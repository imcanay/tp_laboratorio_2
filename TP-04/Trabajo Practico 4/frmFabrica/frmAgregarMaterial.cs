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

namespace frmFabrica
{
    public partial class frmAgregarMaterial : Form
    {
        public frmAgregarMaterial()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tbxNombreMaterial.Text != "" || tbxNombreMaterial.Text != null)
            {
                Material material = new Material(tbxNombreMaterial.Text);
                Fabrica.listaDeMateriales+=material;
                
            }
        }
    }
}
