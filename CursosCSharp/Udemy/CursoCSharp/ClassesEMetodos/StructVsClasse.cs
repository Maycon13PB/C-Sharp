using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public struct SPonto
    {
        public int X;
        public int Y;
    }

    public class CPonto
    {
        public int X;
        public int Y;
    }
    class StructVsClasse
    {
        public static void Executar()
        {
            SPonto ponto1 = new SPonto { X = 1, Y = 3 };
            SPonto copiaPonto1 = ponto1; //Atribuição por VALOR!!!
            ponto1.X = 3;

            Console.WriteLine("Ponto 1 X:{0}", ponto1.X);
            Console.WriteLine("Copia Ponto 1 x:{0}", copiaPonto1.X);

            SPonto ponto2 = new SPonto { X = 2, Y = 4 };
            SPonto copiaPonto2 = ponto2; //Atribuição por Referencia!!!
            ponto2.X = 4;

            Console.WriteLine("Ponto2 X:{0}", ponto2.X);
            Console.WriteLine("Copia Ponto2 x:{0}", copiaPonto2.X);

        }
    }
}
