using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();

            book1.tittle = "Harry Potter";
            book1.author = "JH Rowling";
            book1.pages = 400;

            Book book2 = new Book();

            book2.tittle = "Lord of the rings";
            book2.author = "Tolkein";
            book2.pages = 900;

            //book1
            Console.WriteLine(book1.pages);
            Console.WriteLine(book1.tittle);
            Console.WriteLine(book1.author);

            //book2
            Console.WriteLine(book2.pages);
            Console.WriteLine(book2.tittle);
            Console.WriteLine(book2.author);

            //freeze
            Console.ReadLine();


        }
    }
}
