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
    public partial class FrmTipoEvento : Form
    {
        private DSTipoEventos.DTTipoEventosDataTable DTTipoEventos;
        private bool TiempoPerdido;

        public FrmTipoEvento(bool TiempoPerdido = false)
        {
            InitializeComponent();
            this.TiempoPerdido = TiempoPerdido; 
        }

        private void frmTipoEvento_Load(object sender, EventArgs e)
        {
            DTTipoEventos = DSTipoEventos.Listado();  
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void frmTipoEvento_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != System.Windows.Forms.DialogResult.OK)
                if (MessageBox.Show("¿Está seguro de salir sin guardar?", "Confirmación", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No)
                    e.Cancel = true; 
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            if (ValidaNombre())
            {
                CTipoEvento TipoEvento = new CTipoEvento(txtNombre.Text,TiempoPerdido);
                if (TipoEvento.Guarda())
                {
                    MessageBox.Show("Tpo Evento Guardado", "Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                    MessageBox.Show("No se gurado el tipo de evento, error interno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  
            }
        }

        private bool ValidaNombre()
        {
            Control CtrlError = null;
            ErrorProvider.Clear();
            if (txtNombre.TextLength == 0)
            {
                ErrorProvider.SetError(txtNombre, "Asigne un nombre");
                if (CtrlError == null)
                    CtrlError = txtNombre;
            }
            else if (ExisteEvento(txtNombre.Text))
            {
                ErrorProvider.SetError(txtNombre, "Ya existe un evento con el mismo nombre");
                if (CtrlError == null)
                    CtrlError = txtNombre;
            }
            if (CtrlError != null)
            {
                CtrlError.Focus();
                return false; 
            }
            return true;
        }

        private bool ExisteEvento(string Nombre)
        {
            try {
                if (DTTipoEventos.Select("Nombre = '" + Nombre + "'").Length > 0)
                    return true; 
            }
            catch (Exception exc) { }
            return false ;
        }

    }
}
