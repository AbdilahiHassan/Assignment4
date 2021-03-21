using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4.Model
{
    public class Toy :  Product
    {

        bool disney;
        public Toy(int price, int id, bool disney) : base(price, id)
        {
            this.disney = disney;
        }
        public override string Examine()
        {
            return ($"Toy , {price:C}");
        }
        public override string Use()
        {
            return ("Toy best Toy!");
        }


    }
}
