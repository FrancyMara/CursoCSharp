using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
     class VariaveisEConstantes {

        public static void Executar() {
            // area de circunferencia 
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI= 3.1415; comentario para entender que a variavel PI é uma constante e não se altera

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é: " + area + 1000);
            //assim fica concatenado, junta tudo
            Console.WriteLine("Área é: " + (area + 1000));

            //assim vai somar

            //Tipos internos

            bool estaChovendo = true;

            //tipo bool é verdadeiro ou falso
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            // byte apenas valores positivos

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("saldo de Gols " + saldoDeGols);

            //aceita valores negativos

            short salario = short.MaxValue;
            Console.WriteLine("salario" + salario);

            int menorValorint = int.MinValue; //mais usados dos inteiros!
            Console.WriteLine("Menor int " + menorValorint);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Munidal " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço Computador " + precoComputador);

            double valorDeMeracadoDaApple = 1_000_000_000_000.00; //Mais usado dos reais
            Console.WriteLine("Valor Aplle " + valorDeMeracadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia entre Estrelas " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo ao cusro de C#!";
            Console.WriteLine(texto);

            









             


        }
    }
}
