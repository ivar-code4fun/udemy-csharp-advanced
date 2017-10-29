using Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Square(5));
            // () => 
            // x => 
            // (x,y,z) => 
            //Func<int, int> square = number => number * number;
            //Console.WriteLine(square(6));

            //const int factor = 5;

            //Func<int, int> multiplier = n => n * factor;
            //Console.WriteLine(multiplier(50));

            var books = new BookRepository().GetBooks();

            //var cheapbooks = books.FindAll(IsCheaperThan10Dollars);
            var cheapbooks = books.FindAll(book => book.Price < 10);

            foreach (var book in cheapbooks)
            {
                Console.WriteLine(book.Title);
            }

        }

        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }
        //static int Square(int num)
        //{
        //    return num * num;
        //}
    }
}
