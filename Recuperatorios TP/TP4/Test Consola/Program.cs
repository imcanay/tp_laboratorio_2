using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //creo materiales los muestro y los agrego a la lista de materiales
            Console.WriteLine("*-*-*-*Creacion de materiales basicos*-*-*-*-");
            Material madera = new Material("madera");
            Material hierro = new Material("hierro");
            Material algodon = new Material("Algodon");
            Console.WriteLine("*-*-*-*-*Pruebo ToString() de materiales*-*-*-");
            Console.WriteLine(madera.ToString());
            Console.WriteLine(hierro.ToString());
            Console.WriteLine(algodon.ToString());
            Fabrica.AgregarMaterial(madera);
            Fabrica.AgregarMaterial(hierro);
            Fabrica.AgregarMaterial(algodon);
            string listadeMateriales = Fabrica.MostrarListaDeMateriales();
            Console.WriteLine(listadeMateriales);
            Console.WriteLine("*--*-**Creacion de Sillon y ropero *-*-*-**");
            Sillon sillonMadera = new Sillon("Sillon de Madera", madera, algodon);
            Ropero roperoHierro = new Ropero("Ropero de Metal", hierro, madera);
            Console.WriteLine("*--*-**Pruebo Metodos ToString() Sillon y ropero *-*-*-**");
            Console.WriteLine(sillonMadera.ToString());
            Console.WriteLine(roperoHierro.ToString());
            Fabrica.AgregarProducto(sillonMadera);
            Fabrica.AgregarProducto(roperoHierro);

            string listademuebles = Fabrica.MostrarListaDeMuebles();
            Console.WriteLine(listademuebles);

            Console.WriteLine("*-*-*-*-Test de Excepciones-*-*-*-*");
            Console.WriteLine("1)Creo un Sillon con nombre null");
            try
            {

                Sillon sillonMaderaNull = new Sillon(null, madera, algodon);
                if (sillonMaderaNull.Nombre is null)
                {
                    throw new NombreNullException();
                }

            }
            catch (NombreNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("2)Creo un sillon con material tapizado null");
            try
            {

                Sillon sillonMaterialNull = new Sillon("Material Null", madera, null);
            }
            catch (MaterialNullException ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("3)Creo un ropero con nombre null");
            try
            {
                Ropero roperoNombreNull = new Ropero(null, madera, hierro);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("4)Creo un ropero con material estante null");
            try
            {
                Ropero roperoMaterialNull = new Ropero("ropero material null", madera, null);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("*-*-*-*-*Test de Interfaces*-*-*-*");
            Console.WriteLine("*-*-*-*-*Interfaces de Ropero*-*-*-*");
            Ropero roperoBarnizable = new Ropero("ropero barnizable", madera, madera);
            Console.WriteLine(roperoBarnizable.ToString());

            Console.WriteLine(roperoBarnizable.Barnizar(EColorBarniz.Algarrobo));
            Console.WriteLine(roperoBarnizable.ToString());
            Console.WriteLine("*-*-*-*-*Interfaces de Sillon*-*-*-*");
            Sillon sillonColoreable = new Sillon("Sillon Coloreable", hierro, algodon);
            sillonColoreable.ToString();
            Console.WriteLine(sillonColoreable.PintarBase(ConsoleColor.Blue));
            Console.WriteLine(sillonColoreable.PintarSecundario(ConsoleColor.Yellow));
            Console.WriteLine(sillonColoreable.ToString());

            Console.WriteLine("*-*-*-Test de Archivador*-*-*-*");
            Console.WriteLine("*-*-*-Test de Archivador Texto*-*-*-*");

            string nombreDeArchivo = "Console Log.txt";
            string carpeta = AppDomain.CurrentDomain.BaseDirectory + @"\";
            string pathCompleto = carpeta + nombreDeArchivo;
            Texto texto = new Texto();

            texto.Guardar(pathCompleto, sillonColoreable.ToString());
            texto.Guardar(pathCompleto, roperoBarnizable.ToString());
            Console.WriteLine("*-*-*-*Test de Leer Texto*-*-*-*-**-");
            string datosLeidosTXT;
            texto.Leer(pathCompleto, out datosLeidosTXT);
            Console.WriteLine(datosLeidosTXT);

            Console.WriteLine("*-*-*-**-*Test de XML*-*-*-*-*-*");
            string nombreDeArchivoXml = "Muebles.xml";
            string carpetaXml = AppDomain.CurrentDomain.BaseDirectory + @"\";
            string pathCompletoXml = carpetaXml + nombreDeArchivoXml;
            Xml<Sillon> xmlSillon = new Xml<Sillon>();
            Xml<Sillon>.Guardar(pathCompletoXml, sillonColoreable);
            Xml<Sillon> xmlSillonALeer = new Xml<Sillon>();
            Sillon SillonLeido = new Sillon();
            Xml<Sillon>.Leer(pathCompletoXml, out SillonLeido);

            Console.WriteLine(SillonLeido);
                       
            Console.ReadKey();

        }
    }
}
