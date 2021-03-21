using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4.Model
{
    public class Food : Product
    {
        bool lchf;
        public Food(int price, int id, bool lchf) : base(price, id)

        {
            this.lchf = lchf;
        }
        public override string Examine()
        {
            return ($"Sandwich , {price:C} :{id} :{lchf} ");
        }
        public override string Use()
        {
            return ("Best  Sandwich in  town!!");
        }

        //    public Food(int price, int id) : base(price, id)
        //    {
        //    }

        //    public override string Examine()
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public override string Use()
        //    {
        //        throw new NotImplementedException();
        //    }
    }
}
