using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Inferencia {

        public static void Executar() {
            var nome = "Francy";
            // nome = 123; se já iniciei a variaval com o tipo VAR string, não posso atribuir a a ela valor inteiro;
            Console.WriteLine(nome);


            //int idade;
            var idade = 32;
            Console.WriteLine(idade);

            int a;
            a = 3;

            int b = 2;

            Console.WriteLine(a + b);


        }
    }
}
