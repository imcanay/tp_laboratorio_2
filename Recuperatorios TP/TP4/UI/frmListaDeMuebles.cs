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
    public partial class frmListaDeMuebles : Form
    {
        public frmListaDeMuebles()
        {
            InitializeComponent();
        }
        private void frmListaDeMuebles_Load(object sender, EventArgs e)
        {
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
