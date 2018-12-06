using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio43;

namespace Ejercicio46
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Competencia nueva = new Competencia(5, 10, TipoCompetencia.F1);
            Assert.IsNotNull(nueva.ListaCompetidores);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Competencia nueva = new Competencia(5, 10, TipoCompetencia.MotoCross);
            AutoF1 autito = new AutoF1(10, "sd");
            try
            {
                bool cuenta = nueva + autito;
                   
                    
            }catch(Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(CompetenciaNoDisponibleException));
            }
        }

        [TestMethod]
        public void TestMethod3()
        {
            Competencia nueva = new Competencia(5, 10, TipoCompetencia.MotoCross);
            MotoCross autito = new MotoCross(10, "asd");
            try
            {
                bool cuenta = nueva + autito;
            }
            catch (CompetenciaNoDisponibleException)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TestMethod4()
        {
            Competencia nueva = new Competencia(5, 10, TipoCompetencia.F1);
            AutoF1 autito = new AutoF1(10, "ads");
            try
            {
                bool a = nueva + autito;
                //  bool b = nueva + autito;
                bool b = (nueva == autito);
            }
            catch (Exception)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void TestMethod5()
        {
            Competencia nueva = new Competencia(5, 10, TipoCompetencia.F1);
            AutoF1 autito = new AutoF1(10, "ads");
            AutoF1 autito2 = new AutoF1(20, "adsss");
            bool a = nueva + autito;
            bool b = nueva + autito2;
            bool c = nueva - autito;
            if (nueva != autito)
                Assert.IsTrue(true);

        }   
    }
}
