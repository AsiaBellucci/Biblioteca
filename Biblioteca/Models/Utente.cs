using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Models
{
 
    public class Utente
    {
        public string Nome;
        public string Cognome;

       
        public Utente(string nome, string cognome)
        {
            this.Nome = nome;
            this.Cognome = cognome;
        }
        public void getBook()
        {
            Console.WriteLine("Inserisci titolo: ");
            string Titolo = Console.ReadLine();
        }
    }
}
