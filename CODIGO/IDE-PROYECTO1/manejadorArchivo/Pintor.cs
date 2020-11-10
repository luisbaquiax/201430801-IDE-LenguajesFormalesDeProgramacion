using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDE_PROYECTO1.manejadorArchivo
{
    class Pintor
    {
        private String[] palabrasReservadas;
        private String[] operadoresAritmeticos;
        private String[] operadoresRelacionales;
        private String[] operadoresLogicos;
        private String[] operadoresAgrupacion;
        private String[] operadoresAsignacionFinSentencia;
        private String[] palabrasReservadasLenguaje;
        private RichTextBox richTextBox;

        public Pintor(string[] palabrasReservadas,
            string[] operadoresAritmeticos,
            string[] operadoresRelacionales,
            string[] operadoresLogicos,
            string[] operadoresAgrupacion,
            string[] operadoresAsignacionFinSentencia,
            string[] palabrasReservadasLenguaje,
            RichTextBox richTextBox)
        {
            this.palabrasReservadas = palabrasReservadas;
            this.operadoresAritmeticos = operadoresAritmeticos;
            this.operadoresRelacionales = operadoresRelacionales;
            this.operadoresLogicos = operadoresLogicos;
            this.operadoresAgrupacion = operadoresAgrupacion;
            this.operadoresAsignacionFinSentencia = operadoresAsignacionFinSentencia;
            this.palabrasReservadasLenguaje = palabrasReservadasLenguaje;
            this.richTextBox = richTextBox;
        }

        private void pintar(String palabra, Color color, int startIndex)
        {
            if (this.richTextBox.Text.Contains(palabra))
            {
                int indice = -1;
                int seleccionarInicio = this.richTextBox.SelectionStart;

                while ((indice = this.richTextBox.Text.IndexOf(palabra, (indice + 1))) != -1)
                {
                    this.richTextBox.Select((indice + startIndex), palabra.Length);
                    this.richTextBox.SelectionColor = color;
                    this.richTextBox.Select(seleccionarInicio, 0);
                    this.richTextBox.SelectionColor = Color.Black;
                }
            }
        }

        public void colorearPalabrasReservadas()
        {
            pintar("entero ", Color.Purple, 0);
            pintar("decimal ", Color.LightBlue, 0);
            pintar("cadena ", Color.Gray, 0);
            pintar("booleano ", Color.Orange, 0);
            pintar("caracter ", Color.Brown, 0);

            pintar("entero\n", Color.Purple, 0);
            pintar("decimal\n", Color.LightBlue, 0);
            pintar("cadena\n", Color.Gray, 0);
            pintar("booleano\n", Color.Orange, 0);
            pintar("caracter\n", Color.Brown, 0);

        }

        public void pintarOperadoresAritmeticos()
        {
            for (int i = 0; i < this.operadoresAritmeticos.Length; i++)
            {
                pintar(this.operadoresAritmeticos[i], Color.DarkBlue, 0);
            }

        }

        public void pintarOperadoreRelacionales()
        {

            for (int i = 0; i < this.operadoresRelacionales.Length; i++)
            {
                pintar(this.operadoresRelacionales[i] + ' ', Color.DarkBlue, 0);

            }
        }

        public void pintarOperadoreLogicos()
        {

            for (int i = 0; i < this.operadoresLogicos.Length; i++)
            {
                pintar(this.operadoresLogicos[i] + ' ', Color.Blue, 0);

            }
        }

        public void pintarSignosdeAgrupacion()
        {
            for (int i = 0; i < this.operadoresAgrupacion.Length; i++)
            {
                pintar(this.operadoresAgrupacion[i] + ' ', Color.DarkBlue, 0);
                pintar(this.operadoresAgrupacion[i] + '\n', Color.DarkBlue, 0);
            }
        }

        public void pintarFindeSentencia()
        {
            for (int i = 0; i < this.operadoresAsignacionFinSentencia.Length; i++)
            {
                pintar(this.operadoresAsignacionFinSentencia[i] + ' ', Color.DeepPink, 0);
                pintar(this.operadoresAsignacionFinSentencia[i] + '\n', Color.DeepPink, 0);
            }
        }

        public void pintarPalabrasReservadasLenguaje()
        {
            for (int i = 0; i < this.palabrasReservadasLenguaje.Length; i++)
            {
                pintar(this.palabrasReservadasLenguaje[i] + ' ', Color.DarkGreen, 0);
                pintar(this.palabrasReservadasLenguaje[i] + '\n', Color.DarkGreen, 0);
            }
        }
    }
}
