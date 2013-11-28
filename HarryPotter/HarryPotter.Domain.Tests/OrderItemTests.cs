using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace HarryPotter.Domain.Tests
{

    [TestFixture]
    public class OrderItemTests
    {
        private OrderItem _orderItem;

        [Test]
        public void New_CreateInstanceWith2Books_Create2Items()
        {
            Book book = new Book() { Id = 2 };
            this._orderItem = new OrderItem(book);
            Assert.AreEqual(book, this._orderItem.Book);
        }

        [Test]
        public void New_OrderWith1Book_Price8Pesos()
        {
            Book book = new Book() { Price = 8 };
            _orderItem.Book = _orderItem.TotalBook(book, 1);
            double total = _orderItem.Book.Price; 
            Assert.AreEqual(8, total);
        }

        [Test]
        public void New_OrderWith2Book_Price16Pesos()
        {
            Book book = new Book() { Price = 8 };
            _orderItem.Book = _orderItem.TotalBook(book, 2);
            double total = _orderItem.Book.Price;
            Assert.AreEqual(16, total);
        }

        [Test]
        public void New_OrderWith3Book_Price24Pesos()
        {
            Book book = new Book() { Price = 8 };
            _orderItem.Book = _orderItem.TotalBook(book, 3);
            double total = _orderItem.Book.Price;
            Assert.AreEqual(24, total);
        }

        [Test]
        public void New_OrderWith4Book_Price32Pesos()
        {
            Book book = new Book() { Price = 8 };
            _orderItem.Book = _orderItem.TotalBook(book, 4);
            double total = _orderItem.Book.Price;
            Assert.AreEqual(32, total);
        }

        [Test]
        public void New_OrderWith5Book_Price40Pesos()
        {
            Book book = new Book() { Price = 8 };
            _orderItem.Book = _orderItem.TotalBook(book, 5);
            double total = _orderItem.Book.Price;
            Assert.AreEqual(40, total);
        }

        [Test]
        public void New_OrderWith2Book_Price16DescPesos()
        {
            Book book = new Book() { Price = 8 };
            _orderItem.Book = _orderItem.TotalBookDesc(book, 2, .05);
            double total = _orderItem.Book.Price;
            Assert.AreEqual(14.95, Convert.ToDecimal(total.ToString(".##")));
        }

        [Test]
        public void New_OrderWith3Book_Price24DescPesos()
        {
            Book book = new Book() { Price = 8 };
            _orderItem.Book = _orderItem.TotalBookDesc(book, 3, .10);
            double total = _orderItem.Book.Price;
            Assert.AreEqual(22.9, Convert.ToDecimal(total.ToString(".##")));
        }

        [Test]
        public void New_OrderWith4Book_Price32DescPesos()
        {
            Book book = new Book() { Price = 8 };
            _orderItem.Book = _orderItem.TotalBookDesc(book, 4, .20);
            double total = _orderItem.Book.Price;
            Assert.AreEqual(30.8, Convert.ToDecimal(total.ToString(".##")));
        }

        [Test]
        public void New_OrderWith5Book_Price40DescPesos()
        {
            Book book = new Book() { Price = 8 };
            _orderItem.Book = _orderItem.TotalBookDesc(book, 5, .25);
            double total = _orderItem.Book.Price;
            Assert.AreEqual(38.75, Convert.ToDecimal(total.ToString(".##")));
        }

        [Test]
        public void New_OrderWith2Bookand1_PricePesos()
        {
            List<Book> LisBook =  new List<Book>();

            Book book = new Book() { Price = 8 ,Name="L1"};
            LisBook.Add(book);
            Book book2 = new Book() { Price = 8, Name = "L1" };
            LisBook.Add(book2);
            Book book3 = new Book() { Price = 8, Name = "L2" };
            LisBook.Add(book3);
            Book book4 = new Book() { Price = 8, Name = "L2" };
            LisBook.Add(book4);
            Book book5 = new Book() { Price = 8, Name = "L3" };
            LisBook.Add(book5);
            Book book6 = new Book() { Price = 8, Name = "L3" };
            LisBook.Add(book6);
            Book book7 = new Book() { Price = 8, Name = "L4" };
            LisBook.Add(book7);
            Book book8 = new Book() { Price = 8, Name = "L5" };
            LisBook.Add(book8);

            double total = _orderItem.TotalListBookDesc(LisBook); ;
            Assert.AreEqual(70.65, Convert.ToDecimal(total.ToString(".##")));
        }
    }
}
