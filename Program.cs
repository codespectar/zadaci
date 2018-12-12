using System;

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
          



            /*
            try
            {
                //using (StreamReader sr = new StreamReader("TextFile1.txt"));
                string path1 = @"C:\Users\julij\source\repos\UcenikOdeljenje\UcenikOdeljenje\TextFile1.txt";
                using (StreamReader sr = new StreamReader(path1))
  
                {
                    string line;
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            */
        }
    }
}
