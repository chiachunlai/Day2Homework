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


        [TestMethod()]
        public void 一二三集各買了一本_價格應為270元()
        {
            //arrange
            var target = new PotterShoppingCart();

            //act
            target.AddToCart(
                new Book
                {
                    ISBN = "9573317249",
                    Name = "哈利波特1",
                    Price = 100
                }
            );
            target.AddToCart(
                new Book
                {
                    ISBN = "9573317583",
                    Name = "哈利波特2",
                    Price = 100
                }
            );
            target.AddToCart(
                new Book
                {
                    ISBN = "9573318008",
                    Name = "哈利波特3",
                    Price = 100
                }
            );

            var totalPrice = target.CheckOut();

            //assert
            var expected = 270;
            Assert.AreEqual(expected, totalPrice);
        }

        [TestMethod()]
        public void 一二三四集各買了一本_價格應為320元()
        {
            //arrange
            var target = new PotterShoppingCart();

            //act
            target.AddToCart(
                new Book
                {
                    ISBN = "9573317249",
                    Name = "哈利波特1",
                    Price = 100
                }
            );
            target.AddToCart(
                new Book
                {
                    ISBN = "9573317583",
                    Name = "哈利波特2",
                    Price = 100
                }
            );
            target.AddToCart(
                new Book
                {
                    ISBN = "9573318008",
                    Name = "哈利波特3",
                    Price = 100
                }
            );

            target.AddToCart(
                new Book
                {
                    ISBN = "9573318318",
                    Name = "哈利波特4",
                    Price = 100
                }
            );

            var totalPrice = target.CheckOut();

            //assert
            var expected = 320;
            Assert.AreEqual(expected, totalPrice);
        }

        [TestMethod()]
        public void 一次買了整套_一二三四五集各買了一本_價格應為375元()
        {
            //arrange
            var target = new PotterShoppingCart();

            //act
            target.AddToCart(
                new Book
                {
                    ISBN = "9573317249",
                    Name = "哈利波特1",
                    Price = 100
                }
            );
            target.AddToCart(
                new Book
                {
                    ISBN = "9573317583",
                    Name = "哈利波特2",
                    Price = 100
                }
            );
            target.AddToCart(
                new Book
                {
                    ISBN = "9573318008",
                    Name = "哈利波特3",
                    Price = 100
                }
            );

            target.AddToCart(
                new Book
                {
                    ISBN = "9573318318",
                    Name = "哈利波特4",
                    Price = 100
                }
            );

            target.AddToCart(
                new Book
                {
                    ISBN = "9573319861",
                    Name = "哈利波特5",
                    Price = 100
                }
            );

            var totalPrice = target.CheckOut();

            //assert
            var expected = 375;
            Assert.AreEqual(expected, totalPrice);
        }

        [TestMethod()]
        public void 一二集各買了一本_第三集買了兩本_價格應為370元()
        {
            //arrange
            var target = new PotterShoppingCart();

            //act
            target.AddToCart(
                new Book
                {
                    ISBN = "9573317249",
                    Name = "哈利波特1",
                    Price = 100
                }
            );
            target.AddToCart(
                new Book
                {
                    ISBN = "9573317583",
                    Name = "哈利波特2",
                    Price = 100
                }
            );
            target.AddToCart(
                new Book
                {
                    ISBN = "9573318008",
                    Name = "哈利波特3",
                    Price = 100
                }
            );

            target.AddToCart(
                new Book
                {
                    ISBN = "9573318008",
                    Name = "哈利波特3",
                    Price = 100
                }
            );
                      

            var totalPrice = target.CheckOut();

            //assert
            var expected = 370;
            Assert.AreEqual(expected, totalPrice);
        }

        [TestMethod()]
        public void 第一集買了一本_第二三集各買了兩本_價格應為460元()
        {
            //arrange
            var target = new PotterShoppingCart();

            //act
            target.AddToCart(
                new Book
                {
                    ISBN = "9573317249",
                    Name = "哈利波特1",
                    Price = 100
                }
            );
            target.AddToCart(
                new Book
                {
                    ISBN = "9573317583",
                    Name = "哈利波特2",
                    Price = 100
                }
            );
            target.AddToCart(
                new Book
                {
                    ISBN = "9573317583",
                    Name = "哈利波特2",
                    Price = 100
                }
            );
            target.AddToCart(
                new Book
                {
                    ISBN = "9573318008",
                    Name = "哈利波特3",
                    Price = 100
                }
            );

            target.AddToCart(
                new Book
                {
                    ISBN = "9573318008",
                    Name = "哈利波特3",
                    Price = 100
                }
            );


            var totalPrice = target.CheckOut();

            //assert
            var expected = 460;
            Assert.AreEqual(expected, totalPrice);
        }


    }
}