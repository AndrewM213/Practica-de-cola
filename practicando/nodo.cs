using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicando
{
    internal class nodo
    {
        public string Dato {  get; set; }
        public nodo sig {  get; set; }

        public nodo (string dato)
        {
            Dato = dato;
        }
         public nodo()
        { }
    }
}
