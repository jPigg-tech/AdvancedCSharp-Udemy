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
            // args => expression
            // number => number*number
            // Func<int, int> square = Square; ... Can also be ran as...

            Func<int, int> square = number => number * number;

            Console.WriteLine(square(5));
            Console.ReadKey();
            
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
