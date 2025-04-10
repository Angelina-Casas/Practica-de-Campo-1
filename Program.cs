using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace G6_GestionMetroLinea1_T2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\t\t\t██╗     ██████╗ ███╗   ██╗ ███████╗  █████╗     ████╗           ██████╗  ");
            Console.WriteLine("\t\t\t██║     ╚═██ ╔╝ ████╗  ██║ ██╔════╝ ██╔═╗██║   ██ ██║          ██╔════╝  ");
            Console.WriteLine("\t\t\t██║       ██ ║  ██╔██╗ ██║ █████╗   ███████║      ██║    ████╗           ");
            Console.WriteLine("\t\t\t██║       ██ ║  ██║╚██╗██║ ██╔══╝   ██╔═╗██║      ██║   ██████║          ");
            Console.WriteLine("\t\t\t██████╗ ██████╗ ██║ ╚████║ ███████╗ ██║ ║██║      ██║   ╚═════╝          ");
            Console.WriteLine("\t\t\t╚═════╝ ╚═════╝ ╚═╝  ╚═══╝ ╚══════╝ ╚═╝ ╚══╝      ╚═╝  (o)   (o)         ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t\tBienvenidos pasajeros a la linea 1 de Lima");
            
            // Imprimir la barra de carga
            Console.WriteLine("\n");
            Console.Write("   \t\t\t   Cargando: ");
            Console.Write("\t");
            for (int i = 0; i < 20; i++)
            {

                Console.Write("██");
                Thread.Sleep(300);

            }
            Console.Write("\t\n");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\tPresione para continuar");
            Console.ReadKey();
            Console.ResetColor();

            int opc;
            do
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Clear();

                Console.WriteLine("======================================");
                Console.WriteLine("        Bienvenido a la Línea 1     ");
                Console.WriteLine("             Metro de Lima      ");
                Console.WriteLine("======================================");

                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine();

                Console.WriteLine("[1] Registro de Estaciones");
                Console.WriteLine("[2] Registro de Trenes");
                Console.WriteLine("[3] Registro de Tarjetas");
                Console.WriteLine("[4] Registro de Recargas");
                Console.WriteLine("[5] Registro de Colas de Pasajeros");
                Console.WriteLine("[6] Registro de Empleados");
                Console.WriteLine("[7] Apertura y Cierre de Estaciones");
                Console.WriteLine("[8] Salir");
                Console.Write("\nIngresar Opción: ");
                if (!int.TryParse(Console.ReadLine(), out opc))
                {
                    Console.WriteLine("Opción inválida, inténtalo otra vez.");
                    continue;
                }

                switch (opc)
                {
                    case 1:
                        RegistroEstaciones();
                        break;
                    case 2:
                        RegistroTrenes();
                        break;
                    case 3:
                        RegistroTarjeta();
                        break;
                    case 4:
                        break;
                    case 5:
                        RegistroColas();
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        Console.WriteLine("Saliendo del sistema...");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Gracias por su preferencia");
                        break;
                    default:
                        Console.WriteLine("Opción inválida, inténtalo otra vez.");
                        break;
                }
                Console.ReadKey();
            } while (opc != 9);
        }
        static void RegistroTarjeta()
        {
            Tarjeta();
            void Tarjeta()
            {
                Console.Title = "Sistema de Gestión de Tarjetas";
                ReporteTarjeta listaTarjetas = new ReporteTarjeta();
                while (true)
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Clear();
                    Console.WriteLine("=========================================");
                    Console.WriteLine("           REGISTRO DE TARJETAS        ");
                    Console.WriteLine("=========================================");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("\n 1. Registrar nueva tarjeta      ");
                    Console.WriteLine(" 2. Eliminar Tarjeta             ");
                    Console.WriteLine(" 3. Ver Tarjetas Registradas     ");
                    Console.WriteLine(" 4. Salir                        ");
                    Console.WriteLine();
                    Console.Write("Ingrese su opción: ");
                    int opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            RegistrarTarjeta(listaTarjetas);
                            break;
                        case 2:
                            EliminarTarjeta(listaTarjetas);
                            break;
                        case 3:
                            listaTarjetas.RecorrerTarjetas();
                            break;
                        case 4:
                            Console.WriteLine("Saliendo del programa...");
                            return;
                        default:
                            Console.WriteLine("Opción inválida. Por favor, ingrese una opción válida.");
                            break;
                    }
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }
            void RegistrarTarjeta(ReporteTarjeta listaTarjetas)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("=============================================================");
                Console.WriteLine("                     REGISTRO DE TARJETA        ");
                Console.WriteLine("=============================================================");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("\nIngrese el DNI del propietario: ");
                string dni = Console.ReadLine();
                Console.Write("Ingrese el nombre del propietario: ");
                string nombrePropietario = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nEL COSTO DEL REGISTRO DE LA TARJETA ES DE S/. 5");
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("==================================================");
                Console.WriteLine("\nSeleccione el tipo de tarjeta: ");
                Console.WriteLine(" 1. Universitario     ");
                Console.WriteLine(" 2. Escolar           ");
                Console.WriteLine(" 3. Normal            ");
                int tipo = int.Parse(Console.ReadLine());
                string tipoTarjeta;
                switch (tipo)
                {
                    case 1:

                        tipoTarjeta = "Universitario";
                        break;
                    case 2:
                        tipoTarjeta = "Escolar";
                        break;
                    case 3:
                        tipoTarjeta = "Normal";
                        break;
                    default:
                        Console.WriteLine("Tipo de tarjeta inválido.");
                        return;
                }
                Console.Write("Ingrese el saldo inicial con el que desea recargar la tarjeta: ");
                decimal saldoInicial = decimal.Parse(Console.ReadLine());
                if (saldoInicial < 5.00m)
                {
                    Console.WriteLine("El saldo inicial debe ser mayor o igual a 5 soles.");
                    Console.WriteLine("Regresando al menú principal...");
                    return;
                }
                listaTarjetas.Insertar(dni, nombrePropietario, saldoInicial, tipoTarjeta);
            }
            void EliminarTarjeta(ReporteTarjeta listaTarjetas)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.White;

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("=============================================");
                Console.WriteLine("               Eliminar tarjeta           ");
                Console.WriteLine("=============================================");

                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("Ingrese el DNI de la tarjeta a eliminar: ");
                string dni = Console.ReadLine();

                listaTarjetas.Eliminar(dni);
            }
        }

        static void RegistroTrenes()
        {
            ReporteTren trenes = new ReporteTren();
            bool continuar = true;
            while (continuar)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("====================================================================");
                Console.WriteLine("                    REGISTRO DE TRENES ");
                Console.WriteLine("====================================================================");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("1. Buscar tren por ID");
                Console.WriteLine("2. Mostrar todos los trenes activos");
                Console.WriteLine("3. Mostrar todos los trenes inactivos");
                Console.WriteLine("4. Mostrar todos los trenes y su estado");
                Console.WriteLine("5. Salir");
                Console.Write("\nSelecciona una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {

                    case "1":
                        Console.Write("\nIntroduce el ID del tren a buscar (101 - 115) : ");
                        int id = int.Parse(Console.ReadLine());
                        trenes.buscarId(id);
                        break;
                    case "2":
                        trenes.mostrarActivos();
                        break;
                    case "3":
                        trenes.mostrarInactivos();
                        break;
                    case "4":
                        trenes.mostrarTodos();
                        break;
                    case "5":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida... Intenta de nuevo.");
                        break;
                }
                if (continuar)
                {
                    Console.WriteLine("\nPresiona cualquier tecla para volver al menú...");
                    Console.ReadKey();
                }
            }
            Console.WriteLine("Saliendo...");
        }
        static ReporteEstacion reporteestacion = new ReporteEstacion();
        static void RegistroEstaciones()
        {
            int opc;
            do
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("====================================================================");
                Console.WriteLine("                   REGISTRO DE ESTACIONES               ");
                Console.WriteLine("====================================================================");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("1. Mostrar todas las estaciones");
                Console.WriteLine("2. Mostrar apertura y cierre de todas las estaciones");
                Console.WriteLine("3. Buscar información de cada estación");
                Console.WriteLine("4. Salir");
                Console.Write("\nIngresar Opción: ");
                if (!int.TryParse(Console.ReadLine(), out opc))
                {
                    Console.WriteLine("Opción inválida, inténtalo otra vez.");
                    continue;
                }
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("\n----------------------------------");
                        Console.WriteLine("|      Lista de estaciones       |");
                        Console.WriteLine("----------------------------------");
                        Console.ForegroundColor = ConsoleColor.Black;
                        reporteestacion.Imprimir();
                        Console.WriteLine("----------------------------------");
                        break;
                    case 2:
                        reporteestacion.ImprimirHr();
                        break;
                    case 3:
                        Console.Write("Ingrese el nombre de la estación a buscar: ");
                        string nombreBuscar = Console.ReadLine();
                        var infoEstacion = reporteestacion.Buscar(nombreBuscar);
                        if (infoEstacion != null)
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Write("\n");
                            Console.WriteLine("-------------------------------------------------------------------");
                            Console.WriteLine("|                         |              HORARIO                  |");
                            Console.WriteLine("|        ESTACION         -----------------------------------------");
                            Console.WriteLine("|                         |     APERTURA       |      CIERRE      |");
                            Console.WriteLine("-------------------------------------------------------------------");
                            Console.WriteLine($"|       {infoEstacion.nombre,-17} |       {infoEstacion.apertura,-10}   |       {infoEstacion.cierre,-10} |");
                            Console.WriteLine("-------------------------------------------------------------------");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Estación no encontrada.");
                        }
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;

                    case 4:
                        Console.WriteLine("Saliendo del registro de estaciones...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida, inténtalo otra vez.");
                        break;
                }
                Console.ReadKey();
            } while (opc != 4);
        }
        static void RegistroColas()
        {
            RegistroCola colaPasajeros = new RegistroCola();
            int opcion;
            do
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("===================================================");
                Console.WriteLine("                REGISTRO DE COLAS           ");
                Console.WriteLine("===================================================");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("1. Registrar pasajero en la cola");
                Console.WriteLine("2. Mostrar pasajeros en colas");
                Console.WriteLine("3. Eliminar pasajero de la cola");
                Console.WriteLine("4. Salir");
                Console.Write("\nSeleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine("\n---------------------------------------------------");

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el nombre del pasajero: ");
                        string nombre = Console.ReadLine();
                        colaPasajeros.RegistrarPasajero(nombre);
                        break;
                    case 2:
                        Console.WriteLine("     NOMBRE \t\t        DETALLE");
                        Console.WriteLine("---------------------------------------------------");
                        colaPasajeros.MostrarCola();
                        break;

                    case 3:
                        Console.Write("Ingrese el nombre del pasajero a eliminar: ");
                        string nombreEliminar = Console.ReadLine();
                        colaPasajeros.EliminarPasajero(nombreEliminar);
                        break;

                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
                Console.ReadKey();
            } while (opcion != 4);
        }
    }
}
