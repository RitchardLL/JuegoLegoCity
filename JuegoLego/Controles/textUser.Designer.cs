namespace JuegoLego.Controles
{
    partial class textUser
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTexto = new System.Windows.Forms.Panel();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pnlTexto
            // 
            this.pnlTexto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlTexto.Location = new System.Drawing.Point(3, 28);
            this.pnlTexto.Name = "pnlTexto";
            this.pnlTexto.Size = new System.Drawing.Size(272, 3);
            this.pnlTexto.TabIndex = 7;
            // 
            // txtTexto
            // 
            this.txtTexto.BackColor = System.Drawing.SystemColors.Control;
            this.txtTexto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexto.ForeColor = System.Drawing.Color.Gray;
            this.txtTexto.HideSelection = false;
            this.txtTexto.Location = new System.Drawing.Point(5, 5);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(267, 23);
            this.txtTexto.TabIndex = 6;
            this.txtTexto.TabStop = false;
            this.txtTexto.Text = "UserName";
            this.txtTexto.Enter += new System.EventHandler(this.txtTexto_Enter);
            this.txtTexto.Leave += new System.EventHandler(this.txtTexto_Leave);
            // 
            // textUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.pnlTexto);
            this.Controls.Add(this.txtTexto);
            this.Name = "textUser";
            this.Size = new System.Drawing.Size(277, 34);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTexto;
        private System.Windows.Forms.TextBox txtTexto;
    }
}
