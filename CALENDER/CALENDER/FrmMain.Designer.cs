namespace CALENDER
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cmdOrdenes = new System.Windows.Forms.Button();
            this.PanelBotones = new System.Windows.Forms.Panel();
            this.cmdPerdidasTiempo = new System.Windows.Forms.Button();
            this.cmdInicioFin = new System.Windows.Forms.Button();
            this.cmdSetup = new System.Windows.Forms.Button();
            this.cmdC2 = new System.Windows.Forms.Button();
            this.cmdC1 = new System.Windows.Forms.Button();
            this.cmdDN1 = new System.Windows.Forms.Button();
            this.cmdPlacas = new System.Windows.Forms.Button();
            this.cmdCortes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.txtOrdenActual = new System.Windows.Forms.TextBox();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.lblNomTiempoTransActual = new System.Windows.Forms.Label();
            this.lblNomTiempoTransOrden = new System.Windows.Forms.Label();
            this.lblTiempoPaso = new System.Windows.Forms.Label();
            this.lblTiempoOrden = new System.Windows.Forms.Label();
            this.lblNomHoraInicio = new System.Windows.Forms.Label();
            this.lblNomPasoActual = new System.Windows.Forms.Label();
            this.lblPasoActual = new System.Windows.Forms.Label();
            this.lblOredenActual = new System.Windows.Forms.Label();
            this.colEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.PanelBotones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // cmdOrdenes
            // 
            this.cmdOrdenes.ForeColor = System.Drawing.Color.Black;
            this.cmdOrdenes.Location = new System.Drawing.Point(864, 5);
            this.cmdOrdenes.Name = "cmdOrdenes";
            this.cmdOrdenes.Size = new System.Drawing.Size(138, 27);
            this.cmdOrdenes.TabIndex = 22;
            this.cmdOrdenes.Text = "Listado de Órdenes";
            this.cmdOrdenes.UseVisualStyleBackColor = true;
            this.cmdOrdenes.Click += new System.EventHandler(this.cmdOrdenes_Click);
            // 
            // PanelBotones
            // 
            this.PanelBotones.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelBotones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelBotones.Controls.Add(this.cmdPerdidasTiempo);
            this.PanelBotones.Controls.Add(this.cmdInicioFin);
            this.PanelBotones.Controls.Add(this.cmdSetup);
            this.PanelBotones.Controls.Add(this.cmdC2);
            this.PanelBotones.Controls.Add(this.cmdC1);
            this.PanelBotones.Controls.Add(this.cmdDN1);
            this.PanelBotones.Controls.Add(this.cmdPlacas);
            this.PanelBotones.Controls.Add(this.cmdCortes);
            this.PanelBotones.Location = new System.Drawing.Point(12, 349);
            this.PanelBotones.Name = "PanelBotones";
            this.PanelBotones.Size = new System.Drawing.Size(990, 300);
            this.PanelBotones.TabIndex = 27;
            // 
            // cmdPerdidasTiempo
            // 
            this.cmdPerdidasTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPerdidasTiempo.ForeColor = System.Drawing.Color.Black;
            this.cmdPerdidasTiempo.Location = new System.Drawing.Point(756, 162);
            this.cmdPerdidasTiempo.Name = "cmdPerdidasTiempo";
            this.cmdPerdidasTiempo.Size = new System.Drawing.Size(211, 117);
            this.cmdPerdidasTiempo.TabIndex = 29;
            this.cmdPerdidasTiempo.Text = "Pérdidas";
            this.cmdPerdidasTiempo.UseVisualStyleBackColor = true;
            this.cmdPerdidasTiempo.Click += new System.EventHandler(this.cmdPerdidasTiempo_Click);
            // 
            // cmdInicioFin
            // 
            this.cmdInicioFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdInicioFin.ForeColor = System.Drawing.Color.Black;
            this.cmdInicioFin.Location = new System.Drawing.Point(15, 18);
            this.cmdInicioFin.Name = "cmdInicioFin";
            this.cmdInicioFin.Size = new System.Drawing.Size(211, 117);
            this.cmdInicioFin.TabIndex = 16;
            this.cmdInicioFin.Text = "Iniciar";
            this.cmdInicioFin.UseVisualStyleBackColor = true;
            this.cmdInicioFin.Click += new System.EventHandler(this.cmdInicioFin_Click);
            // 
            // cmdSetup
            // 
            this.cmdSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSetup.ForeColor = System.Drawing.Color.Black;
            this.cmdSetup.Location = new System.Drawing.Point(756, 18);
            this.cmdSetup.Name = "cmdSetup";
            this.cmdSetup.Size = new System.Drawing.Size(211, 117);
            this.cmdSetup.TabIndex = 28;
            this.cmdSetup.Text = "Setup";
            this.cmdSetup.UseVisualStyleBackColor = true;
            this.cmdSetup.Click += new System.EventHandler(this.cmdSetup_Click);
            // 
            // cmdC2
            // 
            this.cmdC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdC2.ForeColor = System.Drawing.Color.Black;
            this.cmdC2.Location = new System.Drawing.Point(262, 18);
            this.cmdC2.Name = "cmdC2";
            this.cmdC2.Size = new System.Drawing.Size(211, 117);
            this.cmdC2.TabIndex = 11;
            this.cmdC2.Text = "C2";
            this.cmdC2.UseVisualStyleBackColor = true;
            this.cmdC2.Click += new System.EventHandler(this.cmdC2_Click);
            // 
            // cmdC1
            // 
            this.cmdC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdC1.ForeColor = System.Drawing.Color.Black;
            this.cmdC1.Location = new System.Drawing.Point(15, 162);
            this.cmdC1.Name = "cmdC1";
            this.cmdC1.Size = new System.Drawing.Size(211, 117);
            this.cmdC1.TabIndex = 8;
            this.cmdC1.Text = "C1";
            this.cmdC1.UseVisualStyleBackColor = true;
            this.cmdC1.Click += new System.EventHandler(this.cmdC1_Click);
            // 
            // cmdDN1
            // 
            this.cmdDN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDN1.ForeColor = System.Drawing.Color.Black;
            this.cmdDN1.Location = new System.Drawing.Point(262, 162);
            this.cmdDN1.Name = "cmdDN1";
            this.cmdDN1.Size = new System.Drawing.Size(211, 117);
            this.cmdDN1.TabIndex = 9;
            this.cmdDN1.Text = "D1";
            this.cmdDN1.UseVisualStyleBackColor = true;
            this.cmdDN1.Click += new System.EventHandler(this.cmdDN1_Click);
            // 
            // cmdPlacas
            // 
            this.cmdPlacas.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPlacas.ForeColor = System.Drawing.Color.Black;
            this.cmdPlacas.Location = new System.Drawing.Point(509, 18);
            this.cmdPlacas.Name = "cmdPlacas";
            this.cmdPlacas.Size = new System.Drawing.Size(211, 117);
            this.cmdPlacas.TabIndex = 14;
            this.cmdPlacas.Text = "Placas";
            this.cmdPlacas.UseVisualStyleBackColor = true;
            this.cmdPlacas.Click += new System.EventHandler(this.cmdPlacas_Click);
            // 
            // cmdCortes
            // 
            this.cmdCortes.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCortes.ForeColor = System.Drawing.Color.Black;
            this.cmdCortes.Location = new System.Drawing.Point(509, 162);
            this.cmdCortes.Name = "cmdCortes";
            this.cmdCortes.Size = new System.Drawing.Size(211, 117);
            this.cmdCortes.TabIndex = 15;
            this.cmdCortes.Text = "Cortes";
            this.cmdCortes.UseVisualStyleBackColor = true;
            this.cmdCortes.Click += new System.EventHandler(this.cmdCortes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grid);
            this.groupBox1.Controls.Add(this.txtOrdenActual);
            this.groupBox1.Controls.Add(this.lblHoraInicio);
            this.groupBox1.Controls.Add(this.lblNomTiempoTransActual);
            this.groupBox1.Controls.Add(this.lblNomTiempoTransOrden);
            this.groupBox1.Controls.Add(this.lblTiempoPaso);
            this.groupBox1.Controls.Add(this.lblTiempoOrden);
            this.groupBox1.Controls.Add(this.lblNomHoraInicio);
            this.groupBox1.Controls.Add(this.lblNomPasoActual);
            this.groupBox1.Controls.Add(this.lblPasoActual);
            this.groupBox1.Controls.Add(this.lblOredenActual);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(990, 313);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeColumns = false;
            this.grid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.colEvento,
            this.colHoraInicio});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle5;
            this.grid.Location = new System.Drawing.Point(657, 19);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(312, 282);
            this.grid.TabIndex = 32;
            // 
            // txtOrdenActual
            // 
            this.txtOrdenActual.BackColor = System.Drawing.Color.DarkCyan;
            this.txtOrdenActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrdenActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtOrdenActual.Location = new System.Drawing.Point(315, 19);
            this.txtOrdenActual.MaxLength = 10;
            this.txtOrdenActual.Name = "txtOrdenActual";
            this.txtOrdenActual.Size = new System.Drawing.Size(310, 62);
            this.txtOrdenActual.TabIndex = 31;
            this.txtOrdenActual.Text = "OT-";
            this.txtOrdenActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraInicio.Location = new System.Drawing.Point(10, 139);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(299, 52);
            this.lblHoraInicio.TabIndex = 30;
            this.lblHoraInicio.Text = "Hora Inicio";
            this.lblHoraInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNomTiempoTransActual
            // 
            this.lblNomTiempoTransActual.BackColor = System.Drawing.Color.SteelBlue;
            this.lblNomTiempoTransActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomTiempoTransActual.ForeColor = System.Drawing.Color.White;
            this.lblNomTiempoTransActual.Location = new System.Drawing.Point(315, 251);
            this.lblNomTiempoTransActual.Name = "lblNomTiempoTransActual";
            this.lblNomTiempoTransActual.Size = new System.Drawing.Size(310, 50);
            this.lblNomTiempoTransActual.TabIndex = 29;
            this.lblNomTiempoTransActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNomTiempoTransOrden
            // 
            this.lblNomTiempoTransOrden.BackColor = System.Drawing.Color.SteelBlue;
            this.lblNomTiempoTransOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomTiempoTransOrden.ForeColor = System.Drawing.Color.White;
            this.lblNomTiempoTransOrden.Location = new System.Drawing.Point(315, 196);
            this.lblNomTiempoTransOrden.Name = "lblNomTiempoTransOrden";
            this.lblNomTiempoTransOrden.Size = new System.Drawing.Size(310, 50);
            this.lblNomTiempoTransOrden.TabIndex = 28;
            this.lblNomTiempoTransOrden.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTiempoPaso
            // 
            this.lblTiempoPaso.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoPaso.Location = new System.Drawing.Point(10, 249);
            this.lblTiempoPaso.Name = "lblTiempoPaso";
            this.lblTiempoPaso.Size = new System.Drawing.Size(299, 52);
            this.lblTiempoPaso.TabIndex = 27;
            this.lblTiempoPaso.Text = "Tiempo paso actual";
            this.lblTiempoPaso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTiempoOrden
            // 
            this.lblTiempoOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoOrden.Location = new System.Drawing.Point(10, 194);
            this.lblTiempoOrden.Name = "lblTiempoOrden";
            this.lblTiempoOrden.Size = new System.Drawing.Size(299, 52);
            this.lblTiempoOrden.TabIndex = 26;
            this.lblTiempoOrden.Text = "Tiempo Orden";
            this.lblTiempoOrden.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNomHoraInicio
            // 
            this.lblNomHoraInicio.BackColor = System.Drawing.Color.SteelBlue;
            this.lblNomHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomHoraInicio.ForeColor = System.Drawing.Color.White;
            this.lblNomHoraInicio.Location = new System.Drawing.Point(315, 141);
            this.lblNomHoraInicio.Name = "lblNomHoraInicio";
            this.lblNomHoraInicio.Size = new System.Drawing.Size(310, 50);
            this.lblNomHoraInicio.TabIndex = 25;
            this.lblNomHoraInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNomPasoActual
            // 
            this.lblNomPasoActual.BackColor = System.Drawing.Color.SteelBlue;
            this.lblNomPasoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomPasoActual.ForeColor = System.Drawing.Color.White;
            this.lblNomPasoActual.Location = new System.Drawing.Point(315, 86);
            this.lblNomPasoActual.Name = "lblNomPasoActual";
            this.lblNomPasoActual.Size = new System.Drawing.Size(310, 50);
            this.lblNomPasoActual.TabIndex = 24;
            this.lblNomPasoActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPasoActual
            // 
            this.lblPasoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasoActual.Location = new System.Drawing.Point(10, 84);
            this.lblPasoActual.Name = "lblPasoActual";
            this.lblPasoActual.Size = new System.Drawing.Size(299, 52);
            this.lblPasoActual.TabIndex = 23;
            this.lblPasoActual.Text = "Paso Actual";
            this.lblPasoActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOredenActual
            // 
            this.lblOredenActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOredenActual.Location = new System.Drawing.Point(10, 29);
            this.lblOredenActual.Name = "lblOredenActual";
            this.lblOredenActual.Size = new System.Drawing.Size(299, 52);
            this.lblOredenActual.TabIndex = 22;
            this.lblOredenActual.Text = "Orden Actual";
            this.lblOredenActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colEvento
            // 
            this.colEvento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colEvento.DefaultCellStyle = dataGridViewCellStyle3;
            this.colEvento.HeaderText = "Evento";
            this.colEvento.Name = "colEvento";
            this.colEvento.ReadOnly = true;
            // 
            // colHoraInicio
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colHoraInicio.DefaultCellStyle = dataGridViewCellStyle4;
            this.colHoraInicio.HeaderText = "Inicio";
            this.colHoraInicio.Name = "colHoraInicio";
            this.colHoraInicio.ReadOnly = true;
            this.colHoraInicio.Width = 150;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1014, 659);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PanelBotones);
            this.Controls.Add(this.cmdOrdenes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALENDER";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.PanelBotones.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button cmdOrdenes;
        private System.Windows.Forms.Panel PanelBotones;
        private System.Windows.Forms.Button cmdPerdidasTiempo;
        private System.Windows.Forms.Button cmdInicioFin;
        private System.Windows.Forms.Button cmdSetup;
        private System.Windows.Forms.Button cmdC2;
        private System.Windows.Forms.Button cmdC1;
        private System.Windows.Forms.Button cmdDN1;
        private System.Windows.Forms.Button cmdPlacas;
        private System.Windows.Forms.Button cmdCortes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.TextBox txtOrdenActual;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.Label lblNomTiempoTransActual;
        private System.Windows.Forms.Label lblNomTiempoTransOrden;
        private System.Windows.Forms.Label lblTiempoPaso;
        private System.Windows.Forms.Label lblTiempoOrden;
        private System.Windows.Forms.Label lblNomHoraInicio;
        private System.Windows.Forms.Label lblNomPasoActual;
        private System.Windows.Forms.Label lblPasoActual;
        private System.Windows.Forms.Label lblOredenActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoraInicio;
    }
}

