using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Material
    {
        #region Atributos
        private string nombre;

        #endregion
        #region Constructores
        public Material()
        {
        }

        public Material(string nombre)
        {
            Nombre = nombre;
        }
        #endregion
        #region Propiedades
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        #endregion
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Nombre);
            return sb.ToString();
        }

        public static List<Material> operator +(List<Material> listaDeMateriales, Material material)
        {
            if (listaDeMateriales != material)
            {
                listaDeMateriales.Add(material);

            }

            return listaDeMateriales;
        }

        public static bool operator ==(List<Material> listaDeMaterial, Material material)
        {
            bool retorno = false;
            foreach (Material item in listaDeMaterial)
            {
                if (item.Nombre.ToLower() == material.Nombre.ToLower())
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public static bool operator !=(List<Material> listaDeMaterial, Material material)
        {
            bool retorno = false;
            if (!(listaDeMaterial == material))
            {
                retorno = true;
            }
            return retorno;
        }

        public static explicit operator Material(string nombre)
        {
            return new Material(nombre);
        }


    }
}
