using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;



namespace Archivador
{
    public class Xml<T> where T : new()
    {
        /// <summary>
        /// Guarda un objeto de tipo T en el archivo indicado en el path
        /// </summary>
        /// <param name="pathCompleto"> Path del archivo donde se va a guardar</param>
        /// <param name="datos"> Objeto de tipo T que se va a guardar</param>
        public static void Guardar(string pathCompleto, T datos)
        {
            
            using (XmlTextWriter writer = new XmlTextWriter (pathCompleto, Encoding.UTF8))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));//o capaz no es T y es datos
                serializer.Serialize(writer, datos);
            }
            Console.WriteLine("Objeto Serializado");
           
        }
        /// <summary>
        /// Lee un objeto de un archivo y lo guarda en la variable indicada.
        /// </summary>
        /// <param name="pathCompleto"> Archivo del que se va leer></param>
        /// <param name="datos">A donde se van a guardar los datos </param>
        public static void Leer(string pathCompleto, out T datos)
        {
            T datosAx = new T();             
            try
            {
                using (XmlTextReader reader = new XmlTextReader(pathCompleto))
                {
                 XmlSerializer serializer = new XmlSerializer(typeof(T));
                    datosAx = (T)serializer.Deserialize(reader);
                 Console.WriteLine("se deserealizo el documento XML y se guardo el dato");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine("error no se pudo deserealizar");
            }

            datos = datosAx;
            
        }
    }
}
