using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp
{
    // where T : IComparable
    // where T : Product
    // where T : struct
    // where T : class
    // where T : new()
    public class Generics
    {
     
    }

    public class Utilities<T> where T : IComparable
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;

            // if a compared to b is greater than 0
            // return a otherwise return b
        }       
    }

    public class Product
    {
        public string  Title { get; set; }
        public float Price { get; set; }
    }
    public class Book : Product
    {
        public string Isbn { get; set; }
    }
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product)
        {
            return product.Price;
        }

        // We don't care about the actual discount
        // This just shows with that constraint if you pass
        // in a TProduct you'll have access to all of its 
        // properties and methods using dot notation
    }
}
