using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koulussa_yhdessä_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Person personA = new Person();
            personA.Age = 30;
            personA.Name = "Juho";
            Console.WriteLine($"Henkilön A nimi on:{personA.Name} ja ikä on:{personA.Age}");

            Person personB = new Person(25, "Matti", 1.8, new List<Pet>());
            personB.Age = 25;
            personB.Name = "Matti";

            Person personC = new Person(35, "Jesse", 179.6, new List<Pet>());
            personC.Age = 35;
            personC.Name = "Jesse";

        }
    }// Class Program päättyy

    // class - avainsana
    // Test - oma luokan nimi, isolla kirjaimella
    class Person // Luokkien idea on mallintaa jotakin todellista asiaa. Tiettyyn pisteeseen saakka.
    {

        // 2a. Property
        // kirjoita prop and sen jälkeen sarkain (TAB) kaksi kertaa
        // Propertyn syntaksi: [Näkyvyys][datatyyppi][nimi][get ja set]
        public int Age { get; set; }
        public string Name{ get; set; }
        public double Length { get; set; }
        public Location CurrentLocation { get; set; }
        public List<Pet> Pets { get; set; }

        // 2b. Contructor
        // Erityis metodi, jolla tallennetaan objektiin oletusarvoja
        // [Näkyvyys]
        // [nimi], jonka täytyy olla täysin sama kuin luokan nimi
        public Person()
        {

        }
        public Person(int age, string name, double length, List<Pet> pets)
        {
            Age = age;
            Name = name;
            Length = length;
            Pets = pets;
        }

        // 2c. Metodi / Method
        // Toiminnallisuus

        // Metodi palauttaa matkan pituuden uuden ja vanhan sijainnin välillä.
        public int Walk(Location newLocation)
        {
            int result = CurrentLocation.CoordinateX - newLocation.CoordinateX;

            CurrentLocation = newLocation; // Päivitetään uusi sijainti

            return result;
        }

    }
    class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class Location
    {
        public int CoordinateX { get; set; }
    }

}
