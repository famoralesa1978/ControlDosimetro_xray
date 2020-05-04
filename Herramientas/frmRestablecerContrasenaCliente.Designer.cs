namespace ControlDosimetro
{
    partial class frmRestablecerContrasenaCliente
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
            this.tbl_Usuario = new System.Windows.Forms.GroupBox();
            this.btn_RestablecerContrasena = new System.Windows.Forms.Button();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Clave = new System.Windows.Forms.TextBox();
            this.lbl_Clave = new System.Windows.Forms.Label();
            this.txt_Clave1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Razon_Social = new System.Windows.Forms.TextBox();
            this.lbl_Razon_Social = new System.Windows.Forms.Label();
            this.txt_run = new System.Windows.Forms.TextBox();
            this.lbl_run = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Id_Personal = new System.Windows.Forms.Label();
            this.btn_Grabar = new System.Windows.Forms.Button();
            this.tbl_Usuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_Usuario
            // 
            this.tbl_Usuario.Controls.Add(this.btn_RestablecerContrasena);
            this.tbl_Usuario.Controls.Add(this.lbl_Email);
            this.tbl_Usuario.Controls.Add(this.txt_Email);
            this.tbl_Usuario.Controls.Add(this.txt_Clave);
            this.tbl_Usuario.Controls.Add(this.lbl_Clave);
            this.tbl_Usuario.Controls.Add(this.txt_Clave1);
            this.tbl_Usuario.Controls.Add(this.label2);
            this.tbl_Usuario.Controls.Add(this.txt_Razon_Social);
            this.tbl_Usuario.Controls.Add(this.lbl_Razon_Social);
            this.tbl_Usuario.Controls.Add(this.txt_run);
            this.tbl_Usuario.Controls.Add(this.lbl_run);
            this.tbl_Usuario.Controls.Add(this.pictureBox1);
            this.tbl_Usuario.Controls.Add(this.lbl_Id_Personal);
            this.tbl_Usuario.Controls.Add(this.btn_Grabar);
            this.tbl_Usuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_Usuario.Location = new System.Drawing.Point(0, 0);
            this.tbl_Usuario.Name = "tbl_Usuario";
            this.tbl_Usuario.Size = new System.Drawing.Size(537, 178);
            this.tbl_Usuario.TabIndex = 0;
            this.tbl_Usuario.TabStop = false;
            this.tbl_Usuario.Text = "Datos";
            // 
            // btn_RestablecerContrasena
            // 
            this.btn_RestablecerContrasena.Location = new System.Drawing.Point(88, 84);
            this.btn_RestablecerContrasena.Name = "btn_RestablecerContrasena";
            this.btn_RestablecerContrasena.Size = new System.Drawing.Size(146, 23);
            this.btn_RestablecerContrasena.TabIndex = 71;
            this.btn_RestablecerContrasena.Text = "Restablecer Contraseña";
            this.btn_RestablecerContrasena.UseVisualStyleBackColor = true;
            this.btn_RestablecerContrasena.Click += new System.EventHandler(this.btn_RestablecerContrasena_Click);
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(10, 63);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(32, 13);
            this.lbl_Email.TabIndex = 70;
            this.lbl_Email.Text = "Email";
            // 
            // txt_Email
            // 
            this.txt_Email.Enabled = false;
            this.txt_Email.Location = new System.Drawing.Point(88, 60);
            this.txt_Email.MaxLength = 100;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(275, 20);
            this.txt_Email.TabIndex = 69;
            // 
            // txt_Clave
            // 
            this.txt_Clave.Enabled = false;
            this.txt_Clave.Location = new System.Drawing.Point(236, 109);
            this.txt_Clave.MaxLength = 100;
            this.txt_Clave.Name = "txt_Clave";
            this.txt_Clave.Size = new System.Drawing.Size(111, 20);
            this.txt_Clave.TabIndex = 68;
            this.txt_Clave.Visible = false;
            // 
            // lbl_Clave
            // 
            this.lbl_Clave.AutoSize = true;
            this.lbl_Clave.Location = new System.Drawing.Point(12, 116);
            this.lbl_Clave.Name = "lbl_Clave";
            this.lbl_Clave.Size = new System.Drawing.Size(34, 13);
            this.lbl_Clave.TabIndex = 67;
            this.lbl_Clave.Text = "Clave";
            // 
            // txt_Clave1
            // 
            this.txt_Clave1.Enabled = false;
            this.txt_Clave1.Location = new System.Drawing.Point(89, 113);
            this.txt_Clave1.MaxLength = 100;
            this.txt_Clave1.Name = "txt_Clave1";
            this.txt_Clave1.PasswordChar = '*';
            this.txt_Clave1.ReadOnly = true;
            this.txt_Clave1.Size = new System.Drawing.Size(132, 20);
            this.txt_Clave1.TabIndex = 66;
            this.txt_Clave1.TextChanged += new System.EventHandler(this.txt_Contraseña1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "Formato: 12345678-9";
            // 
            // txt_Razon_Social
            // 
            this.txt_Razon_Social.Enabled = false;
            this.txt_Razon_Social.Location = new System.Drawing.Point(89, 35);
            this.txt_Razon_Social.MaxLength = 60;
            this.txt_Razon_Social.Name = "txt_Razon_Social";
            this.txt_Razon_Social.Size = new System.Drawing.Size(274, 20);
            this.txt_Razon_Social.TabIndex = 63;
            // 
            // lbl_Razon_Social
            // 
            this.lbl_Razon_Social.AutoSize = true;
            this.lbl_Razon_Social.Location = new System.Drawing.Point(10, 38);
            this.lbl_Razon_Social.Name = "lbl_Razon_Social";
            this.lbl_Razon_Social.Size = new System.Drawing.Size(70, 13);
            this.lbl_Razon_Social.TabIndex = 64;
            this.lbl_Razon_Social.Text = "Razon Social";
            // 
            // txt_run
            // 
            this.txt_run.Location = new System.Drawing.Point(89, 12);
            this.txt_run.MaxLength = 10;
            this.txt_run.Name = "txt_run";
            this.txt_run.Size = new System.Drawing.Size(120, 20);
            this.txt_run.TabIndex = 62;
            this.txt_run.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_run_KeyPress);
            // 
            // lbl_run
            // 
            this.lbl_run.AutoSize = true;
            this.lbl_run.Location = new System.Drawing.Point(10, 15);
            this.lbl_run.Name = "lbl_run";
            this.lbl_run.Size = new System.Drawing.Size(24, 13);
            this.lbl_run.TabIndex = 61;
            this.lbl_run.Text = "Rut";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ControlDosimetro.Properties.Resources.CambioContrasenaCliente;
            this.pictureBox1.Location = new System.Drawing.Point(369, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Id_Personal
            // 
            this.lbl_Id_Personal.AutoSize = true;
            this.lbl_Id_Personal.Location = new System.Drawing.Point(163, 88);
            this.lbl_Id_Personal.Name = "lbl_Id_Personal";
            this.lbl_Id_Personal.Size = new System.Drawing.Size(0, 13);
            this.lbl_Id_Personal.TabIndex = 47;
            // 
            // btn_Grabar
            // 
            this.btn_Grabar.Location = new System.Drawing.Point(89, 141);
            this.btn_Grabar.Name = "btn_Grabar";
            this.btn_Grabar.Size = new System.Drawing.Size(125, 23);
            this.btn_Grabar.TabIndex = 12;
            this.btn_Grabar.Text = "Enviar Contraseña";
            this.btn_Grabar.UseVisualStyleBackColor = true;
            this.btn_Grabar.Click += new System.EventHandler(this.btn_Grabar_Click);
            // 
            // frmRestablecerContrasenaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 178);
            this.Controls.Add(this.tbl_Usuario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRestablecerContrasenaCliente";
            this.Text = "Restablecer contraseña cliente";
            this.tbl_Usuario.ResumeLayout(false);
            this.tbl_Usuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox tbl_Usuario;
        private System.Windows.Forms.Button btn_Grabar;
                                private System.Windows.Forms.Label lbl_Id_Personal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Razon_Social;
        private System.Windows.Forms.Label lbl_Razon_Social;
        private System.Windows.Forms.TextBox txt_run;
        private System.Windows.Forms.Label lbl_run;
        private System.Windows.Forms.TextBox txt_Clave;
        private System.Windows.Forms.Label lbl_Clave;
        private System.Windows.Forms.TextBox txt_Clave1;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Button btn_RestablecerContrasena;
    }
}