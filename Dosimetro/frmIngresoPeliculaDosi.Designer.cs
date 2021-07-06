namespace ControlDosimetro
{
    partial class frmIngresoPeliculaDosi
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresoPeliculaDosi));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label16 = new System.Windows.Forms.Label();
			this.lbl_rut = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.btn_Cargar_cliente = new System.Windows.Forms.Button();
			this.lbl_id_cliente = new System.Windows.Forms.TextBox();
			this.lbl_Direccion = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btn_filtro = new System.Windows.Forms.Button();
			this.btn_cargar = new System.Windows.Forms.Button();
			this.cbx_id_periodo = new System.Windows.Forms.ComboBox();
			this.lbl_nombreCliente = new System.Windows.Forms.Label();
			this.grp_Ingreso = new System.Windows.Forms.GroupBox();
			this.pctAgregarSucursal = new System.Windows.Forms.PictureBox();
			this.txt_pelrefhasta = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.txt_pelrefdesde = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.cbx_Sucursal = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.dtp_Fecha_dev = new System.Windows.Forms.DateTimePicker();
			this.label13 = new System.Windows.Forms.Label();
			this.txt_Servicio = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txt_Observacion = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.chk_Ref = new System.Windows.Forms.CheckBox();
			this.txt_NDocumento = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txt_PeliculaHasta = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.dtp_Fecha_inicio = new System.Windows.Forms.DateTimePicker();
			this.btn_Agregar = new System.Windows.Forms.Button();
			this.txt_Pelicula = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cbx_anno = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.pnl_Progreso = new System.Windows.Forms.GroupBox();
			this.pgb_Barra = new System.Windows.Forms.ProgressBar();
			this.grdDatos = new System.Windows.Forms.DataGridView();
			this.cmsPopup = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmEliminar = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsb_Imprimir = new System.Windows.Forms.ToolStripButton();
			this.tsdReporte = new System.Windows.Forms.ToolStripDropDownButton();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.integerGridColumn1 = new GridExtension.IntegerGridColumn();
			this.integerGridColumn2 = new GridExtension.IntegerGridColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btn_Imprimir = new System.Windows.Forms.Button();
			this.btn_Cerrar = new System.Windows.Forms.Button();
			this.btn_IngresoDosimetro = new System.Windows.Forms.Button();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id_estadodosimetro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.N_Pelicula = new GridExtension.IntegerGridColumn();
			this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.N_documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColFecha_ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			this.grp_Ingreso.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctAgregarSucursal)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.pnl_Progreso.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
			this.cmsPopup.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.lbl_rut);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.btn_Cargar_cliente);
			this.groupBox1.Controls.Add(this.lbl_id_cliente);
			this.groupBox1.Controls.Add(this.lbl_Direccion);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.btn_filtro);
			this.groupBox1.Controls.Add(this.btn_cargar);
			this.groupBox1.Controls.Add(this.cbx_id_periodo);
			this.groupBox1.Controls.Add(this.lbl_nombreCliente);
			this.groupBox1.Controls.Add(this.grp_Ingreso);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cbx_anno);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(5, 28);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(465, 380);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dato Cliente";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(12, 98);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(44, 13);
			this.label16.TabIndex = 50;
			this.label16.Text = "Nombre";
			// 
			// lbl_rut
			// 
			this.lbl_rut.AutoSize = true;
			this.lbl_rut.Location = new System.Drawing.Point(84, 121);
			this.lbl_rut.Name = "lbl_rut";
			this.lbl_rut.Size = new System.Drawing.Size(35, 13);
			this.lbl_rut.TabIndex = 49;
			this.lbl_rut.Text = "label1";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(12, 121);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(24, 13);
			this.label11.TabIndex = 48;
			this.label11.Text = "Rut";
			// 
			// btn_Cargar_cliente
			// 
			this.btn_Cargar_cliente.Location = new System.Drawing.Point(340, 19);
			this.btn_Cargar_cliente.Name = "btn_Cargar_cliente";
			this.btn_Cargar_cliente.Size = new System.Drawing.Size(119, 23);
			this.btn_Cargar_cliente.TabIndex = 47;
			this.btn_Cargar_cliente.Text = "Cargar Cliente";
			this.btn_Cargar_cliente.UseVisualStyleBackColor = true;
			this.btn_Cargar_cliente.Visible = false;
			this.btn_Cargar_cliente.Click += new System.EventHandler(this.btn_Cargar_cliente_Click);
			// 
			// lbl_id_cliente
			// 
			this.lbl_id_cliente.Location = new System.Drawing.Point(87, 69);
			this.lbl_id_cliente.Name = "lbl_id_cliente";
			this.lbl_id_cliente.Size = new System.Drawing.Size(53, 20);
			this.lbl_id_cliente.TabIndex = 3;
			// 
			// lbl_Direccion
			// 
			this.lbl_Direccion.AutoSize = true;
			this.lbl_Direccion.Location = new System.Drawing.Point(84, 147);
			this.lbl_Direccion.Name = "lbl_Direccion";
			this.lbl_Direccion.Size = new System.Drawing.Size(35, 13);
			this.lbl_Direccion.TabIndex = 46;
			this.lbl_Direccion.Text = "label1";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 147);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 13);
			this.label6.TabIndex = 45;
			this.label6.Text = "Dirección";
			// 
			// btn_filtro
			// 
			this.btn_filtro.Location = new System.Drawing.Point(232, 68);
			this.btn_filtro.Name = "btn_filtro";
			this.btn_filtro.Size = new System.Drawing.Size(95, 23);
			this.btn_filtro.TabIndex = 44;
			this.btn_filtro.Text = "Limpiar filtro";
			this.btn_filtro.UseVisualStyleBackColor = true;
			this.btn_filtro.Click += new System.EventHandler(this.btn_filtro_Click_1);
			// 
			// btn_cargar
			// 
			this.btn_cargar.Location = new System.Drawing.Point(151, 68);
			this.btn_cargar.Name = "btn_cargar";
			this.btn_cargar.Size = new System.Drawing.Size(75, 23);
			this.btn_cargar.TabIndex = 4;
			this.btn_cargar.Text = "Cargar";
			this.btn_cargar.UseVisualStyleBackColor = true;
			this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
			// 
			// cbx_id_periodo
			// 
			this.cbx_id_periodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_id_periodo.FormattingEnabled = true;
			this.cbx_id_periodo.Location = new System.Drawing.Point(87, 44);
			this.cbx_id_periodo.Name = "cbx_id_periodo";
			this.cbx_id_periodo.Size = new System.Drawing.Size(121, 21);
			this.cbx_id_periodo.TabIndex = 2;
			// 
			// lbl_nombreCliente
			// 
			this.lbl_nombreCliente.AutoSize = true;
			this.lbl_nombreCliente.Location = new System.Drawing.Point(84, 98);
			this.lbl_nombreCliente.Name = "lbl_nombreCliente";
			this.lbl_nombreCliente.Size = new System.Drawing.Size(35, 13);
			this.lbl_nombreCliente.TabIndex = 42;
			this.lbl_nombreCliente.Text = "label1";
			// 
			// grp_Ingreso
			// 
			this.grp_Ingreso.Controls.Add(this.pctAgregarSucursal);
			this.grp_Ingreso.Controls.Add(this.txt_pelrefhasta);
			this.grp_Ingreso.Controls.Add(this.label15);
			this.grp_Ingreso.Controls.Add(this.txt_pelrefdesde);
			this.grp_Ingreso.Controls.Add(this.label14);
			this.grp_Ingreso.Controls.Add(this.cbx_Sucursal);
			this.grp_Ingreso.Controls.Add(this.label12);
			this.grp_Ingreso.Controls.Add(this.dtp_Fecha_dev);
			this.grp_Ingreso.Controls.Add(this.label13);
			this.grp_Ingreso.Controls.Add(this.txt_Servicio);
			this.grp_Ingreso.Controls.Add(this.label10);
			this.grp_Ingreso.Controls.Add(this.txt_Observacion);
			this.grp_Ingreso.Controls.Add(this.label9);
			this.grp_Ingreso.Controls.Add(this.chk_Ref);
			this.grp_Ingreso.Controls.Add(this.txt_NDocumento);
			this.grp_Ingreso.Controls.Add(this.label8);
			this.grp_Ingreso.Controls.Add(this.txt_PeliculaHasta);
			this.grp_Ingreso.Controls.Add(this.label7);
			this.grp_Ingreso.Controls.Add(this.dtp_Fecha_inicio);
			this.grp_Ingreso.Controls.Add(this.btn_Agregar);
			this.grp_Ingreso.Controls.Add(this.txt_Pelicula);
			this.grp_Ingreso.Controls.Add(this.label5);
			this.grp_Ingreso.Controls.Add(this.label4);
			this.grp_Ingreso.Location = new System.Drawing.Point(7, 172);
			this.grp_Ingreso.Name = "grp_Ingreso";
			this.grp_Ingreso.Size = new System.Drawing.Size(452, 201);
			this.grp_Ingreso.TabIndex = 5;
			this.grp_Ingreso.TabStop = false;
			this.grp_Ingreso.Text = "Ingreso Pelicula";
			// 
			// pctAgregarSucursal
			// 
			this.pctAgregarSucursal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pctAgregarSucursal.Image = global::ControlDosimetro.Properties.Resources.Agregar;
			this.pctAgregarSucursal.Location = new System.Drawing.Point(422, 135);
			this.pctAgregarSucursal.Name = "pctAgregarSucursal";
			this.pctAgregarSucursal.Size = new System.Drawing.Size(24, 22);
			this.pctAgregarSucursal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pctAgregarSucursal.TabIndex = 33;
			this.pctAgregarSucursal.TabStop = false;
			this.pctAgregarSucursal.Click += new System.EventHandler(this.pctAgregarSucursal_Click);
			// 
			// txt_pelrefhasta
			// 
			this.txt_pelrefhasta.Location = new System.Drawing.Point(268, 39);
			this.txt_pelrefhasta.MaxLength = 10;
			this.txt_pelrefhasta.Name = "txt_pelrefhasta";
			this.txt_pelrefhasta.Size = new System.Drawing.Size(100, 20);
			this.txt_pelrefhasta.TabIndex = 9;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(233, 42);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(35, 13);
			this.label15.TabIndex = 32;
			this.label15.Text = "Hasta";
			// 
			// txt_pelrefdesde
			// 
			this.txt_pelrefdesde.Location = new System.Drawing.Point(127, 39);
			this.txt_pelrefdesde.MaxLength = 10;
			this.txt_pelrefdesde.Name = "txt_pelrefdesde";
			this.txt_pelrefdesde.Size = new System.Drawing.Size(100, 20);
			this.txt_pelrefdesde.TabIndex = 8;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(7, 42);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(114, 13);
			this.label14.TabIndex = 29;
			this.label14.Text = "N° Pelicula Referencia";
			// 
			// cbx_Sucursal
			// 
			this.cbx_Sucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_Sucursal.FormattingEnabled = true;
			this.cbx_Sucursal.Location = new System.Drawing.Point(68, 135);
			this.cbx_Sucursal.Name = "cbx_Sucursal";
			this.cbx_Sucursal.Size = new System.Drawing.Size(349, 21);
			this.cbx_Sucursal.TabIndex = 14;
			this.cbx_Sucursal.SelectedIndexChanged += new System.EventHandler(this.cbx_Sucursal_SelectedIndexChanged);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(3, 138);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(48, 13);
			this.label12.TabIndex = 27;
			this.label12.Text = "Sucursal";
			// 
			// dtp_Fecha_dev
			// 
			this.dtp_Fecha_dev.CustomFormat = "dd-MMMMMMMMMMM-yyyy";
			this.dtp_Fecha_dev.Enabled = false;
			this.dtp_Fecha_dev.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_Fecha_dev.Location = new System.Drawing.Point(105, 113);
			this.dtp_Fecha_dev.Name = "dtp_Fecha_dev";
			this.dtp_Fecha_dev.Size = new System.Drawing.Size(132, 20);
			this.dtp_Fecha_dev.TabIndex = 13;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(3, 119);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(94, 13);
			this.label13.TabIndex = 25;
			this.label13.Text = "Fecha Devolución";
			// 
			// txt_Servicio
			// 
			this.txt_Servicio.Location = new System.Drawing.Point(105, 89);
			this.txt_Servicio.MaxLength = 100;
			this.txt_Servicio.Name = "txt_Servicio";
			this.txt_Servicio.Size = new System.Drawing.Size(329, 20);
			this.txt_Servicio.TabIndex = 12;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(3, 93);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(45, 13);
			this.label10.TabIndex = 18;
			this.label10.Text = "Servicio";
			// 
			// txt_Observacion
			// 
			this.txt_Observacion.Location = new System.Drawing.Point(68, 158);
			this.txt_Observacion.MaxLength = 200;
			this.txt_Observacion.Name = "txt_Observacion";
			this.txt_Observacion.Size = new System.Drawing.Size(233, 20);
			this.txt_Observacion.TabIndex = 15;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(3, 161);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(67, 13);
			this.label9.TabIndex = 16;
			this.label9.Text = "Observación";
			// 
			// chk_Ref
			// 
			this.chk_Ref.AutoSize = true;
			this.chk_Ref.Location = new System.Drawing.Point(327, 15);
			this.chk_Ref.Name = "chk_Ref";
			this.chk_Ref.Size = new System.Drawing.Size(118, 17);
			this.chk_Ref.TabIndex = 15;
			this.chk_Ref.Text = "Pelicula Referencia";
			this.chk_Ref.UseVisualStyleBackColor = true;
			this.chk_Ref.Visible = false;
			// 
			// txt_NDocumento
			// 
			this.txt_NDocumento.Location = new System.Drawing.Point(105, 63);
			this.txt_NDocumento.MaxLength = 10;
			this.txt_NDocumento.Name = "txt_NDocumento";
			this.txt_NDocumento.Size = new System.Drawing.Size(100, 20);
			this.txt_NDocumento.TabIndex = 10;
			this.txt_NDocumento.Leave += new System.EventHandler(this.txt_NDocumento_Leave);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(3, 66);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(77, 13);
			this.label8.TabIndex = 14;
			this.label8.Text = "N° Documento";
			// 
			// txt_PeliculaHasta
			// 
			this.txt_PeliculaHasta.Location = new System.Drawing.Point(213, 13);
			this.txt_PeliculaHasta.MaxLength = 10;
			this.txt_PeliculaHasta.Name = "txt_PeliculaHasta";
			this.txt_PeliculaHasta.Size = new System.Drawing.Size(100, 20);
			this.txt_PeliculaHasta.TabIndex = 7;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(178, 16);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(35, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "Hasta";
			// 
			// dtp_Fecha_inicio
			// 
			this.dtp_Fecha_inicio.CustomFormat = "dd/MM/yyyy";
			this.dtp_Fecha_inicio.Enabled = false;
			this.dtp_Fecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_Fecha_inicio.Location = new System.Drawing.Point(311, 63);
			this.dtp_Fecha_inicio.Name = "dtp_Fecha_inicio";
			this.dtp_Fecha_inicio.Size = new System.Drawing.Size(98, 20);
			this.dtp_Fecha_inicio.TabIndex = 11;
			// 
			// btn_Agregar
			// 
			this.btn_Agregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btn_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btn_Agregar.Image = global::ControlDosimetro.Properties.Resources.Save_32;
			this.btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Agregar.Location = new System.Drawing.Point(311, 156);
			this.btn_Agregar.Name = "btn_Agregar";
			this.btn_Agregar.Size = new System.Drawing.Size(87, 40);
			this.btn_Agregar.TabIndex = 17;
			this.btn_Agregar.Text = "Agregar";
			this.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_Agregar.UseVisualStyleBackColor = true;
			this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
			// 
			// txt_Pelicula
			// 
			this.txt_Pelicula.Location = new System.Drawing.Point(72, 13);
			this.txt_Pelicula.MaxLength = 10;
			this.txt_Pelicula.Name = "txt_Pelicula";
			this.txt_Pelicula.Size = new System.Drawing.Size(100, 20);
			this.txt_Pelicula.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(213, 65);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(92, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "Fecha Recepción";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "N° Pelicula";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 36;
			this.label1.Text = "periodo";
			// 
			// cbx_anno
			// 
			this.cbx_anno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_anno.FormattingEnabled = true;
			this.cbx_anno.Location = new System.Drawing.Point(87, 19);
			this.cbx_anno.Name = "cbx_anno";
			this.cbx_anno.Size = new System.Drawing.Size(121, 21);
			this.cbx_anno.TabIndex = 1;
			this.cbx_anno.SelectedIndexChanged += new System.EventHandler(this.cbx_anno_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 34;
			this.label2.Text = "N°  Cliente";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Año";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.pnl_Progreso);
			this.groupBox2.Controls.Add(this.grdDatos);
			this.groupBox2.Location = new System.Drawing.Point(0, 414);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(465, 270);
			this.groupBox2.TabIndex = 18;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Listado";
			// 
			// pnl_Progreso
			// 
			this.pnl_Progreso.Controls.Add(this.pgb_Barra);
			this.pnl_Progreso.Location = new System.Drawing.Point(54, 89);
			this.pnl_Progreso.Name = "pnl_Progreso";
			this.pnl_Progreso.Size = new System.Drawing.Size(338, 118);
			this.pnl_Progreso.TabIndex = 10;
			this.pnl_Progreso.TabStop = false;
			this.pnl_Progreso.Text = "Progreso de Grabado";
			// 
			// pgb_Barra
			// 
			this.pgb_Barra.Location = new System.Drawing.Point(21, 43);
			this.pgb_Barra.Name = "pgb_Barra";
			this.pgb_Barra.Size = new System.Drawing.Size(311, 23);
			this.pgb_Barra.TabIndex = 0;
			// 
			// grdDatos
			// 
			this.grdDatos.AllowUserToAddRows = false;
			this.grdDatos.AllowUserToDeleteRows = false;
			this.grdDatos.AllowUserToResizeColumns = false;
			this.grdDatos.AllowUserToResizeRows = false;
			this.grdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.grdDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.id_estadodosimetro,
            this.N_Pelicula,
            this.Descripcion,
            this.N_documento,
            this.ColFecha_ingreso});
			this.grdDatos.ContextMenuStrip = this.cmsPopup;
			this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdDatos.Location = new System.Drawing.Point(3, 16);
			this.grdDatos.Name = "grdDatos";
			this.grdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
			this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdDatos.Size = new System.Drawing.Size(459, 251);
			this.grdDatos.TabIndex = 8;
			this.grdDatos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdDatos_CellFormatting);
			this.grdDatos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_CellValueChanged);
			this.grdDatos.CurrentCellDirtyStateChanged += new System.EventHandler(this.grdDatos_CurrentCellDirtyStateChanged);
			// 
			// cmsPopup
			// 
			this.cmsPopup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEliminar});
			this.cmsPopup.Name = "contextMenuStrip1";
			this.cmsPopup.Size = new System.Drawing.Size(118, 26);
			// 
			// tsmEliminar
			// 
			this.tsmEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsmEliminar.Name = "tsmEliminar";
			this.tsmEliminar.Size = new System.Drawing.Size(117, 22);
			this.tsmEliminar.Text = "Eliminar";
			this.tsmEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.tsmEliminar.Click += new System.EventHandler(this.tsmEliminar_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Imprimir,
            this.tsdReporte});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(470, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsb_Imprimir
			// 
			this.tsb_Imprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsb_Imprimir.Image = global::ControlDosimetro.Properties.Resources.print_32;
			this.tsb_Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsb_Imprimir.Name = "tsb_Imprimir";
			this.tsb_Imprimir.Size = new System.Drawing.Size(23, 22);
			this.tsb_Imprimir.Text = "Imprimir";
			this.tsb_Imprimir.Click += new System.EventHandler(this.tsb_Imprimir_Click);
			// 
			// tsdReporte
			// 
			this.tsdReporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsdReporte.Image = ((System.Drawing.Image)(resources.GetObject("tsdReporte.Image")));
			this.tsdReporte.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsdReporte.Name = "tsdReporte";
			this.tsdReporte.Size = new System.Drawing.Size(61, 22);
			this.tsdReporte.Text = "Reporte";
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Personal";
			this.dataGridViewTextBoxColumn1.HeaderText = "Id_Personal";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Visible = false;
			this.dataGridViewTextBoxColumn1.Width = 88;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "id_dosimetro";
			this.dataGridViewTextBoxColumn2.HeaderText = "Id_dosimetro";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Visible = false;
			this.dataGridViewTextBoxColumn2.Width = 92;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Id_Cliente";
			this.dataGridViewTextBoxColumn3.HeaderText = "N° Cliente";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn3.Width = 79;
			// 
			// integerGridColumn1
			// 
			this.integerGridColumn1.DataPropertyName = "N_Documento";
			this.integerGridColumn1.HeaderText = "N° Documento";
			this.integerGridColumn1.Name = "integerGridColumn1";
			this.integerGridColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.integerGridColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.integerGridColumn1.Width = 102;
			// 
			// integerGridColumn2
			// 
			this.integerGridColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.integerGridColumn2.DataPropertyName = "N_Pelicula";
			this.integerGridColumn2.HeaderText = "Nº Pelicula";
			this.integerGridColumn2.Name = "integerGridColumn2";
			this.integerGridColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.integerGridColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.dataGridViewTextBoxColumn4.DataPropertyName = "N_Documento";
			this.dataGridViewTextBoxColumn4.HeaderText = "N° Documento";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.dataGridViewTextBoxColumn5.DataPropertyName = "N_Pelicula";
			this.dataGridViewTextBoxColumn5.HeaderText = "Nº Pelicula";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Rut";
			this.dataGridViewTextBoxColumn6.FillWeight = 300F;
			this.dataGridViewTextBoxColumn6.HeaderText = "Rut";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.dataGridViewTextBoxColumn7.DataPropertyName = "Nombres";
			this.dataGridViewTextBoxColumn7.HeaderText = "Nombres";
			this.dataGridViewTextBoxColumn7.MinimumWidth = 150;
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.dataGridViewTextBoxColumn8.DataPropertyName = "Paterno";
			dataGridViewCellStyle1.Format = "N2";
			dataGridViewCellStyle1.NullValue = "0";
			this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewTextBoxColumn8.FillWeight = 300F;
			this.dataGridViewTextBoxColumn8.HeaderText = "Paterno";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.dataGridViewTextBoxColumn9.DataPropertyName = "Maternos";
			this.dataGridViewTextBoxColumn9.HeaderText = "Maternos";
			this.dataGridViewTextBoxColumn9.MinimumWidth = 150;
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.DataPropertyName = "dosis";
			dataGridViewCellStyle2.Format = "N2";
			dataGridViewCellStyle2.NullValue = "0";
			this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewTextBoxColumn10.HeaderText = "Valor Ingresar";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn10.Width = 97;
			// 
			// btn_Imprimir
			// 
			this.btn_Imprimir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_Imprimir.Location = new System.Drawing.Point(27, 692);
			this.btn_Imprimir.Name = "btn_Imprimir";
			this.btn_Imprimir.Size = new System.Drawing.Size(97, 23);
			this.btn_Imprimir.TabIndex = 7;
			this.btn_Imprimir.Text = "Imprimir sobre";
			this.btn_Imprimir.UseVisualStyleBackColor = true;
			this.btn_Imprimir.Click += new System.EventHandler(this.btn_Imprimir_Click);
			// 
			// btn_Cerrar
			// 
			this.btn_Cerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_Cerrar.Location = new System.Drawing.Point(371, 690);
			this.btn_Cerrar.Name = "btn_Cerrar";
			this.btn_Cerrar.Size = new System.Drawing.Size(75, 23);
			this.btn_Cerrar.TabIndex = 9;
			this.btn_Cerrar.Text = "Cerrar";
			this.btn_Cerrar.UseVisualStyleBackColor = true;
			this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
			// 
			// btn_IngresoDosimetro
			// 
			this.btn_IngresoDosimetro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_IngresoDosimetro.Location = new System.Drawing.Point(154, 692);
			this.btn_IngresoDosimetro.Name = "btn_IngresoDosimetro";
			this.btn_IngresoDosimetro.Size = new System.Drawing.Size(167, 23);
			this.btn_IngresoDosimetro.TabIndex = 10;
			this.btn_IngresoDosimetro.Text = "Impresión Documento";
			this.btn_IngresoDosimetro.UseVisualStyleBackColor = true;
			this.btn_IngresoDosimetro.Click += new System.EventHandler(this.btn_IngresoDosimetro_Click);
			// 
			// id
			// 
			this.id.DataPropertyName = "id";
			this.id.HeaderText = "id";
			this.id.Name = "id";
			this.id.Visible = false;
			this.id.Width = 40;
			// 
			// id_estadodosimetro
			// 
			this.id_estadodosimetro.DataPropertyName = "id_estadodosimetro";
			this.id_estadodosimetro.HeaderText = "id_estadodosimetro";
			this.id_estadodosimetro.Name = "id_estadodosimetro";
			this.id_estadodosimetro.Visible = false;
			this.id_estadodosimetro.Width = 123;
			// 
			// N_Pelicula
			// 
			this.N_Pelicula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.N_Pelicula.DataPropertyName = "n_dosimetro";
			this.N_Pelicula.HeaderText = "Nº Pelicula";
			this.N_Pelicula.Name = "N_Pelicula";
			this.N_Pelicula.ReadOnly = true;
			this.N_Pelicula.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.N_Pelicula.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.N_Pelicula.Width = 84;
			// 
			// Descripcion
			// 
			this.Descripcion.DataPropertyName = "Descripcion";
			this.Descripcion.HeaderText = "Descripcion";
			this.Descripcion.Name = "Descripcion";
			this.Descripcion.ReadOnly = true;
			this.Descripcion.Width = 88;
			// 
			// N_documento
			// 
			this.N_documento.DataPropertyName = "N_documento";
			this.N_documento.HeaderText = "N° Documento";
			this.N_documento.Name = "N_documento";
			this.N_documento.ReadOnly = true;
			this.N_documento.Width = 102;
			// 
			// ColFecha_ingreso
			// 
			this.ColFecha_ingreso.DataPropertyName = "Fecha_ingreso";
			this.ColFecha_ingreso.HeaderText = "Fecha ingreso";
			this.ColFecha_ingreso.Name = "ColFecha_ingreso";
			this.ColFecha_ingreso.ReadOnly = true;
			this.ColFecha_ingreso.Width = 99;
			// 
			// frmIngresoPeliculaDosi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(470, 722);
			this.Controls.Add(this.btn_IngresoDosimetro);
			this.Controls.Add(this.btn_Cerrar);
			this.Controls.Add(this.btn_Imprimir);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmIngresoPeliculaDosi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ingreso Pelicula";
			this.Load += new System.EventHandler(this.frmIngresoPelicula_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.grp_Ingreso.ResumeLayout(false);
			this.grp_Ingreso.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pctAgregarSucursal)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.pnl_Progreso.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
			this.cmsPopup.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		  private System.Windows.Forms.GroupBox groupBox1;
		  private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
		  private System.Windows.Forms.DataGridView grdDatos;
		  private System.Windows.Forms.ToolStrip toolStrip1;
          private System.Windows.Forms.Label label2;
								private System.Windows.Forms.Label label1;
								private System.Windows.Forms.ComboBox cbx_anno;
								private System.Windows.Forms.GroupBox grp_Ingreso;
								private System.Windows.Forms.Label label5;
								private System.Windows.Forms.Label label4;
                                private System.Windows.Forms.TextBox txt_Pelicula;
								private System.Windows.Forms.Button btn_Agregar;
                                private System.Windows.Forms.Label lbl_nombreCliente;
								private System.Windows.Forms.ComboBox cbx_id_periodo;
                                private System.Windows.Forms.Button btn_cargar;
                                private System.Windows.Forms.Button btn_filtro;
                                private System.Windows.Forms.GroupBox pnl_Progreso;
                                private System.Windows.Forms.ProgressBar pgb_Barra;
                                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
                                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
                                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
                                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
                                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
                                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
                                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
                                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
                                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
                                private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
                                private GridExtension.IntegerGridColumn integerGridColumn1;
                                private GridExtension.IntegerGridColumn integerGridColumn2;
                                private System.Windows.Forms.DateTimePicker dtp_Fecha_inicio;
                                private System.Windows.Forms.ContextMenuStrip cmsPopup;
                                private System.Windows.Forms.ToolStripMenuItem tsmEliminar;
                                private System.Windows.Forms.Label lbl_Direccion;
                                private System.Windows.Forms.Label label6;
                                private System.Windows.Forms.Button btn_Imprimir;
                                private System.Windows.Forms.TextBox txt_PeliculaHasta;
                                private System.Windows.Forms.Label label7;
                                private System.Windows.Forms.Button btn_Cerrar;
                                private System.Windows.Forms.TextBox txt_NDocumento;
                                private System.Windows.Forms.Label label8;
                                private System.Windows.Forms.CheckBox chk_Ref;
                                private System.Windows.Forms.Button btn_IngresoDosimetro;
                                private System.Windows.Forms.TextBox txt_Observacion;
                                private System.Windows.Forms.Label label9;
                                private System.Windows.Forms.TextBox lbl_id_cliente;
                                private System.Windows.Forms.Button btn_Cargar_cliente;
                                private System.Windows.Forms.Label label11;
                                private System.Windows.Forms.Label lbl_rut;
                                private System.Windows.Forms.TextBox txt_Servicio;
                                private System.Windows.Forms.Label label10;
                                private System.Windows.Forms.ComboBox cbx_Sucursal;
                                private System.Windows.Forms.Label label12;
                                private System.Windows.Forms.DateTimePicker dtp_Fecha_dev;
                                private System.Windows.Forms.Label label13;
                                private System.Windows.Forms.TextBox txt_pelrefhasta;
                                private System.Windows.Forms.Label label15;
                                private System.Windows.Forms.TextBox txt_pelrefdesde;
                                private System.Windows.Forms.Label label14;
                                private System.Windows.Forms.PictureBox pctAgregarSucursal;
                                private System.Windows.Forms.ToolStripButton tsb_Imprimir;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.ToolStripDropDownButton tsdReporte;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_estadodosimetro;
		private GridExtension.IntegerGridColumn N_Pelicula;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn N_documento;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColFecha_ingreso;
	}
}