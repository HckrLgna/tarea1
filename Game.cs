using Newtonsoft.Json;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using Proyecto1_01;
using Proyecto1_01.Extras;
using Proyecto1_01.Utils;
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

        [JsonIgnore]
        public Stage stage;
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
            
            stage = new Stage(new Coordinate(0f,0f,0f));
            stage.addFigure("Speaker1",new Figure(new Coordinate(-17.0f,0.0f,-10.0f), Speaker.getParts() ));
            stage.addFigure("Vase", new Figure(new Coordinate(+17.0f,-10.0f,+20.0f), Vase.getParts()));
            stage.addFigure("Ball", new Figure(new Coordinate(-25.0f,-5.0f,+20.0f), Ball.getParts() ));
            //stage = Serializer.SaveJsonToObj<Stage>("Extras/scenary_changed2.json");
            //stage = Serializer.SaveJsonToObj<Stage>("Extras/scenary.json");
            stage.addFigure("Televisor", Serializer.SaveJsonToObj<Figure>("Extras/Televisor.json") );
            

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

        public void objToJson(string path)
        {
            Console.WriteLine("obj to json stage");
            Serializer.SaveObjToJson(stage, path);
        }
        public void JsonToObj( string path)
        {
            stage.setStage(Serializer.SaveJsonToObj<Stage>(path));
            //stage.addFigure( Serializer.SaveJsonToObj<Figure>(path));
        }
          
    }
}
