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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtp_FechaDestino = new System.Windows.Forms.Label();
            this.dtp_FechaInicio = new System.Windows.Forms.Label();
            this.cbx_id_periodo = new System.Windows.Forms.ComboBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.lbl_FechaDestino = new System.Windows.Forms.Label();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtp_FechaDestinoTermino = new System.Windows.Forms.Label();
            this.lbl_FechaDestinoTermino = new System.Windows.Forms.Label();
            this.btn_GuardarTermino = new System.Windows.Forms.Button();
            this.dtp_FechaTermino = new System.Windows.Forms.Label();
            this.btn_ModificarTermino = new System.Windows.Forms.Button();
            this.cbx_id_periodoTermino = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.lbl_nombrecliente = new System.Windows.Forms.Label();
            this.btn_CargarCliente = new System.Windows.Forms.Button();
            this.lbl_id_cliente = new System.Windows.Forms.TextBox();
            this.lbl_run = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btn_Limpiar);
            this.groupBox1.Controls.Add(this.lbl_nombrecliente);
            this.groupBox1.Controls.Add(this.btn_CargarCliente);
            this.groupBox1.Controls.Add(this.lbl_id_cliente);
            this.groupBox1.Controls.Add(this.lbl_run);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 330);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dtp_FechaDestino);
            this.panel2.Controls.Add(this.dtp_FechaInicio);
            this.panel2.Controls.Add(this.cbx_id_periodo);
            this.panel2.Controls.Add(this.btn_Guardar);
            this.panel2.Controls.Add(this.lbl_FechaDestino);
            this.panel2.Controls.Add(this.btn_Modificar);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(6, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 83);
            this.panel2.TabIndex = 16;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dtp_FechaDestino
            // 
            this.dtp_FechaDestino.AutoSize = true;
            this.dtp_FechaDestino.Location = new System.Drawing.Point(82, 56);
            this.dtp_FechaDestino.Name = "dtp_FechaDestino";
            this.dtp_FechaDestino.Size = new System.Drawing.Size(71, 13);
            this.dtp_FechaDestino.TabIndex = 28;
            this.dtp_FechaDestino.Text = "No Habilitada";
            // 
            // dtp_FechaInicio
            // 
            this.dtp_FechaInicio.AutoSize = true;
            this.dtp_FechaInicio.Location = new System.Drawing.Point(82, 16);
            this.dtp_FechaInicio.Name = "dtp_FechaInicio";
            this.dtp_FechaInicio.Size = new System.Drawing.Size(65, 13);
            this.dtp_FechaInicio.TabIndex = 27;
            this.dtp_FechaInicio.Text = "Fecha Inicio";
            // 
            // cbx_id_periodo
            // 
            this.cbx_id_periodo.FormattingEnabled = true;
            this.cbx_id_periodo.Location = new System.Drawing.Point(173, 53);
            this.cbx_id_periodo.Name = "cbx_id_periodo";
            this.cbx_id_periodo.Size = new System.Drawing.Size(88, 21);
            this.cbx_id_periodo.TabIndex = 26;
            this.cbx_id_periodo.SelectedIndexChanged += new System.EventHandler(this.cbx_id_periodo_SelectedIndexChanged);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Image = global::ControlDosimetro.Properties.Resources.save_32;
            this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Guardar.Location = new System.Drawing.Point(278, 16);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(88, 35);
            this.btn_Guardar.TabIndex = 25;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // lbl_FechaDestino
            // 
            this.lbl_FechaDestino.AutoSize = true;
            this.lbl_FechaDestino.Location = new System.Drawing.Point(3, 56);
            this.lbl_FechaDestino.Name = "lbl_FechaDestino";
            this.lbl_FechaDestino.Size = new System.Drawing.Size(79, 13);
            this.lbl_FechaDestino.TabIndex = 24;
            this.lbl_FechaDestino.Text = "Fecha Destino:";
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Image = global::ControlDosimetro.Properties.Resources.delete_32;
            this.btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Modificar.Location = new System.Drawing.Point(173, 5);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(88, 35);
            this.btn_Modificar.TabIndex = 23;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Fecha Inicio:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dtp_FechaDestinoTermino);
            this.panel1.Controls.Add(this.lbl_FechaDestinoTermino);
            this.panel1.Controls.Add(this.btn_GuardarTermino);
            this.panel1.Controls.Add(this.dtp_FechaTermino);
            this.panel1.Controls.Add(this.btn_ModificarTermino);
            this.panel1.Controls.Add(this.cbx_id_periodoTermino);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(6, 238);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 81);
            this.panel1.TabIndex = 15;
            // 
            // dtp_FechaDestinoTermino
            // 
            this.dtp_FechaDestinoTermino.AutoSize = true;
            this.dtp_FechaDestinoTermino.Location = new System.Drawing.Point(82, 55);
            this.dtp_FechaDestinoTermino.Name = "dtp_FechaDestinoTermino";
            this.dtp_FechaDestinoTermino.Size = new System.Drawing.Size(43, 13);
            this.dtp_FechaDestinoTermino.TabIndex = 30;
            this.dtp_FechaDestinoTermino.Text = "Destino";
            // 
            // lbl_FechaDestinoTermino
            // 
            this.lbl_FechaDestinoTermino.AutoSize = true;
            this.lbl_FechaDestinoTermino.Location = new System.Drawing.Point(3, 55);
            this.lbl_FechaDestinoTermino.Name = "lbl_FechaDestinoTermino";
            this.lbl_FechaDestinoTermino.Size = new System.Drawing.Size(79, 13);
            this.lbl_FechaDestinoTermino.TabIndex = 29;
            this.lbl_FechaDestinoTermino.Text = "Fecha Destino:";
            // 
            // btn_GuardarTermino
            // 
            this.btn_GuardarTermino.Image = global::ControlDosimetro.Properties.Resources.save_32;
            this.btn_GuardarTermino.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GuardarTermino.Location = new System.Drawing.Point(278, 15);
            this.btn_GuardarTermino.Name = "btn_GuardarTermino";
            this.btn_GuardarTermino.Size = new System.Drawing.Size(88, 35);
            this.btn_GuardarTermino.TabIndex = 28;
            this.btn_GuardarTermino.Text = "Guardar";
            this.btn_GuardarTermino.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_GuardarTermino.UseVisualStyleBackColor = true;
            this.btn_GuardarTermino.Click += new System.EventHandler(this.btn_GuardarTermino_Click);
            // 
            // dtp_FechaTermino
            // 
            this.dtp_FechaTermino.AutoSize = true;
            this.dtp_FechaTermino.Location = new System.Drawing.Point(82, 15);
            this.dtp_FechaTermino.Name = "dtp_FechaTermino";
            this.dtp_FechaTermino.Size = new System.Drawing.Size(78, 13);
            this.dtp_FechaTermino.TabIndex = 27;
            this.dtp_FechaTermino.Text = "Fecha Termino";
            // 
            // btn_ModificarTermino
            // 
            this.btn_ModificarTermino.Image = global::ControlDosimetro.Properties.Resources.delete_32;
            this.btn_ModificarTermino.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ModificarTermino.Location = new System.Drawing.Point(173, 4);
            this.btn_ModificarTermino.Name = "btn_ModificarTermino";
            this.btn_ModificarTermino.Size = new System.Drawing.Size(88, 35);
            this.btn_ModificarTermino.TabIndex = 26;
            this.btn_ModificarTermino.Text = "Modificar";
            this.btn_ModificarTermino.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ModificarTermino.UseVisualStyleBackColor = true;
            this.btn_ModificarTermino.Click += new System.EventHandler(this.btn_ModificarTermino_Click);
            // 
            // cbx_id_periodoTermino
            // 
            this.cbx_id_periodoTermino.FormattingEnabled = true;
            this.cbx_id_periodoTermino.Location = new System.Drawing.Point(173, 52);
            this.cbx_id_periodoTermino.Name = "cbx_id_periodoTermino";
            this.cbx_id_periodoTermino.Size = new System.Drawing.Size(90, 21);
            this.cbx_id_periodoTermino.TabIndex = 25;
            this.cbx_id_periodoTermino.SelectedIndexChanged += new System.EventHandler(this.cbx_id_periodoTermino_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Fecha Término:";
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Image = global::ControlDosimetro.Properties.Resources.Limpiar;
            this.btn_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Limpiar.Location = new System.Drawing.Point(286, 33);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(88, 35);
            this.btn_Limpiar.TabIndex = 14;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // lbl_nombrecliente
            // 
            this.lbl_nombrecliente.AutoSize = true;
            this.lbl_nombrecliente.Location = new System.Drawing.Point(90, 84);
            this.lbl_nombrecliente.Name = "lbl_nombrecliente";
            this.lbl_nombrecliente.Size = new System.Drawing.Size(70, 13);
            this.lbl_nombrecliente.TabIndex = 6;
            this.lbl_nombrecliente.Text = "Razón Social";
            // 
            // btn_CargarCliente
            // 
            this.btn_CargarCliente.Image = global::ControlDosimetro.Properties.Resources.Buscar;
            this.btn_CargarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CargarCliente.Location = new System.Drawing.Point(181, 33);
            this.btn_CargarCliente.Name = "btn_CargarCliente";
            this.btn_CargarCliente.Size = new System.Drawing.Size(88, 35);
            this.btn_CargarCliente.TabIndex = 5;
            this.btn_CargarCliente.Text = "Buscar";
            this.btn_CargarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CargarCliente.UseVisualStyleBackColor = true;
            this.btn_CargarCliente.Click += new System.EventHandler(this.btn_CargarCliente_Click);
            // 
            // lbl_id_cliente
            // 
            this.lbl_id_cliente.Location = new System.Drawing.Point(93, 41);
            this.lbl_id_cliente.MaxLength = 10;
            this.lbl_id_cliente.Name = "lbl_id_cliente";
            this.lbl_id_cliente.Size = new System.Drawing.Size(62, 20);
            this.lbl_id_cliente.TabIndex = 4;
            this.lbl_id_cliente.TextChanged += new System.EventHandler(this.lbl_id_cliente_TextChanged);
            // 
            // lbl_run
            // 
            this.lbl_run.AutoSize = true;
            this.lbl_run.Location = new System.Drawing.Point(90, 124);
            this.lbl_run.Name = "lbl_run";
            this.lbl_run.Size = new System.Drawing.Size(64, 13);
            this.lbl_run.TabIndex = 3;
            this.lbl_run.Text = "12345678-9";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "RUT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N° Cliente:";
            // 
            // frmCambioFecha
            // 
            this.ClientSize = new System.Drawing.Size(409, 341);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(425, 380);
            this.MinimumSize = new System.Drawing.Size(425, 380);
            this.Name = "frmCambioFecha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Fecha";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label dtp_FechaDestino;
        private System.Windows.Forms.Label dtp_FechaInicio;
        private System.Windows.Forms.ComboBox cbx_id_periodo;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label lbl_FechaDestino;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label dtp_FechaDestinoTermino;
        private System.Windows.Forms.Label lbl_FechaDestinoTermino;
        private System.Windows.Forms.Button btn_GuardarTermino;
        private System.Windows.Forms.Label dtp_FechaTermino;
        private System.Windows.Forms.Button btn_ModificarTermino;
        private System.Windows.Forms.ComboBox cbx_id_periodoTermino;
        private System.Windows.Forms.Label label5;
    }
}