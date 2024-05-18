﻿using Proyecto1;
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
            addItemsCbx();

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
                juego.JsonToObj(fileNameWithoutExtension, filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string filePath="";
            saveFileDialog1.Filter = "Archivos JSON (*.json)|*.json"; // Filtro para mostrar solo archivos JSON
            saveFileDialog1.Title = "Guardar archivo JSON"; // Título del cuadro de diálogo
            saveFileDialog1.FileName = "archivo"; // Nombre predeterminado del archivo
            saveFileDialog1.DefaultExt = ".json"; // Extensión predeterminada

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog1.FileName;
            }

            Console.WriteLine("Ruta del archivo: " + filePath);
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
            if ( cmbxObjets.SelectedItem.ToString() != "Escenario")
            {
                cmbxParts.Enabled = true; cmbxParts.SelectedIndex = 0;
                
                cmbxParts.Items.Clear();
                cmbxParts.Items.Add("Objeto");
                if (cmbxParts.Items.Count <= 1)
                {         
                    foreach (var parts in juego.stage.getFigure(cmbxObjets.SelectedItem.ToString()).GetListParts())
                    {
                        cmbxParts.Items.Add(parts.Key);

                    }
                }
                 

            }
            else
            {
                cmbxParts.Enabled = false;
                cmbxFaces.Enabled = false;
            }
            cleanCursor();
        }

        private void cleanCursor()
        {
            this.XSlider.Value = 0;
            this.YSlider.Value = 0;
            this.ZSlider.Value = 0;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void addItemsCbx()
        {
            Console.WriteLine("uso add itemcbx");
            cmbxObjets.Items.Clear();
            cmbxObjets.Items.Add("Escenario");
            foreach (var obj in juego.stage.objects)
            {
                cmbxObjets.Items.Add(obj.Key);
            }
            
        }

        private void cmbxParts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbxParts.SelectedItem.ToString() != "Objeto")
            {
                cmbxFaces.Enabled=true; cmbxFaces.SelectedIndex = 0;
                cmbxFaces.Items.Clear();
                cmbxFaces.Items.Add("Parte");
                if ( cmbxFaces.Items.Count <= 1)
                {
                    
                    foreach (var faces in juego.stage.getFigure(cmbxObjets.SelectedItem.ToString()).GetPart(cmbxParts.SelectedItem.ToString()).GetListFaces())
                    {
                        cmbxFaces.Items.Add(faces.Key);
                    }
                }
                
            }
            else
            {
                cmbxFaces.Enabled=false;
            }
            cleanCursor();
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

                string objectString = cmbxObjets.SelectedItem!=null ? cmbxObjets.SelectedItem.ToString() : "Escenario";
                string partString = cmbxParts.SelectedItem!=null ? cmbxParts.SelectedItem.ToString(): "Objeto";
                string faceString = cmbxFaces.SelectedItem!=null ? cmbxFaces.SelectedItem.ToString(): "Parte";
                float xSlider = XSlider.Value / 100f;
                float ySlider = YSlider.Value / 100f;
                float zSlider = ZSlider.Value / 100f;
                if (mode == "Rotate")
                {
                    if (objectString == "Escenario")
                    {
                        juego.stage.SetRotation(xSlider, ySlider,
                            zSlider);
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
                        else
                        {
                            Part partToProcess = objectToProcess.GetPart(partString);
                            if ( faceString == "Parte")
                            {
                                partToProcess.SetRotation((float)XSlider.Value, (float)YSlider.Value,(float)ZSlider.Value, true);
                                return;
                            }
                            Console.WriteLine("face rotate");
                            Face faceToProcess = partToProcess.GetFace(faceString);
                            faceToProcess.SetRotation((float)XSlider.Value, (float)YSlider.Value, (float)ZSlider.Value, true);
                        }

                        
                    }

                    return;
                }

                Coordinate coordinates = new Coordinate(xSlider, ySlider,zSlider);

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
                        else
                        {
                            Part partToProcess = objectToProcess.GetPart(partString);
                            if(faceString == "Parte")
                            {
                                partToProcess.SetTraslation(coordinates);
                                return;
                            }
                            Face faceToProcess = partToProcess.GetFace(faceString);
                            faceToProcess.SetTraslation(coordinates);
                        }

                        
                    }

                    return;
                }

                if (mode == "Escale")
                {
                    Console.WriteLine("escale");
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
                        else
                        {
                            Part partToProcess = objectToProcess.GetPart(partString);
                            if(faceString == "Parte")
                            {
                                partToProcess.SetScale(coordinates);
                                return;
                            }
                            Face faceToProcess = partToProcess.GetFace(faceString);
                            faceToProcess.SetScale(coordinates);

                        }

                        
                    }
                }
            }
        }

        private void YSlider_Scroll(object sender, EventArgs e)
        {
            SliderHandler();
        }

        private void ZSlider_Scroll(object sender, EventArgs e)
        {
            SliderHandler();
        }

        private void cmbxFaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            cleanCursor();

        }

        private void cmbxOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            cleanCursor();
        }
    }
}
