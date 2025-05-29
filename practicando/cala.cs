using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicando
{
    internal class cala
    {
        /*EJERCICIO 2  Crear un programa donde se ingrese el nombre de las 
             * personas quellegan a un restaurante, mostrar el orden de la cola y cuantas 
             * personas hay en ella.*/
        nodo Primero {  get; set; }
        public void Agregar_nombre(string nombre)
        {
            nodo nuevo = new nodo(nombre);
            if (this.Primero == null)
            {
                this.Primero = nuevo;
            }
            else
            {
                nodo temp = this.Primero;
                while (temp.sig != null)
                {
                    temp = temp.sig;
                }
                temp.sig = nuevo;
            }
        }
        public int Tamaño()
        {
            if (this.Primero == null) { return 0; }
            else
            {
                int cant = 0;
                nodo temp = this.Primero;
                while (temp.sig != null)
                {
                    cant++;
                    temp = temp.sig;
                }
                return cant;
            }
        }
        public override string ToString()
        {
            string todo = "";
            nodo temp = this.Primero;
            while (temp.sig != null)
            {
                todo += temp.Dato + ", ";
                temp = temp.sig;
            }
            return todo;
        }
    }
}
