using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Valinta_Kuukaudet_yhdessä_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tee ohjelma, joka kysyy kuukauden ja tulostaa mihin vuoden aikaan se kuuluu.
            // 11-12-1-2-3 ovat talvea. 4-5 ovat kevättä. 6-7-8 ovat kesää.
            // 9-10 ovat syksyä.
            //Kuukauden voi antaa numerona tai tekstinä.
            //Suorita sovellus: if-else, switch ja ternary rakenteilla.
            /*
            Console.WriteLine("Syötä kuukausi numero 1-12:");
            int userMonth = int.Parse(Console.ReadLine());
            
            if (userMonth == 11  || userMonth == 12 || userMonth == 1 || userMonth == 2 || userMonth == 3)
            {
                Console.WriteLine("talvi!");
            }
            else if (userMonth == 4 || userMonth == 5)
            {
                Console.WriteLine("Kevät!");
            }
            else if (userMonth == 6 || userMonth == 7 || userMonth == 8)
            {
                Console.WriteLine("Kesä!");
            }
            else if (userMonth == 9 || userMonth == 10)
            {
                Console.WriteLine("Syksy!");
            }
            else
            {
                Console.WriteLine("Väärä syöte. 1-12 numerot käytössä");
            } 
            */
            // Muokataan teksi pieniksi kirjaimiksi

            // !!!!!!!!!!!!!!monthIF = monthIF.ToLower();  ToLower() muokkaa kirjaimet pieniksi!!!!!!!!!!!!!!!!!!!
            // toinen tapa tehää string esim. mothIF == "tammikuu".........
            // -----------------------------------------------------------------------------------------------------
            // Switch
            /*
            !!!!!!!!!!! case int xyz when (xyz >= 6 || xyz <= 8): 6 ja 8ssä kesä!!!!!!!!!!!!
            switch (userMonth)
                {
                case 1:
                case 2:
                case 3:
                case 12:
                case 11:                 
                    Console.WriteLine("Talvi");
                    break;
                 
           
                case 4:
                case 5:
                    Console.WriteLine("Kevät");
                    break;
                  
            
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Kesä");
                    break;
           
                case 9:
                case 10:
                    Console.WriteLine("Syksy");
                    break;
            default:
                Console.WriteLine("Virheellinen numero!");
                break;
            } */
            // C# 7 versiossa voidaan ilmaista myös tietty numero alue.
            // ----------------------------------------------------------------------------------------  

            // Ternary

            Console.Write("Syötä kuukausi numerona: ");
            int monthTernary = int.Parse(Console.ReadLine());

            string message = "";

            // ternary vertailu
            message = monthTernary == 11 || monthTernary == 12 || monthTernary >= 1 && monthTernary <= 3 ? "Talvi" :
                monthTernary >= 4 && monthTernary <= 5 ? "Kevät" :
                monthTernary >= 6 && monthTernary <= 8 ? "kesä" :
                monthTernary >= 9 && monthTernary <= 10 ? "Syksy" :
                "Virheellinen arvo";


            Console.WriteLine(message);



            Console.ReadKey();
        }
    }
}
