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
        public void loadFromObj(string path, Coordinate center)
        {
            List<Coordinate> vertex = new List<Coordinate>();
            Dictionary<string, Face> faces = new Dictionary<string, Face>();
            Dictionary<string, Part> parts = new Dictionary<string, Part>();

            using (StreamReader reader = new StreamReader(path))
            {
                int faceCounter = 0;
                int partCounter = 0;
                while (!reader.EndOfStream)
                {
                    List<string> words = new List<string>(reader.ReadLine().ToLower().Split(' '));
                    words.RemoveAll(s => s == string.Empty);
                    if(words.Count == 0)
                        continue;
                    
                    string select = words[0];
                    words.RemoveAt(0);
                    switch(select)
                    {
                        case "c":
                            vertex.Add(new Coordinate(float.Parse(words[0], CultureInfo.InvariantCulture), float.Parse(words[1]), float.Parse(words[2])));

                            break;
                        case "f":
                            Dictionary<string, Coordinate> faceVertices= new Dictionary<string, Coordinate>();
                            int key = 0;
                            foreach (string item in words)
                            {
                                if (item.Length == 0)
                                    continue;
                                string [] compas = item.Split('/');
                                int index = int.Parse(compas[0])-1;
                                faceVertices.Add(key.ToString(), new Coordinate(vertex[index].x, vertex[index].y, vertex[index].z));

                                key++;
    
                            }
                            faces.Add(faceCounter.ToString(), new Face(faceVertices,center));
                            break;
                        case "list_parts":
                            Console.WriteLine("partes");
                            break;

                    }
                    faceCounter++;
                }
                list_parts = parts;
                center = center;
                setCenter(center);
            }

        }

        public void serializer(string path)
        {
            // Read the JSON file into a string
            string jsonString = File.ReadAllText(path);

            // Deserialize the JSON string into a JObject
            JObject jsonObject = JObject.Parse(jsonString);

            // Extract the necessary properties from the JObject
            JToken mainToken = jsonObject["p"]["1"];
            Part mainPart = mainToken.ToObject<Part>();

            // Perform operations based on the data
            foreach (var part in mainPart.list_faces)
            {
                Console.WriteLine($"Part: {part.ToString()}");
                foreach (var face in part.Value.list_coordinates)
                {
                    Console.WriteLine($"  Face: {face.ToString()}");
                    
                }
            }
        }
    }
}
