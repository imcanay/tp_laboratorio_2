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
    public partial class frmListaDeMuebles : Form
    {
        public frmListaDeMuebles()
        {
            InitializeComponent();
        }
        private void frmListaDeMuebles_Load(object sender, EventArgs e)
        {
            if (Fabrica.listaDeMuebles.Count == 0 && Fabrica.listaDeMateriales.Count == 0)
            {
                DialogResult showDialog = MessageBox.Show("Primero cargue algun material y mueble", "No hay materiales", MessageBoxButtons.OKCancel);
                if (showDialog == DialogResult.OK)
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
            else if (Fabrica.listaDeMuebles.Count == 0 && Fabrica.listaDeMateriales.Count > 0)
            {
                DialogResult showDialog = MessageBox.Show("Primero cargue algun mueble", "No hay muebles", MessageBoxButtons.OKCancel);
                if (showDialog == DialogResult.OK)
                {
                    frmAgregarMueble frmAgregarMueble = new frmAgregarMueble();
                    frmAgregarMueble.ShowDialog();
                    this.Dispose();
                }
                else
                {
                    this.Dispose();
                }
            }
            rtbxListaDeMuebles.Text = Fabrica.MostrarListaDeMuebles();
        }

        private void btnGuardar_Xml_Click(object sender, EventArgs e)
        {
            string nombreDeArchivoXml = "Muebles.xml";
            string carpetaXml = AppDomain.CurrentDomain.BaseDirectory + @"\";
            string pathCompletoXml = carpetaXml + nombreDeArchivoXml;
            Xml<List<Mueble>>.Guardar(pathCompletoXml, Fabrica.listaDeMuebles);

        }
    }
}
