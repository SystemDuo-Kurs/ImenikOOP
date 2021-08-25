using System;
using System.Collections.Generic;

namespace Imenik
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba abc = new Osoba { Ime = "Pera" };
           
            List<Osoba> osobe = new();
            while(true)
            {
                Osoba o = new();
                Console.Write("Ime: ");
                o.Ime = Console.ReadLine();
                Console.Write("Prezime: ");
                o.Prezime = Console.ReadLine();
                osobe.Add(o);
                //moze i osobe.Add(new Osoba { Ime = ime, Prezime = prezime });
                foreach (Osoba neko in osobe)
                {
                    Console.WriteLine($"{neko.Ime} -- {neko.Prezime}");
                }
            }
        }
    }
    class Osoba
    {
        public string Ime;
        public string Prezime;
        public string Telefon;

        

        /*public Osoba(string ime, string prezime) //konstruktor
        {
            Ime = ime;
            Prezime = prezime;
            Console.WriteLine("radiiii :)");
        }
        public Osoba(string ime, string prezime, string tel) //konstruktor
        {
            Ime = ime;
            Prezime = prezime;
            Telefon = tel;
            Console.WriteLine("radiiii :)");
        }*/
    }
}
