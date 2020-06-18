namespace ControlDosimetro
{
    partial class frmreporte
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sistiamccontrolDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistiamc_controlDataSet1 = new ControlDosimetro.sistiamc_controlDataSet1();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sistiamc_controlDataSet2 = new ControlDosimetro.sistiamc_controlDataSet2();
            this.rtpDosimetriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rtpDosimetriaTableAdapter = new ControlDosimetro.sistiamc_controlDataSet2TableAdapters.rtpDosimetriaTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sistiamc_controlDataSet11 = new ControlDosimetro.DB_A2B812_ControlDataSet();
            this.sistiamc_controlDataSet = new ControlDosimetro.sistiamc_controlDataSet();
            this.sistiamc_controlDataSet9 = new ControlDosimetro.DB_A2B812_ControlDataSet();
            this.dataSet1 = new ControlDosimetro.DataSet1();
            this.rptOrdenTrabajoTableAdapter = new ControlDosimetro.DataSet1TableAdapters.rptOrdenTrabajoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sistiamccontrolDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistiamc_controlDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sistiamc_controlDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtpDosimetriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistiamc_controlDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistiamc_controlDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistiamc_controlDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 545);
            this.panel1.TabIndex = 2;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.sistiamccontrolDataSet1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(707, 545);
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
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "rptOrdenTrabajo";
            this.bindingSource1.DataSource = this.dataSet1;
            // 
            // sistiamc_controlDataSet11
            // 
            this.sistiamc_controlDataSet11.DataSetName = "sistiamc_controlDataSet11";
            this.sistiamc_controlDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sistiamc_controlDataSet
            // 
            this.sistiamc_controlDataSet.DataSetName = "sistiamc_controlDataSet";
            this.sistiamc_controlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sistiamc_controlDataSet9
            // 
            this.sistiamc_controlDataSet9.DataSetName = "sistiamc_controlDataSet9";
            this.sistiamc_controlDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptOrdenTrabajoTableAdapter
            // 
            this.rptOrdenTrabajoTableAdapter.ClearBeforeFill = true;
            // 
            // frmreporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 569);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "frmreporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.frmRpDosimetria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistiamccontrolDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistiamc_controlDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sistiamc_controlDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtpDosimetriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistiamc_controlDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistiamc_controlDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistiamc_controlDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rtpDosimetriaBindingSource;
        private sistiamc_controlDataSet2 sistiamc_controlDataSet2;
        private sistiamc_controlDataSet2TableAdapters.rtpDosimetriaTableAdapter rtpDosimetriaTableAdapter;
        private System.Windows.Forms.BindingSource sistiamccontrolDataSet1BindingSource;
        private sistiamc_controlDataSet1 sistiamc_controlDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DB_A2B812_ControlDataSet sistiamc_controlDataSet9;
        private DB_A2B812_ControlDataSet sistiamc_controlDataSet11;
        private sistiamc_controlDataSet sistiamc_controlDataSet;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.rptOrdenTrabajoTableAdapter rptOrdenTrabajoTableAdapter;
    }
}