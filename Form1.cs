using Proyecto1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            juego = new Game(800, 600, "Demo OpenTK");
             
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
                addItemsCbx();
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
            //name = comboBox1.SelectedItem.ToString();
            juego.objToJson(filePath);
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
            cmbxParts.SelectedItem = null;
            cmbxParts.Items.Clear();
            cmbxFaces.SelectedItem = null;
            cmbxFaces.Items.Clear();
            foreach (var parts in juego.stage.getFigure(cmbxObjets.SelectedItem.ToString()).GetListParts())
            {
                cmbxParts.Items.Add(parts.Key);
                
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void addItemsCbx()
        {
            foreach (var obj in juego.stage.objects)
            {
                cmbxObjets.Items.Add(obj.Key);
            }
            
        }

        private void cmbxParts_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbxFaces.SelectedItem = null;
            cmbxFaces.Items.Clear();
            //cmbxParts.SelectedItem = null;
            //cmbxParts.Items.Clear();

            foreach (var faces in juego.stage.getFigure(cmbxObjets.SelectedItem.ToString()).GetPart(cmbxParts.SelectedItem.ToString()).GetListFaces())
            {
                cmbxFaces.Items.Add(faces.Key);
            }
        }

        private void inptPosX_ValueChanged(object sender, EventArgs e)
        {
            float posx = (float)inptPosX.Value;
            
            juego.stage.getFigure(cmbxObjets.SelectedItem.ToString()).traslate(posx,0,0);
        }
    }
}
