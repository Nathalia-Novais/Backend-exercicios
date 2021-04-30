using System;

namespace entrega1
{
    class Program
    {

        static void Main(string[] args)
        {
             Console.WriteLine("Qual é a sua idade?");
            int idade = int.Parse(Console.ReadLine());
            
            int meses = idade * 12;
            Console.WriteLine("Sua Idade em meses é: " + meses + " meses\n");

            int dias = idade * 365;
            Console.WriteLine("Sua Idade em dias é: " + dias + " dias\n");

            int horas = dias * 24;
            Console.WriteLine("Sua Idade em horas é: " + horas + " horas\n");

            int minutos = horas * 60;
            Console.WriteLine("Sua Idade em minutos é: " + minutos + " minutos\n");

            
            

        }

    }
}
