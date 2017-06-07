using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotterShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart.Tests
{
    [TestClass()]
    public class PotterShoppingCartTests
    {
        //[TestMethod()]
        //public void AddToCartTest()
        //{
        //    Assert.Fail();
        //}

        [TestMethod()]
        public void 第一集買了一本_價格應為100元()
        {
            //arrange
            var target = new PotterShoppingCart();
            var book = new Book
            {
                ISBN = "9789573317241",
                Name = "哈利波特1",
                Price = 100               
            };

            //act
            target.AddToCart(book);
            var totalPrice = target.CheckOut();

            //assert
            var expected = 100;
            Assert.AreEqual(expected, totalPrice);
        }

        [TestMethod()]
        public void 第一集買了一本_第二集也買了一本_價格應為190元()
        {
            //arrange
            var target = new PotterShoppingCart();
            var book = new Book
            {
                ISBN = "9789573317241",
                Name = "哈利波特1",
                Price = 100
            };

            //act
            target.AddToCart(
                new Book
                {
                    ISBN = "9789573317241",
                    Name = "哈利波特1",
                    Price = 100
                }
            );
            target.AddToCart(
               new Book
               {
                   ISBN = "9789573317586",
                   Name = "哈利波特2",
                   Price = 100
               }
           );

            var totalPrice = target.CheckOut();

            //assert
            var expected = 190;
            Assert.AreEqual(expected, totalPrice);
        }
    }
}