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
    public partial class frmFabrica : Form
    {
        FabricaDAO fabricaDAO;
        
        public frmFabrica()
        {
            InitializeComponent();
            //materiales basicos de los muebles
            Material madera = new Material("madera");
            Material hierro = new Material("hierro");
            Material algodon = new Material("Algodon");
            Fabrica.AgregarMaterial(madera);
            Fabrica.AgregarMaterial(hierro);
            Fabrica.AgregarMaterial(algodon);
            Sillon sillonDefault = new Sillon("Sillon Madera y algodon", madera, algodon);
            Sillon sillonDefault2 = new Sillon("Sillon Madera y madera", madera, madera);

            Ropero roperoDefault = new Ropero("Ropero Madera y Hierro", madera, hierro);
            Ropero roperoDefault2 = new Ropero("Ropero Madera y Madera", madera, madera);
            Fabrica.listaDeMuebles.Add(sillonDefault);
            Fabrica.listaDeMuebles.Add(roperoDefault);
            Fabrica.listaDeMuebles.Add(roperoDefault2);
            Fabrica.listaDeMuebles.Add(sillonDefault2);
            fabricaDAO = new FabricaDAO();


        }

        private void btnFabricar_Mueble_Click(object sender, EventArgs e)
        {
            frmAgregarMueble frmAgregarMueble = new frmAgregarMueble();
            frmAgregarMueble.ShowDialog();
        }

        private void btnDiseñar_Mueble_Click(object sender, EventArgs e)
        {
            frmDiseñar frmDiseñar = new frmDiseñar();
            frmDiseñar.ShowDialog();
        }

        private void btnListar_Muebles_Click(object sender, EventArgs e)
        {
            frmListaDeMuebles frmListaDeMuebles = new frmListaDeMuebles();
            frmListaDeMuebles.ShowDialog();
        }

        private void btnListar_Materiales_Click(object sender, EventArgs e)
        {
            frmListaDeMateriales frmListaMateriales = new frmListaDeMateriales();
            frmListaMateriales.ShowDialog();
        }

        private void btnGuardar_DB_Click(object sender, EventArgs e)
        {
            if (fabricaDAO.InsertListaDeMuebles(Fabrica.listaDeMuebles))
            {
                MessageBox.Show("Se guardo la lista en la Base de datos");
            }
            else
            {
                MessageBox.Show("No se guardo la lista en la Base de datos");
            }

        }

        private void btnCargar_BD_Click(object sender, EventArgs e)
        {
            List<Mueble> listaDeMueblesDB;
            listaDeMueblesDB = fabricaDAO.GetListaDeMuebles();
        }

        private void btnAgregar_Material_Click(object sender, EventArgs e)
        {
            frmAgregarMaterial frmAgregarMaterial = new frmAgregarMaterial();
            frmAgregarMaterial.ShowDialog();
        }

        private void frmFabrica_Load(object sender, EventArgs e)
        {

        }
    }
}
