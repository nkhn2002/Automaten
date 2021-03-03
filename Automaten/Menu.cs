using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    class Menu
    {
        public static void Load()
        {
            Console.Clear();

            Console.WriteLine(" █████╗ ██╗   ██╗████████╗ ██████╗ ███╗   ███╗ █████╗ ████████╗");
            Console.WriteLine("██╔══██╗██║   ██║╚══██╔══╝██╔═══██╗████╗ ████║██╔══██╗╚══██╔══╝");
            Console.WriteLine("███████║██║   ██║   ██║   ██║   ██║██╔████╔██║███████║   ██║   ");
            Console.WriteLine("██╔══██║██║   ██║   ██║   ██║   ██║██║╚██╔╝██║██╔══██║   ██║   ");
            Console.WriteLine("██║  ██║╚██████╔╝   ██║   ╚██████╔╝██║ ╚═╝ ██║██║  ██║   ██║   ");
            Console.WriteLine("╚═╝  ╚═╝ ╚═════╝    ╚═╝    ╚═════╝ ╚═╝     ╚═╝╚═╝  ╚═╝   ╚═╝   \n\n");
            Console.WriteLine("To go to admin mode, write 'admin menu'");
            Console.WriteLine("=======================================");
            Console.Write("Product:\tPrice:\t\tAmount:\n");
            foreach(var item in Automat.products)
            {
                Console.Write("{0}\t\t{1}kr\t\t{2}\n", item.Name, item.Price, item.Amount);
            }
            Console.WriteLine("");
        }
    }
}
