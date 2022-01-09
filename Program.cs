using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int wiek = 0;
            Console.WriteLine("Podaj swój wiek");
            wiek = Convert.ToInt32(Console.ReadLine());
            
            if(wiek<15)
            {
                Console.WriteLine("Leksiu to lubi :0");
            }
            else if(wiek == 15)
            {
                Console.WriteLine("Zostań w domu, nie wychodź");
            }
            else 
            {
                Console.WriteLine("Uciekaj!");
            }
        }
    }
}
