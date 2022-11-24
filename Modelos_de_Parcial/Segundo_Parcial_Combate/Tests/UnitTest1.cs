using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(BusinessException))]
        public void Personaje_DeberiaLanzarBusinessException_CuandoRecibenivelInvalido()
        {
             Guerrero guerrero = new Guerrero(1, "Juan", 200);
            
           
        }
         [TestMethod]
        public void Personaje_DeberiaTenerNivelDeVidaMayorACero_CuandoRecibeAtaque()
        {
             Guerrero guerrero = new Guerrero(1, "Juan", 50);

            guerrero.RecibirAtaque(10);

            Assert.IsTrue(guerrero.PuntosDeVida > 0);
        }
         [TestMethod]
        public void Personaje_DeberiaTener200PuntosDeDefensa_CuandoNivelEs2()
        {
             Guerrero guerrero = new Guerrero(1, "Juan", 2);


            Assert.AreEqual(200, guerrero.PuntosDeDefensa);
        }
    }
}
