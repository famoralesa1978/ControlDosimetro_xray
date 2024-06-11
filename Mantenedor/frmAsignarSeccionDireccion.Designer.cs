namespace ControlDosimetro
{
	partial class frmAsignarSeccionDireccion
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
			this.tbl_personal = new System.Windows.Forms.GroupBox();
			this.lblCantidad = new System.Windows.Forms.Label();
			this.btn_Agregar = new System.Windows.Forms.Button();
			this.btnInvertir = new System.Windows.Forms.Button();
			this.btnDesmarcar = new System.Windows.Forms.Button();
			this.btnMarcarTodos = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.cbxSeccion = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.chkLista = new System.Windows.Forms.CheckedListBox();
			this.lbl_Id_Personal = new System.Windows.Forms.Label();
			this.lbl_nombreCliente = new System.Windows.Forms.Label();
			this.lbl_id_cliente = new System.Windows.Forms.Label();
			this.btn_cerrar = new System.Windows.Forms.Button();
			this.btn_Grabar = new System.Windows.Forms.Button();
			this.lbl_id_cliente1 = new System.Windows.Forms.Label();
			this.topSeccion = new System.Windows.Forms.ToolTip(this.components);
			this.tabDatos = new System.Windows.Forms.TabControl();
			this.tabSeccion = new System.Windows.Forms.TabPage();
			this.tabDireccion = new System.Windows.Forms.TabPage();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnInvertirDir = new System.Windows.Forms.Button();
			this.btnDesmarcarTodosDir = new System.Windows.Forms.Button();
			this.btnMarcarTodosDir = new System.Windows.Forms.Button();
			this.cbxDireccion = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.chkListaDir = new System.Windows.Forms.CheckedListBox();
			this.btnGuardarDir = new System.Windows.Forms.Button();
			this.tbl_personal.SuspendLayout();
			this.tabDatos.SuspendLayout();
			this.tabSeccion.SuspendLayout();
			this.tabDireccion.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbl_personal
			// 
			this.tbl_personal.Controls.Add(this.tabDatos);
			this.tbl_personal.Controls.Add(this.lbl_Id_Personal);
			this.tbl_personal.Controls.Add(this.lbl_nombreCliente);
			this.tbl_personal.Controls.Add(this.lbl_id_cliente);
			this.tbl_personal.Controls.Add(this.btn_cerrar);
			this.tbl_personal.Controls.Add(this.lbl_id_cliente1);
			this.tbl_personal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbl_personal.Location = new System.Drawing.Point(0, 0);
			this.tbl_personal.Name = "tbl_personal";
			this.tbl_personal.Size = new System.Drawing.Size(727, 644);
			this.tbl_personal.TabIndex = 0;
			this.tbl_personal.TabStop = false;
			this.tbl_personal.Text = "Datos";
			// 
			// lblCantidad
			// 
			this.lblCantidad.AutoSize = true;
			this.lblCantidad.Location = new System.Drawing.Point(13, 86);
			this.lblCantidad.Name = "lblCantidad";
			this.lblCantidad.Size = new System.Drawing.Size(35, 13);
			this.lblCantidad.TabIndex = 55;
			this.lblCantidad.Text = "label3";
			// 
			// btn_Agregar
			// 
			this.btn_Agregar.Image = global::ControlDosimetro.Properties.Resources.Seccion_24;
			this.btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Agregar.Location = new System.Drawing.Point(438, 11);
			this.btn_Agregar.Name = "btn_Agregar";
			this.btn_Agregar.Size = new System.Drawing.Size(35, 31);
			this.btn_Agregar.TabIndex = 54;
			this.topSeccion.SetToolTip(this.btn_Agregar, "Agregar sección");
			this.btn_Agregar.UseVisualStyleBackColor = true;
			this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
			// 
			// btnInvertir
			// 
			this.btnInvertir.Location = new System.Drawing.Point(392, 44);
			this.btnInvertir.Name = "btnInvertir";
			this.btnInvertir.Size = new System.Drawing.Size(79, 23);
			this.btnInvertir.TabIndex = 53;
			this.btnInvertir.Text = "Invertir";
			this.btnInvertir.UseVisualStyleBackColor = true;
			this.btnInvertir.Click += new System.EventHandler(this.btnInvertir_Click);
			// 
			// btnDesmarcar
			// 
			this.btnDesmarcar.Location = new System.Drawing.Point(268, 44);
			this.btnDesmarcar.Name = "btnDesmarcar";
			this.btnDesmarcar.Size = new System.Drawing.Size(118, 23);
			this.btnDesmarcar.TabIndex = 52;
			this.btnDesmarcar.Text = "Desmarcar todos";
			this.btnDesmarcar.UseVisualStyleBackColor = true;
			this.btnDesmarcar.Click += new System.EventHandler(this.btnDesmarcar_Click);
			// 
			// btnMarcarTodos
			// 
			this.btnMarcarTodos.Location = new System.Drawing.Point(169, 44);
			this.btnMarcarTodos.Name = "btnMarcarTodos";
			this.btnMarcarTodos.Size = new System.Drawing.Size(93, 23);
			this.btnMarcarTodos.TabIndex = 51;
			this.btnMarcarTodos.Text = "Marcar todos";
			this.btnMarcarTodos.UseVisualStyleBackColor = true;
			this.btnMarcarTodos.Click += new System.EventHandler(this.btnMarcarTodos_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 13);
			this.label2.TabIndex = 50;
			this.label2.Text = "Lista de personal";
			// 
			// cbxSeccion
			// 
			this.cbxSeccion.DisplayMember = "Direccion";
			this.cbxSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxSeccion.FormattingEnabled = true;
			this.cbxSeccion.Location = new System.Drawing.Point(72, 17);
			this.cbxSeccion.Name = "cbxSeccion";
			this.cbxSeccion.Size = new System.Drawing.Size(360, 21);
			this.cbxSeccion.TabIndex = 49;
			this.cbxSeccion.ValueMember = "Id_sucursal";
			this.cbxSeccion.SelectedIndexChanged += new System.EventHandler(this.cbxDireccion_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 48;
			this.label1.Text = "Sección";
			// 
			// chkLista
			// 
			this.chkLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.chkLista.CheckOnClick = true;
			this.chkLista.FormattingEnabled = true;
			this.chkLista.Location = new System.Drawing.Point(16, 102);
			this.chkLista.Name = "chkLista";
			this.chkLista.Size = new System.Drawing.Size(686, 334);
			this.chkLista.TabIndex = 0;
			this.chkLista.ThreeDCheckBoxes = true;
			this.chkLista.SelectedValueChanged += new System.EventHandler(this.chkLista_SelectedValueChanged);
			// 
			// lbl_Id_Personal
			// 
			this.lbl_Id_Personal.AutoSize = true;
			this.lbl_Id_Personal.Location = new System.Drawing.Point(71, 22);
			this.lbl_Id_Personal.Name = "lbl_Id_Personal";
			this.lbl_Id_Personal.Size = new System.Drawing.Size(35, 13);
			this.lbl_Id_Personal.TabIndex = 47;
			this.lbl_Id_Personal.Text = "label1";
			this.lbl_Id_Personal.Visible = false;
			// 
			// lbl_nombreCliente
			// 
			this.lbl_nombreCliente.AutoSize = true;
			this.lbl_nombreCliente.Location = new System.Drawing.Point(221, 20);
			this.lbl_nombreCliente.Name = "lbl_nombreCliente";
			this.lbl_nombreCliente.Size = new System.Drawing.Size(35, 13);
			this.lbl_nombreCliente.TabIndex = 40;
			this.lbl_nombreCliente.Text = "label1";
			// 
			// lbl_id_cliente
			// 
			this.lbl_id_cliente.AutoSize = true;
			this.lbl_id_cliente.Location = new System.Drawing.Point(167, 21);
			this.lbl_id_cliente.Name = "lbl_id_cliente";
			this.lbl_id_cliente.Size = new System.Drawing.Size(35, 13);
			this.lbl_id_cliente.TabIndex = 39;
			this.lbl_id_cliente.Text = "label1";
			// 
			// btn_cerrar
			// 
			this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_cerrar.Image = global::ControlDosimetro.Properties.Resources.exit;
			this.btn_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_cerrar.Location = new System.Drawing.Point(187, 587);
			this.btn_cerrar.Name = "btn_cerrar";
			this.btn_cerrar.Size = new System.Drawing.Size(101, 45);
			this.btn_cerrar.TabIndex = 14;
			this.btn_cerrar.Text = "Cerrar";
			this.btn_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.topSeccion.SetToolTip(this.btn_cerrar, "Cierra el formulario");
			this.btn_cerrar.UseVisualStyleBackColor = true;
			this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
			// 
			// btn_Grabar
			// 
			this.btn_Grabar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Grabar.Image = global::ControlDosimetro.Properties.Resources.Save_32;
			this.btn_Grabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Grabar.Location = new System.Drawing.Point(16, 442);
			this.btn_Grabar.Name = "btn_Grabar";
			this.btn_Grabar.Size = new System.Drawing.Size(106, 45);
			this.btn_Grabar.TabIndex = 13;
			this.btn_Grabar.Text = "Guardar";
			this.btn_Grabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.topSeccion.SetToolTip(this.btn_Grabar, "Guarda información del personal");
			this.btn_Grabar.UseVisualStyleBackColor = true;
			this.btn_Grabar.Click += new System.EventHandler(this.btn_Grabar_Click);
			// 
			// lbl_id_cliente1
			// 
			this.lbl_id_cliente1.AutoSize = true;
			this.lbl_id_cliente1.Location = new System.Drawing.Point(11, 22);
			this.lbl_id_cliente1.Name = "lbl_id_cliente1";
			this.lbl_id_cliente1.Size = new System.Drawing.Size(54, 13);
			this.lbl_id_cliente1.TabIndex = 5;
			this.lbl_id_cliente1.Text = "N° Cliente";
			// 
			// tabDatos
			// 
			this.tabDatos.Controls.Add(this.tabSeccion);
			this.tabDatos.Controls.Add(this.tabDireccion);
			this.tabDatos.Location = new System.Drawing.Point(14, 57);
			this.tabDatos.Name = "tabDatos";
			this.tabDatos.SelectedIndex = 0;
			this.tabDatos.Size = new System.Drawing.Size(716, 522);
			this.tabDatos.TabIndex = 56;
			// 
			// tabSeccion
			// 
			this.tabSeccion.Controls.Add(this.btn_Agregar);
			this.tabSeccion.Controls.Add(this.chkLista);
			this.tabSeccion.Controls.Add(this.lblCantidad);
			this.tabSeccion.Controls.Add(this.cbxSeccion);
			this.tabSeccion.Controls.Add(this.btnInvertir);
			this.tabSeccion.Controls.Add(this.btn_Grabar);
			this.tabSeccion.Controls.Add(this.label1);
			this.tabSeccion.Controls.Add(this.btnDesmarcar);
			this.tabSeccion.Controls.Add(this.btnMarcarTodos);
			this.tabSeccion.Controls.Add(this.label2);
			this.tabSeccion.Location = new System.Drawing.Point(4, 22);
			this.tabSeccion.Name = "tabSeccion";
			this.tabSeccion.Padding = new System.Windows.Forms.Padding(3);
			this.tabSeccion.Size = new System.Drawing.Size(708, 496);
			this.tabSeccion.TabIndex = 0;
			this.tabSeccion.Text = "Sección";
			this.tabSeccion.UseVisualStyleBackColor = true;
			// 
			// tabDireccion
			// 
			this.tabDireccion.Controls.Add(this.btnGuardarDir);
			this.tabDireccion.Controls.Add(this.label3);
			this.tabDireccion.Controls.Add(this.label4);
			this.tabDireccion.Controls.Add(this.btnInvertirDir);
			this.tabDireccion.Controls.Add(this.btnDesmarcarTodosDir);
			this.tabDireccion.Controls.Add(this.btnMarcarTodosDir);
			this.tabDireccion.Controls.Add(this.cbxDireccion);
			this.tabDireccion.Controls.Add(this.label5);
			this.tabDireccion.Controls.Add(this.chkListaDir);
			this.tabDireccion.Location = new System.Drawing.Point(4, 22);
			this.tabDireccion.Name = "tabDireccion";
			this.tabDireccion.Padding = new System.Windows.Forms.Padding(3);
			this.tabDireccion.Size = new System.Drawing.Size(708, 496);
			this.tabDireccion.TabIndex = 1;
			this.tabDireccion.Text = "Dirección";
			this.tabDireccion.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 66;
			this.label3.Text = "label3";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 52);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(87, 13);
			this.label4.TabIndex = 65;
			this.label4.Text = "Lista de personal";
			// 
			// btnInvertirDir
			// 
			this.btnInvertirDir.Location = new System.Drawing.Point(406, 42);
			this.btnInvertirDir.Name = "btnInvertirDir";
			this.btnInvertirDir.Size = new System.Drawing.Size(79, 23);
			this.btnInvertirDir.TabIndex = 64;
			this.btnInvertirDir.Text = "Invertir";
			this.btnInvertirDir.UseVisualStyleBackColor = true;
			this.btnInvertirDir.Click += new System.EventHandler(this.btnInvertirDir_Click);
			// 
			// btnDesmarcarTodosDir
			// 
			this.btnDesmarcarTodosDir.Location = new System.Drawing.Point(282, 42);
			this.btnDesmarcarTodosDir.Name = "btnDesmarcarTodosDir";
			this.btnDesmarcarTodosDir.Size = new System.Drawing.Size(118, 23);
			this.btnDesmarcarTodosDir.TabIndex = 63;
			this.btnDesmarcarTodosDir.Text = "Desmarcar todos";
			this.btnDesmarcarTodosDir.UseVisualStyleBackColor = true;
			this.btnDesmarcarTodosDir.Click += new System.EventHandler(this.btnDesmarcarTodosDir_Click);
			// 
			// btnMarcarTodosDir
			// 
			this.btnMarcarTodosDir.Location = new System.Drawing.Point(183, 42);
			this.btnMarcarTodosDir.Name = "btnMarcarTodosDir";
			this.btnMarcarTodosDir.Size = new System.Drawing.Size(93, 23);
			this.btnMarcarTodosDir.TabIndex = 62;
			this.btnMarcarTodosDir.Text = "Marcar todos";
			this.btnMarcarTodosDir.UseVisualStyleBackColor = true;
			this.btnMarcarTodosDir.Click += new System.EventHandler(this.btnMarcarTodosDir_Click);
			// 
			// cbxDireccion
			// 
			this.cbxDireccion.DisplayMember = "Direccion";
			this.cbxDireccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxDireccion.FormattingEnabled = true;
			this.cbxDireccion.Location = new System.Drawing.Point(65, 10);
			this.cbxDireccion.Name = "cbxDireccion";
			this.cbxDireccion.Size = new System.Drawing.Size(424, 21);
			this.cbxDireccion.TabIndex = 61;
			this.cbxDireccion.ValueMember = "Id_sucursal";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 13);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 13);
			this.label5.TabIndex = 60;
			this.label5.Text = "Dirección";
			// 
			// chkListaDir
			// 
			this.chkListaDir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.chkListaDir.CheckOnClick = true;
			this.chkListaDir.FormattingEnabled = true;
			this.chkListaDir.Location = new System.Drawing.Point(9, 92);
			this.chkListaDir.Name = "chkListaDir";
			this.chkListaDir.Size = new System.Drawing.Size(693, 349);
			this.chkListaDir.TabIndex = 59;
			this.chkListaDir.ThreeDCheckBoxes = true;
			// 
			// btnGuardarDir
			// 
			this.btnGuardarDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGuardarDir.Image = global::ControlDosimetro.Properties.Resources.Save_32;
			this.btnGuardarDir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardarDir.Location = new System.Drawing.Point(11, 446);
			this.btnGuardarDir.Name = "btnGuardarDir";
			this.btnGuardarDir.Size = new System.Drawing.Size(89, 44);
			this.btnGuardarDir.TabIndex = 67;
			this.btnGuardarDir.Text = "Guardar";
			this.btnGuardarDir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.topSeccion.SetToolTip(this.btnGuardarDir, "Guarda información del personal");
			this.btnGuardarDir.UseVisualStyleBackColor = true;
			this.btnGuardarDir.Click += new System.EventHandler(this.btnGuardarDir_Click);
			// 
			// frmAsignarSeccionDireccion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(727, 644);
			this.Controls.Add(this.tbl_personal);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmAsignarSeccionDireccion";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Asignar sección  y dirección";
			this.tbl_personal.ResumeLayout(false);
			this.tbl_personal.PerformLayout();
			this.tabDatos.ResumeLayout(false);
			this.tabSeccion.ResumeLayout(false);
			this.tabSeccion.PerformLayout();
			this.tabDireccion.ResumeLayout(false);
			this.tabDireccion.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox tbl_personal;
		private System.Windows.Forms.Label lbl_id_cliente1;
		private System.Windows.Forms.Button btn_cerrar;
		private System.Windows.Forms.Button btn_Grabar;
		private System.Windows.Forms.Label lbl_id_cliente;
		private System.Windows.Forms.Label lbl_nombreCliente;
		private System.Windows.Forms.Label lbl_Id_Personal;
		private System.Windows.Forms.ToolTip topSeccion;
		private System.Windows.Forms.CheckedListBox chkLista;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbxSeccion;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnInvertir;
		private System.Windows.Forms.Button btnDesmarcar;
		private System.Windows.Forms.Button btnMarcarTodos;
		private System.Windows.Forms.Button btn_Agregar;
		private System.Windows.Forms.Label lblCantidad;
		private System.Windows.Forms.TabControl tabDatos;
		private System.Windows.Forms.TabPage tabSeccion;
		private System.Windows.Forms.TabPage tabDireccion;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnInvertirDir;
		private System.Windows.Forms.Button btnDesmarcarTodosDir;
		private System.Windows.Forms.Button btnMarcarTodosDir;
		private System.Windows.Forms.ComboBox cbxDireccion;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckedListBox chkListaDir;
		private System.Windows.Forms.Button btnGuardarDir;
	}
}