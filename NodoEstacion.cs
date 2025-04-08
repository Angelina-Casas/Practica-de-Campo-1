using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G6_GestionMetroLinea1_T2
{
    internal class NodoEstacion
    {
        public string nombre;
        public string apertura;
        public string cierre;
        public NodoEstacion sgte;
        public NodoEstacion(string nombre, string apertura, string cierre)
        {
            this.nombre = nombre.Trim();
            this.apertura = apertura;
            this.cierre = cierre;
            sgte = null;
        }
    }
}
