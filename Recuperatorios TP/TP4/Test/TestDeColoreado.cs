using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;

namespace Test
{
    [TestClass]
    public class TestDeColoreado
    {
        [TestMethod]
        public void sillonColoreando()
        {
            //arrange
            Material madera = new Material("madera");
            Material algodon = new Material("algodon");
            Sillon sillonDefault = new Sillon("Sillon Madera y algodon", madera, algodon);
            ConsoleColor color = ConsoleColor.Red;
            //act
            bool response = sillonDefault.PintarBase(color);

            //assert
            Assert.IsTrue(response);


        }
    }
}
