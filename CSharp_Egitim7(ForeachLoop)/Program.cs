using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Egitim7_ForeachLoop_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach döngüsü
            //4 parametre alır
            //1. değişken türü
            //2. değişken adı
            //3. in
            //4. liste ,koleksiyon, dizi

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };
            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 45, 78, 985, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //foreach (int i in number)
            //{
            //    Console.WriteLine(i);
            //}


            //int[] numbers = { 45, 78, 985, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //foreach(int number in  numbers)
            //{
            //    if(number %2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] number = { 45, 78, 985, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //int total = 0;
            //foreach (int i in number)
            //{
            //    total+= i;
            //}
            //Console.WriteLine(total);


            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //string word = "Merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}







            Console.Read();
            #endregion

            #region Örnek sınav sistemi uygulaması

            //Console.Write("***** C# Eğitim kampı sınav uygulaması *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();


            ////sınıftaki öğrenci sayısını kullanıcıdan alma
            //Console.WriteLine("-------------------------------");
            //Console.Write("sınıfınızda kaç öğrenci var");
            //int studentCount=int.Parse(Console.ReadLine());
            //Console.WriteLine("-------------------------------");

            ////öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //for(int i=0;i<studentCount; i++)
            //{
            //    Console.Write($"{i + 1}.öğrencinin ismini giriniz: ");
            //    studentNames[i] = Console.ReadLine();

            //    double totalExamResult = 0;


            //    //her öğrenci için 3 sınav notu girişi
            //    for(int j=0;j<3;j++)
            //    {
            //        Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz:");
            //        double value=double.Parse(Console.ReadLine());

            //        totalExamResult += value;//notları topladık.
            //    }
            //    studentExamAvg[i]= totalExamResult/3;
            //}

            ////Sınav ortalamaları
            //for(int i=0;i<studentCount;i++)
            //{
            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

            //    //öğrencilerin ortalaması ve geçme kalma durumları
            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti!"); 
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı!");
            //    }
            //}


            #endregion


        }
    }
}
