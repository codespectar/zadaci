using System;
/*1. Napraviti:
1) Strukturu Tacka koja ima:
    a. javna polja x i y
    b. konstruktor sa dva parametra za postavljanje vrednosti polja
    c. metod za Prikazi za prikaz tačke kao uređenog para
2) Klasu Vektor koja ima:
    a. privatna polja _pocetak i _kraj koja predstavljaju početnu i krajnju tačku vektora
    b. javna svojstva za čitanje i upis u privatna polja
    c. default konstruktor i konstruktor sa dva parametra za inicijalizaciju krajnjih
    tačaka vektora
    d. metod Prikaz za prikaz vektora kao uređenog para dve tačke
    e. overload operatora + za određivanje zbira dva vektora 

U Main metodi testirati kreiranu klasu kreiranjem dva objekta klase Vektor, određivanjem zbira
dva kreirana vektora i prikazom rezultujućeg vektora. 
 * */
namespace OperatorOverload
{
    struct Tacka
    {
        public double x, y;
        public Tacka(double x, double y)
        { this.x = x; this.y = y; }

        public string Prikazi()
        {
            return string.Format("({0},{1})", x, y);
        }
    }
    class Vektor
    {
        private Tacka _pocetak;
        private Tacka _kraj;

        public Tacka Pocetak
        {
            get { return _pocetak; }
            set { _pocetak = value; }
        }
        public Tacka Kraj
        {
            get { return _kraj; }
            set { _kraj = value; }
        }
        public Vektor() { }
        public Vektor(Tacka Pocetak, Tacka Kraj)
        {
            this.Pocetak = Pocetak;
            this.Kraj = Kraj;
        }
        public string Prikazi()
        {
            return string.Format("{0}-{1}", Pocetak.Prikazi(), Kraj.Prikazi());
        }

        public static Vektor operator +(Vektor v1, Vektor v2)
        {
            Vektor v3 = new Vektor();
            double pomX = v1.Kraj.x - v2.Pocetak.x;
            double pomY = v1.Kraj.y - v2.Pocetak.y;

           
            v2.Pocetak = v1.Kraj;
            v2.Kraj = new Tacka(v2.Kraj.x + pomX, v2.Kraj.y + pomY);

            v3.Pocetak = v1.Pocetak;
            v3.Kraj = v2.Kraj;

            return v3;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Tacka a = new Tacka(0, 0);
            Tacka b = new Tacka(5, 5);
            Tacka c = new Tacka(7, 10);
            Tacka d = new Tacka(7, 15);

            Vektor v1 = new Vektor(a, b);

            Vektor v2 = new Vektor();
            v2.Pocetak = c;
            v2.Kraj = d;

            Console.WriteLine("v1=" + v1.Prikazi());
            Console.WriteLine("v2=" + v2.Prikazi());
            Vektor v3 = v1 + v2;
            Console.WriteLine("v1+v2=" + v3.Prikazi());
            

            Console.Read();

        }
    }
}
