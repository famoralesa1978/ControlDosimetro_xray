namespace ControlDosimetro
{
    partial class frmRptPorEstado
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
            this.sistiamccontrolDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistiamc_controlDataSet1 = new ControlDosimetro.sistiamc_controlDataSet1();
            this.sistiamc_controlDataSet2 = new ControlDosimetro.sistiamc_controlDataSet2();
            this.rtpDosimetriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rtpDosimetriaTableAdapter = new ControlDosimetro.sistiamc_controlDataSet2TableAdapters.rtpDosimetriaTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_Estado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Reporte = new System.Windows.Forms.Button();
            this.cbx_periodo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_anno = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sistiamccontrolDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistiamc_controlDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistiamc_controlDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtpDosimetriaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sistiamccontrolDataSet1BindingSource
            // 
            this.sistiamccontrolDataSet1BindingSource.DataSource = this.sistiamc_controlDataSet1;
            this.sistiamccontrolDataSet1BindingSource.Position = 0;
            // 
            // sistiamc_controlDataSet1
            // 
            this.sistiamc_controlDataSet1.DataSetName = "sistiamc_controlDataSet1";
            this.sistiamc_controlDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sistiamc_controlDataSet2
            // 
            this.sistiamc_controlDataSet2.DataSetName = "sistiamc_controlDataSet2";
            this.sistiamc_controlDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rtpDosimetriaBindingSource
            // 
            this.rtpDosimetriaBindingSource.DataMember = "rtpDosimetria";
            this.rtpDosimetriaBindingSource.DataSource = this.sistiamc_controlDataSet2;
            // 
            // rtpDosimetriaTableAdapter
            // 
            this.rtpDosimetriaTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_Estado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_Reporte);
            this.groupBox1.Controls.Add(this.cbx_periodo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbx_anno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 200);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros para el reporte";
            // 
            // cbx_Estado
            // 
            this.cbx_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Estado.FormattingEnabled = true;
            this.cbx_Estado.Location = new System.Drawing.Point(97, 89);
            this.cbx_Estado.Name = "cbx_Estado";
            this.cbx_Estado.Size = new System.Drawing.Size(121, 21);
            this.cbx_Estado.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Estado";
            // 
            // btn_Reporte
            // 
            this.btn_Reporte.Location = new System.Drawing.Point(47, 160);
            this.btn_Reporte.Name = "btn_Reporte";
            this.btn_Reporte.Size = new System.Drawing.Size(75, 23);
            this.btn_Reporte.TabIndex = 5;
            this.btn_Reporte.Text = "Reporte";
            this.btn_Reporte.UseVisualStyleBackColor = true;
            this.btn_Reporte.Click += new System.EventHandler(this.btn_Reporte_Click);
            // 
            // cbx_periodo
            // 
            this.cbx_periodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_periodo.FormattingEnabled = true;
            this.cbx_periodo.Location = new System.Drawing.Point(97, 62);
            this.cbx_periodo.Name = "cbx_periodo";
            this.cbx_periodo.Size = new System.Drawing.Size(121, 21);
            this.cbx_periodo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "periodo";
            // 
            // cbx_anno
            // 
            this.cbx_anno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_anno.FormattingEnabled = true;
            this.cbx_anno.Location = new System.Drawing.Point(97, 35);
            this.cbx_anno.Name = "cbx_anno";
            this.cbx_anno.Size = new System.Drawing.Size(121, 21);
            this.cbx_anno.TabIndex = 2;
            this.cbx_anno.SelectedIndexChanged += new System.EventHandler(this.cbx_anno_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Año";
            // 
            // frmRptPorEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 224);
            this.Controls.Add(this.groupBox1);
            this.MinimizeBox = false;
            this.Name = "frmRptPorEstado";
            this.Text = "Reporte Por Estado";
            this.Load += new System.EventHandler(this.frmRpDosimetria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistiamccontrolDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistiamc_controlDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistiamc_controlDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtpDosimetriaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource rtpDosimetriaBindingSource;
        private sistiamc_controlDataSet2 sistiamc_controlDataSet2;
        private sistiamc_controlDataSet2TableAdapters.rtpDosimetriaTableAdapter rtpDosimetriaTableAdapter;
        private System.Windows.Forms.BindingSource sistiamccontrolDataSet1BindingSource;
        private sistiamc_controlDataSet1 sistiamc_controlDataSet1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Reporte;
        private System.Windows.Forms.ComboBox cbx_periodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_anno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_Estado;
        private System.Windows.Forms.Label label2;
    }
}