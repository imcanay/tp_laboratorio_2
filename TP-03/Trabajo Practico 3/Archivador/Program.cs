using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivador
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreDeArchivo="";
            string Carpeta = AppDomain.CurrentDomain.BaseDirectory + "\\";
            string pathCompleto = Carpeta + nombreDeArchivo;
            try
            {
                    nombreDeArchivo = "Texto.txt";
                if (File.Exists(pathCompleto))
                {
                    using (StreamWriter sw = new StreamWriter(pathCompleto,true))
                    {
                        sw.Write("Date: " + DateTime.Now);
                    }
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(pathCompleto))
                    {
                        sw.Write("nuevo archivo creado en: " + DateTime.Now.ToString());
                                                
                    }
                }

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            
        }
    }
}
