using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class MetodosDeExtension
    {
        /// <summary>
        /// Metodo de extension que corrobora si un material es del mismo tipo que el indicado
        /// </summary>
        /// <param name="material"> material a comparar</param>
        /// <param name="nombreMaterial">material con el que se compara</param>
        /// <returns>true si es el mismo material</returns>
        public static bool EsMaterial(this Material material, string nombreMaterial)
        {
            bool retorno = false;
            string nombreMaterialAx = material.Nombre.ToLower().Trim();
            nombreMaterial = nombreMaterial.ToLower();
            if (nombreMaterialAx == nombreMaterial)
            {
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Metodo de extension que corrobora si un mueble esta en una lista.
        /// </summary>
        /// <param name="listaDeMuebles"> lista que va a corroborar</param>
        /// <param name="mueble">mueble a comparar</param>
        /// <returns>true si el mueble esta en la lista</returns>
        public static bool ContieneMueble(this List<Mueble> listaDeMuebles, Mueble mueble)
        {
            bool retorno = false;
            foreach (Mueble item in listaDeMuebles)
            {
                if (item.Equals(mueble))
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;

        }
    }
}
