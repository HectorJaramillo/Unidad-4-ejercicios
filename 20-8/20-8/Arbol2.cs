using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_8
{
    class Arbol2
    {
        // EJEMPLO DEL UN ARBOL 
        private Nodo raiz;// LA ESTRUCTURA INDICA LA EXISTENCIA DE LA RAIZ 
        // EN NODO PRINCIPAL , SEGUIDO DE LAS RAMAS CONOCIDAS COMO HIJOS 
        public Arbol2()
        {
            raiz = null;
        }

        public void Insertar(int info)
        {
            // CADA QUE SE CREA UN NODO , SE DICE QUE EL NODO HIJO PUEDE SER PADRE
            // SIEMPRE Y CUANDO ESTE TENGA MAS RAMIFICACIONES, DE LO CONTRARIO,
            // UN HIJO SOLO PUEDE TENER HERMANOS QUE SON LOS QUE SALEN DEL MISMO NODO.
            Nodo nuevo;
            nuevo = new Nodo();
            // LA RAMIFICACION SE LLEVA DE IZQUIERDA A DERECHA CUANDO SE LLEVA ACABO 
            // LA ACOMODACION DE ELEMENTOS 
            nuevo.info = info;
            nuevo.izq = null;
            nuevo.der = null;
            if (raiz == null)
                raiz = nuevo;
            else
            {
                Nodo anterior = null, tempo;
                tempo = raiz;
                while (tempo != null)
                {
                    anterior = tempo;
                    if (info < tempo.info)
                        tempo = tempo.izq;
                    else
                        tempo = tempo.der;
                }
                if (info < anterior.info)
                    anterior.izq = nuevo;
                else
                    anterior.der = nuevo;
            }
        }
        // LOS SUB-ARBOLES SON TODOS LOS ARBOLES GENERADOS A PARTIR DE UNA 
        // SECCION DETERMINADA DEL ARBOL


        private void Inorden(Nodo tempo)
        {
            // DESCRIBE EL RECCORRIDO : EL PRIMER SUB-ARBOL, LUEGO SE RECORRE LA RAIZ 
            //Y AL FINAL SE RECORRE EN INORDEN DE LOS DEMAS SUB-ARBOLES
            if (tempo != null)
            {
                Inorden(tempo.izq);
                Console.Write(tempo.info + " ");
                Inorden(tempo.der);
            }
        }
        public void Inorden()
        {
            Inorden(raiz);
            Console.WriteLine();
        }
        private void PreOrden(Nodo tempo)
        {
            if (tempo != null)
            {
                Console.Write(tempo.info + " ");
                PreOrden(tempo.izq);
                PreOrden(tempo.der);
            }
        }

        public void PreOrden()
        {
            // ESTE RECORRODO COMIENZA EN LA RAIZ Y LUEGO ACOMODA CADA HOJA 
            // DE IQUIERDA A DERECHA CADA UNO DE LOS SUB-ARBOLES
            PreOrden(raiz);
            Console.WriteLine();
        }
        public void ArbolB()
        {
            Insertar(-1);
            Insertar(7);
            Insertar(4);
            Insertar(11);
            Insertar(5);
            Insertar(-8);
            Insertar(15);
            Insertar(-3);
            Insertar(-2);
            Insertar(6);
            Insertar(10);
            Insertar(3);
            Console.WriteLine("Pre Orden");
            PreOrden();
            Console.WriteLine("In Orden");
            Inorden();
        }
    }
}
