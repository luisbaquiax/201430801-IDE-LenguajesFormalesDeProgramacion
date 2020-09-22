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
        private String valor;
        private String estadoSiguiente;

        public Transicion(string estadoInicial, string valor, string siguiente)
        {
            this.EstadoInicial = estadoInicial;
            this.Valor = valor;
            this.EstadoSiguiente = EstadoSiguiente;
        }

        public string EstadoInicial { get => estadoInicial; set => estadoInicial = value; }
        public string Valor { get => valor; set => valor = value; }
        public string EstadoSiguiente { get => estadoSiguiente; set => estadoSiguiente = value; }
    }
}
