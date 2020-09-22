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
        private String folderSelecionado;
        private String archivosGT = "Archivos.gt |*.gt";
        private String archviosGTE = "Errores.gtE |*.gtE";

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
                //archivo = saveFileDialog.FileName;
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
                        //se le pasa de parametro el nombre del archivo que el usuario le de, en este caso pudo haber sido 'archivo'
                        using (StreamWriter textoGuardado = File.CreateText(archivo))
                        {
                            textoGuardado.Write(txtArea.Text);
                            MessageBox.Show("Archivo guardado exitosamente");
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar el archivo. "+ ex.Message);
            }

        }


        public void saveFile2(SaveFileDialog saveFileDialog, RichTextBox txtArea)
        {

            try
            {
                saveFileDialog.Filter = archivosGT +"| *.gtE";
                //archivo = saveFileDialog.FileName;
                if (archivo != null)
                {

                    using (StreamWriter textoGuardado = File.CreateText(this.rutaFolder+archivo))
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
                        //se le pasa de parametro el nombre del archivo que el usuario le de, en este caso pudo haber sido 'archivo'
                        using (StreamWriter textoGuardado = File.CreateText(this.rutaFolder + archivo))
                        {
                            textoGuardado.Write(txtArea.Text);
                            MessageBox.Show("Archivo guardado exitosamente");
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar el archivo. " + ex.Message);
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
                        MessageBox.Show("Archivo guardado exitosamente");
                    }
                    else
                    {
                        String ruta = saveFileDialog.FileName;

                        StreamWriter textoGuardado = File.CreateText(ruta);
                        textoGuardado.Write(txtErrores.Text);
                        textoGuardado.Flush();
                        textoGuardado.Close();
                        MessageBox.Show("Archivo guardado exitosamente");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo guardar el archivo");
            }

        }
        /**
         * crea una carptea para un proyecto nuevo
         * @ param name="folderDialog"
         */
        public void crearFolderProyecto(FolderBrowserDialog folderDialog)
        {

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {

                this.rutaFolder = folderDialog.SelectedPath;

                if (Directory.Exists(this.rutaFolder))
                {

                    Directory.CreateDirectory(rutaFolder);
                    Console.WriteLine(this.rutaFolder);
                    MessageBox.Show("Proyecto creado");
                }
            }
            
        }

        public void seleccionarCarpeta(FolderBrowserDialog folderBrowserDialog)
        {
            folderBrowserDialog.Description = "Seleciona tu proyecto";

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folderSelecionado = folderBrowserDialog.SelectedPath;
            }
        }
        /**
         * Metodo para cerrar un archivo abierto
         */
        public void cerrarArchivo(SaveFileDialog saveFile, RichTextBox txtArea)
        {
            this.archivo = null;
            txtArea.Clear();
            MessageBox.Show("Archivo cerrado exitosamente");
        }

        public void borrarArchivo(OpenFileDialog openFile)
        {
            openFile.Title = "Busca tu archivo";
            openFile.Filter = archivosGT;
            openFile.ShowDialog();
            try
            {
                if (File.Exists(openFile.FileName))
                {
                    if (openFile.ShowDialog() == DialogResult.OK)
                    {
                        File.Delete(openFile.FileName);
                        return;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo borrar el archivo");
            }
        }
    }
}
