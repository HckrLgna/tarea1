using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using Proyecto1_01;
using Proyecto1_01.Extras;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    public class Game : GameWindow
    {
       
        
        public Stage stage;
        public Figure televisor;

        public Dictionary<string, Part> list_parts_televisor;
        public Dictionary<string, Part> list_parts_speaker;
        public Dictionary<string, Part> list_parts_vase;
        //-----------------------------------------------------------------------------------------------------------------
        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title) {
         
        }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
        }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            GL.ClearColor(Color4.Beige);
            list_parts_televisor = new Dictionary<string, Part>();
            list_parts_speaker = new Dictionary<string, Part>();
            list_parts_vase = new Dictionary<string, Part>();
            loadData();
            stage = new Stage();
            
            televisor = new Figure(new Coordinate(), list_parts_televisor);            
            stage.addFigure("televisor",televisor);
            
        }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnUnload(EventArgs e)
        {
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            //GL.DeleteBuffer(VertexBufferObject);
            base.OnUnload(e);
        }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            //GL.DepthMask(true);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.Enable(EnableCap.DepthTest);
            GL.LoadIdentity();
            //-----------------------
            GL.Rotate(18, 1, 1, 0);
            //GL.Rotate(0.9, 1, 1, 1);
            stage.draw();
            //-----------------------
            Context.SwapBuffers();
            base.OnRenderFrame(e);
        }
        //-----------------------------------------------------------------------------------------------------------------
        protected override void OnResize(EventArgs e)
        {
            float d = 30;
            GL.Viewport(0, 0, Width, Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-d, d, -d, d, -d, d);
            //GL.Frustum(-80, 80, -80, 80, 4, 100);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            base.OnResize(e);
        }

        public void objToJson(string name,string path)
        {
            
            stage.getFigure(name).saveToFile(path);
            
        }
        public void JsonToObj(string name, string path)
        {
            Figure dinamic = new Figure();
            dinamic.setFigure(Figure.loadFromJson(path));
            stage.addFigure(name, dinamic);

            
        }
         private void loadData()
        {
            
            int valorX = 10;
            int valorY = 10;
            int valorZ = 3;
            int distY = 12;
            Dictionary<string, Face> list_faces_televisor = new Dictionary<string, Face>();
             

            Dictionary<string, Coordinate> back_list_points = new Dictionary<string, Coordinate>();
            back_list_points.Add("left-top", new Coordinate(-valorX, +valorY, -valorZ));
            back_list_points.Add("right-top", new Coordinate(+valorX, +valorY, -valorZ));
            back_list_points.Add("right-button", new Coordinate(+valorX, -valorY, -valorZ));
            back_list_points.Add("left-button", new Coordinate(-valorX, -valorY, -valorZ));

            Dictionary<string, Coordinate> front_list_points = new Dictionary<string, Coordinate>();
            front_list_points.Add("left-top", new Coordinate(-valorX, +valorY, +valorZ));
            front_list_points.Add("right-top", new Coordinate(+valorX, +valorY, +valorZ));
            front_list_points.Add("right-button", new Coordinate(+valorX, -valorY, +valorZ));
            front_list_points.Add("left-button", new Coordinate(-valorX, -valorY, +valorZ));

            Dictionary<string, Coordinate> left_list_points = new Dictionary<string, Coordinate>();
            left_list_points.Add("left-top", new Coordinate(+valorX, +valorY, -valorZ));
            left_list_points.Add("right-top", new Coordinate(+valorX, +valorY, +valorZ));
            left_list_points.Add("right-button", new Coordinate(+valorX, -valorY, +valorZ));
            left_list_points.Add("left-button", new Coordinate(+valorX, -valorY, -valorZ));

            Dictionary<string, Coordinate> right_list_points = new Dictionary<string, Coordinate>();
            right_list_points.Add("left-top", new Coordinate(-valorX, +valorY, -valorZ));
            right_list_points.Add("right-top", new Coordinate(-valorX, +valorY, +valorZ));
            right_list_points.Add("right-button", new Coordinate(-valorX, -valorY, +valorZ));
            right_list_points.Add("left-button", new Coordinate(-valorX, -valorY, -valorZ));

            Dictionary<string, Coordinate> top_list_points = new Dictionary<string, Coordinate>();
            top_list_points.Add("left-top", new Coordinate(-valorX, +valorY, -valorZ));
            top_list_points.Add("right-top", new Coordinate(+valorX, +valorY, -valorZ));
            top_list_points.Add("right-button", new Coordinate(+valorX, +valorY, +valorZ));
            top_list_points.Add("left-button", new Coordinate(-valorX, +valorY, +valorZ));

            Dictionary<string, Coordinate> bottom_list_points = new Dictionary<string, Coordinate>();
            bottom_list_points.Add("left-top", new Coordinate(-valorX, -valorY, -valorZ));
            bottom_list_points.Add("right-top", new Coordinate(+valorX, -valorY, -valorZ));
            bottom_list_points.Add("right-button", new Coordinate(+valorX, -valorY, +valorZ));
            bottom_list_points.Add("left-button", new Coordinate(-valorX, -valorY, +valorZ));

            

            list_faces_televisor.Add("back", new Face(back_list_points, Color.Aqua));
            list_faces_televisor.Add("front", new Face(front_list_points, Color.Black));
            list_faces_televisor.Add("left", new Face(left_list_points, Color.Gray));
            list_faces_televisor.Add("right", new Face(right_list_points, Color.Gray));
            list_faces_televisor.Add("top", new Face(top_list_points, Color.DarkGray));
            list_faces_televisor.Add("bottom", new Face(bottom_list_points, Color.Blue));
            valorX = 8;
            valorY = 8;
            valorZ = 4;
            Dictionary<string, Coordinate> screen_list_points = new Dictionary<string, Coordinate>();
            screen_list_points.Add("left-top", new Coordinate(-valorX, +valorY, +valorZ));
            screen_list_points.Add("right-top", new Coordinate(+valorX, +valorY, +valorZ));
            screen_list_points.Add("right-button", new Coordinate(+valorX, -valorY, +valorZ));
            screen_list_points.Add("left-button", new Coordinate(-valorX, -valorY, +valorZ));
            list_faces_televisor.Add("screen", new Face(screen_list_points, Color.LightGray));


            list_parts_televisor.Add("main_part", new Part(list_faces_televisor, new Coordinate()));

            Dictionary<string, Face> list_faces_support = new Dictionary<string, Face>();
            valorX = 2;
            valorY = 2;
            valorZ = 2;

            Dictionary<string, Coordinate> back_support_list_points = new Dictionary<string, Coordinate>();
            back_support_list_points.Add("left-top", new Coordinate(-valorX, +valorY - distY, -valorZ));
            back_support_list_points.Add("right-top", new Coordinate(+valorX, +valorY - distY, -valorZ));
            back_support_list_points.Add("right-button", new Coordinate(+valorX, -valorY - distY, -valorZ));
            back_support_list_points.Add("left-button", new Coordinate(-valorX, -valorY - distY, -valorZ));

            Dictionary<string, Coordinate> front_support_list_points = new Dictionary<string, Coordinate>();
            front_support_list_points.Add("left-top", new Coordinate(-valorX, +valorY - distY, +valorZ));
            front_support_list_points.Add("right-top", new Coordinate(+valorX, +valorY - distY, +valorZ));
            front_support_list_points.Add("right-button", new Coordinate(+valorX, -valorY - distY, +valorZ));
            front_support_list_points.Add("left-button", new Coordinate(-valorX, -valorY - distY, +valorZ));

            Dictionary<string, Coordinate> left_support_list_points = new Dictionary<string, Coordinate>();
            left_support_list_points.Add("left-top", new Coordinate(+valorX, +valorY - distY, -valorZ));
            left_support_list_points.Add("right-top", new Coordinate(+valorX, +valorY - distY, +valorZ));
            left_support_list_points.Add("right-button", new Coordinate(+valorX, -valorY - distY, +valorZ));
            left_support_list_points.Add("left-button", new Coordinate(+valorX, -valorY - distY, -valorZ));

            Dictionary<string, Coordinate> right_support_list_points = new Dictionary<string, Coordinate>();
            right_support_list_points.Add("left-top", new Coordinate(-valorX, +valorY - distY, -valorZ));
            right_support_list_points.Add("right-top", new Coordinate(-valorX, +valorY - distY, +valorZ));
            right_support_list_points.Add("right-button", new Coordinate(-valorX, -valorY - distY, +valorZ));
            right_support_list_points.Add("left-button", new Coordinate(-valorX, -valorY - distY, -valorZ));


            list_faces_support.Add("back_support", new Face(back_support_list_points, Color.Black));
            list_faces_support.Add("front_support", new Face(front_support_list_points, Color.Black));
            list_faces_support.Add("left_support", new Face(left_support_list_points, Color.Black));
            list_faces_support.Add("right_support", new Face(right_support_list_points, Color.Black));

            list_parts_televisor.Add("support_part", new Part(list_faces_support, new Coordinate()));

            Dictionary<string, Face> list_faces_base = new Dictionary<string, Face>();
            valorX = 5;
            valorY = 1;
            valorZ = 2;
            distY = 15;


            Dictionary<string, Coordinate> back_base_list_points = new Dictionary<string, Coordinate>();
            back_base_list_points.Add("left-top", new Coordinate(-valorX, +valorY - distY, -valorZ));
            back_base_list_points.Add("right-top", new Coordinate(+valorX, +valorY - distY, -valorZ));
            back_base_list_points.Add("right-button", new Coordinate(+valorX, -valorY - distY, -valorZ));
            back_base_list_points.Add("left-button", new Coordinate(-valorX, -valorY - distY, -valorZ));

            Dictionary<string, Coordinate> front_base_list_points = new Dictionary<string, Coordinate>();
            front_base_list_points.Add("left-top", new Coordinate(-valorX, +valorY - distY, +valorZ));
            front_base_list_points.Add("right-top", new Coordinate(+valorX, +valorY - distY, +valorZ));
            front_base_list_points.Add("right-button", new Coordinate(+valorX, -valorY - distY, +valorZ));
            front_base_list_points.Add("left-button", new Coordinate(-valorX, -valorY - distY, +valorZ));

            Dictionary<string, Coordinate> left_base_list_points = new Dictionary<string, Coordinate>();
            left_base_list_points.Add("left-top", new Coordinate(+valorX, +valorY - distY, -valorZ));
            left_base_list_points.Add("right-top", new Coordinate(+valorX, +valorY - distY, +valorZ));
            left_base_list_points.Add("right-button", new Coordinate(+valorX, -valorY - distY, +valorZ));
            left_base_list_points.Add("left-button", new Coordinate(+valorX, -valorY - distY, -valorZ));

            Dictionary<string, Coordinate> right_base_list_points = new Dictionary<string, Coordinate>();
            right_base_list_points.Add("left-top", new Coordinate(-valorX, +valorY - distY, -valorZ));
            right_base_list_points.Add("right-top", new Coordinate(-valorX, +valorY - distY, +valorZ));
            right_base_list_points.Add("right-button", new Coordinate(-valorX, -valorY - distY, +valorZ));
            right_base_list_points.Add("left-button", new Coordinate(-valorX, -valorY - distY, -valorZ));


            list_faces_base.Add("back_base", new Face(back_base_list_points, Color.Black));
            list_faces_base.Add("front_base", new Face(front_base_list_points, Color.Black));
            list_faces_base.Add("left_base", new Face(left_base_list_points, Color.Black));
            list_faces_base.Add("right_base", new Face(right_base_list_points, Color.Black));
            list_parts_televisor.Add("base_part", new Part(list_faces_base, new Coordinate()));
        }
       

    }
}
