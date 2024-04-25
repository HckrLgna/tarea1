using Proyecto1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_01
{
    public class Part
    {
        public Dictionary<string, Face> list_faces;
        public Coordinate center;

        public Part(Dictionary<string, Face>list_faces, Coordinate origin)
        {
            this.list_faces = list_faces;
            this.center = origin;
        }
        public Part(Dictionary<string, Face> list_faces)
        {
            this.list_faces = list_faces;
            this.center = new Coordinate();
        }
        public Part()
        {
            this.list_faces = new Dictionary<string, Face>();
            this.center = new Coordinate();
        }
        public void setCenter(Coordinate newCenter)
        {
            this.center = newCenter;
            foreach (var face in list_faces)
            {
                face.Value.center = center;
            }

        }
        public void draw(Coordinate center)
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
