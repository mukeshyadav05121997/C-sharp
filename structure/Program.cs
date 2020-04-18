//Structure is value type means it store in stack 
//it is very  useful when we have small data 



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structure
{

   struct Books {
    public    string BookName;
     public   string AuthorName;
    public    int Id;
    };
    class Program
    {
        static void Main(string[] args)
        {
            Books Book1; /* Book1 of Book*/
            Books Book2; /* Book1 of Book*/

            //book1 specification
            Book1.BookName = "Seven Beauty";
            Book1.AuthorName = "Mukesh Yadav";
            Book1.Id = 1;

            //book2 specification
            Book2.BookName = "MY First Book";
            Book2.AuthorName = "Lokesh";
            Book2.Id = 2;

            Console.WriteLine("The Book1 Bookname is {0} ", Book1.BookName);
            Console.WriteLine("The Book1 Authorname is {0} ", Book1.AuthorName);
            Console.WriteLine("The Book1 Id is {0} ", Book1.Id);
            //Console.WriteLine("The Book2 Bookname is {0} and Written by {1} and Its Id is {2}", Book2.BookName, Book2.AuthorName, Book2.Id);
            Console.ReadKey();
        }
    }
}
