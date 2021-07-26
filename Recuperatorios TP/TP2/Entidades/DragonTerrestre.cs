using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DragonTerrestre : Dragon
    {
        private TipoDeSuperficie tipoDeSuperficie;

        public TipoDeSuperficie TipoDeSuperficie
        {
            get { return tipoDeSuperficie; }
            set { tipoDeSuperficie = value; }
        }

        public DragonTerrestre()
        {

        }

        public DragonTerrestre(Alimentacion tipoDeAlimentacion, double tamaño, string nombre) : base(tipoDeAlimentacion, tamaño, nombre)
        {
        }

        public DragonTerrestre(TipoDeSuperficie tipoDeSuperficie, Alimentacion tipoDeAlimentacion, double tamaño, string nombre) : base(tipoDeAlimentacion, tamaño, nombre)
        {
            TipoDeSuperficie = tipoDeSuperficie;
        }
        /// <summary>
        /// Alimenta a los dragones Terrestres
        /// </summary>
        /// <returns>String indicando como se alimento</returns>
        public override string Alimentar()
        {
            string retorno = "";

            switch (TipoDeSuperficie)
            {
                case TipoDeSuperficie.Subterraneo:
                    if (this.TipoDeAlimentacion == Alimentacion.Carnivoro)
                    {
                        retorno = "Se entierra Carne bajo tierra";
                    }
                    else if (this.TipoDeAlimentacion == Alimentacion.Hervivoro)
                    {
                        retorno = "Se entierran Verduras bajo tierra";
                    }
                    break;
                case TipoDeSuperficie.Superficial:
                    if (this.TipoDeAlimentacion == Alimentacion.Carnivoro)
                    {
                        retorno = "Se lanza Carne a la planicie";
                    }
                    else if (this.TipoDeAlimentacion == Alimentacion.Hervivoro)
                    {
                        retorno = "Se lanzan Verduras a la planicie";
                    }
                    break;
            }


            return retorno;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"\nEs Terrestre  en: {TipoDeSuperficie.ToString()}");

            return base.ToString() + sb.ToString();
        }
    }
    public enum TipoDeSuperficie
    {
        Subterraneo,
        Superficial
    }
}
