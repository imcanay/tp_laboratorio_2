
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
            this.btnGuardarXml = new System.Windows.Forms.Button();
            this.btnCargarXml = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbxListaDeMateriales
            // 
            this.rtbxListaDeMateriales.Font = new System.Drawing.Font("Neo Sans", 8.249999F, System.Drawing.FontStyle.Bold);
            this.rtbxListaDeMateriales.Location = new System.Drawing.Point(12, 12);
            this.rtbxListaDeMateriales.Name = "rtbxListaDeMateriales";
            this.rtbxListaDeMateriales.ReadOnly = true;
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
            this.btnGuardar_Texto.Size = new System.Drawing.Size(109, 32);
            this.btnGuardar_Texto.TabIndex = 7;
            this.btnGuardar_Texto.Text = "Generar Log.txt";
            this.btnGuardar_Texto.UseVisualStyleBackColor = false;
            this.btnGuardar_Texto.Click += new System.EventHandler(this.btnGuardar_Texto_Click);
            // 
            // btnGuardarXml
            // 
            this.btnGuardarXml.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGuardarXml.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGuardarXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarXml.Font = new System.Drawing.Font("Neo Sans", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarXml.ForeColor = System.Drawing.Color.LightGreen;
            this.btnGuardarXml.Location = new System.Drawing.Point(123, 290);
            this.btnGuardarXml.Name = "btnGuardarXml";
            this.btnGuardarXml.Size = new System.Drawing.Size(63, 32);
            this.btnGuardarXml.TabIndex = 8;
            this.btnGuardarXml.Text = "Guardar";
            this.btnGuardarXml.UseVisualStyleBackColor = false;
            this.btnGuardarXml.Click += new System.EventHandler(this.btnGuardarXml_Click);
            // 
            // btnCargarXml
            // 
            this.btnCargarXml.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCargarXml.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCargarXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarXml.Font = new System.Drawing.Font("Neo Sans", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarXml.ForeColor = System.Drawing.Color.LightGreen;
            this.btnCargarXml.Location = new System.Drawing.Point(192, 290);
            this.btnCargarXml.Name = "btnCargarXml";
            this.btnCargarXml.Size = new System.Drawing.Size(105, 32);
            this.btnCargarXml.TabIndex = 9;
            this.btnCargarXml.Text = "Cargar Archivo";
            this.btnCargarXml.UseVisualStyleBackColor = false;
            this.btnCargarXml.Click += new System.EventHandler(this.btnCargarXml_Click);
            // 
            // frmListaDeMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(423, 359);
            this.Controls.Add(this.btnCargarXml);
            this.Controls.Add(this.btnGuardarXml);
            this.Controls.Add(this.btnGuardar_Texto);
            this.Controls.Add(this.rtbxListaDeMateriales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListaDeMateriales";
            this.Text = "frmListaDeMateriales";
            this.Load += new System.EventHandler(this.frmListaDeMateriales_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbxListaDeMateriales;
        private System.Windows.Forms.Button btnGuardar_Texto;
        private System.Windows.Forms.Button btnGuardarXml;
        private System.Windows.Forms.Button btnCargarXml;
    }
}