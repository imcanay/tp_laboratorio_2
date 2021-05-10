using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo //agrego hereda de vehiculo
    {
        #region Constructores
        public Suv(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {            
        }
        #endregion
        #region Propiedades
        /// <summary>
        /// SUV son 'Grande'
        /// </summary>
        protected new ETamanio Tamanio  
        {
            get
            {
                return ETamanio.Grande;
            }
        }
        #endregion
        #region Metodos
        /// <summary>
        /// Muestra la informacion del SUV.
        /// </summary>
        /// <returns>retorna string con la informacion del SUV</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("TAMAÑO : "+ this.Tamanio.ToString());
            
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
