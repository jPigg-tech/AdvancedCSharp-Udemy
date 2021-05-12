using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            var cheapBooks = books.FindAll(IsCheaperThan10Dollars);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
            Console.ReadLine();
        }

        // Predicate delegate method (returns a bool)
        // returns true if the given condition is satisfied
        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }

        static void RunSimpleLambdaExpressionMethods()
        {
            // args => expression
            // number => number*number
            // Func<int, int> square = Square; ... Can also be ran as...

            Func<int, int> square = number => number * number;

            Console.WriteLine(square(5));
            //Console.ReadLine();


            // without any arguments... 
            // () => ...
            // one argument
            // x => ...
            // multiple arguments 
            // (x, y, z) => ...

            // Lambda Expressions can understand 
            // any variable within the scope it is called
            // as well as the variable that is passed to it

            const int factor = 5;

            Func<int, int> multiplier = n => n * factor;
            var result = multiplier(10);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static int Square(int number)
        {
            return number*number;
        }

        static void RunDelegateClass()
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            // PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;

            processor.Process("photo.jpg", filterHandler);
            Console.ReadLine();
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply Remove RedEye");
        }
        // The above method shows the power of delegates
        // They allow the caller to create and add methods on 
        // the fly with out any affects to PhotoProcessor class
        // or the PhotoFilter class
    }
}
