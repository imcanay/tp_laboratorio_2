
namespace UI
{
    partial class frmDiseñar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiseñar));
            this.lblColorSecundario = new System.Windows.Forms.Label();
            this.lblColorBase = new System.Windows.Forms.Label();
            this.cmbxColorSecundario = new System.Windows.Forms.ComboBox();
            this.cmbxColorBase = new System.Windows.Forms.ComboBox();
            this.btnPintar = new System.Windows.Forms.Button();
            this.lblLista = new System.Windows.Forms.Label();
            this.lsbxListaMueblesAPintar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblColorSecundario
            // 
            this.lblColorSecundario.AutoSize = true;
            this.lblColorSecundario.Font = new System.Drawing.Font("Neo Sans", 8.249999F, System.Drawing.FontStyle.Bold);
            this.lblColorSecundario.ForeColor = System.Drawing.Color.LightGreen;
            this.lblColorSecundario.Location = new System.Drawing.Point(214, 105);
            this.lblColorSecundario.Name = "lblColorSecundario";
            this.lblColorSecundario.Size = new System.Drawing.Size(105, 14);
            this.lblColorSecundario.TabIndex = 20;
            this.lblColorSecundario.Text = "Color Secundario";
            // 
            // lblColorBase
            // 
            this.lblColorBase.AutoSize = true;
            this.lblColorBase.Font = new System.Drawing.Font("Neo Sans", 8.249999F, System.Drawing.FontStyle.Bold);
            this.lblColorBase.ForeColor = System.Drawing.Color.LightGreen;
            this.lblColorBase.Location = new System.Drawing.Point(219, 45);
            this.lblColorBase.Name = "lblColorBase";
            this.lblColorBase.Size = new System.Drawing.Size(101, 14);
            this.lblColorBase.TabIndex = 19;
            this.lblColorBase.Text = "Color de la base";
            // 
            // cmbxColorSecundario
            // 
            this.cmbxColorSecundario.Font = new System.Drawing.Font("Neo Sans", 8.249999F, System.Drawing.FontStyle.Bold);
            this.cmbxColorSecundario.ForeColor = System.Drawing.Color.LightGreen;
            this.cmbxColorSecundario.FormattingEnabled = true;
            this.cmbxColorSecundario.Location = new System.Drawing.Point(210, 121);
            this.cmbxColorSecundario.Name = "cmbxColorSecundario";
            this.cmbxColorSecundario.Size = new System.Drawing.Size(207, 22);
            this.cmbxColorSecundario.TabIndex = 18;
            // 
            // cmbxColorBase
            // 
            this.cmbxColorBase.Font = new System.Drawing.Font("Neo Sans", 8.249999F, System.Drawing.FontStyle.Bold);
            this.cmbxColorBase.ForeColor = System.Drawing.Color.LightGreen;
            this.cmbxColorBase.FormattingEnabled = true;
            this.cmbxColorBase.Location = new System.Drawing.Point(210, 62);
            this.cmbxColorBase.Name = "cmbxColorBase";
            this.cmbxColorBase.Size = new System.Drawing.Size(207, 22);
            this.cmbxColorBase.TabIndex = 17;
            // 
            // btnPintar
            // 
            this.btnPintar.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnPintar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPintar.Font = new System.Drawing.Font("Neo Sans", 8.249999F, System.Drawing.FontStyle.Bold);
            this.btnPintar.ForeColor = System.Drawing.Color.LightGreen;
            this.btnPintar.Location = new System.Drawing.Point(257, 160);
            this.btnPintar.Name = "btnPintar";
            this.btnPintar.Size = new System.Drawing.Size(96, 47);
            this.btnPintar.TabIndex = 16;
            this.btnPintar.Text = "Diseñar";
            this.btnPintar.UseVisualStyleBackColor = true;
            this.btnPintar.Click += new System.EventHandler(this.btnPintar_Click);
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Font = new System.Drawing.Font("Neo Sans", 8.249999F, System.Drawing.FontStyle.Bold);
            this.lblLista.ForeColor = System.Drawing.Color.LightGreen;
            this.lblLista.Location = new System.Drawing.Point(12, 17);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(119, 14);
            this.lblLista.TabIndex = 15;
            this.lblLista.Text = "Listado de Muebles";
            // 
            // lsbxListaMueblesAPintar
            // 
            this.lsbxListaMueblesAPintar.Font = new System.Drawing.Font("Neo Sans", 8.249999F, System.Drawing.FontStyle.Bold);
            this.lsbxListaMueblesAPintar.ForeColor = System.Drawing.Color.Black;
            this.lsbxListaMueblesAPintar.FormattingEnabled = true;
            this.lsbxListaMueblesAPintar.ItemHeight = 14;
            this.lsbxListaMueblesAPintar.Location = new System.Drawing.Point(11, 45);
            this.lsbxListaMueblesAPintar.Name = "lsbxListaMueblesAPintar";
            this.lsbxListaMueblesAPintar.Size = new System.Drawing.Size(193, 186);
            this.lsbxListaMueblesAPintar.TabIndex = 14;
            this.lsbxListaMueblesAPintar.SelectedIndexChanged += new System.EventHandler(this.lsbxListaMueblesAPintar_SelectedIndexChanged);
            // 
            // frmDiseñar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(429, 248);
            this.Controls.Add(this.lblColorSecundario);
            this.Controls.Add(this.lblColorBase);
            this.Controls.Add(this.cmbxColorSecundario);
            this.Controls.Add(this.cmbxColorBase);
            this.Controls.Add(this.btnPintar);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.lsbxListaMueblesAPintar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDiseñar";
            this.Text = "frmDiseñar";
            this.Load += new System.EventHandler(this.frmDiseñar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblColorSecundario;
        private System.Windows.Forms.Label lblColorBase;
        private System.Windows.Forms.ComboBox cmbxColorSecundario;
        private System.Windows.Forms.ComboBox cmbxColorBase;
        private System.Windows.Forms.Button btnPintar;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.ListBox lsbxListaMueblesAPintar;
    }
}