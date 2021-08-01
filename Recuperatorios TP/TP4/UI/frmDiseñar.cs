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
    public partial class frmDiseñar : Form
    {
        public frmDiseñar()
        {
            InitializeComponent();
        }

        private void btnPintar_Click(object sender, EventArgs e)
        {
            int indice = lsbxListaMueblesAPintar.SelectedIndex;


            //si lo seleccionado de la lista es ropero
            if (lsbxListaMueblesAPintar.SelectedItem is Ropero)
            {
                Ropero roperoAx = (Ropero)Fabrica.listaDeMuebles[indice];

                if (roperoAx.MaterialBase.Nombre.ToLower() == "madera")
                {
                    roperoAx.Barnizar((EColorBarniz)cmbxColorBase.SelectedItem);
                }
                else
                {
                    roperoAx.PintarBase((ConsoleColor)cmbxColorBase.SelectedItem);
                }
                try
                {
                    if (roperoAx.MaterialEstantes.Nombre.ToLower() == "madera")
                    {

                        throw new BarnizarEstantesException();
                    }
                }
                catch (Exception)
                {
                }
                finally
                {
                    roperoAx.PintarSecundario((ConsoleColor)cmbxColorSecundario.SelectedItem);
                }

                Fabrica.listaDeMuebles[indice] = roperoAx;
                MessageBox.Show("Termino de guardar los cambios y quedo: \n" + Fabrica.listaDeMuebles[indice].ToString());
            }

            //si lo seleccionado de la lista es un sillon
            else if (lsbxListaMueblesAPintar.SelectedItem is Sillon)
            {
                Sillon sillonAx = (Sillon)Fabrica.listaDeMuebles[indice];
                try
                {
                    if (sillonAx.MaterialBase.Nombre == "madera")
                    {
                        throw new BarnizarSillaException();
                    }
                }
                catch (Exception)
                {
                }
                finally
                {
                    sillonAx.PintarBase((ConsoleColor)cmbxColorBase.SelectedItem);
                }
                try
                {
                    if (sillonAx.MaterialTapizado.Nombre == "madera")
                    {
                        throw new BarnizarSillaException();
                    }
                }
                catch (Exception)
                {

                }
                finally
                {
                    sillonAx.PintarSecundario((ConsoleColor)cmbxColorSecundario.SelectedItem);
                }
                Fabrica.listaDeMuebles[indice] = sillonAx;
                MessageBox.Show("Termino de guardar los cambios y quedo: \n" + Fabrica.listaDeMuebles[indice].ToString());
            }
        }

        private void frmDiseñar_Load(object sender, EventArgs e)
        {
            BindingSource listaMuebles = new BindingSource();
            listaMuebles.DataSource = Fabrica.listaDeMuebles;
            lsbxListaMueblesAPintar.DataSource = listaMuebles;
            lsbxListaMueblesAPintar.DisplayMember = "Nombre";

            if (Fabrica.listaDeMuebles.Count ==0)
            {
                DialogResult dialogResult = MessageBox.Show("Aun no se fabrico ningun mueble, deasea ir al formulario de fabricacion?", "Sin Muebles", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Dispose();
                    frmAgregarMueble frmAgregarMueble = new frmAgregarMueble();
                    frmAgregarMueble.ShowDialog();
                }
                else
                {
                    this.Dispose();
                }
            }
        }

        private void lsbxListaMueblesAPintar_SelectedIndexChanged(object sender, EventArgs e)
        {


            BindingSource baseBarniz = new BindingSource();
            baseBarniz.DataSource = Enum.GetValues(typeof(EColorBarniz));
            BindingSource baseColor = new BindingSource();
            baseColor.DataSource = Enum.GetValues(typeof(ConsoleColor));
            BindingSource secundarioBarniz = new BindingSource();
            secundarioBarniz.DataSource = Enum.GetValues(typeof(EColorBarniz));
            BindingSource secundarioColor = new BindingSource();
            secundarioColor.DataSource = Enum.GetValues(typeof(ConsoleColor));


            int indice = lsbxListaMueblesAPintar.SelectedIndex;
            if (lsbxListaMueblesAPintar.SelectedItem is Ropero)
            {
                Ropero roperoAx = (Ropero)Fabrica.listaDeMuebles[indice];//este es el objeto seleccionado
                //material base
                if (roperoAx.MaterialBase.EsMaterial("madera")) //si es base de madera
                {
                    cmbxColorBase.DataSource = baseBarniz; // muestra lista de barnices
                }
                else
                {
                    cmbxColorBase.DataSource = baseColor; // si no es madera muestra colores
                }
                //material secundario
                try
                {
                    if (roperoAx.MaterialEstantes.EsMaterial("madera"))
                    {
                        throw new BarnizarEstantesException();
                    }
                }
                catch (Exception)
                {
                }
                finally
                {
                    cmbxColorSecundario.DataSource = secundarioColor;
                }
            }
            else if (lsbxListaMueblesAPintar.SelectedItem is Sillon)
            {
                Sillon sillonAx = (Sillon)Fabrica.listaDeMuebles[indice];//objeto sillon
                try
                {
                    if (sillonAx.MaterialBase.EsMaterial("madera")) // si es base de madera
                    {
                        //muestra lista de colores
                        throw new BarnizarSillaException();  // por que las sillas no se barnizan
                    }
                    else
                    {
                        cmbxColorBase.DataSource = baseColor;//sino es madera muestra colores
                    }
                }
                catch (Exception)
                {

                }
                finally
                {
                    cmbxColorBase.DataSource = baseColor;
                }

                try
                {
                    //material secundario
                    if (sillonAx.MaterialTapizado.EsMaterial("madera"))
                    {

                        throw new BarnizarSillaException();
                    }
                    else
                    {
                        cmbxColorSecundario.DataSource = secundarioColor;
                    }
                }
                catch (Exception)
                {

                }
                finally
                {
                    cmbxColorSecundario.DataSource = secundarioColor;
                }

            }
        }
    }
}
