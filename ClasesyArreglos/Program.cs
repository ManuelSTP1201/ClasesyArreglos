using static ClasesyArreglos.CrearDesayuno;

class Program
{
    static void Main()
    {
        GestorDesayunos gestor = new GestorDesayunos();
        string opcion;

        do
        {
            Console.WriteLine("Menú de Desayunos:");
            Console.WriteLine("a) Crear desayuno");
            Console.WriteLine("b) Listar desayunos");
            Console.WriteLine("c) Eliminar desayuno");
            Console.WriteLine("d) Salir");
            Console.Write("Selecciona una opción: ");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "a":
                    Console.Write("Introduce el nombre del desayuno: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Introduce el precio del desayuno: ");
                    string precio = Console.ReadLine();
                    Console.Write("Introduce los días (separados por comas): ");
                    string dias = Console.ReadLine();
                    gestor.CrearDesayuno(nombre, precio, dias);
                    break;
                case "b":
                    gestor.ListarDesayunos();
                    break;
                case "c":
                    Console.Write("Introduce el nombre del desayuno a eliminar: ");
                    string nombreAEliminar = Console.ReadLine();
                    gestor.EliminarDesayuno(nombreAEliminar);
                    break;
                case "d":
                    Console.WriteLine("Fin del programa.");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                    break;
            }
        } while (opcion != "d");
    }
}