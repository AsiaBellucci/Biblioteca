using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Models
{
    /// <summary>
    /// Rappresenta un libro e gestisce l'assegnazione degli stessi
    /// </summary>
    public class Libro
    {
        private int id;
        private string titolo;
        private Utente utente;// L'utente che ha in prestito il libro, se null il libro è disponibile

        public Libro(int id, string titolo)
        {
            this.id = id;
            this.titolo = titolo;
            this.utente = null;
        }

        #region metodi
        /// <summary>
        /// permette di assegnare un libro e ne verifica la dispponibilità
        /// </summary>
        /// <param name="richiedente">accetta in ingresso un oggetto di tipo utente</param>
        public void assegnaLibro(Utente richiedente)
        {

            if (this.utente == null)
            {
                this.utente = richiedente;
                Console.WriteLine($"Il libro è stato assegnato a {richiedente.Nome} {richiedente.Cognome}");
            }
            else
            {
                Console.WriteLine("Il libro è già stato assegnato");
            }
        }

        /// <summary>
        /// permette di restituire un libro e verifica se l'utente ne è in possesso
        /// </summary>
        /// <param name="restituente"></param>
        public void restituzioneLibro(Utente restituente)
        {
            if(this.utente != null)
            {
                Console.WriteLine($"L'utente {restituente.Nome} {restituente.Cognome} sta restituendo il libro");
                restituente = null;
            }
            else
            {
                Console.WriteLine("Il libro è disponibile");
            }
        }
#endregion

    }
}
