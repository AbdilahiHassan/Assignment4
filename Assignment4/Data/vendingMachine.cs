using Assignment4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment4.Data
{
   public class VendingMachine : IVendingMachine
    {

        private int moneyPool = 0;
        private readonly int[] denominations = new int[] { 1, 5, 10, 20, 50, 100, 500, 1000 };
       List<Product> products = new List<Product>();
        public IEnumerable<object> price;

        public int Id { get; }
        public bool Lchf { get; }
        public bool Disney { get; }
        public bool Warm { get; }

        // List<p> p = new List<p>();

        public VendingMachine(int price, int price1)
        {
            Additems();

        }

        public VendingMachine(int price, int id, bool lchf, bool disney, bool warm) : this(price)
        {
            Id = id;
            Lchf = lchf;
            Disney = disney;
            Warm = warm;
        }

        public VendingMachine(int price, int id, bool lchf, bool disney) : this(price)
        {
        }

        public VendingMachine(int price, int price1, int v, int id) : this(price, price1)
        {
        }

        public VendingMachine(int price)
        {
        }

        public VendingMachine()
        {
        }

        public Product Purchase(int productId)
        {
           

       
            foreach (Product product in products)
            {
                if (product.id == productId)
                {
                    if (product.price <= moneyPool)
                    {
                        moneyPool = moneyPool - product.price;
                        return product;
                    }
                    else
                    {
                        throw new Exception("you do Not enough money");
                    }

                }
            }
            return null;
        }
        public List<Product> ShowAll()
        {
            foreach (var item in products)
            {

            }
            return products;
        }
        
        public bool InsertMoney(int money)
        {
            if (denominations.Contains(money))
            {
                moneyPool = money + moneyPool;
                return true;
            }
            else
            {
                return false;
            }

        }
        public string EndTransaction()
        {
            StringBuilder sBuil = new StringBuilder();


            foreach (int coin in denominations)
            {
                if (moneyPool / coin > 0)
                {
                    sBuil.Append($"Returning: {moneyPool / coin} * {coin}");
                }
                moneyPool %= coin;
            }
            return sBuil.ToString();

        }
        public void Additems()
        {
            products.Add(new Toy(500, 1, true));
            products.Add(new Toy(500, 2, true));
            products.Add(new Food(50, 3, true));
            products.Add(new Food(50, 4, true));
            products.Add(new Drinks(25, 5, false));
            products.Add(new Drinks(25, 6, false));

        }


    }
}
