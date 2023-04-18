using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teoriapv6_function_class_method_struct_enum
{
    class Program // Luokka
    {
        static void Main(string[] args) // Funktio / Metodi
        {

            // Funktio
            // 


            // Funktio ja metodi ovat melkein samoja, erona on niiden sijainti.
            // Metodi on termi funktiolle, joka on osana luokkaa.

            // Olemme kirjoittaneet koodia luokkaan nimeltä "Program" ja sen funktioon / metodiin "Main"

            // Funktio / Metodi koodi tulee tiettyyn kohtaan tiedostoa.

            // Kun lähdemme tekemään uutta metodia, se täytyy kirjoittaa samalle tasolle muiden metodien / funktioiden kanssa, luokan sisälle.


            // Tänne ei voi luoda uutta funktiota, koska olemme jo "Main"-funktion sisällä
            // Metodi luotiin "Main"-funktion alapuolelle

            // Täällä voidaan käyttää metodia

            // UUSI TERMI: olio / object
            // olio on instanssi. Esimerkki: https://i.stack.imgur.com/lNUAA.png
            // Oletuksena metodeja voi ainoastaan käyttää, kun luokasta on luotu objekti.
            // Nyt uutta "printText()"-metodia ei voida käyttää, ellei luoda luokasta "Program"
            // uutta objektia.


            Program test = new Program(); // Luodaan tämän tiedoston "Program" luokasta objecti
            test.printText("hello", 123);
            test.printText("World", 321);

            // Poikkeuksena staattinen metodi
            // Jos metodista luodaan staattinen, sitä voi käyttää suoraan ilman objektia.

            // Esim:
            Console.WriteLine(""); // Tämä on "Console"-luokan staattinen "WriteLine()"-metodi
            // Program.multiplyNumbers(2, 10); // Viittaus "Program" luokkaan ei ole pakollinen
            // koska olemme sen luokan sisällä.
            int fiveTimesThree = multiplyNumbers(5, 3); // metodi palauttaa arvon, se pitää ottaa talteen. esim. muuttujaan "fiveTimesThree"
            // Tai käytetään palautettavaa arvoa suoraan toisessa metodissa
            // Nyt metodin "multipluNumbers()" palautettava arvo toimii parametrissa
            // metodille "WriteLine"
            Console.WriteLine(multiplyNumbers(5, 3));




            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        } // Main function

        // Luodaan uusi metodi, muiden metodien ulkopuolelle, mutta luokan sisälle.

        // [Näkyvyys] [palautettavaDatatyyppi] [metodinNimi] [(parametrit, pilkulla eroteltuna)]
        // Tämä funktio ottaa vastaan kaksi arvoa: string message ja int number
        // Metodi kirjoittaa consoliin parametrien sisällön
        private void printText(string message, int number)
        {
            // Private näkyvyys tarkoittaa, että sitä ei voi käyttää luokan ulkopuolelta
            // void -datatyyppi, ei palauta mitään
            // parametrit -dataa, joka lähetetään funktioon.
            Console.WriteLine($"text: {message}{number}");
        }

        // Luodaan staattinen metodi
        // avainsana "static" tulee näkyvyyden ja palautettavan datatyypin väliin.
        // Tämä metodi ottaa vastaan kaksi int arvoa ja palauttaa niiden kerronnan tuloksen.
        public static int multiplyNumbers (int number1, int number2)
        {
            // public -näkyy luokan ulkopuolelle
            // static -tekee metodista staattisen (voi käyttää ilman objektia)
            // int - tämä metodi palauttaa int-arvon

            return number1*number2; // return avainsanalla palautetaan arvo.
        }


    } // Class Program


} // Namespace
