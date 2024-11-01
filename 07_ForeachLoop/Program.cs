using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Dögüsü

            /*
            
            Foreach(1;2;3;4)
            1:Değişken türü
            2:Değişken Adı
            3:In
            4:Liste,koleksiyon,dizi

            */
            //string[] cities = { "ankara","milano","roma","budapeşte","istanbul","varşova" };

            //foreach(string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 1, 2, 345, 34534, 231, 12, 46578, 45, 64 };

            //foreach(int x in numbers)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 1, 2, 345, 34534, 231, 12, 46578, 45, 64 };

            //foreach (int x in numbers)
            //{
            //    if (x % 2 == 0)
            //    {
            //        Console.WriteLine(x);
            //    }
            //}

            //int[] numbers = { 1, 2, 345, 34534, 231, 12, 46578, 45, 64 };

            //int total = 0;

            //foreach(int i in numbers)
            //{
            //    total+= i;
            //}
            //Console.WriteLine(total);


            // List<int> numbers = new List<int>()
            // {
            //     1,23,3 ,4,5,6,7,
            // };

            //foreach(int i in numbers)
            // {
            //     Console.WriteLine(i);
            // }

            //string word = "Merhaba";

            //foreach(char i in word)
            //{
            //    Console.WriteLine(i);
            //}





            #endregion

            #region Örnek Sınav Sistemi Uygulaması


            Console.Write("***** C# Eğitim Kampı Sınavı Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Sınıftaki öğrenci sayısını kulanıcıdan alma
            Console.WriteLine("-----------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------");

            //Öğrenci isimleirni ve not ortalamalarını saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResault = 0;

                //her öğrenci için 3 sınav notu girişi
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResault += value; //notları toplama
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResault / 3;
            }

           //sınav ortalamaları

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine($"{studentNames[i]} isimli öğrencinin ortalaması: {studentExamAvg[i]}");

                //Öğrencilerin ortalaması ve geçip kalma durumları

                if (studentExamAvg[i] >=50) 
                {
                    Console.WriteLine($"{studentNames[i]} isimli öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} isimli öğrenci dersten kaldı");
                }

                Console.WriteLine("-----------------------------------------------------");

            }


            #endregion
            Console.Read();
        }
    }
}
