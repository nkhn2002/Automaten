using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Automaten
{
    class Automat
    {
        private string name;
        private double price;
        private int amount;
        private double money;

        public static List<Automat> products = new List<Automat>();

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public double Money
        {
            get { return money; }
            set { money = value; }
        }

        public Automat()
        {

        }

        public Automat(string _name, double _price, int _amount)
        {
            this.Name = _name;
            this.Price = _price;
            this.Amount = _amount;
        }

        public void AdmAddAmount(string name, int _amount)
        {
            foreach (var item in products.Where(p => p.Name.ToLower() == name))
            {
                item.Amount = item.Amount + _amount;
            }
        }

        public void AdmRemAmount(string name, int _amount)
        {
            foreach (var item in products.Where(p => p.Name.ToLower() == name))
            {
                item.Amount = item.Amount - _amount;
            }
        }

        public void AdmEditPrice(string name, double _price)
        {
            foreach (var item in products.Where(p => p.Name.ToLower() == name))
            {
                Console.WriteLine("chips");
                item.Price = _price;
            }
        }

        public void TakeMoney()
        {
            Money = 0;
        }
    }
}
