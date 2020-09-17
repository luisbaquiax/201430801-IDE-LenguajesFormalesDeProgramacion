using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace IDE_PROYECTO1.manejadorArchivo
{
    class ManejadorArchivo
    {
        private String archivo;
        private String rutaFolder;
        private String archivosGT = "Archivos.gt |*.gt";
        private String archviosGTE = "Errores.gt |*.gtE";

        public ManejadorArchivo() { }

        public string Archivo { get => archivo; set => archivo = value; }
        public string RutaFolder { get => rutaFolder; set => rutaFolder = value; }

        /**
        * Este método me servirá para abriri un arhivo
        * @ param name="openFile"
        * @ param name="txtArea"
        */
        public void abrirArchivo(OpenFileDialog openFile, RichTextBox txtArea)
        {
            openFile.Title = "Busca tu archivo";
            openFile.Filter = archivosGT;
            openFile.ShowDialog();
            try
            {
                if (File.Exists(openFile.FileName))
                {

                    archivo = openFile.FileName;

                    TextReader lectorArchivo = new StreamReader(archivo);
                    txtArea.AppendText(lectorArchivo.ReadToEnd());
                    lectorArchivo.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo abrir el proyecto");
            }

        }


        /**
        * Este método me serve para guardar un arhivo,
        * si el archivo es diferente de nulo se crea uno nuevo, sino no se crea
        * @ param name="saveFileDialog"param name="saveFileDialog"
        */
        public void saveFile(SaveFileDialog saveFileDialog, RichTextBox txtArea)
        {

            try
            {
                saveFileDialog.Filter = archivosGT;

                if (archivo != null)
                {
                    using (StreamWriter textoGuardado = File.CreateText(archivo))
                    {
                        textoGuardado.Write(txtArea.Text);
                        MessageBox.Show("Archivo guardado exitosamente");
                    }
                }
                else
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {

                        archivo = saveFileDialog.FileName;
                        //se le pasa de parametro el nombre del archivo que el usuario le de
                        using (StreamWriter textoGuardado = File.CreateText(saveFileDialog.FileName))
                        {
                            textoGuardado.Write(txtArea.Text);
                            MessageBox.Show("Archivo guardado exitosamente");
                        }
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo guardar el archivo");
            }

        }

        /**
         * Método para guardar el archivo de los errore
         * Si el archivo existe no se crea, sino se crea
         * @ param name="saveFileDialog" 
         * @ param name="txtErrores"
         */
        public void saveFileErrores(SaveFileDialog saveFileDialog, RichTextBox txtErrores)
        {

            try
            {
                saveFileDialog.Filter = archviosGTE;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFileDialog.FileName))
                    {
                        String ruta = saveFileDialog.FileName;

                        StreamWriter textoGuardado = File.CreateText(ruta);
                        textoGuardado.Write(txtErrores.Text);
                        textoGuardado.Flush();
                        textoGuardado.Close();
                    }
                    else
                    {
                        String ruta = saveFileDialog.FileName;

                        StreamWriter textoGuardado = File.CreateText(ruta);
                        textoGuardado.Write(txtErrores.Text);
                        textoGuardado.Flush();
                        textoGuardado.Close();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo guardar el archivo");
            }

        }

        public void crearFolderProyecto(FolderBrowserDialog folderDialog)
        {


            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                rutaFolder = folderDialog.SelectedPath;

                if (!Directory.Exists(rutaFolder))
                {
                    Directory.CreateDirectory(rutaFolder);
                }
            }


        }
    }
}
