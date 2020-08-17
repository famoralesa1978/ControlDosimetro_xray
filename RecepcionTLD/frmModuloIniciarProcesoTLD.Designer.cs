namespace ControlDosimetro
{
    partial class frmModuloIniciarProcesoTLD
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btn_Guardar = new System.Windows.Forms.Button();
			this.txt_TLD = new System.Windows.Forms.TextBox();
			this.btn_filtro = new System.Windows.Forms.Button();
			this.btn_cargar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
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
			this.btn_Cerrar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lbl_NCliente = new System.Windows.Forms.Label();
			this.lbl_NombreCliente = new System.Windows.Forms.Label();
			this.lbl_NombrePersonal = new System.Windows.Forms.Label();
			this.lbl_Periodo = new System.Windows.Forms.Label();
			this.lbl_TLD = new System.Windows.Forms.Label();
			this.nudPosicion = new System.Windows.Forms.NumericUpDown();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnIniciar = new System.Windows.Forms.Button();
			this.grdDatos = new System.Windows.Forms.DataGridView();
			this.N_Pelicula = new GridExtension.IntegerGridColumn();
			this.Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.N_documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NomPersonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPosicion)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnCancelar);
			this.groupBox1.Controls.Add(this.btn_Guardar);
			this.groupBox1.Location = new System.Drawing.Point(12, 74);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(752, 228);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dato Cliente";
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(386, 199);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 6;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
			// 
			// btn_Guardar
			// 
			this.btn_Guardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_Guardar.Location = new System.Drawing.Point(232, 199);
			this.btn_Guardar.Name = "btn_Guardar";
			this.btn_Guardar.Size = new System.Drawing.Size(127, 23);
			this.btn_Guardar.TabIndex = 5;
			this.btn_Guardar.Text = "Agregar a la lectura";
			this.btn_Guardar.UseVisualStyleBackColor = true;
			this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
			// 
			// txt_TLD
			// 
			this.txt_TLD.Location = new System.Drawing.Point(89, 45);
			this.txt_TLD.Name = "txt_TLD";
			this.txt_TLD.Size = new System.Drawing.Size(134, 20);
			this.txt_TLD.TabIndex = 1;
			// 
			// btn_filtro
			// 
			this.btn_filtro.Location = new System.Drawing.Point(336, 45);
			this.btn_filtro.Name = "btn_filtro";
			this.btn_filtro.Size = new System.Drawing.Size(95, 23);
			this.btn_filtro.TabIndex = 4;
			this.btn_filtro.Text = "Limpiar filtro";
			this.btn_filtro.UseVisualStyleBackColor = true;
			this.btn_filtro.Click += new System.EventHandler(this.btn_filtro_Click_1);
			// 
			// btn_cargar
			// 
			this.btn_cargar.Location = new System.Drawing.Point(244, 45);
			this.btn_cargar.Name = "btn_cargar";
			this.btn_cargar.Size = new System.Drawing.Size(75, 23);
			this.btn_cargar.TabIndex = 2;
			this.btn_cargar.Text = "Cargar";
			this.btn_cargar.UseVisualStyleBackColor = true;
			this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 34;
			this.label2.Text = "N° TLD";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(798, 25);
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
			// btn_Cerrar
			// 
			this.btn_Cerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_Cerrar.Location = new System.Drawing.Point(517, 532);
			this.btn_Cerrar.Name = "btn_Cerrar";
			this.btn_Cerrar.Size = new System.Drawing.Size(75, 23);
			this.btn_Cerrar.TabIndex = 10;
			this.btn_Cerrar.Text = "Cerrar";
			this.btn_Cerrar.UseVisualStyleBackColor = true;
			this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click_1);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre cliente";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 49);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Nombre Personal";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 78);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "Periodo";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.63748F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.36252F));
			this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.lbl_NCliente, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.lbl_NombreCliente, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.lbl_NombrePersonal, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.lbl_Periodo, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.lbl_TLD, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.nudPosicion, 1, 5);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 93);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(731, 168);
			this.tableLayoutPanel1.TabIndex = 0;
			this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 132);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(47, 13);
			this.label7.TabIndex = 35;
			this.label7.Text = "Posición";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 105);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(43, 13);
			this.label6.TabIndex = 35;
			this.label6.Text = "N° TLD";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "N° Cliente";
			// 
			// lbl_NCliente
			// 
			this.lbl_NCliente.AutoSize = true;
			this.lbl_NCliente.Location = new System.Drawing.Point(109, 0);
			this.lbl_NCliente.Name = "lbl_NCliente";
			this.lbl_NCliente.Size = new System.Drawing.Size(63, 13);
			this.lbl_NCliente.TabIndex = 36;
			this.lbl_NCliente.Text = "lbl_NCliente";
			// 
			// lbl_NombreCliente
			// 
			this.lbl_NombreCliente.AutoSize = true;
			this.lbl_NombreCliente.Location = new System.Drawing.Point(109, 25);
			this.lbl_NombreCliente.Name = "lbl_NombreCliente";
			this.lbl_NombreCliente.Size = new System.Drawing.Size(92, 13);
			this.lbl_NombreCliente.TabIndex = 37;
			this.lbl_NombreCliente.Text = "lbl_NombreCliente";
			// 
			// lbl_NombrePersonal
			// 
			this.lbl_NombrePersonal.AutoSize = true;
			this.lbl_NombrePersonal.Location = new System.Drawing.Point(109, 49);
			this.lbl_NombrePersonal.Name = "lbl_NombrePersonal";
			this.lbl_NombrePersonal.Size = new System.Drawing.Size(101, 13);
			this.lbl_NombrePersonal.TabIndex = 38;
			this.lbl_NombrePersonal.Text = "lbl_NombrePersonal";
			// 
			// lbl_Periodo
			// 
			this.lbl_Periodo.AutoSize = true;
			this.lbl_Periodo.Location = new System.Drawing.Point(109, 78);
			this.lbl_Periodo.Name = "lbl_Periodo";
			this.lbl_Periodo.Size = new System.Drawing.Size(59, 13);
			this.lbl_Periodo.TabIndex = 39;
			this.lbl_Periodo.Text = "lbl_Periodo";
			// 
			// lbl_TLD
			// 
			this.lbl_TLD.AutoSize = true;
			this.lbl_TLD.Location = new System.Drawing.Point(109, 105);
			this.lbl_TLD.Name = "lbl_TLD";
			this.lbl_TLD.Size = new System.Drawing.Size(44, 13);
			this.lbl_TLD.TabIndex = 40;
			this.lbl_TLD.Text = "lbl_TLD";
			// 
			// nudPosicion
			// 
			this.nudPosicion.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.nudPosicion.Location = new System.Drawing.Point(109, 135);
			this.nudPosicion.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
			this.nudPosicion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudPosicion.Name = "nudPosicion";
			this.nudPosicion.ReadOnly = true;
			this.nudPosicion.Size = new System.Drawing.Size(63, 20);
			this.nudPosicion.TabIndex = 41;
			this.nudPosicion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.pictureBox1);
			this.groupBox2.Controls.Add(this.btnIniciar);
			this.groupBox2.Controls.Add(this.grdDatos);
			this.groupBox2.Location = new System.Drawing.Point(12, 309);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(752, 217);
			this.groupBox2.TabIndex = 35;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Para iniciar Proceso de lectura";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::ControlDosimetro.Properties.Resources.IniciarProceso;
			this.pictureBox1.Location = new System.Drawing.Point(656, 20);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(89, 85);
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			// 
			// btnIniciar
			// 
			this.btnIniciar.Location = new System.Drawing.Point(655, 111);
			this.btnIniciar.Name = "btnIniciar";
			this.btnIniciar.Size = new System.Drawing.Size(90, 43);
			this.btnIniciar.TabIndex = 10;
			this.btnIniciar.Text = "Iniciar Lectura";
			this.btnIniciar.UseVisualStyleBackColor = true;
			this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
			// 
			// grdDatos
			// 
			this.grdDatos.AllowUserToAddRows = false;
			this.grdDatos.AllowUserToDeleteRows = false;
			this.grdDatos.AllowUserToResizeColumns = false;
			this.grdDatos.AllowUserToResizeRows = false;
			this.grdDatos.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.grdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.grdDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N_Pelicula,
            this.Periodo,
            this.N_documento,
            this.NCliente,
            this.NomPersonal});
			this.grdDatos.Location = new System.Drawing.Point(0, 18);
			this.grdDatos.Name = "grdDatos";
			this.grdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
			this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdDatos.Size = new System.Drawing.Size(649, 184);
			this.grdDatos.TabIndex = 9;
			// 
			// N_Pelicula
			// 
			this.N_Pelicula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.N_Pelicula.DataPropertyName = "n_dosimetro";
			this.N_Pelicula.HeaderText = "Nº TLD";
			this.N_Pelicula.Name = "N_Pelicula";
			this.N_Pelicula.ReadOnly = true;
			this.N_Pelicula.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.N_Pelicula.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.N_Pelicula.Width = 68;
			// 
			// Periodo
			// 
			this.Periodo.DataPropertyName = "tri";
			this.Periodo.HeaderText = "Periodo";
			this.Periodo.Name = "Periodo";
			this.Periodo.ReadOnly = true;
			this.Periodo.Width = 68;
			// 
			// N_documento
			// 
			this.N_documento.DataPropertyName = "N_documento";
			this.N_documento.HeaderText = "N° Documento";
			this.N_documento.Name = "N_documento";
			this.N_documento.ReadOnly = true;
			this.N_documento.Width = 102;
			// 
			// NCliente
			// 
			this.NCliente.DataPropertyName = "Id_cliente";
			this.NCliente.HeaderText = "N° Cliente";
			this.NCliente.Name = "NCliente";
			this.NCliente.ReadOnly = true;
			this.NCliente.Width = 79;
			// 
			// NomPersonal
			// 
			this.NomPersonal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NomPersonal.DataPropertyName = "nombre";
			this.NomPersonal.HeaderText = "Nombre del personal";
			this.NomPersonal.Name = "NomPersonal";
			this.NomPersonal.ReadOnly = true;
			// 
			// frmModuloIniciarProcesoTLD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(798, 565);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.btn_filtro);
			this.Controls.Add(this.btn_cargar);
			this.Controls.Add(this.txt_TLD);
			this.Controls.Add(this.btn_Cerrar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmModuloIniciarProcesoTLD";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Iniciar proceso de lectura";
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPosicion)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
		  private System.Windows.Forms.ToolStrip toolStrip1;
          private System.Windows.Forms.Label label2;
                                private System.Windows.Forms.Button btn_cargar;
                                private System.Windows.Forms.Button btn_filtro;
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
                                private System.Windows.Forms.TextBox txt_TLD;
                                private System.Windows.Forms.Button btn_Cerrar;
                                private System.Windows.Forms.Button btn_Guardar;
                                private System.Windows.Forms.Label label4;
                                private System.Windows.Forms.Label label1;
                                private System.Windows.Forms.Label label5;
                                private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
                                private System.Windows.Forms.Label label6;
                                private System.Windows.Forms.Label label3;
                                private System.Windows.Forms.Button btnCancelar;
                                private System.Windows.Forms.Label label7;
                                private System.Windows.Forms.Label lbl_NCliente;
                                private System.Windows.Forms.Label lbl_NombreCliente;
                                private System.Windows.Forms.Label lbl_NombrePersonal;
                                private System.Windows.Forms.Label lbl_Periodo;
                                private System.Windows.Forms.Label lbl_TLD;
                                private System.Windows.Forms.NumericUpDown nudPosicion;
                                private System.Windows.Forms.GroupBox groupBox2;
                                private System.Windows.Forms.DataGridView grdDatos;
                                private GridExtension.IntegerGridColumn N_Pelicula;
                                private System.Windows.Forms.DataGridViewTextBoxColumn Periodo;
                                private System.Windows.Forms.DataGridViewTextBoxColumn N_documento;
                                private System.Windows.Forms.DataGridViewTextBoxColumn NCliente;
                                private System.Windows.Forms.DataGridViewTextBoxColumn NomPersonal;
                                private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}