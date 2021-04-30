using System;

namespace entrega3
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Qual é o seu salário atual?");
            double salario = int.Parse(Console.ReadLine());

            if ( salario < 500)
            {
                // caso o salario for menor que 500
                double aumento = salario + (salario* 0.30);
                Console.WriteLine("Parabéns agora você vai ganhar um salário de: " + aumento);
            } else {

                // caso o salario for maior que 500
                Console.WriteLine("você não foi aprovado para ganhar o aumento");

            }
        }
    }
}
