namespace ControlDosimetro
{
    partial class frmBusquedaUsuario
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
            this.cbx_id_estado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Filtro = new System.Windows.Forms.Button();
            this.btn_cargarusuario = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_Agregar = new System.Windows.Forms.ToolStripButton();
            this.Id_Personal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maternos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbx_Id_perfil = new System.Windows.Forms.ComboBox();
            this.lbl_Id_perfil = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_Id_perfil);
            this.groupBox1.Controls.Add(this.lbl_Id_perfil);
            this.groupBox1.Controls.Add(this.cbx_id_estado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Filtro);
            this.groupBox1.Controls.Add(this.btn_cargarusuario);
            this.groupBox1.Location = new System.Drawing.Point(0, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(849, 144);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dato Usuario";
            // 
            // cbx_id_estado
            // 
            this.cbx_id_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_id_estado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbx_id_estado.FormattingEnabled = true;
            this.cbx_id_estado.Location = new System.Drawing.Point(70, 22);
            this.cbx_id_estado.Name = "cbx_id_estado";
            this.cbx_id_estado.Size = new System.Drawing.Size(121, 21);
            this.cbx_id_estado.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Estado";
            // 
            // btn_Filtro
            // 
            this.btn_Filtro.Image = global::ControlDosimetro.Properties.Resources.Limpiar;
            this.btn_Filtro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Filtro.Location = new System.Drawing.Point(209, 96);
            this.btn_Filtro.Name = "btn_Filtro";
            this.btn_Filtro.Size = new System.Drawing.Size(122, 39);
            this.btn_Filtro.TabIndex = 35;
            this.btn_Filtro.Text = "Limpiar Filtro";
            this.btn_Filtro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Filtro.UseVisualStyleBackColor = true;
            this.btn_Filtro.Click += new System.EventHandler(this.btn_Filtro_Click);
            // 
            // btn_cargarusuario
            // 
            this.btn_cargarusuario.Image = global::ControlDosimetro.Properties.Resources.Buscar;
            this.btn_cargarusuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cargarusuario.Location = new System.Drawing.Point(39, 95);
            this.btn_cargarusuario.Name = "btn_cargarusuario";
            this.btn_cargarusuario.Size = new System.Drawing.Size(111, 40);
            this.btn_cargarusuario.TabIndex = 3;
            this.btn_cargarusuario.Text = "Busqueda";
            this.btn_cargarusuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cargarusuario.UseVisualStyleBackColor = true;
            this.btn_cargarusuario.Click += new System.EventHandler(this.btn_cargarusuario_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.grdDatos);
            this.groupBox2.Location = new System.Drawing.Point(5, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(842, 354);
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
            this.Rut,
            this.Nombres,
            this.Paterno,
            this.Maternos,
            this.Id_estado});
            this.grdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDatos.Location = new System.Drawing.Point(3, 16);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(836, 335);
            this.grdDatos.TabIndex = 5;
            this.grdDatos.DoubleClick += new System.EventHandler(this.grdDatos_DoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Agregar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(859, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_Agregar
            // 
            this.tsb_Agregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Agregar.Image = global::ControlDosimetro.Properties.Resources.Agregar;
            this.tsb_Agregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Agregar.Name = "tsb_Agregar";
            this.tsb_Agregar.Size = new System.Drawing.Size(23, 22);
            this.tsb_Agregar.Text = "toolStripButton1";
            this.tsb_Agregar.ToolTipText = "Agregar Personal";
            this.tsb_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // Id_Personal
            // 
            this.Id_Personal.DataPropertyName = "Id_Usuario";
            this.Id_Personal.Frozen = true;
            this.Id_Personal.HeaderText = "Id_Usuario";
            this.Id_Personal.Name = "Id_Personal";
            this.Id_Personal.ReadOnly = true;
            this.Id_Personal.Visible = false;
            this.Id_Personal.Width = 83;
            // 
            // Rut
            // 
            this.Rut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Rut.DataPropertyName = "Usuario";
            this.Rut.HeaderText = "Usuario";
            this.Rut.Name = "Rut";
            this.Rut.ReadOnly = true;
            this.Rut.Width = 68;
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
            // Id_estado
            // 
            this.Id_estado.DataPropertyName = "Descripcion";
            this.Id_estado.HeaderText = "Perfil";
            this.Id_estado.Name = "Id_estado";
            this.Id_estado.ReadOnly = true;
            this.Id_estado.Width = 55;
            // 
            // cbx_Id_perfil
            // 
            this.cbx_Id_perfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Id_perfil.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbx_Id_perfil.FormattingEnabled = true;
            this.cbx_Id_perfil.Location = new System.Drawing.Point(70, 52);
            this.cbx_Id_perfil.Name = "cbx_Id_perfil";
            this.cbx_Id_perfil.Size = new System.Drawing.Size(166, 21);
            this.cbx_Id_perfil.TabIndex = 55;
            this.cbx_Id_perfil.TabStop = false;
            // 
            // lbl_Id_perfil
            // 
            this.lbl_Id_perfil.AutoSize = true;
            this.lbl_Id_perfil.Location = new System.Drawing.Point(12, 55);
            this.lbl_Id_perfil.Name = "lbl_Id_perfil";
            this.lbl_Id_perfil.Size = new System.Drawing.Size(30, 13);
            this.lbl_Id_perfil.TabIndex = 54;
            this.lbl_Id_perfil.Text = "Perfil";
            // 
            // frmBusquedaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 532);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(776, 464);
            this.Name = "frmBusquedaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda Usuario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
		  private System.Windows.Forms.DataGridView grdDatos;
          private System.Windows.Forms.ToolStrip toolStrip1;
								private System.Windows.Forms.Button btn_cargarusuario;
                                private System.Windows.Forms.Button btn_Filtro;
                                private System.Windows.Forms.ToolStripButton tsb_Agregar;
                                private System.Windows.Forms.ComboBox cbx_id_estado;
                                private System.Windows.Forms.Label label1;
                                private System.Windows.Forms.DataGridViewTextBoxColumn Id_Personal;
                                private System.Windows.Forms.DataGridViewTextBoxColumn Rut;
                                private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
                                private System.Windows.Forms.DataGridViewTextBoxColumn Paterno;
                                private System.Windows.Forms.DataGridViewTextBoxColumn Maternos;
                                private System.Windows.Forms.DataGridViewTextBoxColumn Id_estado;
                                private System.Windows.Forms.ComboBox cbx_Id_perfil;
                                private System.Windows.Forms.Label lbl_Id_perfil;
    }
}