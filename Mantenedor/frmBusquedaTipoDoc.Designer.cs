namespace ControlDosimetro
{
    partial class frmBusquedaTipoDoc
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
            this.grpDatosTipoDocumento = new System.Windows.Forms.GroupBox();
            this.cbx_id_estado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_Agregar = new System.Windows.Forms.ToolStripButton();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalle_tipo_documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.grpDatosTipoDocumento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatosTipoDocumento
            // 
            this.grpDatosTipoDocumento.Controls.Add(this.btn_Buscar);
            this.grpDatosTipoDocumento.Controls.Add(this.cbx_id_estado);
            this.grpDatosTipoDocumento.Controls.Add(this.label1);
            this.grpDatosTipoDocumento.Location = new System.Drawing.Point(12, 28);
            this.grpDatosTipoDocumento.Name = "grpDatosTipoDocumento";
            this.grpDatosTipoDocumento.Size = new System.Drawing.Size(495, 93);
            this.grpDatosTipoDocumento.TabIndex = 2;
            this.grpDatosTipoDocumento.TabStop = false;
            this.grpDatosTipoDocumento.Text = "Dato Tipo Documento";
            // 
            // cbx_id_estado
            // 
            this.cbx_id_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_id_estado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbx_id_estado.FormattingEnabled = true;
            this.cbx_id_estado.Location = new System.Drawing.Point(66, 19);
            this.cbx_id_estado.Name = "cbx_id_estado";
            this.cbx_id_estado.Size = new System.Drawing.Size(121, 21);
            this.cbx_id_estado.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estado";
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.AllowUserToDeleteRows = false;
            this.grdDatos.AllowUserToResizeColumns = false;
            this.grdDatos.AllowUserToResizeRows = false;
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdDatos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.detalle_tipo_documento});
            this.grdDatos.Location = new System.Drawing.Point(12, 127);
            this.grdDatos.MultiSelect = false;
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ReadOnly = true;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(496, 264);
            this.grdDatos.TabIndex = 3;
            this.grdDatos.DoubleClick += new System.EventHandler(this.grdDatos_DoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Agregar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(514, 25);
            this.toolStrip1.TabIndex = 4;
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
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.Frozen = true;
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 41;
            // 
            // detalle_tipo_documento
            // 
            this.detalle_tipo_documento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.detalle_tipo_documento.DataPropertyName = "detalle_tipo_documento";
            this.detalle_tipo_documento.HeaderText = "Descripción";
            this.detalle_tipo_documento.Name = "detalle_tipo_documento";
            this.detalle_tipo_documento.ReadOnly = true;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Image = global::ControlDosimetro.Properties.Resources.Buscar;
            this.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Buscar.Location = new System.Drawing.Point(32, 47);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(111, 40);
            this.btn_Buscar.TabIndex = 4;
            this.btn_Buscar.Text = "Busqueda";
            this.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // frmBusquedaTipoDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 395);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grpDatosTipoDocumento);
            this.Controls.Add(this.grdDatos);
            this.Name = "frmBusquedaTipoDoc";
            this.Text = "Tipo de Documentos";
            this.grpDatosTipoDocumento.ResumeLayout(false);
            this.grpDatosTipoDocumento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosTipoDocumento;
        private System.Windows.Forms.ComboBox cbx_id_estado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_Agregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalle_tipo_documento;
        private System.Windows.Forms.Button btn_Buscar;
    }
}