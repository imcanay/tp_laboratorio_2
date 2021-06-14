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
    public partial class frmListaMateriales : Form
    {
        public frmListaMateriales()
        {
            InitializeComponent();
        }

        private void frmListaMateriales_Load(object sender, EventArgs e)
        {
            rtbxListaDeMateriales.Text = Fabrica.MostrarListaDeMateriales();
        }
    }
}
