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
    public partial class FrmListadoOrdenes : Form
    {
        private  int _Orden;
        private DSTipoEventos.DTTipoEventosDataTable DTTiposEventos; 

        public int IdOrden
        { get { return _Orden; } }

        public FrmListadoOrdenes(bool Seleccionar = true)
        {
            InitializeComponent();
            if (Seleccionar == false)
                cmdSeleccionar.Visible = false; 
        }

        private void FrmListadoOrdenes_Load(object sender, EventArgs e)
        {
            DTTiposEventos = DSTipoEventos.Listado(); 
            llenaListado();
        }

        private void llenaListado()
        {
            DsOrdenes.DtOrdenesDataTable DTOrdenes;
            DTOrdenes = DsOrdenes.ListadoOrdenes(dtFecha.Value);
            DSEventos.DTEventosDataTable DTEventos;
            int i = 0;
            string FechaIni = "";
            string FechaFin = "";
            tv.Nodes.Clear();
            Cursor.Current = Cursors.WaitCursor;
            foreach (DsOrdenes.DtOrdenesRow DROrden in DTOrdenes)
            {
                tv.Nodes.Add(DROrden.Nombre);
                DTEventos = DSEventos.ListadoEventos(DROrden.IdOrden);
                FechaIni = "";
                FechaFin = "";
                foreach (DSEventos.DTEventosRow DREvento in DTEventos)
                {
                    if((CFunciones.Evento)DREvento.Tipo ==  CFunciones.Evento.Iniciado )
                        FechaIni = DREvento.FechaInicio.ToShortDateString();
                    if ((CFunciones.Evento)DREvento.Tipo == CFunciones.Evento.Fin)
                        FechaFin = DREvento.FechaFin.ToShortDateString();
                    if ((CFunciones.Evento)DREvento.Tipo == CFunciones.Evento.D)
                        tv.Nodes[i].Nodes.Add("D"+DREvento.Numero.ToString() 
                            + " " + DREvento.FechaInicio.ToShortTimeString());                
                    else
                    {
                        tv.Nodes[i].Nodes.Add(NombreEvento(DREvento.Tipo) + " " +
                            DREvento.FechaInicio.ToShortTimeString()); 
                    }    
                }
                tv.Nodes[i].Tag = DROrden.IdOrden;
                tv.Nodes[i].Text = DROrden.Nombre + " " + FechaIni; 
                if(FechaFin.Length > 0)
                    tv.Nodes[i].Text += " - " + FechaFin;
                i++;
            }
            Cursor.Current = Cursors.Default;
        }

        private string NombreEvento(int IdEvento)
        {
            string Nombre = "";
            if (IdEvento < (int)CFunciones.Evento.SetUp)
                Nombre = ((CFunciones.Evento)IdEvento).ToString();
            else
            {
                try{
                    Nombre = DTTiposEventos.Select("IdTipoEvento = " + IdEvento.ToString())[0]["Nombre"].ToString();
                }
                catch(Exception exc){}
            }
            return Nombre;
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel; 
        }

        private void cmdSeleccionar_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK; 
        }

        private void tv_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tv.SelectedNode.Parent == null)
                _Orden = (int)tv.SelectedNode.Tag; 
        }

        private void dtFecha_CloseUp(object sender, EventArgs e)
        {
            llenaListado(); 
        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            FrmReporte form = new FrmReporte(dtFecha.Value);
            form.ShowDialog(); 
        }

    }
}
