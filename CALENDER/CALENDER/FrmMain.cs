using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CALENDER
{
    public partial class FrmMain : Form
    {
        private COrden Orden;
        private int ContDN;
        private string TextoIniciar;
        private string TextoFinalizar ;
        private TimeSpan TiempoRango1;
        private TimeSpan TiempoRango2;
        private string TextoIniciarNuevo;
        private DSTipoEventos.DTTipoEventosDataTable DTTiposEventos; 

        public FrmMain()
        {
            InitializeComponent();
            ContDN = 1;
            TextoIniciar = "Iniciar";
            TextoFinalizar = "Finalizar";
            TextoIniciarNuevo = "Iniciar Nuevo";
            cmdInicioFin.Tag = true; 
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            CFunciones.IniciaConexion();
            DTTiposEventos = DSTipoEventos.Listado();
            timer.Start();
        }

        private void PausarOrden()
        {
            Orden.Pausa();
            VistaTerminaOrden(); 
        }

        private void FinalizaOrden()
        {
            if (Orden.ComienzaNuevoEvento((int)CFunciones.Evento.Fin) == false)
                MessageBox.Show("Error al crear orden", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Orden.Finaliza();
                VistaTerminaOrden();
            }
        }

        private void IniciaNuevaOrden()
        {
            Orden = new COrden(txtOrdenActual.Text);
            if (Orden.IniciaOrden() == false)
                MessageBox.Show("Error al crear orden", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                LLanaGridEventos();
        }

        private void LLanaGridEventos()
        {
            CEventos Evento;
            grid.Rows.Clear();  
            for(int i = 0; i < Orden.CountEventos(); i++)
            {
                Evento = Orden.EventoIndex(i);
                if(Evento.Tipo == (int)CFunciones.Evento.D )
                    grid.Rows.Add(NombreEvento((int)Evento.Tipo)+Evento.Numero.ToString(), 
                        Evento.FechaInicio.ToShortTimeString());
                else
                    grid.Rows.Add(NombreEvento((int)Evento.Tipo),Evento.FechaInicio.ToShortTimeString());
            }
        }

        private void ActualizaVista()
        {
            if (Orden != null)
            {
                txtOrdenActual.Text = Orden.Nombre;
                if (Orden.Evento.Tipo != (int)CFunciones.Evento.D)
                    lblNomPasoActual.Text = NombreEvento(Orden.Evento.Tipo);
                else
                    lblNomPasoActual.Text = NombreEvento(Orden.Evento.Tipo) + ContDN.ToString();
                lblNomHoraInicio.Text = Orden.FechaInicio.ToShortTimeString();   
                cmdDN1.Text = "D" + ContDN.ToString();
                lblNomTiempoTransOrden.Text = CFunciones.FomatoCorto(Orden.TiempoTotal);
                ActualizaTiempos();
            }
            else
                cmdDN1.Text = "D1";
        }

        private void ActualizaTiempos()
        {
            if (Orden != null)
            {
                if (Orden.Evento.FechaFin.Year == 1 && Orden.Evento.Tipo != (int)CFunciones.Evento.Fin)
                {                    
                    TiempoRango2 = DateTime.Now.Subtract(Orden.Evento.FechaInicio);
                    lblNomTiempoTransActual.Text = CFunciones.FomatoCorto(TiempoRango2);
                    TiempoRango1 = Orden.TiempoTotal;
                    TiempoRango1 = TiempoRango1.Add(TiempoRango2);
                    lblNomTiempoTransOrden.Text = CFunciones.FomatoCorto(TiempoRango1);
                }
            }
        }

        private void IniciaEstadoBoton()
        {
            if (Orden == null)
            {
                cmdInicioFin.Text = TextoIniciar;
                cmdInicioFin.Tag = true;
            }
            else
            {
                if (!Orden.Terminada())//Ultimo evento no terminado
                {
                    cmdInicioFin.Text = TextoFinalizar;
                    cmdInicioFin.Tag = false;
                }
                else // ultimo evento terminado
                {
                    cmdInicioFin.Text = TextoIniciarNuevo;
                    cmdInicioFin.Tag = true;
                }
            }
        }
        
        private int SiguienteDNumero()
        {
            CEventos Evento;
            int DN = 0;
            for (int i = 0; i < Orden.CountEventos(); i++)
            {
                Evento = Orden.EventoIndex(i);
                if (Evento.Tipo == (int)CFunciones.Evento.D)
                    DN = Evento.Numero;
            }
            return DN+1;
        }

        private bool ClickBotonEvento(int IdTipoEvento, int Numero = 0)
        {
            if (Orden != null)
            {
                if (Orden.ComienzaNuevoEvento(IdTipoEvento, Numero) == false)
                    MessageBox.Show("Error al crear orden", "Error interno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    ActualizaVista();
                    IniciaEstadoBoton();
                    LLanaGridEventos(); 
                    return true;
                }
            }
            else
                MessageBox.Show("Seleccione o cree una orden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  
            return false;
        }

        private bool ClickInicio()
        {
            if (cmdInicioFin.Text == TextoIniciarNuevo)//Cuando se selecciono uno de la lista y ya esta terminado
            {
                LimpiaVista();
                txtOrdenActual.ReadOnly = false;
                Orden = null;
            }
            else
            {
                if (ValidaCampos())
                {
                    ContDN = 1;
                    IniciaNuevaOrden();                                        
                    habilitaBotonesEventos(true);
                    return true;
                }
            }
            return false;
        }

        private string NombreEvento(int IdEvento)
        {
            string Nombre = "";
            if (IdEvento < (int)CFunciones.Evento.SetUp)
                Nombre = ((CFunciones.Evento)IdEvento).ToString();
            else
            {
                try
                { Nombre = DTTiposEventos.Select("IdTipoEvento = " + IdEvento.ToString())[0]["Nombre"].ToString(); }
                catch (Exception exc) { }
            }
            return Nombre;
        }

        private bool TiempoPerdido(int IdTipoEvento)
        {
            bool band = false;
            if (IdTipoEvento < (int)CFunciones.Evento.SetUp && IdTipoEvento >= (int)CFunciones.Evento.Tocador)
                band = true;
            else
            {
                try
                { band = !(bool)DTTiposEventos.Select("IdTipoEvento = " + IdTipoEvento.ToString())[0]["Tipo"]; }
                catch (Exception exc) { }
            }
            return band;
        }

#region Eventos

        private void cmdInicioFin_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if ((bool)cmdInicioFin.Tag)
            {
                if (ClickInicio())
                {
                    txtOrdenActual.ReadOnly = true;
                    cmdDN1.Text = "D1"; 
                }
            }
            else
            {
                FrmMensaje form = new FrmMensaje();
                form.ShowDialog();
                switch (form.Accion)
                {
                    case CFunciones.AccionMensaje.Pausar: PausarOrden();
                        break;
                    case CFunciones.AccionMensaje.Finalizar: FinalizaOrden();
                        ContDN = 1;
                        break;
                    case CFunciones.AccionMensaje.Cancelar:
                        break;
                }
            }
            IniciaEstadoBoton();
            ActualizaVista();
        }

        private void cmdC1_Click(object sender, EventArgs e)
        {
            ClickBotonEvento((int)CFunciones.Evento.C1);
        }

        private void cmdC2_Click(object sender, EventArgs e)
        {
            ClickBotonEvento((int)CFunciones.Evento.C2);
        }

        private void cmdDN1_Click(object sender, EventArgs e)
        {
            if (ClickBotonEvento((int)CFunciones.Evento.D, ContDN))
                CambiaDN();
        }
        
        private void cmdSetup_Click(object sender, EventArgs e)
        {
            FrmTiposEvento form;
            if (Orden != null)
            {
                form = new FrmTiposEvento();
                form.TiempoPerdido = false;
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    ClickBotonEvento(form.IdEvento);
            }
            else
            {
                form = new FrmTiposEvento(false);
                form.TiempoPerdido = false;
                form.ShowDialog(); 
            }
        }

        private void cmdPerdidasTiempo_Click(object sender, EventArgs e)
        {
            FrmTiposEvento form;
            if (Orden != null)
            {
                form = new FrmTiposEvento(true);
                form.TiempoPerdido = true;
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    ClickBotonEvento(form.IdEvento);
            }
            else
            {
                form = new FrmTiposEvento(false);
                form.TiempoPerdido = true;
                form.ShowDialog();
            }
        }

        private void cmdPlacas_Click(object sender, EventArgs e)
        {
            ClickBotonEvento((int)CFunciones.Evento.Placas);
        }

        private void cmdCortes_Click(object sender, EventArgs e)
        {
            ClickBotonEvento((int)CFunciones.Evento.Cortes); 
        }

        private void cmdSalidaTocador_Click(object sender, EventArgs e)
        {
            ClickBotonEvento((int)CFunciones.Evento.Tocador);
        }

        private void cmdComida_Click(object sender, EventArgs e)
        {
            ClickBotonEvento((int)CFunciones.Evento.Comida);
        }

        private void cmdOtro_Click(object sender, EventArgs e)
        {
            ClickBotonEvento((int)CFunciones.Evento.Otro);
        }

        private void cmdOrdenes_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            FrmListadoOrdenes form ;
            if ((bool)cmdInicioFin.Tag == true)
            {
                Cursor.Current = Cursors.WaitCursor;
                form = new FrmListadoOrdenes();
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Orden = new COrden(form.IdOrden);
                    txtOrdenActual.ReadOnly = true;
                    LLanaGridEventos();
                    ContDN = SiguienteDNumero();                    
                    ActualizaVista();
                    if (Orden.Terminada())
                        habilitaBotonesEventos(false);
                    else habilitaBotonesEventos(true);
                    IniciaEstadoBoton();
                    txtOrdenActual.ReadOnly = true;
                }
                Cursor.Current = Cursors.Default;
            }
            else
            {
                form = new FrmListadoOrdenes(false);
                form.ShowDialog(); 
            }                
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ActualizaTiempos();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Orden != null)
            {
                if (Orden.Evento.FechaFin.Year == 1)
                    if (MessageBox.Show("Esta seguro de salir sin finalizar el evento actual", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                        e.Cancel = true; 
            }
        }

#endregion

#region Simples

        private void CambiaDN()
        {
            ContDN++;
            cmdDN1.Text = "D"+ContDN.ToString();
        }

        private bool ValidaCampos()
        {
            Control CtrlError = null;
            errorProvider.Clear();
            if (txtOrdenActual.TextLength == 0)
            {
                errorProvider.SetError(txtOrdenActual, "Asigne un nombre");
                if (CtrlError == null)
                    CtrlError = txtOrdenActual;
            }
            else
            {
                if (DsOrdenes.Orden(txtOrdenActual.Text) != null)
                {
                    errorProvider.SetError(txtOrdenActual, "Ya existe una orden con el mismo nombre");
                    if (CtrlError == null)
                        CtrlError = txtOrdenActual;
                }
            }
            if (CtrlError != null)
            {
                CtrlError.Focus();
                return false;
            }
            return true;
        }

        private void LimpiaVista()
        {
            txtOrdenActual.Text = "OT-";  
            //lblNomHoraFin.Text = "";
            lblNomHoraInicio.Text = "";
            lblNomPasoActual.Text = "";
            lblNomTiempoTransActual.Text = "";
            lblNomTiempoTransOrden.Text = "";
            grid.Rows.Clear();   
        }

        private void habilitaBotonesEventos(bool Habilitar)
        {
            cmdDN1.Enabled = Habilitar;
            cmdC1.Enabled = Habilitar;
            cmdC2.Enabled = Habilitar;
            cmdCortes.Enabled = Habilitar;
            cmdCortes.Enabled = Habilitar;
            cmdPlacas.Enabled = Habilitar;  
        }

        private void VistaTerminaOrden()
        {
            Orden = null;
            LimpiaVista();
            habilitaBotonesEventos(false);
            cmdInicioFin.Enabled = true;
            txtOrdenActual.ReadOnly = false;
        }

#endregion


    }
}
