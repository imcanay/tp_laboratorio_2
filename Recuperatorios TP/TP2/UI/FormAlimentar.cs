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
    public partial class FormAlimentar : Form
    {
        public BindingSource bs1 = new BindingSource();
        public FormAlimentar()
        {
            InitializeComponent();
            
        }

        private void btnAlimentar_Click(object sender, EventArgs e)
        {
            
            rtbxAlimentacion.Text = Guarderia.AlimentarDragones();
        }
    }
}
