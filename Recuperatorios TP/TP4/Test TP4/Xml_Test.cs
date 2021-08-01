using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;
using System.IO;

namespace Test_TP4
{
    [TestClass]
    public class Xml_Test
    {
        [TestMethod]
        public void Xml_Test_Archivo()
        {
            string archivoPruebaXml = "prueba Xml.xml";
            string path = AppDomain.CurrentDomain.BaseDirectory + @"\";
            string pathCompleto = path + archivoPruebaXml;
            Material materialGuardado = new Material("Material de Pruebas");
            
            Xml<Material>.Guardar(pathCompleto, materialGuardado);

            Assert.IsTrue(File.Exists(pathCompleto));

        }

        [TestMethod]
        public void Xml_Test_Material()
        {
            string archivoPruebaXml = "prueba Xml.xml";
            string path = AppDomain.CurrentDomain.BaseDirectory + @"\";
            string pathCompleto = path + archivoPruebaXml;
            Material materialGuardado = new Material("Material de Pruebas");
            Material materialRetornado = new Material();
            
            Xml<Material>.Guardar(pathCompleto, materialGuardado);
            Xml<Material>.Leer(pathCompleto, out materialRetornado);

            Assert.AreEqual(materialGuardado.Nombre, materialRetornado.Nombre);

        }
    }
}
