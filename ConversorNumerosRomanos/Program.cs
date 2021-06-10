using System;

namespace ConversorNumerosRomanos
{
    class Program
    {
        static void Main(string[] args)
        {

            NumerosRomanosParaArabicos n = new NumerosRomanosParaArabicos("iv");
            Console.WriteLine(n.NumeroArabico);
        }
    }
}
