namespace ControlDosimetro
{
    partial class frmIngresoDosisTLD
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresoDosisTLD));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.grdDatos = new System.Windows.Forms.DataGridView();
			this.Id_Personal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PosicionDisco = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.N_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NDocumento = new GridExtension.IntegerGridColumn();
			this.n_dosimetro = new GridExtension.IntegerGridColumn();
			this.Rut = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Maternos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Controlado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.condosis = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.valor = new GridExtension.RealGridColumn();
			this.Estado = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.Cristal1 = new GridExtension.RealGridColumn();
			this.Cristal2 = new GridExtension.RealGridColumn();
			this.Id_Dosimetro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id_periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tld = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.chkMarcar = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.chkControlado = new System.Windows.Forms.CheckBox();
			this.pnl_Progreso = new System.Windows.Forms.GroupBox();
			this.pgb_Barra = new System.Windows.Forms.ProgressBar();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btn_Cliente = new System.Windows.Forms.ToolStripButton();
			this.btnIngresarDosisISP = new System.Windows.Forms.ToolStripButton();
			this.btn_Guardar = new System.Windows.Forms.Button();
			this.btn_Cerrar = new System.Windows.Forms.Button();
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
			this.btn_Cargar = new System.Windows.Forms.Button();
			this.lbl_id_cliente = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
			this.panel1.SuspendLayout();
			this.pnl_Progreso.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.grdDatos);
			this.groupBox2.Controls.Add(this.panel1);
			this.groupBox2.Controls.Add(this.pnl_Progreso);
			this.groupBox2.Location = new System.Drawing.Point(0, 28);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1179, 460);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Listado";
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
            this.Id_Personal,
            this.PosicionDisco,
            this.N_Cliente,
            this.NDocumento,
            this.n_dosimetro,
            this.Rut,
            this.Paterno,
            this.Maternos,
            this.Nombres,
            this.Controlado,
            this.condosis,
            this.valor,
            this.Estado,
            this.Cristal1,
            this.Cristal2,
            this.Id_Dosimetro,
            this.id_periodo,
            this.tld});
			this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdDatos.Location = new System.Drawing.Point(3, 51);
			this.grdDatos.Name = "grdDatos";
			this.grdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
			this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.grdDatos.Size = new System.Drawing.Size(1173, 406);
			this.grdDatos.TabIndex = 8;
			this.grdDatos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdDatos_CellFormatting);
			this.grdDatos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_CellValueChanged);
			this.grdDatos.CurrentCellDirtyStateChanged += new System.EventHandler(this.grdDatos_CurrentCellDirtyStateChanged);
			this.grdDatos.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_RowValidated);
			this.grdDatos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdDatos_KeyDown);
			// 
			// Id_Personal
			// 
			this.Id_Personal.DataPropertyName = "Id_Personal";
			this.Id_Personal.HeaderText = "Id_Personal";
			this.Id_Personal.Name = "Id_Personal";
			this.Id_Personal.ReadOnly = true;
			this.Id_Personal.Visible = false;
			this.Id_Personal.Width = 88;
			// 
			// PosicionDisco
			// 
			this.PosicionDisco.DataPropertyName = "PosicionDisco";
			this.PosicionDisco.HeaderText = "Posición";
			this.PosicionDisco.Name = "PosicionDisco";
			this.PosicionDisco.ReadOnly = true;
			this.PosicionDisco.Width = 72;
			// 
			// N_Cliente
			// 
			this.N_Cliente.DataPropertyName = "Id_Cliente";
			this.N_Cliente.HeaderText = "N° Cliente";
			this.N_Cliente.Name = "N_Cliente";
			this.N_Cliente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.N_Cliente.Width = 79;
			// 
			// NDocumento
			// 
			this.NDocumento.DataPropertyName = "N_Documento";
			this.NDocumento.HeaderText = "N° Documento";
			this.NDocumento.Name = "NDocumento";
			this.NDocumento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.NDocumento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.NDocumento.Width = 102;
			// 
			// n_dosimetro
			// 
			this.n_dosimetro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.n_dosimetro.DataPropertyName = "n_dosimetro";
			this.n_dosimetro.HeaderText = "Nº TLD";
			this.n_dosimetro.Name = "n_dosimetro";
			this.n_dosimetro.ReadOnly = true;
			this.n_dosimetro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.n_dosimetro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.n_dosimetro.Width = 68;
			// 
			// Rut
			// 
			this.Rut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.Rut.DataPropertyName = "Rut";
			this.Rut.HeaderText = "Rut";
			this.Rut.Name = "Rut";
			this.Rut.ReadOnly = true;
			this.Rut.Width = 49;
			// 
			// Paterno
			// 
			this.Paterno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.Paterno.DataPropertyName = "Paterno";
			this.Paterno.FillWeight = 300F;
			this.Paterno.HeaderText = "Paterno";
			this.Paterno.Name = "Paterno";
			this.Paterno.ReadOnly = true;
			this.Paterno.Width = 69;
			// 
			// Maternos
			// 
			this.Maternos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.Maternos.DataPropertyName = "Maternos";
			this.Maternos.HeaderText = "Maternos";
			this.Maternos.MinimumWidth = 150;
			this.Maternos.Name = "Maternos";
			this.Maternos.ReadOnly = true;
			this.Maternos.Width = 150;
			// 
			// Nombres
			// 
			this.Nombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.Nombres.DataPropertyName = "Nombres";
			this.Nombres.HeaderText = "Nombres";
			this.Nombres.Name = "Nombres";
			this.Nombres.ReadOnly = true;
			this.Nombres.Width = 74;
			// 
			// Controlado
			// 
			this.Controlado.DataPropertyName = "Controlado";
			this.Controlado.FalseValue = "0";
			this.Controlado.HeaderText = "Controlado";
			this.Controlado.IndeterminateValue = "";
			this.Controlado.Name = "Controlado";
			this.Controlado.TrueValue = "1";
			this.Controlado.Width = 64;
			// 
			// condosis
			// 
			this.condosis.DataPropertyName = "condosis";
			this.condosis.FalseValue = "0";
			this.condosis.HeaderText = "Con Dosis";
			this.condosis.IndeterminateValue = "";
			this.condosis.Name = "condosis";
			this.condosis.TrueValue = "1";
			this.condosis.Width = 61;
			// 
			// valor
			// 
			this.valor.DataPropertyName = "dosis";
			dataGridViewCellStyle4.Format = "N2";
			dataGridViewCellStyle4.NullValue = "0";
			this.valor.DefaultCellStyle = dataGridViewCellStyle4;
			this.valor.HeaderText = "Valor Ingresar";
			this.valor.Name = "valor";
			this.valor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.valor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.valor.Width = 97;
			// 
			// Estado
			// 
			this.Estado.DataPropertyName = "estadodosis";
			this.Estado.HeaderText = "Estado Controlado";
			this.Estado.Name = "Estado";
			// 
			// Cristal1
			// 
			this.Cristal1.DataPropertyName = "Cristal1";
			this.Cristal1.HeaderText = "Cristal1";
			this.Cristal1.Name = "Cristal1";
			this.Cristal1.Width = 47;
			// 
			// Cristal2
			// 
			this.Cristal2.DataPropertyName = "Cristal2";
			this.Cristal2.HeaderText = "Cristal2";
			this.Cristal2.Name = "Cristal2";
			this.Cristal2.Width = 47;
			// 
			// Id_Dosimetro
			// 
			this.Id_Dosimetro.DataPropertyName = "Id_Dosimetro";
			this.Id_Dosimetro.HeaderText = "Id_Dosimetro";
			this.Id_Dosimetro.Name = "Id_Dosimetro";
			this.Id_Dosimetro.Visible = false;
			this.Id_Dosimetro.Width = 94;
			// 
			// id_periodo
			// 
			this.id_periodo.DataPropertyName = "id_periodo";
			this.id_periodo.HeaderText = "id_periodo";
			this.id_periodo.Name = "id_periodo";
			this.id_periodo.ReadOnly = true;
			this.id_periodo.Visible = false;
			this.id_periodo.Width = 81;
			// 
			// tld
			// 
			this.tld.DataPropertyName = "tld";
			this.tld.HeaderText = "tld";
			this.tld.Name = "tld";
			this.tld.Visible = false;
			this.tld.Width = 43;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btn_Cargar);
			this.panel1.Controls.Add(this.lbl_id_cliente);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.chkMarcar);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.chkControlado);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(3, 16);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1173, 35);
			this.panel1.TabIndex = 11;
			// 
			// chkMarcar
			// 
			this.chkMarcar.AutoSize = true;
			this.chkMarcar.Location = new System.Drawing.Point(904, 8);
			this.chkMarcar.Name = "chkMarcar";
			this.chkMarcar.Size = new System.Drawing.Size(51, 17);
			this.chkMarcar.TabIndex = 2;
			this.chkMarcar.Text = "MNR";
			this.chkMarcar.UseVisualStyleBackColor = true;
			this.chkMarcar.CheckedChanged += new System.EventHandler(this.chkMarcar_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(593, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Marcar todos";
			// 
			// chkControlado
			// 
			this.chkControlado.AutoSize = true;
			this.chkControlado.Location = new System.Drawing.Point(682, 12);
			this.chkControlado.Name = "chkControlado";
			this.chkControlado.Size = new System.Drawing.Size(77, 17);
			this.chkControlado.TabIndex = 0;
			this.chkControlado.Text = "Controlado";
			this.chkControlado.UseVisualStyleBackColor = true;
			this.chkControlado.CheckedChanged += new System.EventHandler(this.chkControlado_CheckedChanged);
			// 
			// pnl_Progreso
			// 
			this.pnl_Progreso.Controls.Add(this.pgb_Barra);
			this.pnl_Progreso.Location = new System.Drawing.Point(95, 88);
			this.pnl_Progreso.Name = "pnl_Progreso";
			this.pnl_Progreso.Size = new System.Drawing.Size(787, 118);
			this.pnl_Progreso.TabIndex = 10;
			this.pnl_Progreso.TabStop = false;
			this.pnl_Progreso.Text = "Progreso de Grabado";
			// 
			// pgb_Barra
			// 
			this.pgb_Barra.Location = new System.Drawing.Point(21, 43);
			this.pgb_Barra.Name = "pgb_Barra";
			this.pgb_Barra.Size = new System.Drawing.Size(749, 23);
			this.pgb_Barra.TabIndex = 0;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Cliente,
            this.btnIngresarDosisISP});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1184, 25);
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
			// btnIngresarDosisISP
			// 
			this.btnIngresarDosisISP.BackColor = System.Drawing.Color.SkyBlue;
			this.btnIngresarDosisISP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnIngresarDosisISP.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresarDosisISP.Image")));
			this.btnIngresarDosisISP.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnIngresarDosisISP.Name = "btnIngresarDosisISP";
			this.btnIngresarDosisISP.Size = new System.Drawing.Size(58, 22);
			this.btnIngresarDosisISP.Text = "Dosis ISP";
			this.btnIngresarDosisISP.ToolTipText = "Dosis ISP";
			this.btnIngresarDosisISP.Click += new System.EventHandler(this.btnIngresarDosisISP_Click);
			// 
			// btn_Guardar
			// 
			this.btn_Guardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_Guardar.Image = global::ControlDosimetro.Properties.Resources.Save_24;
			this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Guardar.Location = new System.Drawing.Point(338, 494);
			this.btn_Guardar.Name = "btn_Guardar";
			this.btn_Guardar.Size = new System.Drawing.Size(101, 33);
			this.btn_Guardar.TabIndex = 7;
			this.btn_Guardar.Text = "Guardar";
			this.btn_Guardar.UseVisualStyleBackColor = true;
			this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
			// 
			// btn_Cerrar
			// 
			this.btn_Cerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_Cerrar.Image = global::ControlDosimetro.Properties.Resources.Close_24;
			this.btn_Cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Cerrar.Location = new System.Drawing.Point(612, 494);
			this.btn_Cerrar.Name = "btn_Cerrar";
			this.btn_Cerrar.Size = new System.Drawing.Size(96, 30);
			this.btn_Cerrar.TabIndex = 8;
			this.btn_Cerrar.Text = "Cerrar";
			this.btn_Cerrar.UseVisualStyleBackColor = true;
			this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
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
			dataGridViewCellStyle5.Format = "N2";
			dataGridViewCellStyle5.NullValue = "0";
			this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle5;
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
			dataGridViewCellStyle6.Format = "N2";
			dataGridViewCellStyle6.NullValue = "0";
			this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridViewTextBoxColumn10.HeaderText = "Valor Ingresar";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn10.Width = 97;
			// 
			// btn_Cargar
			// 
			this.btn_Cargar.Location = new System.Drawing.Point(219, 6);
			this.btn_Cargar.Name = "btn_Cargar";
			this.btn_Cargar.Size = new System.Drawing.Size(106, 23);
			this.btn_Cargar.TabIndex = 51;
			this.btn_Cargar.Text = "Cargar";
			this.btn_Cargar.UseVisualStyleBackColor = true;
			this.btn_Cargar.Click += new System.EventHandler(this.btn_Cargar_Click);
			// 
			// lbl_id_cliente
			// 
			this.lbl_id_cliente.Location = new System.Drawing.Point(101, 10);
			this.lbl_id_cliente.Name = "lbl_id_cliente";
			this.lbl_id_cliente.Size = new System.Drawing.Size(100, 20);
			this.lbl_id_cliente.TabIndex = 50;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(26, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 49;
			this.label2.Text = "N°  Cliente";
			// 
			// frmIngresoDosisTLD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1184, 555);
			this.Controls.Add(this.btn_Cerrar);
			this.Controls.Add(this.btn_Guardar);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.groupBox2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(776, 464);
			this.Name = "frmIngresoDosisTLD";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ingreso Dosis  TLD";
			this.Load += new System.EventHandler(this.frmIngresoDosisTLD_Load);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.pnl_Progreso.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
		  private System.Windows.Forms.DataGridView grdDatos;
          private System.Windows.Forms.ToolStrip toolStrip1;
								private System.Windows.Forms.Button btn_Guardar;
                                private System.Windows.Forms.Button btn_Cerrar;
                                private System.Windows.Forms.ToolStripButton btnIngresarDosisISP;
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
                                private System.Windows.Forms.DataGridViewTextBoxColumn Id_Personal;
                                private System.Windows.Forms.DataGridViewTextBoxColumn PosicionDisco;
                                private System.Windows.Forms.DataGridViewTextBoxColumn N_Cliente;
                                private GridExtension.IntegerGridColumn NDocumento;
                                private GridExtension.IntegerGridColumn n_dosimetro;
                                private System.Windows.Forms.DataGridViewTextBoxColumn Rut;
                                private System.Windows.Forms.DataGridViewTextBoxColumn Paterno;
                                private System.Windows.Forms.DataGridViewTextBoxColumn Maternos;
                                private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
                                private System.Windows.Forms.DataGridViewCheckBoxColumn Controlado;
                                private System.Windows.Forms.DataGridViewCheckBoxColumn condosis;
                                private GridExtension.RealGridColumn valor;
                                private System.Windows.Forms.DataGridViewComboBoxColumn Estado;
                                private GridExtension.RealGridColumn Cristal1;
                                private GridExtension.RealGridColumn Cristal2;
                                private System.Windows.Forms.DataGridViewTextBoxColumn Id_Dosimetro;
                                private System.Windows.Forms.DataGridViewTextBoxColumn id_periodo;
                                private System.Windows.Forms.DataGridViewTextBoxColumn tld;
        private System.Windows.Forms.ToolStripButton btn_Cliente;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox chkMarcar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox chkControlado;
		private System.Windows.Forms.Button btn_Cargar;
		private System.Windows.Forms.TextBox lbl_id_cliente;
		private System.Windows.Forms.Label label2;
	}
}