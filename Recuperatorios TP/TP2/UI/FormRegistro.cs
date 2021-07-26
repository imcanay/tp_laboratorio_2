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
    public partial class FormRegistro : Form
    {
        public BindingSource bs1 = new BindingSource();
        public BindingSource bs2 = new BindingSource();
        public BindingSource bs3 = new BindingSource();
        private double tamaño;

        public FormRegistro()
        {
            InitializeComponent();

            bs1.DataSource = Enum.GetValues(typeof(TiposDeDragon));
            cmbxTipo.DataSource = bs1;
            bs3.DataSource = Enum.GetValues(typeof(Alimentacion));
            cmbxAlimentacion.DataSource = bs3;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string strTamaño = txtTamaño.Text.Replace('.', ',');
            bool registroAux = false;
            double.TryParse(strTamaño, out tamaño);
            if (tamaño == 0)
            {
                MessageBox.Show("No se puede agregar un Dragon con ese tamaño");
            }
            else
            {

                switch (cmbxTipo.Text)
                {
                    case "Acuatico":
                        DragonAcuatico dragonAcuatico = new DragonAcuatico((TipoDeAgua)cmbxAtributoExtra.SelectedIndex, (Alimentacion)cmbxAlimentacion.SelectedIndex, tamaño, txtNombre.Text);
                        registroAux = Guarderia.AgregarDragon(dragonAcuatico);
                        break;
                    case "Volador":
                        DragonVolador dragonVolador = new DragonVolador((TipoDeNido)cmbxAtributoExtra.SelectedIndex, (Alimentacion)cmbxAlimentacion.SelectedIndex, tamaño, txtNombre.Text);
                        registroAux = Guarderia.AgregarDragon(dragonVolador);
                        break;
                    case "Terrestre":
                         DragonTerrestre dragonTerrestre = new DragonTerrestre((TipoDeSuperficie)cmbxAtributoExtra.SelectedIndex, (Alimentacion)cmbxAlimentacion.SelectedIndex, tamaño, txtNombre.Text);
                        registroAux = Guarderia.AgregarDragon(dragonTerrestre);
                        break;
                }
            }
            if (registroAux==true)
            {
                MessageBox.Show("Se registro el dragon");
            }
            else
            {
                MessageBox.Show("No se registro el dragon");
            }
        }

        private void cmbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbxTipo.Text)
            {
                case "Acuatico":
                    lblAtributo.Text = "Tipo De Agua Preferida";
                    bs2.DataSource = Enum.GetValues(typeof(TipoDeAgua));
                    cmbxAtributoExtra.DataSource = bs2;
                    cmbxAtributoExtra.DisplayMember = Enum.GetName(typeof(TipoDeAgua), 1);
                    break;
                case "Volador":
                    lblAtributo.Text = "Donde Anida";
                    bs2.DataSource = Enum.GetValues(typeof(TipoDeNido));
                    cmbxAtributoExtra.DataSource = bs2;
                    cmbxAtributoExtra.DisplayMember = Enum.GetName(typeof(TipoDeNido), 1);
                    break;
                case "Terrestre":
                    lblAtributo.Text = "En Que superficie Habita";
                    bs2.DataSource = Enum.GetValues(typeof(TipoDeSuperficie));
                    cmbxAtributoExtra.DataSource = bs2;
                    cmbxAtributoExtra.DisplayMember = Enum.GetName(typeof(TipoDeSuperficie), 1);
                    break;
            }
        }
    }
}
