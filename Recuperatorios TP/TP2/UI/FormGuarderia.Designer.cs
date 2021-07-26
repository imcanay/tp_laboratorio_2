
namespace UI
{
    partial class frmGuarderia
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuarderia));
            this.btnAgregarDragon = new System.Windows.Forms.Button();
            this.btnEstadoDeGuarderia = new System.Windows.Forms.Button();
            this.btnAlimentar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarDragon
            // 
            this.btnAgregarDragon.Location = new System.Drawing.Point(12, 22);
            this.btnAgregarDragon.Name = "btnAgregarDragon";
            this.btnAgregarDragon.Size = new System.Drawing.Size(117, 32);
            this.btnAgregarDragon.TabIndex = 0;
            this.btnAgregarDragon.Text = "Regristrar Dragon";
            this.btnAgregarDragon.UseVisualStyleBackColor = true;
            this.btnAgregarDragon.Click += new System.EventHandler(this.btnAgregarDragon_Click);
            // 
            // btnEstadoDeGuarderia
            // 
            this.btnEstadoDeGuarderia.Location = new System.Drawing.Point(12, 70);
            this.btnEstadoDeGuarderia.Name = "btnEstadoDeGuarderia";
            this.btnEstadoDeGuarderia.Size = new System.Drawing.Size(117, 32);
            this.btnEstadoDeGuarderia.TabIndex = 1;
            this.btnEstadoDeGuarderia.Text = "Ver Guarderia";
            this.btnEstadoDeGuarderia.UseVisualStyleBackColor = true;
            this.btnEstadoDeGuarderia.Click += new System.EventHandler(this.btnEstadoDeGuarderia_Click);
            // 
            // btnAlimentar
            // 
            this.btnAlimentar.Location = new System.Drawing.Point(12, 108);
            this.btnAlimentar.Name = "btnAlimentar";
            this.btnAlimentar.Size = new System.Drawing.Size(117, 32);
            this.btnAlimentar.TabIndex = 2;
            this.btnAlimentar.Text = "Alimentar Dragones";
            this.btnAlimentar.UseVisualStyleBackColor = true;
            this.btnAlimentar.Click += new System.EventHandler(this.btnAlimentar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.DragonGif;
            this.pictureBox1.Location = new System.Drawing.Point(157, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmGuarderia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 152);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAlimentar);
            this.Controls.Add(this.btnEstadoDeGuarderia);
            this.Controls.Add(this.btnAgregarDragon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGuarderia";
            this.Text = "Guarderia de Dragones";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarDragon;
        private System.Windows.Forms.Button btnEstadoDeGuarderia;
        private System.Windows.Forms.Button btnAlimentar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

