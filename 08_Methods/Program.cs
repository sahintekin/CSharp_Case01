using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Void Metotlar

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Mahmut Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Ebru Çınar");

            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum () 
            //{
            //    int x=3;
            //    int y=6;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();






            #endregion

            #region  Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Mehmet Yıldız");

            //void CustomerCard(string name,string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " Soyadı: " + surName);
            //}

            //CustomerCard("Mahmut","Yıldız");
            //CustomerCard("Ayşe","Kaya");


            #endregion

            #region  Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(1, 2, 3);


            #endregion

            #region Geriye Metot Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Yıldız";

            //    return name+ " " + surname;
            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren  String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke:  " + countryName + " Başkent: " + capital + " Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x= Console.ReadLine();
            //Console.Write("Ülkenin başkentini Giriniz: ");
            //y = Console.ReadLine();
            //Console.Write("Ülkenin bayrağının rengini Giriniz: ");
            //z = Console.ReadLine();
            //Console.WriteLine( CountryCard(x, y, z));


            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1 , int number2)
            //{
            //    int result = number1+ number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45,653));
            //Console.WriteLine(Sum(45,655));
            //Console.WriteLine(Sum(45,635));
            //Console.WriteLine(Sum(45,645));
            //Console.WriteLine(Sum(452,65));
            //Console.WriteLine(Sum(425,65));

            #endregion

            #region Ornek Uygulama
            string ExamResult(string student,int exam1,int exam2,int exam3)
            {
                int result= (exam1+ exam2 +exam3) / 3 ;
                if (result >=50)
                {
                    return student +" Adlı öğrenci sınavı geçti.." + " Ortalaması: " +result;
                }
                else
                {
                    return  student + " Adlı Öğrenci Başarısız oldu.." +  " Ortalaması: " + result;
                }
            }

            Console.WriteLine(ExamResult("Ali",45,65,67));
            Console.WriteLine(ExamResult("Ayşe",35,25,47));

            #endregion

            Console.Read();
        }
    }
}
