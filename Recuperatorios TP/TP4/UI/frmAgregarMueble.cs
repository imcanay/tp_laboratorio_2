using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace UI
{
    public partial class frmAgregarMueble : Form
    {


        public event FabricarMuebleDelegate FabricarMuebleEvent;
        public delegate void CmbxAlteradorDelegate(object sender, EventArgs e);
        Thread threadFabricador;
        public frmAgregarMueble()
        {
            InitializeComponent();

            cmbTipoMueble.DataSource = Enum.GetValues(typeof(ETipoDeMueble));
            cmbTipoMueble.SelectedItem = null;
            BindingSource bs1 = new BindingSource();
            BindingSource bs2 = new BindingSource();
            bs1.DataSource = Fabrica.listaDeMateriales;
            bs2.DataSource = Fabrica.listaDeMateriales;

            cmbMaterial.DataSource = bs1;
            cmbMaterial.DisplayMember = "Nombre";
            cmbMaterial.SelectedItem = null;

            cmbMaterialSecundario.DataSource = bs2;
            cmbMaterialSecundario.DisplayMember = "Nombre";
            cmbMaterialSecundario.SelectedItem = null;

            FabricarMuebleEvent += Fabrica.AgregarProducto;


        }

        private void btnAgregarMueble_Click(object sender, EventArgs e)
        {
            ParameterizedThreadStart pts = new ParameterizedThreadStart(Fabricador);
            threadFabricador = new Thread(pts);

            if (FabricarMuebleEvent != null)
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
                                Sillon sillon = new Sillon(txbxNombre.Text, (Material)cmbMaterial.SelectedValue, (Material)cmbMaterialSecundario.SelectedValue);
                                threadFabricador.Start(sillon);
                                break;
                            case "Ropero":
                                Ropero ropero = new Ropero(txbxNombre.Text, (Material)cmbMaterial.SelectedValue, (Material)cmbMaterialSecundario.SelectedValue);
                                threadFabricador.Start(ropero);
                                break;
                        }
                    }
            MessageBox.Show($"Se inicio la fabricacion del mueble {txbxNombre.Text}");

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

            cmbTipoMueble.SelectedItem = null;
            cmbMaterialSecundario.SelectedItem = null;
            cmbMaterial.SelectedItem = null;
            txbxNombre.Text = null;
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


        public void Fabricador(object mueble)
        {
            Mueble axmueble = (Mueble)mueble;
            FabricarMuebleEvent.Invoke(axmueble);
            MessageBox.Show(axmueble.ToString());
        }
        
    }




}
