namespace ControlDosimetro
{
	partial class frmAsignarSeccionPersonal
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
			this.tbl_personal.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbl_personal
			// 
			this.tbl_personal.Controls.Add(this.cbxSeccion);
			this.tbl_personal.Controls.Add(this.label1);
			this.tbl_personal.Controls.Add(this.chkLista);
			this.tbl_personal.Controls.Add(this.lbl_Id_Personal);
			this.tbl_personal.Controls.Add(this.lbl_nombreCliente);
			this.tbl_personal.Controls.Add(this.lbl_id_cliente);
			this.tbl_personal.Controls.Add(this.btn_cerrar);
			this.tbl_personal.Controls.Add(this.btn_Grabar);
			this.tbl_personal.Controls.Add(this.lbl_id_cliente1);
			this.tbl_personal.Location = new System.Drawing.Point(0, 0);
			this.tbl_personal.Name = "tbl_personal";
			this.tbl_personal.Size = new System.Drawing.Size(492, 484);
			this.tbl_personal.TabIndex = 0;
			this.tbl_personal.TabStop = false;
			this.tbl_personal.Text = "Datos";
			// 
			// cbxSeccion
			// 
			this.cbxSeccion.DisplayMember = "Direccion";
			this.cbxSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxSeccion.FormattingEnabled = true;
			this.cbxSeccion.Location = new System.Drawing.Point(62, 46);
			this.cbxSeccion.Name = "cbxSeccion";
			this.cbxSeccion.Size = new System.Drawing.Size(424, 21);
			this.cbxSeccion.TabIndex = 49;
			this.cbxSeccion.ValueMember = "Id_sucursal";
			this.cbxSeccion.SelectedIndexChanged += new System.EventHandler(this.cbxDireccion_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 48;
			this.label1.Text = "Sección";
			// 
			// chkLista
			// 
			this.chkLista.CheckOnClick = true;
			this.chkLista.FormattingEnabled = true;
			this.chkLista.Location = new System.Drawing.Point(6, 78);
			this.chkLista.Name = "chkLista";
			this.chkLista.Size = new System.Drawing.Size(480, 334);
			this.chkLista.TabIndex = 0;
			this.chkLista.ThreeDCheckBoxes = true;
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
			this.btn_cerrar.Image = global::ControlDosimetro.Properties.Resources.exit;
			this.btn_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_cerrar.Location = new System.Drawing.Point(190, 417);
			this.btn_cerrar.Name = "btn_cerrar";
			this.btn_cerrar.Size = new System.Drawing.Size(95, 45);
			this.btn_cerrar.TabIndex = 14;
			this.btn_cerrar.Text = "Cerrar";
			this.btn_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.topSeccion.SetToolTip(this.btn_cerrar, "Cierra el formulario");
			this.btn_cerrar.UseVisualStyleBackColor = true;
			this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
			// 
			// btn_Grabar
			// 
			this.btn_Grabar.Image = global::ControlDosimetro.Properties.Resources.Save_32;
			this.btn_Grabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Grabar.Location = new System.Drawing.Point(79, 417);
			this.btn_Grabar.Name = "btn_Grabar";
			this.btn_Grabar.Size = new System.Drawing.Size(95, 45);
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
			// frmAsignarSeccionPersonal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(498, 490);
			this.Controls.Add(this.tbl_personal);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmAsignarSeccionPersonal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Asignar sección al personal";
			this.tbl_personal.ResumeLayout(false);
			this.tbl_personal.PerformLayout();
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
	}
}