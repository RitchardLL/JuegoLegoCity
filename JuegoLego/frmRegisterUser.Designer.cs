namespace JuegoLego
{
    partial class frmRegisterUser
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tUserMail = new JuegoLego.Controles.textUser();
            this.tUserApellidos = new JuegoLego.Controles.textUser();
            this.tUserName = new JuegoLego.Controles.textUser();
            this.tUserRepeatPassword = new JuegoLego.Controles.textUser();
            this.tUserPassword = new JuegoLego.Controles.textUser();
            this.tUserUsuario = new JuegoLego.Controles.textUser();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegister.Location = new System.Drawing.Point(81, 534);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(152, 39);
            this.btnRegister.TabIndex = 22;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::JuegoLego.Properties.Resources._1486564399_close_81512;
            this.pictureBox5.Location = new System.Drawing.Point(306, 11);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 29);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JuegoLego.Properties.Resources.new_user;
            this.pictureBox1.Location = new System.Drawing.Point(53, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // tUserMail
            // 
            this.tUserMail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tUserMail.Location = new System.Drawing.Point(30, 482);
            this.tUserMail.Name = "tUserMail";
            this.tUserMail.Size = new System.Drawing.Size(277, 34);
            this.tUserMail.TabIndex = 28;
            this.tUserMail.Texto = null;
            // 
            // tUserApellidos
            // 
            this.tUserApellidos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tUserApellidos.Location = new System.Drawing.Point(30, 442);
            this.tUserApellidos.Name = "tUserApellidos";
            this.tUserApellidos.Size = new System.Drawing.Size(277, 34);
            this.tUserApellidos.TabIndex = 27;
            this.tUserApellidos.Texto = null;
            this.tUserApellidos.Load += new System.EventHandler(this.tUserApellidos_Load);
            // 
            // tUserName
            // 
            this.tUserName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tUserName.Location = new System.Drawing.Point(30, 402);
            this.tUserName.Name = "tUserName";
            this.tUserName.Size = new System.Drawing.Size(277, 34);
            this.tUserName.TabIndex = 26;
            this.tUserName.Texto = null;
            // 
            // tUserRepeatPassword
            // 
            this.tUserRepeatPassword.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tUserRepeatPassword.Location = new System.Drawing.Point(30, 340);
            this.tUserRepeatPassword.Name = "tUserRepeatPassword";
            this.tUserRepeatPassword.Size = new System.Drawing.Size(277, 34);
            this.tUserRepeatPassword.TabIndex = 25;
            this.tUserRepeatPassword.Texto = null;
            // 
            // tUserPassword
            // 
            this.tUserPassword.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tUserPassword.Location = new System.Drawing.Point(30, 300);
            this.tUserPassword.Name = "tUserPassword";
            this.tUserPassword.Size = new System.Drawing.Size(277, 34);
            this.tUserPassword.TabIndex = 24;
            this.tUserPassword.Texto = null;
            // 
            // tUserUsuario
            // 
            this.tUserUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tUserUsuario.Location = new System.Drawing.Point(30, 260);
            this.tUserUsuario.Name = "tUserUsuario";
            this.tUserUsuario.Size = new System.Drawing.Size(277, 34);
            this.tUserUsuario.TabIndex = 23;
            this.tUserUsuario.Texto = null;
            // 
            // frmRegisterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(350, 600);
            this.Controls.Add(this.tUserMail);
            this.Controls.Add(this.tUserApellidos);
            this.Controls.Add(this.tUserName);
            this.Controls.Add(this.tUserRepeatPassword);
            this.Controls.Add(this.tUserPassword);
            this.Controls.Add(this.tUserUsuario);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegisterUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegisterUser";
            this.Load += new System.EventHandler(this.frmRegisterUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnRegister;
        private Controles.textUser tUserUsuario;
        private Controles.textUser tUserPassword;
        private Controles.textUser tUserName;
        private Controles.textUser tUserRepeatPassword;
        private Controles.textUser tUserApellidos;
        private Controles.textUser tUserMail;
    }
}