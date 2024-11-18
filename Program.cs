using DecoratorExample.Decorators;
using DecoratorExample.Interfaces;
using DecoratorExample.Models;

namespace DecoratorExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kawa");
            Console.WriteLine("''''''''''''''''''\n");
            ICoffee c = new Coffee();
            bool end = false;
            while (!end)
            {
                Menu();
                string choice = Console.ReadLine().ToLower();
                switch (choice)
                {
                    case "1":
                        c = new Milk(c); break;
                    case "2":
                        c = new Sugar(c); break;
                    case "3":
                        end = true;
                        break;
                    default:
                        Console.WriteLine("Brak opcji w menu");
                        break;
                }
                if (!end)
                {
                    Console.WriteLine("Kawa: ");
                    Details(c);
                }
            }
            Console.WriteLine("\nFinalna kawa: ");
            Details(c);
            Console.WriteLine("Koniec");
        }
        static void Menu()
        {
            Console.WriteLine("\nOpcje: ");
            Console.WriteLine("\n1. Mleko");
            Console.WriteLine("\n2. Cukier");
            Console.WriteLine("\n3. Zakończ");
        }
        static void Details(ICoffee c)
        {
            Console.WriteLine($"Kawa: {c.GetDesc()}");
            Console.WriteLine($"Cena: {c.Cost():F2}");
        }
    }
}
