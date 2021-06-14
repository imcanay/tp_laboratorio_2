using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    class ManejoDeArchivos
    {
        /// <summary>
        /// Guarda en un archivo ubicado en "path" los datos recibidos en "datos"
        /// </summary>
        /// <param name="path"> El path del archivo a donde se van a escribir los datos</param>
        /// <param name="datos">Datos que se van a escribir en el archivo</param>
        /// <returns>bool indicando si se guardo(true) o no (false)</returns>
        public static bool GuardarTexto(string path, string datos)
        {
            bool retorno = true;
            StreamWriter writer = new StreamWriter(path);
            using (writer)
            {
                writer.WriteLine(datos);
                if (!File.Exists(path))
                {
                    retorno = false;
                }
            }
                return retorno;
        }

        public static string LeerTexto(string path)
        {
            string textoLeido = "";
            if (File.Exists(path))
            {
                StreamReader reader = new StreamReader(path);
                textoLeido += reader.ReadToEnd();
            }

            return textoLeido;
        }

        //serializacion
        public static bool SerializarXml<T>(T objeto, string path)
        {
            bool retorno = true;
            XmlSerializer serializer = new XmlSerializer(typeof(T));//tipo de objeto a serializar
            XmlTextWriter writerXml = new XmlTextWriter(path, Encoding.UTF8);//donde se guarda y como
            using(writerXml)
            {
                try
                {
                    serializer.Serialize(writerXml, objeto);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    retorno = false;
                }
            }
                return retorno;
        }
        public static T DeserealizarXml<T>(string path)
        {
            if (!File.Exists(path))
            {
                return default;
            }
            XmlTextReader readerXml = new XmlTextReader(path);
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            T retorno = default(T);
            using (readerXml)
            {
                try
                {

                retorno = (T)serializer.Deserialize(readerXml);
                }
                catch (Exception)
                {

                    return default;
                }
            }
            return retorno;
        }
    }
}
