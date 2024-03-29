﻿namespace ControlDosimetro
{
	partial class FrmInformeDetalleISPAnual
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_IdCliente = new System.Windows.Forms.TextBox();
			this.lbl_run = new System.Windows.Forms.Label();
			this.cbxSucursal = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btn_CargarCli = new System.Windows.Forms.Button();
			this.lbl_Rut = new System.Windows.Forms.Label();
			this.btn_filtro = new System.Windows.Forms.Button();
			this.btn_cargar = new System.Windows.Forms.Button();
			this.lbl_nombreCliente = new System.Windows.Forms.Label();
			this.cbx_anno = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.grpInformacion = new System.Windows.Forms.GroupBox();
			this.pnl_Progreso = new System.Windows.Forms.GroupBox();
			this.pgb_Barra = new System.Windows.Forms.ProgressBar();
			this.grdDatos = new System.Windows.Forms.DataGridView();
			this.colGenerar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Rut = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Maternos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col1ertri = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col2dotri = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col3ertri = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col4totri = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btn_Guardar = new System.Windows.Forms.Button();
			this.btn_Cerrar = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.lbl_Alternativa = new System.Windows.Forms.Label();
			this.lbl_Original = new System.Windows.Forms.Label();
			this.rbtAlternativa = new System.Windows.Forms.RadioButton();
			this.rbtOiginal = new System.Windows.Forms.RadioButton();
			this.dbd_Archivo = new System.Windows.Forms.FolderBrowserDialog();
			this.btnGenerar = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.grpInformacion.SuspendLayout();
			this.pnl_Progreso.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txt_IdCliente);
			this.groupBox1.Controls.Add(this.lbl_run);
			this.groupBox1.Controls.Add(this.cbxSucursal);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.btn_CargarCli);
			this.groupBox1.Controls.Add(this.lbl_Rut);
			this.groupBox1.Controls.Add(this.btn_filtro);
			this.groupBox1.Controls.Add(this.btn_cargar);
			this.groupBox1.Controls.Add(this.lbl_nombreCliente);
			this.groupBox1.Controls.Add(this.cbx_anno);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(5, 28);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(660, 137);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dato Cliente";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(248, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(108, 13);
			this.label4.TabIndex = 55;
			this.label4.Text = "Formato: 12345678-9";
			// 
			// txt_IdCliente
			// 
			this.txt_IdCliente.Location = new System.Drawing.Point(87, 13);
			this.txt_IdCliente.MaxLength = 10;
			this.txt_IdCliente.Name = "txt_IdCliente";
			this.txt_IdCliente.Size = new System.Drawing.Size(120, 20);
			this.txt_IdCliente.TabIndex = 54;
			// 
			// lbl_run
			// 
			this.lbl_run.AutoSize = true;
			this.lbl_run.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_run.Location = new System.Drawing.Point(14, 39);
			this.lbl_run.Name = "lbl_run";
			this.lbl_run.Size = new System.Drawing.Size(24, 13);
			this.lbl_run.TabIndex = 53;
			this.lbl_run.Text = "Rut";
			// 
			// cbxSucursal
			// 
			this.cbxSucursal.DisplayMember = "Direccion";
			this.cbxSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxSucursal.FormattingEnabled = true;
			this.cbxSucursal.Location = new System.Drawing.Point(87, 110);
			this.cbxSucursal.Name = "cbxSucursal";
			this.cbxSucursal.Size = new System.Drawing.Size(414, 21);
			this.cbxSucursal.TabIndex = 52;
			this.cbxSucursal.ValueMember = "Id_sucursal";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 113);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 13);
			this.label1.TabIndex = 51;
			this.label1.Text = "Sucursal";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 13);
			this.label6.TabIndex = 50;
			this.label6.Text = "N° cliente";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(14, 58);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 13);
			this.label5.TabIndex = 49;
			this.label5.Text = "Razon social";
			// 
			// btn_CargarCli
			// 
			this.btn_CargarCli.Location = new System.Drawing.Point(367, 10);
			this.btn_CargarCli.Name = "btn_CargarCli";
			this.btn_CargarCli.Size = new System.Drawing.Size(106, 23);
			this.btn_CargarCli.TabIndex = 48;
			this.btn_CargarCli.Text = "Cargar cliente";
			this.btn_CargarCli.UseVisualStyleBackColor = true;
			this.btn_CargarCli.Click += new System.EventHandler(this.Btn_CargarCli_Click);
			// 
			// lbl_Rut
			// 
			this.lbl_Rut.AutoSize = true;
			this.lbl_Rut.Location = new System.Drawing.Point(84, 39);
			this.lbl_Rut.Name = "lbl_Rut";
			this.lbl_Rut.Size = new System.Drawing.Size(53, 13);
			this.lbl_Rut.TabIndex = 46;
			this.lbl_Rut.Text = "rut cliente";
			// 
			// btn_filtro
			// 
			this.btn_filtro.Location = new System.Drawing.Point(479, 11);
			this.btn_filtro.Name = "btn_filtro";
			this.btn_filtro.Size = new System.Drawing.Size(95, 23);
			this.btn_filtro.TabIndex = 44;
			this.btn_filtro.Text = "Limpiar filtro";
			this.btn_filtro.UseVisualStyleBackColor = true;
			this.btn_filtro.Click += new System.EventHandler(this.Btn_filtro_Click_1);
			// 
			// btn_cargar
			// 
			this.btn_cargar.Location = new System.Drawing.Point(507, 108);
			this.btn_cargar.Name = "btn_cargar";
			this.btn_cargar.Size = new System.Drawing.Size(147, 23);
			this.btn_cargar.TabIndex = 3;
			this.btn_cargar.Text = "Cargar datos periodo";
			this.btn_cargar.UseVisualStyleBackColor = true;
			this.btn_cargar.Click += new System.EventHandler(this.Btn_cargar_Click);
			// 
			// lbl_nombreCliente
			// 
			this.lbl_nombreCliente.AutoSize = true;
			this.lbl_nombreCliente.Location = new System.Drawing.Point(86, 58);
			this.lbl_nombreCliente.Name = "lbl_nombreCliente";
			this.lbl_nombreCliente.Size = new System.Drawing.Size(35, 13);
			this.lbl_nombreCliente.TabIndex = 42;
			this.lbl_nombreCliente.Text = "label1";
			// 
			// cbx_anno
			// 
			this.cbx_anno.DisplayMember = "anno";
			this.cbx_anno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_anno.FormattingEnabled = true;
			this.cbx_anno.Location = new System.Drawing.Point(87, 83);
			this.cbx_anno.Name = "cbx_anno";
			this.cbx_anno.Size = new System.Drawing.Size(121, 21);
			this.cbx_anno.TabIndex = 1;
			this.cbx_anno.ValueMember = "anno";
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
			// grpInformacion
			// 
			this.grpInformacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grpInformacion.Controls.Add(this.pnl_Progreso);
			this.grpInformacion.Controls.Add(this.grdDatos);
			this.grpInformacion.Location = new System.Drawing.Point(5, 171);
			this.grpInformacion.Name = "grpInformacion";
			this.grpInformacion.Size = new System.Drawing.Size(975, 369);
			this.grpInformacion.TabIndex = 6;
			this.grpInformacion.TabStop = false;
			this.grpInformacion.Text = "Listado";
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
            this.colGenerar,
            this.Rut,
            this.Nombres,
            this.Paterno,
            this.Maternos,
            this.col1ertri,
            this.col2dotri,
            this.col3ertri,
            this.col4totri});
			this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdDatos.Location = new System.Drawing.Point(3, 16);
			this.grdDatos.Name = "grdDatos";
			this.grdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
			this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.grdDatos.Size = new System.Drawing.Size(969, 350);
			this.grdDatos.TabIndex = 8;
			this.grdDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdDatos_CellContentClick);
			this.grdDatos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GrdDatos_CellFormatting);
			this.grdDatos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdDatos_CellValueChanged);
			this.grdDatos.CurrentCellDirtyStateChanged += new System.EventHandler(this.GrdDatos_CurrentCellDirtyStateChanged);
			// 
			// colGenerar
			// 
			this.colGenerar.DataPropertyName = "Generar";
			this.colGenerar.HeaderText = "Generar";
			this.colGenerar.Name = "colGenerar";
			this.colGenerar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.colGenerar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.colGenerar.Width = 70;
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
			// col1ertri
			// 
			this.col1ertri.DataPropertyName = "1er tri";
			this.col1ertri.HeaderText = "1er tri";
			this.col1ertri.Name = "col1ertri";
			this.col1ertri.ReadOnly = true;
			this.col1ertri.Width = 58;
			// 
			// col2dotri
			// 
			this.col2dotri.DataPropertyName = "2do tri";
			this.col2dotri.HeaderText = "2do tri";
			this.col2dotri.Name = "col2dotri";
			this.col2dotri.ReadOnly = true;
			this.col2dotri.Width = 61;
			// 
			// col3ertri
			// 
			this.col3ertri.DataPropertyName = "3er tri";
			this.col3ertri.HeaderText = "3er tri";
			this.col3ertri.Name = "col3ertri";
			this.col3ertri.ReadOnly = true;
			this.col3ertri.Width = 58;
			// 
			// col4totri
			// 
			this.col4totri.DataPropertyName = "4to tri";
			this.col4totri.HeaderText = "4to tri";
			this.col4totri.Name = "col4totri";
			this.col4totri.ReadOnly = true;
			this.col4totri.Width = 58;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(980, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btn_Guardar
			// 
			this.btn_Guardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_Guardar.Location = new System.Drawing.Point(612, 543);
			this.btn_Guardar.Name = "btn_Guardar";
			this.btn_Guardar.Size = new System.Drawing.Size(139, 23);
			this.btn_Guardar.TabIndex = 7;
			this.btn_Guardar.Text = "Generar Archivo ISP";
			this.btn_Guardar.UseVisualStyleBackColor = true;
			this.btn_Guardar.Visible = false;
			// 
			// btn_Cerrar
			// 
			this.btn_Cerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btn_Cerrar.Location = new System.Drawing.Point(420, 546);
			this.btn_Cerrar.Name = "btn_Cerrar";
			this.btn_Cerrar.Size = new System.Drawing.Size(75, 23);
			this.btn_Cerrar.TabIndex = 8;
			this.btn_Cerrar.Text = "Cerrar";
			this.btn_Cerrar.UseVisualStyleBackColor = true;
			this.btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.lbl_Alternativa);
			this.groupBox3.Controls.Add(this.lbl_Original);
			this.groupBox3.Controls.Add(this.rbtAlternativa);
			this.groupBox3.Controls.Add(this.rbtOiginal);
			this.groupBox3.Location = new System.Drawing.Point(685, 36);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(287, 129);
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
			// btnGenerar
			// 
			this.btnGenerar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnGenerar.Location = new System.Drawing.Point(252, 547);
			this.btnGenerar.Name = "btnGenerar";
			this.btnGenerar.Size = new System.Drawing.Size(139, 23);
			this.btnGenerar.TabIndex = 18;
			this.btnGenerar.Text = "Generar Archivo ISP";
			this.btnGenerar.UseVisualStyleBackColor = true;
			this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
			// 
			// FrmInformeDetalleISPAnual
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(980, 578);
			this.Controls.Add(this.btnGenerar);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.btn_Cerrar);
			this.Controls.Add(this.btn_Guardar);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.grpInformacion);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(776, 464);
			this.Name = "FrmInformeDetalleISPAnual";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Informe  detalle ISP anual";
			this.Load += new System.EventHandler(this.FrmInformeDetalleISPAnual_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.grpInformacion.ResumeLayout(false);
			this.pnl_Progreso.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpInformacion;
		private System.Windows.Forms.DataGridView grdDatos;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ComboBox cbx_anno;
		private System.Windows.Forms.Label lbl_nombreCliente;
		private System.Windows.Forms.Button btn_cargar;
		private System.Windows.Forms.Button btn_Guardar;
		private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_filtro;
        private System.Windows.Forms.GroupBox pnl_Progreso;
        private System.Windows.Forms.ProgressBar pgb_Barra;
        private System.Windows.Forms.Label lbl_Rut;
        private System.Windows.Forms.Button btn_CargarCli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.FolderBrowserDialog dbd_Archivo;
		private System.Windows.Forms.Label lbl_Original;
		private System.Windows.Forms.RadioButton rbtAlternativa;
		private System.Windows.Forms.RadioButton rbtOiginal;
		private System.Windows.Forms.Label lbl_Alternativa;
		private System.Windows.Forms.Button btnGenerar;
		private System.Windows.Forms.ComboBox cbxSucursal;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_IdCliente;
		private System.Windows.Forms.Label lbl_run;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colGenerar;
		private System.Windows.Forms.DataGridViewTextBoxColumn Rut;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
		private System.Windows.Forms.DataGridViewTextBoxColumn Paterno;
		private System.Windows.Forms.DataGridViewTextBoxColumn Maternos;
		private System.Windows.Forms.DataGridViewTextBoxColumn col1ertri;
		private System.Windows.Forms.DataGridViewTextBoxColumn col2dotri;
		private System.Windows.Forms.DataGridViewTextBoxColumn col3ertri;
		private System.Windows.Forms.DataGridViewTextBoxColumn col4totri;
	}
}