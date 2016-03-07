using System.Linq;
using Newtonsoft.Json.Linq;
using Breeze.ContextProvider;

namespace WebAPIDemo.Models
{
    public interface IRepository
    {
         string MetaData { get; }

        SaveResult SaveChanges(JObject saveBundle);


        IQueryable<Book> Books();
        IQueryable<Order> Orders();
    }
}