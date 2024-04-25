using Proyecto1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1_01
{
    public partial class Form1 : Form
    {
        Game juego;
        int indexComboBoxSelected;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            juego = new Game(800, 600, "Demo OpenTK");
            indexComboBoxSelected = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = "";
                string fileNameWithoutExtension = "new Object";
                OpenFileDialog openFileDialog = new OpenFileDialog();

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);
                }
                Console.WriteLine("Nombre del archivo sin extensión: " + fileNameWithoutExtension);
                juego.JsonToObj(fileNameWithoutExtension, filePath);
                comboBox1.Items.Add(fileNameWithoutExtension);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string filePath="";
            string name = "Object";
            saveFileDialog1.Filter = "Archivos JSON (*.json)|*.json"; // Filtro para mostrar solo archivos JSON
            saveFileDialog1.Title = "Guardar archivo JSON"; // Título del cuadro de diálogo
            saveFileDialog1.FileName = "archivo"; // Nombre predeterminado del archivo
            saveFileDialog1.DefaultExt = ".json"; // Extensión predeterminada

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog1.FileName;
            }
            Console.WriteLine("Ruta del archivo: " + filePath);
            Console.WriteLine(indexComboBoxSelected);
            name = comboBox1.SelectedItem.ToString();
            juego.objToJson(name , filePath);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            juego.Run(60);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
