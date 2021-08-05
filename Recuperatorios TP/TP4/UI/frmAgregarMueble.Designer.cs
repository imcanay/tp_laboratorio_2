
namespace UI
{
    partial class frmAgregarMueble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarMueble));
            this.cmbMaterialSecundario = new System.Windows.Forms.ComboBox();
            this.lblMaterialSecundario = new System.Windows.Forms.Label();
            this.txbxNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.btnAgregarMueble = new System.Windows.Forms.Button();
            this.cmbTipoMueble = new System.Windows.Forms.ComboBox();
            this.rtbxUltimoMueble = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbMaterialSecundario
            // 
            this.cmbMaterialSecundario.Font = new System.Drawing.Font("Neo Sans", 8.249999F, System.Drawing.FontStyle.Bold);
            this.cmbMaterialSecundario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbMaterialSecundario.FormattingEnabled = true;
            this.cmbMaterialSecundario.Location = new System.Drawing.Point(12, 170);
            this.cmbMaterialSecundario.Name = "cmbMaterialSecundario";
            this.cmbMaterialSecundario.Size = new System.Drawing.Size(212, 22);
            this.cmbMaterialSecundario.TabIndex = 4;
            // 
            // lblMaterialSecundario
            // 
            this.lblMaterialSecundario.AutoSize = true;
            this.lblMaterialSecundario.Font = new System.Drawing.Font("Neo Sans", 8.249999F, System.Drawing.FontStyle.Bold);
            this.lblMaterialSecundario.ForeColor = System.Drawing.Color.Ivory;
            this.lblMaterialSecundario.Location = new System.Drawing.Point(15, 154);
            this.lblMaterialSecundario.Name = "lblMaterialSecundario";
            this.lblMaterialSecundario.Size = new System.Drawing.Size(55, 14);
            this.lblMaterialSecundario.TabIndex = 17;
            this.lblMaterialSecundario.Text = "Material";
            // 
            // txbxNombre
            // 
            this.txbxNombre.Font = new System.Drawing.Font("Neo Sans", 8.249999F, System.Drawing.FontStyle.Bold);
            this.txbxNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbxNombre.Location = new System.Drawing.Point(12, 48);
            this.txbxNombre.Name = "txbxNombre";
            this.txbxNombre.Size = new System.Drawing.Size(215, 21);
            this.txbxNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Neo Sans", 8.249999F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.Ivory;
            this.lblNombre.Location = new System.Drawing.Point(12, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(118, 14);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Nombre del Mueble";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Neo Sans", 8.249999F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Ivory;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 14);
            this.label2.TabIndex = 14;
            this.label2.Text = "Material de la Base";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Neo Sans", 8.249999F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 14);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tipo de Mueble";
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.Font = new System.Drawing.Font("Neo Sans", 8.249999F, System.Drawing.FontStyle.Bold);
            this.cmbMaterial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(12, 130);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(212, 22);
            this.cmbMaterial.TabIndex = 3;
            // 
            // btnAgregarMueble
            // 
            this.btnAgregarMueble.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAgregarMueble.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnAgregarMueble.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMueble.Font = new System.Drawing.Font("Neo Sans", 8.249999F, System.Drawing.FontStyle.Bold);
            this.btnAgregarMueble.ForeColor = System.Drawing.Color.Ivory;
            this.btnAgregarMueble.Location = new System.Drawing.Point(57, 223);
            this.btnAgregarMueble.Name = "btnAgregarMueble";
            this.btnAgregarMueble.Size = new System.Drawing.Size(114, 52);
            this.btnAgregarMueble.TabIndex = 5;
            this.btnAgregarMueble.Text = "Agregar";
            this.btnAgregarMueble.UseVisualStyleBackColor = false;
            this.btnAgregarMueble.Click += new System.EventHandler(this.btnAgregarMueble_Click);
            // 
            // cmbTipoMueble
            // 
            this.cmbTipoMueble.Font = new System.Drawing.Font("Neo Sans", 8.249999F, System.Drawing.FontStyle.Bold);
            this.cmbTipoMueble.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbTipoMueble.FormattingEnabled = true;
            this.cmbTipoMueble.Location = new System.Drawing.Point(12, 90);
            this.cmbTipoMueble.Name = "cmbTipoMueble";
            this.cmbTipoMueble.Size = new System.Drawing.Size(212, 22);
            this.cmbTipoMueble.TabIndex = 2;
            this.cmbTipoMueble.SelectedIndexChanged += new System.EventHandler(this.cmbTipoMueble_SelectedIndexChanged);
            // 
            // rtbxUltimoMueble
            // 
            this.rtbxUltimoMueble.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtbxUltimoMueble.Location = new System.Drawing.Point(255, 53);
            this.rtbxUltimoMueble.Name = "rtbxUltimoMueble";
            this.rtbxUltimoMueble.ReadOnly = true;
            this.rtbxUltimoMueble.Size = new System.Drawing.Size(153, 138);
            this.rtbxUltimoMueble.TabIndex = 19;
            this.rtbxUltimoMueble.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Neo Sans", 8.249999F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Ivory;
            this.label3.Location = new System.Drawing.Point(252, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 14);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ultimo Mueble Creado";
            // 
            // frmAgregarMueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(425, 289);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbxUltimoMueble);
            this.Controls.Add(this.cmbMaterialSecundario);
            this.Controls.Add(this.lblMaterialSecundario);
            this.Controls.Add(this.txbxNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.btnAgregarMueble);
            this.Controls.Add(this.cmbTipoMueble);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarMueble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fabrica de muebles";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAgregarMueble_FormClosing);
            this.Load += new System.EventHandler(this.frmAgregarMueble_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMaterialSecundario;
        private System.Windows.Forms.Label lblMaterialSecundario;
        private System.Windows.Forms.TextBox txbxNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Button btnAgregarMueble;
        private System.Windows.Forms.ComboBox cmbTipoMueble;
        private System.Windows.Forms.RichTextBox rtbxUltimoMueble;
        private System.Windows.Forms.Label label3;
    }
}