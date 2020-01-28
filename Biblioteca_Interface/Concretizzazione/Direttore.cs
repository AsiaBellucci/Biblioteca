using Biblioteca_Interface.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca_Interface.Concretizzazione
{
    public class Direttore : IPersona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Descrizione
        {
            get
            {
                return this.Nome + " " + this.Cognome;
            }

        }


        public Direttore(string nome, string cognome)
        {
            this.Nome = nome;
            this.Cognome = cognome;
        }
    }
}
