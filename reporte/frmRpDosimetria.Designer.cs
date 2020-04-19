namespace ControlDosimetro
{
    partial class frmRpDosimetria
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sistiamccontrolDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistiamc_controlDataSet1 = new ControlDosimetro.sistiamc_controlDataSet1();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_anno = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPorDosimetro = new System.Windows.Forms.TabPage();
            this.btn_ReporteNDosimetro = new System.Windows.Forms.Button();
            this.txt_NDosimetro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabRut = new System.Windows.Forms.TabPage();
            this.btn_ReporteRut = new System.Windows.Forms.Button();
            this.txt_Rut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCliente = new System.Windows.Forms.TabPage();
            this.btn_reporteNCliente = new System.Windows.Forms.Button();
            this.txt_NumeroCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabRegion = new System.Windows.Forms.TabPage();
            this.cbx_Region = new System.Windows.Forms.ComboBox();
            this.btn_ReporteRegion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabAnual = new System.Windows.Forms.TabPage();
            this.btn_AnualCliente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sistiamc_controlDataSet2 = new ControlDosimetro.sistiamc_controlDataSet2();
            this.rtpDosimetriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rtpDosimetriaTableAdapter = new ControlDosimetro.sistiamc_controlDataSet2TableAdapters.rtpDosimetriaTableAdapter();
            this.tabAnualSucursal = new System.Windows.Forms.TabPage();
            this.btnReporteAnualPorSucursal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sistiamccontrolDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistiamc_controlDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPorDosimetro.SuspendLayout();
            this.tabRut.SuspendLayout();
            this.tabCliente.SuspendLayout();
            this.tabRegion.SuspendLayout();
            this.tabAnual.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sistiamc_controlDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtpDosimetriaBindingSource)).BeginInit();
            this.tabAnualSucursal.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_anno);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 125);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // cbx_anno
            // 
            this.cbx_anno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_anno.FormattingEnabled = true;
            this.cbx_anno.Location = new System.Drawing.Point(41, 17);
            this.cbx_anno.Name = "cbx_anno";
            this.cbx_anno.Size = new System.Drawing.Size(121, 21);
            this.cbx_anno.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Año";
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPorDosimetro);
            this.tabControl1.Controls.Add(this.tabRut);
            this.tabControl1.Controls.Add(this.tabCliente);
            this.tabControl1.Controls.Add(this.tabRegion);
            this.tabControl1.Controls.Add(this.tabAnual);
            this.tabControl1.Controls.Add(this.tabAnualSucursal);
            this.tabControl1.Location = new System.Drawing.Point(6, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(551, 75);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPorDosimetro
            // 
            this.tabPorDosimetro.Controls.Add(this.btn_ReporteNDosimetro);
            this.tabPorDosimetro.Controls.Add(this.txt_NDosimetro);
            this.tabPorDosimetro.Controls.Add(this.label5);
            this.tabPorDosimetro.Location = new System.Drawing.Point(4, 25);
            this.tabPorDosimetro.Name = "tabPorDosimetro";
            this.tabPorDosimetro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPorDosimetro.Size = new System.Drawing.Size(543, 46);
            this.tabPorDosimetro.TabIndex = 4;
            this.tabPorDosimetro.Text = "Por Dosimetro";
            this.tabPorDosimetro.UseVisualStyleBackColor = true;
            // 
            // btn_ReporteNDosimetro
            // 
            this.btn_ReporteNDosimetro.Location = new System.Drawing.Point(223, 12);
            this.btn_ReporteNDosimetro.Name = "btn_ReporteNDosimetro";
            this.btn_ReporteNDosimetro.Size = new System.Drawing.Size(75, 23);
            this.btn_ReporteNDosimetro.TabIndex = 8;
            this.btn_ReporteNDosimetro.Text = "Reporte";
            this.btn_ReporteNDosimetro.UseVisualStyleBackColor = true;
            this.btn_ReporteNDosimetro.Click += new System.EventHandler(this.btn_ReporteNDosimetro_Click);
            // 
            // txt_NDosimetro
            // 
            this.txt_NDosimetro.Location = new System.Drawing.Point(91, 11);
            this.txt_NDosimetro.Name = "txt_NDosimetro";
            this.txt_NDosimetro.Size = new System.Drawing.Size(126, 20);
            this.txt_NDosimetro.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "N° Dosimetro";
            // 
            // tabRut
            // 
            this.tabRut.Controls.Add(this.btn_ReporteRut);
            this.tabRut.Controls.Add(this.txt_Rut);
            this.tabRut.Controls.Add(this.label1);
            this.tabRut.Location = new System.Drawing.Point(4, 25);
            this.tabRut.Name = "tabRut";
            this.tabRut.Padding = new System.Windows.Forms.Padding(3);
            this.tabRut.Size = new System.Drawing.Size(505, 46);
            this.tabRut.TabIndex = 0;
            this.tabRut.Text = "Por Rut";
            this.tabRut.UseVisualStyleBackColor = true;
            // 
            // btn_ReporteRut
            // 
            this.btn_ReporteRut.Location = new System.Drawing.Point(178, 10);
            this.btn_ReporteRut.Name = "btn_ReporteRut";
            this.btn_ReporteRut.Size = new System.Drawing.Size(75, 23);
            this.btn_ReporteRut.TabIndex = 2;
            this.btn_ReporteRut.Text = "Reporte";
            this.btn_ReporteRut.UseVisualStyleBackColor = true;
            this.btn_ReporteRut.Click += new System.EventHandler(this.btn_ReporteRut_Click);
            // 
            // txt_Rut
            // 
            this.txt_Rut.Location = new System.Drawing.Point(46, 10);
            this.txt_Rut.Name = "txt_Rut";
            this.txt_Rut.Size = new System.Drawing.Size(126, 20);
            this.txt_Rut.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rut";
            // 
            // tabCliente
            // 
            this.tabCliente.Controls.Add(this.btn_reporteNCliente);
            this.tabCliente.Controls.Add(this.txt_NumeroCliente);
            this.tabCliente.Controls.Add(this.label2);
            this.tabCliente.Location = new System.Drawing.Point(4, 25);
            this.tabCliente.Name = "tabCliente";
            this.tabCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabCliente.Size = new System.Drawing.Size(505, 46);
            this.tabCliente.TabIndex = 1;
            this.tabCliente.Text = "Por Número Cliente";
            this.tabCliente.UseVisualStyleBackColor = true;
            // 
            // btn_reporteNCliente
            // 
            this.btn_reporteNCliente.Location = new System.Drawing.Point(223, 7);
            this.btn_reporteNCliente.Name = "btn_reporteNCliente";
            this.btn_reporteNCliente.Size = new System.Drawing.Size(75, 23);
            this.btn_reporteNCliente.TabIndex = 5;
            this.btn_reporteNCliente.Text = "Reporte";
            this.btn_reporteNCliente.UseVisualStyleBackColor = true;
            this.btn_reporteNCliente.Click += new System.EventHandler(this.btn_reporteNCliente_Click);
            // 
            // txt_NumeroCliente
            // 
            this.txt_NumeroCliente.Location = new System.Drawing.Point(91, 6);
            this.txt_NumeroCliente.Name = "txt_NumeroCliente";
            this.txt_NumeroCliente.Size = new System.Drawing.Size(126, 20);
            this.txt_NumeroCliente.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número Cliente";
            // 
            // tabRegion
            // 
            this.tabRegion.Controls.Add(this.cbx_Region);
            this.tabRegion.Controls.Add(this.btn_ReporteRegion);
            this.tabRegion.Controls.Add(this.label3);
            this.tabRegion.Location = new System.Drawing.Point(4, 25);
            this.tabRegion.Name = "tabRegion";
            this.tabRegion.Size = new System.Drawing.Size(505, 46);
            this.tabRegion.TabIndex = 2;
            this.tabRegion.Text = "Por Región";
            this.tabRegion.UseVisualStyleBackColor = true;
            // 
            // cbx_Region
            // 
            this.cbx_Region.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Region.FormattingEnabled = true;
            this.cbx_Region.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cbx_Region.Location = new System.Drawing.Point(61, 9);
            this.cbx_Region.Name = "cbx_Region";
            this.cbx_Region.Size = new System.Drawing.Size(62, 21);
            this.cbx_Region.TabIndex = 9;
            // 
            // btn_ReporteRegion
            // 
            this.btn_ReporteRegion.Location = new System.Drawing.Point(129, 9);
            this.btn_ReporteRegion.Name = "btn_ReporteRegion";
            this.btn_ReporteRegion.Size = new System.Drawing.Size(75, 23);
            this.btn_ReporteRegion.TabIndex = 9;
            this.btn_ReporteRegion.Text = "Reporte";
            this.btn_ReporteRegion.UseVisualStyleBackColor = true;
            this.btn_ReporteRegion.Click += new System.EventHandler(this.btn_ReporteRegion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Región";
            // 
            // tabAnual
            // 
            this.tabAnual.Controls.Add(this.btn_AnualCliente);
            this.tabAnual.Location = new System.Drawing.Point(4, 25);
            this.tabAnual.Name = "tabAnual";
            this.tabAnual.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnual.Size = new System.Drawing.Size(543, 46);
            this.tabAnual.TabIndex = 3;
            this.tabAnual.Text = "Anual por Cliente";
            this.tabAnual.UseVisualStyleBackColor = true;
            // 
            // btn_AnualCliente
            // 
            this.btn_AnualCliente.Location = new System.Drawing.Point(31, 17);
            this.btn_AnualCliente.Name = "btn_AnualCliente";
            this.btn_AnualCliente.Size = new System.Drawing.Size(75, 23);
            this.btn_AnualCliente.TabIndex = 11;
            this.btn_AnualCliente.Text = "Reporte";
            this.btn_AnualCliente.UseVisualStyleBackColor = true;
            this.btn_AnualCliente.Click += new System.EventHandler(this.btn_AnualCliente_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Location = new System.Drawing.Point(3, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 413);
            this.panel1.TabIndex = 2;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sistiamccontrolDataSet1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ControlDosimetro.reporte.rptDosimetria.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1217, 413);
            this.reportViewer1.TabIndex = 0;
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
            // tabAnualSucursal
            // 
            this.tabAnualSucursal.Controls.Add(this.btnReporteAnualPorSucursal);
            this.tabAnualSucursal.Location = new System.Drawing.Point(4, 25);
            this.tabAnualSucursal.Name = "tabAnualSucursal";
            this.tabAnualSucursal.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnualSucursal.Size = new System.Drawing.Size(543, 46);
            this.tabAnualSucursal.TabIndex = 5;
            this.tabAnualSucursal.Text = "Anual por Sucursal";
            this.tabAnualSucursal.UseVisualStyleBackColor = true;
            // 
            // btnReporteAnualPorSucursal
            // 
            this.btnReporteAnualPorSucursal.Location = new System.Drawing.Point(16, 6);
            this.btnReporteAnualPorSucursal.Name = "btnReporteAnualPorSucursal";
            this.btnReporteAnualPorSucursal.Size = new System.Drawing.Size(75, 23);
            this.btnReporteAnualPorSucursal.TabIndex = 12;
            this.btnReporteAnualPorSucursal.Text = "Reporte";
            this.btnReporteAnualPorSucursal.UseVisualStyleBackColor = true;
            this.btnReporteAnualPorSucursal.Click += new System.EventHandler(this.btnReporteAnualPorSucursal_Click);
            // 
            // frmRpDosimetria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 569);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.MinimizeBox = false;
            this.Name = "frmRpDosimetria";
            this.Text = "frmRpDosimetria";
            this.Load += new System.EventHandler(this.frmRpDosimetria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistiamccontrolDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistiamc_controlDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPorDosimetro.ResumeLayout(false);
            this.tabPorDosimetro.PerformLayout();
            this.tabRut.ResumeLayout(false);
            this.tabRut.PerformLayout();
            this.tabCliente.ResumeLayout(false);
            this.tabCliente.PerformLayout();
            this.tabRegion.ResumeLayout(false);
            this.tabRegion.PerformLayout();
            this.tabAnual.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sistiamc_controlDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtpDosimetriaBindingSource)).EndInit();
            this.tabAnualSucursal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbx_anno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRut;
        private System.Windows.Forms.Button btn_ReporteRut;
        private System.Windows.Forms.TextBox txt_Rut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabCliente;
        private System.Windows.Forms.Button btn_reporteNCliente;
        private System.Windows.Forms.TextBox txt_NumeroCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabRegion;
        private System.Windows.Forms.ComboBox cbx_Region;
        private System.Windows.Forms.Button btn_ReporteRegion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rtpDosimetriaBindingSource;
        private sistiamc_controlDataSet2 sistiamc_controlDataSet2;
        private sistiamc_controlDataSet2TableAdapters.rtpDosimetriaTableAdapter rtpDosimetriaTableAdapter;
        private System.Windows.Forms.BindingSource sistiamccontrolDataSet1BindingSource;
        private sistiamc_controlDataSet1 sistiamc_controlDataSet1;
        private System.Windows.Forms.TabPage tabAnual;
        private System.Windows.Forms.Button btn_AnualCliente;
        private System.Windows.Forms.TabPage tabPorDosimetro;
        private System.Windows.Forms.Button btn_ReporteNDosimetro;
        private System.Windows.Forms.TextBox txt_NDosimetro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabAnualSucursal;
        private System.Windows.Forms.Button btnReporteAnualPorSucursal;
    }
}