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

        public ManejadorArchivo() { }
        /**
         * Este método me servirá para abriri un arhivo
         */
        private void escribirArchivo()
        {
            //de momento escribe el archivo 
            try
            {
                TextWriter escritor = new StreamWriter(@"C:/Users/Usuario/Documents/file.txt");
                escritor.WriteLine("Este es un texto de mi archivo");
                escritor.Close();
                MessageBox.Show("Archivo creado");
            }
            catch (Exception)
            {
                MessageBox.Show("no se pudo escribir el archivo");
            }
        }

        public void leerArchivo(RichTextBox txtArea)
        {
            TextReader lector = new StreamReader(@"C:/Users/Usuario/Documents/file.txt");
            txtArea.Text = lector.ReadToEnd();
            lector.Close();
        }

        /**
        * Este método me servirá para abriri un arhivo
        */
        public void abrirArchivo(OpenFileDialog openFile, RichTextBox txtArea)
        {
            openFile.Title = "Busca tu archivo";
            openFile.ShowDialog();
            try
            {
                if (File.Exists(openFile.FileName))
                {

                    String ruta = openFile.FileName;

                    TextReader lectorArchivo = new StreamReader(ruta);
                    txtArea.Text = lectorArchivo.ReadToEnd();
                    lectorArchivo.Close();
                    //MessageBox.Show("");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo abrir el proyecto");
            }

        }


        /**
        * Este método me servirá para guardar un arhivo
        */
        public void saveFile(SaveFileDialog saveFileDialog, RichTextBox txtArea)
        {

            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFileDialog.FileName))
                    {
                        String ruta = saveFileDialog.FileName;

                        StreamWriter textoGuardado = File.CreateText(ruta);
                        textoGuardado.Write(txtArea.Text);
                        textoGuardado.Flush();
                        textoGuardado.Close();
                    }
                    else
                    {
                        String ruta = saveFileDialog.FileName;

                        StreamWriter textoGuardado = File.CreateText(ruta);
                        textoGuardado.Write(txtArea.Text);
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
    }
}
