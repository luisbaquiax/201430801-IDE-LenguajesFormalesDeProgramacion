using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IDE_PROYECTO1.manejadorArchivo;
using IDE_PROYECTO1.automata;
using System.IO;

namespace IDE_PROYECTO1
{
    public partial class VentanaEditor : Form
    {
        private ManejadorArchivo manejadorArchvo;
        private AnalizadorLexico automata;
        private Pintor pintor;

        private string openFileName, folderName;

        private bool fileOpened = false;

        public VentanaEditor()
        {
            InitializeComponent();
            this.manejadorArchvo = new ManejadorArchivo();
        }
        /**
         * Abre o edita un archivo
         */
        private void abrirProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.manejadorArchvo.abrirArchivo(this.openFileDialog, this.txtEditorCodigo);
            this.manejadorArchvo.seleccionarCarpeta(this.folderBrowserDialog);

        }

        private void guardarProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.manejadorArchvo.saveFile(this.saveFile, this.txtEditorCodigo);

        }

        private void códigoFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuNuevoProyecto_Click(object sender, EventArgs e)
        {
            this.txtEditorCodigo.Clear();
            this.manejadorArchvo.crearFolderProyecto(this.folderBrowserDialog);
        }

        private void menuEliminarProyecto_Click(object sender, EventArgs e)
        {
            this.manejadorArchvo.borrarArchivo(this.openFileDialog);
        }

        private void menuCrearCodigoFuente_Click(object sender, EventArgs e)
        {
            this.manejadorArchvo.Archivo = null;
            this.manejadorArchvo.saveFile(this.saveFile, this.txtEditorCodigo);
            this.txtEditorCodigo.Clear();
            
        }

        private void menuAbrirCodigoFuente_Click(object sender, EventArgs e)
        {
            this.txtEditorCodigo.Clear();
            this.manejadorArchvo.Archivo = null;
            this.manejadorArchvo.abrirArchivo(this.openFileDialog, this.txtEditorCodigo);
           
        }

        private void menuEliminarCodigoFuente_Click(object sender, EventArgs e)
        {
            this.manejadorArchvo.borrarArchivo(this.openFileDialog);
        }

        private void menuCerrarCodigoFuente_Click(object sender, EventArgs e)
        {

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.manejadorArchvo.saveFile(this.saveFile, this.txtEditorCodigo);
        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnExportarErrores_Click(object sender, EventArgs e)
        {
            //se llama el metodo guardar archivo de la clase manejador archivo
            this.manejadorArchvo.saveFileErrores(this.saveFile, this.txtErrores);
        }

        /**
         * Evento para reconocer los tokens
         */
        private void txtEditorCodigo_TextChanged(object sender, EventArgs e)
        {
            ///this.txtErrores.Text = this.txtEditorCodigo.Text;
            this.automata = new AnalizadorLexico();
            this.automata.analizarTexto(this.txtEditorCodigo.Text, this.txtBoxFila, this.textBoxColumna);
            
            this.pintor = new Pintor(automata.PalabrasReservadas,
                automata.OperadoresAritmeticos,
                automata.OperadoresRelacionales,
                automata.OperadoresLogicos,
                automata.OperadoresAgrupacion,
                automata.OperadoresAsignacionFinSentencia,
                automata.PalabrasReservadasLenguaje, 
                this.txtEditorCodigo);

            this.pintor.colorearPalabrasReservadas();
            this.pintor.pintarFindeSentencia();
            this.pintor.pintarOperadoreLogicos();
            this.pintor.pintarOperadoreRelacionales();
            this.pintor.pintarOperadoresAritmeticos();
            this.pintor.pintarPalabrasReservadasLenguaje();
            this.pintor.pintarSignosdeAgrupacion();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtEditorCodigo.Clear();
            this.manejadorArchvo.abrirArchivo(this.openFileDialog, this.txtEditorCodigo);
        }

        private void cerrarAchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.manejadorArchvo.cerrarArchivo(this.saveFile, this.txtEditorCodigo);
        }

        private void btnCompilar_Click(object sender, EventArgs e)
        {

        }
    }
}
