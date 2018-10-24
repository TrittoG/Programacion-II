using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio41;
using Central_Telefonica;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Local loc = new Local("111",20,)
            Centralita cen = new Centralita("carlito");

            Assert.IsNotNull(cen.Llamadas);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Centralita cen = new Centralita("carlo");
            
            Local loc = new Local("origen", 10,"destino", 20);
            Local loca = new Local("origen", 15, "destino", 25);

            try
            {
                cen += loc;
                cen += loca;
            }
            catch(Exception ex)
            {
                Assert.
            }
        }


    }
}
