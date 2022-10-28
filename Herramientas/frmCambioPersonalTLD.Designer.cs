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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
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
			this.cmsPopup.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.grpDatos.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPersonal.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tabSeccion.SuspendLayout();
			this.tabDireccion.SuspendLayout();
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
			this.label3.Enabled = false;
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
			this.toolStrip1.Size = new System.Drawing.Size(520, 25);
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
			dataGridViewCellStyle3.Format = "N2";
			dataGridViewCellStyle3.NullValue = "0";
			this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle3;
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
			dataGridViewCellStyle4.Format = "N2";
			dataGridViewCellStyle4.NullValue = "0";
			this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle4;
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
			this.grpDatos.Controls.Add(this.tabControl1);
			this.grpDatos.Location = new System.Drawing.Point(0, 96);
			this.grpDatos.Name = "grpDatos";
			this.grpDatos.Size = new System.Drawing.Size(514, 238);
			this.grpDatos.TabIndex = 3;
			this.grpDatos.TabStop = false;
			this.grpDatos.Text = "Datos a modificar";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPersonal);
			this.tabControl1.Controls.Add(this.tabSeccion);
			this.tabControl1.Controls.Add(this.tabDireccion);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(3, 16);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(508, 219);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPersonal
			// 
			this.tabPersonal.BackColor = System.Drawing.SystemColors.Control;
			this.tabPersonal.Controls.Add(this.panel1);
			this.tabPersonal.Location = new System.Drawing.Point(4, 22);
			this.tabPersonal.Name = "tabPersonal";
			this.tabPersonal.Padding = new System.Windows.Forms.Padding(3);
			this.tabPersonal.Size = new System.Drawing.Size(500, 193);
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
			this.panel1.Size = new System.Drawing.Size(494, 187);
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
			this.tabSeccion.Size = new System.Drawing.Size(500, 193);
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
			this.label6.Enabled = false;
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
			this.tabDireccion.Size = new System.Drawing.Size(500, 193);
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
			this.label9.Enabled = false;
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
			// frmCambioPersonalTLD
			// 
			this.AcceptButton = this.btn_Cargar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(520, 343);
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
			this.tabControl1.ResumeLayout(false);
			this.tabPersonal.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tabSeccion.ResumeLayout(false);
			this.tabSeccion.PerformLayout();
			this.tabDireccion.ResumeLayout(false);
			this.tabDireccion.PerformLayout();
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
		private System.Windows.Forms.TabControl tabControl1;
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
	}
}