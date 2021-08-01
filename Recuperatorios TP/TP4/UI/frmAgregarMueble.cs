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
                    else if (txbxNombre.Text.Length==0)
                    {
                        throw new FaltaSeleccionException("El nombre debe contener algun caracter");
                    }
                    else
                    {
                        switch (cmbTipoMueble.Text)
                        {
                            case "Sillon":
                                Sillon sillon = new Sillon(txbxNombre.Text, (Material)cmbMaterial.SelectedValue, (Material)cmbMaterialSecundario.SelectedValue);
                                threadFabricador.Start(sillon);
                                MessageBox.Show("Fabricar el sillon demorara 10 seg");
                                break;
                            case "Ropero":
                                Ropero ropero = new Ropero(txbxNombre.Text, (Material)cmbMaterial.SelectedValue, (Material)cmbMaterialSecundario.SelectedValue);
                                threadFabricador.Start(ropero);
                                MessageBox.Show("Fabricar el Ropero demorara 15 seg");
                                break;
                        }
                    }
                    

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

            if (this.rtbxUltimoMueble.InvokeRequired)
            {
                this.rtbxUltimoMueble.BeginInvoke((MethodInvoker)delegate ()
               {
                   this.rtbxUltimoMueble.Text = mueble.ToString();

               }
                );

            }
            else
            {
                this.rtbxUltimoMueble.Text = mueble.ToString();
            }
        }

        private void frmAgregarMueble_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (threadFabricador == null)
            {
                this.Dispose();
            }
            else if (threadFabricador.IsAlive)
            {
             threadFabricador.Abort();
            }
            else
            {
                this.Dispose();
            }
        }

        private void frmAgregarMueble_Load(object sender, EventArgs e)
        {
            if (Fabrica.listaDeMateriales.Count == 0)
            {
                DialogResult dialogResult = MessageBox.Show("No hay materiales disponibles, Desea cargarlos del archivo?", "Error de materiales", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    frmListaDeMateriales frmListaMateriales = new frmListaDeMateriales();
                    frmListaMateriales.ShowDialog();
                    this.Dispose();
                }
                else if (dialogResult == DialogResult.No)
                {
                    DialogResult dialogResult2 = MessageBox.Show("Desea crear un nuevo material?", "Error de materiales", MessageBoxButtons.YesNo);
                    if (dialogResult2 == DialogResult.Yes)
                    {
                        frmAgregarMaterial frmAgregarMaterial = new frmAgregarMaterial();
                        frmAgregarMaterial.ShowDialog();
                        this.Dispose();
                    }
                    else
                    {
                    this.Dispose();
                    }
                    
                }
            }
        }
    }




}
