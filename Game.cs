using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Graphics.OpenGL;


namespace Televisor
{
    internal class Game : GameWindow
    {
        private int vertexBufferHandler;
        private int shaderProgramHandler;
        private int vertexArrayHandle;

        public Game(int width = 1280, int height = 760, string title = "TV3D")
           : base(GameWindowSettings.Default, new NativeWindowSettings
           {
               Title = title,
               Size = new Vector2i(width, height),
               WindowBorder = WindowBorder.Fixed,
               StartVisible = false,
               StartFocused = true,
               API = ContextAPI.OpenGL,
               Profile = ContextProfile.Core,
               APIVersion = new Version(3, 3)
           })
        {
            this.CenterWindow(new Vector2i(800, 600));
        }
        protected override void OnResize(ResizeEventArgs e)
        {
            GL.Viewport(0, 0, e.Width, e.Height);
            base.OnResize(e);
        }

        protected override void OnLoad()
        {
            GL.ClearColor(new Color4(0.3f, 0.4f, 0.5f, 1f));
            float[] vertices = new float[]
            {
                // Pantalla
                -0.5f, 0.5f, 0f,   // Arriba izquierda
                0.5f, 0.5f, 0f,    // Arriba derecha
                -0.5f, -0.5f, 0f,  // Abajo izquierda
                0.5f, -0.5f, 0f,   // Abajo derecha

                // Base
                -0.7f, -0.7f, 0f,  // Esquina superior izquierda
                0.7f, -0.7f, 0f,   // Esquina superior derecha
                -0.7f, -0.8f, 0f,  // Esquina inferior izquierda
                0.7f, -0.8f, 0f    // Esquina inferior derecha
            };

            this.vertexBufferHandler = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, this.vertexBufferHandler);
            GL.BufferData(BufferTarget.ArrayBuffer, vertices.Length * sizeof(float), vertices, BufferUsageHint.StaticDraw);
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);

            this.vertexArrayHandle = GL.GenVertexArray();
            GL.BindVertexArray(this.vertexArrayHandle);

            GL.BindBuffer(BufferTarget.ArrayBuffer, this.vertexBufferHandler);
            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 3 * sizeof(float), 0);
            GL.EnableVertexAttribArray(0);

            GL.BindVertexArray(0);

            string vertexShaderCode =
                @"
                 #version 330 core

                 layout(location = 0) in vec3 aPosition;

                 void main(){
                    gl_Position = vec4(aPosition, 1f);
                 }";

            string pixelShaderCode =
                @"
                 #version 330 core

                 out vec4 pixelColor;

                 void main(){
                    pixelColor = vec4(0.8f, 0.8f, 0.8f, 1f); // Color gris claro
                 }
                 ";

            int vertexShaderHandle = GL.CreateShader(ShaderType.VertexShader);
            GL.ShaderSource(vertexShaderHandle, vertexShaderCode);
            GL.CompileShader(vertexShaderHandle);   

            int pixelShaderObject = GL.CreateShader(ShaderType.FragmentShader);
            GL.ShaderSource(pixelShaderObject, pixelShaderCode);
            GL.CompileShader(pixelShaderObject);

            this.shaderProgramHandler = GL.CreateProgram();

            GL.AttachShader(this.shaderProgramHandler, vertexShaderHandle);
            GL.AttachShader(this.shaderProgramHandler, pixelShaderObject);

            GL.LinkProgram(this.shaderProgramHandler);

            GL.DetachShader(this.shaderProgramHandler, vertexShaderHandle);
            GL.DetachShader(this.shaderProgramHandler, pixelShaderObject);

            GL.DeleteShader(vertexShaderHandle);
            GL.DeleteShader(pixelShaderObject);

            base.OnLoad();
        }

        protected override void OnUnload()
        {
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            GL.DeleteBuffer(this.vertexBufferHandler);

            GL.UseProgram(0);
            GL.DeleteProgram(this.shaderProgramHandler);

            base.OnUnload();
        }
        protected override void OnUpdateFrame(FrameEventArgs args)
        {
            base.OnUpdateFrame(args);
        }

        protected override void OnRenderFrame(FrameEventArgs args)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.UseProgram(this.shaderProgramHandler);
            GL.BindVertexArray(this.vertexArrayHandle);

            GL.DrawArrays(PrimitiveType.TriangleStrip, 0, 4); // Pantalla
            GL.DrawArrays(PrimitiveType.TriangleStrip, 4, 4); //Base

            this.SwapBuffers();

            base.OnRenderFrame(args);
        }
    }
}
