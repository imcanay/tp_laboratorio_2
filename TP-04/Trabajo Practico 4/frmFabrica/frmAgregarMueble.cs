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
using System.Threading;

namespace frmFabrica
{
    public partial class frmAgregarMueble : Form
    {
        public FabricarRopero fabricarRopero;
        public FabricarSillon fabricarSillon;
        

        public frmAgregarMueble()
        {
            InitializeComponent();
                       
            cmbTipoMueble.DataSource = Enum.GetValues(typeof(ETipoDeMueble));
            BindingSource bs1 = new BindingSource();
            BindingSource bs2 = new BindingSource();
            bs1.DataSource = Fabrica.listaDeMateriales;
            bs2.DataSource = Fabrica.listaDeMateriales;

            cmbMaterial.DataSource= bs1;
            cmbMaterial.DisplayMember = "Nombre";
            
            cmbMaterialSecundario.DataSource = bs2;
            cmbMaterialSecundario.DisplayMember = "Nombre";



        }
   

        private void btnAgregarMueble_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipoMueble.SelectedItem == null || cmbMaterial.SelectedItem == null || cmbMaterialSecundario == null)
                {
                    throw new FaltaSeleccionException();
                }
                else
                {
                    switch (cmbTipoMueble.Text)
                    {
                        case "Sillon":
                            Sillon sillon = new Sillon(txbxNombre.Text,(Material)cmbMaterial.SelectedValue,(Material)cmbMaterialSecundario.SelectedValue);
                            MessageBox.Show(sillon.ToString());

                            
                            Fabrica.listaDeMuebles.Add(sillon);

                            break;
                        case "Ropero":
                            Ropero ropero= new Ropero(txbxNombre.Text, (Material)cmbMaterial.SelectedValue, (Material)cmbMaterialSecundario.SelectedValue);
                            MessageBox.Show(ropero.ToString());
                           ////Fabrica.listaDeMuebles.Add(ropero); 
                            break;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            foreach (Control item in this.Controls)
            {
                item.ResetText();

            }
        }

        private void cmbTipoMueble_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbTipoMueble.Text)
            {
                case "Sillon":
                    lblMaterialSecundario.Text = "Material del Tapizado";
                    
                   
                    break;
                case "Ropero":
                    lblMaterialSecundario.Text = "Material de los Estantes";
                    break;
                default:
                    lblMaterialSecundario.Text = "Material del Tapizado";
                    break;
            }
        }

        private void frmAgregarMueble_Load(object sender, EventArgs e)
        {

        }
    }
}
