using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_3
{
    public class Nodo
    {
        public Nodo Izquierdo { get; set; } //ATRIBUTOS DE LA CLASE NODO
        public Nodo Derecha { get; set; }
        public int Dato { get; set; }// DATOS QUE ENTRARAN AL ARBOL
        public Nodo()//CONSTRUCTOR DE LA CLASE NODO
        {
            Dato = 0;
            Izquierdo = null;
            Derecha = null;
        }
    }
}
