﻿namespace ControlDosimetro
{
    partial class frmimprimeDocFilmico
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
			this.lbl_NDocumento = new System.Windows.Forms.TextBox();
			this.btnimprimir = new System.Windows.Forms.Button();
			this.Btn_cerrar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "N° Documento";
			// 
			// lbl_NDocumento
			// 
			this.lbl_NDocumento.Location = new System.Drawing.Point(95, 24);
			this.lbl_NDocumento.Name = "lbl_NDocumento";
			this.lbl_NDocumento.Size = new System.Drawing.Size(100, 20);
			this.lbl_NDocumento.TabIndex = 1;
			// 
			// btnimprimir
			// 
			this.btnimprimir.Location = new System.Drawing.Point(149, 63);
			this.btnimprimir.Name = "btnimprimir";
			this.btnimprimir.Size = new System.Drawing.Size(64, 23);
			this.btnimprimir.TabIndex = 2;
			this.btnimprimir.Text = "Imprimir";
			this.btnimprimir.UseVisualStyleBackColor = true;
			this.btnimprimir.Click += new System.EventHandler(this.button1_Click);
			// 
			// Btn_cerrar
			// 
			this.Btn_cerrar.Location = new System.Drawing.Point(219, 63);
			this.Btn_cerrar.Name = "Btn_cerrar";
			this.Btn_cerrar.Size = new System.Drawing.Size(63, 23);
			this.Btn_cerrar.TabIndex = 3;
			this.Btn_cerrar.Text = "Cerrar";
			this.Btn_cerrar.UseVisualStyleBackColor = true;
			this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
			// 
			// frmimprimeDocFilmico
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(289, 98);
			this.ControlBox = false;
			this.Controls.Add(this.Btn_cerrar);
			this.Controls.Add(this.btnimprimir);
			this.Controls.Add(this.lbl_NDocumento);
			this.Controls.Add(this.label1);
			this.Location = new System.Drawing.Point(0, 80);
			this.Name = "frmimprimeDocFilmico";
			this.Text = "Imprimir Documentos Filmicos";
			this.Load += new System.EventHandler(this.frmimprimeDocFilmico_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lbl_NDocumento;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button Btn_cerrar;
    }
}