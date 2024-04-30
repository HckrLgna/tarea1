using Proyecto1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Globalization;


namespace Proyecto1_01
{
    public class Figure
    {
        public Dictionary<string, Part> list_parts;
        public Coordinate center;

        public Figure()
        {
            this.center = new Coordinate();
            list_parts = new Dictionary<string, Part>();
        }
        public Figure(Coordinate center, Dictionary<string, Part> list_parts)
        {
            this.center = center;
            this.list_parts = list_parts;
             
        }
        public void setFigure(Figure figure)
        {
            this.center = figure.center;
            this.list_parts = figure.list_parts;
        }
        public void setCenter(Coordinate newCenter)
        {
            this.center = newCenter;
            foreach(var face in list_parts)
            {
                face.Value.center = center;
            }

        }
        public void draw()
        {
            foreach (var item in list_parts)
            {
                item.Value.draw(center);
            }
        }
        public void addPart(string name, Part part)
        {
            list_parts.Add(name, part);
        }
        public void removePart(string name)
        {
            list_parts.Remove(name);
        }
        public void saveToFile(string path)
        {
            string jsonOutput = JsonConvert.SerializeObject(this);
            File.WriteAllText(path, jsonOutput);
     
        }
        public static Figure loadFromJson(string path)
        {
            string filePath = File.ReadAllText(path);
            Console.WriteLine(filePath);
            return JsonConvert.DeserializeObject<Figure>(filePath);
        }
        
    }
}
