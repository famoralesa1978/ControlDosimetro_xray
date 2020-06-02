namespace ControlDosimetro
{
    partial class frmParametro
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_Agregar = new System.Windows.Forms.Button();
			this.cbx_EstadoId = new System.Windows.Forms.ComboBox();
			this.btn_Buscar = new System.Windows.Forms.Button();
			this.cbx_Estado = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.grdDatos = new System.Windows.Forms.DataGridView();
			this.Id_Parametro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tsParametro = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
			this.tsParametro.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_Agregar);
			this.groupBox1.Controls.Add(this.cbx_EstadoId);
			this.groupBox1.Controls.Add(this.btn_Buscar);
			this.groupBox1.Controls.Add(this.cbx_Estado);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(3, 35);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(495, 72);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Busqueda";
			// 
			// btn_Agregar
			// 
			this.btn_Agregar.Location = new System.Drawing.Point(166, 41);
			this.btn_Agregar.Name = "btn_Agregar";
			this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
			this.btn_Agregar.TabIndex = 3;
			this.btn_Agregar.Text = "Agregar";
			this.btn_Agregar.UseVisualStyleBackColor = true;
			this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
			// 
			// cbx_EstadoId
			// 
			this.cbx_EstadoId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_EstadoId.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbx_EstadoId.FormattingEnabled = true;
			this.cbx_EstadoId.Location = new System.Drawing.Point(192, 11);
			this.cbx_EstadoId.Name = "cbx_EstadoId";
			this.cbx_EstadoId.Size = new System.Drawing.Size(121, 21);
			this.cbx_EstadoId.TabIndex = 2;
			this.cbx_EstadoId.Visible = false;
			// 
			// btn_Buscar
			// 
			this.btn_Buscar.Location = new System.Drawing.Point(65, 41);
			this.btn_Buscar.Name = "btn_Buscar";
			this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
			this.btn_Buscar.TabIndex = 2;
			this.btn_Buscar.Text = "Buscar";
			this.btn_Buscar.UseVisualStyleBackColor = true;
			this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
			// 
			// cbx_Estado
			// 
			this.cbx_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_Estado.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbx_Estado.FormattingEnabled = true;
			this.cbx_Estado.Location = new System.Drawing.Point(65, 11);
			this.cbx_Estado.Name = "cbx_Estado";
			this.cbx_Estado.Size = new System.Drawing.Size(121, 21);
			this.cbx_Estado.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Estado";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.grdDatos);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.groupBox2.Location = new System.Drawing.Point(0, 113);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(501, 241);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Lista";
			// 
			// grdDatos
			// 
			this.grdDatos.AllowUserToAddRows = false;
			this.grdDatos.AllowUserToDeleteRows = false;
			this.grdDatos.AllowUserToResizeColumns = false;
			this.grdDatos.AllowUserToResizeRows = false;
			this.grdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.grdDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.grdDatos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Parametro,
            this.Descripcion,
            this.Orden});
			this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdDatos.Location = new System.Drawing.Point(3, 16);
			this.grdDatos.MultiSelect = false;
			this.grdDatos.Name = "grdDatos";
			this.grdDatos.ReadOnly = true;
			this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdDatos.Size = new System.Drawing.Size(495, 222);
			this.grdDatos.TabIndex = 1;
			this.grdDatos.DoubleClick += new System.EventHandler(this.grdDatos_DoubleClick);
			// 
			// Id_Parametro
			// 
			this.Id_Parametro.DataPropertyName = "Id_parametro";
			this.Id_Parametro.Frozen = true;
			this.Id_Parametro.HeaderText = "Id";
			this.Id_Parametro.Name = "Id_Parametro";
			this.Id_Parametro.ReadOnly = true;
			this.Id_Parametro.Width = 41;
			// 
			// Descripcion
			// 
			this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Descripcion.DataPropertyName = "Descripcion";
			this.Descripcion.HeaderText = "Descripción";
			this.Descripcion.Name = "Descripcion";
			this.Descripcion.ReadOnly = true;
			// 
			// Orden
			// 
			this.Orden.DataPropertyName = "orden";
			this.Orden.HeaderText = "Orden";
			this.Orden.Name = "Orden";
			this.Orden.ReadOnly = true;
			this.Orden.Width = 61;
			// 
			// tsParametro
			// 
			this.tsParametro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
			this.tsParametro.Location = new System.Drawing.Point(0, 0);
			this.tsParametro.Name = "tsParametro";
			this.tsParametro.Size = new System.Drawing.Size(501, 25);
			this.tsParametro.TabIndex = 2;
			this.tsParametro.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = global::ControlDosimetro.Properties.Resources.Detalle;
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Text = "tsParametroDetalle";
			this.toolStripButton1.ToolTipText = "Detalle";
			// 
			// frmParametro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(501, 354);
			this.Controls.Add(this.tsParametro);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(517, 392);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(517, 392);
			this.Name = "frmParametro";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Configuración de Parametro";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
			this.tsParametro.ResumeLayout(false);
			this.tsParametro.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.ComboBox cbx_Estado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbx_EstadoId;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Parametro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orden;
        private System.Windows.Forms.Button btn_Agregar;
								private System.Windows.Forms.ToolStrip tsParametro;
								private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

