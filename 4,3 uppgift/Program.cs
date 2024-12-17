using System;

namespace _4_3_uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            int summa = 0; 
           
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Ange heltal {i}: "); 
                int tal;

                
                while (!int.TryParse(Console.ReadLine(), out tal))
                {
                    Console.Write("Ogiltig inmatning. Ange ett heltal: ");
                }

                summa += tal;
            }

           
            Console.WriteLine($"Summan av de inmatade talen är: {summa}");
        }
    }
}