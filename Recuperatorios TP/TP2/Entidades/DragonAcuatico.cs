using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public class DragonAcuatico : Dragon
    {
        private TipoDeAgua tipoDeAgua;

        public DragonAcuatico()
        {
        }
        public DragonAcuatico(Alimentacion tipoDeAlimentacion, double tamaño, string nombre) : base(tipoDeAlimentacion, tamaño, nombre)
        {
        }
        public DragonAcuatico(TipoDeAgua tipoDeAgua, Alimentacion tipoDeAlimentacion, double tamaño, string nombre) : base(tipoDeAlimentacion, tamaño, nombre)
        {
            TipoDeAgua = tipoDeAgua;
        }
        public TipoDeAgua TipoDeAgua
        {
            get { return tipoDeAgua; }
            set { tipoDeAgua = value; }
        }

        /// <summary>
        /// Alimenta a los dragones de Agua
        /// </summary>
        /// <returns>String indicando como se alimento</returns>
        public override string Alimentar()
        {
            string retorno = "";
            switch (TipoDeAgua)
            {
                case TipoDeAgua.Dulce:
                    if (this.TipoDeAlimentacion == Alimentacion.Carnivoro)
                    {
                        retorno = "Se lanza Carne al rio";
                    }
                    else if (this.TipoDeAlimentacion == Alimentacion.Hervivoro)
                    {
                        retorno = "Se lanzan Verduras al rio";
                    }
                    break;
                case TipoDeAgua.Salada:
                    if (this.TipoDeAlimentacion == Alimentacion.Carnivoro)
                    {
                        retorno = "Se lanza Carne al mar";
                    }
                    else if (this.TipoDeAlimentacion == Alimentacion.Hervivoro)
                    {
                        retorno = "Se lanzan Verduras al mar";
                    }
                    break;
            }
            return retorno;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"\nEs Acuatico vive en Agua: {TipoDeAgua.ToString()}");

            return base.ToString() + sb.ToString();
        }
    }
    public enum TipoDeAgua
    {
        Dulce,
        Salada
    }

}
