namespace ControlDosimetro
{
    partial class frmLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
			this.panel1 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.txt_Contrasena = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_Usuario = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_ingresar = new System.Windows.Forms.Button();
			this.btn_Salir = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.labelVersion = new System.Windows.Forms.ToolStripStatusLabel();
			this.labelBD = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsbHerramienta = new System.Windows.Forms.ToolStripDropDownButton();
			this.tsbEnviarLog = new System.Windows.Forms.ToolStripMenuItem();
			this.tsbRecuperarCont = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tableLayoutPanel1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(402, 229);
			this.panel1.TabIndex = 0;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.04975F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.95025F));
			this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 204F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(402, 204);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = global::ControlDosimetro.Properties.Resources.Filmica;
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(155, 198);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Controls.Add(this.txt_Contrasena, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.txt_Usuario, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 4);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(164, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 5;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(235, 198);
			this.tableLayoutPanel2.TabIndex = 1;
			// 
			// txt_Contrasena
			// 
			this.txt_Contrasena.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txt_Contrasena.Location = new System.Drawing.Point(3, 95);
			this.txt_Contrasena.Name = "txt_Contrasena";
			this.txt_Contrasena.PasswordChar = '*';
			this.txt_Contrasena.Size = new System.Drawing.Size(229, 20);
			this.txt_Contrasena.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Usuario";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(3, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Contraseña";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txt_Usuario
			// 
			this.txt_Usuario.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txt_Usuario.Location = new System.Drawing.Point(3, 34);
			this.txt_Usuario.Name = "txt_Usuario";
			this.txt_Usuario.Size = new System.Drawing.Size(229, 20);
			this.txt_Usuario.TabIndex = 2;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Controls.Add(this.btn_ingresar, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.btn_Salir, 1, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 132);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(229, 63);
			this.tableLayoutPanel3.TabIndex = 4;
			// 
			// btn_ingresar
			// 
			this.btn_ingresar.Location = new System.Drawing.Point(3, 3);
			this.btn_ingresar.Name = "btn_ingresar";
			this.btn_ingresar.Size = new System.Drawing.Size(108, 30);
			this.btn_ingresar.TabIndex = 0;
			this.btn_ingresar.Text = "Aceptar";
			this.btn_ingresar.UseVisualStyleBackColor = true;
			this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
			// 
			// btn_Salir
			// 
			this.btn_Salir.Location = new System.Drawing.Point(117, 3);
			this.btn_Salir.Name = "btn_Salir";
			this.btn_Salir.Size = new System.Drawing.Size(109, 30);
			this.btn_Salir.TabIndex = 1;
			this.btn_Salir.Text = "Salir";
			this.btn_Salir.UseVisualStyleBackColor = true;
			this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.labelVersion,
            this.labelBD,
            this.tsbHerramienta});
			this.statusStrip1.Location = new System.Drawing.Point(0, 207);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(402, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 17);
			this.toolStripStatusLabel1.Text = "Versión";
			// 
			// labelVersion
			// 
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Size = new System.Drawing.Size(45, 17);
			this.labelVersion.Text = "version";
			// 
			// labelBD
			// 
			this.labelBD.Name = "labelBD";
			this.labelBD.Size = new System.Drawing.Size(68, 17);
			this.labelBD.Text = "Producción";
			this.labelBD.Click += new System.EventHandler(this.labelBD_Click);
			// 
			// tsbHerramienta
			// 
			this.tsbHerramienta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tsbHerramienta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEnviarLog,
            this.tsbRecuperarCont});
			this.tsbHerramienta.Image = ((System.Drawing.Image)(resources.GetObject("tsbHerramienta.Image")));
			this.tsbHerramienta.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbHerramienta.Name = "tsbHerramienta";
			this.tsbHerramienta.Size = new System.Drawing.Size(91, 20);
			this.tsbHerramienta.Text = "Herramientas";
			// 
			// tsbEnviarLog
			// 
			this.tsbEnviarLog.Name = "tsbEnviarLog";
			this.tsbEnviarLog.Size = new System.Drawing.Size(181, 22);
			this.tsbEnviarLog.Text = "Enviar Log...";
			this.tsbEnviarLog.Click += new System.EventHandler(this.tsbEnviarLog_Click);
			// 
			// tsbRecuperarCont
			// 
			this.tsbRecuperarCont.Name = "tsbRecuperarCont";
			this.tsbRecuperarCont.Size = new System.Drawing.Size(181, 22);
			this.tsbRecuperarCont.Text = "Recuperar cotraseña";
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(402, 229);
			this.ControlBox = false;
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.panel1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sistema de control dosimetro";
			this.panel1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txt_Contrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelVersion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel labelBD;
        private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStripDropDownButton tsbHerramienta;
		private System.Windows.Forms.ToolStripMenuItem tsbEnviarLog;
		private System.Windows.Forms.ToolStripMenuItem tsbRecuperarCont;
	}
}