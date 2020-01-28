using Biblioteca_Interface.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca_Interface.Concretizzazione
{
    public class Studente : IPersona
    {
        public string Nome { get ; set; }
        public string Cognome { get; set; }
        public string Matricola { get; }

        public string Descrizione 
        {
        get
            {
                return this.Nome + " " + this.Cognome;
            }
        }

        public Studente(string nome, string cognome, string matricola)
        {
            this.Nome = nome;
            this.Cognome = cognome;
            this.Matricola = matricola;
        }

        

        public string Stampa(string descrizione, string matricola)
        {
            string value = $"Lo studente {descrizione} ha la matricola {matricola}";
            return value;
        }
    }
}
