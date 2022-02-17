using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAtributo
    {
        int a = 10;
        public static void Executar()
        {
            //Acessar variável 'a' dentro do método Executar

            int b = new DesafioAtributo().a;

            Console.WriteLine(b);
        }
    }
}
