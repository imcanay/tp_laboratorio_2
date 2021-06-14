
namespace frmFabrica
{
    partial class frmListaMateriales
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
            this.rtbxListaDeMateriales = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbxListaDeMateriales
            // 
            this.rtbxListaDeMateriales.Location = new System.Drawing.Point(12, 25);
            this.rtbxListaDeMateriales.Name = "rtbxListaDeMateriales";
            this.rtbxListaDeMateriales.Size = new System.Drawing.Size(251, 357);
            this.rtbxListaDeMateriales.TabIndex = 1;
            this.rtbxListaDeMateriales.Text = "";
            // 
            // frmListaMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 388);
            this.Controls.Add(this.rtbxListaDeMateriales);
            this.Name = "frmListaMateriales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lista de materiales";
            this.Load += new System.EventHandler(this.frmListaMateriales_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbxListaDeMateriales;
    }
}