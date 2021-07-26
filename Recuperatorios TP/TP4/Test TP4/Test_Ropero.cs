using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;

namespace Test_TP4
{
    [TestClass]
    public class Test_Ropero
    {
        [TestMethod]
        public void FabricarRoperoFalloMaterialBase()
        {
            string nombreRopero = "Ropero_Test1";
            Material madera = new Material("madera");
            Material materialBase = madera;
            Material hierro = new Material("hierro");
            Fabrica.AgregarMaterial(hierro);
            Material materialEstantes = hierro;
            Ropero roperoTest = new Ropero(nombreRopero, materialBase, materialEstantes);
            try
            {
                Fabrica.AgregarProducto(roperoTest);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.GetType() == typeof(MuebleNoAgregadoException));
            }
        }
        [TestMethod]
        public void FabricarRoperoFalloMaterialSecundario()
        {
            string nombreRopero = "Ropero_Test2";
            Material madera = new Material("madera");
            Fabrica.AgregarMaterial(madera);
            Material materialBase = madera;
            Material hierro = new Material("hierro");
            Material materialEstantes = hierro;
            Ropero roperoTest = new Ropero(nombreRopero, materialBase, materialEstantes);
            try
            {
                Fabrica.AgregarProducto(roperoTest);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.GetType() == typeof(MuebleNoAgregadoException));
            }


        }
        [TestMethod]

        public void FabricarRoperoSinFallos()
        {
            string nombreRopero = "Ropero_Test3";
            Material madera = new Material("madera");
            Fabrica.AgregarMaterial(madera);
            Material materialBase = madera;
            Material hierro = new Material("hierro");
            Fabrica.AgregarMaterial(hierro);
            Material materialEstantes = hierro;
            Ropero roperoTest = new Ropero(nombreRopero, materialBase, materialEstantes);
            Fabrica.AgregarProducto(roperoTest);
            Assert.IsTrue(Fabrica.listaDeMuebles.ContieneMueble(roperoTest));

        }

    }
}
