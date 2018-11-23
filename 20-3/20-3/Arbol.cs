using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_3
{
    public class Arbol
    {
        private Nodo Raiz { get; set; }//RAIZ DEL ARBOL
        private int Contador = 0;
        public Arbol() { Raiz = null; }//CONSTRUCTOR DE LA CLASE ARBOLICO

        // AQUI LOS EVALUAMOS 
        public Nodo Insertar(int DatoXL, Nodo nodo)
        { // SI EL DATO ES MAOR QUE LA RAIZ ENTONCES SE IRA A LA DERECHA O IZQUIERDA 
            Nodo temporal = null;
            if (nodo == null)
            {
                temporal = new Nodo();//SI EL NODO TEMPORAL ES NULO  EL PRIMER DATO ENTRA COMO LA RAIZ
                temporal.Dato = DatoXL;
                return temporal;
            }
            // SI EL NUEVO DATO INGRESADO ES MAYOR VA A LA IZQUIERDA
            if (DatoXL < nodo.Dato)
            {
                nodo.Izquierdo = Insertar(DatoXL, nodo.Izquierdo);
            }
            if (DatoXL > nodo.Dato)
            { // SI NO VA A LA DERECHA 
                nodo.Derecha = Insertar(DatoXL, nodo.Derecha);
            }
            return nodo;//RETORNO NODO
        }

        public void Impresion(Nodo nodo)
        {
            //D1 E2 B3 H4 I5 A6 F7 J8 C9 G10 K11
            List<char> Lista = new List<char>
            {'D','E','B','H','I','A','F','J','C','G','K'};
            if (nodo == null) return; // IMPRESION DEL ARBOL
            for (int cont = 0; cont < Contador; cont++)
            {
                Console.Write("->");
            }
            Console.WriteLine(Lista[nodo.Dato - 1]);
            if (nodo.Izquierdo != null)
            { // IDENTIFICADOR DEL NODO IZQUIERDO Y LLAMADA RECURSIVA DEL METODO
                Contador++; Console.Write("Izq ");
                Impresion(nodo.Izquierdo); Contador--;
            } // IDENTIFICADOR DEL NODO NODO Y LLAMADA RECURSIVA DEL METODO
            if (nodo.Derecha != null)
            {
                Contador++; Console.Write("Der ");
                Impresion(nodo.Derecha); Contador--;
            }
        }

        public void OrdenacionConNombreLargo(Nodo nodo)
        {
            //D1 E2 B3 H4 I5 A6 F7 J8 C9 G10 K11
            List<char> Lista = new List<char>
            {'D','E','B','H','I','A','F','J','C','G','K'};
            // IMPRIME LOS NUMEROS EN ORDEN INICIO RAIZ 
            if (nodo == null) return;
            if (nodo.Izquierdo != null)
            {
                Contador++; OrdenacionConNombreLargo(nodo.Izquierdo); Contador--;
            } // LOS ACOMODAN DE MENOR A MAYOR 1,2,3...       
            Console.Write(" ->" + Lista[nodo.Dato - 1]);
            if (nodo.Derecha != null)
            {
                Contador++; OrdenacionConNombreLargo(nodo.Derecha); Contador--;
            }
        }

        public void PreOrden(Nodo nodo)
        {
            //D1 E2 B3 H4 I5 A6 F7 J8 C9 G10 K11
            List<char> Lista = new List<char>
            {'D','E','B','H','I','A','F','J','C','G','K'};
            if (nodo == null) return;
            if (nodo.Izquierdo != null)
            {
                Contador++; OrdenacionConNombreLargo(nodo.Izquierdo); Contador--;//IMPRIME LA RAIZ
            }
            if (nodo.Derecha != null)
            {
                Contador++; OrdenacionConNombreLargo(nodo.Derecha); Contador--;// RECORRE LOS NODOS DE LA IZQUIERDOS Y LUEGO LOS DERECHOS 
            }
            Console.Write(" ->" + Lista[nodo.Dato - 1]);//IMPRIME LA RAIZ
        }
    }
}
