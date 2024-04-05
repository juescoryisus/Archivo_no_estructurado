using System;
using System.IO;
using System.Windows.Forms;

namespace Archivo_no_estructurado
{
    public partial class Form1 : Form
    {
        private string filePath = "datos.txt"; // Ruta del archivo de datos

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string dataToSave = txtDato.Text;

            txtDato.Clear();

            // Escribir el texto en el archivo
            File.WriteAllText(filePath, dataToSave);

            MessageBox.Show("Datos guardados correctamente en el archivo.");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                // Leer el texto desde el archivo
                string loadedData = File.ReadAllText(filePath);

                // Mostrar el texto en el cuadro de texto
                txtDato.Text = loadedData;

                MessageBox.Show("Datos cargados correctamente desde el archivo.");
            }
            else
            {
                MessageBox.Show("El archivo no existe.");
            }
        }
    }
}
