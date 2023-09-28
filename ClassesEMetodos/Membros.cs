using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
     class Membros {

        public static void Executar() {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Francy";
            sicrano.Idade = 32;

          //  Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} Anos");

            sicrano.ApresentarNoConsole();
            sicrano.Zerar();
            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Mari";
            fulano.Idade = 29;

            var apresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoDoFulano.Length);
            Console.WriteLine(apresentacaoDoFulano);

        }


     }

}

