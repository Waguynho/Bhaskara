using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bhaskara;

namespace TestaBhaskara
{
    [TestClass]
    public class TesteBhaskara1
    {
        private Bhaskara.Bhaskara bhask1;
        private Bhaskara.Bhaskara bhask2;

        [TestInitialize]
        public void Inicializa()
        {
            bhask1 = new Bhaskara.Bhaskara(1, 5, 6);
            bhask2 = new Bhaskara.Bhaskara(8, 8, 9);
        }

        [TestMethod]
        public void TestaX1() {

            Assert.AreEqual(-2, bhask1.getX1());
        }

        [TestMethod]
        public void TestaX2()
        {

            Assert.AreEqual(-3, bhask1.getX2());
        }

        [TestMethod]
        public void TestaDelta()
        {
            bhask1.getX1();
            Assert.AreEqual(1, bhask1.getDelta());
        }

        [TestMethod]
        [ExpectedException(typeof(Bhaskara.Ex_AZero))]
       public void TestaAZeroExcessao() {

          Bhaskara.Bhaskara  bhask2 = new Bhaskara.Bhaskara(0, 5, 6);
         
       }

        [TestMethod]
        [ExpectedException(typeof(Bhaskara.Ex_Delta_Negativo))]
        public void TestaDeltaNegativoExcessao()
        {

            bhask2.getX1();

        }

        [TestMethod]       
        public void TestaDeltaZero()
        {
            bhask2 = new Bhaskara.Bhaskara(4, 4, 1);

            Assert.AreEqual(0, bhask2.getDelta());

        }

       
      

    }
}
