namespace ControlDosimetro
{
	partial class frmAyudaCliente
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
			this.btn_Filtro = new System.Windows.Forms.Button();
			this.btn_cargarCliente = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_IdCliente = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.grdDatos = new System.Windows.Forms.DataGridView();
			this.Rut = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Razon_Social = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_Filtro);
			this.groupBox1.Controls.Add(this.btn_cargarCliente);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txt_IdCliente);
			this.groupBox1.Location = new System.Drawing.Point(0, 28);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(849, 144);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dato Cliente";
			// 
			// btn_Filtro
			// 
			this.btn_Filtro.Image = global::ControlDosimetro.Properties.Resources.Limpiar;
			this.btn_Filtro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Filtro.Location = new System.Drawing.Point(209, 48);
			this.btn_Filtro.Name = "btn_Filtro";
			this.btn_Filtro.Size = new System.Drawing.Size(122, 39);
			this.btn_Filtro.TabIndex = 35;
			this.btn_Filtro.Text = "Limpiar Filtro";
			this.btn_Filtro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_Filtro.UseVisualStyleBackColor = true;
			this.btn_Filtro.Click += new System.EventHandler(this.btn_Filtro_Click);
			// 
			// btn_cargarCliente
			// 
			this.btn_cargarCliente.Image = global::ControlDosimetro.Properties.Resources.Buscar;
			this.btn_cargarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_cargarCliente.Location = new System.Drawing.Point(39, 47);
			this.btn_cargarCliente.Name = "btn_cargarCliente";
			this.btn_cargarCliente.Size = new System.Drawing.Size(111, 40);
			this.btn_cargarCliente.TabIndex = 3;
			this.btn_cargarCliente.Text = "Busqueda";
			this.btn_cargarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_cargarCliente.UseVisualStyleBackColor = true;
			this.btn_cargarCliente.Click += new System.EventHandler(this.btn_cargarCliente_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 34;
			this.label2.Text = "N°  Cliente";
			// 
			// txt_IdCliente
			// 
			this.txt_IdCliente.Location = new System.Drawing.Point(94, 19);
			this.txt_IdCliente.MaxLength = 10;
			this.txt_IdCliente.Name = "txt_IdCliente";
			this.txt_IdCliente.Size = new System.Drawing.Size(100, 20);
			this.txt_IdCliente.TabIndex = 2;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.grdDatos);
			this.groupBox2.Location = new System.Drawing.Point(5, 135);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(743, 397);
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
            this.Rut,
            this.Razon_Social,
            this.Direccion});
			this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdDatos.Location = new System.Drawing.Point(3, 16);
			this.grdDatos.MultiSelect = false;
			this.grdDatos.Name = "grdDatos";
			this.grdDatos.ReadOnly = true;
			this.grdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
			this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdDatos.Size = new System.Drawing.Size(737, 378);
			this.grdDatos.TabIndex = 5;
			this.grdDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_CellDoubleClick);
			this.grdDatos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grdDatos_DataBindingComplete);
			// 
			// Rut
			// 
			this.Rut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.Rut.DataPropertyName = "run";
			this.Rut.HeaderText = "Rut";
			this.Rut.Name = "Rut";
			this.Rut.ReadOnly = true;
			this.Rut.Width = 49;
			// 
			// Razon_Social
			// 
			this.Razon_Social.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Razon_Social.DataPropertyName = "Razon_Social";
			this.Razon_Social.HeaderText = "Nombres";
			this.Razon_Social.Name = "Razon_Social";
			this.Razon_Social.ReadOnly = true;
			this.Razon_Social.Width = 200;
			// 
			// Direccion
			// 
			this.Direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Direccion.DataPropertyName = "Direccion";
			this.Direccion.FillWeight = 300F;
			this.Direccion.HeaderText = "Dirección";
			this.Direccion.Name = "Direccion";
			this.Direccion.ReadOnly = true;
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(760, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// frmAyudaCliente
			// 
			this.AcceptButton = this.btn_cargarCliente;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(760, 532);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(776, 462);
			this.Name = "frmAyudaCliente";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Busqueda cliente";
			this.Load += new System.EventHandler(this.frmAyudaCliente_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_IdCliente;
        private System.Windows.Forms.GroupBox groupBox2;
		  private System.Windows.Forms.DataGridView grdDatos;
		  private System.Windows.Forms.ToolStrip toolStrip1;
								private System.Windows.Forms.Label label2;
								private System.Windows.Forms.Button btn_cargarCliente;
                                private System.Windows.Forms.Button btn_Filtro;
		private System.Windows.Forms.DataGridViewTextBoxColumn Rut;
		private System.Windows.Forms.DataGridViewTextBoxColumn Razon_Social;
		private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
	}
}