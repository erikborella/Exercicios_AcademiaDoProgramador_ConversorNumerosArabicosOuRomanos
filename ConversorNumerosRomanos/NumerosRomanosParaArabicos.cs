using System;
using System.Collections.Generic;
using System.Text;

namespace ConversorNumerosRomanos
{
    public class NumerosRomanosParaArabicos
    {
        public int NumeroArabico { get; private set; }
        public string NumeroRomano { get; set; }

        private Dictionary<string, int> dicionarioConversao = new Dictionary<string, int>()
        {
            { "m", 1000000},
            { "d", 500000 },
            { "c", 100000 },
            { "l", 50000 },
            { "x", 10000 },
            { "v", 5000 },
            { "i", 1000 },
            { "M", 1000 },
            { "D", 500 },
            { "C", 100 },
            { "L", 50 },
            { "X", 10},
            { "V", 5},
            { "I", 1},
        };

        private List<string> valoresQuePodemDiminuir = new List<string>()
        {
            "I",
            "X",
            "C",
            "i",
            "x",
            "c"
        };

        public NumerosRomanosParaArabicos(string numeroRomano)
        {
            NumeroRomano = numeroRomano;
            NumeroArabico = Converter(numeroRomano);

        }

        private int Converter(string numeroRomano)
        {
            numeroRomano = Normalizar(numeroRomano);

            char[] valoresParaConversao = numeroRomano.ToCharArray();
            int saida = 0;
            
            for (int i = 0; i < valoresParaConversao.Length; i++)
            {
                string valor = valoresParaConversao[i].ToString();
                int valorASerAdicionado = 0;

                if (PodeAvancarMaisUmaPosicao(valoresParaConversao, i))
                {
                    string proximoValor = valoresParaConversao[i + 1].ToString();

                    if (valoresQuePodemDiminuir.Contains(valor) && ProximoValorEhMaiorQueOAtual(valor, proximoValor))
                    {
                        valorASerAdicionado = dicionarioConversao[proximoValor] - dicionarioConversao[valor];
                        i++;
                    }

                }

                if (valorASerAdicionado == 0)
                {
                    valorASerAdicionado = dicionarioConversao[valor];
                }

                saida += valorASerAdicionado;
            }

            return saida;
        }

        private bool ProximoValorEhMaiorQueOAtual(string valor, string proximoValor)
        {
            return dicionarioConversao[proximoValor] > dicionarioConversao[valor];
        }

        private bool PodeAvancarMaisUmaPosicao(char[] valoresParaConversao, int i)
        {
            return i + 1 < valoresParaConversao.Length;
        }

        private string Normalizar(string str)
        {
            str = str.ToUpper();

            str = str.Replace("Ī", "i");
            str = str.Replace("V̄", "v");
            str = str.Replace("X̄", "x");
            str = str.Replace("C̄", "c");
            str = str.Replace("D̄", "d");
            str = str.Replace("L̄", "l");
            str = str.Replace("M̄", "m");

            return str;
        }
    }
}
