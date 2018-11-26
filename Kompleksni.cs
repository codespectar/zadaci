using System;

namespace OverloadOperator
{
    class Kompleksni
    {
        private double re;
        private double im;
        public Kompleksni()
        {
            re = 0;
            im = 0;
        }
        public Kompleksni(double realni, double imaginarni)
        {
            re = realni;
            im = imaginarni;
        }
        public static Kompleksni operator +(Kompleksni Z1, Kompleksni Z2)
        {
            Kompleksni Z3 = new Kompleksni();
            Z3.re = Z1.re + Z2.re;
            Z3.im = Z1.im + Z2.im;
            return Z3;
        }
        public static Kompleksni operator -(Kompleksni Z1, Kompleksni Z2)
        {
            Kompleksni Z3 = new Kompleksni();
            Z3.re = Z1.re - Z2.re;
            Z3.im = Z1.im - Z2.im;
            return Z3;
        }
        public static Kompleksni operator *(Kompleksni Z1, Kompleksni Z2)
        {
            Kompleksni Z3 = new Kompleksni();
            Z3.re = Z1.re * Z2.re - Z1.im * Z2.im;
            Z3.im = Z1.re * Z2.im + Z1.im * Z2.re;
            return Z3;
        }
        public static Kompleksni operator /(Kompleksni Z1, Kompleksni Z2)
        {
            Kompleksni Z3 = new Kompleksni();
            Z3.re = (Z1.re * Z2.re - Z1.im * Z2.im) / (Math.Pow(Z2.re, 2) + Math.Pow(Z2.im, 2));
            Z3.im = (Z1.im * Z2.re - Z1.re * Z2.im) / (Math.Pow(Z2.re, 2) + Math.Pow(Z2.im, 2));
            return Z3;
        }
        public static Kompleksni operator !(Kompleksni Z1)
        {
            Kompleksni Z2 = new Kompleksni();
            Z2.re = Z1.re;
            Z2.im = -Z1.im;
            return Z2;
        }
        public void Prikaz()
        {
            Console.Write(re);
            if (im > 0)
                Console.WriteLine("+j" + im);
            else
                Console.WriteLine("-j" + -im);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kompleksni Z1 = new Kompleksni(4, -6);
            Kompleksni Z2 = new Kompleksni(-2, -3);
            Console.Write("Z1 = ");
            Z1.Prikaz();
            Console.Write("Z2 = ");
            Z2.Prikaz();
            Kompleksni Z3 = new Kompleksni();
            Console.Write("Zbir Z1 i Z2: Z3 = ");
            Z3 = Z1 + Z2;
            Z3.Prikaz();
            Console.Write("Razlika Z1 i Z2: Z3 = ");
            Z3 = Z1 - Z2;
            Z3.Prikaz();
            Console.Write("Proizvod Z1 i Z2: Z3 = ");
            Z3 = Z1 * Z2;
            Z3.Prikaz();
            Console.Write("Kolicnik Z1 i Z2: Z3 = ");
            Z3 = Z1 / Z2;
            Z3.Prikaz();
            Console.Write("Konjugovano kompleksni broj broja Z1: Z3 = ");
            Z3 = !Z1;
            Z3.Prikaz();
        }
    }
}
