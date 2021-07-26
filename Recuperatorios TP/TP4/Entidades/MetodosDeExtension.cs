using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class MetodosDeExtension
    {
        public static bool EsMadera(this Material material)
        {
            bool retorno = false;
            material.Nombre.ToLower();
            if (material.Nombre == "madera" && Fabrica.listaDeMateriales == material)
            {
                retorno = true;
            }
            return retorno;
        }

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
