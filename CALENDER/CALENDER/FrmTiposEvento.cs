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
    public partial class FrmTiposEvento : Form
    {
        private  int _IdTipoEvento;
        public int IdEvento { get { return _IdTipoEvento; } }
        public bool TiempoPerdido;

        public FrmTiposEvento(bool Seleccionar = true)
        {
            InitializeComponent();
            if (Seleccionar == false)
                cmdAceptar.Visible = false; 
        }

        private void FrmTiposEvento_Load(object sender, EventArgs e)
        {
            llenaTiposEventos();
        }

        private void llenaTiposEventos()
        {
            grid.Rows.Clear();  
            DSTipoEventos.DTTipoEventosDataTable DTTipos = DSTipoEventos.Listado(); 
            foreach(DSTipoEventos.DTTipoEventosRow Tipo in DTTipos.Rows)
                if(TiempoPerdido)
                {
                    if (Tipo.Tipo == false)
                        grid.Rows.Add(Tipo.IdTipoEvento, Tipo.Nombre);
                }
                else
                {
                    if (Tipo.Tipo == true)
                        grid.Rows.Add(Tipo.IdTipoEvento, Tipo.Nombre);
                }
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            try { 
             if (grid.CurrentRow.Index != -1)
                 _IdTipoEvento = int.Parse(grid.CurrentRow.Cells[colId.Name].Value.ToString());
             DialogResult = System.Windows.Forms.DialogResult.OK; 
            }
            catch (Exception exc) 
            {
                MessageBox.Show("Seleccione un tipo", "", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            } 
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            FrmTipoEvento Form = new FrmTipoEvento(TiempoPerdido);
            if (Form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                llenaTiposEventos(); 
        }

    }
}
