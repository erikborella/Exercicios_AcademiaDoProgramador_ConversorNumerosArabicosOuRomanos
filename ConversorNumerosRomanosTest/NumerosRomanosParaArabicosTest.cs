using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConversorNumerosRomanos;

namespace ConversorNumerosRomanosTest
{
    class NumerosRomanosParaArabicosTest
    {
        [TestClass]
        public class NumerosRomanoParaArabicosTest
        {

            [TestMethod]
            public void DeveVerificarI()
            {
                NumerosRomanosParaArabicos conversor = new NumerosRomanosParaArabicos("I");
                Assert.AreEqual(1, conversor.NumeroArabico);
            }

            [TestMethod]
            public void DeveVerificarIV()
            {
                NumerosRomanosParaArabicos conversor = new NumerosRomanosParaArabicos("IV");
                Assert.AreEqual(4, conversor.NumeroArabico);
            }

            [TestMethod]
            public void DeveVerificarV()
            {
                NumerosRomanosParaArabicos conversor = new NumerosRomanosParaArabicos("V");
                Assert.AreEqual(5, conversor.NumeroArabico);
            }

            [TestMethod]
            public void DeveVerificarIX()
            {
                NumerosRomanosParaArabicos conversor = new NumerosRomanosParaArabicos("IX");
                Assert.AreEqual(9, conversor.NumeroArabico);
            }

            [TestMethod]
            public void DeveVerificarX()
            {
                NumerosRomanosParaArabicos conversor = new NumerosRomanosParaArabicos("X");
                Assert.AreEqual(10, conversor.NumeroArabico);
            }

            [TestMethod]
            public void DeveVerificarXL()
            {
                NumerosRomanosParaArabicos conversor = new NumerosRomanosParaArabicos("XL");
                Assert.AreEqual(40, conversor.NumeroArabico);
            }

            [TestMethod]
            public void DeveVerificarXC()
            {
                NumerosRomanosParaArabicos conversor = new NumerosRomanosParaArabicos("XC");
                Assert.AreEqual(90, conversor.NumeroArabico);
            }

            [TestMethod]
            public void DeveVerificarCD()
            {
                NumerosRomanosParaArabicos conversor = new NumerosRomanosParaArabicos("CD");
                Assert.AreEqual(400, conversor.NumeroArabico);
            }

            [TestMethod]
            public void DeveVerificarC()
            {
                NumerosRomanosParaArabicos conversor = new NumerosRomanosParaArabicos("C");
                Assert.AreEqual(100, conversor.NumeroArabico);
            }

            [TestMethod]
            public void DeveVerificarD()
            {
                NumerosRomanosParaArabicos conversor = new NumerosRomanosParaArabicos("D");
                Assert.AreEqual(500, conversor.NumeroArabico);
            }

            [TestMethod]
            public void DeveVerificarCM()
            {
                NumerosRomanosParaArabicos conversor = new NumerosRomanosParaArabicos("CM");
                Assert.AreEqual(900, conversor.NumeroArabico);
            }

            [TestMethod]
            public void DeveVerificarM()
            {
                NumerosRomanosParaArabicos conversor = new NumerosRomanosParaArabicos("M");
                Assert.AreEqual(1000, conversor.NumeroArabico);
            }

            [TestMethod]
            public void DeveVerificarVIII()
            {
                NumerosRomanosParaArabicos conversor = new NumerosRomanosParaArabicos("VIII");
                Assert.AreEqual(8, conversor.NumeroArabico);
            }

            [TestMethod]
            public void DeveVerificarLXII()
            {
                NumerosRomanosParaArabicos conversor = new NumerosRomanosParaArabicos("LXII");
                Assert.AreEqual(62, conversor.NumeroArabico);
            }

            [TestMethod]
            public void DeveVerificarCLVIII()
            {
                NumerosRomanosParaArabicos conversor = new NumerosRomanosParaArabicos("CLVIII");
                Assert.AreEqual(158, conversor.NumeroArabico);
            }

            [TestMethod]
            public void DeveVerificarMCXX()
            {
                NumerosRomanosParaArabicos conversor = new NumerosRomanosParaArabicos("MCXX");
                Assert.AreEqual(1120, conversor.NumeroArabico);
            }

            [TestMethod]
            public void DeveVerificarĪV̄()
            {
                NumerosRomanosParaArabicos conversor = new NumerosRomanosParaArabicos("ĪV̄");
                Assert.AreEqual(4000, conversor.NumeroArabico);
            }

            [TestMethod]
            public void DeveVerificarV̄()
            {
                NumerosRomanosParaArabicos conversor = new NumerosRomanosParaArabicos("V̄");
                Assert.AreEqual(5000, conversor.NumeroArabico);
            }

            [TestMethod]
            public void DeveVerificarV̄Ī()
            {
                NumerosRomanosParaArabicos conversor = new NumerosRomanosParaArabicos("V̄Ī");
                Assert.AreEqual(6000, conversor.NumeroArabico);
            }

            [TestMethod]
            public void DeveVerificarV̄ĪĪ()
            {
                NumerosRomanosParaArabicos conversor = new NumerosRomanosParaArabicos("V̄ĪĪ");
                Assert.AreEqual(7000, conversor.NumeroArabico);
            }

            [TestMethod]
            public void DeveVerificarV̄ĪĪĪ()
            {
                NumerosRomanosParaArabicos conversor = new NumerosRomanosParaArabicos("V̄ĪĪĪ");
                Assert.AreEqual(8000, conversor.NumeroArabico);
            }

            [TestMethod]
            public void DeveVerificarĪX̄()
            {
                NumerosRomanosParaArabicos conversor = new NumerosRomanosParaArabicos("ĪX̄");
                Assert.AreEqual(9000, conversor.NumeroArabico);
            }

            [TestMethod]
            public void DeveVerificarX̄()
            {
                NumerosRomanosParaArabicos conversor = new NumerosRomanosParaArabicos("X̄");
                Assert.AreEqual(10000, conversor.NumeroArabico);
            }
        }
    }
}
