using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public abstract class Dragon
    {
        private double tamaño;
        private string nombre;
        private Alimentacion alimentacion;

        public Dragon()
        {

        }

        protected Dragon(Alimentacion tipoDeAlimentacion, double tamaño, string nombre)
        {
            TipoDeAlimentacion = tipoDeAlimentacion;
            Tamaño = tamaño;
            Nombre = nombre;
        }

        public Alimentacion TipoDeAlimentacion
        {
            get { return alimentacion; }
            set { alimentacion = value; }
        }
        public double Tamaño
        {
            get { return tamaño; }
            set { tamaño = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public abstract string Alimentar();

        public static bool operator +(List<Dragon> listaDeDragones , Dragon dragon)
        {
            bool retorno = false;
            if (!(listaDeDragones==dragon))
            {
                listaDeDragones.Add(dragon);
                retorno = true;
            }

            return retorno;
        }

        public static bool operator ==(List<Dragon> listaDeDragones, Dragon dragon)
        {
            bool retorno = false;
            foreach (Dragon item in listaDeDragones)
            {
                if (item.Nombre == dragon.Nombre)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;

        }
        public static bool operator !=(List<Dragon> listaDeDragones, Dragon dragon)
        {
            bool retorno = true;

            foreach (Dragon item in listaDeDragones)
            {
                if (!(item.Nombre == dragon.Nombre))
                {
                    retorno = false;
                    break;
                }
            }
            return retorno;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.Nombre} mide:{this.Tamaño} mts es: {this.TipoDeAlimentacion.ToString()}");
            return sb.ToString();
        }


    }
    public enum TiposDeDragon
    {
        Acuatico,
        Volador,
        Terrestre
    }
    public enum Alimentacion
    {
        Carnivoro,
        Hervivoro
    }
}
