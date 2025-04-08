using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G6_GestionMetroLinea1_T2
{
    internal class ReporteEstacion
    {
        private NodoEstacion p = null;
        public ReporteEstacion()
        {
            AgregarEstacionesPredeterminadas();
        }
        private void AgregarEstacionesPredeterminadas()
        {
            AgregarEstacion(new NodoEstacion("       Bayobar     ", "05:00", "22:02"));
            AgregarEstacion(new NodoEstacion("      Santa Rosa    ", "05:02", "22:04"));
            AgregarEstacion(new NodoEstacion("      San Martin     ", "05:04", "22:06"));
            AgregarEstacion(new NodoEstacion("      San Carlos     ", "05:06", "22:08"));
            AgregarEstacion(new NodoEstacion("      Los Postes     ", "05:08", "22:10"));
            AgregarEstacion(new NodoEstacion("     Los Jardines     ", "05:10", "22:12"));
            AgregarEstacion(new NodoEstacion("   Piramide del Sol    ", "05:12", "22:14"));
            AgregarEstacion(new NodoEstacion("     Caja de Agua     ", "05:14", "22:16"));
            AgregarEstacion(new NodoEstacion("  Presbitero Maestro  ", "05:17", "22:18"));
            AgregarEstacion(new NodoEstacion("       El angel       ", "05:19", "22:20"));
            AgregarEstacion(new NodoEstacion("       Gamarra       ", "05:23", "22:24"));
            AgregarEstacion(new NodoEstacion("       Arriola       ", "05:25", "22:26"));
            AgregarEstacion(new NodoEstacion("      La Cultura     ", "05:27", "22:28"));
            AgregarEstacion(new NodoEstacion("     San Borja Sur     ", "05:30", "22:30"));
            AgregarEstacion(new NodoEstacion("       Angamos       ", "05:32", "23:33"));
            AgregarEstacion(new NodoEstacion("       Cabitos       ", "05:35", "22:35"));
            AgregarEstacion(new NodoEstacion("       Ayacucho      ", "05:37", "22:37"));
            AgregarEstacion(new NodoEstacion("     Jorge Chavez     ", "05:39", "22:39"));
            AgregarEstacion(new NodoEstacion("       Atocongo      ", "05:42", "22:42"));
            AgregarEstacion(new NodoEstacion("       San Juan     ", "05:44", "22:44"));
            AgregarEstacion(new NodoEstacion("     Villa Maria    ", "05:48", "22:48"));
            AgregarEstacion(new NodoEstacion("      Pumacahua     ", "05:50", "22:50"));
            AgregarEstacion(new NodoEstacion("  Parque Industrial  ", "05:52", "22:52"));
            AgregarEstacion(new NodoEstacion("  Villa el Salvador  ", "05:54", "22:54"));
        }
        private void AgregarEstacion(NodoEstacion nuevaEstacion)
        {
            if (p == null)
            {
                p = nuevaEstacion;
            }
            else
            {
                NodoEstacion actual = p;
                while (actual.sgte != null)
                {
                    actual = actual.sgte;
                }
                actual.sgte = nuevaEstacion;
            }
        }
        public NodoEstacion Buscar(string nombre)
        {
            NodoEstacion actual = p;
            while (actual != null)
            {
                if (string.Equals(actual.nombre, nombre, StringComparison.OrdinalIgnoreCase))
                {
                    return actual;
                }
                actual = actual.sgte;
            }
            return null;
        }
        public void Imprimir()
        {
            if (p == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            NodoEstacion actual = p;
            while (actual != null)
            {
                Console.WriteLine($"|        {actual.nombre,-23} |");
                actual = actual.sgte;
            }
        }
        public void ImprimirHr()
        {
            if (p == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            NodoEstacion actual = p;
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("|        ESTACION           |     APERTURA    |       CIERRE      |");
            Console.WriteLine("-------------------------------------------------------------------");

            while (actual != null)
            {
                Console.WriteLine($"| {actual.nombre,-23}   |      {actual.apertura,-9}  |       {actual.cierre,-10}  |");
                actual = actual.sgte; 
            }

            Console.WriteLine("-------------------------------------------------------------------");
        }
        public NodoHorario Principal { get; set; }
        public void Agregar(NodoHorario estacion)
        {
            if (Principal == null)
            {
                Principal = estacion;
            }
            else
            {
                NodoHorario actual = Principal;
                while (actual.sgte != null)
                {
                    if (actual.nombre == estacion.nombre)
                    {
                        return;
                    }
                    actual = actual.sgte;
                }
                actual.sgte = estacion;
            }
        }
    }
}
