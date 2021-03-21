using Assignment4.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    internal class Drinks : Product
    {

        bool warm;
        public Drinks(int price, int id, bool Warm) : base(price, id)
        {
            this.warm = Warm;
        }

        public override string Examine()
        {
            return ($"Drink, {price:C} {id} {warm}");

        }

        public override string Use()
        {
            return "Drink slow its cold";
        }


    }

}

