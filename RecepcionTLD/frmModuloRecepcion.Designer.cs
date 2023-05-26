namespace ControlDosimetro
{
    partial class frmModuloRecepcion
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbtTLD = new System.Windows.Forms.RadioButton();
			this.rbtDosimetria = new System.Windows.Forms.RadioButton();
			this.txt_Observacion = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txt_NDocumento = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_CodCliente = new System.Windows.Forms.TextBox();
			this.btn_filtro = new System.Windows.Forms.Button();
			this.btn_cargar = new System.Windows.Forms.Button();
			this.cbx_id_periodo = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cbx_anno = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dtp_FechaRecepcion = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.chk_marcar = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.pnl_Progreso = new System.Windows.Forms.GroupBox();
			this.pgb_Barra = new System.Windows.Forms.ProgressBar();
			this.grdDatos = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id_estadodosimetro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.N_Pelicula = new GridExtension.IntegerGridColumn();
			this.N_Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.marca = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.FechaRecepción = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Observación = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btn_Cliente = new System.Windows.Forms.ToolStripButton();
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
			this.btn_Cerrar = new System.Windows.Forms.Button();
			this.btn_Guardar = new System.Windows.Forms.Button();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.lbl_rut_cliente = new System.Windows.Forms.Label();
			this.btn_Cargar_cliente = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.lbl_nombreCliente = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.pnl_Progreso.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.lbl_nombreCliente);
			this.groupBox1.Controls.Add(this.btn_Cargar_cliente);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.lbl_rut_cliente);
			this.groupBox1.Controls.Add(this.rbtTLD);
			this.groupBox1.Controls.Add(this.rbtDosimetria);
			this.groupBox1.Controls.Add(this.txt_Observacion);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.txt_NDocumento);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txt_CodCliente);
			this.groupBox1.Controls.Add(this.btn_filtro);
			this.groupBox1.Controls.Add(this.btn_cargar);
			this.groupBox1.Controls.Add(this.cbx_id_periodo);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cbx_anno);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(5, 28);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(635, 174);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dato Cliente";
			// 
			// rbtTLD
			// 
			this.rbtTLD.AutoSize = true;
			this.rbtTLD.Location = new System.Drawing.Point(569, 12);
			this.rbtTLD.Name = "rbtTLD";
			this.rbtTLD.Size = new System.Drawing.Size(46, 17);
			this.rbtTLD.TabIndex = 49;
			this.rbtTLD.TabStop = true;
			this.rbtTLD.Text = "TLD";
			this.rbtTLD.UseVisualStyleBackColor = true;
			// 
			// rbtDosimetria
			// 
			this.rbtDosimetria.AutoSize = true;
			this.rbtDosimetria.Checked = true;
			this.rbtDosimetria.Location = new System.Drawing.Point(489, 13);
			this.rbtDosimetria.Name = "rbtDosimetria";
			this.rbtDosimetria.Size = new System.Drawing.Size(74, 17);
			this.rbtDosimetria.TabIndex = 48;
			this.rbtDosimetria.TabStop = true;
			this.rbtDosimetria.Text = "Dosimetria";
			this.rbtDosimetria.UseVisualStyleBackColor = true;
			// 
			// txt_Observacion
			// 
			this.txt_Observacion.Location = new System.Drawing.Point(87, 145);
			this.txt_Observacion.MaxLength = 200;
			this.txt_Observacion.Name = "txt_Observacion";
			this.txt_Observacion.Size = new System.Drawing.Size(366, 20);
			this.txt_Observacion.TabIndex = 47;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(12, 148);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(67, 13);
			this.label9.TabIndex = 46;
			this.label9.Text = "Observación";
			// 
			// txt_NDocumento
			// 
			this.txt_NDocumento.Location = new System.Drawing.Point(87, 119);
			this.txt_NDocumento.Name = "txt_NDocumento";
			this.txt_NDocumento.Size = new System.Drawing.Size(100, 20);
			this.txt_NDocumento.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 122);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 13);
			this.label4.TabIndex = 45;
			this.label4.Text = "N° Documento";
			// 
			// txt_CodCliente
			// 
			this.txt_CodCliente.Location = new System.Drawing.Point(87, 12);
			this.txt_CodCliente.Name = "txt_CodCliente";
			this.txt_CodCliente.Size = new System.Drawing.Size(53, 20);
			this.txt_CodCliente.TabIndex = 1;
			// 
			// btn_filtro
			// 
			this.btn_filtro.Location = new System.Drawing.Point(489, 85);
			this.btn_filtro.Name = "btn_filtro";
			this.btn_filtro.Size = new System.Drawing.Size(95, 23);
			this.btn_filtro.TabIndex = 6;
			this.btn_filtro.Text = "Limpiar filtro";
			this.btn_filtro.UseVisualStyleBackColor = true;
			this.btn_filtro.Click += new System.EventHandler(this.btn_filtro_Click_1);
			// 
			// btn_cargar
			// 
			this.btn_cargar.Location = new System.Drawing.Point(220, 94);
			this.btn_cargar.Name = "btn_cargar";
			this.btn_cargar.Size = new System.Drawing.Size(75, 23);
			this.btn_cargar.TabIndex = 5;
			this.btn_cargar.Text = "Cargar";
			this.btn_cargar.UseVisualStyleBackColor = true;
			this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
			// 
			// cbx_id_periodo
			// 
			this.cbx_id_periodo.DisplayMember = "Trimestre";
			this.cbx_id_periodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_id_periodo.FormattingEnabled = true;
			this.cbx_id_periodo.Location = new System.Drawing.Point(87, 96);
			this.cbx_id_periodo.Name = "cbx_id_periodo";
			this.cbx_id_periodo.Size = new System.Drawing.Size(121, 21);
			this.cbx_id_periodo.TabIndex = 43;
			this.cbx_id_periodo.ValueMember = "Id_Periodo";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 99);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 36;
			this.label1.Text = "periodo";
			// 
			// cbx_anno
			// 
			this.cbx_anno.DisplayMember = "anno";
			this.cbx_anno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_anno.FormattingEnabled = true;
			this.cbx_anno.Location = new System.Drawing.Point(87, 72);
			this.cbx_anno.Name = "cbx_anno";
			this.cbx_anno.Size = new System.Drawing.Size(121, 21);
			this.cbx_anno.TabIndex = 2;
			this.cbx_anno.ValueMember = "anno";
			this.cbx_anno.SelectedIndexChanged += new System.EventHandler(this.cbx_anno_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 34;
			this.label2.Text = "N°  Cliente";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 75);
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
			this.groupBox2.Controls.Add(this.dtp_FechaRecepcion);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.checkBox1);
			this.groupBox2.Controls.Add(this.chk_marcar);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.pnl_Progreso);
			this.groupBox2.Controls.Add(this.grdDatos);
			this.groupBox2.Location = new System.Drawing.Point(5, 202);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(836, 329);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Listado";
			// 
			// dtp_FechaRecepcion
			// 
			this.dtp_FechaRecepcion.CustomFormat = "dd/MM/yyyy";
			this.dtp_FechaRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_FechaRecepcion.Location = new System.Drawing.Point(110, 10);
			this.dtp_FechaRecepcion.Name = "dtp_FechaRecepcion";
			this.dtp_FechaRecepcion.Size = new System.Drawing.Size(98, 20);
			this.dtp_FechaRecepcion.TabIndex = 15;
			this.dtp_FechaRecepcion.Value = new System.DateTime(2018, 1, 7, 0, 0, 0, 0);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(15, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(92, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Fecha Recepción";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Indeterminate;
			this.checkBox1.Enabled = false;
			this.checkBox1.Location = new System.Drawing.Point(652, 0);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(108, 17);
			this.checkBox1.TabIndex = 16;
			this.checkBox1.Text = "Con Observación";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// chk_marcar
			// 
			this.chk_marcar.AutoSize = true;
			this.chk_marcar.Location = new System.Drawing.Point(291, 16);
			this.chk_marcar.Name = "chk_marcar";
			this.chk_marcar.Size = new System.Drawing.Size(15, 14);
			this.chk_marcar.TabIndex = 12;
			this.chk_marcar.UseVisualStyleBackColor = true;
			this.chk_marcar.CheckedChanged += new System.EventHandler(this.chk_marcar_CheckedChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(217, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Marcar Todo";
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
			this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.grdDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.id_estadodosimetro,
            this.N_Pelicula,
            this.N_Documento,
            this.Descripcion,
            this.marca,
            this.FechaRecepción,
            this.Observación});
			this.grdDatos.Location = new System.Drawing.Point(3, 35);
			this.grdDatos.Name = "grdDatos";
			this.grdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
			this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.grdDatos.Size = new System.Drawing.Size(827, 291);
			this.grdDatos.TabIndex = 8;
			this.grdDatos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_CellValueChanged);
			this.grdDatos.CurrentCellDirtyStateChanged += new System.EventHandler(this.grdDatos_CurrentCellDirtyStateChanged);
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
			// N_Documento
			// 
			this.N_Documento.DataPropertyName = "N_Documento";
			this.N_Documento.HeaderText = "N° Documento";
			this.N_Documento.Name = "N_Documento";
			this.N_Documento.ReadOnly = true;
			this.N_Documento.Width = 102;
			// 
			// Descripcion
			// 
			this.Descripcion.DataPropertyName = "Descripcion";
			this.Descripcion.HeaderText = "Descripcion";
			this.Descripcion.Name = "Descripcion";
			this.Descripcion.ReadOnly = true;
			this.Descripcion.Width = 88;
			// 
			// marca
			// 
			this.marca.DataPropertyName = "Marca";
			this.marca.FalseValue = "0";
			this.marca.HeaderText = "Recepcionar";
			this.marca.IndeterminateValue = "2";
			this.marca.Name = "marca";
			this.marca.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.marca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.marca.ThreeState = true;
			this.marca.TrueValue = "1";
			this.marca.Width = 93;
			// 
			// FechaRecepción
			// 
			this.FechaRecepción.DataPropertyName = "FechaRecepcion";
			this.FechaRecepción.HeaderText = "Fecha Recepción";
			this.FechaRecepción.Name = "FechaRecepción";
			this.FechaRecepción.ReadOnly = true;
			this.FechaRecepción.Width = 117;
			// 
			// Observación
			// 
			this.Observación.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Observación.DataPropertyName = "Observacion";
			this.Observación.HeaderText = "Observacion";
			this.Observación.Name = "Observación";
			this.Observación.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Observación.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Cliente});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(841, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btn_Cliente
			// 
			this.btn_Cliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_Cliente.Image = global::ControlDosimetro.Properties.Resources.cliente;
			this.btn_Cliente.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_Cliente.Name = "btn_Cliente";
			this.btn_Cliente.Size = new System.Drawing.Size(23, 22);
			this.btn_Cliente.Text = "Cliente";
			this.btn_Cliente.Click += new System.EventHandler(this.btn_Cliente_Click);
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
			dataGridViewCellStyle19.Format = "N2";
			dataGridViewCellStyle19.NullValue = "0";
			this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle19;
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
			dataGridViewCellStyle20.Format = "N2";
			dataGridViewCellStyle20.NullValue = "0";
			this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle20;
			this.dataGridViewTextBoxColumn10.HeaderText = "Valor Ingresar";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn10.Width = 97;
			// 
			// btn_Cerrar
			// 
			this.btn_Cerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_Cerrar.Location = new System.Drawing.Point(538, 532);
			this.btn_Cerrar.Name = "btn_Cerrar";
			this.btn_Cerrar.Size = new System.Drawing.Size(75, 23);
			this.btn_Cerrar.TabIndex = 10;
			this.btn_Cerrar.Text = "Cerrar";
			this.btn_Cerrar.UseVisualStyleBackColor = true;
			this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click_1);
			// 
			// btn_Guardar
			// 
			this.btn_Guardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_Guardar.Location = new System.Drawing.Point(366, 533);
			this.btn_Guardar.Name = "btn_Guardar";
			this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
			this.btn_Guardar.TabIndex = 9;
			this.btn_Guardar.Text = "Guardar";
			this.btn_Guardar.UseVisualStyleBackColor = true;
			this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox2.Enabled = false;
			this.checkBox2.Location = new System.Drawing.Point(657, 179);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(145, 17);
			this.checkBox2.TabIndex = 17;
			this.checkBox2.Text = "Recibido sin observación";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(657, 156);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(46, 13);
			this.label7.TabIndex = 18;
			this.label7.Text = "Estado";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 36);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(44, 13);
			this.label8.TabIndex = 63;
			this.label8.Text = "Nombre";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(12, 54);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(24, 13);
			this.label11.TabIndex = 62;
			this.label11.Text = "Rut";
			// 
			// lbl_rut_cliente
			// 
			this.lbl_rut_cliente.AutoSize = true;
			this.lbl_rut_cliente.Location = new System.Drawing.Point(89, 54);
			this.lbl_rut_cliente.Name = "lbl_rut_cliente";
			this.lbl_rut_cliente.Size = new System.Drawing.Size(0, 13);
			this.lbl_rut_cliente.TabIndex = 60;
			// 
			// btn_Cargar_cliente
			// 
			this.btn_Cargar_cliente.Location = new System.Drawing.Point(146, 10);
			this.btn_Cargar_cliente.Name = "btn_Cargar_cliente";
			this.btn_Cargar_cliente.Size = new System.Drawing.Size(119, 23);
			this.btn_Cargar_cliente.TabIndex = 64;
			this.btn_Cargar_cliente.Text = "Cargar Cliente";
			this.btn_Cargar_cliente.UseVisualStyleBackColor = true;
			this.btn_Cargar_cliente.Click += new System.EventHandler(this.btn_Cargar_cliente_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(89, 35);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(0, 13);
			this.label10.TabIndex = 66;
			// 
			// lbl_nombreCliente
			// 
			this.lbl_nombreCliente.AutoSize = true;
			this.lbl_nombreCliente.Location = new System.Drawing.Point(83, 35);
			this.lbl_nombreCliente.Name = "lbl_nombreCliente";
			this.lbl_nombreCliente.Size = new System.Drawing.Size(0, 13);
			this.lbl_nombreCliente.TabIndex = 65;
			// 
			// frmModuloRecepcion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(841, 565);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.btn_Cerrar);
			this.Controls.Add(this.btn_Guardar);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmModuloRecepcion";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Recepción Dosimetro";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.pnl_Progreso.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
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
                                private System.Windows.Forms.TextBox txt_CodCliente;
                                private System.Windows.Forms.Button btn_Cerrar;
                                private System.Windows.Forms.Button btn_Guardar;
                                private System.Windows.Forms.TextBox txt_NDocumento;
                                private System.Windows.Forms.Label label4;
                                private System.Windows.Forms.TextBox txt_Observacion;
                                private System.Windows.Forms.Label label9;
                                private System.Windows.Forms.CheckBox chk_marcar;
                                private System.Windows.Forms.Label label5;
                                private System.Windows.Forms.Label label6;
                                private System.Windows.Forms.DateTimePicker dtp_FechaRecepcion;
                                private System.Windows.Forms.CheckBox checkBox2;
                                private System.Windows.Forms.CheckBox checkBox1;
                                private System.Windows.Forms.Label label7;
                                private System.Windows.Forms.DataGridViewTextBoxColumn id;
                                private System.Windows.Forms.DataGridViewTextBoxColumn id_estadodosimetro;
                                private GridExtension.IntegerGridColumn N_Pelicula;
                                private System.Windows.Forms.DataGridViewTextBoxColumn N_Documento;
                                private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
                                private System.Windows.Forms.DataGridViewCheckBoxColumn marca;
                                private System.Windows.Forms.DataGridViewTextBoxColumn FechaRecepción;
                                private System.Windows.Forms.DataGridViewComboBoxColumn Observación;
                                private System.Windows.Forms.RadioButton rbtTLD;
                                private System.Windows.Forms.RadioButton rbtDosimetria;
        private System.Windows.Forms.ToolStripButton btn_Cliente;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label lbl_rut_cliente;
		private System.Windows.Forms.Button btn_Cargar_cliente;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label lbl_nombreCliente;
	}
}