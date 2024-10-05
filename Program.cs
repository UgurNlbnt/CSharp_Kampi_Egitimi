using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Egitim3_MakingDecision_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If-Else

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre doğrudur.");
            //}
            //else
            //    Console.WriteLine("Şifre yanlış.");

            //string capital, country;
            //Console.WriteLine("Başkenti giriniz:");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //if(capital == "ankara" && country == "türkiye")
            //{
            //    Console.WriteLine("verieler doğrulandı.");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı bilgi");
            //}

            //int number;
            //Console.WriteLine("sayıyı giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if(number == 5)
            //{
            //    Console.WriteLine("sayı doğru.");
            //}
            //else
            //{
            //    Console.WriteLine("sayı yanlış");
            //}


            //int exam1, exam2, exam3,average;
            //string result = "Hata!";

            //Console.Write("sınav1: ");
            //exam1=int.Parse(Console.ReadLine());
            //Console.Write("sınav2: ");
            //exam2 =int.Parse(Console.ReadLine());
            //Console.Write("sınav3: ");
            //exam3 =int.Parse(Console.ReadLine());

            //average = (exam1+exam2+exam3)/ 3;
            //Console.WriteLine("sınavların ortalaması: " + average);

            //if(average>0 && average<=50)
            //{
            //    result = "sonuc vasat";
            //}

            //if(average>50 && average<=70)
            //{
            //    result = "sonuc orta";
            //}

            //if(average>70 && average<=84)
            //{
            //    result = "sonuç iyi";
            //}

            //if (average > 84 && average <= 100)
            //{
            //    result = "sonuç çok iyi";
            //}

            //Console.WriteLine(result); 

            //string city;
            //Console.Write("LÜTFEN ŞEHİR GİRİŞİ YAPINIZ");
            //city = Console.ReadLine();

            //if (city == "adana" || city == "ankara" || city == "bursa" || city == "trabzon")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //    Console.WriteLine("şehir mevcut değil");

            //Console.Write("kullanıcı adını giriniz");
            //string username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("kullanıcı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("hoşgeldiniz!");
            //}
            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1.sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("lütfen 2. yasıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1%number2;
            //Console.Write("1.sayının 2. sayının bölümünden kalan: " +  result);

            //Console.Write("lütfen sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if(number%2==0) 
            //{
            //    Console.Write("sayı çifttir.");
            //}
            //else
            //{
            //    Console.Write("sayı tektir.");
            //}
            #endregion

            #region Char Değişkenler ile Karar Yapıları
            //char team;
            //Console.Write("lütfen takım sembolunu giriniz: ");
            //team=char.Parse(Console.ReadLine());

            //if(team=='g'||team=='G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}

            //if(team=='f'||team=='F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}

            //if (team == 'b' || team == 'B')
            //{
            //    Console.WriteLine("Besiktaş");
            //}
            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("****** c# eğitim kampı restorantı ******");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------------");

            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çprbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("---------------------------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.WriteLine("detayını gormek istediğiniz menüyü seçin");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------Ana Yemekler---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri soslu tavuk");
            //    Console.WriteLine("2-Kızartma tava");
            //    Console.WriteLine("3-Fsulye pilav");
            //    Console.WriteLine("4-somon");
            //    Console.WriteLine("5-Patlıcan musakka");
            //    Console.WriteLine("---------------Ana Yemekler---------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------Çormabalar---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek çorbası");
            //    Console.WriteLine("2-Ezogelin çorbası");
            //    Console.WriteLine("---------------Çorbalar---------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------Pizzalar---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz pizza");
            //    Console.WriteLine("2-margaritta");
            //    Console.WriteLine("3-Mantarlı pizza");
            //    Console.WriteLine("---------------pizzalar--------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------İçecekler---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-su");
            //    Console.WriteLine("---------------İçecekler--------------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------Tatlılar---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Triliçe");
            //    Console.WriteLine("2-Kaazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("---------------Tatlılar--------------");
            //    Console.WriteLine();
            //}


            Console.ReadKey();
            #endregion

            #region Switch Case

            //Console.Write("Lütfen ay girişi yapınız.");
            //int monthNumber=int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:Console.Write("ocak");
            //        break;

            //    case 2:
            //        Console.Write("şubat");
            //        break;
            //    case 3:
            //        Console.Write("mart");
            //        break;
            //    case 4:
            //        Console.Write("nisan");
            //        break;
            //    case 5:
            //        Console.Write("mayıs");
            //        break;
            //    case 6:
            //        Console.Write("haziran");
            //        break;
            //    case 7:
            //        Console.Write("temmuz");
            //        break;
            //    case 8:
            //        Console.Write("ağustos");
            //        break;
            //    case 9:
            //        Console.Write("eylül");
            //        break;
            //    case 10:
            //        Console.Write("ekim");
            //        break;
            //    case 11:
            //        Console.Write("kasım");
            //        break;
            //    case 12:
            //        Console.Write("aralık");
            //        break;

            //    default:Console.Write("Hatalı veri girişi!");
            //        break;

            //}


            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1.sayıyı giriniz: ");
            //number1=int.Parse(Console.ReadLine());

            //Console.Write("2.sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("lütfen yapmak istediğiniz işlemi giriniz: ");
            //symbol=char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result=number1+ number2; 
            //        Console.WriteLine("toplam: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("fark: " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("çarpım: " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("bölüm: " + result);
            //        break;

            //}

            #endregion

        }
    }
}
