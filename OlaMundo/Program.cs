using System;

namespace OlaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boa noite!");
            Console.WriteLine("Qual o seu nome?");
            
            String nome = Console.ReadLine();
            
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Olá " + nome + "x-"+i.ToString());
            }

            Console.WriteLine("Digite qualquer tecla para finalizar");
            Console.ReadKey();
        }
    }
}
