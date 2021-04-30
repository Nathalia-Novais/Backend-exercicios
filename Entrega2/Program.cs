using System;

namespace Entrega2
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Qual é o ano atual?");
            int anoatual = int.Parse(Console.ReadLine());

             Console.WriteLine("Qual é o ano do seu nascimento?");
            int nascimento = int.Parse(Console.ReadLine());

            int idade  = anoatual - nascimento;
            Console.WriteLine("você tem : " + idade+ " anos");

            int semanas = idade * 52;
            Console.WriteLine("sua idade em semanas é de: " + semanas+ " semanas ");

        }
    }
}
