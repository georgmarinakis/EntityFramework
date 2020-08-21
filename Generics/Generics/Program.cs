using System;
using System.Globalization;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book { Isbn = "1111", Title = "C# Advanced" };

            // Reusability of code
            var numbers = new GenericList<int>();
            numbers.Add(10); //public void Add(T value) {}

            var books = new GenericList<Book>(); //NO casting or boxing
            books.Add(new Book()); //public void Add(T value) {}

            // Create a dictionary
            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1234", new Book());

            //var a = new Utilities();
            //a.Max(3,7);

            var number = new Nullable<int>();
            Console.WriteLine("Has Value ?" + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());
        }
    }
}
