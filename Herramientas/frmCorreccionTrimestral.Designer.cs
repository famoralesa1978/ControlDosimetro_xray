﻿namespace ControlDosimetro
{
    partial class frmCorreccionTrimestral
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
			this.grpDatosCliente = new System.Windows.Forms.GroupBox();
			this.btn_filtro = new System.Windows.Forms.Button();
			this.cbx_anno = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lbl_id_cliente = new System.Windows.Forms.TextBox();
			this.btn_cargar = new System.Windows.Forms.Button();
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
			this.grpPrincipal = new System.Windows.Forms.GroupBox();
			this.grpCambiarpor = new System.Windows.Forms.GroupBox();
			this.btn_Guardar = new System.Windows.Forms.Button();
			this.cbx_id_periodoCambio = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cbx_annoCambio = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.grpActual = new System.Windows.Forms.GroupBox();
			this.cbx_id_periodo = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabCorregir = new System.Windows.Forms.TabControl();
			this.tabCorrFilimico = new System.Windows.Forms.TabPage();
			this.tabCorrTLD = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbx_id_periodoTLD = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btn_GuardarTLD = new System.Windows.Forms.Button();
			this.cbx_id_periodoCambioTLD = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cbx_annoCambioTLD = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.grpDatosCliente.SuspendLayout();
			this.cmsPopup.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.grpPrincipal.SuspendLayout();
			this.grpCambiarpor.SuspendLayout();
			this.grpActual.SuspendLayout();
			this.tabCorregir.SuspendLayout();
			this.tabCorrFilimico.SuspendLayout();
			this.tabCorrTLD.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpDatosCliente
			// 
			this.grpDatosCliente.Controls.Add(this.btn_filtro);
			this.grpDatosCliente.Controls.Add(this.cbx_anno);
			this.grpDatosCliente.Controls.Add(this.label3);
			this.grpDatosCliente.Controls.Add(this.lbl_id_cliente);
			this.grpDatosCliente.Controls.Add(this.btn_cargar);
			this.grpDatosCliente.Controls.Add(this.label2);
			this.grpDatosCliente.Location = new System.Drawing.Point(5, 28);
			this.grpDatosCliente.Name = "grpDatosCliente";
			this.grpDatosCliente.Size = new System.Drawing.Size(432, 74);
			this.grpDatosCliente.TabIndex = 1;
			this.grpDatosCliente.TabStop = false;
			this.grpDatosCliente.Text = "Dato Cliente";
			// 
			// btn_filtro
			// 
			this.btn_filtro.Location = new System.Drawing.Point(262, 42);
			this.btn_filtro.Name = "btn_filtro";
			this.btn_filtro.Size = new System.Drawing.Size(95, 23);
			this.btn_filtro.TabIndex = 45;
			this.btn_filtro.Text = "Limpiar filtro";
			this.btn_filtro.UseVisualStyleBackColor = true;
			this.btn_filtro.Click += new System.EventHandler(this.Btn_filtro_Click);
			// 
			// cbx_anno
			// 
			this.cbx_anno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_anno.FormattingEnabled = true;
			this.cbx_anno.Location = new System.Drawing.Point(87, 42);
			this.cbx_anno.Name = "cbx_anno";
			this.cbx_anno.Size = new System.Drawing.Size(87, 21);
			this.cbx_anno.TabIndex = 35;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 45);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 13);
			this.label3.TabIndex = 36;
			this.label3.Text = "Año";
			// 
			// lbl_id_cliente
			// 
			this.lbl_id_cliente.Location = new System.Drawing.Point(87, 19);
			this.lbl_id_cliente.Name = "lbl_id_cliente";
			this.lbl_id_cliente.Size = new System.Drawing.Size(53, 20);
			this.lbl_id_cliente.TabIndex = 1;
			// 
			// btn_cargar
			// 
			this.btn_cargar.Location = new System.Drawing.Point(180, 42);
			this.btn_cargar.Name = "btn_cargar";
			this.btn_cargar.Size = new System.Drawing.Size(75, 23);
			this.btn_cargar.TabIndex = 2;
			this.btn_cargar.Text = "Cargar";
			this.btn_cargar.UseVisualStyleBackColor = true;
			this.btn_cargar.Click += new System.EventHandler(this.Btn_cargar_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 34;
			this.label2.Text = "N°  Cliente";
			// 
			// cmsPopup
			// 
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
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(459, 25);
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
			// grpPrincipal
			// 
			this.grpPrincipal.Controls.Add(this.tabCorregir);
			this.grpPrincipal.Location = new System.Drawing.Point(5, 108);
			this.grpPrincipal.Name = "grpPrincipal";
			this.grpPrincipal.Size = new System.Drawing.Size(448, 180);
			this.grpPrincipal.TabIndex = 3;
			this.grpPrincipal.TabStop = false;
			this.grpPrincipal.Text = "Datos a corregir";
			// 
			// grpCambiarpor
			// 
			this.grpCambiarpor.Controls.Add(this.btn_Guardar);
			this.grpCambiarpor.Controls.Add(this.cbx_id_periodoCambio);
			this.grpCambiarpor.Controls.Add(this.label5);
			this.grpCambiarpor.Controls.Add(this.cbx_annoCambio);
			this.grpCambiarpor.Controls.Add(this.label4);
			this.grpCambiarpor.Location = new System.Drawing.Point(224, 6);
			this.grpCambiarpor.Name = "grpCambiarpor";
			this.grpCambiarpor.Size = new System.Drawing.Size(212, 105);
			this.grpCambiarpor.TabIndex = 1;
			this.grpCambiarpor.TabStop = false;
			this.grpCambiarpor.Text = "Cambiar Por";
			// 
			// btn_Guardar
			// 
			this.btn_Guardar.Location = new System.Drawing.Point(40, 76);
			this.btn_Guardar.Name = "btn_Guardar";
			this.btn_Guardar.Size = new System.Drawing.Size(102, 23);
			this.btn_Guardar.TabIndex = 41;
			this.btn_Guardar.Text = "Guardar Cambio";
			this.btn_Guardar.UseVisualStyleBackColor = true;
			this.btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
			// 
			// cbx_id_periodoCambio
			// 
			this.cbx_id_periodoCambio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_id_periodoCambio.FormattingEnabled = true;
			this.cbx_id_periodoCambio.Location = new System.Drawing.Point(81, 42);
			this.cbx_id_periodoCambio.Name = "cbx_id_periodoCambio";
			this.cbx_id_periodoCambio.Size = new System.Drawing.Size(121, 21);
			this.cbx_id_periodoCambio.TabIndex = 39;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 47);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(42, 13);
			this.label5.TabIndex = 40;
			this.label5.Text = "periodo";
			// 
			// cbx_annoCambio
			// 
			this.cbx_annoCambio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_annoCambio.FormattingEnabled = true;
			this.cbx_annoCambio.Location = new System.Drawing.Point(81, 13);
			this.cbx_annoCambio.Name = "cbx_annoCambio";
			this.cbx_annoCambio.Size = new System.Drawing.Size(87, 21);
			this.cbx_annoCambio.TabIndex = 37;
			this.cbx_annoCambio.SelectedIndexChanged += new System.EventHandler(this.Cbx_annoCambio_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(26, 13);
			this.label4.TabIndex = 38;
			this.label4.Text = "Año";
			// 
			// grpActual
			// 
			this.grpActual.Controls.Add(this.cbx_id_periodo);
			this.grpActual.Controls.Add(this.label1);
			this.grpActual.Location = new System.Drawing.Point(9, 6);
			this.grpActual.Name = "grpActual";
			this.grpActual.Size = new System.Drawing.Size(209, 105);
			this.grpActual.TabIndex = 0;
			this.grpActual.TabStop = false;
			this.grpActual.Text = "Actual";
			// 
			// cbx_id_periodo
			// 
			this.cbx_id_periodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_id_periodo.FormattingEnabled = true;
			this.cbx_id_periodo.Location = new System.Drawing.Point(81, 42);
			this.cbx_id_periodo.Name = "cbx_id_periodo";
			this.cbx_id_periodo.Size = new System.Drawing.Size(121, 21);
			this.cbx_id_periodo.TabIndex = 37;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 38;
			this.label1.Text = "periodo";
			// 
			// tabCorregir
			// 
			this.tabCorregir.Controls.Add(this.tabCorrFilimico);
			this.tabCorregir.Controls.Add(this.tabCorrTLD);
			this.tabCorregir.Location = new System.Drawing.Point(2, 19);
			this.tabCorregir.Name = "tabCorregir";
			this.tabCorregir.SelectedIndex = 0;
			this.tabCorregir.Size = new System.Drawing.Size(446, 153);
			this.tabCorregir.TabIndex = 2;
			// 
			// tabCorrFilimico
			// 
			this.tabCorrFilimico.Controls.Add(this.grpActual);
			this.tabCorrFilimico.Controls.Add(this.grpCambiarpor);
			this.tabCorrFilimico.Location = new System.Drawing.Point(4, 22);
			this.tabCorrFilimico.Name = "tabCorrFilimico";
			this.tabCorrFilimico.Padding = new System.Windows.Forms.Padding(3);
			this.tabCorrFilimico.Size = new System.Drawing.Size(438, 127);
			this.tabCorrFilimico.TabIndex = 0;
			this.tabCorrFilimico.Text = "Filmico";
			this.tabCorrFilimico.UseVisualStyleBackColor = true;
			// 
			// tabCorrTLD
			// 
			this.tabCorrTLD.Controls.Add(this.groupBox1);
			this.tabCorrTLD.Controls.Add(this.groupBox2);
			this.tabCorrTLD.Location = new System.Drawing.Point(4, 22);
			this.tabCorrTLD.Name = "tabCorrTLD";
			this.tabCorrTLD.Padding = new System.Windows.Forms.Padding(3);
			this.tabCorrTLD.Size = new System.Drawing.Size(438, 127);
			this.tabCorrTLD.TabIndex = 1;
			this.tabCorrTLD.Text = "TLD";
			this.tabCorrTLD.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbx_id_periodoTLD);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Location = new System.Drawing.Point(6, 11);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(209, 105);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Actual";
			// 
			// cbx_id_periodoTLD
			// 
			this.cbx_id_periodoTLD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_id_periodoTLD.FormattingEnabled = true;
			this.cbx_id_periodoTLD.Location = new System.Drawing.Point(81, 42);
			this.cbx_id_periodoTLD.Name = "cbx_id_periodoTLD";
			this.cbx_id_periodoTLD.Size = new System.Drawing.Size(121, 21);
			this.cbx_id_periodoTLD.TabIndex = 37;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 47);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(42, 13);
			this.label6.TabIndex = 38;
			this.label6.Text = "periodo";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btn_GuardarTLD);
			this.groupBox2.Controls.Add(this.cbx_id_periodoCambioTLD);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.cbx_annoCambioTLD);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Location = new System.Drawing.Point(221, 11);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(212, 105);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Cambiar Por";
			// 
			// btn_GuardarTLD
			// 
			this.btn_GuardarTLD.Location = new System.Drawing.Point(40, 76);
			this.btn_GuardarTLD.Name = "btn_GuardarTLD";
			this.btn_GuardarTLD.Size = new System.Drawing.Size(102, 23);
			this.btn_GuardarTLD.TabIndex = 41;
			this.btn_GuardarTLD.Text = "Guardar Cambio";
			this.btn_GuardarTLD.UseVisualStyleBackColor = true;
			this.btn_GuardarTLD.Click += new System.EventHandler(this.btn_GuardarTLD_Click);
			// 
			// cbx_id_periodoCambioTLD
			// 
			this.cbx_id_periodoCambioTLD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_id_periodoCambioTLD.FormattingEnabled = true;
			this.cbx_id_periodoCambioTLD.Location = new System.Drawing.Point(81, 42);
			this.cbx_id_periodoCambioTLD.Name = "cbx_id_periodoCambioTLD";
			this.cbx_id_periodoCambioTLD.Size = new System.Drawing.Size(121, 21);
			this.cbx_id_periodoCambioTLD.TabIndex = 39;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 47);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(42, 13);
			this.label7.TabIndex = 40;
			this.label7.Text = "periodo";
			// 
			// cbx_annoCambioTLD
			// 
			this.cbx_annoCambioTLD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_annoCambioTLD.FormattingEnabled = true;
			this.cbx_annoCambioTLD.Location = new System.Drawing.Point(81, 13);
			this.cbx_annoCambioTLD.Name = "cbx_annoCambioTLD";
			this.cbx_annoCambioTLD.Size = new System.Drawing.Size(87, 21);
			this.cbx_annoCambioTLD.TabIndex = 37;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 16);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(26, 13);
			this.label8.TabIndex = 38;
			this.label8.Text = "Año";
			// 
			// frmCorreccionTrimestral
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(459, 294);
			this.Controls.Add(this.grpPrincipal);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.grpDatosCliente);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmCorreccionTrimestral";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Corrección de Trimestre";
			this.Load += new System.EventHandler(this.FrmIngresoPelicula_Load);
			this.grpDatosCliente.ResumeLayout(false);
			this.grpDatosCliente.PerformLayout();
			this.cmsPopup.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			this.grpPrincipal.ResumeLayout(false);
			this.grpCambiarpor.ResumeLayout(false);
			this.grpCambiarpor.PerformLayout();
			this.grpActual.ResumeLayout(false);
			this.grpActual.PerformLayout();
			this.tabCorregir.ResumeLayout(false);
			this.tabCorrFilimico.ResumeLayout(false);
			this.tabCorrTLD.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosCliente;
		  private System.Windows.Forms.ToolStrip toolStrip1;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Button btn_cargar;
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
                                private System.Windows.Forms.TextBox lbl_id_cliente;
                                private System.Windows.Forms.FontDialog fdgLetra;
                                private System.Windows.Forms.ColorDialog colorDialog1;
                                private System.Windows.Forms.OpenFileDialog openFileDialog1;
                                private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
                                private System.Windows.Forms.ToolStripMenuItem btn_EliminarSeleccion;
                                private System.Windows.Forms.GroupBox grpPrincipal;
                                private System.Windows.Forms.ComboBox cbx_anno;
                                private System.Windows.Forms.Label label3;
                                private System.Windows.Forms.GroupBox grpCambiarpor;
                                private System.Windows.Forms.GroupBox grpActual;
                                private System.Windows.Forms.ComboBox cbx_id_periodo;
                                private System.Windows.Forms.Label label1;
                                private System.Windows.Forms.ComboBox cbx_id_periodoCambio;
                                private System.Windows.Forms.Label label5;
                                private System.Windows.Forms.ComboBox cbx_annoCambio;
                                private System.Windows.Forms.Label label4;
                                private System.Windows.Forms.Button btn_Guardar;
                                private System.Windows.Forms.Button btn_filtro;
		private System.Windows.Forms.TabControl tabCorregir;
		private System.Windows.Forms.TabPage tabCorrFilimico;
		private System.Windows.Forms.TabPage tabCorrTLD;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cbx_id_periodoTLD;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btn_GuardarTLD;
		private System.Windows.Forms.ComboBox cbx_id_periodoCambioTLD;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cbx_annoCambioTLD;
		private System.Windows.Forms.Label label8;
	}
}