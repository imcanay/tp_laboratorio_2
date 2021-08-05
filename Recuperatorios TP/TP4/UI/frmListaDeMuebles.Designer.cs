
namespace UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaDeMuebles));
            this.rtbxListaDeMuebles = new System.Windows.Forms.RichTextBox();
            this.btnGuardar_Xml = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbxListaDeMuebles
            // 
            this.rtbxListaDeMuebles.Font = new System.Drawing.Font("Neo Sans", 8.249999F, System.Drawing.FontStyle.Bold);
            this.rtbxListaDeMuebles.Location = new System.Drawing.Point(22, 21);
            this.rtbxListaDeMuebles.Name = "rtbxListaDeMuebles";
            this.rtbxListaDeMuebles.Size = new System.Drawing.Size(379, 283);
            this.rtbxListaDeMuebles.TabIndex = 1;
            this.rtbxListaDeMuebles.Text = "";
            // 
            // btnGuardar_Xml
            // 
            this.btnGuardar_Xml.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGuardar_Xml.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnGuardar_Xml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar_Xml.Font = new System.Drawing.Font("Neo Sans", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar_Xml.ForeColor = System.Drawing.Color.Ivory;
            this.btnGuardar_Xml.Location = new System.Drawing.Point(22, 310);
            this.btnGuardar_Xml.Name = "btnGuardar_Xml";
            this.btnGuardar_Xml.Size = new System.Drawing.Size(125, 32);
            this.btnGuardar_Xml.TabIndex = 6;
            this.btnGuardar_Xml.Text = "Generar Log.xml";
            this.btnGuardar_Xml.UseVisualStyleBackColor = false;
            this.btnGuardar_Xml.Click += new System.EventHandler(this.btnGuardar_Xml_Click);
            // 
            // frmListaDeMuebles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(455, 380);
            this.Controls.Add(this.btnGuardar_Xml);
            this.Controls.Add(this.rtbxListaDeMuebles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListaDeMuebles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de muebles";
            this.Load += new System.EventHandler(this.frmListaDeMuebles_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbxListaDeMuebles;
        private System.Windows.Forms.Button btnGuardar_Xml;
    }
}