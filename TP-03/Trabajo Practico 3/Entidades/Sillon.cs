using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Sillon : Mueble, IColoreable
    {
        #region Atributos
        /// <summary>
        /// Material del que esta hecho el tapizado
        /// </summary>
        private Material materialTapizado;
        /// <summary>
        /// Color de la base del sillon
        /// </summary>
        private ConsoleColor colorBase;
        /// <summary>
        /// Color del tapizado
        /// </summary>
        private ConsoleColor colorTapizado;
        #endregion
        #region Propiedades
        public override string Nombre 
        {
            get { return this.nombre; }
            set { this.nombre = value; }

        }
        public override Material MaterialBase 
        {
            get { return this.materialBase; }
            set { materialBase = value; }
        }

        public  Material MaterialTapizado 
        {
            get { return materialTapizado; }
            set { materialTapizado = value; }
        }

        public ConsoleColor ColorBase 
        {
            get { return colorBase; }
            set { colorBase = value; }
        }
        public ConsoleColor ColorTapizado 
        {            
            get { return colorTapizado; }
            set { colorTapizado = value; }
        }

        #endregion
        #region Metodos
        /// <summary>
        /// Sobreescritura del metodo ToString()
        /// </summary>
        /// <returns>devuelve string con la informacion del sillon</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append("Tapizado de:  " + MaterialTapizado.ToString());
            sb.Append("El color de la base es: " + ColorBase + "\nel color del tapizado es: " + ColorTapizado);
            return sb.ToString();
        }
        /// <summary>
        /// Metodo que cambia el color de la base del sillon
        /// </summary>
        /// <param name="color"></param>
        /// <returns>booleano indicando si pudo hacer el cambio</returns>
        public bool PintarBase(ConsoleColor color)
        {
            bool retorno;
            try
            {
                this.ColorBase = color;
                retorno = true;
            }
            catch (Exception)
            {
                retorno = false;
            }            
            return retorno;
        }
        /// <summary>
        /// Metodo que cambia el color del tapizado del sillon
        /// </summary>
        /// <param name="color"></param>
        /// <returns>booleano indicando si pudo hacer el cambio</returns>
        public bool PintarSecundario(ConsoleColor color)
        {
            bool retorno;
            try
            {
                this.ColorTapizado = color;
                retorno = true;
            }
            catch (Exception)
            {
                retorno = false;
            }           
            return retorno;
        }
        #endregion
        #region Constructores

        public Sillon() : base()
        {
           
        }

        public Sillon(string nombre, Material materialBase) : base(nombre, materialBase )
        {
            
        }
        public Sillon(string nombre, Material materialBase, Material materialTapizado) : base(nombre, materialBase)
        {
            if (materialTapizado == null)
            {
                throw new MaterialNullException("el material del tapizado es null");
            }
            else
            {
            this.MaterialTapizado = materialTapizado;
            }
            
        }
        #endregion
    }
}
