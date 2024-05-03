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
using OpenTK;


namespace Proyecto1_01
{
    public class Figure
    {
        public Dictionary<string, Part> list_parts;
        public Coordinate center;
        public Transformation Transformations { get; set; }
        public Figure()
        {
            Transformations = new Transformation();
            list_parts = new Dictionary<string, Part>();
        }
        public Figure(Coordinate center, Dictionary<string, Part> list_parts)
        {
            this.list_parts = list_parts;
            Transformations = new Transformation(center);
        }
        public Dictionary<string, Part> GetListParts()
        {
            return this.list_parts;
        }
        public Part GetPart(string name)
        {
            return list_parts[name];
        }
        public void setFigure(Figure figure)
        {
            this.center = figure.center;
            this.list_parts = figure.list_parts;
        }
        public void SetCenter(Coordinate newCenter)
        {
            Matrix4 CenterMatrix = Matrix4.CreateTranslation(newCenter);
            Transformations.Center = CenterMatrix;

            this.center = newCenter;
            foreach(var part in list_parts.Values)
            {
                part.Transformations.Center = CenterMatrix;
                part.Transformations.SetTransformation(true);
            }

        }
        public Matrix4 GetCenter()
        {
            return Transformations.Center;
        }

        public void draw()
        {
            foreach (var item in list_parts)
            {
                item.Value.draw();
            }
        }
        public void Traslate(float x,float y, float z)
        {
            
            foreach (var item in list_parts.Values)
            {
                item.Traslate(x,y,z);
            }

        }
        public void Rotate(  float x, float y,float z)
        {
            foreach (var item in list_parts.Values)
            {
                item.Rotate( x, y, z);
            }
        }

        public void Escalate(float x, float y, float z)
        {
            foreach (var item in list_parts.Values)
            {
                item.Escalate(x, y, z);
            }
        }
        public void SetRotation(float angleX, float angleY, float angleZ, bool self)
        {
            bool isLoaded = false;
            foreach (var part in list_parts.Values)
            {
                var formerCenter = part.Transformations.Center.Inverted();
                part.Transformations.TransformationMatrix *= formerCenter;
                part.SetRotation(angleX, angleY, angleZ, self);
                if (!isLoaded)
                {
                    Transformations.Rotation = part.Transformations.Rotation;
                    isLoaded = true;
                }
            }
        }
        public void SetTraslation(float x, float y, float z)
        {
            bool isLoaded = false;
            foreach (var part in list_parts.Values)
            {
                var formerCenter = part.Transformations.Center.Inverted();
                part.Transformations.TransformationMatrix *= formerCenter;
                part.SetTraslation(x, y, z);

                if (!isLoaded)
                {
                    Transformations.Traslation = part.Transformations.Traslation;
                    isLoaded = true;
                }
            }
        }

        public void SetTraslation(Coordinate position)
        {
            bool isLoaded = false;
            foreach (var part in list_parts)
            {
                part.Value.SetTraslation(position);
                part.Value.Transformations.SetTransformation();

                if (!isLoaded)
                {
                    Transformations.Traslation = part.Value.Transformations.Traslation;
                    isLoaded = true;
                }
            }
        }
        public void SetScale(float x, float y, float z)
        {
            bool isLoaded = false;
            foreach (var part in list_parts.Values)
            {
                part.SetScale(x, y, z);
                Transformations.SetScaleTransformation();

                if (!isLoaded)
                {
                    Transformations.Scaling = part.Transformations.Scaling;
                    isLoaded = true;
                }

            }
        }
        public void SetScale(Coordinate position)
        {
            bool isLoaded = false;
            foreach (var parts in list_parts)
            {
                parts.Value.SetScale(position);
                Transformations.SetScaleTransformation();

                if (!isLoaded)
                {
                    Transformations.Scaling = parts.Value.Transformations.Scaling;
                    isLoaded = true;
                }
            }
        }
    }
}
