using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clase_16_Library;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                Persona p = new Persona("Pablo", "Cordoba", "100000000", Persona.ENacionalidad.Argentino);
            }
            catch(Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(DniInvalidoException));
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            try
            {
                Persona p = new Persona("Giuliano", "Tritto", "10000000", Persona.ENacionalidad.Extranjero);
            }
            catch(Exception ex)
            {
                if(ex.Equals(typeof(NacionalidadInvalidaException)))
                {
                    try
                    {
                        Persona a = new Persona("Laura", "Fernandez", "99999998", Persona.ENacionalidad.Argentino);
                    }
                    catch(Exception es)
                    {
                        Assert.IsInstanceOfType(ex, typeof(NacionalidadInvalidaException));
                    }
                }
            }
        }
    }
}
