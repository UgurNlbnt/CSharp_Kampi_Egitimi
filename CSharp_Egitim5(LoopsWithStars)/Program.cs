using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Egitim5_LoopsWithStars_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 tane yıldız oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region Yan yana 10 tane yıldız oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region Yan yana 10 tane yıldız oluşturma her satırda 10 tane yıldız olsun. 

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*********");
            //}

            #endregion

            #region Dik üçgen

            //for(int i = 1;i<=5;i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ters Dik üçgen

            //for(int i = 5;i>=1;i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region Ters ve Dik üçgen beraber çizimi

            //for(int i =1 ; i <=5 ; i++)
            //{
            //    for(int j =1 ; j <=i ;j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for(int m =4 ; m>=1 ;m--)
            //{
            //    for(int k=1 ; k<=m ;k++)
            //    {
            //        Console.Write('*');
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region Baklava dilimi
            //int n = 5;
            //for(int i = 1;i <= n;i++)
            //{
            //    for(int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int k=1; k<=2*i-1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //alt kısım
            //for(int i = n - 1; i >= 1; i--)
            //{
            //    for(int j = n - 1;j>0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Piramit
            //int n = 5;
            //for(int i = 1; i <= n; i++)
            //{
            //    //boşluk
            //    for(int j = n - 1;j> 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    //yıldızlar
            //    for(int k=1;k<=2*i-1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}



            #endregion

            #region Ters Piramit
            //int n = 5;
            //for (int i = n; i >= 1; i--)
            //{
            //    //boşluk
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    //yıldızlar
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            Console.Read();
        }
    }
}
