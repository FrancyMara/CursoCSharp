﻿using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;


namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variaveis e Contantes", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interplocao - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Numero - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionis - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresDeAtribuicao.Executar},
                {"Operadores Unarios - Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternario - Fundamentos", OperadorTernario.Executar},
               
                //Estruturas de Controle
               {"Estrutura If - Estruturas de Controle", EstruturaIf.Executar},
               {"Estrutura If/Else - Estruturas de Controle", EstruturaIfElse.Executar},
               {"Estrutura If/Else/If - Estruturas de Controle", EstruturaIfElseIf.Executar},
               {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
               {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},
               {"Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar},
               {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar},
               {"Estrutura ForEach - Estruturas de Controle", EstruturaForEach.Executar},
               {"Estrutura Break - Estruturas de Controle", UsandoBreak.Executar},
               {"Estrutura Continue - Estruturas de Controle", UsandoContinue.Executar},

               //Classe e Métodos
               {"Membros - Classes e Metodos", Membros.Executar},
               {"Contrutotes - Classes e Metodos ", Construtores.Executar},
               {"Metodos Com Retorno - Classes e Metodos ", MetodosComRetorno.Executar},
               {"Enum - Classes e Metodos ", ExemploEnum.Executar},
               {"Struct - Classes e Metodos ", ExemploStruct.Executar},
               {"Struct Vs Classe - Classes e Metodos ", StructVSClasse.Executar},
               {"Valor Vs Referência - Classes e Metodos ", ValorVsReferencia.Executar},
               




            }); ;

            central.SelecionarEExecutar();
        }
    }
}