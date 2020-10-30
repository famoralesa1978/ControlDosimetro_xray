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
			this.tbl_Cliente = new System.Windows.Forms.GroupBox();
			this.SuspendLayout();
			// 
			// tbl_Cliente
			// 
			this.tbl_Cliente.Location = new System.Drawing.Point(0, 0);
			this.tbl_Cliente.Name = "tbl_Cliente";
			this.tbl_Cliente.Size = new System.Drawing.Size(521, 385);
			this.tbl_Cliente.TabIndex = 0;
			this.tbl_Cliente.TabStop = false;
			this.tbl_Cliente.Text = "Datos";
			// 
			// frmCambiarFechaControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(521, 397);
			this.Controls.Add(this.tbl_Cliente);
			this.Name = "frmCambiarFechaControl";
			this.Text = "frmCambiarFechaControl";
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox tbl_Cliente;
    }
}