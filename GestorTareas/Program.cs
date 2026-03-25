using System;

namespace GestorTareasArray
{
    class Program
    {
        private static int opcion;

        static void Main(string[] args)
        {
            Console.WriteLine("Gestor de Tareas Pendientes (con Arrays)");
            Console.WriteLine("----------------------------------------");

            // Array para almacenar hasta 5 tareas
            string[] tareas = new string[5];
            int contadorTareas = 0;

            while (true)

            {
                Console.WriteLine("\nOpciones:");
                Console.WriteLine("1. Añadir tarea");
                Console.WriteLine("2. Mostrar tareas");
                Console.WriteLine("3. Salir");
                Console.Write("Selecciona una opción: ");

                string opcion = Console.ReadLine() ??"";

                if (opcion == "1")
                {
                    Console.Write("Introduce la tarea: ");
                    tareas[contadorTareas] = Console.ReadLine();
                    contadorTareas++;
                    Console.WriteLine("Tarea añadida.");
                }

                else if (opcion == "2")
                {
                    Console.WriteLine("\nTareas pendientes:");
                    for (int i = 0; i < contadorTareas; i++)
                    {
                        Console.WriteLine($"{i + 1}. {tareas[i]}");
                    }
                    if (contadorTareas == 0)
                    {
                        Console.WriteLine("No hay tareas registradas.");
                    }
                }
                else if (opcion == "3")
                {
                    Console.WriteLine("Saliendo del programa...");
                    break;
                }
                else
                {
                    Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                }
            }while (opcion != 4) ;
            Console.WriteLine("Registro implementado");
        }
    }
}