using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        #region Atributos
        ETipo tipo;
        #endregion
        #region Enumerados
        public enum ETipo 
        { 
            CuatroPuertas, 
            CincoPuertas 
        }
        #endregion
        #region Constructores
        /// <summary>
        /// Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
            this.tipo = ETipo.CuatroPuertas;
        }

        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo): base(chasis, marca, color) //genero constructor con tipo heredando del constructor base
        {
            this.tipo = tipo;
        }
        #endregion
        #region Propiedades
        /// <summary>
        /// Sedan son 'Mediano'
        /// </summary>
        protected new ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }
        #endregion
        #region Metodos
        /// <summary>
        /// Muestra la informacion de un Sedan
        /// </summary>
        /// <returns>retorna un string con la informacion de un Sedan</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.Append("TAMAÑO : "+ this.Tamanio);
            sb.AppendLine("TIPO : " + this.tipo); 
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
