using static ClasesyArreglos.CrearDesayuno;

class Program
{
    static void Main()
    {
        GestorDesayunos gestor = new GestorDesayunos();
        string opcion;

        do
        {
            Console.WriteLine("Menú de Desayunos: \n");
            Console.WriteLine("a) Crear desayuno\n");
            Console.WriteLine("b) Listar desayunos\n");
            Console.WriteLine("c) Eliminar desayuno\n");
            Console.WriteLine("d) Salir\n");
            Console.Write("Selecciona una opción: \n");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "a":
                    Console.Write("\nIntroduce el nombre del desayuno: \n");
                    string nombre = Console.ReadLine();
                    Console.Write("\nIntroduce el precio del desayuno: \n");
                    string precio = Console.ReadLine();
                    Console.Write("\nIntroduce los días (separados por comas): \n");
                    string dias = Console.ReadLine();
                    gestor.CrearDesayuno(nombre, precio, dias);
                    break;
                case "b":
                    gestor.ListarDesayunos();
                    break;
                case "c":
                    Console.Write("\nIntroduce el nombre del desayuno a eliminar: \n");
                    string nombreAEliminar = Console.ReadLine();
                    gestor.EliminarDesayuno(nombreAEliminar);
                    break;
                case "d":
                    Console.WriteLine("\nFin del programa.\n");
                    break;
                default:
                    Console.WriteLine("\nOpción no válida. Inténtalo de nuevo.\n");
                    break;
            }

            Console.WriteLine("Hola mundo");
        } while (opcion != "d");
    }
}