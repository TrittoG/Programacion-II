using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        int contador = 0;

        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                Votacion vot = new Votacion();

                SerializarXML<Votacion> ser = new SerializarXML<Votacion>();

                ser.Guardar(null, vot); //null para que entre al catch
            }
            catch (Exception e)
            {

                Assert.IsInstanceOfType(e, typeof(ErrorArchivoException));
            }
        }


        [TestMethod]
        public void TestMethod2()
        {

            System.Collections.Generic.Dictionary<string, Votacion.EVoto> senadores;
            senadores = new System.Collections.Generic.Dictionary<string, Votacion.EVoto>();

            senadores.Add("NICOLAS", Votacion.EVoto.Negativo);
            senadores.Add("NICOLAO", Votacion.EVoto.Negativo);
            senadores.Add("Giuliano", Votacion.EVoto.Afirmativo);
            Votacion v = new Votacion("nombre", senadores);

            //agrego al evento el contador para ver cuantas veces 
            v.EventoVotoEfectuado += Contador;

            v.Simular();

            //si la cantidad de veces que usa el evento es igual a los senadores
            Assert.AreEqual(senadores.Count, contador);
        }


        /// <summary>
        /// Contador para ver cuantas veces se llama al evento
        /// </summary>
        /// <param name="str"></param>
        /// <param name="eVoto"></param>
        public void Contador(string str, Votacion.EVoto eVoto)
        {
            contador++;
        }

    }
}
