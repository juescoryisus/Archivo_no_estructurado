using System;
using System.IO;
using System.Windows.Forms;

namespace Archivo_no_estructurado
{
    public partial class Form1 : Form
    {
        private string filePath = "datos.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string dataToSave = txtDato.Text;

            txtDato.Clear();

            File.WriteAllText(filePath, dataToSave);

            MessageBox.Show("Datos guardados correctamente en el archivo.");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                string loadedData = File.ReadAllText(filePath);

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
