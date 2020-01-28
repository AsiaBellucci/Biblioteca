using Biblioteca_Interface.Concretizzazione;
using Biblioteca_Interface.Interface;
using System;

namespace Biblioteca_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Direttore dir = new Direttore("aaa", "bbb");
            Console.WriteLine($"Il direttore è {dir.Descrizione}");
            Studente s = new Studente("Giorgio", "Bianchi", "123");
            string desc = s.Descrizione;
            s.Stampa(desc, s.Matricola);
            Console.WriteLine("premere un tasto per terminare.");
            //Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
