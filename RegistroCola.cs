using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G6_GestionMetroLinea1_T2
{
    internal class RegistroCola
    {
        private NodoPasajero frente;
        private NodoPasajero final;
        public RegistroCola()
        {
            frente = null;
            final = null;
        }
        public void RegistrarPasajero(string nombre)
        {
            Random rand = new Random();
            bool Prioridad = rand.Next(0, 2) == 1;
            string Detalle= "";

            if (Prioridad)
            {
                string[] detalles = { "Embarazada", "Tercera Edad", "Niño en brazo", "Discapacidad" };
                Detalle = detalles[rand.Next(detalles.Length)];
            }

            NodoPasajero nuevoPasajero = new NodoPasajero(nombre, Prioridad, Detalle);
            Console.WriteLine($"Pasajero {nombre} ha sido registrado en la cola.");

            if (frente == null)
            {
                frente = nuevoPasajero;
                final = nuevoPasajero;
            }
            else if (Prioridad)
            {
                NodoPasajero actual = frente;
                NodoPasajero ant = null;
                while (actual != null && actual.Prioridad)
                {
                    ant = actual;
                    actual = actual.sgte;
                }
                if (ant == null)
                {
                    nuevoPasajero.sgte = frente;
                    frente = nuevoPasajero;
                }
                else
                {
                    nuevoPasajero.sgte = ant.sgte;
                    ant.sgte = nuevoPasajero;
                }
                if (nuevoPasajero.sgte == null)
                {
                    final = nuevoPasajero;
                }
            }
            else
            {
                final.sgte = nuevoPasajero; 
                final = nuevoPasajero;   
            }
        }
        public void MostrarCola()
        {
            if (frente == null)
            {
                Console.WriteLine("La cola está vacía.");
                return;
            }
            NodoPasajero actual = frente;
            while (actual != null)
            {
                if (actual.Prioridad)
                {
                    Console.Write($"     {actual.Nombre,-13} -");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("      Prioridad");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine($" ({actual.Detalle})");
                }
                else
                {
                    Console.Write($"     {actual.Nombre,-13} -");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("      Regular");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine();
                }
                actual = actual.sgte;
            }
        }
        public void EliminarPasajero(string nombre)
        {
            if (frente == null)
            {
                Console.WriteLine("La cola está vacía.");
                return;
            }

            if (frente.Nombre == nombre)
            {
                Console.WriteLine($"Pasajero {frente.Nombre} ha sido eliminado de la cola.");
                frente = frente.sgte;
                if (frente == null)
                {
                    final = null;
                }
                return;
            }

            NodoPasajero actual = frente;
            while (actual.sgte != null && actual.sgte.Nombre != nombre)
            {
                actual = actual.sgte;
            }

            if (actual.sgte== null)
            {
                Console.WriteLine($"Pasajero {nombre} no se encontró en la cola.");
            }
            else
            {
                Console.WriteLine($"Pasajero {actual.sgte.Nombre} ha sido eliminado de la cola.");
                actual.sgte = actual.sgte.sgte;
                if (actual.sgte == null)
                {
                    final = actual;
                }
            }
        }
    }
}
