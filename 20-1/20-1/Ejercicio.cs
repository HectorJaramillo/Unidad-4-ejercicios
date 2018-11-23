using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_1
{
    public class Ejercicio//Clase para agregar de manera manual todos los datos(fue horrible capturar todo esto)
    {
        public void E1()
        {
            List<Nodo> A1 = new List<Nodo>();//Listas de datos capturados segun sea el caso
            List<Nodo> A2 = new List<Nodo>();
            List<Nodo> A3 = new List<Nodo>();
            List<Nodo> A4 = new List<Nodo>();
            List<Nodo> A5 = new List<Nodo>();
            List<Nodo> A6 = new List<Nodo>();
            Nodo Raiz = new Nodo("1", "A");
            Nodo H2 = new Nodo("2", "C");
            Nodo H3 = new Nodo("3", "A");
            Nodo H4 = new Nodo("4", "C");
            Nodo H5 = new Nodo("5", "A");
            Nodo H6 = new Nodo("6", "C");
            Nodo H7 = new Nodo("7", "A");
            Nodo H8 = new Nodo("8", "C");
            Nodo H9 = new Nodo("9", "A");
            Nodo H10 = new Nodo("10", "C");
            Nodo H11 = new Nodo("11", "A");
            Nodo H12 = new Nodo("12", "C");
            Nodo H13 = new Nodo("13", "A");
            Nodo H14 = new Nodo("14", "C");
            Nodo H15 = new Nodo("15", "A");
            Nodo H16 = new Nodo("16", "C");
            Nodo H17 = new Nodo("17", "A");
            Nodo H18 = new Nodo("18", "C");
            Nodo H19 = new Nodo("19", "A");
            Nodo H20 = new Nodo("20", "C");
            Nodo H21 = new Nodo("21", "A");
            Nodo H22 = new Nodo("22", "C");
            Nodo H23 = new Nodo("23", "A");
            Nodo H24 = new Nodo("24", "C");
            Nodo H25 = new Nodo("25", "A");
            A6.Add(Raiz);
            A6.Add(H2);
            A6.Add(H3);
            A6.Add(H4);
            A6.Add(H5);
            A6.Add(H6);
            A6.Add(H7);
            A6.Add(H8);
            A6.Add(H9);
            A6.Add(H10);
            A6.Add(H11);
            A6.Add(H12);
            A6.Add(H13);
            A6.Add(H14);
            A6.Add(H15);
            A6.Add(H16);
            A6.Add(H17);
            A6.Add(H18);
            A6.Add(H19);
            A6.Add(H20);
            A6.Add(H21);
            A6.Add(H22);
            A6.Add(H23);
            A6.Add(H24);
            A6.Add(H25);
            A5.Add(Raiz);
            H3.Lata = "C";
            A5.Add(H3);
            A5.Add(H5);
            H7.Lata = "C";
            A5.Add(H7);
            A5.Add(H9);
            H11.Lata = "C";
            A5.Add(H11);
            A5.Add(H13);
            H15.Lata = "C";
            A5.Add(H15);
            A5.Add(H17);
            H19.Lata = "C";
            A5.Add(H19);
            A5.Add(H21);
            H23.Lata = "C";
            A5.Add(H23);
            A5.Add(H25);
            A4.Add(Raiz);
            A4.Add(H5);
            A4.Add(H9);
            A4.Add(H13);
            A4.Add(H17);
            A4.Add(H21);
            A4.Add(H25);
            A3.Add(Raiz);
            A3.Add(H9);
            A3.Add(H17);
            A3.Add(H25);
            A2.Add(Raiz);
            A2.Add(H17);
            A1.Add(Raiz);

        }
        public void Ejercicio1()
        {
            int Niveles = 0;

            List<Nodo> A1 = new List<Nodo>();
            List<Nodo> A2 = new List<Nodo>();
            List<Nodo> A3 = new List<Nodo>();
            List<Nodo> A4 = new List<Nodo>();
            List<Nodo> A5 = new List<Nodo>();
            List<Nodo> A6 = new List<Nodo>();
            Arbol Arbolin = new Arbol();
            Console.WriteLine("Introduzca el nodo raiz");
            string Base = Console.ReadLine();
            Nodo NodoBase = new Nodo(Base);
            A1.Add(NodoBase);
            Back1:
            Console.WriteLine("\nDesea seguir agregando nodos SI/NO)?");
            string Verificar = Console.ReadLine().ToUpper();
            if (Verificar == "SI")
            {
                Niveles++;
                foreach (var item in A1)
                {
                    Console.Write("\nIntroduzca el nodo de izquierda de {0}: ", item.Name);
                    item.Izquierda = Console.ReadLine();
                    if (item.Izquierda == "0")
                    {
                        goto Derecha;
                    }
                    else
                    {
                        Nodo Izquierda = new Nodo(item.Izquierda);
                        A2.Add(Izquierda);
                    }
                    Derecha:
                    Console.Write("Introduzca el nodo de derecha de {0}: ", item.Name);
                    item.Derecha = Console.ReadLine();
                    if (item.Derecha == "0")
                    {
                        goto Next1;
                    }
                    else
                    {
                        Nodo Derecha = new Nodo(item.Derecha);
                        A2.Add(Derecha);
                    }
                }
            }
            else if (Verificar == "NO")
            {
                goto Next5;
            }
            else
            {
                goto Back1;
            }


            Next1:
            Back2:
            Console.WriteLine("\nDesea seguir agregando nodos (SI/NO)?");
            string Verificar2 = Console.ReadLine().ToUpper();
            if (Verificar2 == "SI")
            {
                Niveles++;
                foreach (Nodo item in A2)
                {
                    Console.Write("\nIntroduzca el nodo de izquierda de {0}: ", item.Name);
                    item.Izquierda = Console.ReadLine();
                    if (item.Izquierda == "0")
                    {
                        goto Derecha;
                    }
                    else
                    {
                        Nodo Izquierda = new Nodo(item.Izquierda);
                        A3.Add(Izquierda);
                    }
                    Derecha:
                    Console.Write("Introduzca el nodo de derecha de {0}: ", item.Name);
                    item.Derecha = Console.ReadLine();
                    if (item.Derecha == "0")
                    {
                        goto Next2;
                    }
                    else
                    {
                        Nodo Derecha = new Nodo(item.Derecha);
                        A3.Add(Derecha);
                    }
                }
            }
            else if (Verificar2 == "NO")
            {
                goto Next5;
            }
            else
            {
                goto Back2;
            }

            Next2:
            Back3:
            Console.WriteLine("\nDesea seguir agregando nodos (SI/NO)?");
            string Verificar3 = Console.ReadLine().ToUpper();
            if (Verificar3 == "SI")
            {
                Niveles++;
                foreach (var item in A3)
                {
                    Console.Write("\nIntroduzca el nodo de izquierda de {0}: ", item.Name);
                    item.Izquierda = Console.ReadLine();
                    if (item.Izquierda == "0")
                    {
                        goto Derecha;
                    }
                    else
                    {
                        Nodo Izquierda = new Nodo(item.Izquierda);
                        A4.Add(Izquierda);
                    }
                    Derecha:
                    Console.Write("Introduzca el nodo de derecha de {0}: ", item.Name);
                    item.Derecha = Console.ReadLine();
                    if (item.Derecha == "0")
                    {
                        goto Next3;
                    }
                    else
                    {
                        Nodo Derecha = new Nodo(item.Derecha);
                        A4.Add(Derecha);
                    }
                }
            }
            else if (Verificar3 == "NO")
            {
                goto Next5;
            }

            else
            {
                goto Back3;
            }

            Next3:
            Back4:
            Console.WriteLine("\nDesea seguir agregando nodos (SI/NO)?");
            string Verificar4 = Console.ReadLine().ToUpper();
            if (Verificar4 == "SI")
            {
                Niveles++;
                foreach (var item in A4)
                {
                    Console.Write("\nIntroduzca el nodo de izquierda de {0}: ", item.Name);
                    item.Izquierda = Console.ReadLine();
                    if (item.Izquierda == "0")
                    {
                        goto Derecha;
                    }
                    else
                    {
                        Nodo Izquierda = new Nodo(item.Izquierda);
                        A5.Add(Izquierda);
                    }
                    Derecha:
                    Console.Write("Introduzca el nodo de derecha de {0}: ", item.Name);
                    item.Derecha = Console.ReadLine();
                    if (item.Derecha == "0")
                    {
                        goto Next4;
                    }
                    else
                    {
                        Nodo Derecha = new Nodo(item.Derecha);
                        A5.Add(Derecha);
                    }
                }
            }
            else if (Verificar4 == "NO")
            {
                goto Next5;
            }

            else
            {
                goto Back4;
            }
            Next4:
            Back5:
            Console.WriteLine("\nDesea seguir agregando nodos (SI/NO)?");
            string Verificar5 = Console.ReadLine().ToUpper();//Captura de opcion
            if (Verificar5 == "SI")
            {
                Niveles++;
                foreach (var item in A5)
                {
                    Console.Write("\nIntroduzca el nodo de izquierda:  de {0}: ", item.Name);
                    item.Izquierda = Console.ReadLine();
                    if (item.Izquierda == "0")
                    {
                        goto Derecha;
                    }
                    else
                    {
                        Nodo Izquierda = new Nodo(item.Izquierda);
                        A6.Add(Izquierda);
                    }
                    Derecha:
                    Console.Write("Introduzca el nodo de derecha:  de {0}: ", item.Name);
                    item.Derecha = Console.ReadLine();
                    if (item.Derecha == "0")
                    {
                        goto Next5;
                    }
                    else
                    {
                        Nodo Derecha = new Nodo(item.Derecha);
                        A6.Add(Derecha);
                    }
                }
            }
            else if (Verificar5 == "NO")
            {
                goto Next5;
            }

            else
            {
                goto Back5;
            }
            Next5:
            Console.WriteLine("Presione para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.SetCursorPosition(65, 0);
            foreach (var item in A1)//Se imprimira el arbol de forma que parezcan niveles
            {//Para eso son los set cursor position
                Console.WriteLine(item.Name);
            }
            Console.SetCursorPosition(37, 1);
            foreach (var item in A2)
            {
                Console.Write(item.Name + "                                                             ");
            }
            Console.SetCursorPosition(21, 2);
            foreach (var item in A3)
            {
                Console.Write(item.Name + "                               ");
            }
            Console.SetCursorPosition(13, 3);
            foreach (var item in A4)
            {
                Console.Write(item.Name + "               ");
            }
            Console.SetCursorPosition(9, 4);
            foreach (var item in A5)
            {
                Console.Write(item.Name + "       ");
            }
            Console.SetCursorPosition(7, 5);
            foreach (var item in A6)
            {
                Console.Write(item.Name + "   ");
            }
            int NumeroSets = (A6.Count / 2) * 3 + (A5.Count / 2) * 3 + (A4.Count / 2) * 3 + (A3.Count / 2) * 3 + (A2.Count / 2) * 3;//Formula para calcular el numero de sets
            Console.WriteLine("\n\n\n\n\nEl numero de partidos que jugo el campeon fueron: {0}", Niveles);//altura-1
            Console.WriteLine("El numero de sets que se jugaron en el torneo fueron de: {0}", NumeroSets);//Cantidad de set jugados en el torneo
            Console.ReadKey();
        }
    }
}
