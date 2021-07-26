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

namespace MiCalculadora
{
    public partial class formCalculadora : Form
    {
        public static double Operar(string numero1, string numero2, string operador)
        {
            if (string.IsNullOrEmpty(numero1))
            {
                throw new ArgumentException("Ingrese un numero valido para operar");
            }

            if (string.IsNullOrEmpty(numero2))
            {
                throw new ArgumentException("Ingrese un numero valido para operar");
            }

            if (string.IsNullOrEmpty(operador))
            {
                throw new ArgumentException("Ingrese un operador valido para operar");
            }

            double retorno;
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);
            char operadorChar = operador[0];
            
            retorno = Calculadora.Operar(num1, num2, operadorChar);


            return retorno;
        }
        private  void Limpiar()
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperador.Text = "";
            lblResultado.Text = "";
        }
        public formCalculadora()
        {
            InitializeComponent();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            try
            {

            lblResultado.Text = Operar(txtNumero1.Text.Replace('.', ','), txtNumero2.Text.Replace('.', ','), cmbOperador.Text).ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void formCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {           
            DialogResult dialogResult = MessageBox.Show("¿Está seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                this.Dispose();
            }
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != "")
            {
            lblResultado.Text = Numero.DecimalBinario(lblResultado.Text);

            }
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != "")
            {
                lblResultado.Text = Numero.BinarioDecimal(lblResultado.Text);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }
    }
}
