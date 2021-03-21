using Assignment4.Data;
using System;
using System.Collections.Generic;
using Xunit;

namespace Assignment4.Model.Test
{
    public class VendinMachineTest
    {
        [Fact]
        public void MechineTest()
        {
            //Arrange Id = id;
            

                 int price = 0;
                  int Id =1;
                   bool Lchf = false;
                  bool Disney  = true;
                 bool Warm = true;
              int moneyPool =0;
            int productId = 1;
            int[] denominations = new int[] { 1, 5, 10, 20, 50, 100, 500, 1000 };
            //Act
            VendingMachine vendingMachine = new VendingMachine( price,Id, Lchf,Disney);
    

            List<Product> products = new List<Product>();


            //Assert
            Assert.Equal(0, vendingMachine.Id);
            Assert.False(vendingMachine.Lchf);
          //  Assert.Equal(3, vendingMachine.price);
            Assert.False(vendingMachine.Disney);
           Assert.Equal(false, vendingMachine.Lchf);
            Assert.Equal(0, moneyPool);
           // Assert.Equal("test", vendingMachine.Purchase(int productId));
            //Assert.Equal("test", produc
            //asts);
        }
    }
}
