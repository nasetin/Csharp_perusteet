using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_kokkeeseen_harjottelu
{
    class Kissa
    {

        // nimi, ikä, paino, 
        // propertyt 
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public double Weight { get; set; }

        // Constirtr
        public Kissa(int id, string name, int age, double weight)
        {
            Id = id;
            Name = name;
            Age = age;
            Weight = weight;
        }

        public Kissa(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Kissa()
        {

        }

        public override string ToString()
        {
            return Id.ToString() + " " + Name + " " + Age.ToString() + " " + Weight.ToString();
        }

        public double LaskeYhteen() // metodi
        {
            double tulos = Age + Weight;
            return tulos;
        }

        public void Tulosta() // metodi2
        {
            Console.WriteLine(Name + " on yhtäkuin " + LaskeYhteen());
        }                   // Tulosta metodissa käytetään LaskeThteen metodia!!!


    }
}
