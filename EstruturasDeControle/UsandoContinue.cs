using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle {
    internal class UsandoContinue {
        public static void Executar() {
            int intervalo = 50;
            Console.WriteLine("Numeros pares entre 1 e {0}!", intervalo);

            for (int i = 1; i <= intervalo; i++) {
                if (i % 2 == 1) {
                   continue;
                    //ele causa a interrupção prematura da repetição
                    //ele não causa a saída do bloco
                }

                Console.Write(i + " ");
            }

            //for (int i = 2; i <= intervalo; i += 2) {
             //   Console.Write(i + " ");
                //é uma forma mais inteligente de encontrar os números pares, conforme
                //o for anterior
            }
        }
    }

