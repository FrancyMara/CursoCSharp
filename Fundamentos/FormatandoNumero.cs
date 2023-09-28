using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    internal class FormatandoNumero {

        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));
            //única casa decimal
            Console.WriteLine(valor.ToString("C"));
            //Significa moeda, valor monetário
            Console.WriteLine(valor.ToString("P"));
            //Percentual
            Console.WriteLine(valor.ToString("#.##"));
            //concatena 

            CultureInfo cultura = new CultureInfo("pt-BR");
            //new é usado para uma informação de cultura
            Console.WriteLine(valor.ToString("C0", cultura));
            //c equivale a currence se quiser usar c3 por ex, vai apresentar três casas decimais
            //é valor de dinheiro tbm para cultura

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
            //D posso inserir zeros a esquera, neste caso foram 10 zeros a esquerda
        }
    }
}
