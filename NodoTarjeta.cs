using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G6_GestionMetroLinea1_T2
{
    internal class NodoTarjeta
    {
        public string numeroTarjeta;
        public string nombrePropietario;
        public decimal saldo;
        public string tipoTarjeta;
        public NodoTarjeta sgte;
        public NodoTarjeta(string numeroTarjeta, string nombrePropietario, decimal saldo, string tipoTarjeta)
        {
            this.numeroTarjeta = numeroTarjeta;
            this.nombrePropietario = nombrePropietario;
            this.saldo = saldo;
            this.tipoTarjeta = tipoTarjeta;
            sgte = null;
        }
    }
}
