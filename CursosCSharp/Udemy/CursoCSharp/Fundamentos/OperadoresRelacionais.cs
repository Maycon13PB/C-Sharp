using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {
            Console.Write("Digite a nota: ");
            double.TryParse(Console.ReadLine(), out double nota);

            Console.WriteLine("Bota Invalida? {0}", nota > 10.0);
            Console.WriteLine("Bota Invalida? {0}", nota < 10.0);
            Console.WriteLine("Perfeito? {0}", nota == 10.0);
            Console.WriteLine("Tem como melhorar? {0}", nota != 10.0);
            Console.WriteLine("Passou por média? {0}", nota >= 10.0);
            Console.WriteLine("Recuperação? {0}", nota < 10.0);
            Console.WriteLine("Reprovado? {0}", nota <= 10.0);

        }
    }
}
