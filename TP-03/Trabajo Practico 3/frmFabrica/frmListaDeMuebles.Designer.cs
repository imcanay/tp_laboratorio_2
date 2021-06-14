
namespace frmFabrica
{
    partial class frmListaDeMuebles
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
            this.rtbxListaDeMuebles = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbxListaDeMuebles
            // 
            this.rtbxListaDeMuebles.Location = new System.Drawing.Point(12, 41);
            this.rtbxListaDeMuebles.Name = "rtbxListaDeMuebles";
            this.rtbxListaDeMuebles.Size = new System.Drawing.Size(251, 357);
            this.rtbxListaDeMuebles.TabIndex = 0;
            this.rtbxListaDeMuebles.Text = "";
            // 
            // frmListaDeMuebles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 412);
            this.Controls.Add(this.rtbxListaDeMuebles);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListaDeMuebles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lista de Muebles";
            this.Load += new System.EventHandler(this.frmListaDeMuebles_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbxListaDeMuebles;
    }
}