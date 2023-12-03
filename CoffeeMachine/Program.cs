using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
           Coffee cappuccino = new Cappuccino();
            Coffee espresso = new Espresso();
            Coffee americano = new Americano();
            Resource resource = new Resource();
            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Brew Espresso");
                Console.WriteLine("2. Brew Americano");
                Console.WriteLine("3. Brew Cappuccino");
                Console.WriteLine("4. Check Resource");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1-5): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        espresso.Brew(); break;
                    case "2":
                        americano.Brew(); break;
                    case "3":
                        cappuccino.Brew(); break;
                    case "4":
                        resource.ResourceCheck(); break;
                    case "5":
                        Console.WriteLine("Exiting");
                        return;

                    default: Console.WriteLine("Invalid choice. Please enter number between 1 to 5");
                        break;

                }
                Console.WriteLine();
            }
        }
    }
}