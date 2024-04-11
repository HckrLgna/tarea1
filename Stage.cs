﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_01
{
    public class Stage
    {
        private Dictionary<string, Figure> objects;
        public Stage()
        {
            objects = new Dictionary<string, Figure>();
        }
        public void draw()
        {
            foreach (var figure in objects.Values)
            {
                figure.draw();
            }
        }
        public void addFigure(string name, Figure figure)
        {
            objects.Add(name, figure);  
        }
        public void removeFigure(string name) { 
            objects.Remove(name);
        }
    }
}