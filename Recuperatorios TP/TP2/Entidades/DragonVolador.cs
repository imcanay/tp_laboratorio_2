using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DragonVolador : Dragon
    {
        
        private TipoDeNido tipoDeNido;

        public TipoDeNido DondeAnida
        {
            get { return tipoDeNido; }
            set { tipoDeNido = value; }
        }

        public DragonVolador()
        {

        }

        public DragonVolador(Alimentacion tipoDeAlimentacion, double tamaño, string nombre) : base(tipoDeAlimentacion, tamaño, nombre)
        {
        }

        public DragonVolador(TipoDeNido dondeAnida, Alimentacion tipoDeAlimentacion, double tamaño, string nombre) : base(tipoDeAlimentacion, tamaño, nombre)
        {
            DondeAnida = dondeAnida;
        }
        /// <summary>
        /// Alimenta a los dragones voladores
        /// </summary>
        /// <returns>String indicando como se alimento</returns>
        public override string Alimentar()
        {
            string retorno = "";
            if (this.TipoDeAlimentacion == Alimentacion.Carnivoro)
            {
                retorno = "Se lanza Carne al aire";
            }
            else if (this.TipoDeAlimentacion == Alimentacion.Hervivoro)
            {
                retorno = "Se lanzan Verduras al aire";
            }

            return retorno;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"\nEs Volador Anida en: {DondeAnida.ToString()}");

            return base.ToString() + sb.ToString();
        }
    }
    public enum TipoDeNido
    {
        Arboles,
        Acantilados
    }
}
