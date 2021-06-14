using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;

namespace Test
{
    [TestClass]
    public class TestDeBarnizado
    {

        [TestMethod]
       
        public void roperoBarnizar()
        {
            //arrange
            Material madera = new Material("madera");
            Material hierro = new Material("hierro");
            Ropero roperoDefault = new Ropero("Ropero Madera y Hierro", madera, hierro);
            EColorBarniz colorBarniz = EColorBarniz.Algarrobo;
            //act
            bool response = roperoDefault.Barnizar(colorBarniz);
            
            //assert
            Assert.IsTrue(response);
            

        }
    }
}
