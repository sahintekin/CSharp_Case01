using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If else

            //Console.Write("Lütfen şifrenizi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre doğru..");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış..");
            //}

            //string capital, country;
            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //if(capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Veriler Doğrulandı...");
            //}
            //else
            //{
            //    Console.WriteLine("Veriler yanlış!!!");
            //}

            //int number;
            //Console.Write("Sayıyı giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru.." + "Sayı= "+ number);
            //}
            //else
            //{
            //    Console.WriteLine("Sayı yanlış!!!");
            //}

            //int exam1, exam2, exam3, average;
            //string result="Hata";

            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Sınavların Ortalaması: " + average);

            //if (average > 1 & average <= 50)
            //{
            //    result = "Sonuç berbat";
            //}
            //else if (average > 50 & average <= 69)
            //{
            //    result = "Vasaytın üstü..";
            //}
            //else if (average > 69 & average <= 100)
            //{
            //    result = "Harika..";
            //}
            //else
            //{
            //    Console.WriteLine("Sınav Tekrarı ");
            //}
            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "bursa" | city == "ankara" | city == "trabzon")
            //{
            //    Console.WriteLine("Şehir mevcut..");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil...");
            //}

            //Console.Write("Lütfen kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();
            //if(username != "admin")
            //{
            //    Console.WriteLine("Bu kullanıcı adı kabul edilemez..");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz...");
            //}






            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;

            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1.sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2.sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());
            //int result = number1 % number2;
            //Console.WriteLine("1.Sayının 2.sayıya bölümünden kalan: " + result);

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if(number % 2 == 0)
            //{
            //    Console.Write("Sayı çiftir..");
            //}
            //else
            //{
            //    Console.Write("Sayı tektir..");
            //}
            #endregion

            #region Char Değişkenler ile Karar Yapıları
            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}
            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("****** C# Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if(menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Ana Yemekler---------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk ile Makarna");
            //    Console.WriteLine("2-Kızartma Tabağı ");
            //    Console.WriteLine("3-Fasulye ile Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka ");
            //    Console.WriteLine("-------------------------------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Çorbalar---------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek ");
            //    Console.WriteLine("2-Tarhana ");
            //    Console.WriteLine("3-Tavuk Suyu ");
            //    Console.WriteLine("4-Domates");
            //    Console.WriteLine("-------------------------------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Pizzalar---------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza ");
            //    Console.WriteLine("2-Margerita ");
            //    Console.WriteLine("3-Etli ");
            //    Console.WriteLine("-------------------------------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------İçecekler---------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Ayran ");
            //    Console.WriteLine("2-Şalgam ");
            //    Console.WriteLine("3-Su ");
            //    Console.WriteLine("4-Maden Suyu");
            //    Console.WriteLine("5-Limonata");
            //    Console.WriteLine("-------------------------------");
            //    Console.WriteLine();

            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Tatlılar---------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Künefe ");
            //    Console.WriteLine("2-Baklava ");
            //    Console.WriteLine("3-Şekerpare ");
            //    Console.WriteLine("4-İrmik");
            //    Console.WriteLine("5-Kazandibi");
            //    Console.WriteLine("6-Sütlaç");
            //    Console.WriteLine("-------------------------------");
            //    Console.WriteLine();

            //}



            #endregion

            #region Switch Case
            //Console.Write("Lütfen ay girişi yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("January"); 
            //        break;
            //    case 2: Console.Write("February");
            //        break;
            //    case 3: Console.Write("March");
            //        break;
            //    case 4: Console.Write("April");
            //        break;
            //    case 5: Console.Write("May"); 
            //        break;
            //    case 6: Console.Write("June"); 
            //        break;
            //    case 7: Console.Write("July"); 
            //        break;
            //    case 8: Console.Write("August");
            //        break;
            //    case 9: Console.Write("September"); 
            //        break;
            //    case 10: Console.Write("Octaber");
            //        break;
            //    case 11: Console.Write("Novamber");
            //        break;
            //    case 12: Console.Write("December");
            //        break;
            //    default: Console.Write("Hatalı veri girişi..");
            //        break;
            //}


            #endregion

            #region  Swicth Case Hesap Makinesi

           /* int number1, number2, result;
            char symbol;
            Console.Write("1.Sayıyı Giriniz: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("2.Sayıyı Giriniz: ");
            number2 = int.Parse(Console.ReadLine());
            Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Toplam: " + result);
                    break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Fark: " + result);
                    break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Çarpım: " + result);
                    break;
                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Bölüm: " + result);
                    break;
            } */

            #endregion

            Console.Read();
        }
    }
}
