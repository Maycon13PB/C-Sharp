using System;
using System.Globalization;//Gerenaliza os sinbolos

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual é o seu nome ? ");
            string nome = Console.ReadLine();//serve para captura o que a  pessoa escreve

            Console.Write("Qual é o seu idade ? ");
            int idade  = int.Parse(Console.ReadLine());//Int.Parse pega as string e transforma em number  

            Console.Write("Qual é o seu salario ? ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);//Serve para ser utilizado os simbolos inseridos na hora de execução 

            Console.WriteLine($"{nome} {idade} R${salario}");//R$ serve para pegar a sinbolos  da pessoa local da maquina 
        }
    }
}
