using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConversorNumerosRomanos;

namespace ConversorNumerosRomanosTest
{
    [TestClass]
    public class NumerosArabicosParaRomanosTest
    {

        [TestMethod]
        public void DeveRetornarI()
        {
            NumerosArabicosParaRomanos conversor = new NumerosArabicosParaRomanos(1);
            Assert.AreEqual("I", conversor.NumeroRomano);
        }

        [TestMethod]
        public void DeveRetornarIII()
        {
            NumerosArabicosParaRomanos conversor = new NumerosArabicosParaRomanos(3);
            Assert.AreEqual("III", conversor.NumeroRomano);
        }

        [TestMethod]
        public void DeveRetornarIV()
        {
            NumerosArabicosParaRomanos conversor = new NumerosArabicosParaRomanos(4);
            Assert.AreEqual("IV", conversor.NumeroRomano);
        }

        [TestMethod]
        public void DeveRetornarV()
        {
            NumerosArabicosParaRomanos conversor = new NumerosArabicosParaRomanos(5);
            Assert.AreEqual("V", conversor.NumeroRomano);
        }

        [TestMethod]
        public void DeveRetornarVII()
        {
            NumerosArabicosParaRomanos conversor = new NumerosArabicosParaRomanos(7);
            Assert.AreEqual("VII", conversor.NumeroRomano);
        }

        [TestMethod]
        public void DeveRetornarIX()
        {
            NumerosArabicosParaRomanos conversor = new NumerosArabicosParaRomanos(9);
            Assert.AreEqual("IX", conversor.NumeroRomano);
        }

        [TestMethod]
        public void DeveRetornarX()
        {
            NumerosArabicosParaRomanos conversor = new NumerosArabicosParaRomanos(10);
            Assert.AreEqual("X", conversor.NumeroRomano);
        }

        [TestMethod]
        public void DeveRetornarXV()
        {
            NumerosArabicosParaRomanos conversor = new NumerosArabicosParaRomanos(15);
            Assert.AreEqual("XV", conversor.NumeroRomano);
        }

        [TestMethod]
        public void DeveRetornarXX()
        {
            NumerosArabicosParaRomanos conversor = new NumerosArabicosParaRomanos(20);
            Assert.AreEqual("XX", conversor.NumeroRomano);
        }

        [TestMethod]
        public void DeveRetornarXL()
        {
            NumerosArabicosParaRomanos conversor = new NumerosArabicosParaRomanos(40);
            Assert.AreEqual("XL", conversor.NumeroRomano);
        }

        [TestMethod]
        public void DeveRetornarL()
        {
            NumerosArabicosParaRomanos conversor = new NumerosArabicosParaRomanos(50);
            Assert.AreEqual("L", conversor.NumeroRomano);
        }

        [TestMethod]
        public void DeveRetornarLXXIII()
        {
            NumerosArabicosParaRomanos conversor = new NumerosArabicosParaRomanos(73);
            Assert.AreEqual("LXXIII", conversor.NumeroRomano);
        }

        [TestMethod]
        public void DeveRetornarXC()
        {
            NumerosArabicosParaRomanos conversor = new NumerosArabicosParaRomanos(90);
            Assert.AreEqual("XC", conversor.NumeroRomano);
        }

        [TestMethod]
        public void DeveRetornarCXLIX()
        {
            NumerosArabicosParaRomanos conversor = new NumerosArabicosParaRomanos(149);
            Assert.AreEqual("CXLIX", conversor.NumeroRomano);
        }

        [TestMethod]
        public void DeveRetornarCD()
        {
            NumerosArabicosParaRomanos conversor = new NumerosArabicosParaRomanos(400);
            Assert.AreEqual("CD", conversor.NumeroRomano);
        }

        [TestMethod]
        public void DeveRetornarD()
        {
            NumerosArabicosParaRomanos conversor = new NumerosArabicosParaRomanos(500);
            Assert.AreEqual("D", conversor.NumeroRomano);
        }

        [TestMethod]
        public void DeveRetornarCM()
        {
            NumerosArabicosParaRomanos conversor = new NumerosArabicosParaRomanos(900);
            Assert.AreEqual("CM", conversor.NumeroRomano);
        }

        [TestMethod]
        public void DeveRetornarM()
        {
            NumerosArabicosParaRomanos conversor = new NumerosArabicosParaRomanos(1000);
            Assert.AreEqual("M", conversor.NumeroRomano);
        }

        [TestMethod]
        public void DeveRetornarMD()
        {
            NumerosArabicosParaRomanos conversor = new NumerosArabicosParaRomanos(1500);
            Assert.AreEqual("MD", conversor.NumeroRomano);
        }

        [TestMethod]
        public void DeveRetornarMMM()
        {
            NumerosArabicosParaRomanos conversor = new NumerosArabicosParaRomanos(3000);
            Assert.AreEqual("MMM", conversor.NumeroRomano);
        }

        [TestMethod]
        public void DeveRetornarMMMCII()
        {
            NumerosArabicosParaRomanos conversor = new NumerosArabicosParaRomanos(3102);
            Assert.AreEqual("MMMCII", conversor.NumeroRomano);
        }

        [TestMethod]
        public void DeveRetornarĪV̄()
        {
            NumerosArabicosParaRomanos conversor = new NumerosArabicosParaRomanos(4000);
            Assert.AreEqual("ĪV̄", conversor.NumeroRomano);
        }

        [TestMethod]
        public void DeveRetornarV̄()
        {
            NumerosArabicosParaRomanos conversor = new NumerosArabicosParaRomanos(5000);
            Assert.AreEqual("V̄", conversor.NumeroRomano);
        }

        [TestMethod]
        public void DeveRetornarV̄ĪĪ()
        {
            NumerosArabicosParaRomanos conversor = new NumerosArabicosParaRomanos(7000);
            Assert.AreEqual("V̄ĪĪ", conversor.NumeroRomano);
        }

        [TestMethod]
        public void DeveRetornarĪX̄()
        {
            NumerosArabicosParaRomanos conversor = new NumerosArabicosParaRomanos(9000);
            Assert.AreEqual("ĪX̄", conversor.NumeroRomano);
        }

        [TestMethod]
        public void DeveRetornarĪX̄CXLIX()
        {
            NumerosArabicosParaRomanos conversor = new NumerosArabicosParaRomanos(9149);
            Assert.AreEqual("ĪX̄CXLIX", conversor.NumeroRomano);
        }

        [TestMethod]
        public void DeveRetornarX̄()
        {
            NumerosArabicosParaRomanos conversor = new NumerosArabicosParaRomanos(10000);
            Assert.AreEqual("X̄", conversor.NumeroRomano);
        }

    }
}
