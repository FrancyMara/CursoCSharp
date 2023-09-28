using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Conversoes {

        public static  void Executar() {
            int inteiro = 10;
            double quebrado;
            quebrado = inteiro;
            Console.WriteLine(quebrado);
            //esse caso é conversao implicita, quando tem perigo de ter perca de informação

            double nota = 9.7;
            int notaTruncada = (int) nota; 
            //isso se chama kasting, converter um valor em outro, nesse caso double para inteiro, conversão explicita
            Console.WriteLine("Nota Truncada: {0}", notaTruncada);

            Console.Write("Digite a sua idade ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);
            //conversao de string para inteiro usando int parse

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}", idadeInteiro);

            Console.Write("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out  numero1);
            Console.WriteLine("Resultado1: {0}", numero1);
            // //conversao de string para inteiro usando TryParse

            Console.Write("Digite o segundo número: ");
            int.TryParse (Console.ReadLine(), out int numero2);
            //usando o int é possível declara a varial dentro readline
            Console.WriteLine("Resultado 2: {0}", numero2);
            //aqui ele vai tertar o valor padrao , mas não conseguindo vai informar 0 , no caso de inserir "letras"





        }
    }
}
