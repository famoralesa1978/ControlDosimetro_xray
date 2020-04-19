namespace ControlDosimetro
{
    partial class FrmFacturacion
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCargarCliente = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_CodCliente = new System.Windows.Forms.TextBox();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_nombreCliente = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_periodo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_anno = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_estadodosimetro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N_Pelicula = new GridExtension.IntegerGridColumn();
            this.N_Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAccionFactura = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Facturación";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAccionFactura);
            this.groupBox1.Controls.Add(this.btnCargarCliente);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_CodCliente);
            this.groupBox1.Controls.Add(this.lbl_Direccion);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbl_nombreCliente);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbx_periodo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbx_anno);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(26, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 285);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carga de Documento";
            // 
            // btnCargarCliente
            // 
            this.btnCargarCliente.Location = new System.Drawing.Point(169, 139);
            this.btnCargarCliente.Name = "btnCargarCliente";
            this.btnCargarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnCargarCliente.TabIndex = 52;
            this.btnCargarCliente.Text = "Cargar";
            this.btnCargarCliente.UseVisualStyleBackColor = true;
            this.btnCargarCliente.Click += new System.EventHandler(this.BtnCargarCliente_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Nombre Cliente";
            // 
            // txt_CodCliente
            // 
            this.txt_CodCliente.Location = new System.Drawing.Point(169, 35);
            this.txt_CodCliente.Name = "txt_CodCliente";
            this.txt_CodCliente.Size = new System.Drawing.Size(53, 20);
            this.txt_CodCliente.TabIndex = 50;
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.Location = new System.Drawing.Point(166, 212);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(242, 13);
            this.lbl_Direccion.TabIndex = 49;
            this.lbl_Direccion.Text = "label1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Dirección";
            // 
            // lbl_nombreCliente
            // 
            this.lbl_nombreCliente.Location = new System.Drawing.Point(166, 189);
            this.lbl_nombreCliente.Name = "lbl_nombreCliente";
            this.lbl_nombreCliente.Size = new System.Drawing.Size(239, 23);
            this.lbl_nombreCliente.TabIndex = 47;
            this.lbl_nombreCliente.Text = "label1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "N°  Cliente";
            // 
            // cbx_periodo
            // 
            this.cbx_periodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_periodo.FormattingEnabled = true;
            this.cbx_periodo.Location = new System.Drawing.Point(169, 95);
            this.cbx_periodo.Name = "cbx_periodo";
            this.cbx_periodo.Size = new System.Drawing.Size(121, 21);
            this.cbx_periodo.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Período";
            // 
            // cbx_anno
            // 
            this.cbx_anno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_anno.FormattingEnabled = true;
            this.cbx_anno.Location = new System.Drawing.Point(169, 65);
            this.cbx_anno.Name = "cbx_anno";
            this.cbx_anno.Size = new System.Drawing.Size(121, 21);
            this.cbx_anno.TabIndex = 37;
            this.cbx_anno.SelectedIndexChanged += new System.EventHandler(this.Cbx_anno_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Año";
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
            this.id,
            this.id_estadodosimetro,
            this.N_Pelicula,
            this.N_Documento,
            this.Descripcion,
            this.Marca});
            this.grdDatos.Location = new System.Drawing.Point(26, 329);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdDatos.Size = new System.Drawing.Size(705, 267);
            this.grdDatos.TabIndex = 11;
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
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.Width = 62;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 623);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Conteos por estado según grilla";
            // 
            // btnAccionFactura
            // 
            this.btnAccionFactura.Location = new System.Drawing.Point(29, 256);
            this.btnAccionFactura.Name = "btnAccionFactura";
            this.btnAccionFactura.Size = new System.Drawing.Size(374, 23);
            this.btnAccionFactura.TabIndex = 53;
            this.btnAccionFactura.Text = "Ver o Cargar archivo";
            this.btnAccionFactura.UseVisualStyleBackColor = true;
            this.btnAccionFactura.Click += new System.EventHandler(this.BtnAccionFactura_Click);
            // 
            // frmCargarDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 666);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.grdDatos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCargarDocumentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturación Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbx_periodo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_anno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_nombreCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_CodCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.Button btnCargarCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_estadodosimetro;
        private GridExtension.IntegerGridColumn N_Pelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn N_Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.Button btnAccionFactura;
    }
}

