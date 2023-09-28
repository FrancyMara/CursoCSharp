using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresAritmeticos {
        public static void Executar() {
            //Preço desconto
            var preco = 1000;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine("O preco final é {0}", totalComDesconto);

            //IMC
            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / (altura * altura);
            //double imc = peso / Math.Pow(altura, 2);
            //mesma coisa da linha 22, porém mais limpo a operação ao quadrado (potencia)
            //base é altura e o expoente é o numero 2 de quadrado
            Console.WriteLine($"IMC é {imc}.");

            //Numero Par/Impar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem o resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem o resto {1}", impar, impar %2);
            //operador modulo , resto da divisão é ele que é retornado






        }
    }
}
