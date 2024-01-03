using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {



    public class CalculadoraEstatica {
        public  int Somar(int a , int b) {
            return a + b;
        }
        //como não static é um metodo que pertence a instacia
        
        public static int Multiplicar(int a, int b) {
            return (a * b);

         // como possui static é um medoto que pertence a classe

        }


    }
    internal class MetodosEstaticos {

        public static void Executar() {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("Resultado:{0}",resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(2, 2));
            //para consguir realizar a soma como não usou static ,
            //precisou criar uma calculadoraestatica, criar uma variavel do mesmo tipo "calc", criar um construtor desse tipo "new CalculardoraEstatica"

        

        }
    }
}
