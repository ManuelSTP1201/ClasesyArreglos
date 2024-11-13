using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClasesyArreglos
{
    public class CrearDesayuno
    {
        public class GestorDesayunos
        {
            private List<Desayuno> desayunos;

            public GestorDesayunos()
            {
                desayunos = new List<Desayuno>();
            }

            public void CrearDesayuno(string nombre, string precio, string dias)
            {
                Desayuno nuevoDesayuno = new Desayuno
                {
                    Nombre = nombre,
                    Precio = precio,
                    Dias = dias
                };
                desayunos.Add(nuevoDesayuno);
                Console.WriteLine("Desayuno añadido.\n");
            }

            public void ListarDesayunos()
            {
                Console.WriteLine($"Se sirven {desayunos.Count} desayunos:");
                foreach (var desayuno in desayunos)
                {
                    Console.WriteLine(desayuno);
                }
                Console.WriteLine();
            }

            public void EliminarDesayuno(string nombre)
            {
                Desayuno desayunoAEliminar = desayunos.FirstOrDefault(d => d.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
                if (desayunoAEliminar != null)
                {
                    desayunos.Remove(desayunoAEliminar);
                    Console.WriteLine("Desayuno eliminado.\n");
                }
                else
                {
                    Console.WriteLine("Desayuno no encontrado.\n");
                }
            }
        }
    }
}
