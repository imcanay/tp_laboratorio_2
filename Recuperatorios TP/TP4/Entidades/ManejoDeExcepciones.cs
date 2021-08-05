using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public class MaterialNullException : Exception
    {
        public MaterialNullException() : base("El Material es null")
        {

        }
        public MaterialNullException(string mensaje) : base(mensaje)
        {

        }

    }
    public class NombreNullException : Exception
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
        public FaltaSeleccionException(string message) : base(message)
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

    public class MuebleNoAgregadoException : Exception
    {
        public MuebleNoAgregadoException() : base("Error en el proceso de produccion del Mueble, El mueble no se fabrico.")
        {

        }
    }
    public class SqlListaNullException : Exception
    {
        public SqlListaNullException() : base("La lista de muebles esta vacia o es null, no se guardo en la base de datos")
        {
        }
    }
    public class SqlLecturaDbException : Exception
    {
        public SqlLecturaDbException() : base("Error al leer desde la base de datos")
        {

        }
        public SqlLecturaDbException(string message, Exception ex) : base (message, ex)
        {

        }
    }
}
