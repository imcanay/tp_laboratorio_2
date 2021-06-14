
namespace frmFabrica
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
            this.components = new System.ComponentModel.Container();
            this.cmbTipoMueble = new System.Windows.Forms.ComboBox();
            this.btnAgregarMueble = new System.Windows.Forms.Button();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.fabricaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txbxNombre = new System.Windows.Forms.TextBox();
            this.lblMaterialSecundario = new System.Windows.Forms.Label();
            this.cmbMaterialSecundario = new System.Windows.Forms.ComboBox();
            this.muebleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.muebleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fabricaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fabricaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muebleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muebleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipoMueble
            // 
            this.cmbTipoMueble.FormattingEnabled = true;
            this.cmbTipoMueble.Location = new System.Drawing.Point(9, 85);
            this.cmbTipoMueble.Name = "cmbTipoMueble";
            this.cmbTipoMueble.Size = new System.Drawing.Size(212, 21);
            this.cmbTipoMueble.TabIndex = 0;
            this.cmbTipoMueble.SelectedIndexChanged += new System.EventHandler(this.cmbTipoMueble_SelectedIndexChanged);
            // 
            // btnAgregarMueble
            // 
            this.btnAgregarMueble.Location = new System.Drawing.Point(54, 218);
            this.btnAgregarMueble.Name = "btnAgregarMueble";
            this.btnAgregarMueble.Size = new System.Drawing.Size(114, 52);
            this.btnAgregarMueble.TabIndex = 1;
            this.btnAgregarMueble.Text = "Agregar";
            this.btnAgregarMueble.UseVisualStyleBackColor = true;
            this.btnAgregarMueble.Click += new System.EventHandler(this.btnAgregarMueble_Click);
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.DataSource = this.fabricaBindingSource1;
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(9, 125);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(212, 21);
            this.cmbMaterial.TabIndex = 3;
            // 
            // fabricaBindingSource1
            // 
            this.fabricaBindingSource1.DataSource = typeof(Entidades.Fabrica);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo de Mueble";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Material de la Base";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(9, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(99, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre del Mueble";
            // 
            // txbxNombre
            // 
            this.txbxNombre.Location = new System.Drawing.Point(9, 43);
            this.txbxNombre.Name = "txbxNombre";
            this.txbxNombre.Size = new System.Drawing.Size(215, 20);
            this.txbxNombre.TabIndex = 7;
            // 
            // lblMaterialSecundario
            // 
            this.lblMaterialSecundario.AutoSize = true;
            this.lblMaterialSecundario.Location = new System.Drawing.Point(12, 149);
            this.lblMaterialSecundario.Name = "lblMaterialSecundario";
            this.lblMaterialSecundario.Size = new System.Drawing.Size(44, 13);
            this.lblMaterialSecundario.TabIndex = 8;
            this.lblMaterialSecundario.Text = "Material";
            // 
            // cmbMaterialSecundario
            // 
            this.cmbMaterialSecundario.FormattingEnabled = true;
            this.cmbMaterialSecundario.Location = new System.Drawing.Point(9, 165);
            this.cmbMaterialSecundario.Name = "cmbMaterialSecundario";
            this.cmbMaterialSecundario.Size = new System.Drawing.Size(212, 21);
            this.cmbMaterialSecundario.TabIndex = 9;
            // 
            // muebleBindingSource1
            // 
            this.muebleBindingSource1.DataSource = typeof(Entidades.Mueble);
            // 
            // muebleBindingSource
            // 
            this.muebleBindingSource.DataSource = typeof(Entidades.Mueble);
            // 
            // fabricaBindingSource
            // 
            this.fabricaBindingSource.DataSource = typeof(Entidades.Fabrica);
            // 
            // frmAgregarMueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(236, 280);
            this.Controls.Add(this.cmbMaterialSecundario);
            this.Controls.Add(this.lblMaterialSecundario);
            this.Controls.Add(this.txbxNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.btnAgregarMueble);
            this.Controls.Add(this.cmbTipoMueble);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarMueble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar mueble";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAgregarMueble_FormClosing);
            this.Load += new System.EventHandler(this.frmAgregarMueble_Load);
            this.MdiChildActivate += new System.EventHandler(this.frmAgregarMueble_MdiChildActivate);
            ((System.ComponentModel.ISupportInitialize)(this.fabricaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muebleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muebleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoMueble;
        private System.Windows.Forms.Button btnAgregarMueble;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource muebleBindingSource;
        private System.Windows.Forms.BindingSource muebleBindingSource1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txbxNombre;
        private System.Windows.Forms.Label lblMaterialSecundario;
        private System.Windows.Forms.ComboBox cmbMaterialSecundario;
        private System.Windows.Forms.BindingSource fabricaBindingSource1;
        private System.Windows.Forms.BindingSource fabricaBindingSource;
    }
}