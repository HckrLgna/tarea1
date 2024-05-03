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
        public Stage()
        {
            objects = new Dictionary<string, Figure>();
            center = new Coordinate();
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
        public void Traslate(float x, float y, float z)
        {
            foreach (var item in objects.Values)
            {
                item.Traslate(x,y,z);
            }
        }
        public void Escalate(float x, float y, float z)
        {
            foreach (var item in objects.Values)
            {
                item.Escalate(x,y,z);
            }
        }
    }
}
