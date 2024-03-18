namespace ControlDosimetro
{
    partial class frmCambioPersonalTLD
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lblRut = new System.Windows.Forms.Label();
			this.cbx_PersonalCambio = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cbx_PersonalActual = new System.Windows.Forms.ComboBox();
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
			this.grpDatos = new System.Windows.Forms.GroupBox();
			this.tabPrincipal = new System.Windows.Forms.TabControl();
			this.tabPersonal = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tabSeccion = new System.Windows.Forms.TabPage();
			this.cbx_id_seccionMod = new System.Windows.Forms.ComboBox();
			this.btn_ModificarSeccion = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.cbx_id_seccion = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.tabDireccion = new System.Windows.Forms.TabPage();
			this.cbxDireccionMod = new System.Windows.Forms.ComboBox();
			this.btnDireccionMod = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.cbxDireccionActual = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.tabAsociarTLDEnviadoAlCliente = new System.Windows.Forms.TabPage();
			this.btnAsociarTLDConElOriginal = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.nudTLDEnviadoAlCliente = new System.Windows.Forms.NumericUpDown();
			this.tabCambioEstado = new System.Windows.Forms.TabPage();
			this.lblEstadoActual = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.btnCambioestado = new System.Windows.Forms.Button();
			this.label14 = new System.Windows.Forms.Label();
			this.cbxEstado = new System.Windows.Forms.ComboBox();
			this.lblNombrePersonal = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.tabNDocumento = new System.Windows.Forms.TabPage();
			this.txtNDocumento = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.btnGuardarDireccionNDcto = new System.Windows.Forms.Button();
			this.cbxDireccionDctoCambiar = new System.Windows.Forms.ComboBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.cbxDireccionDctoActual = new System.Windows.Forms.ComboBox();
			this.label18 = new System.Windows.Forms.Label();
			this.tabRecuperar = new System.Windows.Forms.TabPage();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnRecuperarTLD = new System.Windows.Forms.Button();
			this.txtCliente = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.txtPersonal = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.txtNTLDRecuperar = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.lblRecupMensajeTLD = new System.Windows.Forms.Label();
			this.tabEliminar = new System.Windows.Forms.TabPage();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.lblPersonalEliminar = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.tabCambioPeriodo = new System.Windows.Forms.TabPage();
			this.btnCambioPeriodo = new System.Windows.Forms.Button();
			this.label23 = new System.Windows.Forms.Label();
			this.txtListaTLD = new System.Windows.Forms.TextBox();
			this.label25 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.txtNDocumentoCambiarPeriodo = new System.Windows.Forms.TextBox();
			this.label27 = new System.Windows.Forms.Label();
			this.ddlPeriodoCambiarPeriodo = new System.Windows.Forms.ComboBox();
			this.label28 = new System.Windows.Forms.Label();
			this.lblPeriodoActual = new System.Windows.Forms.Label();
			this.cmsPopup.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.grpDatos.SuspendLayout();
			this.tabPrincipal.SuspendLayout();
			this.tabPersonal.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tabSeccion.SuspendLayout();
			this.tabDireccion.SuspendLayout();
			this.tabAsociarTLDEnviadoAlCliente.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudTLDEnviadoAlCliente)).BeginInit();
			this.tabCambioEstado.SuspendLayout();
			this.tabNDocumento.SuspendLayout();
			this.tabRecuperar.SuspendLayout();
			this.panel2.SuspendLayout();
			this.tabEliminar.SuspendLayout();
			this.tabCambioPeriodo.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblRut
			// 
			this.lblRut.AutoSize = true;
			this.lblRut.Location = new System.Drawing.Point(109, 73);
			this.lblRut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblRut.Name = "lblRut";
			this.lblRut.Size = new System.Drawing.Size(29, 13);
			this.lblRut.TabIndex = 44;
			this.lblRut.Text = "Num";
			// 
			// cbx_PersonalCambio
			// 
			this.cbx_PersonalCambio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_PersonalCambio.FormattingEnabled = true;
			this.cbx_PersonalCambio.Location = new System.Drawing.Point(111, 97);
			this.cbx_PersonalCambio.Name = "cbx_PersonalCambio";
			this.cbx_PersonalCambio.Size = new System.Drawing.Size(317, 21);
			this.cbx_PersonalCambio.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(11, 100);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 13);
			this.label5.TabIndex = 42;
			this.label5.Text = "Personal";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(11, 68);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(115, 13);
			this.label4.TabIndex = 41;
			this.label4.Text = "Personal a modicar";
			// 
			// cbx_PersonalActual
			// 
			this.cbx_PersonalActual.Enabled = false;
			this.cbx_PersonalActual.FormattingEnabled = true;
			this.cbx_PersonalActual.Location = new System.Drawing.Point(111, 23);
			this.cbx_PersonalActual.Margin = new System.Windows.Forms.Padding(2);
			this.cbx_PersonalActual.Name = "cbx_PersonalActual";
			this.cbx_PersonalActual.Size = new System.Drawing.Size(317, 21);
			this.cbx_PersonalActual.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 26);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 13);
			this.label3.TabIndex = 39;
			this.label3.Text = "Personal actual";
			// 
			// btn_Cargar
			// 
			this.btn_Cargar.Location = new System.Drawing.Point(187, 26);
			this.btn_Cargar.Margin = new System.Windows.Forms.Padding(2);
			this.btn_Cargar.Name = "btn_Cargar";
			this.btn_Cargar.Size = new System.Drawing.Size(57, 24);
			this.btn_Cargar.TabIndex = 1;
			this.btn_Cargar.Text = "Cargar";
			this.btn_Cargar.UseVisualStyleBackColor = true;
			this.btn_Cargar.Click += new System.EventHandler(this.btn_Cargar_Click);
			// 
			// lbl_NombreCliente
			// 
			this.lbl_NombreCliente.AutoSize = true;
			this.lbl_NombreCliente.Location = new System.Drawing.Point(142, 52);
			this.lbl_NombreCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_NombreCliente.Name = "lbl_NombreCliente";
			this.lbl_NombreCliente.Size = new System.Drawing.Size(79, 13);
			this.lbl_NombreCliente.TabIndex = 37;
			this.lbl_NombreCliente.Text = "Nombre Cliente";
			// 
			// lbl_NCliente
			// 
			this.lbl_NCliente.AutoSize = true;
			this.lbl_NCliente.Location = new System.Drawing.Point(109, 52);
			this.lbl_NCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_NCliente.Name = "lbl_NCliente";
			this.lbl_NCliente.Size = new System.Drawing.Size(29, 13);
			this.lbl_NCliente.TabIndex = 36;
			this.lbl_NCliente.Text = "Num";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 52);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 35;
			this.label1.Text = "Cliente";
			// 
			// btn_filtro
			// 
			this.btn_filtro.Location = new System.Drawing.Point(262, 25);
			this.btn_filtro.Name = "btn_filtro";
			this.btn_filtro.Size = new System.Drawing.Size(95, 25);
			this.btn_filtro.TabIndex = 2;
			this.btn_filtro.Text = "Limpiar filtro";
			this.btn_filtro.UseVisualStyleBackColor = true;
			this.btn_filtro.Click += new System.EventHandler(this.Btn_filtro_Click);
			// 
			// txt_NDoc
			// 
			this.txt_NDoc.Location = new System.Drawing.Point(109, 28);
			this.txt_NDoc.MaxLength = 10;
			this.txt_NDoc.Name = "txt_NDoc";
			this.txt_NDoc.Size = new System.Drawing.Size(74, 20);
			this.txt_NDoc.TabIndex = 0;
			// 
			// btn_Guardar
			// 
			this.btn_Guardar.Location = new System.Drawing.Point(78, 145);
			this.btn_Guardar.Name = "btn_Guardar";
			this.btn_Guardar.Size = new System.Drawing.Size(114, 23);
			this.btn_Guardar.TabIndex = 2;
			this.btn_Guardar.Text = "Modificar personal";
			this.btn_Guardar.UseVisualStyleBackColor = true;
			this.btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 13);
			this.label2.TabIndex = 34;
			this.label2.Text = "N°  TLD";
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
			this.toolStrip1.Size = new System.Drawing.Size(928, 25);
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
			// grpDatos
			// 
			this.grpDatos.Controls.Add(this.tabPrincipal);
			this.grpDatos.Location = new System.Drawing.Point(0, 126);
			this.grpDatos.Name = "grpDatos";
			this.grpDatos.Size = new System.Drawing.Size(916, 362);
			this.grpDatos.TabIndex = 3;
			this.grpDatos.TabStop = false;
			this.grpDatos.Text = "Datos a modificar";
			// 
			// tabPrincipal
			// 
			this.tabPrincipal.Controls.Add(this.tabPersonal);
			this.tabPrincipal.Controls.Add(this.tabSeccion);
			this.tabPrincipal.Controls.Add(this.tabDireccion);
			this.tabPrincipal.Controls.Add(this.tabAsociarTLDEnviadoAlCliente);
			this.tabPrincipal.Controls.Add(this.tabCambioEstado);
			this.tabPrincipal.Controls.Add(this.tabNDocumento);
			this.tabPrincipal.Controls.Add(this.tabRecuperar);
			this.tabPrincipal.Controls.Add(this.tabEliminar);
			this.tabPrincipal.Controls.Add(this.tabCambioPeriodo);
			this.tabPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabPrincipal.Location = new System.Drawing.Point(3, 16);
			this.tabPrincipal.Name = "tabPrincipal";
			this.tabPrincipal.SelectedIndex = 0;
			this.tabPrincipal.Size = new System.Drawing.Size(910, 343);
			this.tabPrincipal.TabIndex = 0;
			// 
			// tabPersonal
			// 
			this.tabPersonal.BackColor = System.Drawing.SystemColors.Control;
			this.tabPersonal.Controls.Add(this.panel1);
			this.tabPersonal.Location = new System.Drawing.Point(4, 22);
			this.tabPersonal.Name = "tabPersonal";
			this.tabPersonal.Padding = new System.Windows.Forms.Padding(3);
			this.tabPersonal.Size = new System.Drawing.Size(902, 193);
			this.tabPersonal.TabIndex = 0;
			this.tabPersonal.Text = "Personal";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.Controls.Add(this.cbx_PersonalCambio);
			this.panel1.Controls.Add(this.btn_Guardar);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.cbx_PersonalActual);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(896, 187);
			this.panel1.TabIndex = 0;
			// 
			// tabSeccion
			// 
			this.tabSeccion.Controls.Add(this.cbx_id_seccionMod);
			this.tabSeccion.Controls.Add(this.btn_ModificarSeccion);
			this.tabSeccion.Controls.Add(this.label6);
			this.tabSeccion.Controls.Add(this.label7);
			this.tabSeccion.Controls.Add(this.cbx_id_seccion);
			this.tabSeccion.Controls.Add(this.label8);
			this.tabSeccion.Location = new System.Drawing.Point(4, 22);
			this.tabSeccion.Name = "tabSeccion";
			this.tabSeccion.Padding = new System.Windows.Forms.Padding(3);
			this.tabSeccion.Size = new System.Drawing.Size(902, 193);
			this.tabSeccion.TabIndex = 1;
			this.tabSeccion.Text = "Sección";
			this.tabSeccion.UseVisualStyleBackColor = true;
			// 
			// cbx_id_seccionMod
			// 
			this.cbx_id_seccionMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_id_seccionMod.FormattingEnabled = true;
			this.cbx_id_seccionMod.Location = new System.Drawing.Point(116, 90);
			this.cbx_id_seccionMod.Name = "cbx_id_seccionMod";
			this.cbx_id_seccionMod.Size = new System.Drawing.Size(317, 21);
			this.cbx_id_seccionMod.TabIndex = 44;
			// 
			// btn_ModificarSeccion
			// 
			this.btn_ModificarSeccion.Location = new System.Drawing.Point(83, 138);
			this.btn_ModificarSeccion.Name = "btn_ModificarSeccion";
			this.btn_ModificarSeccion.Size = new System.Drawing.Size(114, 23);
			this.btn_ModificarSeccion.TabIndex = 45;
			this.btn_ModificarSeccion.Text = "Modificar sección";
			this.btn_ModificarSeccion.UseVisualStyleBackColor = true;
			this.btn_ModificarSeccion.Click += new System.EventHandler(this.btn_ModificarSeccion_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(16, 19);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(46, 13);
			this.label6.TabIndex = 46;
			this.label6.Text = "Sección";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(16, 93);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(46, 13);
			this.label7.TabIndex = 48;
			this.label7.Text = "Sección";
			// 
			// cbx_id_seccion
			// 
			this.cbx_id_seccion.Enabled = false;
			this.cbx_id_seccion.FormattingEnabled = true;
			this.cbx_id_seccion.Location = new System.Drawing.Point(116, 16);
			this.cbx_id_seccion.Margin = new System.Windows.Forms.Padding(2);
			this.cbx_id_seccion.Name = "cbx_id_seccion";
			this.cbx_id_seccion.Size = new System.Drawing.Size(317, 21);
			this.cbx_id_seccion.TabIndex = 43;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(16, 61);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(112, 13);
			this.label8.TabIndex = 47;
			this.label8.Text = "Sección a modicar";
			// 
			// tabDireccion
			// 
			this.tabDireccion.Controls.Add(this.cbxDireccionMod);
			this.tabDireccion.Controls.Add(this.btnDireccionMod);
			this.tabDireccion.Controls.Add(this.label9);
			this.tabDireccion.Controls.Add(this.label10);
			this.tabDireccion.Controls.Add(this.cbxDireccionActual);
			this.tabDireccion.Controls.Add(this.label11);
			this.tabDireccion.Location = new System.Drawing.Point(4, 22);
			this.tabDireccion.Name = "tabDireccion";
			this.tabDireccion.Size = new System.Drawing.Size(902, 193);
			this.tabDireccion.TabIndex = 2;
			this.tabDireccion.Text = "Dirección";
			this.tabDireccion.UseVisualStyleBackColor = true;
			// 
			// cbxDireccionMod
			// 
			this.cbxDireccionMod.DisplayMember = "Descripcion";
			this.cbxDireccionMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxDireccionMod.FormattingEnabled = true;
			this.cbxDireccionMod.Location = new System.Drawing.Point(123, 90);
			this.cbxDireccionMod.Name = "cbxDireccionMod";
			this.cbxDireccionMod.Size = new System.Drawing.Size(317, 21);
			this.cbxDireccionMod.TabIndex = 44;
			this.cbxDireccionMod.ValueMember = "Id_sucursal";
			// 
			// btnDireccionMod
			// 
			this.btnDireccionMod.Location = new System.Drawing.Point(90, 138);
			this.btnDireccionMod.Name = "btnDireccionMod";
			this.btnDireccionMod.Size = new System.Drawing.Size(114, 23);
			this.btnDireccionMod.TabIndex = 45;
			this.btnDireccionMod.Text = "Modificar dirección";
			this.btnDireccionMod.UseVisualStyleBackColor = true;
			this.btnDireccionMod.Click += new System.EventHandler(this.btnDireccionMod_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(23, 19);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(84, 13);
			this.label9.TabIndex = 46;
			this.label9.Text = "Dirección actual";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(23, 93);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(52, 13);
			this.label10.TabIndex = 48;
			this.label10.Text = "Dirección";
			// 
			// cbxDireccionActual
			// 
			this.cbxDireccionActual.DisplayMember = "Descripcion";
			this.cbxDireccionActual.Enabled = false;
			this.cbxDireccionActual.FormattingEnabled = true;
			this.cbxDireccionActual.Location = new System.Drawing.Point(123, 16);
			this.cbxDireccionActual.Margin = new System.Windows.Forms.Padding(2);
			this.cbxDireccionActual.Name = "cbxDireccionActual";
			this.cbxDireccionActual.Size = new System.Drawing.Size(317, 21);
			this.cbxDireccionActual.TabIndex = 43;
			this.cbxDireccionActual.ValueMember = "Id_sucursal";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(23, 61);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(120, 13);
			this.label11.TabIndex = 47;
			this.label11.Text = "Dirección a modicar";
			// 
			// tabAsociarTLDEnviadoAlCliente
			// 
			this.tabAsociarTLDEnviadoAlCliente.Controls.Add(this.btnAsociarTLDConElOriginal);
			this.tabAsociarTLDEnviadoAlCliente.Controls.Add(this.label12);
			this.tabAsociarTLDEnviadoAlCliente.Controls.Add(this.nudTLDEnviadoAlCliente);
			this.tabAsociarTLDEnviadoAlCliente.Location = new System.Drawing.Point(4, 22);
			this.tabAsociarTLDEnviadoAlCliente.Name = "tabAsociarTLDEnviadoAlCliente";
			this.tabAsociarTLDEnviadoAlCliente.Padding = new System.Windows.Forms.Padding(3);
			this.tabAsociarTLDEnviadoAlCliente.Size = new System.Drawing.Size(902, 193);
			this.tabAsociarTLDEnviadoAlCliente.TabIndex = 3;
			this.tabAsociarTLDEnviadoAlCliente.Text = "Asociar TLD  enviado al cliente";
			this.tabAsociarTLDEnviadoAlCliente.UseVisualStyleBackColor = true;
			// 
			// btnAsociarTLDConElOriginal
			// 
			this.btnAsociarTLDConElOriginal.Location = new System.Drawing.Point(89, 105);
			this.btnAsociarTLDConElOriginal.Name = "btnAsociarTLDConElOriginal";
			this.btnAsociarTLDConElOriginal.Size = new System.Drawing.Size(185, 23);
			this.btnAsociarTLDConElOriginal.TabIndex = 46;
			this.btnAsociarTLDConElOriginal.Text = "Asociar TLD con el original";
			this.btnAsociarTLDConElOriginal.UseVisualStyleBackColor = true;
			this.btnAsociarTLDConElOriginal.Click += new System.EventHandler(this.btnAsociarTLDConElOriginal_Click);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(30, 34);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(129, 13);
			this.label12.TabIndex = 1;
			this.label12.Text = "N° TLD enviado al cliente";
			// 
			// nudTLDEnviadoAlCliente
			// 
			this.nudTLDEnviadoAlCliente.Location = new System.Drawing.Point(180, 32);
			this.nudTLDEnviadoAlCliente.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
			this.nudTLDEnviadoAlCliente.Name = "nudTLDEnviadoAlCliente";
			this.nudTLDEnviadoAlCliente.Size = new System.Drawing.Size(120, 20);
			this.nudTLDEnviadoAlCliente.TabIndex = 0;
			// 
			// tabCambioEstado
			// 
			this.tabCambioEstado.Controls.Add(this.lblEstadoActual);
			this.tabCambioEstado.Controls.Add(this.label16);
			this.tabCambioEstado.Controls.Add(this.btnCambioestado);
			this.tabCambioEstado.Controls.Add(this.label14);
			this.tabCambioEstado.Controls.Add(this.cbxEstado);
			this.tabCambioEstado.Controls.Add(this.lblNombrePersonal);
			this.tabCambioEstado.Controls.Add(this.label13);
			this.tabCambioEstado.Location = new System.Drawing.Point(4, 22);
			this.tabCambioEstado.Name = "tabCambioEstado";
			this.tabCambioEstado.Padding = new System.Windows.Forms.Padding(3);
			this.tabCambioEstado.Size = new System.Drawing.Size(902, 193);
			this.tabCambioEstado.TabIndex = 4;
			this.tabCambioEstado.Text = "Cambio Estado";
			this.tabCambioEstado.UseVisualStyleBackColor = true;
			// 
			// lblEstadoActual
			// 
			this.lblEstadoActual.AutoSize = true;
			this.lblEstadoActual.Location = new System.Drawing.Point(95, 39);
			this.lblEstadoActual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblEstadoActual.Name = "lblEstadoActual";
			this.lblEstadoActual.Size = new System.Drawing.Size(54, 13);
			this.lblEstadoActual.TabIndex = 51;
			this.lblEstadoActual.Text = "Personal :";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(14, 39);
			this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(72, 13);
			this.label16.TabIndex = 50;
			this.label16.Text = "Estado actual";
			// 
			// btnCambioestado
			// 
			this.btnCambioestado.Location = new System.Drawing.Point(98, 92);
			this.btnCambioestado.Name = "btnCambioestado";
			this.btnCambioestado.Size = new System.Drawing.Size(114, 23);
			this.btnCambioestado.TabIndex = 49;
			this.btnCambioestado.Text = "Cambio estado";
			this.btnCambioestado.UseVisualStyleBackColor = true;
			this.btnCambioestado.Click += new System.EventHandler(this.btnCambioestado_Click);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(14, 69);
			this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(40, 13);
			this.label14.TabIndex = 48;
			this.label14.Text = "Estado";
			// 
			// cbxEstado
			// 
			this.cbxEstado.DisplayMember = "Descripcion";
			this.cbxEstado.FormattingEnabled = true;
			this.cbxEstado.Location = new System.Drawing.Point(98, 66);
			this.cbxEstado.Margin = new System.Windows.Forms.Padding(2);
			this.cbxEstado.Name = "cbxEstado";
			this.cbxEstado.Size = new System.Drawing.Size(157, 21);
			this.cbxEstado.TabIndex = 47;
			this.cbxEstado.ValueMember = "id";
			// 
			// lblNombrePersonal
			// 
			this.lblNombrePersonal.AutoSize = true;
			this.lblNombrePersonal.Location = new System.Drawing.Point(95, 17);
			this.lblNombrePersonal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblNombrePersonal.Name = "lblNombrePersonal";
			this.lblNombrePersonal.Size = new System.Drawing.Size(54, 13);
			this.lblNombrePersonal.TabIndex = 41;
			this.lblNombrePersonal.Text = "Personal :";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(14, 17);
			this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(48, 13);
			this.label13.TabIndex = 40;
			this.label13.Text = "Personal";
			// 
			// tabNDocumento
			// 
			this.tabNDocumento.Controls.Add(this.txtNDocumento);
			this.tabNDocumento.Controls.Add(this.label19);
			this.tabNDocumento.Controls.Add(this.btnGuardarDireccionNDcto);
			this.tabNDocumento.Controls.Add(this.cbxDireccionDctoCambiar);
			this.tabNDocumento.Controls.Add(this.label15);
			this.tabNDocumento.Controls.Add(this.label17);
			this.tabNDocumento.Controls.Add(this.cbxDireccionDctoActual);
			this.tabNDocumento.Controls.Add(this.label18);
			this.tabNDocumento.Location = new System.Drawing.Point(4, 22);
			this.tabNDocumento.Name = "tabNDocumento";
			this.tabNDocumento.Size = new System.Drawing.Size(902, 317);
			this.tabNDocumento.TabIndex = 5;
			this.tabNDocumento.Text = "por n° documento";
			this.tabNDocumento.UseVisualStyleBackColor = true;
			// 
			// txtNDocumento
			// 
			this.txtNDocumento.Location = new System.Drawing.Point(122, 105);
			this.txtNDocumento.MaxLength = 10;
			this.txtNDocumento.Name = "txtNDocumento";
			this.txtNDocumento.Size = new System.Drawing.Size(74, 20);
			this.txtNDocumento.TabIndex = 55;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(28, 108);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(75, 13);
			this.label19.TabIndex = 56;
			this.label19.Text = "N° documento";
			// 
			// btnGuardarDireccionNDcto
			// 
			this.btnGuardarDireccionNDcto.Location = new System.Drawing.Point(62, 147);
			this.btnGuardarDireccionNDcto.Name = "btnGuardarDireccionNDcto";
			this.btnGuardarDireccionNDcto.Size = new System.Drawing.Size(114, 23);
			this.btnGuardarDireccionNDcto.TabIndex = 54;
			this.btnGuardarDireccionNDcto.Text = "Modificar dirección";
			this.btnGuardarDireccionNDcto.UseVisualStyleBackColor = true;
			this.btnGuardarDireccionNDcto.Click += new System.EventHandler(this.btnGuardarDireccionNDcto_Click);
			// 
			// cbxDireccionDctoCambiar
			// 
			this.cbxDireccionDctoCambiar.DisplayMember = "Descripcion";
			this.cbxDireccionDctoCambiar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxDireccionDctoCambiar.FormattingEnabled = true;
			this.cbxDireccionDctoCambiar.Location = new System.Drawing.Point(122, 76);
			this.cbxDireccionDctoCambiar.Name = "cbxDireccionDctoCambiar";
			this.cbxDireccionDctoCambiar.Size = new System.Drawing.Size(317, 21);
			this.cbxDireccionDctoCambiar.TabIndex = 50;
			this.cbxDireccionDctoCambiar.ValueMember = "Id_sucursal";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(22, 20);
			this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(84, 13);
			this.label15.TabIndex = 51;
			this.label15.Text = "Dirección actual";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(22, 79);
			this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(52, 13);
			this.label17.TabIndex = 53;
			this.label17.Text = "Dirección";
			// 
			// cbxDireccionDctoActual
			// 
			this.cbxDireccionDctoActual.DisplayMember = "Descripcion";
			this.cbxDireccionDctoActual.Enabled = false;
			this.cbxDireccionDctoActual.FormattingEnabled = true;
			this.cbxDireccionDctoActual.Location = new System.Drawing.Point(122, 17);
			this.cbxDireccionDctoActual.Margin = new System.Windows.Forms.Padding(2);
			this.cbxDireccionDctoActual.Name = "cbxDireccionDctoActual";
			this.cbxDireccionDctoActual.Size = new System.Drawing.Size(317, 21);
			this.cbxDireccionDctoActual.TabIndex = 49;
			this.cbxDireccionDctoActual.ValueMember = "Id_sucursal";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(22, 47);
			this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(120, 13);
			this.label18.TabIndex = 52;
			this.label18.Text = "Dirección a modicar";
			// 
			// tabRecuperar
			// 
			this.tabRecuperar.Controls.Add(this.panel2);
			this.tabRecuperar.Location = new System.Drawing.Point(4, 22);
			this.tabRecuperar.Name = "tabRecuperar";
			this.tabRecuperar.Size = new System.Drawing.Size(902, 193);
			this.tabRecuperar.TabIndex = 6;
			this.tabRecuperar.Text = "Recuperar TLD";
			this.tabRecuperar.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnRecuperarTLD);
			this.panel2.Controls.Add(this.txtCliente);
			this.panel2.Controls.Add(this.label22);
			this.panel2.Controls.Add(this.txtPersonal);
			this.panel2.Controls.Add(this.label21);
			this.panel2.Controls.Add(this.txtNTLDRecuperar);
			this.panel2.Controls.Add(this.label20);
			this.panel2.Controls.Add(this.lblRecupMensajeTLD);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(902, 193);
			this.panel2.TabIndex = 0;
			// 
			// btnRecuperarTLD
			// 
			this.btnRecuperarTLD.Location = new System.Drawing.Point(138, 146);
			this.btnRecuperarTLD.Name = "btnRecuperarTLD";
			this.btnRecuperarTLD.Size = new System.Drawing.Size(212, 23);
			this.btnRecuperarTLD.TabIndex = 7;
			this.btnRecuperarTLD.Text = "Recuperar TLD";
			this.btnRecuperarTLD.UseVisualStyleBackColor = true;
			this.btnRecuperarTLD.Click += new System.EventHandler(this.btnRecuperarTLD_Click);
			// 
			// txtCliente
			// 
			this.txtCliente.Location = new System.Drawing.Point(115, 100);
			this.txtCliente.Name = "txtCliente";
			this.txtCliente.ReadOnly = true;
			this.txtCliente.Size = new System.Drawing.Size(484, 20);
			this.txtCliente.TabIndex = 6;
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(37, 103);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(39, 13);
			this.label22.TabIndex = 5;
			this.label22.Text = "Cliente";
			// 
			// txtPersonal
			// 
			this.txtPersonal.Location = new System.Drawing.Point(115, 74);
			this.txtPersonal.Name = "txtPersonal";
			this.txtPersonal.ReadOnly = true;
			this.txtPersonal.Size = new System.Drawing.Size(484, 20);
			this.txtPersonal.TabIndex = 4;
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(37, 77);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(48, 13);
			this.label21.TabIndex = 3;
			this.label21.Text = "Personal";
			// 
			// txtNTLDRecuperar
			// 
			this.txtNTLDRecuperar.Location = new System.Drawing.Point(115, 48);
			this.txtNTLDRecuperar.Name = "txtNTLDRecuperar";
			this.txtNTLDRecuperar.ReadOnly = true;
			this.txtNTLDRecuperar.Size = new System.Drawing.Size(132, 20);
			this.txtNTLDRecuperar.TabIndex = 2;
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(37, 51);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(59, 13);
			this.label20.TabIndex = 1;
			this.label20.Text = "Datos TLD";
			// 
			// lblRecupMensajeTLD
			// 
			this.lblRecupMensajeTLD.AutoSize = true;
			this.lblRecupMensajeTLD.Location = new System.Drawing.Point(37, 23);
			this.lblRecupMensajeTLD.Name = "lblRecupMensajeTLD";
			this.lblRecupMensajeTLD.Size = new System.Drawing.Size(41, 13);
			this.lblRecupMensajeTLD.TabIndex = 0;
			this.lblRecupMensajeTLD.Text = "label20";
			// 
			// tabEliminar
			// 
			this.tabEliminar.Controls.Add(this.btnEliminar);
			this.tabEliminar.Controls.Add(this.lblPersonalEliminar);
			this.tabEliminar.Controls.Add(this.label24);
			this.tabEliminar.Location = new System.Drawing.Point(4, 22);
			this.tabEliminar.Name = "tabEliminar";
			this.tabEliminar.Size = new System.Drawing.Size(902, 193);
			this.tabEliminar.TabIndex = 7;
			this.tabEliminar.Text = "Eliminar TLD";
			this.tabEliminar.UseVisualStyleBackColor = true;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(42, 61);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(114, 23);
			this.btnEliminar.TabIndex = 52;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// lblPersonalEliminar
			// 
			this.lblPersonalEliminar.AutoSize = true;
			this.lblPersonalEliminar.Location = new System.Drawing.Point(120, 22);
			this.lblPersonalEliminar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblPersonalEliminar.Name = "lblPersonalEliminar";
			this.lblPersonalEliminar.Size = new System.Drawing.Size(54, 13);
			this.lblPersonalEliminar.TabIndex = 51;
			this.lblPersonalEliminar.Text = "Personal :";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(39, 22);
			this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(48, 13);
			this.label24.TabIndex = 50;
			this.label24.Text = "Personal";
			// 
			// tabCambioPeriodo
			// 
			this.tabCambioPeriodo.Controls.Add(this.ddlPeriodoCambiarPeriodo);
			this.tabCambioPeriodo.Controls.Add(this.label27);
			this.tabCambioPeriodo.Controls.Add(this.txtNDocumentoCambiarPeriodo);
			this.tabCambioPeriodo.Controls.Add(this.label26);
			this.tabCambioPeriodo.Controls.Add(this.label25);
			this.tabCambioPeriodo.Controls.Add(this.txtListaTLD);
			this.tabCambioPeriodo.Controls.Add(this.label23);
			this.tabCambioPeriodo.Controls.Add(this.btnCambioPeriodo);
			this.tabCambioPeriodo.Location = new System.Drawing.Point(4, 22);
			this.tabCambioPeriodo.Name = "tabCambioPeriodo";
			this.tabCambioPeriodo.Size = new System.Drawing.Size(902, 317);
			this.tabCambioPeriodo.TabIndex = 8;
			this.tabCambioPeriodo.Text = "Cambiar Periodo";
			this.tabCambioPeriodo.UseVisualStyleBackColor = true;
			// 
			// btnCambioPeriodo
			// 
			this.btnCambioPeriodo.Location = new System.Drawing.Point(62, 137);
			this.btnCambioPeriodo.Name = "btnCambioPeriodo";
			this.btnCambioPeriodo.Size = new System.Drawing.Size(114, 23);
			this.btnCambioPeriodo.TabIndex = 46;
			this.btnCambioPeriodo.Text = "Modificar periodo";
			this.btnCambioPeriodo.UseVisualStyleBackColor = true;
			this.btnCambioPeriodo.Click += new System.EventHandler(this.btnCambioPeriodo_Click);
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(62, 28);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(68, 13);
			this.label23.TabIndex = 47;
			this.label23.Text = "Lista de TLD";
			// 
			// txtListaTLD
			// 
			this.txtListaTLD.Location = new System.Drawing.Point(150, 25);
			this.txtListaTLD.Name = "txtListaTLD";
			this.txtListaTLD.Size = new System.Drawing.Size(577, 20);
			this.txtListaTLD.TabIndex = 48;
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(747, 25);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(140, 13);
			this.label25.TabIndex = 49;
			this.label25.Text = "Ejemplo: 34565, 5678, 3344";
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Location = new System.Drawing.Point(63, 61);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(77, 13);
			this.label26.TabIndex = 50;
			this.label26.Text = "N° Documento";
			// 
			// txtNDocumentoCambiarPeriodo
			// 
			this.txtNDocumentoCambiarPeriodo.Location = new System.Drawing.Point(150, 54);
			this.txtNDocumentoCambiarPeriodo.Name = "txtNDocumentoCambiarPeriodo";
			this.txtNDocumentoCambiarPeriodo.Size = new System.Drawing.Size(128, 20);
			this.txtNDocumentoCambiarPeriodo.TabIndex = 51;
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Location = new System.Drawing.Point(63, 87);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(83, 13);
			this.label27.TabIndex = 52;
			this.label27.Text = "Cambiar periodo";
			// 
			// ddlPeriodoCambiarPeriodo
			// 
			this.ddlPeriodoCambiarPeriodo.DisplayMember = "GlosaTrimestre";
			this.ddlPeriodoCambiarPeriodo.FormattingEnabled = true;
			this.ddlPeriodoCambiarPeriodo.Location = new System.Drawing.Point(150, 84);
			this.ddlPeriodoCambiarPeriodo.Name = "ddlPeriodoCambiarPeriodo";
			this.ddlPeriodoCambiarPeriodo.Size = new System.Drawing.Size(200, 21);
			this.ddlPeriodoCambiarPeriodo.TabIndex = 53;
			this.ddlPeriodoCambiarPeriodo.ValueMember = "Id_Periodo";
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Location = new System.Drawing.Point(11, 96);
			this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(76, 13);
			this.label28.TabIndex = 45;
			this.label28.Text = "Periodo Actual";
			// 
			// lblPeriodoActual
			// 
			this.lblPeriodoActual.AutoSize = true;
			this.lblPeriodoActual.Location = new System.Drawing.Point(109, 96);
			this.lblPeriodoActual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblPeriodoActual.Name = "lblPeriodoActual";
			this.lblPeriodoActual.Size = new System.Drawing.Size(0, 13);
			this.lblPeriodoActual.TabIndex = 46;
			// 
			// frmCambioPersonalTLD
			// 
			this.AcceptButton = this.btn_Cargar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(928, 500);
			this.Controls.Add(this.lblPeriodoActual);
			this.Controls.Add(this.label28);
			this.Controls.Add(this.btn_filtro);
			this.Controls.Add(this.grpDatos);
			this.Controls.Add(this.lblRut);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.txt_NDoc);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btn_Cargar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbl_NombreCliente);
			this.Controls.Add(this.lbl_NCliente);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmCambioPersonalTLD";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cambio datos TLD";
			this.cmsPopup.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			this.grpDatos.ResumeLayout(false);
			this.tabPrincipal.ResumeLayout(false);
			this.tabPersonal.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tabSeccion.ResumeLayout(false);
			this.tabSeccion.PerformLayout();
			this.tabDireccion.ResumeLayout(false);
			this.tabDireccion.PerformLayout();
			this.tabAsociarTLDEnviadoAlCliente.ResumeLayout(false);
			this.tabAsociarTLDEnviadoAlCliente.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudTLDEnviadoAlCliente)).EndInit();
			this.tabCambioEstado.ResumeLayout(false);
			this.tabCambioEstado.PerformLayout();
			this.tabNDocumento.ResumeLayout(false);
			this.tabNDocumento.PerformLayout();
			this.tabRecuperar.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.tabEliminar.ResumeLayout(false);
			this.tabEliminar.PerformLayout();
			this.tabCambioPeriodo.ResumeLayout(false);
			this.tabCambioPeriodo.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
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
		private System.Windows.Forms.ComboBox cbx_PersonalActual;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cbx_PersonalCambio;
		private System.Windows.Forms.Label lblRut;
		private System.Windows.Forms.GroupBox grpDatos;
		private System.Windows.Forms.TabControl tabPrincipal;
		private System.Windows.Forms.TabPage tabPersonal;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TabPage tabSeccion;
		private System.Windows.Forms.ComboBox cbx_id_seccionMod;
		private System.Windows.Forms.Button btn_ModificarSeccion;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cbx_id_seccion;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TabPage tabDireccion;
		private System.Windows.Forms.ComboBox cbxDireccionMod;
		private System.Windows.Forms.Button btnDireccionMod;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cbxDireccionActual;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TabPage tabAsociarTLDEnviadoAlCliente;
		private System.Windows.Forms.Button btnAsociarTLDConElOriginal;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.NumericUpDown nudTLDEnviadoAlCliente;
		private System.Windows.Forms.TabPage tabCambioEstado;
		private System.Windows.Forms.Button btnCambioestado;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.ComboBox cbxEstado;
		private System.Windows.Forms.Label lblNombrePersonal;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label lblEstadoActual;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TabPage tabNDocumento;
		private System.Windows.Forms.Button btnGuardarDireccionNDcto;
		private System.Windows.Forms.ComboBox cbxDireccionDctoCambiar;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.ComboBox cbxDireccionDctoActual;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox txtNDocumento;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TabPage tabRecuperar;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lblRecupMensajeTLD;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TextBox txtNTLDRecuperar;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.TextBox txtPersonal;
		private System.Windows.Forms.TextBox txtCliente;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Button btnRecuperarTLD;
		private System.Windows.Forms.TabPage tabEliminar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Label lblPersonalEliminar;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.TabPage tabCambioPeriodo;
		private System.Windows.Forms.Button btnCambioPeriodo;
		private System.Windows.Forms.TextBox txtListaTLD;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.TextBox txtNDocumentoCambiarPeriodo;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.ComboBox ddlPeriodoCambiarPeriodo;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label lblPeriodoActual;
	}
}