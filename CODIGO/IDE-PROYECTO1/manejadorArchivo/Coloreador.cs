using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDE_PROYECTO1.manejadorArchivo
{
    class Coloreador
    {
        private String[] palabrasReservadas;
        private String[] operadoresAritmeticos;
        private String[] operadoresRelacionales;
        private String[] operadoresLogicos;
        private String[] operadoresAgrupacion;
        private String[] operadoresAsignacionFinSentencia;
        private String[] palabrasReservadasLenguaje;

        public Coloreador(string[] palabrasReservadas, 
            string[] operadoresAritmeticos, 
            string[] operadoresRelacionales, 
            string[] operadoresLogicos, 
            string[] operadoresAgrupacion, 
            string[] operadoresAsignacionFinSentencia, 
            string[] palabrasReservadasLenguaje)
        {
            this.palabrasReservadas = palabrasReservadas;
            this.operadoresAritmeticos = operadoresAritmeticos;
            this.operadoresRelacionales = operadoresRelacionales;
            this.operadoresLogicos = operadoresLogicos;
            this.operadoresAgrupacion = operadoresAgrupacion;
            this.operadoresAsignacionFinSentencia = operadoresAsignacionFinSentencia;
            this.palabrasReservadasLenguaje = palabrasReservadasLenguaje;
        }

        public void colorearPalabrasReservadas(String identificadorReservado, RichTextBox richText) {
            //identificadorReservado.
        }
    }
}
