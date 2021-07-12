
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFabrica));
            this.btnFabricar = new System.Windows.Forms.Button();
            this.btnAgregarMaterial = new System.Windows.Forms.Button();
            this.btnDiseñar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnListaMuebles = new System.Windows.Forms.Button();
            this.btnListaMateriales = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFabricar
            // 
            this.btnFabricar.Location = new System.Drawing.Point(12, 101);
            this.btnFabricar.Name = "btnFabricar";
            this.btnFabricar.Size = new System.Drawing.Size(97, 24);
            this.btnFabricar.TabIndex = 0;
            this.btnFabricar.Text = "Fabricar Mueble";
            this.btnFabricar.UseVisualStyleBackColor = true;
            this.btnFabricar.Click += new System.EventHandler(this.btnFabricar_Click);
            // 
            // btnAgregarMaterial
            // 
            this.btnAgregarMaterial.Location = new System.Drawing.Point(13, 126);
            this.btnAgregarMaterial.Name = "btnAgregarMaterial";
            this.btnAgregarMaterial.Size = new System.Drawing.Size(95, 24);
            this.btnAgregarMaterial.TabIndex = 1;
            this.btnAgregarMaterial.Text = "Agregar Material";
            this.btnAgregarMaterial.UseVisualStyleBackColor = true;
            this.btnAgregarMaterial.Click += new System.EventHandler(this.btnAgregarMaterial_Click);
            // 
            // btnDiseñar
            // 
            this.btnDiseñar.Location = new System.Drawing.Point(12, 150);
            this.btnDiseñar.Name = "btnDiseñar";
            this.btnDiseñar.Size = new System.Drawing.Size(95, 24);
            this.btnDiseñar.TabIndex = 2;
            this.btnDiseñar.Text = "Diseñar Mueble";
            this.btnDiseñar.UseVisualStyleBackColor = true;
            this.btnDiseñar.Click += new System.EventHandler(this.btnDiseñar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(7, 29);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(72, 25);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(7, 55);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(72, 27);
            this.btnCargar.TabIndex = 4;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnListaMuebles
            // 
            this.btnListaMuebles.Location = new System.Drawing.Point(112, 102);
            this.btnListaMuebles.Name = "btnListaMuebles";
            this.btnListaMuebles.Size = new System.Drawing.Size(80, 35);
            this.btnListaMuebles.TabIndex = 5;
            this.btnListaMuebles.Text = "Mostrar Lista de Muebles";
            this.btnListaMuebles.UseVisualStyleBackColor = true;
            this.btnListaMuebles.Click += new System.EventHandler(this.btnListaMuebles_Click);
            // 
            // btnListaMateriales
            // 
            this.btnListaMateriales.Location = new System.Drawing.Point(112, 139);
            this.btnListaMateriales.Name = "btnListaMateriales";
            this.btnListaMateriales.Size = new System.Drawing.Size(80, 35);
            this.btnListaMateriales.TabIndex = 6;
            this.btnListaMateriales.Text = "Mostrar Lista de Materiales";
            this.btnListaMateriales.UseVisualStyleBackColor = true;
            this.btnListaMateriales.Click += new System.EventHandler(this.btnListaMateriales_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 24);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cargar DB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 24);
            this.button2.TabIndex = 8;
            this.button2.Text = "Guardar DB";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 11);
            this.label2.TabIndex = 10;
            this.label2.Text = "Fabrica De Muebles S.A";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Dese Archivo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Desde Base de Datos";
            // 
            // label1
            // 
            this.label1.Image = global::frmFabrica.Properties.Resources.Muebles_SA;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 93);
            this.label1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnCargar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Location = new System.Drawing.Point(9, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(86, 92);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(108, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(118, 93);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // frmFabrica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(270, 325);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListaMateriales);
            this.Controls.Add(this.btnListaMuebles);
            this.Controls.Add(this.btnDiseñar);
            this.Controls.Add(this.btnAgregarMaterial);
            this.Controls.Add(this.btnFabricar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFabrica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fabrica de muebles - Ignacio Canay 2c";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFabricar;
        private System.Windows.Forms.Button btnAgregarMaterial;
        private System.Windows.Forms.Button btnDiseñar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnListaMuebles;
        private System.Windows.Forms.Button btnListaMateriales;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

