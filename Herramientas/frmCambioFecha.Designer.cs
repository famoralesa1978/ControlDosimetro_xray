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
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.dtp_FechaDestino = new System.Windows.Forms.DateTimePicker();
            this.lbl_FechaDestino = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.btn_Guardar);
            this.groupBox1.Controls.Add(this.dtp_FechaDestino);
            this.groupBox1.Controls.Add(this.lbl_FechaDestino);
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
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(215, 157);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(88, 23);
            this.btn_Guardar.TabIndex = 12;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // dtp_FechaDestino
            // 
            this.dtp_FechaDestino.CustomFormat = "dd/MM/yyyy";
            this.dtp_FechaDestino.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_FechaDestino.Location = new System.Drawing.Point(108, 157);
            this.dtp_FechaDestino.Name = "dtp_FechaDestino";
            this.dtp_FechaDestino.Size = new System.Drawing.Size(101, 20);
            this.dtp_FechaDestino.TabIndex = 11;
            // 
            // lbl_FechaDestino
            // 
            this.lbl_FechaDestino.AutoSize = true;
            this.lbl_FechaDestino.Location = new System.Drawing.Point(23, 163);
            this.lbl_FechaDestino.Name = "lbl_FechaDestino";
            this.lbl_FechaDestino.Size = new System.Drawing.Size(79, 13);
            this.lbl_FechaDestino.TabIndex = 10;
            this.lbl_FechaDestino.Text = "Fecha Destino:";
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(215, 126);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(88, 23);
            this.btn_Modificar.TabIndex = 9;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha Inicio:";
            // 
            // dtp_FechaInicio
            // 
            this.dtp_FechaInicio.CustomFormat = "dd/MM/yyyy";
            this.dtp_FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_FechaInicio.Location = new System.Drawing.Point(108, 126);
            this.dtp_FechaInicio.Name = "dtp_FechaInicio";
            this.dtp_FechaInicio.Size = new System.Drawing.Size(101, 20);
            this.dtp_FechaInicio.TabIndex = 7;
            // 
            // lbl_nombrecliente
            // 
            this.lbl_nombrecliente.AutoSize = true;
            this.lbl_nombrecliente.Location = new System.Drawing.Point(108, 78);
            this.lbl_nombrecliente.Name = "lbl_nombrecliente";
            this.lbl_nombrecliente.Size = new System.Drawing.Size(70, 13);
            this.lbl_nombrecliente.TabIndex = 6;
            this.lbl_nombrecliente.Text = "Razón Social";
            // 
            // btn_CargarCliente
            // 
            this.btn_CargarCliente.Location = new System.Drawing.Point(215, 47);
            this.btn_CargarCliente.Name = "btn_CargarCliente";
            this.btn_CargarCliente.Size = new System.Drawing.Size(88, 23);
            this.btn_CargarCliente.TabIndex = 5;
            this.btn_CargarCliente.Text = "Cargar Cliente";
            this.btn_CargarCliente.UseVisualStyleBackColor = true;
            this.btn_CargarCliente.Click += new System.EventHandler(this.btn_CargarCliente_Click);
            // 
            // lbl_id_cliente
            // 
            this.lbl_id_cliente.Location = new System.Drawing.Point(108, 47);
            this.lbl_id_cliente.MaxLength = 10;
            this.lbl_id_cliente.Name = "lbl_id_cliente";
            this.lbl_id_cliente.Size = new System.Drawing.Size(91, 20);
            this.lbl_id_cliente.TabIndex = 4;
            // 
            // lbl_run
            // 
            this.lbl_run.AutoSize = true;
            this.lbl_run.Location = new System.Drawing.Point(108, 102);
            this.lbl_run.Name = "lbl_run";
            this.lbl_run.Size = new System.Drawing.Size(64, 13);
            this.lbl_run.TabIndex = 3;
            this.lbl_run.Text = "12345678-9";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "RUN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 76);
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
            this.ClientSize = new System.Drawing.Size(409, 233);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(425, 272);
            this.MinimumSize = new System.Drawing.Size(425, 272);
            this.Name = "frmCambioFecha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Fecha";
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
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.DateTimePicker dtp_FechaDestino;
        private System.Windows.Forms.Label lbl_FechaDestino;
    }
}