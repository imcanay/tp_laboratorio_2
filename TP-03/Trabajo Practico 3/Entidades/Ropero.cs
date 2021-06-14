using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Ropero : Mueble, IBarnizable, IColoreable
    {
        #region Atributos
        /// <summary>
        /// material del que estan hechos los estantes
        /// </summary>
        private Material materialEstantes;
        /// <summary>
        /// color del barniz utilizado en la estructura base
        /// </summary>
        private EColorBarniz colorBarniz = EColorBarniz.Sin;
        /// <summary>
        /// color de la base
        /// </summary>
        private ConsoleColor colorBase;
        /// <summary>
        /// color de los estantes
        /// </summary>
        private ConsoleColor colorEstantes;

        #endregion

        #region Propiedades
        /// <summary>
        /// Material del que estan hechos los estantes
        /// </summary>
        public Material MaterialEstantes
        {
            get { return this.materialEstantes; }
            set {this.materialEstantes = value;}
        }
        /// <summary>
        /// Nombre del Ropero
        /// </summary>
        public override string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value;}
            
        }
        /// <summary>
        /// Material Base del que esta hecho el ropero
        /// </summary>
        public override Material MaterialBase
        {
            get { return this.materialBase; }
            set { this.materialBase = value; }
            
        }
       
        /// <summary>
        /// Color del barniz  del ropero
        /// </summary>
        public EColorBarniz ColorBarniz
        {
            get { return colorBarniz; }
            set { colorBarniz = value; }
        }
        /// <summary>
        /// Color de la base del ropero
        /// </summary>
        public ConsoleColor ColorBase 
        {
            get { return colorBase; }
            set { colorBase = value; }
        }
        /// <summary>
        /// Color de los estantes del ropero
        /// </summary>
        public ConsoleColor ColorEstantes
        {
            get { return colorEstantes; }
            set { colorEstantes = value; }
        }



        #endregion
        #region Constructores
        public Ropero():base()
        {
        }
        public Ropero(string nombre, Material materialBase) :base(nombre,materialBase)
        {
            
        }

        public Ropero(string nombre, Material materialBase,  Material materialEstantes) :base(nombre,materialBase)
        {
            if (materialEstantes == null)
            {
                throw new MaterialNullException("El material del estante es null");
            }
            else
            {
            this.MaterialEstantes = materialEstantes;
            }
            
        }

        #endregion
        #region Metodos
        /// <summary>
        /// Sobrecarga del metodo ToString para Roperos
        /// </summary>
        /// <returns>Devuelve una cadena con la informacion del ropero</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            switch (this.materialBase.Nombre)
            {
                case "madera":
            sb.Append("El color del Barniz es: " + ColorBarniz.ToString());
                    break;
                default:
                    sb.Append("El color del ropero es: " + ColorBase.ToString());
                    break;
            }
            sb.Append("\nEstantes de: " + MaterialEstantes.ToString() + "color: " + ColorEstantes);            
            
            return sb.ToString();
        }

        /// <summary>
        /// funcion que barniza un ropero de madera
        /// </summary>
        /// <param name="colorBarniz"> color del barniz a apalicar</param>
        /// <returns>booleano indicando si pudo realizar el barnizado</returns>
        public bool  Barnizar(EColorBarniz colorBarniz)
        {
            bool retorno;
            if (this.materialBase.Nombre=="madera") //aca puede ir un no es de madera exception
            {
            ColorBarniz = colorBarniz;
                retorno = true;
            }
            else
            {
                retorno = false;
            }
            return retorno;
        }
        /// <summary>
        /// Pinta la base del ropero de un color
        /// </summary>
        /// <param name="color"></param>
        /// <returns>booleano indicando si pudo pintar</returns>
        public bool PintarBase(ConsoleColor color)
        {
            bool retorno;
            try
            {
            ColorBase = color;
            retorno = true;

            }
            catch (Exception)
            {

                retorno = false;
            }
            return retorno;
        }
        /// <summary>
        /// Pinta la repisa de un ropero
        /// </summary>
        /// <param name="color"></param>
        /// <returns>booleano indicando si pudo pintar</returns>
        public bool PintarSecundario(ConsoleColor color)
        {
            bool retorno;
            try
            {
            ColorEstantes = color;
            retorno = true;
            }
            catch (Exception)
            {
                throw;
            }
            return retorno;
        }

        #endregion
    }

}

