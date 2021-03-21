using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4.Model
{
  public interface  IVendingMachine



    {

        public Product Purchase(int productId);

        public List<Product> ShowAll();

        public bool InsertMoney(int money);

        public string EndTransaction();

    }
}