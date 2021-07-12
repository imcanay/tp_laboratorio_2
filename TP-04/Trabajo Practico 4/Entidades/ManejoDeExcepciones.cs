using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class MaterialNullException: Exception
    {
        public MaterialNullException():base("El Material es null")
        {
            
        }
        public MaterialNullException(string mensaje) : base(mensaje)
        {

        }

    }
    public class NombreNullException: Exception
    { 
        public NombreNullException() : base("El Nombre es null o vacio")
        {
         
        }
    }

    public class FaltaSeleccionException : Exception
    {
        public FaltaSeleccionException() : base("Algun elemento del formulario no fue correctamente seleccionardo")
        {

        }

    }
    public class BarnizarSillaException : Exception
    {
        public BarnizarSillaException() : base("En esta fabrica no barnizamos sillas por que quedan feas")
        {

        }
    }
    public class BarnizarEstantesException : Exception
    {
        public BarnizarEstantesException() : base("En esta fabrica se barnizan los estantes del mismo color que el resto del mueble")
        {

        }
    
    }
    public class ListaBDInvalidaException : Exception
    {
        public ListaBDInvalidaException() : base("La lista de la base de datos no es valida")
        {

        }
    }
}
