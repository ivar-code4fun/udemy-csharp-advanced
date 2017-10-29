using Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() { Isbn = "1234", Title = "Title 1", Price = 5 },
                new Book() { Isbn = "5678", Title = "Title 2", Price = 7 },
                new Book() { Isbn = "9090", Title = "Title 3", Price = 17 },
            };
        }
    }
}
