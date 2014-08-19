namespace CALENDER
{
    partial class FrmListadoOrdenes
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
            this.tv = new System.Windows.Forms.TreeView();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdSeleccionar = new System.Windows.Forms.Button();
            this.gbFecha = new System.Windows.Forms.GroupBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.cmdImprimir = new System.Windows.Forms.Button();
            this.gbFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // tv
            // 
            this.tv.Location = new System.Drawing.Point(13, 69);
            this.tv.Name = "tv";
            this.tv.Size = new System.Drawing.Size(270, 287);
            this.tv.TabIndex = 0;
            this.tv.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_AfterSelect);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(193, 362);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(90, 30);
            this.cmdCancelar.TabIndex = 17;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdSeleccionar
            // 
            this.cmdSeleccionar.Location = new System.Drawing.Point(12, 362);
            this.cmdSeleccionar.Name = "cmdSeleccionar";
            this.cmdSeleccionar.Size = new System.Drawing.Size(90, 30);
            this.cmdSeleccionar.TabIndex = 16;
            this.cmdSeleccionar.Text = "Seleccionar";
            this.cmdSeleccionar.UseVisualStyleBackColor = true;
            this.cmdSeleccionar.Click += new System.EventHandler(this.cmdSeleccionar_Click);
            // 
            // gbFecha
            // 
            this.gbFecha.Controls.Add(this.dtFecha);
            this.gbFecha.Location = new System.Drawing.Point(13, 12);
            this.gbFecha.Name = "gbFecha";
            this.gbFecha.Size = new System.Drawing.Size(228, 51);
            this.gbFecha.TabIndex = 18;
            this.gbFecha.TabStop = false;
            this.gbFecha.Text = "Peródo";
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(6, 19);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(211, 20);
            this.dtFecha.TabIndex = 0;
            this.dtFecha.CloseUp += new System.EventHandler(this.dtFecha_CloseUp);
            // 
            // cmdImprimir
            // 
            this.cmdImprimir.Location = new System.Drawing.Point(247, 23);
            this.cmdImprimir.Name = "cmdImprimir";
            this.cmdImprimir.Size = new System.Drawing.Size(36, 35);
            this.cmdImprimir.TabIndex = 19;
            this.cmdImprimir.Text = "Imp.";
            this.cmdImprimir.UseVisualStyleBackColor = true;
            this.cmdImprimir.Click += new System.EventHandler(this.cmdImprimir_Click);
            // 
            // FrmListadoOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 402);
            this.Controls.Add(this.cmdImprimir);
            this.Controls.Add(this.gbFecha);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdSeleccionar);
            this.Controls.Add(this.tv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListadoOrdenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Ordenes";
            this.Load += new System.EventHandler(this.FrmListadoOrdenes_Load);
            this.gbFecha.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tv;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdSeleccionar;
        private System.Windows.Forms.GroupBox gbFecha;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Button cmdImprimir;
    }
}