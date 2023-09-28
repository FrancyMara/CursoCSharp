using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CursoCSharp.EstruturasDeControle 
    
{
    internal class EstruturaIf 
        {
        public static void Executar() {
            bool bomComportamento = false;
            string entrada;

            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);
            //tryparse converta uma string em inteiro
            //então se for digitado letras ao invés de número ele vai converter para zero
            //a variavel nota, foi criada para que seja atribuido o valor digitado pelo usuario
            // caso seja numero atribui, se não for, não atribui

            Console.WriteLine("Possui bom Comportamento (S/N): ");
            entrada = Console.ReadLine();

            //if (entrada == "S" || entrada == "s")
              //  bomComportamento = true;

           // bomComportamento = entrada == "S" || entrada == "s";
            //essa sentença é mesma coisa da sentença comentada acima

            bomComportamento = entrada.ToLower() == "s";
            //usando assim não precisa comparar como no ex acima se é minusuclo ou maisculo
            //basta passar uma vez apenas

                if (nota >= 9.0 && bomComportamento) {
                Console.WriteLine("Quadro de Honra!");
            }
        
        }
    }
}
