using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UI
{
    public partial class frmGuarderia : Form
    {
        public frmGuarderia()
        {
            InitializeComponent();
            
            
        }

        private void btnAgregarDragon_Click(object sender, EventArgs e)
        {
            FormRegistro frmRegistro = new FormRegistro();
            frmRegistro.ShowDialog();
        }

        private void btnAlimentar_Click(object sender, EventArgs e)
        {
            FormAlimentar frmAlimentar = new FormAlimentar();
            frmAlimentar.ShowDialog();
        }

        private void btnEstadoDeGuarderia_Click(object sender, EventArgs e)
        {
            FormVerGuarderia frmVerGuarderia = new FormVerGuarderia();
            frmVerGuarderia.ShowDialog();
        }
    }
}
