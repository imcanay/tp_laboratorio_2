using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace UI
{
    public partial class frmListaDeMateriales : Form
    {
        private string nombreDeArchivoXml = "Materiales.xml";
        private string carpetaXml = AppDomain.CurrentDomain.BaseDirectory + @"\";
        private string nombreDeArchivo = "Lista de Materiales Log.txt";
        private string carpeta = AppDomain.CurrentDomain.BaseDirectory + @"\";

        public frmListaDeMateriales()
        {
            InitializeComponent();
        }

        private void frmListaDeMateriales_Load(object sender, EventArgs e)
        {
            if (Fabrica.listaDeMateriales.Count ==0)
            {
                rtbxListaDeMateriales.Text = "Aun no se ha cargado ningun material. Puede cargar la lista del archivo o ingrese nuevos materiales";
            }
            else
            {
            rtbxListaDeMateriales.Text = Fabrica.MostrarListaDeMateriales();

            }


        }

        private void btnGuardar_Texto_Click(object sender, EventArgs e)
        {

            string pathCompleto = carpeta + nombreDeArchivo;
            Texto texto = new Texto();
            texto.Guardar(pathCompleto, rtbxListaDeMateriales.Text);
            MessageBox.Show("se guardo log.txt");


        }

        private void btnGuardarXml_Click(object sender, EventArgs e)
        {

            string pathCompletoXml = carpetaXml + nombreDeArchivoXml;
            Xml<List<Material>>.Guardar(pathCompletoXml, Fabrica.listaDeMateriales);
        }

        private void btnCargarXml_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esto sobrescribirá la lista de materiales actual", "¿Desea continuar?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string pathCompletoXml = carpetaXml + nombreDeArchivoXml;
                Xml<List<Material>>.Leer(pathCompletoXml, out Fabrica.listaDeMateriales);
                rtbxListaDeMateriales.Text = Fabrica.MostrarListaDeMateriales();
            }

        }
    }
}
