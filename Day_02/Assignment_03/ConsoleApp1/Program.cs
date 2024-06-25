using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please Enter Your Name : ");
            try
            {
                string name = Console.ReadLine();
                Console.WriteLine($"(welcome! {name}to adventure center!");
                Console.WriteLine("Please Enter Your Age : ");
                int age = int.Parse(Console.ReadLine());

                if (age < 80)
                {
                    Console.WriteLine($"{name}!your ride is heavy! Enjoy!");
                }
                else
                {
                    Console.WriteLine($"{name}! Sorry, you cannot do this activity");
                }
                //Console.WriteLine($"{name}! Sorry,you cannot do this activity!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
