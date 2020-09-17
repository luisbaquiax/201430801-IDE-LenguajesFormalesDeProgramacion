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
        private String alfabeto;

        public Automata()
        {
            this.estadoActual = "QO";
            this.estadoDeAceptacion = new string[] { "Q1", "Q2" };
            this.transiciones = new Transicion[] {
                new Transicion("Q0","B","Q1"),
                new Transicion("Q1","B","Q1"),
                new Transicion("Q1","C","Q2"),
                new Transicion("Q2","B","Q1")};
            /*this.alfabeto = new string[] { "A", "B","C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N","Ñ", "O", "P", "Q", "R",
             "S", "T","U", "V", "W","X", "Y", "Z","1", "2", "3","4", "5", "6","7", "8", "9","0"};*/
            this.alfabeto = obtenerAlfabeto();
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
                if ( this.alfabeto[i].ToString().Equals(caracter, StringComparison.InvariantCultureIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
        /**
         * Metod para obtener todos los caractere para el alfabeto del IDE-PROYECTO
         */
        public String obtenerAlfabeto() {
            String caracteres = "";
            for (int i = 32; i < 126; i++) {
                caracteres += (char)i;
            }
            return caracteres;
        }
        /**
         * Convierte una cadena en una arreglo de caracteres
         */
        public char[] obtenerAlfabetoEnCaracteres(String alfabeto) {
            char[] caracteres = new Char[alfabeto.Length];
            for (int i = 0; i< caracteres.Length;  i++) {
                caracteres[i] = alfabeto[i]; 
            }
            return caracteres;
        }
    }
}
