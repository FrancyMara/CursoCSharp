using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;s

namespace CursoCSharp.ClassesEMetodos {

    public struct Dependente {
        public string Nome;
        public int Idade;
    }

     class ValorVsReferencia {

        public static void Executar () {
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"{numero} {copiaNumero}");

            numero++;
            Console.WriteLine($"{numero} {copiaNumero}");

            Dependente dep = new Dependente {
                Nome = "Beto",
                Idade = 20
            };

            Dependente copiaDep = dep;

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");

            copiaDep.Nome = "Francy Mara";
            dep.Idade = 33;

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");

        }
    }
}
