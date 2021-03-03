using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    class Admin
    {
        public static int Choice { get; set; }
        // Product Name
        public static string Product { get; set; }

        // Product New Price
        public static double NewPrice { get; set; }

        // Product Refill
        public static int ProductRefill { get; set; }

        // Get Money From Machine
        public static double Money { get; set; }

        public static Automat automat = new Automat();
        public static void Banner()
        {
            Console.Clear();

            Console.WriteLine(" █████╗ ██╗   ██╗████████╗ ██████╗ ███╗   ███╗ █████╗ ████████╗");
            Console.WriteLine("██╔══██╗██║   ██║╚══██╔══╝██╔═══██╗████╗ ████║██╔══██╗╚══██╔══╝");
            Console.WriteLine("███████║██║   ██║   ██║   ██║   ██║██╔████╔██║███████║   ██║   ");
            Console.WriteLine("██╔══██║██║   ██║   ██║   ██║   ██║██║╚██╔╝██║██╔══██║   ██║   ");
            Console.WriteLine("██║  ██║╚██████╔╝   ██║   ╚██████╔╝██║ ╚═╝ ██║██║  ██║   ██║   ");
            Console.WriteLine("╚═╝  ╚═╝ ╚═════╝    ╚═╝    ╚═════╝ ╚═╝     ╚═╝╚═╝  ╚═╝   ╚═╝   \n\n");
            Console.WriteLine("1. Change product price");
            Console.WriteLine("2. Refill product");
            Console.WriteLine("3. Take money from machine");
            Console.WriteLine("5. Exit Admin Menu");
            Console.WriteLine("\n=======================================");
            Console.Write("Product:\tPrice:\t\tAmount:\n");
            foreach (var item in Automat.products)
            {
                Console.Write("{0}\t\t{1}kr\t\t{2}\n", item.Name, item.Price, item.Amount);
            }
            Console.WriteLine("");
        }

        public static void AdminMenu()
        {
            Banner();
            Console.Write("\nEnter your choice: ");
            Choice = int.Parse(Console.ReadLine());

            switch(Choice)
            {
                case 1:
                    EditPrice();
                    Banner();
                    AdminMenu();
                    break;

                case 2:
                    Refill();
                    Banner();
                    AdminMenu();
                    break;

                case 3:
                    TakeMoney();
                    Banner();
                    AdminMenu();
                    break;

                case 4:
                    Menu.Load();
                    break;
            }
        }
        public static void EditPrice()
        {
            Console.Write("Enter product name: ");
            Product = Console.ReadLine().ToLower();

            Console.Write("New product price: ");
            NewPrice = double.Parse(Console.ReadLine());

            automat.AdmEditPrice(Product, NewPrice);
        }

        public static void Refill()
        {
            Console.Write("Enter product name: ");
            Product = Console.ReadLine().ToLower();

            Console.Write("New refill amount: ");
            ProductRefill = int.Parse(Console.ReadLine());

            automat.AdmAddAmount(Product, ProductRefill);
        }

        public static void TakeMoney()
        {
            automat.TakeMoney();
            Console.WriteLine("Money has been withdraw");
        }
    }
}
