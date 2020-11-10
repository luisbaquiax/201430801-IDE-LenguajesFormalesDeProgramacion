using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE_PROYECTO1.automata
{
    class Token
    {
        int fila = 0;
        int columna = 0;
        String token;

        public Token(int fila, int columna, string token)
        {
            this.fila = fila;
            this.columna = columna;
            this.token = token;
        }

        public int Fila { get => fila; set => fila = value; }
        public int Columna { get => columna; set => columna = value; }
    }
}
