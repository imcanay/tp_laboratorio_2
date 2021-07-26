using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        public static double Operar(Numero num1, Numero num2, char operador)
        {
            double retorno;
            if (num1 is null)
            {
                throw new ArgumentNullException(nameof(num1));
            }

            if (num2 is null)
            {
                throw new ArgumentNullException(nameof(num2));
            }
            string operacion = ValidarOperador(operador);
           
                switch (operacion)
                {
                    case "-":
                    retorno = num1 - num2;
                        break;
                    case "*":
                    retorno = num1 * num2;
                        break;
                    case "/":
                    retorno = num1 / num2;
                        break;

                    default:
                    operacion = "+";
                    retorno = num1 + num2;
                        break;
                }
            return retorno;
        }

        private static string ValidarOperador(char operador)
        {
            string retorno = "+";
            if (operador == '+' || operador == '-' || operador == '*' || operador == '/')
            {
                switch (operador)
                {
                    default:
                        operador = '+';
                        retorno = operador.ToString();
                        break;
                    case '+':
                        retorno = operador.ToString();
                        break;
                    case '-':
                        retorno = operador.ToString();
                        break;
                    case '*':
                        retorno = operador.ToString();
                        break;
                    case '/':
                        retorno = operador.ToString();
                        break;

                }
            }
            return retorno;
        }
    }
}
