using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Models
{
    public class Libro
    {
        private int id;
        private string titolo;
        private Utente utente;

        public Libro(int id, string titolo)
        {
            this.id = id;
            this.titolo = titolo;
            this.utente = null;
        }

        public void assegnaLibro(Utente utente, int id)
        {

            if (this.utente == null)
            {
                this.utente = utente;
                Console.WriteLine($"Il libro{id} è stato assegnato a {utente}");
            }
        }

        public void RestituireLibro(Utente utente)
        {
            if(utente)
            {
                this.utente = null;
                Console.WriteLine($"L'utente {utente} è stato rimosso");
            }
        }
    }
}
