namespace ControlDosimetro
{
	partial class frmGenerarPreISP
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenerarPreISP));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbx_id_periodo = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cbx_anno = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsb_Reporte = new System.Windows.Forms.ToolStripSplitButton();
			this.tsb_Verificacion = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Cerrar = new System.Windows.Forms.Button();
			this.btn_Corregir = new System.Windows.Forms.Button();
			this.pnl_Progreso = new System.Windows.Forms.GroupBox();
			this.btn_Dosis = new System.Windows.Forms.Button();
			this.btn_Toes = new System.Windows.Forms.Button();
			this.btn_Entidades = new System.Windows.Forms.Button();
			this.lbl_Status = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.pnl_Progreso.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbx_id_periodo);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cbx_anno);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(5, 28);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(410, 89);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Cargar Datos";
			// 
			// cbx_id_periodo
			// 
			this.cbx_id_periodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_id_periodo.FormattingEnabled = true;
			this.cbx_id_periodo.Location = new System.Drawing.Point(85, 50);
			this.cbx_id_periodo.Name = "cbx_id_periodo";
			this.cbx_id_periodo.Size = new System.Drawing.Size(121, 21);
			this.cbx_id_periodo.TabIndex = 43;
			this.cbx_id_periodo.SelectedIndexChanged += new System.EventHandler(this.cbx_id_periodo_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 36;
			this.label1.Text = "periodo";
			// 
			// cbx_anno
			// 
			this.cbx_anno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbx_anno.FormattingEnabled = true;
			this.cbx_anno.Location = new System.Drawing.Point(85, 25);
			this.cbx_anno.Name = "cbx_anno";
			this.cbx_anno.Size = new System.Drawing.Size(121, 21);
			this.cbx_anno.TabIndex = 1;
			this.cbx_anno.SelectedIndexChanged += new System.EventHandler(this.cbx_anno_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 28);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Año";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Reporte});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(430, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsb_Reporte
			// 
			this.tsb_Reporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsb_Reporte.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Verificacion});
			this.tsb_Reporte.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Reporte.Image")));
			this.tsb_Reporte.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsb_Reporte.Name = "tsb_Reporte";
			this.tsb_Reporte.Size = new System.Drawing.Size(64, 22);
			this.tsb_Reporte.Tag = "";
			this.tsb_Reporte.Text = "Reporte";
			// 
			// tsb_Verificacion
			// 
			this.tsb_Verificacion.Name = "tsb_Verificacion";
			this.tsb_Verificacion.Size = new System.Drawing.Size(135, 22);
			this.tsb_Verificacion.Text = "Verificación";
			this.tsb_Verificacion.Click += new System.EventHandler(this.tsb_Verificacion_Click);
			// 
			// btn_Cerrar
			// 
			this.btn_Cerrar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_Cerrar.Location = new System.Drawing.Point(254, 157);
			this.btn_Cerrar.Name = "btn_Cerrar";
			this.btn_Cerrar.Size = new System.Drawing.Size(83, 23);
			this.btn_Cerrar.TabIndex = 8;
			this.btn_Cerrar.Text = "Cerrar";
			this.btn_Cerrar.UseVisualStyleBackColor = true;
			this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
			// 
			// btn_Corregir
			// 
			this.btn_Corregir.Location = new System.Drawing.Point(62, 155);
			this.btn_Corregir.Name = "btn_Corregir";
			this.btn_Corregir.Size = new System.Drawing.Size(126, 23);
			this.btn_Corregir.TabIndex = 9;
			this.btn_Corregir.Text = "Generar datos";
			this.btn_Corregir.UseVisualStyleBackColor = true;
			this.btn_Corregir.Click += new System.EventHandler(this.btn_Corregir_Click);
			// 
			// pnl_Progreso
			// 
			this.pnl_Progreso.Controls.Add(this.btn_Dosis);
			this.pnl_Progreso.Controls.Add(this.btn_Toes);
			this.pnl_Progreso.Controls.Add(this.btn_Entidades);
			this.pnl_Progreso.Location = new System.Drawing.Point(12, 184);
			this.pnl_Progreso.Name = "pnl_Progreso";
			this.pnl_Progreso.Size = new System.Drawing.Size(403, 70);
			this.pnl_Progreso.TabIndex = 9;
			this.pnl_Progreso.TabStop = false;
			this.pnl_Progreso.Text = "Descarga informe";
			// 
			// btn_Dosis
			// 
			this.btn_Dosis.Location = new System.Drawing.Point(242, 18);
			this.btn_Dosis.Name = "btn_Dosis";
			this.btn_Dosis.Size = new System.Drawing.Size(75, 23);
			this.btn_Dosis.TabIndex = 12;
			this.btn_Dosis.Text = "DOSIS";
			this.btn_Dosis.UseVisualStyleBackColor = true;
			this.btn_Dosis.Click += new System.EventHandler(this.btn_Dosis_Click);
			// 
			// btn_Toes
			// 
			this.btn_Toes.Location = new System.Drawing.Point(142, 18);
			this.btn_Toes.Name = "btn_Toes";
			this.btn_Toes.Size = new System.Drawing.Size(75, 23);
			this.btn_Toes.TabIndex = 11;
			this.btn_Toes.Text = "TOES";
			this.btn_Toes.UseVisualStyleBackColor = true;
			this.btn_Toes.Click += new System.EventHandler(this.btn_Toes_Click);
			// 
			// btn_Entidades
			// 
			this.btn_Entidades.Location = new System.Drawing.Point(17, 19);
			this.btn_Entidades.Name = "btn_Entidades";
			this.btn_Entidades.Size = new System.Drawing.Size(100, 23);
			this.btn_Entidades.TabIndex = 10;
			this.btn_Entidades.Text = "ENTIDADES ";
			this.btn_Entidades.UseVisualStyleBackColor = true;
			this.btn_Entidades.Click += new System.EventHandler(this.btn_Entidades_Click);
			// 
			// lbl_Status
			// 
			this.lbl_Status.AutoSize = true;
			this.lbl_Status.ForeColor = System.Drawing.Color.Yellow;
			this.lbl_Status.Location = new System.Drawing.Point(62, 124);
			this.lbl_Status.Name = "lbl_Status";
			this.lbl_Status.Size = new System.Drawing.Size(29, 13);
			this.lbl_Status.TabIndex = 10;
			this.lbl_Status.Text = "mkm";
			// 
			// frmGenerarPreISP
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(430, 263);
			this.Controls.Add(this.lbl_Status);
			this.Controls.Add(this.pnl_Progreso);
			this.Controls.Add(this.btn_Corregir);
			this.Controls.Add(this.btn_Cerrar);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmGenerarPreISP";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Generar Pre informe ISP";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.pnl_Progreso.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		  private System.Windows.Forms.GroupBox groupBox1;
		  private System.Windows.Forms.Label label3;
		  private System.Windows.Forms.ToolStrip toolStrip1;
								private System.Windows.Forms.Label label1;
								private System.Windows.Forms.ComboBox cbx_anno;
								private System.Windows.Forms.ComboBox cbx_id_periodo;
								private System.Windows.Forms.Button btn_Cerrar;
                                private System.Windows.Forms.Button btn_Corregir;
        private System.Windows.Forms.ToolStripSplitButton tsb_Reporte;
        private System.Windows.Forms.ToolStripMenuItem tsb_Verificacion;
        private System.Windows.Forms.GroupBox pnl_Progreso;
        private System.Windows.Forms.Button btn_Dosis;
        private System.Windows.Forms.Button btn_Toes;
        private System.Windows.Forms.Button btn_Entidades;
        private System.Windows.Forms.Label lbl_Status;
    }
}