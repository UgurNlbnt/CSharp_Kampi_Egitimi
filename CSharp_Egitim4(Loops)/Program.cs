﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Egitim4_Loops_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //döngüler 1+2+3+4+5+6
            //3+3=6+4=10+5=15+6=21

            //for döngüsü 3 parametreye sahiptir.for(x;y;z)
            //x:başlangıç
            //y:bitiş
            //artış/azalış

            //int i;
            //for(i=1 ; i<=5 ; i++)
            //{
            //    Console.WriteLine("C# Eğitim kampı");
            //}

            //for(i=3; i<=50 ; i +=3)
            //{
            //    Console.WriteLine(i);
            //}


            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for(int i= 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("yaşasın cumhuriyet");
            //}

            #endregion

            #region For döngüsü ile karar yapıları

            //for (int i = 0; i < 100; i++)
            //{
            //    if(i%5==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //int totalValue = 0; 

            //for (int i = 0; i < 10; i++)
            //{
            //    totalValue+= i;
            //}

            //Console.WriteLine(totalValue);

            //int totalValue = 0;
            //for (int i = 0; i < 20; i++)
            //{
            //    if(i%2==0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("----------------------");
            //Console.WriteLine(totalValue);

            //int count = 0;
            //for(int i=1;i<=50;i++) 
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //1-2-4-6-16...
            //her saaatte bakteri 2 kat artıyo 24 saat sonra kaç bakteri olur.

            //int bacterium = 1;
            //for(int i = 1; i <= 24; i++) 
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i+".Saat sonunda: " + bacterium + " " + "bakteri oluşur");
            //}



            #endregion

            #region While Döngüsü
            //şart sağlandığı müddetçe dönguye devam edilir. 
            //While(şart)
            //{
            //işlemler
            //}

            //int i=1;
            //while(i<=10)
            //{
            //    Console.WriteLine("merhaba döngüler");
            //    i++;
            //}

            //int i = 1;
            //while(i<=10)
            //{
            //    if(i%3==0 )
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}


            //int i = 1;
            //int sum = 0;
            //while(i<=10)
            //{
            //    sum += i;
            //    i++;
            //}

            //Console.WriteLine(sum);



            #endregion

            #region Örnek Sınav Sorusu

            //klavyeden girilen 3 basamaklı sayının basamaklarını toplamını hesaplayan C# programını yazınız. 

            //Console.Write("sayı giriniz:");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundred;
            //int sum;

            //hundred = number / 100;
            //tens = (number % 100) / 10;
            //ones = number % 10;

            //Console.WriteLine(hundred+" "+ tens+" "+ones+"sayıların basamakları.");

            //sum = ones + tens + ones;
            //Console.WriteLine(sum);
            

            #endregion


            Console.Read();
        }
    }
}