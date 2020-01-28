using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Models
{
 
    public class Utente
    {
        internal string Nome { get; set; }
        internal string Cognome { get; set; }
        internal string Descrizione { //con il get assegni il nome e il cognome dell'utente alla descrizione
            get 
            { 
                return this.Nome + " " + this.Cognome;
            } 
            
        } 

       
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
