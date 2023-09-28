using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresLogicos {
        public static void Executar() {
            var executoutTrabaljo1 = true;
            var executoutTrabaljo2 = true;

            var comprouTv50 = executoutTrabaljo1 && executoutTrabaljo2;
            Console.WriteLine("Comprou a Tv 50? {0}", comprouTv50);

            var comprouSorvete = executoutTrabaljo1 || executoutTrabaljo2;
            Console.WriteLine("Comprou o Sorvete? {0}", comprouSorvete);

            var comprouTv32 = executoutTrabaljo1 ^ executoutTrabaljo2;
            Console.WriteLine("Comprou a Tv 32? {0}", comprouTv32);

            Console.WriteLine("Mais saudável? {0}", !comprouSorvete);
            // ao usar o !, vai passar o resultado independente se verdadeiro ou falso
            // o ! é usado para negar
            //é operador unário
            

        }
    }
}
