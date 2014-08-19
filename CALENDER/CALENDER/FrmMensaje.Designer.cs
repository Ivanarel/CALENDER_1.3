namespace CALENDER
{
    partial class FrmMensaje
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
            this.cmdPausar = new System.Windows.Forms.Button();
            this.cmdFinalizar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdPausar
            // 
            this.cmdPausar.Location = new System.Drawing.Point(12, 12);
            this.cmdPausar.Name = "cmdPausar";
            this.cmdPausar.Size = new System.Drawing.Size(75, 23);
            this.cmdPausar.TabIndex = 1;
            this.cmdPausar.Text = "Pausar";
            this.cmdPausar.UseVisualStyleBackColor = true;
            this.cmdPausar.Click += new System.EventHandler(this.cmdPausar_Click);
            // 
            // cmdFinalizar
            // 
            this.cmdFinalizar.Location = new System.Drawing.Point(93, 12);
            this.cmdFinalizar.Name = "cmdFinalizar";
            this.cmdFinalizar.Size = new System.Drawing.Size(75, 23);
            this.cmdFinalizar.TabIndex = 0;
            this.cmdFinalizar.Text = "Finalizar";
            this.cmdFinalizar.UseVisualStyleBackColor = true;
            this.cmdFinalizar.Click += new System.EventHandler(this.cmdFinalizar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(174, 12);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(75, 23);
            this.cmdCancelar.TabIndex = 2;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // frmMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 46);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdFinalizar);
            this.Controls.Add(this.cmdPausar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMensaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdPausar;
        private System.Windows.Forms.Button cmdFinalizar;
        private System.Windows.Forms.Button cmdCancelar;
    }
}