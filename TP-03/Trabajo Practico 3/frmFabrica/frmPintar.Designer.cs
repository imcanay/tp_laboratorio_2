
namespace frmFabrica
{
    partial class frmPintar
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
            this.lsbxListaMueblesAPintar = new System.Windows.Forms.ListBox();
            this.lblLista = new System.Windows.Forms.Label();
            this.btnPintar = new System.Windows.Forms.Button();
            this.cmbxColorBase = new System.Windows.Forms.ComboBox();
            this.cmbxColorSecundario = new System.Windows.Forms.ComboBox();
            this.lblColorBase = new System.Windows.Forms.Label();
            this.lblColorSecundario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsbxListaMueblesAPintar
            // 
            this.lsbxListaMueblesAPintar.FormattingEnabled = true;
            this.lsbxListaMueblesAPintar.Location = new System.Drawing.Point(12, 46);
            this.lsbxListaMueblesAPintar.Name = "lsbxListaMueblesAPintar";
            this.lsbxListaMueblesAPintar.Size = new System.Drawing.Size(193, 186);
            this.lsbxListaMueblesAPintar.TabIndex = 1;
            this.lsbxListaMueblesAPintar.SelectedIndexChanged += new System.EventHandler(this.lsbxListaMueblesAPintar_SelectedIndexChanged);
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Location = new System.Drawing.Point(9, 18);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(99, 13);
            this.lblLista.TabIndex = 2;
            this.lblLista.Text = "Listado de Muebles";
            // 
            // btnPintar
            // 
            this.btnPintar.Location = new System.Drawing.Point(254, 161);
            this.btnPintar.Name = "btnPintar";
            this.btnPintar.Size = new System.Drawing.Size(96, 47);
            this.btnPintar.TabIndex = 3;
            this.btnPintar.Text = "Diseñar";
            this.btnPintar.UseVisualStyleBackColor = true;
            this.btnPintar.Click += new System.EventHandler(this.btnPintar_Click);
            // 
            // cmbxColorBase
            // 
            this.cmbxColorBase.FormattingEnabled = true;
            this.cmbxColorBase.Location = new System.Drawing.Point(207, 63);
            this.cmbxColorBase.Name = "cmbxColorBase";
            this.cmbxColorBase.Size = new System.Drawing.Size(207, 21);
            this.cmbxColorBase.TabIndex = 9;
            // 
            // cmbxColorSecundario
            // 
            this.cmbxColorSecundario.FormattingEnabled = true;
            this.cmbxColorSecundario.Location = new System.Drawing.Point(207, 122);
            this.cmbxColorSecundario.Name = "cmbxColorSecundario";
            this.cmbxColorSecundario.Size = new System.Drawing.Size(207, 21);
            this.cmbxColorSecundario.TabIndex = 10;
            // 
            // lblColorBase
            // 
            this.lblColorBase.AutoSize = true;
            this.lblColorBase.Location = new System.Drawing.Point(216, 46);
            this.lblColorBase.Name = "lblColorBase";
            this.lblColorBase.Size = new System.Drawing.Size(83, 13);
            this.lblColorBase.TabIndex = 12;
            this.lblColorBase.Text = "Color de la base";
            // 
            // lblColorSecundario
            // 
            this.lblColorSecundario.AutoSize = true;
            this.lblColorSecundario.Location = new System.Drawing.Point(211, 106);
            this.lblColorSecundario.Name = "lblColorSecundario";
            this.lblColorSecundario.Size = new System.Drawing.Size(88, 13);
            this.lblColorSecundario.TabIndex = 13;
            this.lblColorSecundario.Text = "Color Secundario";
            // 
            // frmPintar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 252);
            this.Controls.Add(this.lblColorSecundario);
            this.Controls.Add(this.lblColorBase);
            this.Controls.Add(this.cmbxColorSecundario);
            this.Controls.Add(this.cmbxColorBase);
            this.Controls.Add(this.btnPintar);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.lsbxListaMueblesAPintar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPintar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Diseñar mueble";
            this.Load += new System.EventHandler(this.frmPintar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbxListaMueblesAPintar;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.Button btnPintar;
        private System.Windows.Forms.ComboBox cmbxColorBase;
        private System.Windows.Forms.ComboBox cmbxColorSecundario;
        private System.Windows.Forms.Label lblColorBase;
        private System.Windows.Forms.Label lblColorSecundario;
    }
}