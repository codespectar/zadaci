using System;
using System.Collections;

/*Kreirati klase:
1. Klasu Ucenik koja ima:
a. Privatno polje prezimeIme koje saadrži prezime i ime učenika
b. Privatno polje nedovoljne koje ima vrednost true ili false i pokazuje da li učenik ima nedovoljne ocene
c. Privatno polje prosek sadrži prosečnu ocenu učenika.
d. Javna svojstva za postavljanje i čitanje gore navedenih privatnih polja
e. Default konstruktor koji prezimeIme postavlja na prazan string, nedovoljne na false i prosek na nulu.
f. Metod Uspeh za određivanje uspeha (“odlican”, “vrlo dobar”...) na osnovu
podataka o učeniku
g. Metod PrikaziUcenika za prikaz podataka o učeniku – ime, prezime i uspeh
2. Klasu Odeljenje koja ima: 
a. Privatno polje oznakaOdeljenja.
b. Privatno polje spisakUcenika (tipa ArrayList)
c. Javna svojstva za date privatne atribute
d. Konstruktor koji za argument ima oznaku odeljenja i inicijalizuje spisak učenika na spisak dužine nula.
e. Metod UnesiUcenika za unos učenika u odeljenje
f. Metod PrikaziOdeljenje za prikaz svih učenika i njihovog uspeha
U glavnom programu kreirati odeljenje, uneti učenike, prikazati spisak ucenika i prebrojati koliko ima odličnih u odeljenju. 
*/

namespace UcenikOdeljenje
{
    class Program
    {
        static void Main(string[] args)
        { 
            Odeljenje odeljenje = new Odeljenje("III3");
            for (int i = 0; i<2; i++)
            {
                odeljenje.UnesiUcenika();
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("Spisak ucenika za odeljenje " + odeljenje.OznakaOdeljenja);
            odeljenje.PrikaziOdeljenje();
            int brojOdlicnih = 0;
            foreach (Ucenik uc in odeljenje.SpisakUcenika)
            {
                if (uc.Uspeh() == "Odličan")
                    brojOdlicnih++ ;
            }
            Console.Write("Odlicnih ucenika je :" + brojOdlicnih);
            Console.ReadLine();
        }
    }
    class Ucenik
    {
        private string prezimeIme;
        private bool nedovoljne;
        private double prosek;
        public string PrezimeIme
        {
            get { return prezimeIme; }
            set { prezimeIme = value; }
        }
        public bool Nedovoljne
        {
            get { return nedovoljne; }
            set { nedovoljne = value; }
        }
        public double Prosek
        {
            get { return prosek; }
            set {  prosek = value; }
        }
         public Ucenik()
        {
            PrezimeIme = "";
            Nedovoljne = false;
            Prosek = 0;
        }
         public string Uspeh()
        {
            if (!Nedovoljne)
            {
                if (Prosek >= 4.5 && Prosek <= 5)
                    return "Odličan";
                else if (Prosek >= 3.5)
                    return "Vrlo dobar";
                else if (Prosek >= 2.5)
                    return "Dobar";
                else 
                    return "Dovoljan";
            }
            else
                return "Nedovoljan";
        }
        public void PrikaziUcenika()
        {
            //Console.WriteLine(PrezimeIme + "\t" + Uspeh());
            Console.WriteLine("{0:20} \t {1}", PrezimeIme, Uspeh());
        }
    }
    class Odeljenje
    {
        private string oznakaOdeljenja;
        private ArrayList spisakUcenika = new ArrayList();
        public string OznakaOdeljenja
        {
            get { return oznakaOdeljenja; }
            set { oznakaOdeljenja = value; }
        }
        public ArrayList SpisakUcenika
        {
            get { return spisakUcenika; }
        }
        public Odeljenje(string oznakaOdeljenja)
        {
            OznakaOdeljenja = oznakaOdeljenja;
            spisakUcenika.Capacity = 0;
        }
        public void UnesiUcenika()
        {
            Ucenik ucenik = new Ucenik();
            Console.WriteLine("Unesite prezime i ime ucenika.");
            ucenik.PrezimeIme = Console.ReadLine();
            Console.WriteLine("Da li ucenik ima nedovoljne.(true/false)");
            ucenik.Nedovoljne = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Unesite uspeh ucenika.");
            ucenik.Prosek = Convert.ToDouble(Console.ReadLine());
            spisakUcenika.Add(ucenik);
        }
         public void PrikaziOdeljenje()
        {
            foreach (Ucenik el in spisakUcenika)
                el.PrikaziUcenika();
        }
    }
}

    
       
