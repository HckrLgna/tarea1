using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;

using Proyecto1;

namespace Proyecto1_01
{
    public class Face
    {
        public Dictionary<string, Coordinate> list_coordinates;
        public Color color;
        public Coordinate center {  get; set; }
        public Face()
        {
            this.list_coordinates = new Dictionary<string, Coordinate>();
            this.color = new Color();
        }
        public Face(Dictionary<string, Coordinate> list_points, Color color) {
            this.list_coordinates = list_points;
            this.color = color;
            
        }
        public Face(Dictionary<string, Coordinate> list_coordinates, Coordinate center)
        {
            this.list_coordinates = list_coordinates;
            this.center = center;
        }

        public Face(Face face)
        {
            this.list_coordinates = face.list_coordinates;
            this.color = face.color;
        }
        public void Draw(Coordinate center)
        {
                
            PrimitiveType primitiveType = PrimitiveType.Quads;

            GL.Begin(primitiveType);
            GL.Color3(color); //gray
            foreach (var item in list_coordinates)
            {
                GL.Vertex3(item.Value.x +center.x  , item.Value.y + center.y , item.Value.z + center.z);
            }

            GL.End();
        }
        public void setColor(Color color)
        {
            this.color = color;
        }

        public void addCoordinate(string name, Coordinate coord)
        {
            list_coordinates.Add(name, coord);
        }
        public void removeCoordinate(string name)
        {
            list_coordinates.Remove(name);
        }
        public Dictionary<string, Coordinate> getListCoordinates()
        {
            return list_coordinates;
        }
        public void displace(float x, float y,  float z)
        {
            foreach (var item in list_coordinates)
            {
                item.Value.acumular(x, y, z);
            }
        }
        public void reduce(float x, float y, float z)
        {
            foreach (var item in list_coordinates)
            {
                item.Value.multiplicar(x, y, z);
            }
        }
    }

}
