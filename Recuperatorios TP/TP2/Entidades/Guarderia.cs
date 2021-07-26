using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Guarderia
    {
        static List<Dragon> listaDeDragonesTotal;

        public static double areaTotalGuarderia = 150000; 
        public static double areaTotalBiomaAgua = 50000;
        public static double areaTotalBiomaAire = 50000;
        public static double areaTotalBiomaTierra = 50000;

        static Guarderia()
        {
            listaDeDragonesTotal = new List<Dragon>();
        }

        /// <summary>
        /// Agregar un Dragon a la lista de Dragones
        /// </summary>
        /// <param name="dragon"></param>
        /// <returns> true si pudo agregar al dragon, sino false</returns>
        public static bool AgregarDragon(Dragon dragon)
        {
            bool retorno = false;
            if (dragon.GetType() == typeof(DragonAcuatico))
            {
                if ((areaTotalBiomaAgua - dragon.Tamaño) > 0 && (areaTotalGuarderia - dragon.Tamaño) > 0)
                {                    
                    retorno = listaDeDragonesTotal + dragon;
                    areaTotalGuarderia -= dragon.Tamaño;
                    areaTotalBiomaAgua -= dragon.Tamaño;
                }
            }
            else if (dragon.GetType() == typeof(DragonTerrestre))
            {
                if ((areaTotalBiomaTierra - dragon.Tamaño) > 0 && (areaTotalBiomaTierra - dragon.Tamaño) > 0)
                {
                    retorno = listaDeDragonesTotal + dragon;
                    areaTotalGuarderia -= dragon.Tamaño;
                    areaTotalBiomaTierra -= dragon.Tamaño;
                }
            }
            else if (dragon.GetType() == typeof(DragonVolador))
            {
                if ((areaTotalBiomaAire - dragon.Tamaño) > 0 && (areaTotalBiomaAire - dragon.Tamaño) > 0)
                {
                    retorno = listaDeDragonesTotal + dragon;
                    areaTotalGuarderia -= dragon.Tamaño;
                    areaTotalBiomaAire -= dragon.Tamaño;
                }
            }
            return retorno;

        }
        /// <summary>
        /// Alimenta los dragones
        /// </summary>
        /// <returns>String indicando como alimento a cada dragon</returns>
        public static string AlimentarDragones()
        {
           
            string alimentar;
            StringBuilder sb = new StringBuilder();
            foreach (Dragon item in Guarderia.listaDeDragonesTotal)
            {
                alimentar = item.Alimentar();
                sb.Append($"\n{alimentar} para alimentar a {item.Nombre}. ");

            }
            return sb.ToString();

        }
        /// <summary>
        /// Lista todos los dragones y sus atributos
        /// </summary>
        /// <returns>un string con la informacion de todos los dragones </returns>
        public static string ListarDragones()
        {
            StringBuilder sb = new StringBuilder();
            foreach ( var item in Guarderia.listaDeDragonesTotal)
            {
                sb.AppendLine(item.ToString());
                
            }
            return sb.ToString();
        }
    
    }
}
