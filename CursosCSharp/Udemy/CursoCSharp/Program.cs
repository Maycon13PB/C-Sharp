using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                //Fundamentos 

                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar },
                {"Váriaveis e Constatnes - Fundamentos ", VariaveisEConstantes.Executar},
                {"Inferencias - Fundamentos", Inferencia.Executar },
                {"Interpolacao - Fundamentos", Interpolacao.Executar }, 
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos", LendoDados.Executar },
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar },
                {"Conversões - Fundamentos", Conversoes.Executar },
                {"Operadores Aritimeticos - Fundamentos", OperadoresAritmeticos.Executar },
                {"Operadores Relacionais  - Fundamentos", OperadoresRelacionais.Executar },
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao .Executar },
                {"Operadores Ternario - Fundamentos", OperadorTernario .Executar },

                //Estruturas de controle 

                {"Estrutura IF - Estruturas de Controle", EstruturaIf .Executar },
                {"Estrutura IF e Else - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura IF e Else If - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura Foreach - Estruturas de Controle", EstruturaForEach.Executar},

                // Classes e Métodos 

                {"Membros - Classes e Metodos ", Membros.Executar},
                {"Construtores - Classes e Metodos ", Construtores.Executar},
                {"Metodos Com Retorno - Classes e Metodos ", MetodosComRetorno .Executar},
                {"Metodos Estaticos - Classes e Metodos", MetodosEstaticos.Executar},
                {"Atributos  Estaticos - Classes e Metodos", AtributosEstaticos.Executar},
                {"Desafio de atributos - Classes e Metodos ", DesafioAtributo.Executar},
                {"Params - Classes e Metodos ", Params .Executar},
                {"Parametros Nomeados - Classes e Metodos ", ParametrosNomeados.Executar},
                {"Get Set - Classes e Metodos ", GetSet.Executar},
                {"Props - Classes e Metodos ", Props.Executar},
                {"Readonly - Classes e Metodos ", Readonly.Executar},
                {"Enum  - Classes e Metodos ", ExemploEnum .Executar},
                {"Struct - Classes e Metodos ", Struct.Executar},
                {"Struct Vs Classe  - Classes e Metodos ", StructVsClasse .Executar},
                {"Valor Vs Referencia - Classes e Metodos ", ValorVsReferencia .Executar},
                {"Parametros Por Referencia- Classes e Metodos ", ParametroPorReferencia.Executar},
                {"Parametros Com Valor Padrão  - Classes e Metodos ", ParametrosPadrao  .Executar},

                //Coleções

                {"Array - Coleções ", Colecoes.Array.Executar},
                {"List - Coleções ", ColecoesList.Executar},
                {" Array List - Coleções ", ColecoesArrayList.Executar},
                {"Coleção Set - Coleções ", ColecoesSet.Executar},
                {"Queue - Coleções ", ColecoesQueue.Executar},
                {"Igualdade - Coleções ", Igualdade.Executar},
                {"Coleção Stack - Coleções ", ColecoesStack.Executar},
                {"Dictionary - Coleções ", ColecoesDictionary.Executar},

                //OO

                {" Herança ",Heranca.Executar},
                {" Contrutor This  ",ConstrutorThis.Executar},
                {" Encapsulamento",Encapsulamento.Executar},


            });

            central.SelecionarEExecutar();
        }
    }
}