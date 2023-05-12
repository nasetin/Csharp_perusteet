using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_yt_tutorial_4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Constructors__________________________________

            //Book book1 = new Book("Harry Potter", "JK Rowling", 400);          
            //Book book2 = new Book("Lord of the rings", "Tolkien", 700);
            //Book book3 = new Book();
            //book2.title = "The Hobbit";

            //Console.WriteLine(book2.title);



            // Object methods_________________________________________

            //Student student1 = new Student("Jim", "Business", 2.8);
            //Student student2 = new Student("Pam", "Art", 3.6);

            //Console.WriteLine(student1.HasHonors());
            //Console.WriteLine(student2.HasHonors());


            // Getters & setters______________________________

            //Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            //Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");
            //// G, PG, PG-13, R, NR
            //Console.WriteLine(avengers.Rating);



            // Static class attributes____________________________________

            //Song holiday = new Song("Holiday", "Green Day", 200);
            //Console.WriteLine(Song.songCount);
            //Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            //Console.WriteLine(kashmir.getSongCount());



            // Static methods & classes________________________________________

            // UsefulTools.SayHi("Nase");

            // Inheritance_________________________________________________

            Chef chef = new Chef();
            chef.MakeSpecialDish();

            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeSpecialDish();



            Console.ReadKey();
        }
    }
}
