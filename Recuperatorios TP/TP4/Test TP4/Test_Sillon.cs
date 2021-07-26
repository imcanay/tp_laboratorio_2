using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;

namespace Test_TP4
{
    [TestClass]
    public class Test_Sillon
    {
        [TestMethod]
        
        public void FabricarSillonFalloMaterialBase()
        {
            string nombreSillon = "Sillon_Test1";
            Material madera = new Material("madera");
            Material materialBase = madera;
            Material algodon = new Material("algodon");
            Fabrica.AgregarMaterial(algodon);
            Material materialTapizado = algodon;
            Sillon sillonTest = new Sillon(nombreSillon, materialBase, materialTapizado);
            try
            {
                Fabrica.AgregarProducto(sillonTest);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.GetType() == typeof(MuebleNoAgregadoException));
            }
        }
        [TestMethod]
        public void FabricarSillonFalloMaterialSecundario()
        {
            string nombreSillon = "Sillon_Test2";
            Material madera = new Material("madera");
            Fabrica.AgregarMaterial(madera);
            Material materialBase = madera;
            Material algodon = new Material("algodon");
            Material materialTapizado = algodon;
            Sillon sillonTest = new Sillon(nombreSillon, materialBase, materialTapizado);
            try
            {
                Fabrica.AgregarProducto(sillonTest);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.GetType() == typeof(MuebleNoAgregadoException));
            }
           
            
        }
        [TestMethod]
        
        public void FabricarSillonSinFallos()
        {
            string nombreSillon = "Sillon_Test3";
            Material madera = new Material("madera");
            Fabrica.AgregarMaterial(madera);
            Material materialBase = madera;
            Material algodon = new Material("algodon");
            Fabrica.AgregarMaterial(algodon);
            Material materialTapizado = algodon;
            Sillon sillonTest = new Sillon(nombreSillon, materialBase, materialTapizado);
            Fabrica.AgregarProducto(sillonTest);
            Assert.IsTrue(Fabrica.listaDeMuebles.ContieneMueble(sillonTest));

        }
    }
}
