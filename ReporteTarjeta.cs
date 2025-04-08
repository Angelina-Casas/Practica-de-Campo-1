using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G6_GestionMetroLinea1_T2
{
    internal class ReporteTarjeta
    {
        public NodoTarjeta p;
        public NodoTarjeta q;
        public int cont;
        public NodoTarjeta tarjetasEliminadasP;
        public NodoTarjeta tarjetasEliminadasQ;

        public ReporteTarjeta()
        {
            p = null;
            q = null;
            tarjetasEliminadasP = null;
            tarjetasEliminadasQ = null;
            cont = 0;
        }

        public void Insertar(string dni, string nombrePropietario, decimal saldoInicial, string tipoTarjeta)
        {
            decimal costoRegistro = 5.00m;
            decimal totalPagar = saldoInicial + costoRegistro;

            if (saldoInicial < 5.00m)
            {
                Console.WriteLine("El saldo inicial debe ser mayor a 5 soles.");
                return;
            }

            decimal saldoFinal = saldoInicial;
            NodoTarjeta nodo = new NodoTarjeta(dni, nombrePropietario, saldoFinal, tipoTarjeta);

            if (p == null)
            {
                p = nodo;
                q = nodo;
            }
            else
            {
                q.sgte = nodo;
                q = nodo;
            }
            cont++;

            decimal tarifaPasaje;
            switch (tipoTarjeta)
            {
                case "Universitario":
                    tarifaPasaje = 0.75m;
                    break;
                case "Escolar":
                    tarifaPasaje = 0.50m;
                    break;
                case "Normal":
                    tarifaPasaje = 1.50m;
                    break;
                default:
                    tarifaPasaje = 0.00m;
                    break;
            }

            Console.ForegroundColor = GetColorForTipoTarjeta(tipoTarjeta);
            Console.WriteLine("==================================================");
            Console.WriteLine($" Tarjeta registrada (DNI) : {nodo.numeroTarjeta:C}");
            Console.WriteLine($" Costo de registro        : {costoRegistro:C}");
            Console.WriteLine($" Saldo inicial            : {nodo.saldo:C}");
            Console.WriteLine($" Total a pagar            : {totalPagar:C}");
            Console.WriteLine($" Tarifa de pasaje         : {tarifaPasaje:C}");
            Console.WriteLine("==================================================");
        }

        private ConsoleColor GetColorForTipoTarjeta(string tipoTarjeta)
        {
            if (tipoTarjeta == "Universitario")
                return ConsoleColor.DarkBlue;
            else if (tipoTarjeta == "Escolar")
                return ConsoleColor.Magenta;
            else if (tipoTarjeta == "Normal")
                return ConsoleColor.Green;
            else
                return ConsoleColor.White;
        }

        public void Eliminar(string dni)
        {
            NodoTarjeta actual = p;
            NodoTarjeta anterior = null;

            while (actual != null)
            {
                if (actual.numeroTarjeta == dni)
                {
                    if (anterior == null)
                    {
                        p = actual.sgte;
                    }
                    else
                    {
                        anterior.sgte = actual.sgte;
                    }

                    if (tarjetasEliminadasP == null)
                    {
                        tarjetasEliminadasP = actual;
                        tarjetasEliminadasQ = actual;
                    }
                    else
                    {
                        tarjetasEliminadasQ.sgte = actual;
                        tarjetasEliminadasQ = actual;
                    }
                    tarjetasEliminadasQ.sgte = null; // Asegurar que no haya referencia a otro nodo

                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine($" Tarjeta con DNI {dni} eliminada....\n");
                    return;
                }
                anterior = actual;
                actual = actual.sgte;
            }
            Console.WriteLine("Tarjeta no encontrada...");
        }

        public void RecorrerTarjetas()
        {
            NodoTarjeta actual = p;

            if (actual == null)
            {
                Console.WriteLine("No hay tarjetas registradas.");
                return;
            }

            while (actual != null)
            {
                Console.ForegroundColor = GetColorForTipoTarjeta(actual.tipoTarjeta);
                Console.WriteLine("\n====================================================");
                Console.WriteLine($" Tarjeta (DNI)  : {actual.numeroTarjeta}     ");
                Console.WriteLine($" Propietario    : {actual.nombrePropietario} ");
                Console.WriteLine($" Saldo          : {actual.saldo:C}           ");
                Console.WriteLine($" Tipo           : {actual.tipoTarjeta}       ");
                Console.WriteLine("======================================================");
                actual = actual.sgte;
            }
            Console.ResetColor();
        }
        public void RecorrerTarjetasEliminadas()
        {
            NodoTarjeta actual = tarjetasEliminadasP;

            if (actual == null)
            {
                Console.WriteLine("No hay tarjetas eliminadas.");
                return;
            }

            while (actual != null)
            {
                Console.WriteLine("\n====================================================");
                Console.WriteLine($" Tarjeta eliminada (DNI)  : {actual.numeroTarjeta}     ");
                Console.WriteLine($" Propietario              : {actual.nombrePropietario} ");
                Console.WriteLine("======================================================");
                actual = actual.sgte;
            }
        }
    }
}