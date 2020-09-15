using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDE_PROYECTO1.automata
{
    class Automata
    {
        private String estadoActual;
        private String[] estadoDeAceptacion;
        private Transicion[] transiciones;
        private String[] alfabeto;

        public Automata()
        {
            this.estadoActual = "QO";
            this.estadoDeAceptacion = new string[] { "Q1", "Q2" };
            this.transiciones = new Transicion[] {
                new Transicion("Q0","B","Q1"),
                new Transicion("Q1","B","Q1"),
                new Transicion("Q1","C","Q2"),
                new Transicion("Q2","B","Q1")};
            this.alfabeto = new string[] { "B", "C" };
        }

        public void analizarTexto(String texto)
        {
            char[] caracteres = texto.ToCharArray();
            for (int i = 0; i < this.transiciones.Length; i++)
            {

            }
        }

        public Boolean esPosibleTransitar(String caracter)
        {
            for (int i = 0; i < this.transiciones.Length; i++)
            {
                if (this.transiciones[i].Inicial.Equals(this.estadoActual, StringComparison.InvariantCultureIgnoreCase)
                    && esAceptadoEnAlfabeto(caracter))
                {
                    //this.estadoActual = this.transiciones[i].getSiguiente;
                    return true;
                }
            }
            return false;
        }

        /**
         * Verifico si el caracter es aceptado en mi alfabeto
         */
        public Boolean esAceptadoEnAlfabeto(String caracter)
        {
            for (int i = 0; i < this.alfabeto.Length; i++)
            {
                if (this.alfabeto[i].Equals(caracter, StringComparison.InvariantCultureIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
