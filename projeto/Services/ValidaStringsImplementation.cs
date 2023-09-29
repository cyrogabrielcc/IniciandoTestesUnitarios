using System.Net.Mime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto.Services
{
    public class ValidaStringsImplementation
    {
        public int ContaTexto(string texto)
        {
            return texto.Length;     
        }
    }
}