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

namespace IDE_PROYECTO1
{
    public partial class VentanaEditor : Form
    {
        private ManejadorArchivo manejadorArchvo;

        public VentanaEditor()
        {
            InitializeComponent();
            this.manejadorArchvo = new ManejadorArchivo();
        }
        /**
         * Abre o edita un archivo
         */
        private void editarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.manejadorArchvo.abrirArchivo(this.openFileDialog, this.txtEditorCodigo);
                
        }

        private void códigoFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuNuevoProyecto_Click(object sender, EventArgs e)
        {
            this.manejadorArchvo.saveFile(this.saveFile, this.txtEditorCodigo);
        }

        private void menuEliminarProyecto_Click(object sender, EventArgs e)
        {

        }

        private void menuCrearCodigoFuente_Click(object sender, EventArgs e)
        {

        }

        private void menuAbrirCodigoFuente_Click(object sender, EventArgs e)
        {

        }

        private void menuEliminarCodigoFuente_Click(object sender, EventArgs e)
        {

        }

        private void menuCerrarCodigoFuente_Click(object sender, EventArgs e)
        {

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuSalir_Click(object sender, EventArgs e)
        {

        }

        private void btnExportarErrores_Click(object sender, EventArgs e)
        {

        }
    }
}
