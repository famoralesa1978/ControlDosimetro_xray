namespace ControlDosimetro
{
    partial class frmRptcliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPorPersonal = new System.Windows.Forms.TabPage();
            this.btn_ReporteNDosimetro = new System.Windows.Forms.Button();
            this.txt_NCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rtpDosimetriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sistiamccontrolDataSet1BindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPorPersonal.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rtpDosimetriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 125);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPorPersonal);
            this.tabControl1.Location = new System.Drawing.Point(6, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(551, 75);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPorPersonal
            // 
            this.tabPorPersonal.Controls.Add(this.btn_ReporteNDosimetro);
            this.tabPorPersonal.Controls.Add(this.txt_NCliente);
            this.tabPorPersonal.Controls.Add(this.label5);
            this.tabPorPersonal.Location = new System.Drawing.Point(4, 25);
            this.tabPorPersonal.Name = "tabPorPersonal";
            this.tabPorPersonal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPorPersonal.Size = new System.Drawing.Size(543, 46);
            this.tabPorPersonal.TabIndex = 4;
            this.tabPorPersonal.Text = "Por Personal";
            this.tabPorPersonal.UseVisualStyleBackColor = true;
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
            // txt_NCliente
            // 
            this.txt_NCliente.Location = new System.Drawing.Point(91, 11);
            this.txt_NCliente.Name = "txt_NCliente";
            this.txt_NCliente.Size = new System.Drawing.Size(126, 20);
            this.txt_NCliente.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Rut Cliente";
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
            // frmRptcliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 569);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.MinimizeBox = false;
            this.Name = "frmRptcliente";
            this.Text = "Reporte por Cliente";
            this.Load += new System.EventHandler(this.frmRpDosimetria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistiamccontrolDataSet1BindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPorPersonal.ResumeLayout(false);
            this.tabPorPersonal.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rtpDosimetriaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rtpDosimetriaBindingSource;
  //      private sistiamc_controlDataSet2 sistiamc_controlDataSet2;
   //     private sistiamc_controlDataSet2TableAdapters.rtpDosimetriaTableAdapter rtpDosimetriaTableAdapter;
        private System.Windows.Forms.BindingSource sistiamccontrolDataSet1BindingSource;
     //   private sistiamc_controlDataSet1 sistiamc_controlDataSet1;
        private System.Windows.Forms.TabPage tabPorPersonal;
        private System.Windows.Forms.Button btn_ReporteNDosimetro;
        private System.Windows.Forms.TextBox txt_NCliente;
        private System.Windows.Forms.Label label5;
    }
}