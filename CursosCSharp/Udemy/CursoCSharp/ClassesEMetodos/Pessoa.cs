﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {
        public string Nome;
        public int Idade;

        public  string Apresentar()
        {
            return string.Format($"Olá! Me chama {Nome} e tenho {Idade} anos.");
        }
        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }
    }
}
