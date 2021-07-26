using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Texto
    {
        public Texto()
        {
        }

        /// <summary>
        /// Guarda con fecha y hora los datos recibidos como texto
        /// </summary>
        /// <param name="pathCompleto"> archivo donde se va a guardar el texto</param>
        /// <param name="datos">Datos que se quieren guardar</param>
        public void Guardar(string pathCompleto, string datos)
        {
            try
            {
                if (File.Exists(pathCompleto))
                {
                    using (StreamWriter sw = new StreamWriter(pathCompleto, true))
                    {
                        sw.WriteLine(datos + "\nAgregado el: " + DateTime.Now);
                    }
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(pathCompleto))
                    {
                        sw.WriteLine("Nuevo archivo creado en: " + DateTime.Now.ToString());
                        sw.WriteLine(datos + " \nAgregado el: " + DateTime.Now);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Lee de un archivo datos y los almacena como cadena de texto en una variable
        /// </summary>
        /// <param name="pathCompleto">path del archivo que se va a leer</param>
        /// <param name="datos">Variable donde se van a guardar los datos</param>
        /// <returns></returns>
        public bool Leer(string pathCompleto, out string datos)
        {
            StringBuilder sb = new StringBuilder();
            string linea;
            bool retorno = false;
            try
            {
                if (File.Exists(pathCompleto))
                {
                    using (StreamReader sr = new StreamReader(pathCompleto))
                    {
                        while ((linea = sr.ReadLine()) != null)
                        {
                            sb.AppendLine(linea);
                        }
                        Console.WriteLine("Se leyeron los datos del archivo");
                        retorno = true;
                    }
                }
                else
                {
                    throw new FileNotFoundException();
                }
            }
            catch (Exception)
            {
                sb.Append("No se encontro el archivo");
            }
            datos = sb.ToString();
            return retorno;
        }
    }
}

