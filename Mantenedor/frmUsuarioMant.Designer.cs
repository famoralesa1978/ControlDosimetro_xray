namespace ControlDosimetro
{
    partial class frmUsuarioMant
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
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.txt_Contraseña1 = new System.Windows.Forms.TextBox();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.lbl_Contraseña = new System.Windows.Forms.Label();
            this.cbx_Id_perfil = new System.Windows.Forms.ComboBox();
            this.lbl_Id_perfil = new System.Windows.Forms.Label();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.lbl_Id_Personal = new System.Windows.Forms.Label();
            this.lbl_Fecha_agregado = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.txt_Maternos = new System.Windows.Forms.TextBox();
            this.lbl_Maternos = new System.Windows.Forms.Label();
            this.lbl_Fecha_Modificacion = new System.Windows.Forms.Label();
            this.cbx_Id_estado = new System.Windows.Forms.ComboBox();
            this.lbl_id_estado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_Grabar = new System.Windows.Forms.Button();
            this.txt_paterno = new System.Windows.Forms.TextBox();
            this.lbl_Paterno = new System.Windows.Forms.Label();
            this.txt_Nombres = new System.Windows.Forms.TextBox();
            this.lbl_Nombres = new System.Windows.Forms.Label();
            this.lbl_Id_Usuario = new System.Windows.Forms.Label();
            this.txt_rut = new System.Windows.Forms.TextBox();
            this.lbl_rut = new System.Windows.Forms.Label();
            this.tbl_Usuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbl_Usuario
            // 
            this.tbl_Usuario.Controls.Add(this.txt_Contraseña);
            this.tbl_Usuario.Controls.Add(this.txt_Contraseña1);
            this.tbl_Usuario.Controls.Add(this.txt_Usuario);
            this.tbl_Usuario.Controls.Add(this.lbl_Contraseña);
            this.tbl_Usuario.Controls.Add(this.cbx_Id_perfil);
            this.tbl_Usuario.Controls.Add(this.lbl_Id_perfil);
            this.tbl_Usuario.Controls.Add(this.btn_Limpiar);
            this.tbl_Usuario.Controls.Add(this.lbl_Id_Personal);
            this.tbl_Usuario.Controls.Add(this.lbl_Fecha_agregado);
            this.tbl_Usuario.Controls.Add(this.lbl_Usuario);
            this.tbl_Usuario.Controls.Add(this.txt_Maternos);
            this.tbl_Usuario.Controls.Add(this.lbl_Maternos);
            this.tbl_Usuario.Controls.Add(this.lbl_Fecha_Modificacion);
            this.tbl_Usuario.Controls.Add(this.cbx_Id_estado);
            this.tbl_Usuario.Controls.Add(this.lbl_id_estado);
            this.tbl_Usuario.Controls.Add(this.label2);
            this.tbl_Usuario.Controls.Add(this.btn_cerrar);
            this.tbl_Usuario.Controls.Add(this.btn_Grabar);
            this.tbl_Usuario.Controls.Add(this.txt_paterno);
            this.tbl_Usuario.Controls.Add(this.lbl_Paterno);
            this.tbl_Usuario.Controls.Add(this.txt_Nombres);
            this.tbl_Usuario.Controls.Add(this.lbl_Nombres);
            this.tbl_Usuario.Controls.Add(this.lbl_Id_Usuario);
            this.tbl_Usuario.Controls.Add(this.txt_rut);
            this.tbl_Usuario.Controls.Add(this.lbl_rut);
            this.tbl_Usuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_Usuario.Location = new System.Drawing.Point(0, 0);
            this.tbl_Usuario.Name = "tbl_Usuario";
            this.tbl_Usuario.Size = new System.Drawing.Size(492, 270);
            this.tbl_Usuario.TabIndex = 0;
            this.tbl_Usuario.TabStop = false;
            this.tbl_Usuario.Text = "Datos";
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Location = new System.Drawing.Point(317, 201);
            this.txt_Contraseña.MaxLength = 100;
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.Size = new System.Drawing.Size(111, 20);
            this.txt_Contraseña.TabIndex = 58;
            this.txt_Contraseña.Visible = false;
            // 
            // txt_Contraseña1
            // 
            this.txt_Contraseña1.Location = new System.Drawing.Point(167, 176);
            this.txt_Contraseña1.MaxLength = 100;
            this.txt_Contraseña1.Name = "txt_Contraseña1";
            this.txt_Contraseña1.PasswordChar = '*';
            this.txt_Contraseña1.Size = new System.Drawing.Size(313, 20);
            this.txt_Contraseña1.TabIndex = 57;
            this.txt_Contraseña1.TextChanged += new System.EventHandler(this.txt_Contraseña1_TextChanged);
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(167, 17);
            this.txt_Usuario.MaxLength = 10;
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(120, 20);
            this.txt_Usuario.TabIndex = 56;
            // 
            // lbl_Contraseña
            // 
            this.lbl_Contraseña.AutoSize = true;
            this.lbl_Contraseña.Location = new System.Drawing.Point(11, 182);
            this.lbl_Contraseña.Name = "lbl_Contraseña";
            this.lbl_Contraseña.Size = new System.Drawing.Size(61, 13);
            this.lbl_Contraseña.TabIndex = 55;
            this.lbl_Contraseña.Text = "Contraseña";
            // 
            // cbx_Id_perfil
            // 
            this.cbx_Id_perfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Id_perfil.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbx_Id_perfil.FormattingEnabled = true;
            this.cbx_Id_perfil.Location = new System.Drawing.Point(167, 149);
            this.cbx_Id_perfil.Name = "cbx_Id_perfil";
            this.cbx_Id_perfil.Size = new System.Drawing.Size(121, 21);
            this.cbx_Id_perfil.TabIndex = 53;
            this.cbx_Id_perfil.TabStop = false;
            // 
            // lbl_Id_perfil
            // 
            this.lbl_Id_perfil.AutoSize = true;
            this.lbl_Id_perfil.Location = new System.Drawing.Point(11, 152);
            this.lbl_Id_perfil.Name = "lbl_Id_perfil";
            this.lbl_Id_perfil.Size = new System.Drawing.Size(30, 13);
            this.lbl_Id_perfil.TabIndex = 52;
            this.lbl_Id_perfil.Text = "Perfil";
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(293, 228);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(110, 23);
            this.btn_Limpiar.TabIndex = 14;
            this.btn_Limpiar.Text = "Limpiar Controles";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // lbl_Id_Personal
            // 
            this.lbl_Id_Personal.AutoSize = true;
            this.lbl_Id_Personal.Location = new System.Drawing.Point(164, 22);
            this.lbl_Id_Personal.Name = "lbl_Id_Personal";
            this.lbl_Id_Personal.Size = new System.Drawing.Size(0, 13);
            this.lbl_Id_Personal.TabIndex = 47;
            // 
            // lbl_Fecha_agregado
            // 
            this.lbl_Fecha_agregado.AutoSize = true;
            this.lbl_Fecha_agregado.Location = new System.Drawing.Point(403, 157);
            this.lbl_Fecha_agregado.Name = "lbl_Fecha_agregado";
            this.lbl_Fecha_agregado.Size = new System.Drawing.Size(35, 13);
            this.lbl_Fecha_agregado.TabIndex = 46;
            this.lbl_Fecha_agregado.Text = "label1";
            this.lbl_Fecha_agregado.Visible = false;
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(13, 22);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(43, 13);
            this.lbl_Usuario.TabIndex = 45;
            this.lbl_Usuario.Text = "Usuario";
            // 
            // txt_Maternos
            // 
            this.txt_Maternos.Location = new System.Drawing.Point(167, 121);
            this.txt_Maternos.MaxLength = 20;
            this.txt_Maternos.Name = "txt_Maternos";
            this.txt_Maternos.Size = new System.Drawing.Size(313, 20);
            this.txt_Maternos.TabIndex = 4;
            // 
            // lbl_Maternos
            // 
            this.lbl_Maternos.AutoSize = true;
            this.lbl_Maternos.Location = new System.Drawing.Point(11, 124);
            this.lbl_Maternos.Name = "lbl_Maternos";
            this.lbl_Maternos.Size = new System.Drawing.Size(46, 13);
            this.lbl_Maternos.TabIndex = 42;
            this.lbl_Maternos.Text = "Materno";
            // 
            // lbl_Fecha_Modificacion
            // 
            this.lbl_Fecha_Modificacion.AutoSize = true;
            this.lbl_Fecha_Modificacion.Location = new System.Drawing.Point(327, 157);
            this.lbl_Fecha_Modificacion.Name = "lbl_Fecha_Modificacion";
            this.lbl_Fecha_Modificacion.Size = new System.Drawing.Size(41, 13);
            this.lbl_Fecha_Modificacion.TabIndex = 38;
            this.lbl_Fecha_Modificacion.Text = "label14";
            this.lbl_Fecha_Modificacion.Visible = false;
            // 
            // cbx_Id_estado
            // 
            this.cbx_Id_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Id_estado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbx_Id_estado.FormattingEnabled = true;
            this.cbx_Id_estado.Location = new System.Drawing.Point(167, 201);
            this.cbx_Id_estado.Name = "cbx_Id_estado";
            this.cbx_Id_estado.Size = new System.Drawing.Size(121, 21);
            this.cbx_Id_estado.TabIndex = 9;
            this.cbx_Id_estado.SelectedIndexChanged += new System.EventHandler(this.cbx_id_estado_SelectedIndexChanged);
            // 
            // lbl_id_estado
            // 
            this.lbl_id_estado.AutoSize = true;
            this.lbl_id_estado.Location = new System.Drawing.Point(13, 207);
            this.lbl_id_estado.Name = "lbl_id_estado";
            this.lbl_id_estado.Size = new System.Drawing.Size(40, 13);
            this.lbl_id_estado.TabIndex = 28;
            this.lbl_id_estado.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Formato: 12345678-9";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(190, 228);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 13;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_Grabar
            // 
            this.btn_Grabar.Location = new System.Drawing.Point(79, 228);
            this.btn_Grabar.Name = "btn_Grabar";
            this.btn_Grabar.Size = new System.Drawing.Size(75, 23);
            this.btn_Grabar.TabIndex = 12;
            this.btn_Grabar.Text = "Guardar";
            this.btn_Grabar.UseVisualStyleBackColor = true;
            this.btn_Grabar.Click += new System.EventHandler(this.btn_Grabar_Click);
            // 
            // txt_paterno
            // 
            this.txt_paterno.Location = new System.Drawing.Point(167, 95);
            this.txt_paterno.MaxLength = 20;
            this.txt_paterno.Name = "txt_paterno";
            this.txt_paterno.Size = new System.Drawing.Size(313, 20);
            this.txt_paterno.TabIndex = 3;
            // 
            // lbl_Paterno
            // 
            this.lbl_Paterno.AutoSize = true;
            this.lbl_Paterno.Location = new System.Drawing.Point(11, 98);
            this.lbl_Paterno.Name = "lbl_Paterno";
            this.lbl_Paterno.Size = new System.Drawing.Size(44, 13);
            this.lbl_Paterno.TabIndex = 9;
            this.lbl_Paterno.Text = "Paterno";
            // 
            // txt_Nombres
            // 
            this.txt_Nombres.Location = new System.Drawing.Point(167, 69);
            this.txt_Nombres.MaxLength = 30;
            this.txt_Nombres.Name = "txt_Nombres";
            this.txt_Nombres.Size = new System.Drawing.Size(313, 20);
            this.txt_Nombres.TabIndex = 2;
            // 
            // lbl_Nombres
            // 
            this.lbl_Nombres.AutoSize = true;
            this.lbl_Nombres.Location = new System.Drawing.Point(11, 72);
            this.lbl_Nombres.Name = "lbl_Nombres";
            this.lbl_Nombres.Size = new System.Drawing.Size(49, 13);
            this.lbl_Nombres.TabIndex = 7;
            this.lbl_Nombres.Text = "Nombres";
            // 
            // lbl_Id_Usuario
            // 
            this.lbl_Id_Usuario.AutoSize = true;
            this.lbl_Id_Usuario.Location = new System.Drawing.Point(380, 16);
            this.lbl_Id_Usuario.Name = "lbl_Id_Usuario";
            this.lbl_Id_Usuario.Size = new System.Drawing.Size(58, 13);
            this.lbl_Id_Usuario.TabIndex = 5;
            this.lbl_Id_Usuario.Text = "N° Usuario";
            this.lbl_Id_Usuario.Visible = false;
            // 
            // txt_rut
            // 
            this.txt_rut.Location = new System.Drawing.Point(167, 43);
            this.txt_rut.MaxLength = 10;
            this.txt_rut.Name = "txt_rut";
            this.txt_rut.Size = new System.Drawing.Size(120, 20);
            this.txt_rut.TabIndex = 1;
            this.txt_rut.Text = "8";
            // 
            // lbl_rut
            // 
            this.lbl_rut.AutoSize = true;
            this.lbl_rut.Location = new System.Drawing.Point(11, 46);
            this.lbl_rut.Name = "lbl_rut";
            this.lbl_rut.Size = new System.Drawing.Size(24, 13);
            this.lbl_rut.TabIndex = 0;
            this.lbl_rut.Text = "Rut";
            // 
            // frmUsuarioMant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 270);
            this.Controls.Add(this.tbl_Usuario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsuarioMant";
            this.Text = "Usuario";
            this.tbl_Usuario.ResumeLayout(false);
            this.tbl_Usuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox tbl_Usuario;
        private System.Windows.Forms.TextBox txt_rut;
        private System.Windows.Forms.Label lbl_rut;
		  private System.Windows.Forms.Label lbl_Id_Usuario;
        private System.Windows.Forms.TextBox txt_Nombres;
        private System.Windows.Forms.Label lbl_Nombres;
        private System.Windows.Forms.TextBox txt_paterno;
        private System.Windows.Forms.Label lbl_Paterno;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_Grabar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_Id_estado;
        private System.Windows.Forms.Label lbl_id_estado;
        private System.Windows.Forms.Label lbl_Fecha_Modificacion;
								private System.Windows.Forms.TextBox txt_Maternos;
                                private System.Windows.Forms.Label lbl_Maternos;
								private System.Windows.Forms.Label lbl_Fecha_agregado;
                                private System.Windows.Forms.Label lbl_Usuario;
                                private System.Windows.Forms.Label lbl_Id_Personal;
                                private System.Windows.Forms.Button btn_Limpiar;
								private System.Windows.Forms.Label lbl_Id_perfil;
                                private System.Windows.Forms.ComboBox cbx_Id_perfil;
                                private System.Windows.Forms.Label lbl_Contraseña;
                                private System.Windows.Forms.TextBox txt_Usuario;
                                private System.Windows.Forms.TextBox txt_Contraseña;
                                private System.Windows.Forms.TextBox txt_Contraseña1;
    }
}