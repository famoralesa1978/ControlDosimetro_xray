namespace ControlDosimetro
{
    partial class frmCambioSucursal
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.grpDatosCliente = new System.Windows.Forms.GroupBox();
			this.cbx_SucCambio = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cbx_SucActual = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btn_Cargar = new System.Windows.Forms.Button();
			this.lbl_NombreCliente = new System.Windows.Forms.Label();
			this.lbl_NCliente = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_filtro = new System.Windows.Forms.Button();
			this.txt_NDoc = new System.Windows.Forms.TextBox();
			this.btn_Guardar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.cmsPopup = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmEliminar = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
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
			this.fdgLetra = new System.Windows.Forms.FontDialog();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.btn_EliminarSeleccion = new System.Windows.Forms.ToolStripMenuItem();
			this.tabPrincipal = new System.Windows.Forms.TabControl();
			this.tabSucursal = new System.Windows.Forms.TabPage();
			this.tabTLD = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbx_SucursalCambiar = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.btnModificarTLD = new System.Windows.Forms.Button();
			this.cbx_Sucursal = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.btn_CargarCli = new System.Windows.Forms.Button();
			this.lbl_id_cliente = new System.Windows.Forms.TextBox();
			this.lbl_rut_cliente = new System.Windows.Forms.Label();
			this.lblRazonSocialTLD = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.grpDatosCliente.SuspendLayout();
			this.cmsPopup.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.tabPrincipal.SuspendLayout();
			this.tabSucursal.SuspendLayout();
			this.tabTLD.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpDatosCliente
			// 
			this.grpDatosCliente.Controls.Add(this.cbx_SucCambio);
			this.grpDatosCliente.Controls.Add(this.label5);
			this.grpDatosCliente.Controls.Add(this.label4);
			this.grpDatosCliente.Controls.Add(this.cbx_SucActual);
			this.grpDatosCliente.Controls.Add(this.label3);
			this.grpDatosCliente.Controls.Add(this.btn_Cargar);
			this.grpDatosCliente.Controls.Add(this.lbl_NombreCliente);
			this.grpDatosCliente.Controls.Add(this.lbl_NCliente);
			this.grpDatosCliente.Controls.Add(this.label1);
			this.grpDatosCliente.Controls.Add(this.btn_filtro);
			this.grpDatosCliente.Controls.Add(this.txt_NDoc);
			this.grpDatosCliente.Controls.Add(this.btn_Guardar);
			this.grpDatosCliente.Controls.Add(this.label2);
			this.grpDatosCliente.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grpDatosCliente.Location = new System.Drawing.Point(3, 3);
			this.grpDatosCliente.Name = "grpDatosCliente";
			this.grpDatosCliente.Size = new System.Drawing.Size(610, 243);
			this.grpDatosCliente.TabIndex = 1;
			this.grpDatosCliente.TabStop = false;
			this.grpDatosCliente.Text = "Dato ";
			// 
			// cbx_SucCambio
			// 
			this.cbx_SucCambio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_SucCambio.FormattingEnabled = true;
			this.cbx_SucCambio.Location = new System.Drawing.Point(109, 123);
			this.cbx_SucCambio.Name = "cbx_SucCambio";
			this.cbx_SucCambio.Size = new System.Drawing.Size(317, 21);
			this.cbx_SucCambio.TabIndex = 43;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(16, 123);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 13);
			this.label5.TabIndex = 42;
			this.label5.Text = "Sucursal";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(14, 97);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(97, 13);
			this.label4.TabIndex = 41;
			this.label4.Text = "Sucursal a modicar";
			// 
			// cbx_SucActual
			// 
			this.cbx_SucActual.Enabled = false;
			this.cbx_SucActual.FormattingEnabled = true;
			this.cbx_SucActual.Location = new System.Drawing.Point(109, 63);
			this.cbx_SucActual.Margin = new System.Windows.Forms.Padding(2);
			this.cbx_SucActual.Name = "cbx_SucActual";
			this.cbx_SucActual.Size = new System.Drawing.Size(317, 21);
			this.cbx_SucActual.TabIndex = 40;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 69);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 13);
			this.label3.TabIndex = 39;
			this.label3.Text = "Sucursal actual";
			// 
			// btn_Cargar
			// 
			this.btn_Cargar.Location = new System.Drawing.Point(187, 15);
			this.btn_Cargar.Margin = new System.Windows.Forms.Padding(2);
			this.btn_Cargar.Name = "btn_Cargar";
			this.btn_Cargar.Size = new System.Drawing.Size(57, 20);
			this.btn_Cargar.TabIndex = 38;
			this.btn_Cargar.Text = "Cargar";
			this.btn_Cargar.UseVisualStyleBackColor = true;
			this.btn_Cargar.Click += new System.EventHandler(this.btn_Cargar_Click);
			// 
			// lbl_NombreCliente
			// 
			this.lbl_NombreCliente.AutoSize = true;
			this.lbl_NombreCliente.Location = new System.Drawing.Point(142, 41);
			this.lbl_NombreCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_NombreCliente.Name = "lbl_NombreCliente";
			this.lbl_NombreCliente.Size = new System.Drawing.Size(79, 13);
			this.lbl_NombreCliente.TabIndex = 37;
			this.lbl_NombreCliente.Text = "Nombre Cliente";
			// 
			// lbl_NCliente
			// 
			this.lbl_NCliente.AutoSize = true;
			this.lbl_NCliente.Location = new System.Drawing.Point(109, 41);
			this.lbl_NCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_NCliente.Name = "lbl_NCliente";
			this.lbl_NCliente.Size = new System.Drawing.Size(29, 13);
			this.lbl_NCliente.TabIndex = 36;
			this.lbl_NCliente.Text = "Num";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 41);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 35;
			this.label1.Text = "Cliente";
			// 
			// btn_filtro
			// 
			this.btn_filtro.Location = new System.Drawing.Point(201, 168);
			this.btn_filtro.Name = "btn_filtro";
			this.btn_filtro.Size = new System.Drawing.Size(95, 23);
			this.btn_filtro.TabIndex = 4;
			this.btn_filtro.Text = "Limpiar filtro";
			this.btn_filtro.UseVisualStyleBackColor = true;
			this.btn_filtro.Click += new System.EventHandler(this.Btn_filtro_Click);
			// 
			// txt_NDoc
			// 
			this.txt_NDoc.Location = new System.Drawing.Point(109, 17);
			this.txt_NDoc.MaxLength = 10;
			this.txt_NDoc.Name = "txt_NDoc";
			this.txt_NDoc.Size = new System.Drawing.Size(74, 20);
			this.txt_NDoc.TabIndex = 1;
			// 
			// btn_Guardar
			// 
			this.btn_Guardar.Location = new System.Drawing.Point(81, 168);
			this.btn_Guardar.Name = "btn_Guardar";
			this.btn_Guardar.Size = new System.Drawing.Size(114, 23);
			this.btn_Guardar.TabIndex = 3;
			this.btn_Guardar.Text = "Modificar sucursal";
			this.btn_Guardar.UseVisualStyleBackColor = true;
			this.btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 13);
			this.label2.TabIndex = 34;
			this.label2.Text = "N°  documento";
			// 
			// cmsPopup
			// 
			this.cmsPopup.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.cmsPopup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEliminar});
			this.cmsPopup.Name = "contextMenuStrip1";
			this.cmsPopup.Size = new System.Drawing.Size(68, 26);
			// 
			// tsmEliminar
			// 
			this.tsmEliminar.Name = "tsmEliminar";
			this.tsmEliminar.Size = new System.Drawing.Size(67, 22);
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(624, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
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
			dataGridViewCellStyle7.Format = "N2";
			dataGridViewCellStyle7.NullValue = "0";
			this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle7;
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
			dataGridViewCellStyle8.Format = "N2";
			dataGridViewCellStyle8.NullValue = "0";
			this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle8;
			this.dataGridViewTextBoxColumn10.HeaderText = "Valor Ingresar";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn10.Width = 97;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_EliminarSeleccion});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(68, 26);
			// 
			// btn_EliminarSeleccion
			// 
			this.btn_EliminarSeleccion.Name = "btn_EliminarSeleccion";
			this.btn_EliminarSeleccion.Size = new System.Drawing.Size(67, 22);
			// 
			// tabPrincipal
			// 
			this.tabPrincipal.Controls.Add(this.tabSucursal);
			this.tabPrincipal.Controls.Add(this.tabTLD);
			this.tabPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabPrincipal.Location = new System.Drawing.Point(0, 25);
			this.tabPrincipal.Name = "tabPrincipal";
			this.tabPrincipal.SelectedIndex = 0;
			this.tabPrincipal.Size = new System.Drawing.Size(624, 275);
			this.tabPrincipal.TabIndex = 3;
			// 
			// tabSucursal
			// 
			this.tabSucursal.Controls.Add(this.grpDatosCliente);
			this.tabSucursal.Location = new System.Drawing.Point(4, 22);
			this.tabSucursal.Name = "tabSucursal";
			this.tabSucursal.Padding = new System.Windows.Forms.Padding(3);
			this.tabSucursal.Size = new System.Drawing.Size(616, 249);
			this.tabSucursal.TabIndex = 0;
			this.tabSucursal.Text = "Filmicos";
			this.tabSucursal.UseVisualStyleBackColor = true;
			// 
			// tabTLD
			// 
			this.tabTLD.Controls.Add(this.groupBox1);
			this.tabTLD.Location = new System.Drawing.Point(4, 22);
			this.tabTLD.Name = "tabTLD";
			this.tabTLD.Padding = new System.Windows.Forms.Padding(3);
			this.tabTLD.Size = new System.Drawing.Size(616, 249);
			this.tabTLD.TabIndex = 1;
			this.tabTLD.Text = "Corregir sucursal";
			this.tabTLD.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbx_SucursalCambiar);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.btnModificarTLD);
			this.groupBox1.Controls.Add(this.cbx_Sucursal);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.btn_CargarCli);
			this.groupBox1.Controls.Add(this.lbl_id_cliente);
			this.groupBox1.Controls.Add(this.lbl_rut_cliente);
			this.groupBox1.Controls.Add(this.lblRazonSocialTLD);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(610, 243);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Datos";
			// 
			// cbx_SucursalCambiar
			// 
			this.cbx_SucursalCambiar.DisplayMember = "Direccion";
			this.cbx_SucursalCambiar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_SucursalCambiar.FormattingEnabled = true;
			this.cbx_SucursalCambiar.Location = new System.Drawing.Point(124, 120);
			this.cbx_SucursalCambiar.Name = "cbx_SucursalCambiar";
			this.cbx_SucursalCambiar.Size = new System.Drawing.Size(484, 21);
			this.cbx_SucursalCambiar.TabIndex = 5;
			this.cbx_SucursalCambiar.ValueMember = "Id_sucursal";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(7, 123);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(97, 13);
			this.label11.TabIndex = 63;
			this.label11.Text = "Sucursal a cambiar";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(222, 197);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(95, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "Limpiar filtro";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// btnModificarTLD
			// 
			this.btnModificarTLD.Location = new System.Drawing.Point(102, 197);
			this.btnModificarTLD.Name = "btnModificarTLD";
			this.btnModificarTLD.Size = new System.Drawing.Size(114, 23);
			this.btnModificarTLD.TabIndex = 6;
			this.btnModificarTLD.Text = "Modificar sucursal";
			this.btnModificarTLD.UseVisualStyleBackColor = true;
			this.btnModificarTLD.Click += new System.EventHandler(this.btnModificarTLD_Click);
			// 
			// cbx_Sucursal
			// 
			this.cbx_Sucursal.DisplayMember = "Direccion";
			this.cbx_Sucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_Sucursal.FormattingEnabled = true;
			this.cbx_Sucursal.Location = new System.Drawing.Point(124, 93);
			this.cbx_Sucursal.Name = "cbx_Sucursal";
			this.cbx_Sucursal.Size = new System.Drawing.Size(484, 21);
			this.cbx_Sucursal.TabIndex = 4;
			this.cbx_Sucursal.ValueMember = "Id_sucursal";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(7, 96);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(48, 13);
			this.label10.TabIndex = 59;
			this.label10.Text = "Sucursal";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(7, 65);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(24, 13);
			this.label6.TabIndex = 58;
			this.label6.Text = "Rut";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(7, 46);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(68, 13);
			this.label7.TabIndex = 57;
			this.label7.Text = "Razon social";
			// 
			// btn_CargarCli
			// 
			this.btn_CargarCli.Location = new System.Drawing.Point(200, 15);
			this.btn_CargarCli.Name = "btn_CargarCli";
			this.btn_CargarCli.Size = new System.Drawing.Size(106, 23);
			this.btn_CargarCli.TabIndex = 1;
			this.btn_CargarCli.Text = "Cargar cliente";
			this.btn_CargarCli.UseVisualStyleBackColor = true;
			this.btn_CargarCli.Click += new System.EventHandler(this.btn_CargarCli_Click);
			// 
			// lbl_id_cliente
			// 
			this.lbl_id_cliente.Location = new System.Drawing.Point(82, 19);
			this.lbl_id_cliente.Name = "lbl_id_cliente";
			this.lbl_id_cliente.Size = new System.Drawing.Size(100, 20);
			this.lbl_id_cliente.TabIndex = 0;
			// 
			// lbl_rut_cliente
			// 
			this.lbl_rut_cliente.AutoSize = true;
			this.lbl_rut_cliente.Location = new System.Drawing.Point(79, 65);
			this.lbl_rut_cliente.Name = "lbl_rut_cliente";
			this.lbl_rut_cliente.Size = new System.Drawing.Size(53, 13);
			this.lbl_rut_cliente.TabIndex = 3;
			this.lbl_rut_cliente.Text = "rut cliente";
			// 
			// lblRazonSocialTLD
			// 
			this.lblRazonSocialTLD.AutoSize = true;
			this.lblRazonSocialTLD.Location = new System.Drawing.Point(79, 46);
			this.lblRazonSocialTLD.Name = "lblRazonSocialTLD";
			this.lblRazonSocialTLD.Size = new System.Drawing.Size(35, 13);
			this.lblRazonSocialTLD.TabIndex = 2;
			this.lblRazonSocialTLD.Text = "label1";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(7, 27);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(57, 13);
			this.label9.TabIndex = 51;
			this.label9.Text = "N°  Cliente";
			// 
			// frmCambioSucursal
			// 
			this.AcceptButton = this.btn_Cargar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 300);
			this.Controls.Add(this.tabPrincipal);
			this.Controls.Add(this.toolStrip1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmCambioSucursal";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cambio sucursal";
			this.grpDatosCliente.ResumeLayout(false);
			this.grpDatosCliente.PerformLayout();
			this.cmsPopup.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			this.tabPrincipal.ResumeLayout(false);
			this.tabSucursal.ResumeLayout(false);
			this.tabTLD.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosCliente;
		  private System.Windows.Forms.ToolStrip toolStrip1;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Button btn_Guardar;
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
                                private System.Windows.Forms.ContextMenuStrip cmsPopup;
                                private System.Windows.Forms.ToolStripMenuItem tsmEliminar;
                                private System.Windows.Forms.TextBox txt_NDoc;
                                private System.Windows.Forms.FontDialog fdgLetra;
                                private System.Windows.Forms.ColorDialog colorDialog1;
                                private System.Windows.Forms.OpenFileDialog openFileDialog1;
                                private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
                                private System.Windows.Forms.ToolStripMenuItem btn_EliminarSeleccion;
                                private System.Windows.Forms.Button btn_filtro;
		private System.Windows.Forms.Label lbl_NombreCliente;
		private System.Windows.Forms.Label lbl_NCliente;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_Cargar;
		private System.Windows.Forms.ComboBox cbx_SucActual;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cbx_SucCambio;
		private System.Windows.Forms.TabControl tabPrincipal;
		private System.Windows.Forms.TabPage tabSucursal;
		private System.Windows.Forms.TabPage tabTLD;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btn_CargarCli;
		private System.Windows.Forms.TextBox lbl_id_cliente;
		private System.Windows.Forms.Label lbl_rut_cliente;
		private System.Windows.Forms.Label lblRazonSocialTLD;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox cbx_Sucursal;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cbx_SucursalCambiar;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnModificarTLD;
	}
}