namespace ControlDosimetro.Herramientas
{
    partial class frmCambioFecha
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_FechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lbl_nombrecliente = new System.Windows.Forms.Label();
            this.btn_CargarCliente = new System.Windows.Forms.Button();
            this.lbl_id_cliente = new System.Windows.Forms.TextBox();
            this.lbl_run = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Modificar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtp_FechaInicio);
            this.groupBox1.Controls.Add(this.lbl_nombrecliente);
            this.groupBox1.Controls.Add(this.btn_CargarCliente);
            this.groupBox1.Controls.Add(this.lbl_id_cliente);
            this.groupBox1.Controls.Add(this.lbl_run);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(194, 153);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(109, 23);
            this.btn_Modificar.TabIndex = 9;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha Inicio:";
            // 
            // dtp_FechaInicio
            // 
            this.dtp_FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaInicio.Location = new System.Drawing.Point(93, 153);
            this.dtp_FechaInicio.Name = "dtp_FechaInicio";
            this.dtp_FechaInicio.Size = new System.Drawing.Size(91, 20);
            this.dtp_FechaInicio.TabIndex = 7;
            // 
            // lbl_nombrecliente
            // 
            this.lbl_nombrecliente.AutoSize = true;
            this.lbl_nombrecliente.Location = new System.Drawing.Point(93, 85);
            this.lbl_nombrecliente.Name = "lbl_nombrecliente";
            this.lbl_nombrecliente.Size = new System.Drawing.Size(35, 13);
            this.lbl_nombrecliente.TabIndex = 6;
            this.lbl_nombrecliente.Text = "label5";
            // 
            // btn_CargarCliente
            // 
            this.btn_CargarCliente.Location = new System.Drawing.Point(194, 42);
            this.btn_CargarCliente.Name = "btn_CargarCliente";
            this.btn_CargarCliente.Size = new System.Drawing.Size(109, 23);
            this.btn_CargarCliente.TabIndex = 5;
            this.btn_CargarCliente.Text = "Cargar Cliente";
            this.btn_CargarCliente.UseVisualStyleBackColor = true;
            this.btn_CargarCliente.Click += new System.EventHandler(this.btn_CargarCliente_Click);
            // 
            // lbl_id_cliente
            // 
            this.lbl_id_cliente.Location = new System.Drawing.Point(93, 44);
            this.lbl_id_cliente.MaxLength = 10;
            this.lbl_id_cliente.Name = "lbl_id_cliente";
            this.lbl_id_cliente.Size = new System.Drawing.Size(91, 20);
            this.lbl_id_cliente.TabIndex = 4;
            // 
            // lbl_run
            // 
            this.lbl_run.AutoSize = true;
            this.lbl_run.Location = new System.Drawing.Point(93, 119);
            this.lbl_run.Name = "lbl_run";
            this.lbl_run.Size = new System.Drawing.Size(35, 13);
            this.lbl_run.TabIndex = 3;
            this.lbl_run.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "RUN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° Cliente:";
            // 
            // frmCambioFecha
            // 
            this.ClientSize = new System.Drawing.Size(410, 233);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCambioFecha";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_CargarCliente;
        private System.Windows.Forms.TextBox lbl_id_cliente;
        private System.Windows.Forms.Label lbl_run;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_nombrecliente;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_FechaInicio;
    }
}