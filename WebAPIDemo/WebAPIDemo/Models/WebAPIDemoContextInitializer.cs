using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIDemo.Models
{
    class WebAPIDemoContextInitializer : DropCreateDatabaseAlways <WebAPIDemoContext>
    {
        protected override void Seed(WebAPIDemoContext context)
        {
            var books = new List<Book>
            {
                new Book() {Name = "War and Peace", Author = "Tolstoy", Price = 19.95m },
                new Book() {Name = "Some stupid Book", Author = "Somebody", Price = 9.95m },
                new Book() {Name = "The Time Machine", Author = "H.G. Wells", Price = 49.95m },
                new Book() {Name = "THE HOLY BIBLE", Author = "GOD", Price = 0.0m },
                new Book() {Name = "Book 2", Author = "Mr. 2Books", Price = 4.95m },
                new Book() {Name = "Book 3", Author = "Mr. 3Books", Price = 17.95m },
                new Book() {Name = "Book 4", Author = "Mr. 4Books", Price = 5.95m },
                new Book() {Name = "Book 5", Author = "Mr. 5Books", Price = 7.95m }
            };
            books.ForEach(b => context.Books.Add(b));
            context.SaveChanges();

            var order = new Order() { Customer = "Mr. FooBar", OrderDate= DateTime.Now};
            var details = new List<OrderDetail>()
            {
                 new OrderDetail() {Book = books[0], Quantity = 1, Order = order },
                 new OrderDetail() {Book = books[2], Quantity = 4, Order = order },
                 new OrderDetail() {Book = books[3], Quantity = 1, Order = order }
            };
            context.Orders.Add(order);
            details.ForEach(o => context.OrderDetails.Add(o));
            context.SaveChanges();

             order = new Order() { Customer = "Mr. BarFoo", OrderDate = DateTime.Now };
             details = new List<OrderDetail>()
            {
                 new OrderDetail() {Book = books[4], Quantity = 1, Order = order },
                 new OrderDetail() {Book = books[4], Quantity = 4, Order = order },
                 new OrderDetail() {Book = books[1], Quantity = 12, Order = order }
            };
            context.Orders.Add(order);
            details.ForEach(o => context.OrderDetails.Add(o));
            context.SaveChanges();

             order = new Order() { Customer = "Mr. Booksalot", OrderDate = DateTime.Now };
             details = new List<OrderDetail>()
            {
                 new OrderDetail() {Book = books[1], Quantity = 1, Order = order },
                 new OrderDetail() {Book = books[2], Quantity = 120, Order = order },
                 new OrderDetail() {Book = books[3], Quantity = 1, Order = order }
            };
            context.Orders.Add(order);
            details.ForEach(o => context.OrderDetails.Add(o));
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
