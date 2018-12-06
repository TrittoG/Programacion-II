using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio42;

namespace Ejercicio45
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                Class1 nuevo = new Class1();
            }
            catch(Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(DivideByZeroException));
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            try
            {
                Class1.MiException();
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(DivideByZeroException));
            }
        }

        [TestMethod]
        public void TestMethod3()
        {
            try
            {
                Class2 nueva = new Class2();
            }
            catch(Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(UnaException));
            }
        }
    }
}
