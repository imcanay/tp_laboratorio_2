
namespace UI
{
    partial class FormAlimentar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlimentar));
            this.rtbxAlimentacion = new System.Windows.Forms.RichTextBox();
            this.btnAlimentar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbxAlimentacion
            // 
            this.rtbxAlimentacion.Location = new System.Drawing.Point(28, 19);
            this.rtbxAlimentacion.Name = "rtbxAlimentacion";
            this.rtbxAlimentacion.Size = new System.Drawing.Size(261, 196);
            this.rtbxAlimentacion.TabIndex = 0;
            this.rtbxAlimentacion.Text = "";
            // 
            // btnAlimentar
            // 
            this.btnAlimentar.Location = new System.Drawing.Point(84, 221);
            this.btnAlimentar.Name = "btnAlimentar";
            this.btnAlimentar.Size = new System.Drawing.Size(110, 31);
            this.btnAlimentar.TabIndex = 1;
            this.btnAlimentar.Text = "Alimentar Dragones";
            this.btnAlimentar.UseVisualStyleBackColor = true;
            this.btnAlimentar.Click += new System.EventHandler(this.btnAlimentar_Click);
            // 
            // FormAlimentar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 257);
            this.Controls.Add(this.btnAlimentar);
            this.Controls.Add(this.rtbxAlimentacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAlimentar";
            this.Text = "Alimentadora de Dragones";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbxAlimentacion;
        private System.Windows.Forms.Button btnAlimentar;
    }
}