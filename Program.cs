using System;
using System.Collections.Generic;

namespace ProyectoAuditorio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Usamos Queue para respetar el orden de llegada (FIFO)
            Queue<Asistente> auditorio = new Queue<Asistente>();

            // Simulando el ingreso de los asistentes solicitados
            auditorio.Enqueue(new Asistente { Nombre = "Karolina", ID = 1 });
            auditorio.Enqueue(new Asistente { Nombre = "Mateo", ID = 2 });

            // Uso de la clase Tools para cumplir con la reportería
            Tools.ImprimirCola(auditorio);

            // Análisis: La estructura Queue utiliza el principio FIFO. 
            // El tiempo de ejecución para Enqueue y Dequeue es O(1), 
            // siendo eficiente para gestionar los asientos.

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
