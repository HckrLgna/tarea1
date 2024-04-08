using OpenTK.Graphics.OpenGL;
using Proyecto1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_01
{
    public class Televisor
    {
        public Cubo screen;
        public Cubo support;
        public Cubo base_screen;
        Punto origin_screen;
        Punto origin_support;
        Punto origin_base_screen;
        public float width;
        public float height;
        public float dept;

        public Televisor(Punto punto, float width, float height, float dept) {

            this.width = width; 
            this.height = height;
            this.dept = dept;

            this.origin_screen = punto;
            this.origin_support = new Punto(punto.x,punto.y - (height), punto.z);
            this.origin_base_screen = new Punto (punto.x, punto.y + (this.origin_support.y - (height/4)), punto.z);


            this.screen = new Cubo(origin_screen, width, height, dept);
             

            this.support = new Cubo(origin_support, width/8, height/8, dept);
            

            this.base_screen = new Cubo(origin_base_screen, width/4, height/6, dept);
        }
        public void draw()
        {
            screen.Dibujar();
            screen_window();
            support.Dibujar();
            base_screen.Dibujar();

        }
        private void screen_window()
        {
            PrimitiveType primitiveType = PrimitiveType.Quads;

            GL.Begin(primitiveType);
            GL.Color3(Color.Gray); //gray
            GL.Vertex3((origin_screen.x + 2) - width, origin_screen.y + height - 2, origin_screen.z + dept + 1);
            GL.Vertex3((origin_screen.x - 2) + width, origin_screen.y + height - 2, origin_screen.z + dept + 1);
            GL.Vertex3((origin_screen.x - 2) + width, origin_screen.y - height + 2, origin_screen.z + dept + 1);
            GL.Vertex3((origin_screen.x + 2) - width, origin_screen.y - height + 2, origin_screen.z + dept + 1);
            GL.End();

        }
    }
}
