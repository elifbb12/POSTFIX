using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSTFİX_VARİ_YAPILARI
{
    class Program
    {
        public delegate int YeniDelagate(int p, int q);
        static void calistir(int a ,int b, YeniDelagate yd)
        {
            Console.WriteLine(yd(a,b));
        }
        static int topla(int a, int b)
        {
            return a + b;
        }
        static int cıkart(int a, int b)
        {
            return a - b;
        }
        static int carp(int a, int b)
        {
            return a * b;
        }
        static int bol(int a, int b)
        {
            return a / b;
        }
        static void Main(string[] args)
        
        
        {
            YeniDelagate yd = topla;
          

            yd += cıkart;
            yd += carp;
            yd += bol;
            yd -= bol;
            Console.WriteLine(yd(5,78));
            calistir(12, 12, carp);
            //calistir(12, 12, (a,b)=>{ return a * b;});  //lambda expression//sahipsiz metot


            //a+b*c =50  abc*+ a=10 , b=20, c=2
            //Matemetiksel öncelikler işlemi
            //abc*+ (stack kullanılacak.)
            //stack bottom kısmı olucak en başağıdan yani bottomdan stağa çıkacak.
            int a = 10;
            int b = 20;
            int c = 2;
            c = a /( b * 2+a-c)*(a+b-c)+c; //işlemler sırayla yazıldı.
                                           //delegate metotlara pointer(metot imzası)
                                           //bir metota başka bir metot göndermek için delegate işe yarar.

            Console.ReadLine();
        }
    }
}
