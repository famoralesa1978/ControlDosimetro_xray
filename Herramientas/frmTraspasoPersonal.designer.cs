namespace ControlDosimetro
{
    partial class frmTraspasoPersonal
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_Traspaso = new System.Windows.Forms.Button();
			this.dtgOrigen = new System.Windows.Forms.DataGridView();
			this.ColRut = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lbl_Id_cliente = new System.Windows.Forms.Label();
			this.lbl_cliente = new System.Windows.Forms.Label();
			this.lbl_RazonSocial = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.btn_Cargar_cliente = new System.Windows.Forms.Button();
			this.txt_Rut = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dtgDestino = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lbl_Id_clienteDestino = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lbl_RazonSocialDestino = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btn_Cargar_clienteDestino = new System.Windows.Forms.Button();
			this.txt_RutDestino = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgOrigen)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgDestino)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
			this.splitContainer1.Size = new System.Drawing.Size(877, 409);
			this.splitContainer1.SplitterDistance = 400;
			this.splitContainer1.TabIndex = 4;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_Traspaso);
			this.groupBox1.Controls.Add(this.dtgOrigen);
			this.groupBox1.Controls.Add(this.lbl_Id_cliente);
			this.groupBox1.Controls.Add(this.lbl_cliente);
			this.groupBox1.Controls.Add(this.lbl_RazonSocial);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.btn_Cargar_cliente);
			this.groupBox1.Controls.Add(this.txt_Rut);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(400, 409);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			// 
			// btn_Traspaso
			// 
			this.btn_Traspaso.Location = new System.Drawing.Point(127, 369);
			this.btn_Traspaso.Name = "btn_Traspaso";
			this.btn_Traspaso.Size = new System.Drawing.Size(75, 23);
			this.btn_Traspaso.TabIndex = 53;
			this.btn_Traspaso.Text = "Traspaso";
			this.btn_Traspaso.UseVisualStyleBackColor = true;
			this.btn_Traspaso.Click += new System.EventHandler(this.btn_Traspaso_Click);
			// 
			// dtgOrigen
			// 
			this.dtgOrigen.AllowUserToAddRows = false;
			this.dtgOrigen.AllowUserToDeleteRows = false;
			this.dtgOrigen.AllowUserToResizeColumns = false;
			this.dtgOrigen.AllowUserToResizeRows = false;
			this.dtgOrigen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgOrigen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColRut,
            this.ColNombre});
			this.dtgOrigen.Location = new System.Drawing.Point(13, 100);
			this.dtgOrigen.Name = "dtgOrigen";
			this.dtgOrigen.ReadOnly = true;
			this.dtgOrigen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtgOrigen.Size = new System.Drawing.Size(364, 248);
			this.dtgOrigen.TabIndex = 52;
			// 
			// ColRut
			// 
			this.ColRut.DataPropertyName = "Rut";
			this.ColRut.HeaderText = "Rut";
			this.ColRut.Name = "ColRut";
			this.ColRut.ReadOnly = true;
			this.ColRut.Width = 80;
			// 
			// ColNombre
			// 
			this.ColNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ColNombre.DataPropertyName = "NombreCompleto";
			this.ColNombre.HeaderText = "Personal";
			this.ColNombre.Name = "ColNombre";
			this.ColNombre.ReadOnly = true;
			// 
			// lbl_Id_cliente
			// 
			this.lbl_Id_cliente.AutoSize = true;
			this.lbl_Id_cliente.Location = new System.Drawing.Point(88, 72);
			this.lbl_Id_cliente.Name = "lbl_Id_cliente";
			this.lbl_Id_cliente.Size = new System.Drawing.Size(69, 13);
			this.lbl_Id_cliente.TabIndex = 51;
			this.lbl_Id_cliente.Text = "lbl_Id_cliente";
			// 
			// lbl_cliente
			// 
			this.lbl_cliente.AutoSize = true;
			this.lbl_cliente.Location = new System.Drawing.Point(10, 72);
			this.lbl_cliente.Name = "lbl_cliente";
			this.lbl_cliente.Size = new System.Drawing.Size(54, 13);
			this.lbl_cliente.TabIndex = 50;
			this.lbl_cliente.Text = "N° Cliente";
			// 
			// lbl_RazonSocial
			// 
			this.lbl_RazonSocial.AutoSize = true;
			this.lbl_RazonSocial.Location = new System.Drawing.Point(88, 49);
			this.lbl_RazonSocial.Name = "lbl_RazonSocial";
			this.lbl_RazonSocial.Size = new System.Drawing.Size(83, 13);
			this.lbl_RazonSocial.TabIndex = 49;
			this.lbl_RazonSocial.Text = "lbl_RazonSocial";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(10, 24);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(24, 13);
			this.label11.TabIndex = 48;
			this.label11.Text = "Rut";
			// 
			// btn_Cargar_cliente
			// 
			this.btn_Cargar_cliente.Location = new System.Drawing.Point(206, 19);
			this.btn_Cargar_cliente.Name = "btn_Cargar_cliente";
			this.btn_Cargar_cliente.Size = new System.Drawing.Size(119, 23);
			this.btn_Cargar_cliente.TabIndex = 47;
			this.btn_Cargar_cliente.Text = "Cargar Cliente";
			this.btn_Cargar_cliente.UseVisualStyleBackColor = true;
			this.btn_Cargar_cliente.Click += new System.EventHandler(this.btn_Cargar_cliente_Click);
			// 
			// txt_Rut
			// 
			this.txt_Rut.Location = new System.Drawing.Point(91, 21);
			this.txt_Rut.Name = "txt_Rut";
			this.txt_Rut.Size = new System.Drawing.Size(112, 20);
			this.txt_Rut.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 13);
			this.label2.TabIndex = 34;
			this.label2.Text = "Razon social";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dtgDestino);
			this.groupBox2.Controls.Add(this.lbl_Id_clienteDestino);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.lbl_RazonSocialDestino);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.btn_Cargar_clienteDestino);
			this.groupBox2.Controls.Add(this.txt_RutDestino);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(0, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(473, 409);
			this.groupBox2.TabIndex = 47;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Datos personal destino";
			// 
			// dtgDestino
			// 
			this.dtgDestino.AllowUserToAddRows = false;
			this.dtgDestino.AllowUserToDeleteRows = false;
			this.dtgDestino.AllowUserToResizeColumns = false;
			this.dtgDestino.AllowUserToResizeRows = false;
			this.dtgDestino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgDestino.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
			this.dtgDestino.Location = new System.Drawing.Point(14, 100);
			this.dtgDestino.Name = "dtgDestino";
			this.dtgDestino.ReadOnly = true;
			this.dtgDestino.Size = new System.Drawing.Size(466, 248);
			this.dtgDestino.TabIndex = 59;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Rut";
			this.dataGridViewTextBoxColumn1.HeaderText = "Rut";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Width = 80;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn2.DataPropertyName = "NombreCompleto";
			this.dataGridViewTextBoxColumn2.HeaderText = "Personal";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// lbl_Id_clienteDestino
			// 
			this.lbl_Id_clienteDestino.AutoSize = true;
			this.lbl_Id_clienteDestino.Location = new System.Drawing.Point(89, 70);
			this.lbl_Id_clienteDestino.Name = "lbl_Id_clienteDestino";
			this.lbl_Id_clienteDestino.Size = new System.Drawing.Size(35, 13);
			this.lbl_Id_clienteDestino.TabIndex = 58;
			this.lbl_Id_clienteDestino.Text = "label1";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 70);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 13);
			this.label3.TabIndex = 57;
			this.label3.Text = "N° Cliente";
			// 
			// lbl_RazonSocialDestino
			// 
			this.lbl_RazonSocialDestino.AutoSize = true;
			this.lbl_RazonSocialDestino.Location = new System.Drawing.Point(89, 47);
			this.lbl_RazonSocialDestino.Name = "lbl_RazonSocialDestino";
			this.lbl_RazonSocialDestino.Size = new System.Drawing.Size(35, 13);
			this.lbl_RazonSocialDestino.TabIndex = 56;
			this.lbl_RazonSocialDestino.Text = "label4";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(11, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(24, 13);
			this.label5.TabIndex = 55;
			this.label5.Text = "Rut";
			// 
			// btn_Cargar_clienteDestino
			// 
			this.btn_Cargar_clienteDestino.Location = new System.Drawing.Point(207, 17);
			this.btn_Cargar_clienteDestino.Name = "btn_Cargar_clienteDestino";
			this.btn_Cargar_clienteDestino.Size = new System.Drawing.Size(119, 23);
			this.btn_Cargar_clienteDestino.TabIndex = 54;
			this.btn_Cargar_clienteDestino.Text = "Cargar Cliente";
			this.btn_Cargar_clienteDestino.UseVisualStyleBackColor = true;
			this.btn_Cargar_clienteDestino.Click += new System.EventHandler(this.btn_Cargar_cliente_Click);
			// 
			// txt_RutDestino
			// 
			this.txt_RutDestino.Location = new System.Drawing.Point(92, 19);
			this.txt_RutDestino.Name = "txt_RutDestino";
			this.txt_RutDestino.Size = new System.Drawing.Size(112, 20);
			this.txt_RutDestino.TabIndex = 52;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(11, 47);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 13);
			this.label6.TabIndex = 53;
			this.label6.Text = "Razon social";
			// 
			// frmTraspasoPersonal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(877, 409);
			this.Controls.Add(this.splitContainer1);
			this.Name = "frmTraspasoPersonal";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Traspaso";
			this.Load += new System.EventHandler(this.frmTraspasoPersonal_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgOrigen)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgDestino)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Cargar_cliente;
        private System.Windows.Forms.TextBox txt_Rut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.Label lbl_RazonSocial;
        private System.Windows.Forms.Label lbl_Id_cliente;
        private System.Windows.Forms.Label lbl_Id_clienteDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_RazonSocialDestino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Cargar_clienteDestino;
        private System.Windows.Forms.TextBox txt_RutDestino;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRut;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridView dtgDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btn_Traspaso;
    }
}