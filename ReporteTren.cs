using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G6_GestionMetroLinea1_T2
{
    internal class ReporteTren
    {
        private NodoTren p; 
        public ReporteTren()
        {
            Random rand = new Random();
            string[] detallesInactivos = { "Mantenimiento programado      ", "Avería en el sistema eléctrico", "Fallo en los frenos           "};

            int trenesInactivosCount = 0;
            NodoTren ant = null;

            for (int i = 101; i <= 115; i++)
            {
                bool activo;
                string detalles = "";

                if (trenesInactivosCount < 3 && rand.Next(0, 2) == 0) 
                {
                    activo = false;
                    detalles = detallesInactivos[rand.Next(detallesInactivos.Length)];
                    trenesInactivosCount++;
                }
                else
                {
                    activo = true;
                }

                NodoTren nuevoTren = new NodoTren(i, activo, detalles);

                if (p == null)
                {
                    p = nuevoTren;
                }
                else
                {
                    ant.sgte = nuevoTren;
                }

                ant = nuevoTren;
            }

            
            NodoTren actual = p;
            while (trenesInactivosCount < 3)
            {
                if (actual.estado)
                {
                    actual.estado = false;
                    actual.detalle = detallesInactivos[rand.Next(detallesInactivos.Length)];
                    trenesInactivosCount++;
                }
                actual = actual.sgte;
            }
        }
        public void buscarId(int Id)
        {
            NodoTren actual = p;
            bool encontrado = false;
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("|   ID\t\t Estado \t\t   Detalle                 |");
            Console.WriteLine("--------------------------------------------------------------------");

            while (actual != null)
            {
                if (actual.id == Id)
                {
                    encontrado = true;
                    Console.Write($"|  {actual.id}\t\t");
                    if (actual.estado)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write(" Activo ");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("                      -                    |");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Inactivo");
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine($"\t {actual.detalle}    |");
                    }

                    break;
                }
                actual = actual.sgte;
            }
            if (!encontrado)
                Console.WriteLine("Tren no encontrado...");
            Console.WriteLine("--------------------------------------------------------------------");
        }
        public void mostrarTodos()
        {
            NodoTren actual = p;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("----------------------------");
            Console.WriteLine("|   ID\t\t Estado    |");
            Console.WriteLine("----------------------------");
            while (actual != null)
            {
                Console.Write($"|  {actual.id}\t\t");
                if (actual.estado)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(" Activo ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Inactivo");
                }
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("   |");
                actual = actual.sgte;
            }
            Console.WriteLine("----------------------------");
        }
        public void mostrarActivos()
        {
            NodoTren actual = p;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\nTrenes Activos: ");
            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine("|   ID\t\t Estado    |");
            Console.WriteLine("----------------------------");
            while (actual != null)
            {
                if (actual.estado)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write($"|  {actual.id}\t\t");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(" Activo ");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("   |");
                }
                actual = actual.sgte;
            }
            Console.WriteLine("----------------------------");
        }
        public void mostrarInactivos()
        {
            NodoTren actual = p;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\nTrenes Inactivos: ");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("|  ID\t\t Estado \t\t  Detalle               |");
            Console.WriteLine("-----------------------------------------------------------------");
            while (actual != null)
            {
                if (!actual.estado)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write($"|  {actual.id}\t\t");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Inactivo");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine($"\t{actual.detalle}  |");
                }
                actual = actual.sgte;
            }
            Console.WriteLine("-----------------------------------------------------------------");
        }
    }
}
