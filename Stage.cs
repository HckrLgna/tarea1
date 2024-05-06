using Proyecto1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_01
{
    public class Stage
    {
        public Dictionary<string, Figure> objects;
        public Coordinate center;
        public Transformation Transformations { get; set; }

        public Stage(Dictionary<string, Figure> objects, Coordinate center, Transformation transformations)
        {
            this.objects = objects;
            transformations = new Transformation(center);
            SetCenter(center);
        }
        public Stage()
        {
            objects = new Dictionary<string, Figure>();
            center = new Coordinate();
            Transformations = new Transformation();
        }
        public void SetCenter(Coordinate center)
        {
            foreach (var object3D in objects.Values)
            {
                Coordinate formerCenter = Coordinate.Vector4ToVertex(object3D.GetCenter().Row3);
                object3D.SetCenter(center + formerCenter);
            }
        }
        public void draw()
        {
            foreach (var figure in objects.Values)
            {
                figure.draw();
            }
        }
        public void setStage(Stage stage)
        {
            this.objects = stage.objects;
            this.center = stage.center;
        }
        public void addFigure(string name, Figure figure)
        {
            objects.Add(name, figure);  
        }
        public void removeFigure(string name) { 
            objects.Remove(name);
        }
        public Figure getFigure(string name)
        {
            try
            {
                return objects[name];
            }catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
            
        }
        public void Rotate(float x, float y, float z)
        {
            foreach (var item in objects.Values)
            {
                item.Rotate(x,y, z);
            }
        }

        public void SetRotation(float angleX, float angleY, float angleZ)
        {
            bool isLoaded = false;
            foreach (var object3D in objects.Values)
            {

                object3D.SetRotation(angleX, angleY, angleZ, false);
                if (!isLoaded)
                {
                    Transformations.Rotation = object3D.Transformations.Rotation;
                    isLoaded = true;
                }
            }
        }

        public void Traslate(float x, float y, float z)
        {
            foreach (var item in objects.Values)
            {
                item.Traslate(x,y,z);
            }
        }

        public void SetTraslation(float x, float y, float z)
        {
            bool isLoaded = false;
            foreach (var object3D in objects.Values)
            {
                object3D.SetTraslation(x, y, z);
                object3D.Transformations.SetTransformation();

                if (!isLoaded)
                {
                    Transformations.Traslation = object3D.Transformations.Traslation;
                    isLoaded = true;
                }
            }
        }
        public void SetTraslation(Coordinate position)
        {
            bool isLoaded = false;
            foreach (var object3D in objects)
            {
                object3D.Value.SetTraslation(position);
                object3D.Value.Transformations.SetTransformation();

                if (!isLoaded)
                {
                    Transformations.Traslation = object3D.Value.Transformations.Traslation;
                    isLoaded = true;
                }
            }
        }
        public void Escalate(float x, float y, float z)
        {
            foreach (var item in objects.Values)
            {
                item.Escalate(x,y,z);
            }
        }

        public void SetScale(float x, float y, float z)
        {
            bool isLoaded = false;
            foreach (var object3D in objects.Values)
            {
                object3D.SetScale(x, y, z);
                Transformations.SetScaleTransformation();

                if (!isLoaded)
                {
                    Transformations.Scaling = object3D.Transformations.Scaling;
                    isLoaded = true;
                }
            }
        }
        public void SetScale(Coordinate position)
        {
            bool isLoaded = false;
            foreach (var object3D in objects)
            {
                object3D.Value.SetScale(position);
                Transformations.SetScaleTransformation();

                if (!isLoaded)
                {
                    Transformations.Scaling = object3D.Value.Transformations.Scaling;
                    isLoaded = true;
                }
            }
        }
    }
}
