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


        public Automata()
        {
            this.estadoActual = "QO";
            this.estadosDeAceptacion = new string[] { "Q1", "Q2" };
            this.transiciones = new Transicion[] {
                new Transicion("Q0","B","Q1"),
                new Transicion("Q1","B","Q1"),
                new Transicion("Q1","C","Q2"),
                new Transicion("Q2","B","Q1")};
            /*this.alfabeto = new string[] { "A", "B","C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N","Ñ", "O", "P", "Q", "R",
             "S", "T","U", "V", "W","X", "Y", "Z","1", "2", "3","4", "5", "6","7", "8", "9","0"};*/
            this.alfabeto = obtenerAlfabeto();

            this.iniciarComponentesDelLenguaje();
        }
        /**
         * Inicia los componetes del lenguaje
         */
        public void iniciarComponentesDelLenguaje()
        {
            this.palabrasReservadas = new String[] { "enter", "decimal", "cadena", "booleano", "caracter" };
            this.operadoresAritmeticos = new string[] { "+", "-", "*", "/", "++", "--" };
            this.operadoresRelacionales = new string[] { ">", "<", ">=", "<=", "==", "!=" };
            this.operadoresLogicos = new string[] { "||", "&&", "!" };
            this.operadoresAgrupacion = new string[] { "(", ")" };
            this.operadoresAsignacionFinSentencia = new String[] { "=", ";" };
            this.palabrasReservadasLenguaje = new string[] { "SI", "SINO", "SINO_SI", "MIENTRAS", "HACER", "DESDE", "HASTA", "INCREMENTO" };
        }
        /**
         * Se recorre el texto en si, se verifica primero es aceptado en el alfabeto después se hace la transición
         * auxiliándose de la transición auxiliar, en caso de nulo no es posible la transición
         * @ param name="texto"
         */
        public void analizarTexto(String texto)
        {

            for (int i = 0; i < texto.Length; i++)
            {
                //this.caracter = Convert.ToString(texto[i]);
                this.caracter = texto[i].ToString();
                if (esAceptadoEnAlfabeto(this.alfabeto, caracter))
                {

                    Transicion auxiliar = buscarTransicion(this.estadoActual, caracter, this.transiciones);
                    if (auxiliar != null)
                    {
                        if (auxiliar.EstadoSiguiente != null)
                        {
                            estadoActual = auxiliar.EstadoSiguiente;
                        }
                    }
                    else
                    {
                        //se corta el flujo si no se puede realizar la transicion con el caracter actual
                        
                        return;
                    }
                }
                else
                {
                    //se el caracter no es aceptado en el alfabeto se termina el proceso
                    return;
                }
                if (esEstadoAceptado(estadoActual, this.estadosDeAceptacion))
                {
                    //es un estado de aceptación
                    this.cadena += this.caracter;
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
         * @ param name="caracter"
         */
        public Boolean esAceptadoEnAlfabeto(String caracter, String alfabeto)
        {
            for (int i = 0; i < alfabeto.Length; i++)
            {
                if (this.alfabeto[i].ToString().Equals(caracter, StringComparison.InvariantCultureIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

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


