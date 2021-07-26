using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        #region Atributos
        private double numero;
        #endregion
        #region Propiedades

        private string SetNumero
        {
            set
            {
                numero = ValidarNumero(value);
            }
        }

        #endregion
        #region Constructores
        public Numero()
        {

            this.numero = 0;
        }
        public Numero(double numero) : this()
        {

            this.numero = numero;
        }
        public Numero(string strNumero) : this()
        {

            this.SetNumero = strNumero;

        }
        #endregion
        #region Sobrecarga de operadores
        public static double operator -(Numero n1, Numero n2)
        {
            double dblRetorno = n1.numero - n2.numero;
            return dblRetorno;

        }
        public static double operator *(Numero n1, Numero n2)
        {
            double dblRetorno = n1.numero * n2.numero;
            return dblRetorno;
        }
        public static double operator /(Numero n1, Numero n2)
        {
            if (n2.numero == 0)
            {
                return double.MinValue;
            }
            double dblRetorno = n1.numero / n2.numero;
            return dblRetorno;
        }
        public static double operator +(Numero n1, Numero n2)
        {
            double dblRetorno = n1.numero + n2.numero;
            return dblRetorno;
        }

        #endregion
        #region Metodos
        /// <summary>
        /// Recive un String y devuelve el numero double, devuelve 0 si no pudo.
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        private double ValidarNumero(string strNumero)
        {

            double auxNumero = 0;
            if (double.TryParse(strNumero, out auxNumero))
            {
                return auxNumero;
            }
            return auxNumero;
        }
        /// <summary>
        /// Recibe un string y revisa si es binario 
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>retorna el numero binario ingresado como decimal en formato string. Si no es binario devuelve "No es binario"</returns>
        public static string BinarioDecimal(string binario)
        {
            string retorno = "No es binario";
            if (EsBinario(binario))
            {
                int auxRetornoInt = Convert.ToInt32(binario, 2);
                retorno = auxRetornoInt.ToString();
            }


            return retorno;
        }

        /// <summary>
        /// Convierte un numero decimal(solo la parte entera positiva) a binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>numero decimal convertido del numero binario como string</returns>
        public static string DecimalBinario(double numero)
        {
            string retorno = "Valor Inválido";

            int intNumero = (int)Math.Abs(numero); // consigo numero entero positivo
            if (intNumero > 0)
            {
                retorno = "";
                while (numero > 0)
                {

                    if (intNumero % 2 == 0)
                    {
                        retorno = "0" + retorno;
                    }
                    else
                    {
                        retorno = "1" + retorno;
                    }
                    intNumero = (int)(intNumero / 2);

                    if (intNumero == 1)
                    {
                        retorno = "1" + retorno;
                        break;
                    }
                }
                if (numero == 0)
                {
                    retorno = "0";
                }
            }
            return retorno;
        }
        /// <summary>
        /// recibo un string con un numero(me quedo con el valor absoluto y entero) y lo paso a decimal
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static string DecimalBinario(string numero)
        {
            double numeroDbl;
            string retorno = "Valor inválido";

            if (double.TryParse(numero, out numeroDbl))
            {
                numeroDbl = Math.Abs(numeroDbl);
                retorno = DecimalBinario(numeroDbl);
            }
            return retorno;
        }
        /// <summary>
        /// Recibe un string, y revisa si esta compuesto de 1 y 0.
        /// </summary>
        /// <param name="binario"> la cadena que se quiere revisar</param>
        /// <returns>true si binario, false si hay algun caracter de la cadena distinto de 1 o 0</returns>
        private static bool EsBinario(string binario)
        {
            bool retorno = false;
            foreach (char c in binario)
            {
                if (c != '0' && c != '1')
                {
                    retorno = false;
                    break;
                }
                return true;
            }
            return retorno;
        }
        #endregion
    }
}
