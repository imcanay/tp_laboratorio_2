using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(Sillon))]
    [XmlInclude(typeof(Ropero))]
    public abstract class Mueble
    {

        #region Atributos
        /// <summary>
        /// nombre del Mueble
        /// </summary>
        protected string nombre;
        /// <summary>
        /// Material del que esta hecho la base del Mueble
        /// </summary>
        protected Material materialBase;

        #endregion
        #region Constructores
        protected Mueble()
        {
        }
        protected Mueble(string nombre, Material materialBase)
        {
            if (nombre == null)
            {
                throw new NombreNullException();
            }
            else
            {
            this.nombre = nombre;
            }
            if (materialBase == null)
            {
                throw new MaterialNullException("El material de la base del mueble es null");
            }
            else
            {
             this.materialBase = materialBase;
            }
      
        }
        #endregion
        #region Propiedades
        

        public abstract string Nombre
        {
            get;
            set;
            
        }
        public abstract Material MaterialBase
        {
            get;
            set;
        }



        #endregion
        #region Metodos
        /// <summary>
        /// sobreescribe el metodo ToString() 
        /// </summary>
        /// <returns>devuelve un string con la informacion del mueble</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nNombre del Mueble: " + Nombre);
            sb.Append("Base de: " + MaterialBase);
            return sb.ToString();
        }
        /// <summary>
        /// sobrecarga de operador + para agregar un mueble a una lista de muebles
        /// </summary>
        /// <param name="listaDeProductos"></param>
        /// <param name="producto"></param>
        /// <returns>La misma lista incluyendo al nuevo mueble</returns>
        public static List<Mueble> operator + (List<Mueble> listaDeProductos , Mueble producto)
        {
            listaDeProductos.Add(producto);
            return listaDeProductos;
        }
        #endregion
    }
}
