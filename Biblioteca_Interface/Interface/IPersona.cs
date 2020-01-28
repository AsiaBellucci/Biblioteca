using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca_Interface.Interface
{
    public interface IPersona
    {
         string Nome { get; set; }
         string Cognome { get; set; }
         string Descrizione { get; }

        
    } 
}
