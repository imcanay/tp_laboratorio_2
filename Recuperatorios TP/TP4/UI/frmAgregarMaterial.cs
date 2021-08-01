using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace UI
{
    public partial class frmAgregarMaterial : Form
    {
        public frmAgregarMaterial()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tbxNombreMaterial.Text != null && tbxNombreMaterial.Text.Length >0)
            {
            Material material = new Material(tbxNombreMaterial.Text.Trim());
            Fabrica.AgregarMaterial(material);

            }

            tbxNombreMaterial.Text = null;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbxNombreMaterial.Text = null;
        }
    }
}
