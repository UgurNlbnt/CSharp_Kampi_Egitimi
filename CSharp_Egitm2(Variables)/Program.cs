﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitim2_Variables_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + "TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + "TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + "TL");
            //Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + "TL");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + "TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawberryTotalPrice = strawberryPrice * strawberryGram;
            //double potatoTotalPrice = potatoPrice * potatoGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;

            //Console.WriteLine("Alınan Ürün: Elma -  " + "Birim Fiyat: " + applePrice  + "/" +"-Gramaj: " + appleGram + "/" + "Toplam Tutar: " + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal -  " + "Birim Fiyat: " + orangePrice  + "/" +"-Gramaj: " + orangeGram + "/" + "Toplam Tutar: " + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek -  " + "Birim Fiyat: " + strawberryPrice  + "/" +"-Gramaj: " + strawberryGram + "/" + "Toplam Tutar: " + strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates -  " + "Birim Fiyat: " + potatoPrice  + "/" +"-Gramaj: " + potatoGram + "/" + "Toplam Tutar: " + potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates -  " + "Birim Fiyat: " + tomatoPrice  + "/" +"-Gramaj: " +  tomatoGram + "/" + "Toplam Tutar: " + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutarı: " + shoppingTotalPrice + "TL");
            #endregion

            #region Char Değişkenler

            //sezar şifreleme: ABCDEFGH -> Herbir karakteri o karakterden sonraki karakterler yer değiştirir.
            //örneğin: TOPLANTI SAAT 20:00'DE her bir karaktere erişmemiz lazım. 
            //Tek tırnak ile tanımlanır.

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);
            #endregion

            #region Klavyeden Veri Girişleri String Değişkeler

            //Console.WriteLine("**** CSharp Hava Yollar Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrich, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrich = Console.ReadLine();

            //Console.Write("İl Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu T.C. Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("--------------------------");
            //Console.WriteLine("Yolcu: " + passengerName + " " + passengerSurname + " " + passengerDistrich + " " + passengerCity + " " + passengerAge + " " + passengerIdentityNumber);

            #endregion

            #region Klayveden Tam Sayı Girişleri ve Dönüşümleri

            //başlangıçta program bütün şeyelri string algılar dönüşüm yapmamız lazım.

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice=20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoeCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoeCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice= shoeCount*shoePrice + computerCount*computerPrice + chairCount*chairPrice + tvCount*tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam ödemenşiz gereken tutar: "+ totalPrice);

            #endregion

            #region Klayveden Ondalıklı Sayı İşlemleri

            //double exam1, exam2,exam3, result;

            //Console.Write("lütfen 1. sınav notunu giriniz:");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("lütfen 2. sınav notunu giriniz:");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("lütfen 3. sınav notunu giriniz:");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: "+ result);

            #endregion

            #region Klayveden Karakter Sayı İşlemleri

            //char gender;
            //Console.Write("Lütfen Cinsiyet seçiniz: ");
            //gender=char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: "+ gender);

            #endregion
            Console.Read();
        }
    }
}