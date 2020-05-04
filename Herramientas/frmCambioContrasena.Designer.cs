namespace ControlDosimetro
{
    partial class frmCambioContrasena
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
            this.lbl_Id_Usuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.txt_Contraseña1 = new System.Windows.Forms.TextBox();
            this.txt_ContrasenaActual = new System.Windows.Forms.TextBox();
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.lbl_Id_Personal = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.btn_Grabar = new System.Windows.Forms.Button();
            this.tbl_Usuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_Usuario
            // 
            this.tbl_Usuario.Controls.Add(this.lbl_Id_Usuario);
            this.tbl_Usuario.Controls.Add(this.pictureBox1);
            this.tbl_Usuario.Controls.Add(this.txt_Contraseña);
            this.tbl_Usuario.Controls.Add(this.txt_Contraseña1);
            this.tbl_Usuario.Controls.Add(this.txt_ContrasenaActual);
            this.tbl_Usuario.Controls.Add(this.lbl_Contraseña);
            this.tbl_Usuario.Controls.Add(this.lbl_Id_Personal);
            this.tbl_Usuario.Controls.Add(this.lbl_Usuario);
            this.tbl_Usuario.Controls.Add(this.btn_Grabar);
            this.tbl_Usuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_Usuario.Location = new System.Drawing.Point(0, 0);
            this.tbl_Usuario.Name = "tbl_Usuario";
            this.tbl_Usuario.Size = new System.Drawing.Size(537, 159);
            this.tbl_Usuario.TabIndex = 0;
            this.tbl_Usuario.TabStop = false;
            this.tbl_Usuario.Text = "Datos";
            // 
            // lbl_Id_Usuario
            // 
            this.lbl_Id_Usuario.AutoSize = true;
            this.lbl_Id_Usuario.Location = new System.Drawing.Point(14, 75);
            this.lbl_Id_Usuario.Name = "lbl_Id_Usuario";
            this.lbl_Id_Usuario.Size = new System.Drawing.Size(58, 13);
            this.lbl_Id_Usuario.TabIndex = 60;
            this.lbl_Id_Usuario.Text = "N° Usuario";
            this.lbl_Id_Usuario.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ControlDosimetro.Properties.Resources.CambioContrasena;
            this.pictureBox1.Location = new System.Drawing.Point(369, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Location = new System.Drawing.Point(167, 68);
            this.txt_Contraseña.MaxLength = 100;
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.Size = new System.Drawing.Size(86, 20);
            this.txt_Contraseña.TabIndex = 58;
            this.txt_Contraseña.Visible = false;
            // 
            // txt_Contraseña1
            // 
            this.txt_Contraseña1.Location = new System.Drawing.Point(167, 42);
            this.txt_Contraseña1.MaxLength = 100;
            this.txt_Contraseña1.Name = "txt_Contraseña1";
            this.txt_Contraseña1.PasswordChar = '*';
            this.txt_Contraseña1.Size = new System.Drawing.Size(184, 20);
            this.txt_Contraseña1.TabIndex = 57;
            this.txt_Contraseña1.TextChanged += new System.EventHandler(this.txt_Contraseña1_TextChanged);
            // 
            // txt_ContrasenaActual
            // 
            this.txt_ContrasenaActual.Location = new System.Drawing.Point(167, 17);
            this.txt_ContrasenaActual.MaxLength = 10;
            this.txt_ContrasenaActual.Name = "txt_ContrasenaActual";
            this.txt_ContrasenaActual.Size = new System.Drawing.Size(184, 20);
            this.txt_ContrasenaActual.TabIndex = 56;
            // 
            // lbl_Contraseña
            // 
            this.lbl_Contraseña.AutoSize = true;
            this.lbl_Contraseña.Location = new System.Drawing.Point(11, 49);
            this.lbl_Contraseña.Name = "lbl_Contraseña";
            this.lbl_Contraseña.Size = new System.Drawing.Size(93, 13);
            this.lbl_Contraseña.TabIndex = 55;
            this.lbl_Contraseña.Text = "Contraseña actual";
            // 
            // lbl_Id_Personal
            // 
            this.lbl_Id_Personal.AutoSize = true;
            this.lbl_Id_Personal.Location = new System.Drawing.Point(164, 22);
            this.lbl_Id_Personal.Name = "lbl_Id_Personal";
            this.lbl_Id_Personal.Size = new System.Drawing.Size(0, 13);
            this.lbl_Id_Personal.TabIndex = 47;
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(13, 22);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(99, 13);
            this.lbl_Usuario.TabIndex = 45;
            this.lbl_Usuario.Text = "Contraseña anterior";
            // 
            // btn_Grabar
            // 
            this.btn_Grabar.Location = new System.Drawing.Point(104, 100);
            this.btn_Grabar.Name = "btn_Grabar";
            this.btn_Grabar.Size = new System.Drawing.Size(125, 23);
            this.btn_Grabar.TabIndex = 12;
            this.btn_Grabar.Text = "Cambiar contraseña";
            this.btn_Grabar.UseVisualStyleBackColor = true;
            this.btn_Grabar.Click += new System.EventHandler(this.btn_Grabar_Click);
            // 
            // frmCambioContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 159);
            this.Controls.Add(this.tbl_Usuario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCambioContrasena";
            this.Text = "Cambio de contraseña";
            this.tbl_Usuario.ResumeLayout(false);
            this.tbl_Usuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox tbl_Usuario;
        private System.Windows.Forms.Button btn_Grabar;
                                private System.Windows.Forms.Label lbl_Usuario;
                                private System.Windows.Forms.Label lbl_Id_Personal;
                                private System.Windows.Forms.Label lbl_Contraseña;
                                private System.Windows.Forms.TextBox txt_ContrasenaActual;
                                private System.Windows.Forms.TextBox txt_Contraseña;
                                private System.Windows.Forms.TextBox txt_Contraseña1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Id_Usuario;
    }
}