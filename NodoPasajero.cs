using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G6_GestionMetroLinea1_T2
{
    internal class NodoPasajero
    {
        public string Nombre { get; set; }
        public bool Prioridad { get; set; }
        public string Detalle { get; set; }
        public NodoPasajero sgte { get; set; }
        public NodoPasajero(string nombre, bool prioridad, string detalle = "")
        {
            Nombre = nombre;
            Prioridad = prioridad;
            Detalle = detalle;
            sgte = null;
        }
        public override string ToString()
        {
            if (Prioridad)
                return $"    {Nombre}  -  Prioridad ({Detalle})";
            else
                return $"    {Nombre}  -  Pasajero Regular";
        }
    }
}
