using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {


        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            //Console.WriteLine("Merhaba dünya");
            //Console.Write("Selam");
            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion

            #region  String Değişkenler
            // string
            // Degişken_türü degiişken_adı;

            //string name;
            //name = "Ahmet";
            //Console.WriteLine(name);
            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //void Müşterilistele()
            //{


            //    Console.WriteLine("-----------------------------------------------------");
            //    Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //    Console.WriteLine("İletişim: " + customerPhone);
            //    Console.WriteLine("Email Adresi: " + customerEmail);
            //    Console.WriteLine(" Adres: " + district + "/" + city);
            //    Console.WriteLine("-----------------------------------------------------");
            //}

            //customerName = "ali";
            //customerSurname = "veli";
            //customerPhone = "63484229";
            //customerEmail = "denem@gmail.com";
            //district = "kadıköy";
            //city = "istanbul";

            //Console.WriteLine("***** Rezervasyon Kartı *****");
            //Console.WriteLine();
            //Müşterilistele();
            //customerName = "veliiili";
            //customerSurname = "veli";
            //customerPhone = "63484229";
            //customerEmail = "denem@gmail.com";
            //district = "kadıköy";
            //city = "istanbul";
            //Müşterilistele();

            #endregion


            #region İnt Değikenler

            //int number = 24;
            //Console.WriteLine(number);
            int hamburgerPrice = 300;
            int cokePrice = 50;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 320;
            int lemonadePrice = 32;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("-----Kola: " + cokePrice + " TL");
            Console.WriteLine("-----Su: " + waterPrice + " TL");
            Console.WriteLine("-----Patates Kızartma: " + friesPrice + " TL");
            Console.WriteLine("-----Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("-----Limonata: " + lemonadePrice + " TL");
            Console.WriteLine();
            Console.WriteLine("**** Siparişiniz ****");
            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;
            

            hamburgerCount = 3;
            cokeCount = 5;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice= friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice= lemonadeCount * lemonadePrice;

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");

            Console.WriteLine();

            int totalPrice = totalHamburgerPrice + totalCokePrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice + totalWaterPrice;

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");
            #endregion
 

            Console.Read();
        }
    }
}
