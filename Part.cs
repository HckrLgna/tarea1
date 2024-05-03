using OpenTK;
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
        public Transformation Transformations;

        public Part(Dictionary<string, Face>list_faces, Coordinate origin)
        {
            this.list_faces = list_faces;
            this.center = origin;
            this.Transformations = new Transformation(origin);

        }
        public Part(Dictionary<string, Face> list_faces)
        {
            this.list_faces = list_faces;
            this.center = new Coordinate();
            this.Transformations = new Transformation();
        }
        public Part()
        {
            this.list_faces = new Dictionary<string, Face>();
            this.center = new Coordinate();
            this.Transformations = new Transformation();
        }
        public Dictionary<string, Face> GetListFaces()
        {
            return this.list_faces;
        }
        public Face GetFace(string key) {
            return this.list_faces[key];
        }
        public void setCenter(Coordinate newCenter)
        {
            this.center = newCenter;
            foreach (var face in list_faces)
            {
                face.Value.center = center;
            }

        }
        public void draw()
        {
            foreach (var item in list_faces)
            {
                item.Value.Draw();
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
        public void Rotate( float x, float y, float z)
        {
            foreach (var item in list_faces.Values)
            {
                item.Rotate(x, y, z);
            }
        }
        public void Traslate(float x, float y, float z)
        {
            // Actualiza las coordenadas de los vértices de todas las caras
            foreach (var face in list_faces.Values)
            {
                face.Traslate(x, y, z);
            }
        }
        public void Escalate(float x, float y, float z)
        {
            foreach (var item in list_faces.Values)
            {
                item.Escalate(x, y, z);
            }
        }

        public void SetRotation(float angleX, float angleY, float angleZ, bool self)
        {
            bool isLoaded = false;
            foreach (var face in list_faces.Values)
            {
                var formerCenter = face.Transformations.Center.Inverted();
                face.Transformations.TransformationMatrix *= formerCenter;
                face.SetRotation(angleX, angleY, angleZ, self);
                if (!isLoaded)
                {
                    Transformations.Rotation = face.Transformations.Rotation;
                    isLoaded = true;
                }
            }
        }
        public void SetTraslation(float x, float y, float z)
        {
            bool isLoaded = false;
            foreach (var face in list_faces.Values)
            {
                face.SetTraslation(x, y, z);
                face.Transformations.SetTransformation();

                if (!isLoaded)
                {
                    Transformations.Traslation = face.Transformations.Traslation;
                    isLoaded = true;
                }
            }
        }
        public void SetTraslation(Coordinate position)
        {
            bool isLoaded = false;
            foreach (var face in list_faces)
            {
                face.Value.SetTraslation(position);
                face.Value.Transformations.SetTransformation();

                if (!isLoaded)
                {
                    Transformations.Traslation = face.Value.Transformations.Traslation;
                    isLoaded = true;
                }
            }
        }
        public void SetScale(float x, float y, float z)
        {
            bool isLoaded = false;
            foreach (var face in list_faces.Values)
            {
                face.SetScale(x, y, z);
                Transformations.SetScaleTransformation();

                if (!isLoaded)
                {
                    Transformations.Scaling = face.Transformations.Scaling;
                    isLoaded = true;
                }

            }
        }
        public void SetScale(Coordinate position)
        {
            bool isLoaded = false;
            foreach (var face in list_faces)
            {
                face.Value.SetScale(position);
                Transformations.SetScaleTransformation();

                if (!isLoaded)
                {
                    Transformations.Scaling = face.Value.Transformations.Scaling;
                    isLoaded = true;
                }
            }
        }
    }
}
