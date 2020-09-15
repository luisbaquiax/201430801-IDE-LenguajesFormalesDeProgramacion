using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE_PROYECTO1.automata
{
    class Transicion
    {
        private String estadoInicial;
        private String estadoSiguiente;
        private String valor;

        public Transicion(string estadoInicial, string estadoSiguiente, string valor)
        {
            this.estadoInicial = estadoInicial;
            this.valor = valor;
            this.estadoSiguiente = estadoSiguiente;
        }

        public string Inicial { get => estadoInicial; set => estadoInicial = value; }
        public string Siguiente { get => estadoSiguiente; set => estadoSiguiente = value; }
        public string Valor { get => valor; set => valor = value; }
    }
}
