using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Automaten
{
    class Program
    {
        public static string Choice { get; set; }
        public static int Money { get; set; }
        static void Main(string[] args)
        {
            // Add Items to vending machine
            AddItems();

            // Load menu :P
            Menu.Load();

            // Parse choice
            while(true)
            {
                Console.Write("What would you like to purchase: ");
                Choice = Console.ReadLine().ToLower();
                switch (Choice)
                {
                    case "chips":
                    case "m&ms":
                    case "kitkat":
                    case "vand":
                    case "cola":
                        Purchase.BuyProduct(Choice);
                        break;

                    case "admin menu":
                        Admin.AdminMenu();
                        break;

                    default:
                        Console.WriteLine("\nThat product does not exist!");
                        Thread.Sleep(1500);
                        Menu.Load();
                        break;
                }
            }

            Console.ReadKey();
        }

        public static void AddItems()
        {
            Automat.products.Add(new Automat("Chips", 22.50, 4));
            Automat.products.Add(new Automat("M&Ms", 15.00, 4));
            Automat.products.Add(new Automat("KitKat", 12.50, 3));
            Automat.products.Add(new Automat("Vand", 10.00, 5));
            Automat.products.Add(new Automat("Cola", 12.00, 3));
        }
    }
}
