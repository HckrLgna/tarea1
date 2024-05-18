using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OpenTK;
using OpenTK.Graphics.OpenGL;

using Proyecto1;

namespace Proyecto1_01
{
    public class Face
    {
        public Dictionary<string, Coordinate> list_coordinates;
        public Transformation Transformations;
        public Color color;
        [JsonIgnore]
        public Coordinate center { get; set; }
        public Face()
        {
            this.list_coordinates = new Dictionary<string, Coordinate>();
            this.color = new Color();
            this.center = new Coordinate();
            this.Transformations = new Transformation();
        }
        public Face(Dictionary<string, Coordinate> list_points, Color color, Coordinate center) {
            this.list_coordinates = list_points;
            this.color = color;
            this.center = center;
            Transformations = new Transformation();
        }
        public void Draw()
        {
            PrimitiveType primitiveType = PrimitiveType.Quads;
            GL.Begin(primitiveType);
            GL.Color3(color); //gray
            foreach (var item in list_coordinates)
            {
                Coordinate vertexToRender = (item.Value) * Transformations.TransformationMatrix;
                GL.Vertex3(vertexToRender);
            }
            GL.End();
            GL.Flush();
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
        public void Traslate(float x, float y,  float z)
        {
            Transformations.Traslation *= Matrix4.CreateTranslation(x, y, z);
        }
        public void Rotate( float angleX, float angleY, float angleZ)
        {
            angleX = MathHelper.DegreesToRadians(angleX);
            angleY = MathHelper.DegreesToRadians(angleY);
            angleZ = MathHelper.DegreesToRadians(angleZ);
            Transformations.Rotation *= Matrix4.CreateRotationX(angleX) * Matrix4.CreateRotationY(angleY) *
                        Matrix4.CreateRotationZ(angleZ);

            foreach (var vertex in list_coordinates)
                vertex.Value.Set(vertex.Value.Get() * Transformations.Rotation);
        }
        public void Escalate(float x, float y, float z)
        {
            Transformations.Scaling *= Matrix4.CreateScale(x, y, z);
        }

        public void SetRotation(float angleX, float angleY, float angleZ, bool self)
        {
            angleX = MathHelper.DegreesToRadians(angleX);
            angleY = MathHelper.DegreesToRadians(angleY);
            angleZ = MathHelper.DegreesToRadians(angleZ);

            Transformations.Rotation = Matrix4.CreateRotationX(angleX) * Matrix4.CreateRotationY(angleY) *
                       Matrix4.CreateRotationZ(angleZ);

            Transformations.SetTransformation(self);
        }
        public void SetTraslation(float x, float y, float z)
        {
            // Transformations.Traslation = new Vertex(x, y, z);
            Transformations.Traslation = Matrix4.CreateTranslation(x, y, z);
            Transformations.SetTransformation();
        }
        public void SetTraslation(Coordinate position)
        {
            SetTraslation(position.X, position.Y, position.Z);
            // Transformations.Traslation = position;
        }

        public void SetScale(float x, float y, float z)
        {
            Transformations.Scaling = Matrix4.CreateScale(x, y, z);
            Transformations.SetScaleTransformation();
        }
        public void SetScale(Coordinate scale)
        {
            Transformations.Scaling = Matrix4.CreateScale(scale);
            Transformations.SetTransformation();
        }

    }

}
