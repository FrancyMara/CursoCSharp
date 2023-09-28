using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CursoCSharp.Fundamentos {
    internal class OperadorTernario {
        public static void Executar() {
            var nota = 9.0;
            bool bomComportamento = false;
            Console.Write("Tem bom comportamento ? ");
            string resposta = Console.ReadLine();
            string resultado = nota >= 7.0 && bomComportamento ? "Aprovado" : "Reprovado";
            //Ternario pq há tres parte: a expressao nota>= 7.00 && bomComportamento ?
            //parte dois primeiro operando "Aprovado" : e depois o terceiro operando "Reprovado"


        }
    }
}
