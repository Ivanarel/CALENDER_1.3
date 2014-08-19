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
    public partial class FrmMensaje : Form
    {
        private CFunciones.AccionMensaje _Accion;
        public CFunciones.AccionMensaje Accion
        {
            get { return _Accion; }
        } 

        public FrmMensaje()
        {
            InitializeComponent();
        }

        private void cmdPausar_Click(object sender, EventArgs e)
        {
            _Accion = CFunciones.AccionMensaje.Pausar;
            Close(); 
        }

        private void cmdFinalizar_Click(object sender, EventArgs e)
        {
            _Accion = CFunciones.AccionMensaje.Finalizar;
            Close();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            _Accion = CFunciones.AccionMensaje.Cancelar;
            Close();
        }
    }
}
