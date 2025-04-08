using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G6_GestionMetroLinea1_T2
{
    internal class NodoHorario
    {
        public string nombre;
        public string horarioApertura;
        public string horarioCierre;
        public NodoHorario sgte;
        public NodoHorario(string nombre, string horarioApertura, string horarioCierre)
        {
            this.nombre = nombre;
            this.horarioApertura = horarioApertura;
            this.horarioCierre = horarioCierre;
        }
    }
}