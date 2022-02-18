using System;
using Desafio;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Desafio desafio = new Desafio();
            desafio.Inicio().Wait();
        }
    }
}
