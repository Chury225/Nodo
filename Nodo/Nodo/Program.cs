
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grafo_matriz
{
    class Program
    {

        public static void menu()
        {
            Console.WriteLine("*****************************************************");
            Console.WriteLine("1.- Agregar un Arco ");
            Console.WriteLine("2.- Mostrar Matriz del grafo ");
            Console.WriteLine("3.- Busqueda Directa");
            Console.WriteLine("4.- Busqueda Secuencial");
            Console.WriteLine("5.- Mostrar Grafo");
            Console.WriteLine("*****************************************************");


        }

        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;

            string linea;


            try
            {
                int tamaño;
                Console.WriteLine("Primero debes Agregar un GRAFO \nRecuerda Utilizar SOLO NUMEROS ENTEROS");

                do
                {

                    Console.WriteLine("El Numero de NODOS debe ser MAYOR a 1");
                    Console.WriteLine();
                    Console.Write("Ingresa el Numero de NODOS del Grafo: ");



                    linea = Console.ReadLine();
                    tamaño = int.Parse(linea);
                    Console.Clear();
                } while (tamaño <= 1);

                Console.Clear();
                Console.WriteLine("¡Grafo Agregado!");
                Console.WriteLine("Cada Nodo fue Nombrado con la Sucesion de 1 a " + tamaño);
                Console.WriteLine();

                int[,] matrix = new int[tamaño, tamaño];



                string op;
                do
                {
                    menu();
                    op = Console.ReadLine();

                    switch (op)
                    {

                        case "1": //////////////////////////////////////////////////////
                            Console.Clear();
                            Console.WriteLine("Usted Selecciono: Agregar un Arco");
                            Console.WriteLine();
                            for (int i = 0; i < 1; i++)
                            {
                                for (int j = 0; j < 1; j++)
                                {
                                    Console.Write("Nodo de Inicio: ");
                                    linea = Console.ReadLine();
                                    int fila = int.Parse(linea);

                                    Console.Write("Nodo de Destino: ");
                                    linea = Console.ReadLine();
                                    int columna = int.Parse(linea);

                                    Console.Write("Valor del Arco: ");
                                    linea = Console.ReadLine();
                                    int valor = int.Parse(linea);

                                    if (fila <= tamaño && columna <= tamaño)
                                    {
                                        if (valor > 0)
                                        {
                                            matrix[fila - 1, columna - 1] = valor;
                                            Console.WriteLine();
                                            Console.WriteLine("¡Arco Agregado! ");
                                            Console.WriteLine();
                                            Console.WriteLine(" (" + fila + ") -- " + valor + " --> (" + columna + ")");
                                            Console.WriteLine();

                                        }
                                        else
                                        {

                                            Console.WriteLine();
                                            Console.WriteLine("¡ARCO NO AGREGADO! ");
                                            Console.WriteLine("El Valor de la Arco debe ser Mayor a Cero ");
                                            Console.WriteLine();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("¡ARCO NO AGREGADO! ");
                                        Console.WriteLine("Algunos de los NODOS no Existen ");
                                        Console.WriteLine();
                                    }


                                }
                            }
                            break;


                        case "2"://////////////////////////////////////////////////////////////////
                            Console.Clear();
                            Console.WriteLine("Se muestra la Matriz del Grafo: ");
                            Console.WriteLine();
                            for (int i = 0; i < tamaño; i++)
                            {
                                for (int j = 0; j < tamaño; j++)
                                {
                                    Console.Write(matrix[i, j] + " ");
                                }
                                Console.WriteLine();
                            }
                            Console.ReadLine();
                            break;
                        case "3":
                            Console.Clear();
                            Console.WriteLine("Usted Selecciono Busqueda Directa");
                            Console.WriteLine();
                            Console.Write("Nodo Origen: ");
                            linea = Console.ReadLine();
                            int fil = int.Parse(linea);
                            Console.Write("Nodo de Destino: ");
                            linea = Console.ReadLine();
                            int col = int.Parse(linea);
                            if (col <= tamaño && fil <= tamaño)
                            {
                                Console.WriteLine();
                                Console.WriteLine("El Valor es: " + matrix[fil - 1, col - 1]);
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("ERROR DE BUSQUEDA");
                                Console.WriteLine("Los Nodos que intruduiste No Exisen");

                                Console.WriteLine();
                            }

                            break;
                        case "4":
                            Console.Clear();
                            Console.WriteLine("Usted Selecciono Busqueda Secuencial");
                            Console.WriteLine();
                            Console.Write("Ingresa dato a Buscar: ");
                            linea = Console.ReadLine();
                            int dato = int.Parse(linea);

                            bool bandera = false;
                            for (int i = 0; i < tamaño; i++)
                            {
                                for (int j = 0; j < tamaño; j++)
                                {
                                    if (matrix[i, j] == dato)
                                    {
                                        bandera = true;
                                        int a = i + 1;
                                        int b = j + 1;
                                        Console.WriteLine("La Ubicacion es; " + a + " --> " + b);


                                    }



                                }

                            }
                            if (bandera == false)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Este dato no Existe");
                            }
                            Console.WriteLine();


                            break;
                        case "5":
                            for (int i = 0; i < tamaño; i++)
                            {
                                for (int j = 0; j < tamaño; j++)
                                {
                                    if (matrix[i, j] > 0)
                                    {
                                        Console.WriteLine(" (" + (i + 1) + ") -- " + matrix[i, j] + " --> (" + (j + 1) + ")");
                                    }
                                }

                            }


                            break;


                    }
                } while (op != "0");

            }
            catch (FormatException)
            {
                Console.WriteLine("¡Ingresa Solo NUMEROS ENTEROS!");
                Console.WriteLine("Presiona Una TECLA para salir");
                Console.ReadKey();
            }
        }
    }
}