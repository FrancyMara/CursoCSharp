using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    
    internal class EstruturaWhile {
        public static void Executar() {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEcontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEcontrado) {
                Console.Write("Insira o seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas ++;
                tentativasRestantes--;

                if (numeroSecreto == palpite) {
                    numeroEcontrado = true;
                    var corAnteror = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Numero encontrado em {0} tentativas", tentativas);
                    Console.BackgroundColor = corAnteror;

                } else if (palpite > numeroSecreto) {
                    Console.WriteLine("Menor.. Tente Novamente!");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);

                }else {
                    Console.WriteLine("Maior.. Tente novamente");
                    Console.WriteLine("Tentativas restantes {0}", tentativasRestantes);
                }
            }


        }
    }
}
