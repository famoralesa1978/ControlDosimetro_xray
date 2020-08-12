namespace ControlDosimetro
{
    partial class frmMantenedorWeb
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
            this.stsEstado = new System.Windows.Forms.StatusStrip();
            this.tssDescEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAgregar = new System.Windows.Forms.ToolStripButton();
            this.scPrincipal = new System.Windows.Forms.SplitContainer();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.gpxListado = new System.Windows.Forms.GroupBox();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.cmsMenuContexto = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmSep3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmAsignarPermiso = new System.Windows.Forms.ToolStripMenuItem();
            this.gpxFiltrar = new System.Windows.Forms.GroupBox();
            this.cbx_Id_menuWeb_Buscar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.cbx_Id_Estado_Buscar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbl_MenuWeb = new System.Windows.Forms.GroupBox();
            this.cbx_Class = new System.Windows.Forms.ComboBox();
            this.lbl_Id_Estado = new System.Windows.Forms.Label();
            this.lbl_Orden = new System.Windows.Forms.Label();
            this.lbl_Class = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.txt_Orden = new System.Windows.Forms.TextBox();
            this.txt_Titulo = new System.Windows.Forms.TextBox();
            this.txt_DirUrl = new System.Windows.Forms.TextBox();
            this.cbx_Id_menu_Padre = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.cbx_Id_Estado = new System.Windows.Forms.ComboBox();
            this.lbl_DirUrl = new System.Windows.Forms.Label();
            this.lbl_Id_menu_Padre = new System.Windows.Forms.Label();
            this.txt_Menu = new System.Windows.Forms.TextBox();
            this.lbl_Menu = new System.Windows.Forms.Label();
            this.lbl_Id_menuWeb = new System.Windows.Forms.Label();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.ColMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stsEstado.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scPrincipal)).BeginInit();
            this.scPrincipal.Panel1.SuspendLayout();
            this.scPrincipal.Panel2.SuspendLayout();
            this.scPrincipal.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            this.gpxListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.cmsMenuContexto.SuspendLayout();
            this.gpxFiltrar.SuspendLayout();
            this.tbl_MenuWeb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // stsEstado
            // 
            this.stsEstado.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssDescEstado,
            this.tssEstado});
            this.stsEstado.Location = new System.Drawing.Point(0, 351);
            this.stsEstado.Name = "stsEstado";
            this.stsEstado.Size = new System.Drawing.Size(748, 22);
            this.stsEstado.SizingGrip = false;
            this.stsEstado.TabIndex = 0;
            this.stsEstado.Text = "statusStrip1";
            // 
            // tssDescEstado
            // 
            this.tssDescEstado.Name = "tssDescEstado";
            this.tssDescEstado.Size = new System.Drawing.Size(42, 17);
            this.tssDescEstado.Text = "Estado";
            // 
            // tssEstado
            // 
            this.tssEstado.Name = "tssEstado";
            this.tssEstado.Size = new System.Drawing.Size(39, 17);
            this.tssEstado.Text = "Status";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardar,
            this.toolStripSeparator1,
            this.tsbAgregar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(748, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGuardar.Image = global::ControlDosimetro.Properties.Resources.save_32;
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(24, 24);
            this.tsbGuardar.Text = "toolStripButton1";
            this.tsbGuardar.ToolTipText = "Guarda la infomación";
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbAgregar
            // 
            this.tsbAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAgregar.Image = global::ControlDosimetro.Properties.Resources.Agregar;
            this.tsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAgregar.Name = "tsbAgregar";
            this.tsbAgregar.Size = new System.Drawing.Size(24, 24);
            this.tsbAgregar.Text = "Permite  Agregar un perfil de usuario";
            this.tsbAgregar.Click += new System.EventHandler(this.tsbAgregar_Click);
            // 
            // scPrincipal
            // 
            this.scPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scPrincipal.Location = new System.Drawing.Point(0, 25);
            this.scPrincipal.Name = "scPrincipal";
            // 
            // scPrincipal.Panel1
            // 
            this.scPrincipal.Panel1.AutoScroll = true;
            this.scPrincipal.Panel1.AutoScrollMinSize = new System.Drawing.Size(200, 0);
            this.scPrincipal.Panel1.Controls.Add(this.pnlPrincipal);
            this.scPrincipal.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.scPrincipal.Panel1MinSize = 400;
            // 
            // scPrincipal.Panel2
            // 
            this.scPrincipal.Panel2.Controls.Add(this.tbl_MenuWeb);
            this.scPrincipal.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.scPrincipal.Panel2MinSize = 300;
            this.scPrincipal.Size = new System.Drawing.Size(735, 323);
            this.scPrincipal.SplitterDistance = 400;
            this.scPrincipal.TabIndex = 2;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPrincipal.Controls.Add(this.gpxListado);
            this.pnlPrincipal.Controls.Add(this.gpxFiltrar);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Margin = new System.Windows.Forms.Padding(6, 3, 5, 3);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(400, 323);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // gpxListado
            // 
            this.gpxListado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpxListado.Controls.Add(this.dgvGrilla);
            this.gpxListado.Location = new System.Drawing.Point(0, 140);
            this.gpxListado.Name = "gpxListado";
            this.gpxListado.Size = new System.Drawing.Size(392, 181);
            this.gpxListado.TabIndex = 4;
            this.gpxListado.TabStop = false;
            this.gpxListado.Text = "Listado";
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.AllowUserToAddRows = false;
            this.dgvGrilla.AllowUserToDeleteRows = false;
            this.dgvGrilla.AllowUserToOrderColumns = true;
            this.dgvGrilla.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGrilla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGrilla.ColumnHeadersHeight = 42;
            this.dgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMenu,
            this.ColTitulo,
            this.ColOrden});
            this.dgvGrilla.ContextMenuStrip = this.cmsMenuContexto;
            this.dgvGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrilla.Location = new System.Drawing.Point(3, 16);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.Size = new System.Drawing.Size(386, 162);
            this.dgvGrilla.TabIndex = 4;
            this.dgvGrilla.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrilla_CellDoubleClick);
            this.dgvGrilla.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvGrilla_ColumnWidthChanged);
            this.dgvGrilla.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvGrilla_Paint);
            // 
            // cmsMenuContexto
            // 
            this.cmsMenuContexto.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsMenuContexto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmActualizar,
            this.toolStripSeparator2,
            this.tsmSep3,
            this.tsmAsignarPermiso});
            this.cmsMenuContexto.Name = "cmsMenuContexto";
            this.cmsMenuContexto.Size = new System.Drawing.Size(161, 60);
            // 
            // tsmActualizar
            // 
            this.tsmActualizar.Name = "tsmActualizar";
            this.tsmActualizar.Size = new System.Drawing.Size(160, 22);
            this.tsmActualizar.Text = "Modificar";
            this.tsmActualizar.Click += new System.EventHandler(this.TsmActualizar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // tsmSep3
            // 
            this.tsmSep3.Name = "tsmSep3";
            this.tsmSep3.Size = new System.Drawing.Size(157, 6);
            this.tsmSep3.Visible = false;
            // 
            // tsmAsignarPermiso
            // 
            this.tsmAsignarPermiso.Name = "tsmAsignarPermiso";
            this.tsmAsignarPermiso.Size = new System.Drawing.Size(160, 22);
            this.tsmAsignarPermiso.Text = "Asignar permiso";
            this.tsmAsignarPermiso.Visible = false;
            // 
            // gpxFiltrar
            // 
            this.gpxFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpxFiltrar.Controls.Add(this.cbx_Id_menuWeb_Buscar);
            this.gpxFiltrar.Controls.Add(this.label6);
            this.gpxFiltrar.Controls.Add(this.btn_Buscar);
            this.gpxFiltrar.Controls.Add(this.cbx_Id_Estado_Buscar);
            this.gpxFiltrar.Controls.Add(this.label1);
            this.gpxFiltrar.Location = new System.Drawing.Point(3, 3);
            this.gpxFiltrar.Name = "gpxFiltrar";
            this.gpxFiltrar.Size = new System.Drawing.Size(389, 147);
            this.gpxFiltrar.TabIndex = 0;
            this.gpxFiltrar.TabStop = false;
            this.gpxFiltrar.Text = "Filtrar";
            // 
            // cbx_Id_menuWeb_Buscar
            // 
            this.cbx_Id_menuWeb_Buscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Id_menuWeb_Buscar.FormattingEnabled = true;
            this.cbx_Id_menuWeb_Buscar.Location = new System.Drawing.Point(106, 33);
            this.cbx_Id_menuWeb_Buscar.Name = "cbx_Id_menuWeb_Buscar";
            this.cbx_Id_menuWeb_Buscar.Size = new System.Drawing.Size(153, 21);
            this.cbx_Id_menuWeb_Buscar.TabIndex = 1;
            this.cbx_Id_menuWeb_Buscar.SelectedIndexChanged += new System.EventHandler(this.cbx_Id_menuWeb_Buscar_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Menu";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Buscar.Image = global::ControlDosimetro.Properties.Resources.Buscar;
            this.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Buscar.Location = new System.Drawing.Point(282, 46);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(42, 42);
            this.btn_Buscar.TabIndex = 3;
            this.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // cbx_Id_Estado_Buscar
            // 
            this.cbx_Id_Estado_Buscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Id_Estado_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbx_Id_Estado_Buscar.FormattingEnabled = true;
            this.cbx_Id_Estado_Buscar.Location = new System.Drawing.Point(106, 77);
            this.cbx_Id_Estado_Buscar.Name = "cbx_Id_Estado_Buscar";
            this.cbx_Id_Estado_Buscar.Size = new System.Drawing.Size(153, 21);
            this.cbx_Id_Estado_Buscar.TabIndex = 2;
            this.cbx_Id_Estado_Buscar.SelectedIndexChanged += new System.EventHandler(this.cbx_Id_Estado_Buscar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Estado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbl_MenuWeb
            // 
            this.tbl_MenuWeb.BackColor = System.Drawing.SystemColors.Control;
            this.tbl_MenuWeb.Controls.Add(this.cbx_Class);
            this.tbl_MenuWeb.Controls.Add(this.lbl_Id_Estado);
            this.tbl_MenuWeb.Controls.Add(this.lbl_Orden);
            this.tbl_MenuWeb.Controls.Add(this.lbl_Class);
            this.tbl_MenuWeb.Controls.Add(this.lbl_Titulo);
            this.tbl_MenuWeb.Controls.Add(this.txt_Orden);
            this.tbl_MenuWeb.Controls.Add(this.txt_Titulo);
            this.tbl_MenuWeb.Controls.Add(this.txt_DirUrl);
            this.tbl_MenuWeb.Controls.Add(this.cbx_Id_menu_Padre);
            this.tbl_MenuWeb.Controls.Add(this.pictureBox1);
            this.tbl_MenuWeb.Controls.Add(this.btn_Guardar);
            this.tbl_MenuWeb.Controls.Add(this.cbx_Id_Estado);
            this.tbl_MenuWeb.Controls.Add(this.lbl_DirUrl);
            this.tbl_MenuWeb.Controls.Add(this.lbl_Id_menu_Padre);
            this.tbl_MenuWeb.Controls.Add(this.txt_Menu);
            this.tbl_MenuWeb.Controls.Add(this.lbl_Menu);
            this.tbl_MenuWeb.Controls.Add(this.lbl_Id_menuWeb);
            this.tbl_MenuWeb.Controls.Add(this.btn_Limpiar);
            this.tbl_MenuWeb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_MenuWeb.Location = new System.Drawing.Point(0, 0);
            this.tbl_MenuWeb.Name = "tbl_MenuWeb";
            this.tbl_MenuWeb.Size = new System.Drawing.Size(331, 323);
            this.tbl_MenuWeb.TabIndex = 6;
            this.tbl_MenuWeb.TabStop = false;
            this.tbl_MenuWeb.Text = "Datos";
            // 
            // cbx_Class
            // 
            this.cbx_Class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Class.FormattingEnabled = true;
            this.cbx_Class.Location = new System.Drawing.Point(88, 174);
            this.cbx_Class.Name = "cbx_Class";
            this.cbx_Class.Size = new System.Drawing.Size(213, 21);
            this.cbx_Class.TabIndex = 12;
            // 
            // lbl_Id_Estado
            // 
            this.lbl_Id_Estado.AutoSize = true;
            this.lbl_Id_Estado.Location = new System.Drawing.Point(21, 238);
            this.lbl_Id_Estado.Name = "lbl_Id_Estado";
            this.lbl_Id_Estado.Size = new System.Drawing.Size(40, 13);
            this.lbl_Id_Estado.TabIndex = 32;
            this.lbl_Id_Estado.Text = "Estado";
            // 
            // lbl_Orden
            // 
            this.lbl_Orden.AutoSize = true;
            this.lbl_Orden.Location = new System.Drawing.Point(21, 209);
            this.lbl_Orden.Name = "lbl_Orden";
            this.lbl_Orden.Size = new System.Drawing.Size(36, 13);
            this.lbl_Orden.TabIndex = 31;
            this.lbl_Orden.Text = "Orden";
            // 
            // lbl_Class
            // 
            this.lbl_Class.AutoSize = true;
            this.lbl_Class.Location = new System.Drawing.Point(21, 180);
            this.lbl_Class.Name = "lbl_Class";
            this.lbl_Class.Size = new System.Drawing.Size(33, 13);
            this.lbl_Class.TabIndex = 30;
            this.lbl_Class.Text = "Clase";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Location = new System.Drawing.Point(21, 151);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(35, 13);
            this.lbl_Titulo.TabIndex = 29;
            this.lbl_Titulo.Text = "Título";
            // 
            // txt_Orden
            // 
            this.txt_Orden.Location = new System.Drawing.Point(88, 203);
            this.txt_Orden.MaxLength = 3;
            this.txt_Orden.Name = "txt_Orden";
            this.txt_Orden.Size = new System.Drawing.Size(213, 20);
            this.txt_Orden.TabIndex = 13;
            this.txt_Orden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Orden_KeyPress);
            // 
            // txt_Titulo
            // 
            this.txt_Titulo.Location = new System.Drawing.Point(88, 146);
            this.txt_Titulo.MaxLength = 100;
            this.txt_Titulo.Name = "txt_Titulo";
            this.txt_Titulo.Size = new System.Drawing.Size(213, 20);
            this.txt_Titulo.TabIndex = 11;
            // 
            // txt_DirUrl
            // 
            this.txt_DirUrl.Location = new System.Drawing.Point(88, 118);
            this.txt_DirUrl.MaxLength = 100;
            this.txt_DirUrl.Name = "txt_DirUrl";
            this.txt_DirUrl.Size = new System.Drawing.Size(213, 20);
            this.txt_DirUrl.TabIndex = 10;
            // 
            // cbx_Id_menu_Padre
            // 
            this.cbx_Id_menu_Padre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Id_menu_Padre.FormattingEnabled = true;
            this.cbx_Id_menu_Padre.Location = new System.Drawing.Point(88, 89);
            this.cbx_Id_menu_Padre.Name = "cbx_Id_menu_Padre";
            this.cbx_Id_menu_Padre.Size = new System.Drawing.Size(213, 21);
            this.cbx_Id_menu_Padre.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::ControlDosimetro.Properties.Resources.minimizar;
            this.pictureBox1.InitialImage = global::ControlDosimetro.Properties.Resources.minimizar;
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Btn_Minimizar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Guardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Guardar.Image = global::ControlDosimetro.Properties.Resources.save_32;
            this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Guardar.Location = new System.Drawing.Point(88, 273);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(87, 40);
            this.btn_Guardar.TabIndex = 15;
            this.btn_Guardar.Text = "Grabar";
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // cbx_Id_Estado
            // 
            this.cbx_Id_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Id_Estado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbx_Id_Estado.FormattingEnabled = true;
            this.cbx_Id_Estado.Location = new System.Drawing.Point(88, 231);
            this.cbx_Id_Estado.Name = "cbx_Id_Estado";
            this.cbx_Id_Estado.Size = new System.Drawing.Size(213, 21);
            this.cbx_Id_Estado.TabIndex = 14;
            // 
            // lbl_DirUrl
            // 
            this.lbl_DirUrl.AutoSize = true;
            this.lbl_DirUrl.Location = new System.Drawing.Point(21, 122);
            this.lbl_DirUrl.Name = "lbl_DirUrl";
            this.lbl_DirUrl.Size = new System.Drawing.Size(29, 13);
            this.lbl_DirUrl.TabIndex = 20;
            this.lbl_DirUrl.Text = "URL";
            // 
            // lbl_Id_menu_Padre
            // 
            this.lbl_Id_menu_Padre.AutoSize = true;
            this.lbl_Id_menu_Padre.Location = new System.Drawing.Point(21, 93);
            this.lbl_Id_menu_Padre.Name = "lbl_Id_menu_Padre";
            this.lbl_Id_menu_Padre.Size = new System.Drawing.Size(65, 13);
            this.lbl_Id_menu_Padre.TabIndex = 18;
            this.lbl_Id_menu_Padre.Text = "Menu Padre";
            // 
            // txt_Menu
            // 
            this.txt_Menu.Location = new System.Drawing.Point(88, 61);
            this.txt_Menu.MaxLength = 100;
            this.txt_Menu.Name = "txt_Menu";
            this.txt_Menu.Size = new System.Drawing.Size(213, 20);
            this.txt_Menu.TabIndex = 8;
            // 
            // lbl_Menu
            // 
            this.lbl_Menu.AutoSize = true;
            this.lbl_Menu.Location = new System.Drawing.Point(21, 64);
            this.lbl_Menu.Name = "lbl_Menu";
            this.lbl_Menu.Size = new System.Drawing.Size(34, 13);
            this.lbl_Menu.TabIndex = 16;
            this.lbl_Menu.Text = "Menu";
            // 
            // lbl_Id_menuWeb
            // 
            this.lbl_Id_menuWeb.AutoSize = true;
            this.lbl_Id_menuWeb.Location = new System.Drawing.Point(21, 40);
            this.lbl_Id_menuWeb.Name = "lbl_Id_menuWeb";
            this.lbl_Id_menuWeb.Size = new System.Drawing.Size(18, 13);
            this.lbl_Id_menuWeb.TabIndex = 14;
            this.lbl_Id_menuWeb.Text = "ID";
            this.lbl_Id_menuWeb.Visible = false;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Limpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Limpiar.Image = global::ControlDosimetro.Properties.Resources.Limpiar;
            this.btn_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Limpiar.Location = new System.Drawing.Point(216, 273);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(85, 40);
            this.btn_Limpiar.TabIndex = 16;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // ColMenu
            // 
            this.ColMenu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColMenu.DataPropertyName = "Menu";
            this.ColMenu.HeaderText = "Menu";
            this.ColMenu.Name = "ColMenu";
            this.ColMenu.ReadOnly = true;
            // 
            // ColTitulo
            // 
            this.ColTitulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTitulo.DataPropertyName = "Titulo";
            this.ColTitulo.HeaderText = "Título";
            this.ColTitulo.Name = "ColTitulo";
            this.ColTitulo.ReadOnly = true;
            // 
            // ColOrden
            // 
            this.ColOrden.DataPropertyName = "Orden";
            this.ColOrden.HeaderText = "Orden";
            this.ColOrden.Name = "ColOrden";
            this.ColOrden.ReadOnly = true;
            this.ColOrden.Width = 80;
            // 
            // frmMantenedorWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(748, 373);
            this.Controls.Add(this.scPrincipal);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.stsEstado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(764, 410);
            this.Name = "frmMantenedorWeb";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenedor Web";
            this.Load += new System.EventHandler(this.frmMantenedorPerfil_Load);
            this.stsEstado.ResumeLayout(false);
            this.stsEstado.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.scPrincipal.Panel1.ResumeLayout(false);
            this.scPrincipal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scPrincipal)).EndInit();
            this.scPrincipal.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            this.gpxListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.cmsMenuContexto.ResumeLayout(false);
            this.gpxFiltrar.ResumeLayout(false);
            this.gpxFiltrar.PerformLayout();
            this.tbl_MenuWeb.ResumeLayout(false);
            this.tbl_MenuWeb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stsEstado;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.SplitContainer scPrincipal;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbAgregar;
        private System.Windows.Forms.GroupBox gpxFiltrar;
        private System.Windows.Forms.ComboBox cbx_Id_Estado_Buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.GroupBox gpxListado;
        private System.Windows.Forms.GroupBox tbl_MenuWeb;
        private System.Windows.Forms.ContextMenuStrip cmsMenuContexto;
        private System.Windows.Forms.ToolStripMenuItem tsmActualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator tsmSep3;
        private System.Windows.Forms.ToolStripMenuItem tsmAsignarPermiso;
        private System.Windows.Forms.ToolStripStatusLabel tssDescEstado;
        private System.Windows.Forms.ToolStripStatusLabel tssEstado;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.ComboBox cbx_Id_Estado;
        private System.Windows.Forms.Label lbl_DirUrl;
        private System.Windows.Forms.Label lbl_Id_menu_Padre;
        private System.Windows.Forms.TextBox txt_Menu;
        private System.Windows.Forms.Label lbl_Menu;
        private System.Windows.Forms.Label lbl_Id_menuWeb;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbx_Id_menuWeb_Buscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_Id_menu_Padre;
        private System.Windows.Forms.ComboBox cbx_Class;
        private System.Windows.Forms.Label lbl_Id_Estado;
        private System.Windows.Forms.Label lbl_Orden;
        private System.Windows.Forms.Label lbl_Class;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.TextBox txt_Orden;
        private System.Windows.Forms.TextBox txt_Titulo;
        private System.Windows.Forms.TextBox txt_DirUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOrden;
    }
}