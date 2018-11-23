﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_6
{
    public class Arbol //Clase arbol
    {
        public static string OracionCompleta = "El rápido zorro marrón salta sobre el perro perezoso";
        public static char[] delimitador = { ' ' };//ARREGLO CHAR QUE NOS INDICARA EL DELIMITADOR DE LA ORACION ' '
        public string[] Partes = OracionCompleta.Split(delimitador);//SE SEPARA LA ORACION POR PALABRA CADA VEZ QUE ENCUENTRA UN ' '
        public int altura; //Variable que guardara el valor de la altura del arbol
        class Nodo //Clase nodo
        {
            public int info; //Guarda el valor que toma el nodo
            public Nodo izq, der; //Dos punteros
        }
        Nodo raiz; //Se crea un objeto raiz;

        class Dato //Clase dato
        {
            public string lugar; //Almacena el camino al dato ingresado
            public int posicionaltura; //Almacena el nivel de cada dato
        }
        List<Dato> weita = new List<Dato>(); //Lista que guarda objetos de la clase Dato

        public Arbol() //Constructor de la clase Arbol
        {
            raiz = null;
        }

        public void Insertar(int info) //Metodo el cual inserta los datos en el arbol
        {
            string Concatenador = ""; //Nos permite guardar la ruta de cada nodo
            int contador = 1; //Contador
            Dato dato = new Dato(); //Se crea un nuevo nodo el cual va a guardar el dato ingresado
            Nodo nuevo;
            nuevo = new Nodo
            {
                info = info,
                izq = null,
                der = null
            };
            if (raiz == null) //Significa que es el primer dato y lo almacena directamente
            {
                raiz = nuevo;
                Concatenador = Convert.ToString(raiz.info);
            }
            else //Significa que ya existe almenos un dato en el arbol
            {
                Nodo anterior = null, recorrido;
                recorrido = raiz;
                while (recorrido != null) //Nos permite localizar el ultimo nodo donde se va almacenar el dato ingresado
                {
                    anterior = recorrido;
                    if (info < recorrido.info)
                    {
                        Concatenador = Convert.ToString(recorrido.info) + "<-"; ;//Guarda la direccion
                        recorrido = recorrido.izq;
                    }
                    else
                    {
                        Concatenador = Convert.ToString(recorrido.info) + "<-";//Guarda la direccion
                        recorrido = recorrido.der;
                    }
                    contador++;
                }
                //Se ingresa el dato dependiendo si es menor o mayor al ultimo dato
                if (info < anterior.info)
                    anterior.izq = nuevo;
                else
                    anterior.der = nuevo;
                dato.posicionaltura = contador; //Se guarda el nivel que se encuentra el dato
                Concatenador = Concatenador + Convert.ToString(info); //Se guarda la direccion
                dato.lugar = Concatenador; //Se guarda la direccion
                weita.Add(dato); //Se guarda el objeto dato, en la lista weita
            }
        }
        private void ImprimirPre(Nodo recorrido) //Metodo recursivo que imprime los datos en PreOrden
        {
            List<string> Fragmentos = new List<string>();
            for (int i = 0; i < Partes.Length; i++)
            {
                Fragmentos.Add(Partes[i]);//SE AÑADE CADA PALABRA A LA LISTA
            }
            if (recorrido != null)
            {

                Console.Write(Fragmentos[recorrido.info] + " ");
                ImprimirPre(recorrido.izq);
                ImprimirPre(recorrido.der);
            }
        }
        public void ImprimirPre() //Metodo recursivo que imprime los datos en PreOrden
        {
            ImprimirPre(raiz);
            Console.WriteLine();
        }
        private void ImprimirEntre(Nodo recorrido) //Metodo recursivo que imprime los datos en InOrden
        {
            List<string> Fragmentos = new List<string>();
            for (int i = 0; i < Partes.Length; i++)
            {
                Fragmentos.Add(Partes[i]);//SE AÑADE CADA PALABRA A LA LISTA
            }
            Fragmentos = Fragmentos.OrderBy(o => o).ToList();
            if (recorrido != null)
            {
                ImprimirEntre(recorrido.izq);
                Console.Write(Fragmentos[recorrido.info] + " ");
                ImprimirEntre(recorrido.der);
            }
        }

        public void ImprimirEntre()//Metodo recursivo que imprime los datos en InOrden
        {
            ImprimirEntre(raiz);
            Console.WriteLine();
        }
        private void ImprimirPost(Nodo recorrido) //Metodo recursivo que imprime los datos en PostOrden
        {
            List<string> Fragmentos = new List<string>();
            for (int i = 0; i < Partes.Length; i++)
            {
                Fragmentos.Add(Partes[i]);//SE AÑADE CADA PALABRA A LA LISTA
            }
            Fragmentos = Fragmentos.OrderBy(o => o).ToList();

            if (recorrido != null)
            {
                ImprimirPost(recorrido.izq);
                ImprimirPost(recorrido.der);
                Console.Write(Fragmentos[recorrido.info] + " ");
            }
        }
        public void ImprimirPost() //Metodo recursivo que imprime los datos en PostOrden
        {
            ImprimirPost(raiz);
            Console.WriteLine();
        }
    }
}
