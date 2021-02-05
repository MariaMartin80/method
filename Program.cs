using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Please enter your name: ");
            String name = Console.ReadLine();
               PrintName(name);                                                                     

        }
        static void PrintName(String name)
        {
            Console.WriteLine("Hello " + name + "!");
            Console.ReadLine();
                
        }
        
    }
}
