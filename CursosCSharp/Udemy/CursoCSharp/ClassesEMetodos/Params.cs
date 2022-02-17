using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Params
    {
        public static void Recepcionar(params string [] pessoas)
        {
            foreach (var Recepcionar in pessoas)
            {
                Console.WriteLine("Ola {0}", pessoas );
            }
        }

        public static void Executar()
        {
            Recepcionar("Pedro", "Manu", "Roger", "Bia");
        }
        
    }
}
