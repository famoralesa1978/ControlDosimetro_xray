namespace ControlDosimetro
{
    partial class frmParametroMant
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
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_Grabar = new System.Windows.Forms.Button();
            this.cbx_EstadoId = new System.Windows.Forms.ComboBox();
            this.cbx_Estado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Orden = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.btn_Cerrar);
            this.groupBox1.Controls.Add(this.btn_Grabar);
            this.groupBox1.Controls.Add(this.cbx_EstadoId);
            this.groupBox1.Controls.Add(this.cbx_Estado);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_Orden);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Descripcion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_ID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(209, 138);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cerrar.TabIndex = 10;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_Grabar
            // 
            this.btn_Grabar.Location = new System.Drawing.Point(77, 138);
            this.btn_Grabar.Name = "btn_Grabar";
            this.btn_Grabar.Size = new System.Drawing.Size(75, 23);
            this.btn_Grabar.TabIndex = 9;
            this.btn_Grabar.Text = "Grabar";
            this.btn_Grabar.UseVisualStyleBackColor = true;
            this.btn_Grabar.Click += new System.EventHandler(this.btn_Grabar_Click);
            // 
            // cbx_EstadoId
            // 
            this.cbx_EstadoId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_EstadoId.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbx_EstadoId.FormattingEnabled = true;
            this.cbx_EstadoId.Location = new System.Drawing.Point(225, 93);
            this.cbx_EstadoId.Name = "cbx_EstadoId";
            this.cbx_EstadoId.Size = new System.Drawing.Size(121, 21);
            this.cbx_EstadoId.TabIndex = 8;
            this.cbx_EstadoId.Visible = false;
            // 
            // cbx_Estado
            // 
            this.cbx_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Estado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbx_Estado.FormattingEnabled = true;
            this.cbx_Estado.Location = new System.Drawing.Point(98, 93);
            this.cbx_Estado.Name = "cbx_Estado";
            this.cbx_Estado.Size = new System.Drawing.Size(121, 21);
            this.cbx_Estado.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Estado";
            // 
            // txt_Orden
            // 
            this.txt_Orden.Location = new System.Drawing.Point(98, 66);
            this.txt_Orden.MaxLength = 2;
            this.txt_Orden.Name = "txt_Orden";
            this.txt_Orden.Size = new System.Drawing.Size(100, 20);
            this.txt_Orden.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Orden";
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(98, 40);
            this.txt_Descripcion.MaxLength = 50;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(260, 20);
            this.txt_Descripcion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(98, 12);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(66, 20);
            this.txt_ID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // frmParametroMant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 179);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmParametroMant";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Edicion Configuración Parametro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Orden;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_EstadoId;
        private System.Windows.Forms.ComboBox cbx_Estado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Grabar;
        private System.Windows.Forms.Button btn_Cerrar;
    }
}