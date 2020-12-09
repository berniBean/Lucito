using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio_7Join
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Modalidad> listModalidad = new List<Modalidad>
            {
                new Modalidad {idModalidad = 1, nombreModalidad = "CAS"},
                new Modalidad {idModalidad = 2, nombreModalidad = "TEMPORAL"},
            };

            List<Empleado> listaEmpleado = new List<Empleado>
            {
                new Empleado {idEmpleado=1, nombre = "Ernesto", idModalidad = 1},
                new Empleado {idEmpleado = 2, nombre = "Alicia", idModalidad = 2},
                new Empleado {idEmpleado = 3, nombre = "Erazmo", idModalidad = 1},
                new Empleado {idEmpleado = 4, nombre = "Julio", idModalidad = 2},
                new Empleado {idEmpleado = 4, nombre = "Cesar", idModalidad = 2},
                new Empleado {idEmpleado = 4, nombre = "Gato", idModalidad = 2},
                new Empleado {idEmpleado = 4, nombre = "Julio", idModalidad = 1}
            };

            var consulta = (from modalidad in listModalidad
                           join empleado in listaEmpleado
                           on modalidad.idModalidad equals empleado.idModalidad
                           select new { nombreEmpleado = empleado.nombre, nombreModalidad = modalidad.nombreModalidad }).ToList();

            foreach (var item in consulta)
            {
                Console.WriteLine(item.nombreEmpleado + " es " + item.nombreModalidad);
            }
        }
    }
}
