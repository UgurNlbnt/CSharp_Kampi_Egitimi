using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitim1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları 
            //bir şeyin method olduğunu anlamamız için yanında mor küp olmalı.
            //Console.Write("merhaba dünya");
            //Console.WriteLine("selamlar"); //WriteLine komutu içerideki bilgiyi yazdıktan sonra imleci aşağıdaki satıra geçirir.
            //Console.Read(); //Read methodu üst tarafataki kod satırları çalıştırdığımızda "enter" tuşuna basana kadar ekranda gösterir. Yazmazsak konsol ekranı direk kapanır.

            //Console.WriteLine("***** Yemek Katagorileri *****");
            //Console.WriteLine("");
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler"); 
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekeler");
            //Console.Read();
            #endregion

            #region String_Değişkenler
            //Değişken tanımlama -> Değişken_türü değişken_Adı;
            //string -> Alfabetik türde değişkenlerimizi tutabileceğimzi tür.

            //string name;
            //name = "Uğur";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district ,city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 500 444 20 20";
            //customerEmail = "ali_çıanr@gamil.com";
            //district = "küçükçekmece";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine("");
            //Console.WriteLine("---------------------------");
            //Console.WriteLine("Müsteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("---------------------------");

            //customerName = "Ayşegül";
            //customerSurname = "Çoner";
            //customerPhone = "+90 500 333 20 50";
            //customerEmail = "aysegülr@gamil.com";
            //district = "Büyükçekmece";
            //city = "İstanbul";

            //Console.WriteLine(""); 

            //Console.WriteLine("---------------------------");
            //Console.WriteLine("Müsteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("---------------------------");

            #endregion

            #region İnt_Değişkenler
            //int -> tam sayı değişkeni.
            //int number = 24;
            //Console.WriteLine(number);

            //int hamburgerPrice = 300;
            //int colaPrice = 35;
            //int waterPrice = 10;
            //int friesPrice = 50;
            //int pizzaPrice = 200;
            //int limonadePrice = 30;

            //Console.WriteLine("**** Restoran Menü ****");
            //Console.WriteLine("");
            //Console.WriteLine("-Hamburger Fiyatı : " + hamburgerPrice + "TL");
            //Console.WriteLine("-Pizza fiyatı: " + pizzaPrice + "TL");
            //Console.WriteLine("-Kola : " + colaPrice);
            //Console.WriteLine("-limanata Fiyatı: " + limonadePrice + "TL");
            //Console.WriteLine("-Kızartma : " + friesPrice + "TL");
            //Console.WriteLine("-Su: " + waterPrice + "TL");
            //Console.WriteLine("");
            //Console.WriteLine("**** Restoran Menü ****");

            //Console.WriteLine();
            //int hamburgerCount;
            //int colaCount;
            //int limonadeCount;
            //int friesCount;
            //int pizzaCount;
            //int waterCount;

            //int totalHamburgerPrice = 0;
            //int totalColaPrice = 0;
            //int totalWaterPrice = 0;
            //int totalLemonadePrice = 0;
            //int totalPizzaPrice = 0;
            //int totalFriesPrice = 0;

            //hamburgerCount=3;
            //colaCount = 2;
            //limonadeCount = 3;
            //friesCount = 0 ;
            //pizzaCount = 1;
            //waterCount = 3;

            //totalHamburgerPrice = hamburgerPrice * hamburgerCount;
            //totalColaPrice = colaPrice * colaCount;
            //totalWaterPrice = waterPrice * waterCount;
            //totalPizzaPrice = pizzaPrice * pizzaCount;
            //totalFriesPrice = friesPrice * friesCount;
            //totalLemonadePrice = limonadePrice * limonadeCount;

            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("hamburger tutar: " + totalHamburgerPrice);
            //Console.WriteLine("pizza tutar: " + totalPizzaPrice);
            //Console.WriteLine("kola tutar: "+ totalColaPrice);
            //Console.WriteLine("kızartma tutar: " + totalFriesPrice);
            //Console.WriteLine("su tutarı: " + totalWaterPrice);
            //Console.WriteLine("limonata tutar: " + totalLemonadePrice);

            //Console.WriteLine();

            //int totalPrice = totalHamburgerPrice + totalPizzaPrice + totalFriesPrice + totalLemonadePrice + totalWaterPrice + totalColaPrice;
            //Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice);
            #endregion

            //    Console.Read();
        }
    }
}