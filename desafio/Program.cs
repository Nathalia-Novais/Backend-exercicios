using System;

namespace entrega4
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Categoria Nadador\n ");


            Console.WriteLine("Qual é a sua idade?");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 5 && idade <= 7)
            {
                Console.WriteLine("Você está na categoria Infantil A");
            }else{
                 if (idade >= 8 && idade <= 10)
              {
                  Console.WriteLine("Você entrou na categoria Infantil B");
              }
             else{
                  if (idade >= 11 && idade <= 13)
              {
                  Console.WriteLine("Você entrou na categoria juvenil A");
              } 
               else {

                    if (idade >= 14 && idade <= 17)
              {
                  Console.WriteLine("Você entrou na categoria juvenil B");
              
              }else
               {
                    if (idade >= 18 )
              {
                  Console.WriteLine("Você entrou na categoria Senior");
              }
               }

               }
               
             }
    
            } 
                     
            }
        }
    }

    
