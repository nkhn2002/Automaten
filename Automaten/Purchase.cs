using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Automaten
{
    class Purchase
    {
        public static double InsMoney { get; set; }
        public static double Price { get; set; }
        public static double MoneyLeftToPay { get; set; }
        public static double Refund { get; set; }
        public static string Cancel { get; set; }

        public static Automat automat = new Automat();
        public static void BuyProduct(string name)
        {
            foreach(var item in Automat.products)
            {
                if(item.Name.ToLower() == name)
                {
                    // Set item price
                    Price = item.Price;

                    if(item.Amount == 0)
                    {
                        Console.WriteLine("No more items of this product is available!");
                        Thread.Sleep(1500);
                        Menu.Load();
                        break;
                    }

                    while (true)
                    {
                        Start:
                        // Parse money inserted
                        Console.Write("Insert money: ");
                        InsMoney = double.Parse(Console.ReadLine());

                        if (InsMoney < Price)
                        {
                            // Get the estimated money left
                            MoneyLeftToPay = Price - InsMoney;

                            // Set the new price
                            Price = MoneyLeftToPay;

                            Console.WriteLine("You still need to pay: {0}\n", MoneyLeftToPay);

                            goto Start;
                        }

                        if(InsMoney > Price)
                        {
                            // Get the refunded amount
                            Refund = InsMoney - Price;

                            Console.WriteLine("You paid too much, you will get {0}kr refunded\n", Refund);
                        }

                        Console.Write("Before we finish the purchase, would you like to cancel? Y/N: ");
                        Cancel = Console.ReadLine().ToLower();

                        switch(Cancel)
                        {
                            case "y":
                            case "yes":
                                Console.WriteLine("\nSuccessfully cancelled the order!");
                                Thread.Sleep(1500);
                                Menu.Load();
                                break;

                            case "n":
                            case "no":
                                Console.WriteLine("\nSuccessfully bought the product, enjoy!");
                                automat.AdmRemAmount(item.Name, -1);
                                Thread.Sleep(1500);
                                Menu.Load();
                                break;

                        }
                        automat.Money += Price;
                        Menu.Load();
                        break;
                    }
                }
            }
        }
    }
}
