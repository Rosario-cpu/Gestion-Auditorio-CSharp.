using System;
using System.Collections.Generic;

namespace ProyectoAuditorio
{
    public static class Tools
    {
        public static void ImprimirCola(Queue<Asistente> cola)
        {
            Console.WriteLine("\n--- Lista de asistentes en espera ---");
            foreach (var a in cola)
            {
                Console.WriteLine($"ID: {a.ID} | Nombre: {a.Nombre}");
            }
        }
    }
}
