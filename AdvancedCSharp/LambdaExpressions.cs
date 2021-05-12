using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp
{
    // An anonymous method 
    // no access modifier
    // no name 
    // no retrun statement
    // We use them for convenience
    // Write less code and achieve the same thing 
    // and code is more readable
    class LambdaExpressions
    {
        // args => expression 
        // number => number*number
        // We need to assign this ^ to a delegate      
            
    }

    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book(){Title = "Title 1", Price = 5},
                new Book(){Title = "Title 2", Price = 7},
                new Book(){Title = "Title 3", Price = 17}
            };
        }
    }
}
