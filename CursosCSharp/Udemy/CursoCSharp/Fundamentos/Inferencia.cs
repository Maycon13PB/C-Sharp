using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
            //Quando usado var o proprio programa ira defenir o tipo da varaivel 
        {

            var nome = "Maycon";
            //nome = 123  quando se usar var  o tipo da varaiavel ja foi definido 
            Console.WriteLine(nome);

            var idade = 32;
            Console.WriteLine(idade);

            int a;
            a = 3;

            int b = 2;
            Console.WriteLine(a + b);
        }
    }
}
