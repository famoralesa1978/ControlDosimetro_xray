namespace ControlDosimetro
{
    partial class frmOrdenTrabajoPorDocumento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_NCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_marcar = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_FechaRecepcion = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.pnl_Progreso = new System.Windows.Forms.GroupBox();
            this.pgb_Barra = new System.Windows.Forms.ProgressBar();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.run = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Razon_Social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N_Dosimetro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FechaOrdenTrabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.pnl_Progreso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btn_Buscar);
            this.groupBox2.Controls.Add(this.txt_NCliente);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.chk_marcar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtp_FechaRecepcion);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.pnl_Progreso);
            this.groupBox2.Controls.Add(this.grdDatos);
            this.groupBox2.Location = new System.Drawing.Point(5, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(836, 453);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Image = global::ControlDosimetro.Properties.Resources.Buscar;
            this.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Buscar.Location = new System.Drawing.Point(207, 15);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(104, 41);
            this.btn_Buscar.TabIndex = 2;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // txt_NCliente
            // 
            this.txt_NCliente.Location = new System.Drawing.Point(92, 26);
            this.txt_NCliente.MaxLength = 10;
            this.txt_NCliente.Name = "txt_NCliente";
            this.txt_NCliente.Size = new System.Drawing.Size(109, 20);
            this.txt_NCliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "N° Cliente";
            // 
            // chk_marcar
            // 
            this.chk_marcar.AutoSize = true;
            this.chk_marcar.Location = new System.Drawing.Point(662, 29);
            this.chk_marcar.Name = "chk_marcar";
            this.chk_marcar.Size = new System.Drawing.Size(15, 14);
            this.chk_marcar.TabIndex = 3;
            this.chk_marcar.UseVisualStyleBackColor = true;
            this.chk_marcar.CheckedChanged += new System.EventHandler(this.chk_marcar_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(588, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Marcar Todo";
            // 
            // dtp_FechaRecepcion
            // 
            this.dtp_FechaRecepcion.CustomFormat = "dd/MM/yyyy";
            this.dtp_FechaRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_FechaRecepcion.Location = new System.Drawing.Point(430, 21);
            this.dtp_FechaRecepcion.Name = "dtp_FechaRecepcion";
            this.dtp_FechaRecepcion.Size = new System.Drawing.Size(98, 20);
            this.dtp_FechaRecepcion.TabIndex = 2;
            this.dtp_FechaRecepcion.Value = new System.DateTime(2018, 1, 7, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fecha Orden Trabajo";
            // 
            // pnl_Progreso
            // 
            this.pnl_Progreso.Controls.Add(this.pgb_Barra);
            this.pnl_Progreso.Location = new System.Drawing.Point(54, 89);
            this.pnl_Progreso.Name = "pnl_Progreso";
            this.pnl_Progreso.Size = new System.Drawing.Size(338, 118);
            this.pnl_Progreso.TabIndex = 10;
            this.pnl_Progreso.TabStop = false;
            this.pnl_Progreso.Text = "Progreso de Grabado";
            // 
            // pgb_Barra
            // 
            this.pgb_Barra.Location = new System.Drawing.Point(21, 43);
            this.pgb_Barra.Name = "pgb_Barra";
            this.pgb_Barra.Size = new System.Drawing.Size(311, 23);
            this.pgb_Barra.TabIndex = 0;
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.AllowUserToDeleteRows = false;
            this.grdDatos.AllowUserToResizeColumns = false;
            this.grdDatos.AllowUserToResizeRows = false;
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cliente,
            this.run,
            this.Razon_Social,
            this.periodo,
            this.N_Dosimetro,
            this.id,
            this.marca,
            this.FechaOrdenTrabajo});
            this.grdDatos.Location = new System.Drawing.Point(3, 62);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdDatos.Size = new System.Drawing.Size(827, 391);
            this.grdDatos.TabIndex = 8;
            this.grdDatos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdDatos_CellFormatting);
            this.grdDatos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDatos_CellValueChanged);
            this.grdDatos.CurrentCellDirtyStateChanged += new System.EventHandler(this.grdDatos_CurrentCellDirtyStateChanged);
            // 
            // id_cliente
            // 
            this.id_cliente.DataPropertyName = "id_cliente";
            this.id_cliente.HeaderText = "N° Cliente";
            this.id_cliente.Name = "id_cliente";
            this.id_cliente.Width = 79;
            // 
            // run
            // 
            this.run.DataPropertyName = "run";
            this.run.FillWeight = 150F;
            this.run.HeaderText = "Rut";
            this.run.Name = "run";
            this.run.Width = 49;
            // 
            // Razon_Social
            // 
            this.Razon_Social.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Razon_Social.DataPropertyName = "Razon_Social";
            this.Razon_Social.HeaderText = "Razón social";
            this.Razon_Social.Name = "Razon_Social";
            this.Razon_Social.ReadOnly = true;
            this.Razon_Social.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // periodo
            // 
            this.periodo.DataPropertyName = "periodo";
            this.periodo.FillWeight = 150F;
            this.periodo.HeaderText = "período";
            this.periodo.Name = "periodo";
            this.periodo.ReadOnly = true;
            this.periodo.Width = 69;
            // 
            // N_Dosimetro
            // 
            this.N_Dosimetro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.N_Dosimetro.DataPropertyName = "N_Dosimetro";
            this.N_Dosimetro.HeaderText = "Dosimetros";
            this.N_Dosimetro.Name = "N_Dosimetro";
            this.N_Dosimetro.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 40;
            // 
            // marca
            // 
            this.marca.DataPropertyName = "Marca";
            this.marca.FalseValue = "0";
            this.marca.HeaderText = "Generar";
            this.marca.IndeterminateValue = "0";
            this.marca.Name = "marca";
            this.marca.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.marca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.marca.TrueValue = "1";
            this.marca.Width = 70;
            // 
            // FechaOrdenTrabajo
            // 
            this.FechaOrdenTrabajo.DataPropertyName = "FechaOrdenTrabajo";
            this.FechaOrdenTrabajo.HeaderText = "Fecha Orden Trabajo";
            this.FechaOrdenTrabajo.Name = "FechaOrdenTrabajo";
            this.FechaOrdenTrabajo.ReadOnly = true;
            this.FechaOrdenTrabajo.Width = 133;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(841, 25);
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
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Cerrar.Location = new System.Drawing.Point(500, 532);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cerrar.TabIndex = 10;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click_1);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Guardar.Location = new System.Drawing.Point(188, 532);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(149, 23);
            this.btn_Guardar.TabIndex = 9;
            this.btn_Guardar.Text = "Generar Orden de Trabajo";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // frmOrdenTrabajoPorDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 565);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOrdenTrabajoPorDocumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orden de Trabajo Por Documento";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnl_Progreso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
		  private System.Windows.Forms.DataGridView grdDatos;
          private System.Windows.Forms.ToolStrip toolStrip1;
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
                                private System.Windows.Forms.Button btn_Cerrar;
                                private System.Windows.Forms.Button btn_Guardar;
                                private System.Windows.Forms.DateTimePicker dtp_FechaRecepcion;
                                private System.Windows.Forms.Label label6;
                                private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
                                private System.Windows.Forms.DataGridViewTextBoxColumn run;
                                private System.Windows.Forms.DataGridViewTextBoxColumn Razon_Social;
                                private System.Windows.Forms.DataGridViewTextBoxColumn periodo;
                                private System.Windows.Forms.DataGridViewTextBoxColumn N_Dosimetro;
                                private System.Windows.Forms.DataGridViewTextBoxColumn id;
                                private System.Windows.Forms.DataGridViewCheckBoxColumn marca;
                                private System.Windows.Forms.DataGridViewTextBoxColumn FechaOrdenTrabajo;
                                private System.Windows.Forms.CheckBox chk_marcar;
                                private System.Windows.Forms.Label label5;
                                private System.Windows.Forms.Button btn_Buscar;
                                private System.Windows.Forms.TextBox txt_NCliente;
                                private System.Windows.Forms.Label label1;
    }
}