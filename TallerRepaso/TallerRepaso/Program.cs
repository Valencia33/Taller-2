using System;
using System.Collections.Generic;

namespace TallerRepaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> empleados = new List<Empleado>();

            empleados.Add(new EmpleadoTiempoCompleto(1, "Ana", 3000));
            empleados.Add(new EmpleadoHoras(2, "Luis", 120, 20));
            empleados.Add(new EmpleadoTiempoCompleto(3, "Carlos", 4500));
            empleados.Add(new EmpleadoHoras(4, "Sofía", 80, 25));

            Console.WriteLine("=== LISTA DE EMPLEADOS ===\n");

            foreach (Empleado e in empleados)
            {
                e.MostrarInformacion();
            }

            Console.ReadLine();
        }
    }
}