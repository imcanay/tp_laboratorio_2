using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo 
    {
        #region Atributos
        private string chasis;
        private ConsoleColor color;
        private EMarca marca; 
        #endregion
        #region Propiedades
        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
         protected  ETamanio Tamanio 
        {
            get;
        
        } 
        #endregion
        #region Enumerados 
        public enum EMarca 
        {
            Chevrolet,
            Ford,
            Renault,
            Toyota,
            BMW,
            Honda,
            HarleyDavidson
        }
        public enum ETamanio
        {
            Chico,
            Mediano,
            Grande
        }
        #endregion
        #region Constructores
        public Vehiculo(string chasis, EMarca marca, ConsoleColor color) 
        {
            this.color = color;
            this.chasis = chasis;
            this.marca = marca;
        }
        #endregion
        #region Metodos 
        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar() 
        {
            return (string)this; 
        }
        #endregion
        #region Sobrecargas de Operadores y Casteos
        /// <summary>
        /// casteo explicito de Vehiculo a String
        /// </summary>
        /// <param name="p"> el vehiculo que se va a castear</param>
        public static explicit operator string(Vehiculo p) 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CHASIS: "+ p.chasis.ToString()); 
            sb.AppendLine("MARCA : "+ p.marca.ToString());
            sb.AppendLine("COLOR : "+ p.color.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString(); 
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns>retorna true si son iguales</returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns>retorna true si son falsos</returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis != v2.chasis); 
        }
        #endregion
    }
}
