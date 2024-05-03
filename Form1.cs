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
        float trasladarx;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            juego = new Game(800, 600, "Demo OpenTK");
            this.trasladarx = 0;
             
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
            catch (Exception ex)
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
            if( cmbxObjets.SelectedItem.ToString() != "Escenario")
            {
                foreach (var parts in juego.stage.getFigure(cmbxObjets.SelectedItem.ToString()).GetListParts())
                {
                    cmbxParts.Items.Add(parts.Key);

                }
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
            

            foreach (var faces in juego.stage.getFigure(cmbxObjets.SelectedItem.ToString()).GetPart(cmbxParts.SelectedItem.ToString()).GetListFaces())
            {
                cmbxFaces.Items.Add(faces.Key);
            }
        }

         
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void XSlider_Scroll(object sender, EventArgs e)
        {
            SliderHandler();
        }
        private void SliderHandler()
        {
            if (XSlider != null && YSlider != null && ZSlider != null)
            {
                string mode = (string)cmbxOperation.SelectedItem;
                string objectString = (string)cmbxObjets.SelectedItem;
                string partString = (string)cmbxParts.SelectedItem;
                string faceString = (string)cmbxFaces.SelectedItem;

                if (mode == "Rotate")
                {
                    if (objectString == "Escenario")
                    {
                        juego.stage.SetRotation((float)XSlider.Value, (float)YSlider.Value,
                            (float)ZSlider.Value);
                    }
                    else
                    {
                        Figure objectToProcess = juego.stage.getFigure(objectString);
                        if (partString == "Objeto")
                        {
                            objectToProcess.SetRotation((float)XSlider.Value, (float)YSlider.Value,
                                (float)ZSlider.Value, true);
                            return;
                        }

                        Part partToProcess = objectToProcess.GetPart(partString);
                        partToProcess.SetRotation((float)XSlider.Value, (float)YSlider.Value,
                            (float)ZSlider.Value, true);
                    }

                    return;
                }

                Coordinate coordinates = new Coordinate((float)XSlider.Value, (float)YSlider.Value,
                    (float)ZSlider.Value);

                if (mode == "Traslate")
                {
                    if (objectString == "Escenario")
                    {
                        juego.stage.SetTraslation(coordinates);
                    }
                    else
                    {
                        Figure objectToProcess = juego.stage.getFigure(objectString);
                        if (partString == "Objeto")
                        {
                            objectToProcess.SetTraslation(coordinates);
                            return;
                        }

                        Part partToProcess = objectToProcess.GetPart(partString);
                        partToProcess.SetTraslation(coordinates);
                    }

                    return;
                }

                if (mode == "Escale")
                {
                    if (objectString == "Escenario")
                    {
                        juego.stage.SetScale(coordinates);
                    }
                    else
                    {
                        Figure objectToProcess = juego.stage.getFigure(objectString);
                        if (partString == "Objeto")
                        {
                            objectToProcess.SetScale(coordinates);
                            return;
                        }

                        Part partToProcess = objectToProcess.GetPart(partString);
                        partToProcess.SetScale(coordinates);
                    }
                }
            }
        }

    }
}
