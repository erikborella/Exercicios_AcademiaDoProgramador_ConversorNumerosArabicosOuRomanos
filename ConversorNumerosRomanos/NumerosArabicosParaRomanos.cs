using System;
using System.Collections.Generic;
using System.Text;

namespace ConversorNumerosRomanos
{
    public class NumerosArabicosParaRomanos
    {
        public int NumeroArabico { get; private set; }
        public string NumeroRomano { get; set; }

        private Dictionary<int, string> valoresConversao = new Dictionary<int, string>()
        {
            { 1000000, "M̄" },
            { 900000, "C̄M̄" },
            { 500000, "D̄" },
            { 400000, "C̄D̄" },
            { 100000, "C̄"},
            { 90000, "X̄C̄" },
            { 50000, "L̄" },
            { 40000, "X̄L̄" },
            { 10000, "X̄" },
            { 9000, "ĪX̄" },
            { 5000, "V̄" },
            { 4000, "ĪV̄" },

            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD"},
            { 100, "C"},
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X"},
            { 9, "IX"},
            { 5, "V"},
            { 4, "IV"},
            { 1, "I"},
        };

        private List<char> letrasComMacronConvertidas = new List<char>()
        {
            'i', 'v', 'x', 'c', 'd', 'm'
        };

        private string milAlternatico = "Ī";

        public NumerosArabicosParaRomanos(int valorArabico)
        {
            NumeroArabico = valorArabico;
            NumeroRomano = Converter(NumeroArabico);
        }

        private string Converter(int valorArabico)
        {
            StringBuilder saida = new StringBuilder();
            int valorParaConversao = valorArabico;

            foreach (int valor in valoresConversao.Keys)
            {
                while (valorParaConversao >= valor)
                {
                    string valorEmRomano;

                    if (valor == 1000 && UltimoCaractereTemMacron(saida))
                        valorEmRomano = milAlternatico;
                    else
                        valorEmRomano = valoresConversao[valor];
                    
                    saida.Append(valorEmRomano);
                    valorParaConversao -= valor;
                }
            }

            return saida.ToString();
        }

        private bool UltimoCaractereTemMacron(StringBuilder str)
        {
            if (str.Length == 0)
                return false;

            string valores = str.ToString();

            valores = valores.Replace("Ī", "i");
            valores = valores.Replace("V̄", "v");
            valores = valores.Replace("X̄", "x");
            valores = valores.Replace("C̄", "c");
            valores = valores.Replace("D̄", "d");
            valores = valores.Replace("M̄", "m");

            char ultimoCaractere = valores[^1];

            return letrasComMacronConvertidas.Contains(ultimoCaractere);
        }
    }
}
