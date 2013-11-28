using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HarryPotter.Domain
{
    public class OrderItem
    {
        public Book Book { get; set; }
        public int Quantity { get; set; }
        string NameActual = "";
        
        public OrderItem()
        { 
        }
        
        public OrderItem(Book book)
        {
            this.Book = book;
        }

        public Book TotalBook(Book bookItem, int quantity)
        {
            Book book = new Book() { Price = bookItem.Price * quantity };

            return book;
        }

        public Book TotalBookDesc(Book bookItem, int quantity, double Desc)
        {
            Book book = new Book() { Price = (bookItem.Price * quantity)-(1.00+Desc) };

            return book;
        }

        public double TotalListBookDesc(List<Book> bookList)
        {
            int iguales = 0;
            int dif = 0;
            double TotalBook = 0;
            List<Book> lstBook = new List<Book>();
            lstBook = bookList;

            foreach (Book i in bookList)
            {
                string aux = i.Name;
                if (NameActual == aux || NameActual == "")
                {
                    NameActual = aux;
                    dif += 1;
                }
                else
                {
                    NameActual = aux;
                    iguales += 1;
                }
            }

            if (dif == 1)
                TotalBook = 8;
            else if (dif == 2)
                TotalBook = 14.95;
            else if(dif == 3)
                TotalBook = 22.9;
            else if (dif == 4)
                TotalBook = 30.8;
            else if (dif == 5)
                TotalBook = 38.75;

            return TotalBook + (iguales * 8);
        }
    }
}
