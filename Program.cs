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
            else
            {
                Console.WriteLine("Nie no, idziesz do domu");
            }
        }
    }
}
