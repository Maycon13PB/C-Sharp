using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int) nota;
            Console.WriteLine("Nota truncada: {0}", notaTruncada);

            Console.WriteLine("Digite sua idade: ");
            string idadeString = Console.ReadLine();       
            int idadeInteiro = int.Parse(idadeString);      //Pegando um numero em string e transformando em number 
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);     // convertendo uma string em number 
            Console.WriteLine("Resultado: {0}", idadeInteiro);

            Console.Write("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);        // Pegando  a string e transformando em int
            Console.WriteLine("Resultaado 1: {0}", numero);

            Console.WriteLine("Digite o segudno número: ");
            int.TryParse(Console.ReadLine(), out int numero2);  // passando string em number se á aver a possibilidade da converção  
            Console.WriteLine("Resultado 2: {0}", numero2); // retornado 0 em caso de erro 
        }
    }
}
