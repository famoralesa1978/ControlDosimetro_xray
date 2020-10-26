namespace ControlDosimetro.Herramientas
{
    partial class frmCambiarFechaControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.labele = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_nombreCliente = new System.Windows.Forms.Label();
            this.lbl_run = new System.Windows.Forms.Label();
            this.lbl_id_cliente = new System.Windows.Forms.TextBox();
            this.btn_CargarCliente = new System.Windows.Forms.Button();
            this.tbl_Cliente = new System.Windows.Forms.GroupBox();
            this.tbl_Cliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° Cliente";
            // 
            // labele
            // 
            this.labele.AutoSize = true;
            this.labele.Location = new System.Drawing.Point(32, 72);
            this.labele.Name = "labele";
            this.labele.Size = new System.Drawing.Size(44, 13);
            this.labele.TabIndex = 1;
            this.labele.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "RUN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha";
            // 
            // lbl_nombreCliente
            // 
            this.lbl_nombreCliente.AutoSize = true;
            this.lbl_nombreCliente.Location = new System.Drawing.Point(93, 72);
            this.lbl_nombreCliente.Name = "lbl_nombreCliente";
            this.lbl_nombreCliente.Size = new System.Drawing.Size(35, 13);
            this.lbl_nombreCliente.TabIndex = 4;
            this.lbl_nombreCliente.Text = "label5";
            // 
            // lbl_run
            // 
            this.lbl_run.AutoSize = true;
            this.lbl_run.Location = new System.Drawing.Point(87, 102);
            this.lbl_run.Name = "lbl_run";
            this.lbl_run.Size = new System.Drawing.Size(35, 13);
            this.lbl_run.TabIndex = 5;
            this.lbl_run.Text = "label6";
            // 
            // lbl_id_cliente
            // 
            this.lbl_id_cliente.Location = new System.Drawing.Point(90, 34);
            this.lbl_id_cliente.Name = "lbl_id_cliente";
            this.lbl_id_cliente.Size = new System.Drawing.Size(100, 20);
            this.lbl_id_cliente.TabIndex = 6;
            // 
            // btn_CargarCliente
            // 
            this.btn_CargarCliente.Location = new System.Drawing.Point(213, 37);
            this.btn_CargarCliente.Name = "btn_CargarCliente";
            this.btn_CargarCliente.Size = new System.Drawing.Size(103, 23);
            this.btn_CargarCliente.TabIndex = 7;
            this.btn_CargarCliente.Text = "Cargar Cliente";
            this.btn_CargarCliente.UseVisualStyleBackColor = true;
            this.btn_CargarCliente.Click += new System.EventHandler(this.btn_CargarCliente_Click_1);
            // 
            // tbl_Cliente
            // 
            this.tbl_Cliente.Controls.Add(this.btn_CargarCliente);
            this.tbl_Cliente.Controls.Add(this.lbl_id_cliente);
            this.tbl_Cliente.Controls.Add(this.lbl_run);
            this.tbl_Cliente.Controls.Add(this.lbl_nombreCliente);
            this.tbl_Cliente.Controls.Add(this.label4);
            this.tbl_Cliente.Controls.Add(this.label3);
            this.tbl_Cliente.Controls.Add(this.labele);
            this.tbl_Cliente.Controls.Add(this.label1);
            this.tbl_Cliente.Location = new System.Drawing.Point(0, 0);
            this.tbl_Cliente.Name = "tbl_Cliente";
            this.tbl_Cliente.Size = new System.Drawing.Size(521, 274);
            this.tbl_Cliente.TabIndex = 0;
            this.tbl_Cliente.TabStop = false;
            this.tbl_Cliente.Text = "Datos";
            // 
            // frmCambiarFechaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 276);
            this.Controls.Add(this.tbl_Cliente);
            this.Name = "frmCambiarFechaControl";
            this.Text = "frmCambiarFechaControl";
            this.tbl_Cliente.ResumeLayout(false);
            this.tbl_Cliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labele;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_nombreCliente;
        private System.Windows.Forms.Label lbl_run;
        private System.Windows.Forms.TextBox lbl_id_cliente;
        private System.Windows.Forms.Button btn_CargarCliente;
        private System.Windows.Forms.GroupBox tbl_Cliente;
    }
}