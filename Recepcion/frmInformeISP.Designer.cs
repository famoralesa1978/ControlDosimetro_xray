namespace ControlDosimetro
{
	partial class FrmInformeISP
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInformeISP));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btn_CargarCli = new System.Windows.Forms.Button();
			this.lbl_id_cliente = new System.Windows.Forms.TextBox();
			this.lbl_rut_cliente = new System.Windows.Forms.Label();
			this.btn_filtro = new System.Windows.Forms.Button();
			this.btn_cargar = new System.Windows.Forms.Button();
			this.cbx_id_periodo = new System.Windows.Forms.ComboBox();
			this.lbl_nombreCliente = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cbx_anno = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.pnl_Progreso = new System.Windows.Forms.GroupBox();
			this.pgb_Barra = new System.Windows.Forms.ProgressBar();
			this.grdDatos = new System.Windows.Forms.DataGridView();
			this.Id_Personal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.N_pelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id_dosimetro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Generar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.enviado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.N_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Rut = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Maternos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.condosis = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Estado = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.id_sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tld = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btn_Sucursal = new System.Windows.Forms.ToolStripButton();
			this.btn_Guardar = new System.Windows.Forms.Button();
			this.btn_Cerrar = new System.Windows.Forms.Button();
			this.btn_Corregir = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.cbx_Sucursal = new System.Windows.Forms.ComboBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.lbl_Alternativa = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lbl_Original = new System.Windows.Forms.Label();
			this.rbtAlternativa = new System.Windows.Forms.RadioButton();
			this.rbtOiginal = new System.Windows.Forms.RadioButton();
			this.dbd_Archivo = new System.Windows.Forms.FolderBrowserDialog();
			this.lbl_id_seccion = new System.Windows.Forms.Label();
			this.cbx_id_seccion = new System.Windows.Forms.ComboBox();
			this.btnGenerar = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.pnl_Progreso.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.btn_CargarCli);
			this.groupBox1.Controls.Add(this.lbl_id_cliente);
			this.groupBox1.Controls.Add(this.lbl_rut_cliente);
			this.groupBox1.Controls.Add(this.btn_filtro);
			this.groupBox1.Controls.Add(this.btn_cargar);
			this.groupBox1.Controls.Add(this.cbx_id_periodo);
			this.groupBox1.Controls.Add(this.lbl_nombreCliente);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cbx_anno);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(5, 28);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(660, 137);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dato Cliente";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 58);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(24, 13);
			this.label6.TabIndex = 50;
			this.label6.Text = "Rut";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 39);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 13);
			this.label5.TabIndex = 49;
			this.label5.Text = "Razon social";
			// 
			// btn_CargarCli
			// 
			this.btn_CargarCli.Location = new System.Drawing.Point(205, 8);
			this.btn_CargarCli.Name = "btn_CargarCli";
			this.btn_CargarCli.Size = new System.Drawing.Size(106, 23);
			this.btn_CargarCli.TabIndex = 48;
			this.btn_CargarCli.Text = "Cargar cliente";
			this.btn_CargarCli.UseVisualStyleBackColor = true;
			this.btn_CargarCli.Click += new System.EventHandler(this.Btn_CargarCli_Click);
			// 
			// lbl_id_cliente
			// 
			this.lbl_id_cliente.Location = new System.Drawing.Point(87, 12);
			this.lbl_id_cliente.Name = "lbl_id_cliente";
			this.lbl_id_cliente.Size = new System.Drawing.Size(100, 20);
			this.lbl_id_cliente.TabIndex = 47;
			// 
			// lbl_rut_cliente
			// 
			this.lbl_rut_cliente.AutoSize = true;
			this.lbl_rut_cliente.Location = new System.Drawing.Point(84, 58);
			this.lbl_rut_cliente.Name = "lbl_rut_cliente";
			this.lbl_rut_cliente.Size = new System.Drawing.Size(53, 13);
			this.lbl_rut_cliente.TabIndex = 46;
			this.lbl_rut_cliente.Text = "rut cliente";
			// 
			// btn_filtro
			// 
			this.btn_filtro.Location = new System.Drawing.Point(317, 8);
			this.btn_filtro.Name = "btn_filtro";
			this.btn_filtro.Size = new System.Drawing.Size(95, 23);
			this.btn_filtro.TabIndex = 44;
			this.btn_filtro.Text = "Limpiar filtro";
			this.btn_filtro.UseVisualStyleBackColor = true;
			this.btn_filtro.Click += new System.EventHandler(this.Btn_filtro_Click_1);
			// 
			// btn_cargar
			// 
			this.btn_cargar.Location = new System.Drawing.Point(216, 108);
			this.btn_cargar.Name = "btn_cargar";
			this.btn_cargar.Size = new System.Drawing.Size(147, 23);
			this.btn_cargar.TabIndex = 3;
			this.btn_cargar.Text = "Cargar datos periodo";
			this.btn_cargar.UseVisualStyleBackColor = true;
			this.btn_cargar.Click += new System.EventHandler(this.Btn_cargar_Click);
			// 
			// cbx_id_periodo
			// 
			this.cbx_id_periodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_id_periodo.FormattingEnabled = true;
			this.cbx_id_periodo.Location = new System.Drawing.Point(87, 108);
			this.cbx_id_periodo.Name = "cbx_id_periodo";
			this.cbx_id_periodo.Size = new System.Drawing.Size(121, 21);
			this.cbx_id_periodo.TabIndex = 43;
			// 
			// lbl_nombreCliente
			// 
			this.lbl_nombreCliente.AutoSize = true;
			this.lbl_nombreCliente.Location = new System.Drawing.Point(84, 39);
			this.lbl_nombreCliente.Name = "lbl_nombreCliente";
			this.lbl_nombreCliente.Size = new System.Drawing.Size(35, 13);
			this.lbl_nombreCliente.TabIndex = 42;
			this.lbl_nombreCliente.Text = "label1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 113);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 36;
			this.label1.Text = "periodo";
			// 
			// cbx_anno
			// 
			this.cbx_anno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_anno.FormattingEnabled = true;
			this.cbx_anno.Location = new System.Drawing.Point(87, 83);
			this.cbx_anno.Name = "cbx_anno";
			this.cbx_anno.Size = new System.Drawing.Size(121, 21);
			this.cbx_anno.TabIndex = 1;
			this.cbx_anno.SelectedIndexChanged += new System.EventHandler(this.Cbx_anno_SelectedIndexChanged);
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
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 86);
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
			this.groupBox2.Location = new System.Drawing.Point(5, 225);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1079, 315);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Listado";
			// 
			// pnl_Progreso
			// 
			this.pnl_Progreso.Controls.Add(this.pgb_Barra);
			this.pnl_Progreso.Location = new System.Drawing.Point(57, 131);
			this.pnl_Progreso.Name = "pnl_Progreso";
			this.pnl_Progreso.Size = new System.Drawing.Size(787, 118);
			this.pnl_Progreso.TabIndex = 9;
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
            this.N_pelicula,
            this.id_dosimetro,
            this.Generar,
            this.enviado,
            this.N_Cliente,
            this.NDocumento,
            this.Rut,
            this.Nombres,
            this.Paterno,
            this.Maternos,
            this.condosis,
            this.valor,
            this.Estado,
            this.id_sucursal,
            this.tld});
			this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdDatos.Location = new System.Drawing.Point(3, 16);
			this.grdDatos.Name = "grdDatos";
			this.grdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
			this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.grdDatos.Size = new System.Drawing.Size(1073, 296);
			this.grdDatos.TabIndex = 8;
			this.grdDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdDatos_CellContentClick);
			this.grdDatos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GrdDatos_CellFormatting);
			this.grdDatos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdDatos_CellValueChanged);
			this.grdDatos.CurrentCellDirtyStateChanged += new System.EventHandler(this.GrdDatos_CurrentCellDirtyStateChanged);
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
			// N_pelicula
			// 
			this.N_pelicula.DataPropertyName = "N_pelicula";
			this.N_pelicula.HeaderText = "Nº Pelicula";
			this.N_pelicula.Name = "N_pelicula";
			this.N_pelicula.ReadOnly = true;
			this.N_pelicula.Width = 84;
			// 
			// id_dosimetro
			// 
			this.id_dosimetro.DataPropertyName = "id_dosimetro";
			this.id_dosimetro.HeaderText = "Id_dosimetro";
			this.id_dosimetro.Name = "id_dosimetro";
			this.id_dosimetro.Visible = false;
			this.id_dosimetro.Width = 92;
			// 
			// Generar
			// 
			this.Generar.DataPropertyName = "generar";
			this.Generar.FalseValue = "0";
			this.Generar.HeaderText = "Corregir";
			this.Generar.Name = "Generar";
			this.Generar.TrueValue = "1";
			this.Generar.Width = 49;
			// 
			// enviado
			// 
			this.enviado.DataPropertyName = "enviado";
			this.enviado.FalseValue = "0";
			this.enviado.HeaderText = "Generado";
			this.enviado.IndeterminateValue = "";
			this.enviado.Name = "enviado";
			this.enviado.TrueValue = "1";
			this.enviado.Width = 60;
			// 
			// N_Cliente
			// 
			this.N_Cliente.DataPropertyName = "Id_Cliente";
			this.N_Cliente.HeaderText = "N° Cliente";
			this.N_Cliente.Name = "N_Cliente";
			this.N_Cliente.Width = 79;
			// 
			// NDocumento
			// 
			this.NDocumento.DataPropertyName = "N_Documento";
			this.NDocumento.HeaderText = "N° Documento";
			this.NDocumento.Name = "NDocumento";
			this.NDocumento.ReadOnly = true;
			this.NDocumento.Width = 102;
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
			// Nombres
			// 
			this.Nombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.Nombres.DataPropertyName = "Nombres";
			this.Nombres.HeaderText = "Nombres";
			this.Nombres.Name = "Nombres";
			this.Nombres.ReadOnly = true;
			this.Nombres.Width = 74;
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
			// condosis
			// 
			this.condosis.DataPropertyName = "condosis";
			this.condosis.FalseValue = "0";
			this.condosis.HeaderText = "Con Dosis";
			this.condosis.IndeterminateValue = "";
			this.condosis.Name = "condosis";
			this.condosis.ReadOnly = true;
			this.condosis.TrueValue = "1";
			this.condosis.Width = 61;
			// 
			// valor
			// 
			this.valor.DataPropertyName = "dosis";
			this.valor.HeaderText = "Valor Ingresar";
			this.valor.Name = "valor";
			this.valor.ReadOnly = true;
			this.valor.Width = 97;
			// 
			// Estado
			// 
			this.Estado.DataPropertyName = "estadodosis";
			this.Estado.HeaderText = "Estado Controlado";
			this.Estado.Name = "Estado";
			this.Estado.ReadOnly = true;
			// 
			// id_sucursal
			// 
			this.id_sucursal.DataPropertyName = "id_sucursal";
			this.id_sucursal.HeaderText = "id_sucursal";
			this.id_sucursal.Name = "id_sucursal";
			this.id_sucursal.Visible = false;
			this.id_sucursal.Width = 85;
			// 
			// tld
			// 
			this.tld.DataPropertyName = "tld";
			this.tld.HeaderText = "TLD";
			this.tld.Name = "tld";
			this.tld.ReadOnly = true;
			this.tld.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.tld.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.tld.Width = 53;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Sucursal});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1084, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btn_Sucursal
			// 
			this.btn_Sucursal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btn_Sucursal.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sucursal.Image")));
			this.btn_Sucursal.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_Sucursal.Name = "btn_Sucursal";
			this.btn_Sucursal.Size = new System.Drawing.Size(55, 22);
			this.btn_Sucursal.Text = "Sucursal";
			this.btn_Sucursal.Click += new System.EventHandler(this.Btn_Sucursal_Click);
			// 
			// btn_Guardar
			// 
			this.btn_Guardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_Guardar.Location = new System.Drawing.Point(300, 547);
			this.btn_Guardar.Name = "btn_Guardar";
			this.btn_Guardar.Size = new System.Drawing.Size(139, 23);
			this.btn_Guardar.TabIndex = 7;
			this.btn_Guardar.Text = "Generar Archivo ISP";
			this.btn_Guardar.UseVisualStyleBackColor = true;
			this.btn_Guardar.Visible = false;
			this.btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
			// 
			// btn_Cerrar
			// 
			this.btn_Cerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_Cerrar.Location = new System.Drawing.Point(472, 546);
			this.btn_Cerrar.Name = "btn_Cerrar";
			this.btn_Cerrar.Size = new System.Drawing.Size(75, 23);
			this.btn_Cerrar.TabIndex = 8;
			this.btn_Cerrar.Text = "Cerrar";
			this.btn_Cerrar.UseVisualStyleBackColor = true;
			this.btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
			// 
			// btn_Corregir
			// 
			this.btn_Corregir.Location = new System.Drawing.Point(141, 546);
			this.btn_Corregir.Name = "btn_Corregir";
			this.btn_Corregir.Size = new System.Drawing.Size(126, 23);
			this.btn_Corregir.TabIndex = 9;
			this.btn_Corregir.Text = "Grabar Dato Corregir";
			this.btn_Corregir.UseVisualStyleBackColor = true;
			this.btn_Corregir.Click += new System.EventHandler(this.Btn_Corregir_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(5, 174);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Sucursal";
			// 
			// cbx_Sucursal
			// 
			this.cbx_Sucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_Sucursal.FormattingEnabled = true;
			this.cbx_Sucursal.Location = new System.Drawing.Point(59, 171);
			this.cbx_Sucursal.Name = "cbx_Sucursal";
			this.cbx_Sucursal.Size = new System.Drawing.Size(526, 21);
			this.cbx_Sucursal.TabIndex = 11;
			this.cbx_Sucursal.SelectedIndexChanged += new System.EventHandler(this.Cbx_Sucursal_SelectedIndexChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.lbl_Alternativa);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.lbl_Original);
			this.groupBox3.Controls.Add(this.rbtAlternativa);
			this.groupBox3.Controls.Add(this.rbtOiginal);
			this.groupBox3.Location = new System.Drawing.Point(685, 36);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(387, 129);
			this.groupBox3.TabIndex = 12;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Ruta archivo";
			// 
			// lbl_Alternativa
			// 
			this.lbl_Alternativa.AutoSize = true;
			this.lbl_Alternativa.Location = new System.Drawing.Point(6, 100);
			this.lbl_Alternativa.Name = "lbl_Alternativa";
			this.lbl_Alternativa.Size = new System.Drawing.Size(22, 13);
			this.lbl_Alternativa.TabIndex = 6;
			this.lbl_Alternativa.Text = "dfff";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(193, 44);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(0, 13);
			this.label7.TabIndex = 5;
			// 
			// lbl_Original
			// 
			this.lbl_Original.AutoSize = true;
			this.lbl_Original.Location = new System.Drawing.Point(6, 50);
			this.lbl_Original.Name = "lbl_Original";
			this.lbl_Original.Size = new System.Drawing.Size(22, 13);
			this.lbl_Original.TabIndex = 4;
			this.lbl_Original.Text = "dfff";
			// 
			// rbtAlternativa
			// 
			this.rbtAlternativa.AutoSize = true;
			this.rbtAlternativa.Location = new System.Drawing.Point(7, 69);
			this.rbtAlternativa.Name = "rbtAlternativa";
			this.rbtAlternativa.Size = new System.Drawing.Size(75, 17);
			this.rbtAlternativa.TabIndex = 3;
			this.rbtAlternativa.TabStop = true;
			this.rbtAlternativa.Text = "Alternativa";
			this.rbtAlternativa.UseVisualStyleBackColor = true;
			// 
			// rbtOiginal
			// 
			this.rbtOiginal.AutoSize = true;
			this.rbtOiginal.Location = new System.Drawing.Point(7, 19);
			this.rbtOiginal.Name = "rbtOiginal";
			this.rbtOiginal.Size = new System.Drawing.Size(60, 17);
			this.rbtOiginal.TabIndex = 2;
			this.rbtOiginal.TabStop = true;
			this.rbtOiginal.Text = "Original";
			this.rbtOiginal.UseVisualStyleBackColor = true;
			// 
			// lbl_id_seccion
			// 
			this.lbl_id_seccion.AutoSize = true;
			this.lbl_id_seccion.Location = new System.Drawing.Point(5, 201);
			this.lbl_id_seccion.Name = "lbl_id_seccion";
			this.lbl_id_seccion.Size = new System.Drawing.Size(46, 13);
			this.lbl_id_seccion.TabIndex = 17;
			this.lbl_id_seccion.Text = "Sección";
			// 
			// cbx_id_seccion
			// 
			this.cbx_id_seccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_id_seccion.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbx_id_seccion.FormattingEnabled = true;
			this.cbx_id_seccion.Location = new System.Drawing.Point(59, 198);
			this.cbx_id_seccion.Name = "cbx_id_seccion";
			this.cbx_id_seccion.Size = new System.Drawing.Size(236, 21);
			this.cbx_id_seccion.TabIndex = 16;
			this.cbx_id_seccion.SelectedIndexChanged += new System.EventHandler(this.cbx_id_seccion_SelectedIndexChanged);
			// 
			// btnGenerar
			// 
			this.btnGenerar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnGenerar.Location = new System.Drawing.Point(613, 547);
			this.btnGenerar.Name = "btnGenerar";
			this.btnGenerar.Size = new System.Drawing.Size(139, 23);
			this.btnGenerar.TabIndex = 18;
			this.btnGenerar.Text = "Generar Archivo ISP";
			this.btnGenerar.UseVisualStyleBackColor = true;
			this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
			// 
			// FrmInformeISP
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1084, 578);
			this.Controls.Add(this.btnGenerar);
			this.Controls.Add(this.lbl_id_seccion);
			this.Controls.Add(this.cbx_id_seccion);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.cbx_Sucursal);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btn_Corregir);
			this.Controls.Add(this.btn_Cerrar);
			this.Controls.Add(this.btn_Guardar);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(776, 464);
			this.Name = "FrmInformeISP";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dosis ISP";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.pnl_Progreso.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
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
		private System.Windows.Forms.Label lbl_nombreCliente;
		private System.Windows.Forms.ComboBox cbx_id_periodo;
		private System.Windows.Forms.Button btn_cargar;
		private System.Windows.Forms.Button btn_Guardar;
		private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_filtro;
        private System.Windows.Forms.GroupBox pnl_Progreso;
        private System.Windows.Forms.ProgressBar pgb_Barra;
        private System.Windows.Forms.Button btn_Corregir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_Sucursal;
        private System.Windows.Forms.ToolStripButton btn_Sucursal;
        private System.Windows.Forms.Label lbl_rut_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Personal;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_pelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_dosimetro;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Generar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn enviado;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maternos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn condosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewComboBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_sucursal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tld;
        private System.Windows.Forms.TextBox lbl_id_cliente;
        private System.Windows.Forms.Button btn_CargarCli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.FolderBrowserDialog dbd_Archivo;
		private System.Windows.Forms.Label lbl_Original;
		private System.Windows.Forms.RadioButton rbtAlternativa;
		private System.Windows.Forms.RadioButton rbtOiginal;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lbl_Alternativa;
		private System.Windows.Forms.Label lbl_id_seccion;
		private System.Windows.Forms.ComboBox cbx_id_seccion;
		private System.Windows.Forms.Button btnGenerar;
	}
}