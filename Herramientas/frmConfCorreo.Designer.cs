namespace ControlDosimetro
{
    partial class FrmConfCorreo
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
            this.conf_Correo = new System.Windows.Forms.GroupBox();
            this.txt_Clave = new System.Windows.Forms.TextBox();
            this.txt_Clave1 = new System.Windows.Forms.TextBox();
            this.txt_Credencial = new System.Windows.Forms.TextBox();
            this.lbl_Clave = new System.Windows.Forms.Label();
            this.lbl_Id_Personal = new System.Windows.Forms.Label();
            this.lbl_Credencial = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_Grabar = new System.Windows.Forms.Button();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.lbl_Port = new System.Windows.Forms.Label();
            this.txt_Host = new System.Windows.Forms.TextBox();
            this.lbl_Host = new System.Windows.Forms.Label();
            this.txt_Desde = new System.Windows.Forms.TextBox();
            this.lbl_Desde = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Para = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_EnviarCorreo = new System.Windows.Forms.Button();
            this.conf_Correo.SuspendLayout();
            this.SuspendLayout();
            // 
            // conf_Correo
            // 
            this.conf_Correo.Controls.Add(this.btn_EnviarCorreo);
            this.conf_Correo.Controls.Add(this.txt_Para);
            this.conf_Correo.Controls.Add(this.label3);
            this.conf_Correo.Controls.Add(this.label2);
            this.conf_Correo.Controls.Add(this.label1);
            this.conf_Correo.Controls.Add(this.txt_Clave);
            this.conf_Correo.Controls.Add(this.txt_Clave1);
            this.conf_Correo.Controls.Add(this.txt_Credencial);
            this.conf_Correo.Controls.Add(this.lbl_Clave);
            this.conf_Correo.Controls.Add(this.lbl_Id_Personal);
            this.conf_Correo.Controls.Add(this.lbl_Credencial);
            this.conf_Correo.Controls.Add(this.btn_cerrar);
            this.conf_Correo.Controls.Add(this.btn_Grabar);
            this.conf_Correo.Controls.Add(this.txt_Port);
            this.conf_Correo.Controls.Add(this.lbl_Port);
            this.conf_Correo.Controls.Add(this.txt_Host);
            this.conf_Correo.Controls.Add(this.lbl_Host);
            this.conf_Correo.Controls.Add(this.txt_Desde);
            this.conf_Correo.Controls.Add(this.lbl_Desde);
            this.conf_Correo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conf_Correo.Location = new System.Drawing.Point(0, 0);
            this.conf_Correo.Name = "conf_Correo";
            this.conf_Correo.Size = new System.Drawing.Size(492, 297);
            this.conf_Correo.TabIndex = 0;
            this.conf_Correo.TabStop = false;
            this.conf_Correo.Text = "Datos";
            // 
            // txt_Clave
            // 
            this.txt_Clave.Location = new System.Drawing.Point(53, 121);
            this.txt_Clave.MaxLength = 100;
            this.txt_Clave.Name = "txt_Clave";
            this.txt_Clave.Size = new System.Drawing.Size(111, 20);
            this.txt_Clave.TabIndex = 58;
            this.txt_Clave.Visible = false;
            // 
            // txt_Clave1
            // 
            this.txt_Clave1.Location = new System.Drawing.Point(167, 122);
            this.txt_Clave1.MaxLength = 100;
            this.txt_Clave1.Name = "txt_Clave1";
            this.txt_Clave1.PasswordChar = '*';
            this.txt_Clave1.Size = new System.Drawing.Size(313, 20);
            this.txt_Clave1.TabIndex = 57;
            this.txt_Clave1.TextChanged += new System.EventHandler(this.Txt_Contraseña1_TextChanged);
            // 
            // txt_Credencial
            // 
            this.txt_Credencial.Location = new System.Drawing.Point(167, 17);
            this.txt_Credencial.MaxLength = 50;
            this.txt_Credencial.Name = "txt_Credencial";
            this.txt_Credencial.Size = new System.Drawing.Size(313, 20);
            this.txt_Credencial.TabIndex = 56;
            // 
            // lbl_Clave
            // 
            this.lbl_Clave.AutoSize = true;
            this.lbl_Clave.Location = new System.Drawing.Point(11, 128);
            this.lbl_Clave.Name = "lbl_Clave";
            this.lbl_Clave.Size = new System.Drawing.Size(34, 13);
            this.lbl_Clave.TabIndex = 55;
            this.lbl_Clave.Text = "Clave";
            // 
            // lbl_Id_Personal
            // 
            this.lbl_Id_Personal.AutoSize = true;
            this.lbl_Id_Personal.Location = new System.Drawing.Point(164, 22);
            this.lbl_Id_Personal.Name = "lbl_Id_Personal";
            this.lbl_Id_Personal.Size = new System.Drawing.Size(0, 13);
            this.lbl_Id_Personal.TabIndex = 47;
            // 
            // lbl_Credencial
            // 
            this.lbl_Credencial.AutoSize = true;
            this.lbl_Credencial.Location = new System.Drawing.Point(13, 22);
            this.lbl_Credencial.Name = "lbl_Credencial";
            this.lbl_Credencial.Size = new System.Drawing.Size(57, 13);
            this.lbl_Credencial.TabIndex = 45;
            this.lbl_Credencial.Text = "Credencial";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(224, 158);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 13;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // btn_Grabar
            // 
            this.btn_Grabar.Location = new System.Drawing.Point(113, 158);
            this.btn_Grabar.Name = "btn_Grabar";
            this.btn_Grabar.Size = new System.Drawing.Size(75, 23);
            this.btn_Grabar.TabIndex = 12;
            this.btn_Grabar.Text = "Guardar";
            this.btn_Grabar.UseVisualStyleBackColor = true;
            this.btn_Grabar.Click += new System.EventHandler(this.Btn_Grabar_Click);
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(167, 95);
            this.txt_Port.MaxLength = 20;
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(45, 20);
            this.txt_Port.TabIndex = 3;
            // 
            // lbl_Port
            // 
            this.lbl_Port.AutoSize = true;
            this.lbl_Port.Location = new System.Drawing.Point(11, 98);
            this.lbl_Port.Name = "lbl_Port";
            this.lbl_Port.Size = new System.Drawing.Size(26, 13);
            this.lbl_Port.TabIndex = 9;
            this.lbl_Port.Text = "Port";
            // 
            // txt_Host
            // 
            this.txt_Host.Location = new System.Drawing.Point(167, 69);
            this.txt_Host.MaxLength = 30;
            this.txt_Host.Name = "txt_Host";
            this.txt_Host.Size = new System.Drawing.Size(104, 20);
            this.txt_Host.TabIndex = 2;
            // 
            // lbl_Host
            // 
            this.lbl_Host.AutoSize = true;
            this.lbl_Host.Location = new System.Drawing.Point(11, 72);
            this.lbl_Host.Name = "lbl_Host";
            this.lbl_Host.Size = new System.Drawing.Size(29, 13);
            this.lbl_Host.TabIndex = 7;
            this.lbl_Host.Text = "Host";
            // 
            // txt_Desde
            // 
            this.txt_Desde.Location = new System.Drawing.Point(167, 43);
            this.txt_Desde.MaxLength = 50;
            this.txt_Desde.Name = "txt_Desde";
            this.txt_Desde.Size = new System.Drawing.Size(313, 20);
            this.txt_Desde.TabIndex = 1;
            // 
            // lbl_Desde
            // 
            this.lbl_Desde.AutoSize = true;
            this.lbl_Desde.Location = new System.Drawing.Point(11, 46);
            this.lbl_Desde.Name = "lbl_Desde";
            this.lbl_Desde.Size = new System.Drawing.Size(38, 13);
            this.lbl_Desde.TabIndex = 0;
            this.lbl_Desde.Text = "Desde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "______________________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Prueba envio de correo";
            // 
            // txt_Para
            // 
            this.txt_Para.Location = new System.Drawing.Point(167, 221);
            this.txt_Para.MaxLength = 50;
            this.txt_Para.Name = "txt_Para";
            this.txt_Para.Size = new System.Drawing.Size(313, 20);
            this.txt_Para.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Para";
            // 
            // btn_EnviarCorreo
            // 
            this.btn_EnviarCorreo.Location = new System.Drawing.Point(78, 251);
            this.btn_EnviarCorreo.Name = "btn_EnviarCorreo";
            this.btn_EnviarCorreo.Size = new System.Drawing.Size(110, 23);
            this.btn_EnviarCorreo.TabIndex = 63;
            this.btn_EnviarCorreo.Text = "Enviar correo";
            this.btn_EnviarCorreo.UseVisualStyleBackColor = true;
            this.btn_EnviarCorreo.Click += new System.EventHandler(this.btn_EnviarCorreo_Click);
            // 
            // FrmConfCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 297);
            this.Controls.Add(this.conf_Correo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfCorreo";
            this.Text = "Configuración de  correo";
            this.conf_Correo.ResumeLayout(false);
            this.conf_Correo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox conf_Correo;
        private System.Windows.Forms.TextBox txt_Desde;
        private System.Windows.Forms.Label lbl_Desde;
        private System.Windows.Forms.TextBox txt_Host;
        private System.Windows.Forms.Label lbl_Host;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.Label lbl_Port;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_Grabar;
                                private System.Windows.Forms.Label lbl_Credencial;
                                private System.Windows.Forms.Label lbl_Id_Personal;
                                private System.Windows.Forms.Label lbl_Clave;
                                private System.Windows.Forms.TextBox txt_Credencial;
                                private System.Windows.Forms.TextBox txt_Clave;
                                private System.Windows.Forms.TextBox txt_Clave1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Para;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_EnviarCorreo;
    }
}