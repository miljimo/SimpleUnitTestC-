using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using checkout;

namespace test
{
    

    [TestClass]
    public class CheckoutServiceTest
    {
        private CheckOutService service = new CheckOutService();

     

        /**
         *  Test item stocking 
         */
        [TestMethod]
        public void addSingleItem()
        {
            bool  status  = this.service.add("apple", 20);
            Assert.AreEqual(true, status);            
        }

        //test for multiple items

        [TestMethod]
        public void emptyCheckOutServiceItems()
        {
            this.service.add("apple", 20);
            this.service.add("Orange", 120);
            var status  = this.service.empty();
            Assert.AreEqual(true, status);
        }


        //get number of items from checkout list testing

        [TestMethod]
        public void addMultipleItemsCheckCount()
        {
            this.service.empty();
            this.service.add("apple", 20);
            this.service.add("Orange", 13);
            int expected = 2;
            int actual = this.service.count();
            Assert.AreEqual(expected, this.service.count());
        }


        [TestMethod]
        public void purchaseSingleItem ()
        {

            this.service.empty();
            this.service.add("apple", 0.60);
            this.service.add("oranges", 0.25);
            var expected = 0.60;
            var actual = this.service.purchase("apple", 1);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void purchaseSameTwoItem()
        {
            this.service.empty();
            this.service.add("apple", 0.60);
            this.service.add("oranges", 0.25);
            var expected = 1.20;
            var actual = this.service.purchase("apple", 2);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void purchaseMultipleItems()
        {

            this.service.empty();
            this.service.add("apple", 0.60);
            this.service.add("oranges", 0.25);

            var expected = 0.85;
            Item[] lists = { new Item("apple", 1), new Item("oranges", 1)};

            var actual = this.service.purchaseRange(lists);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public  void purchaseUnitsMulitipleItems()
        {
            this.service.empty();
            this.service.add("apple", 0.60);
            this.service.add("oranges", 0.25);
            Item[] lists = { new Item("apple", 6), new Item("oranges", 3) };
            var expected = 4.35;
            var actual = this.service.purchaseRange(lists);
            Assert.AreEqual(expected, actual);


        }

       
    }
}
