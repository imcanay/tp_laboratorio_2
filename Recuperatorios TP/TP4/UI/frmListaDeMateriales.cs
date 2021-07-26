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
    public partial class frmListaDeMateriales : Form
    {
        public frmListaDeMateriales()
        {
            InitializeComponent();
        }

        private void frmListaDeMateriales_Load(object sender, EventArgs e)
        {
            rtbxListaDeMateriales.Text = Fabrica.MostrarListaDeMateriales();
        }

        private void btnGuardar_Texto_Click(object sender, EventArgs e)
        {
            string nombreDeArchivo = "Lista de Materiales Log.txt";
            string carpeta = AppDomain.CurrentDomain.BaseDirectory + @"\";
            string pathCompleto = carpeta + nombreDeArchivo;
            Texto texto = new Texto();
            texto.Guardar(pathCompleto, rtbxListaDeMateriales.Text);
        }
    }
}
