using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresDeAtribuicao {
        public static void Executar() {
            var num1 = 3;
            num1 += 10; //Numero recebe o seu valor mais 10
            num1 -= 3; // Num rece num 1  e diminui 3
            num1 *= 5; 
            num1 /= 2; //num 1 divide por 2

            Console.WriteLine(num1);

            int a = 1;
            int b = a;

            a++; //a = a +1 ;
            b--; //b = b - 1;

            Console.WriteLine($"{a} {b}");
            
            //não se preocupar com essa parte do código
            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";
            dynamic d = c;
            d.nome = "Maria";

            Console.WriteLine(c.nome);

        }
    }
}
