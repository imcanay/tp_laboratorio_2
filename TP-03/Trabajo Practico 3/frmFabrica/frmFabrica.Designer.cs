
namespace frmFabrica
{
    partial class frmFabrica
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
            this.btnFabricar = new System.Windows.Forms.Button();
            this.btnAgregarMaterial = new System.Windows.Forms.Button();
            this.btnDiseñar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnListaMuebles = new System.Windows.Forms.Button();
            this.btnListaMateriales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFabricar
            // 
            this.btnFabricar.Location = new System.Drawing.Point(21, 32);
            this.btnFabricar.Name = "btnFabricar";
            this.btnFabricar.Size = new System.Drawing.Size(126, 81);
            this.btnFabricar.TabIndex = 0;
            this.btnFabricar.Text = "Fabricar Mueble";
            this.btnFabricar.UseVisualStyleBackColor = true;
            this.btnFabricar.Click += new System.EventHandler(this.btnFabricar_Click);
            // 
            // btnAgregarMaterial
            // 
            this.btnAgregarMaterial.Location = new System.Drawing.Point(23, 136);
            this.btnAgregarMaterial.Name = "btnAgregarMaterial";
            this.btnAgregarMaterial.Size = new System.Drawing.Size(123, 86);
            this.btnAgregarMaterial.TabIndex = 1;
            this.btnAgregarMaterial.Text = "Agregar Material";
            this.btnAgregarMaterial.UseVisualStyleBackColor = true;
            this.btnAgregarMaterial.Click += new System.EventHandler(this.btnAgregarMaterial_Click);
            // 
            // btnDiseñar
            // 
            this.btnDiseñar.Location = new System.Drawing.Point(25, 239);
            this.btnDiseñar.Name = "btnDiseñar";
            this.btnDiseñar.Size = new System.Drawing.Size(121, 90);
            this.btnDiseñar.TabIndex = 2;
            this.btnDiseñar.Text = "Diseñar Mueble";
            this.btnDiseñar.UseVisualStyleBackColor = true;
            this.btnDiseñar.Click += new System.EventHandler(this.btnDiseñar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(173, 239);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(59, 90);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(246, 239);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(61, 90);
            this.btnCargar.TabIndex = 4;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnListaMuebles
            // 
            this.btnListaMuebles.Location = new System.Drawing.Point(173, 32);
            this.btnListaMuebles.Name = "btnListaMuebles";
            this.btnListaMuebles.Size = new System.Drawing.Size(134, 81);
            this.btnListaMuebles.TabIndex = 5;
            this.btnListaMuebles.Text = "Mostrar Lista de Muebles";
            this.btnListaMuebles.UseVisualStyleBackColor = true;
            this.btnListaMuebles.Click += new System.EventHandler(this.btnListaMuebles_Click);
            // 
            // btnListaMateriales
            // 
            this.btnListaMateriales.Location = new System.Drawing.Point(173, 136);
            this.btnListaMateriales.Name = "btnListaMateriales";
            this.btnListaMateriales.Size = new System.Drawing.Size(134, 86);
            this.btnListaMateriales.TabIndex = 6;
            this.btnListaMateriales.Text = "Mostrar Lista de Materiales";
            this.btnListaMateriales.UseVisualStyleBackColor = true;
            this.btnListaMateriales.Click += new System.EventHandler(this.btnListaMateriales_Click);
            // 
            // frmFabrica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 344);
            this.Controls.Add(this.btnListaMateriales);
            this.Controls.Add(this.btnListaMuebles);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnDiseñar);
            this.Controls.Add(this.btnAgregarMaterial);
            this.Controls.Add(this.btnFabricar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFabrica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fabrica de muebles - Ignacio Canay 2c";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFabricar;
        private System.Windows.Forms.Button btnAgregarMaterial;
        private System.Windows.Forms.Button btnDiseñar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnListaMuebles;
        private System.Windows.Forms.Button btnListaMateriales;
    }
}

