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

            origin_screen = punto;

            

            screen = new Cubo(origin_screen, width, height, dept);
             

            support = new Cubo(new Punto(0, -10, 0), width-13, height-8, dept-2);
            

            base_screen = new Cubo(new Punto(0, -14, 0), width-10, height-8, dept-2);
        }
        public void draw()
        {
            GL.Rotate(20, 1, 1, 0);

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
