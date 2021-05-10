using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        #region Constructores
        public Ciclomotor(EMarca marca, string chasis,  ConsoleColor color) :base(chasis, marca, color)
        {
        }
        #endregion
        #region Propiedaddes
        /// <summary>
        /// Ciclomotor son 'Chico'
        /// </summary>
        protected new ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }
        #endregion
        #region Metodos
        /// <summary>
        /// Muestra la informacion de un Ciclomotor
        /// </summary>
        /// <returns>Retorna un string con la informacion de un Ciclomotor</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("TAMAÑO : "+ this.Tamanio);
            
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
