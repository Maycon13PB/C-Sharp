using System;
using System.Collections;
using System.Collections.Generic;


namespace CursoCSharp.Colecoes
{
    class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            fila.Enqueue("Fulano");
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");

            Console.WriteLine(fila.Peek());//Pega o primeiro elemento da fila 
            Console.WriteLine(fila.Count );// contra o tanto string que esta na fila 

            Console.WriteLine(fila.Dequeue ());// Tira o primeiro elemento da fila 
            Console.WriteLine(fila.Count );

            foreach (var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }
            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("Item"));
        }
    }
}
