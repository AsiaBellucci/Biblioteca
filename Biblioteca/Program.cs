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
            Console.WriteLine("Inserisci id: ");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci titolo: ");
            string Titolo = Console.ReadLine();
            
            Console.WriteLine("Inserisci nome utente: ");
            string utente = Console.ReadLine();
            
            

            Libro l = new Libro(Id, Titolo);
            List<Libro> Libri = new List<Libro>();
            l.assegnaLibro(utente, Id);
        }
    }
}
