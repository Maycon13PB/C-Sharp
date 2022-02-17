using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));//F1 arredonda as casas 
            Console.WriteLine(valor.ToString("C"));//C transforma o numero em moeda 
            Console.WriteLine(valor.ToString("P"));//P transforma o numero em porcentual 
            Console.WriteLine(valor.ToString("#.##")); //# mostra a formatação do numero mais especifica 

            CultureInfo cultura = new CultureInfo("pt-BR");//Definição do idioma no caso português brasileiro 
            Console.WriteLine(valor.ToString("C0",cultura));//C0 formatação em forma de moeda sem nenhuma casa decimal 

            int interio = 256;
            Console.WriteLine(interio.ToString("D10"));//D + numero, acrecenta a quantida de casa desejadas 
        }
    }
}
