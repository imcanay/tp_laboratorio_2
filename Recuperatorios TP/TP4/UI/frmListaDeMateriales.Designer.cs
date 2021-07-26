
namespace UI
{
    partial class frmListaDeMateriales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaDeMateriales));
            this.rtbxListaDeMateriales = new System.Windows.Forms.RichTextBox();
            this.btnGuardar_Texto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbxListaDeMateriales
            // 
            this.rtbxListaDeMateriales.Font = new System.Drawing.Font("Neo Sans", 8.249999F, System.Drawing.FontStyle.Bold);
            this.rtbxListaDeMateriales.Location = new System.Drawing.Point(12, 12);
            this.rtbxListaDeMateriales.Name = "rtbxListaDeMateriales";
            this.rtbxListaDeMateriales.Size = new System.Drawing.Size(296, 272);
            this.rtbxListaDeMateriales.TabIndex = 2;
            this.rtbxListaDeMateriales.Text = "";
            // 
            // btnGuardar_Texto
            // 
            this.btnGuardar_Texto.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGuardar_Texto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGuardar_Texto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar_Texto.Font = new System.Drawing.Font("Neo Sans", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar_Texto.ForeColor = System.Drawing.Color.LightGreen;
            this.btnGuardar_Texto.Location = new System.Drawing.Point(12, 290);
            this.btnGuardar_Texto.Name = "btnGuardar_Texto";
            this.btnGuardar_Texto.Size = new System.Drawing.Size(125, 32);
            this.btnGuardar_Texto.TabIndex = 7;
            this.btnGuardar_Texto.Text = "Generar Log.txt";
            this.btnGuardar_Texto.UseVisualStyleBackColor = false;
            this.btnGuardar_Texto.Click += new System.EventHandler(this.btnGuardar_Texto_Click);
            // 
            // frmListaDeMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(423, 359);
            this.Controls.Add(this.btnGuardar_Texto);
            this.Controls.Add(this.rtbxListaDeMateriales);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListaDeMateriales";
            this.Text = "frmListaDeMateriales";
            this.Load += new System.EventHandler(this.frmListaDeMateriales_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbxListaDeMateriales;
        private System.Windows.Forms.Button btnGuardar_Texto;
    }
}