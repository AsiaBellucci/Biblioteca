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
            //Console.WriteLine("Inserisci id: ");
            //int Id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Inserisci titolo: ");
            //string Titolo = Console.ReadLine();

            //Console.WriteLine("Inserisci nome utente: ");
            //Utente utente = Console.ReadLine();



            //Libro l = new Libro(Id, Titolo);
            //List<Libro> Libri = new List<Libro>();
            //l.assegnaLibro(utente, Id);

            //Console.WriteLine("Inserisci nome utente: ");
            //string nome = Console.ReadLine();
            //Console.WriteLine("Inserisci cognome utente: ");
            //string cognome = Console.ReadLine();
            Utente ut = new Utente("Luca","Verdi");
            Utente ut2 = new Utente("Mario", "Rossi");
            Libro l1 = new Libro(1, "tit1");
            Libro l2 = new Libro(2, "tit2");

            l1.assegnaLibro(ut);
            l2.assegnaLibro(ut);
            l1.restituzioneLibro(ut);
        }
    }
}
