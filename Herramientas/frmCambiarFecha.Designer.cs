namespace ControlDosimetro.Herramientas
{
    partial class frmCambiarFecha
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
            this.tbl_Cliente = new System.Windows.Forms.GroupBox();
            this.lbl_id_cliente = new System.Windows.Forms.TextBox();
            this.btn_CargarCliente = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_rut = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbl_Cliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbl_Cliente
            // 
            this.tbl_Cliente.Controls.Add(this.lbl_id_cliente);
            this.tbl_Cliente.Controls.Add(this.btn_CargarCliente);
            this.tbl_Cliente.Controls.Add(this.label8);
            this.tbl_Cliente.Controls.Add(this.lbl_rut);
            this.tbl_Cliente.Controls.Add(this.label6);
            this.tbl_Cliente.Controls.Add(this.label5);
            this.tbl_Cliente.Controls.Add(this.label4);
            this.tbl_Cliente.Controls.Add(this.label3);
            this.tbl_Cliente.Controls.Add(this.label2);
            this.tbl_Cliente.Controls.Add(this.label1);
            this.tbl_Cliente.Location = new System.Drawing.Point(-3, 1);
            this.tbl_Cliente.Name = "tbl_Cliente";
            this.tbl_Cliente.Size = new System.Drawing.Size(422, 247);
            this.tbl_Cliente.TabIndex = 0;
            this.tbl_Cliente.TabStop = false;
            this.tbl_Cliente.Text = "Datos";
            // 
            // lbl_id_cliente
            // 
            this.lbl_id_cliente.Location = new System.Drawing.Point(133, 45);
            this.lbl_id_cliente.Name = "lbl_id_cliente";
            this.lbl_id_cliente.Size = new System.Drawing.Size(100, 20);
            this.lbl_id_cliente.TabIndex = 19;
            // 
            // btn_CargarCliente
            // 
            this.btn_CargarCliente.Location = new System.Drawing.Point(249, 42);
            this.btn_CargarCliente.Name = "btn_CargarCliente";
            this.btn_CargarCliente.Size = new System.Drawing.Size(84, 23);
            this.btn_CargarCliente.TabIndex = 18;
            this.btn_CargarCliente.Tag = "";
            this.btn_CargarCliente.Text = "Cargar Cliente";
            this.btn_CargarCliente.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(148, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "label8";
            // 
            // lbl_rut
            // 
            this.lbl_rut.AutoSize = true;
            this.lbl_rut.Location = new System.Drawing.Point(148, 111);
            this.lbl_rut.Name = "lbl_rut";
            this.lbl_rut.Size = new System.Drawing.Size(35, 13);
            this.lbl_rut.TabIndex = 16;
            this.lbl_rut.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fecha ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "RUN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "N° Cliente";
            // 
            // frmCambiarFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 251);
            this.Controls.Add(this.tbl_Cliente);
            this.Name = "frmCambiarFecha";
            this.Text = "frmCambiarFecha";
            this.tbl_Cliente.ResumeLayout(false);
            this.tbl_Cliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox tbl_Cliente;
        private System.Windows.Forms.TextBox lbl_id_cliente;
        private System.Windows.Forms.Button btn_CargarCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_rut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}