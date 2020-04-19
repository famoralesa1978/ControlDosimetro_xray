namespace ControlDosimetro
{
    partial class frmTipoDocumentoMant
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
            this.glo_TipoDocumentos = new System.Windows.Forms.GroupBox();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_Grabar = new System.Windows.Forms.Button();
            this.cbx_id_estado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_orden = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_detalle_tipo_documento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id_tipo_doc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.glo_TipoDocumentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // glo_TipoDocumentos
            // 
            this.glo_TipoDocumentos.AutoSize = true;
            this.glo_TipoDocumentos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.glo_TipoDocumentos.Controls.Add(this.btn_Cerrar);
            this.glo_TipoDocumentos.Controls.Add(this.btn_Grabar);
            this.glo_TipoDocumentos.Controls.Add(this.cbx_id_estado);
            this.glo_TipoDocumentos.Controls.Add(this.label4);
            this.glo_TipoDocumentos.Controls.Add(this.txt_orden);
            this.glo_TipoDocumentos.Controls.Add(this.label3);
            this.glo_TipoDocumentos.Controls.Add(this.txt_detalle_tipo_documento);
            this.glo_TipoDocumentos.Controls.Add(this.label2);
            this.glo_TipoDocumentos.Controls.Add(this.txt_id_tipo_doc);
            this.glo_TipoDocumentos.Controls.Add(this.label1);
            this.glo_TipoDocumentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glo_TipoDocumentos.Location = new System.Drawing.Point(0, 0);
            this.glo_TipoDocumentos.Margin = new System.Windows.Forms.Padding(2);
            this.glo_TipoDocumentos.Name = "glo_TipoDocumentos";
            this.glo_TipoDocumentos.Size = new System.Drawing.Size(378, 196);
            this.glo_TipoDocumentos.TabIndex = 2;
            this.glo_TipoDocumentos.TabStop = false;
            this.glo_TipoDocumentos.Text = "Datos";
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
            // cbx_id_estado
            // 
            this.cbx_id_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_id_estado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbx_id_estado.FormattingEnabled = true;
            this.cbx_id_estado.Location = new System.Drawing.Point(98, 93);
            this.cbx_id_estado.Name = "cbx_id_estado";
            this.cbx_id_estado.Size = new System.Drawing.Size(121, 21);
            this.cbx_id_estado.TabIndex = 7;
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
            // txt_orden
            // 
            this.txt_orden.Location = new System.Drawing.Point(98, 66);
            this.txt_orden.Name = "txt_orden";
            this.txt_orden.Size = new System.Drawing.Size(100, 20);
            this.txt_orden.TabIndex = 5;
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
            // txt_detalle_tipo_documento
            // 
            this.txt_detalle_tipo_documento.Location = new System.Drawing.Point(98, 40);
            this.txt_detalle_tipo_documento.MaxLength = 50;
            this.txt_detalle_tipo_documento.Name = "txt_detalle_tipo_documento";
            this.txt_detalle_tipo_documento.Size = new System.Drawing.Size(260, 20);
            this.txt_detalle_tipo_documento.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción";
            // 
            // txt_id_tipo_doc
            // 
            this.txt_id_tipo_doc.Enabled = false;
            this.txt_id_tipo_doc.Location = new System.Drawing.Point(98, 12);
            this.txt_id_tipo_doc.Name = "txt_id_tipo_doc";
            this.txt_id_tipo_doc.Size = new System.Drawing.Size(66, 20);
            this.txt_id_tipo_doc.TabIndex = 1;
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
            // frmTipoDocumentoMant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 196);
            this.Controls.Add(this.glo_TipoDocumentos);
            this.Name = "frmTipoDocumentoMant";
            this.Text = "Tipo Documento";
            this.glo_TipoDocumentos.ResumeLayout(false);
            this.glo_TipoDocumentos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox glo_TipoDocumentos;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_Grabar;
        private System.Windows.Forms.ComboBox cbx_id_estado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_orden;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_detalle_tipo_documento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id_tipo_doc;
        private System.Windows.Forms.Label label1;
    }
}