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
using Archivador;

namespace frmFabrica
{
    public delegate void FabricarSillon(Sillon sillon);
    public delegate void FabricarRopero(Ropero ropero);
    public partial class frmFabrica : Form
    {
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

        }

        private void btnFabricar_Click(object sender, EventArgs e)
        {
            frmAgregarMueble frmAgregarMueble = new frmAgregarMueble();
            frmAgregarMueble.ShowDialog();
        }

        private void btnAgregarMaterial_Click(object sender, EventArgs e)
        {
            frmAgregarMaterial frmAgregarMaterial = new frmAgregarMaterial();
            frmAgregarMaterial.ShowDialog();
        }

        private void btnDiseñar_Click(object sender, EventArgs e)
        {
            //frmDiseñarMueble frmDiseñarMueble = new frmDiseñarMueble();esto es el forma nt
            //frmDiseñarMueble.ShowDialog();
            frmPintar frmPintar = new frmPintar();
            frmPintar.ShowDialog();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            string archivo = "Lista de Muebles.xml";
            string archivoM = "Lista de Materiales.xml";
            string path = AppDomain.CurrentDomain.BaseDirectory + @"\";
            string pathCompleto = path + archivo;
            string pathCompletoM = path + archivoM;
            Xml<List<Mueble>>.Leer(pathCompleto, out Fabrica.listaDeMuebles);
            Xml<List<Material>>.Leer(pathCompletoM, out Fabrica.listaDeMateriales);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            string archivo = "Lista de Muebles.xml";
            string archivoM = "Lista de Materiales.xml";
            string path = AppDomain.CurrentDomain.BaseDirectory + @"\";
            string pathCompleto = path+ archivo;
            string pathCompletoM = path + archivoM;
            Xml<List<Mueble>>.Guardar(pathCompleto, Fabrica.listaDeMuebles);
            Xml<List<Material>>.Guardar(pathCompletoM, Fabrica.listaDeMateriales);


        }

        private void btnListaMuebles_Click(object sender, EventArgs e)
        {
            frmListaDeMuebles frmListaDeMuebles = new frmListaDeMuebles();
            frmListaDeMuebles.ShowDialog();

        }

        private void btnListaMateriales_Click(object sender, EventArgs e)
        {
            frmListaMateriales frmListaMateriales = new frmListaMateriales();
            frmListaMateriales.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MuebleDAO dao = new MuebleDAO();

           // Fabrica.listaDeMuebles = dao.GetEntidadSQLs();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MuebleDAO dao = new MuebleDAO();
            if (dao.Guardar(Fabrica.listaDeMuebles))
            {
                MessageBox.Show("Se guardo en db.");
            }
            else
            {
                throw new Exception("No se pudo guardar en DB");
            }

        }
    }
}
