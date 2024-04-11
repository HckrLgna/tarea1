using Proyecto1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_01
{
    public class Figure
    {
        private Dictionary<string, Face> list_faces;
        private Coordinate center;

        public Figure(Coordinate center)
        {
            this.center = center;
            list_faces = new Dictionary<string, Face>();
        }
        public Figure(Coordinate center, Dictionary<string, Face> list_faces)
        {
            this.center = center;
            this.list_faces = list_faces;
             
        }
        public void setCenter(Coordinate newCenter)
        {
            this.center = newCenter;
            foreach(var face in list_faces)
            {
                face.Value.center = center;
            }

        }
        public void draw()
        {
            foreach (var item in list_faces)
            {
                item.Value.Draw(center);
            }
        }
        public void addFace(string name, Face face)
        {
            list_faces.Add(name, face);
        }
        public void removeFace(string name)
        {
            list_faces.Remove(name);
        }
    }
}
