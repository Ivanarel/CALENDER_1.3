namespace CALENDER
{
    partial class FrmTiposEvento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdAceptar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.gbOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeColumns = false;
            this.grid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNombre});
            this.grid.Location = new System.Drawing.Point(12, 75);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.Size = new System.Drawing.Size(244, 202);
            this.grid.TabIndex = 27;
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colNombre
            // 
            this.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colNombre.DefaultCellStyle = dataGridViewCellStyle3;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Location = new System.Drawing.Point(12, 283);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(90, 30);
            this.cmdAceptar.TabIndex = 28;
            this.cmdAceptar.Text = "Aceptar";
            this.cmdAceptar.UseVisualStyleBackColor = true;
            this.cmdAceptar.Click += new System.EventHandler(this.cmdAceptar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(166, 283);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(90, 30);
            this.cmdCancelar.TabIndex = 29;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.cmdEliminar);
            this.gbOpciones.Controls.Add(this.cmdAgregar);
            this.gbOpciones.Location = new System.Drawing.Point(12, 12);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(111, 57);
            this.gbOpciones.TabIndex = 30;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Opciones";
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(57, 19);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(36, 30);
            this.cmdEliminar.TabIndex = 32;
            this.cmdEliminar.Text = "-";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(15, 19);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(36, 30);
            this.cmdAgregar.TabIndex = 31;
            this.cmdAgregar.Text = "+";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // FrmTiposEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 323);
            this.Controls.Add(this.gbOpciones);
            this.Controls.Add(this.cmdAceptar);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTiposEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos Eventos";
            this.Load += new System.EventHandler(this.FrmTiposEvento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.gbOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button cmdAceptar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdAgregar;
    }
}