using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio44;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Centralita testCent = new Centralita("TestUnitario");
            Assert.IsNotNull(testCent.Llamadas);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Centralita testCent = new Centralita("TestUnitario");
            Local llamada = new Local("Pehuajo", 12, "Capital", 25);
            Local llamada2 = new Local("Pehuajo", 2, "Capital", 45);
            try
            {
                testCent += llamada;
                testCent += llamada2;
            }
            catch(Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(CentralitaException));
            }           
        }

        [TestMethod]
        public void TestMethod3()
        {
            Centralita testCent = new Centralita("TestUnitario");
            Provincial llamada = new Provincial("Pehuajo", Franja.Franja_1, 2, "Curaru");
            Provincial llamada2 = new Provincial("Pehuajo", Franja.Franja_2, 3, "Curaru");
            try
            {
                testCent += llamada;
                testCent += llamada2;
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(CentralitaException));
            }
        }

        [TestMethod]
        public void TestMethod4()
        {
            Centralita testCent = new Centralita("TestUnitario");
            Provincial llamada = new Provincial("Pehuajo", Franja.Franja_1, 2, "Curaru");
            Provincial llamada2 = new Provincial("Pehuajo", Franja.Franja_2, 3, "Curaru");
            Local llamada3 = new Local("Pehuajo", 12, "Capital", 25);
            Local llamada4 = new Local("Pehuajo", 2, "Capital", 45);

            Assert.IsTrue(llamada == llamada2);
            Assert.IsTrue(llamada != llamada3);
            Assert.IsTrue(llamada != llamada4);
            Assert.IsTrue(llamada2 != llamada3);
            Assert.IsTrue(llamada2 != llamada4);
            Assert.IsTrue(llamada3 == llamada4);
        }
    }
}
