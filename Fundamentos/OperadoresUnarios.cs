using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresUnarios {
        public static void Executar() {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo);
            //como a variavel que esta passando é negativa e esta sendo passado no
            //console negativo a variavel sera aprentada com valor positivo
            Console.WriteLine(!booleano);
            // aqui ele inverte os valores se é F vira V e vice e versa

            numero1++;
            Console.WriteLine(numero1);
            //incrementa depois

            --numero1;
            Console.WriteLine(numero1);
            //decrementa antes

            Console.WriteLine(numero1++ == --numero2);
            //quando eu uso o incremento ou decremento antes da váriavel, ao executar o programa
            //a variável sera incrementada ou incrementada antes 

            Console.WriteLine($"{numero1} {numero2}");
            // aqui ele mostra o resulta acima depois de ter comparado

        }
    }
}
