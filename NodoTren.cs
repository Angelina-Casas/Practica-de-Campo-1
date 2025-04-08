using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G6_GestionMetroLinea1_T2
{
    internal class NodoTren
    {
        public int id;
        public bool estado;
        public string detalle;
        public NodoTren sgte;
        public NodoTren(int id, bool estado, string detalle)
        {
            this.id = id;
            this.estado = estado;
            this.detalle = detalle;
            sgte = null;
        }
    }
}