using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDE_PROYECTO1.automata
{
    class AnalizadorLexico
    {
        private String estadoActual;
        private String[] estadosDeAceptacion;
        private Transicion[] transiciones;
        private String alfabeto;
        private String cadena;
        private String caracter;
        //componentes del lenguaje
        private String[] palabrasReservadas;
        private String[] operadoresAritmeticos;
        private String[] operadoresRelacionales;
        private String[] operadoresLogicos;
        private String[] operadoresAgrupacion;
        private String[] operadoresAsignacionFinSentencia;
        private String[] palabrasReservadasLenguaje;

        //posicion de tokens, fila columna, de cada carácter
        private int fila = 0;
        private int columna = 0;
        private char espacio = (char)32;
        private char saltoDeLinea = (char)10;

        public string EstadoActual { get => estadoActual; set => estadoActual = value; }
        public string[] EstadosDeAceptacion { get => estadosDeAceptacion; set => estadosDeAceptacion = value; }
        internal Transicion[] Transiciones { get => transiciones; set => transiciones = value; }
        public string Alfabeto { get => alfabeto; set => alfabeto = value; }
        public string Cadena { get => cadena; set => cadena = value; }
        public string[] PalabrasReservadas { get => palabrasReservadas; set => palabrasReservadas = value; }
        public string[] OperadoresAritmeticos { get => operadoresAritmeticos; set => operadoresAritmeticos = value; }
        public string[] OperadoresRelacionales { get => operadoresRelacionales; set => operadoresRelacionales = value; }
        public string[] OperadoresLogicos { get => operadoresLogicos; set => operadoresLogicos = value; }
        public string[] OperadoresAgrupacion { get => operadoresAgrupacion; set => operadoresAgrupacion = value; }
        public string[] OperadoresAsignacionFinSentencia { get => operadoresAsignacionFinSentencia; set => operadoresAsignacionFinSentencia = value; }
        public string[] PalabrasReservadasLenguaje { get => palabrasReservadasLenguaje; set => palabrasReservadasLenguaje = value; }
        public int Fila { get => fila; set => fila = value; }
        public int Columna { get => columna; set => columna = value; }

        public AnalizadorLexico()
        {
            this.EstadoActual = "S0";
            this.EstadosDeAceptacion = new string[] { "S6", "S7", "S13", "S18", "S19", "S20", "S22", "S23" };
            //transiciones
            this.Transiciones = new Transicion[] {
                new Transicion("Q0","B","Q1"),
                new Transicion("Q1","B","Q1"),
                new Transicion("Q1","C","Q2"),
                new Transicion("Q2","B","Q1")};

            this.Alfabeto = obtenerAlfabeto();
            this.iniciarComponentesDelLenguaje();
            /*this.alfabeto = new string[] { "A", "B","C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N","Ñ", "O", "P", "Q", "R",
             "S", "T","U", "V", "W","X", "Y", "Z","1", "2", "3","4", "5", "6","7", "8", "9","0"};*/
        }

        /**
         * Inicia los componetes del lenguaje
         */
        public void iniciarComponentesDelLenguaje()
        {
            this.PalabrasReservadas = new String[] { "entero", "decimal", "cadena", "booleano", "caracter" };
            this.OperadoresAritmeticos = new string[] { "+", "-", "*", "/", "++", "--" };
            this.OperadoresRelacionales = new string[] { ">", "<", ">=", "<=", "==", "!=" };
            this.OperadoresLogicos = new string[] { "||", "&&", "!" };
            this.OperadoresAgrupacion = new string[] { "(", ")" };
            this.OperadoresAsignacionFinSentencia = new String[] { "=", ";" };
            this.PalabrasReservadasLenguaje = new string[] { "SI", "SINO", "SINO_SI", "MIENTRAS", "HACER", "DESDE", "HASTA", "INCREMENTO" };
        }
        /**
         * Se recorre el texto en si, se verifica primero es aceptado en el alfabeto después se hace la transición
         * auxiliándose de la transición auxiliar, en caso de nulo no es posible la transición
         * @ param name="texto"
         */
        public void analizarTexto(String texto, TextBox textBoxFila, TextBox textBoxColumna)
        {

            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] == this.saltoDeLinea)
                {
                    this.fila++;
                    textBoxFila.Text = "";
                    textBoxFila.Text = this.fila + "";
                }
                if (texto[i] != saltoDeLinea)
                {
                    this.columna++;
                    textBoxFila.Text = "";
                    textBoxFila.Text = this.columna + "";
                }
                //this.caracter = Convert.ToString(texto[i]);
                this.caracter = texto[i].ToString();
                if (esAceptadoEnAlfabeto(this.Alfabeto, caracter))
                {

                    Transicion auxiliar = buscarTransicion(this.EstadoActual, caracter, this.Transiciones);
                    if (auxiliar != null)
                    {
                        if (auxiliar.EstadoSiguiente != null)
                        {
                            EstadoActual = auxiliar.EstadoSiguiente;
                        }
                    }
                    else
                    {
                        //se corta el flujo si no se puede realizar la transicion con el caracter actual

                        //return;
                    }
                }
                else
                {
                    //se el caracter no es aceptado en el alfabeto se termina el proceso
                    //return;
                }
                if (esEstadoAceptado(EstadoActual, this.EstadosDeAceptacion))
                {
                    //es un estado de aceptación
                    this.Cadena += this.caracter;
                }
                else
                {
                    //Es un estado de no aceptación
                }
            }
        }

        /**
         * Busca la transicion auxiliar en la lista de transiones, retorna null si no existe.
         * @ param name="estadoActual"
         * @ param name="transiciones"
         * @ param name="valorActual"
         */
        public Transicion buscarTransicion(String estadoActual, String valorActual, Transicion[] transiciones)
        {
            for (int i = 0; i < transiciones.Length; i++)
            {
                if (transiciones[i].EstadoInicial.Equals(estadoActual, StringComparison.InvariantCultureIgnoreCase) && (transiciones[i].Valor.Equals(valorActual, StringComparison.InvariantCultureIgnoreCase)))
                {
                    return transiciones[i];
                }
            }
            return null;
        }

        /**
         * Verifico si el caracter es aceptado en mi alfabeto
         * param name="caracter"
         * param name="alfabeto"
         */
        public Boolean esAceptadoEnAlfabeto(String caracter, String alfabeto)
        {
            for (int i = 0; i < alfabeto.Length; i++)
            {
                if (this.Alfabeto[i].ToString().Equals(caracter, StringComparison.InvariantCultureIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
        /**
         * Verifica si el estado actual es un estado aceptado
         */
        public Boolean esEstadoAceptado(String estadoActual, String[] estados)
        {
            for (int i = 0; i < estados.Length; i++)
            {
                if (estados[i].Equals(estadoActual, StringComparison.InvariantCultureIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
        /**
         * Metod para obtener todos los caractere para el alfabeto del IDE-PROYECTO
         */
        public String obtenerAlfabeto()
        {
            String caracteres = "";
            for (int i = 32; i < 126; i++)
            {
                caracteres += (char)i;
            }
            //salto de línea en codigo ascii
            caracteres += (char)10;
            return caracteres;
        }
        /**
         * Convierte una cadena en una arreglo de caracteres
         * @ param name="alfabeto"
         */
        public char[] obtenerAlfabetoEnCaracteres(String alfabeto)
        {
            char[] caracteres = new Char[alfabeto.Length];
            for (int i = 0; i < caracteres.Length; i++)
            {
                caracteres[i] = alfabeto[i];
            }
            return caracteres;
        }
    }
}


