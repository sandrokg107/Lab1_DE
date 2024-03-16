using System;

class Program
{
    static void Main(string[] args)
    {
        Box box = new Box(); // Creamos una instancia de la clase Grifo

        // Ciclo para mostrar el menú hasta que el usuario decida salir
        bool salir = false;
        while (!salir)
        {
            // Mostrar el menú de opciones
            Console.WriteLine("\nMenú de opciones:");
            Console.WriteLine("1. Mostrar información de usuarios");
            Console.WriteLine("2. Agregar cliente");
            Console.WriteLine("3. Agregar empleado");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            // Leer la opción ingresada por el usuario
            string opcion = Console.ReadLine();

            // Ejecutar la opción seleccionada
            switch (opcion)
            {
                case "1":
                    Console.WriteLine("\nInformación de usuarios:");
                    box.MostrarUsuarios();
                    break;
                case "2":
                    Console.Write("\nIngrese el nombre del cliente: ");
                    string nombreCliente = Console.ReadLine();
                    Console.Write("Ingrese el saldo del cliente: ");
                    double saldoCliente = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese los litros cargados del cliente: ");
                    double litrosCargadosCliente = Convert.ToDouble(Console.ReadLine());
                    Cliente cliente = new Cliente(nombreCliente, saldoCliente, litrosCargadosCliente);
                    box.AgregarUsuario(cliente);
                    Console.WriteLine("Cliente agregado correctamente.\n");
                    break;
                case "3":
                    Console.Write("\nIngrese el nombre del empleado: ");
                    string nombreEmpleado = Console.ReadLine();
                    Console.Write("Ingrese el saldo del empleado: ");
                    double saldoEmpleado = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese el sueldo del empleado: ");
                    double sueldoEmpleado = Convert.ToDouble(Console.ReadLine());
                    Empleado empleado = new Empleado(nombreEmpleado, saldoEmpleado, sueldoEmpleado);
                    box.AgregarUsuario(empleado);
                    Console.WriteLine("Empleado agregado correctamente.\n");
                    break;
                case "4":
                    salir = true;
                    Console.WriteLine("\nSaliendo del programa...");
                    break;
                default:
                    Console.WriteLine("\nOpción no válida. Por favor, seleccione una opción válida.\n");
                    break;
            }
        }
    }
}