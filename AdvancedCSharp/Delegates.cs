using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp
{
    // Delegates are for designing extensible and 
    // flexable apllications (they are similar to Interfaces)
    // A delegate is a pointer to a function(a reference to a function)
    // An object that knows how to call a method(or multiple)
    // Use a delegate over a interface when you dont need to access
    // other properties or methods on the object implementing the method
    class Delegates
    {

    }

    public class Photo
    {
        public static Photo Load(string path)
        {
            return new Photo();
        }
        public void Save()
        {

        }
    }
    public class PhotoFilters
    {
        // For simplicity I have just used Console.WriteLine
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Apply brightess");
        }
        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply contrast");
        }
        public void Resize(Photo photo)
        {
            Console.WriteLine("Resize photo");
        }
    }

    public class PhotoProcessor
    {
        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = new Photo.Load(path);

            filterHandler(photo);

            photo.Save();
        }
    }
}
