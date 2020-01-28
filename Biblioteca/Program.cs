using Biblioteca.Models;
using System;
using System.Collections.Generic;

namespace Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            
            addNewBook();

        }

        public static void addNewBook()
        {
            
            Utente ut = new Utente("Luca","Verdi");
            Utente ut2 = new Utente("Mario", "Rossi");
            Libro l1 = new Libro(1, "tit1");
            Libro l2 = new Libro(2, "tit2");

            l1.assegnaLibro(ut);
            l2.assegnaLibro(ut);
            l1.restituzioneLibro(ut);


            Utente ut3 = new Utente("Paolo", "Bianchi");
            Console.WriteLine($"La descrizione è {ut3.Descrizione}");
            Console.ReadLine();
            Console.WriteLine("premere un tasto per terminare.");
        }
    }
}
