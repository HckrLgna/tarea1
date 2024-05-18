using Proyecto1;
using Proyecto1_01.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proyecto1_01.Animation
{
    public class AnimationController
    {
        public Script script;
        public Thread thread;
        public bool flag;
        public Stage stage;
        int counter = 0;
        int duration;
        public AnimationController()
        {
            this.script = new Script( GetScenes() );
            //this.script.AddScene(Serializer.SaveJsonToObj<Scene>("Extras/Scene.json"));
       //     this.script.SetListScenes(GetScenes());

            this.thread = new Thread(new ThreadStart(play));
            flag = true;
            duration = 10000;
            this.stage = new Stage();
        }
        public void SetStage(Stage stage)
        {
            this.stage=stage;
        }
        public void StartAnimation()
        {
            
            if (flag) { thread.Start(); } else { flag = false; }
        }
        public void play()
        {
            
            int initialTime = Environment.TickCount & Int32.MaxValue;
            int time = Environment.TickCount & Int32.MaxValue;
            int finalTime = time + duration;
            int realTime = 0;
            Scene tempScene = this.script.list_scenes.ElementAt(0);
            Action temAction = tempScene.list_actions.ElementAt(0);
            do
            {
                for (int i=0; i<tempScene.GetTotalActions(); i++)
                {
                    realTime = (Environment.TickCount & Int32.MaxValue) - initialTime;
                    temAction = tempScene.getAction(i) ;
                    if (realTime >= temAction.timeI && realTime <= temAction.timeF) { PlayAction(temAction, realTime); }
                }
                if (realTime >= duration && flag)
                {
                    flag = false;
                    realTime = 0;
                    initialTime = Environment.TickCount & Int32.MaxValue;
                    foreach (Action item in tempScene.list_actions)
                    {
                        item.nextTime = item.timeI;
                    }
                }
                Console.WriteLine("fin de : " + realTime + "de :" + duration);

                while (!flag);
            
            } while (realTime <= duration);
        }
        public void PlayAction(Action action, int realTime)
        {
            if (action.list_actions[0] == 1) //trasladar
            {
                Traslate(action, action.parameters, realTime);
            }
            if (action.list_actions[1] == 1)//rotar
            {
                Rotate(action, action.parameters, realTime);
            }
            if (action.list_actions[2] == 1)//escalate
            {
                Escalate(action, action.parameters, realTime);
            }
        }
        public void Traslate(Action a, List<float> par, int realTime)
        {
            float time = a.timeF - a.timeI;
            
            
            Console.WriteLine("each time : " + time  +" total :" + counter);
            
            if (realTime >= a.nextTime)
            {
                a.nextTime += (long)time;
                Console.WriteLine("---------------------------------------real time : " + realTime + " next time :" + a.nextTime+"------------------------------");
                if (a.object_type == 0)
                {
                    stage.SetTraslation(par[0], par[1], par[2]);
                }
                else if (a.object_type == 1)
                {
                    stage.getFigure(a.list_object_name[0]).SetTraslation(par[0], par[1], par[2]);
                    counter++;
                    Console.Write("----------------traslate: -------------------:" +counter );

                }
                else if (a.object_type == 2)
                {
                    stage.getFigure(a.list_object_name[0]).GetPart(a.list_object_name[1]).SetTraslation(par[0], par[1], par[2]);
                }
            }

        }

        public void Rotate(Action a, List<float> par, int tiempoActual)
        {
            float time = a.timeF - a.timeI;
            //Console.WriteLine(cada);
            //if (tiempoActual % cada == 0 && tiempoActual >= a.tiempoSiguiente)
            if (tiempoActual >= a.nextTime)
            {
                a.nextTime += (long)time;
                //Console.WriteLine(tiempoActual);
                if (a.object_type == 0)
                {
                    stage.SetRotation(par[0], par[1], par[2]);
                }
                else if (a.object_type == 1)
                {
                   stage.getFigure(a.list_object_name[0]).SetRotation(par[0], par[1], par[2], true);
                   Console.Write("Rotate" + a.list_object_name[0].ToString());

                }
                else if (a.object_type == 2)
                {
                    stage.getFigure(a.list_object_name[0]).GetPart(a.list_object_name[1]).SetRotation(par[0], par[1], par[2], true);
                }
                //else if(a.object_type == 3)
                //{
                //    stage.getFigure(a.list_object_name[0]).GetPart(a.list_object_name[1]).GetFace(a.list_object_name[2]).SetRotation(par[0], par[1], par[2],true);
                // }
            }
        }

        public void Escalate(Action a, List<float> par, int tiempoActual)
        {
            float tiempo = a.timeF - a.timeI;
            //Console.WriteLine(cada);
            //if (tiempoActual % cada == 0 && tiempoActual >= a.tiempoSiguiente)
            if (tiempoActual >= a.nextTime)
            {
                a.nextTime += (long)tiempo;
                //Console.WriteLine(tiempoActual);
                if (a.object_type == 0)
                {
                    //Formulario.escenario.Escalar(par[0], par[1], par[2]);
                }
                else if (a.object_type == 1)
                {
                    //Formulario.escenario.GetObjeto(a.nombreObjeto[0]).Escalar(par[0], par[1], par[2]);
                }
                else if (a.object_type == 2)
                {
                    //Formulario.escenario.GetObjeto(a.nombreObjeto[0]).GetCara(a.nombreObjeto[1]).Escalar(par[0], par[1], par[2]);
                }
            }
        }

        public List<Scene> GetScenes()
        {
            List<Scene> list_scenes = new List<Scene>(); //trasladar = 1, rotar = 1, escalar = 1
            List<Action> list_actions = new List<Action>();
            float x = 0;
            float y = 0;
            float z = -5.5f;
            float zt = 0;
            int ti = 0;
            int tf = 0;
            for (int i = 1; i<=40; i++)
            {
                tf += 250;
                x += 1.07f;
                if (i % 5 == 0)
                {
                    z += -10.5f;
                    list_actions.Add(new Action(new List<string>() { "Ball" }, new List<byte>() { 0, 1, 0 }, new List<float>() { 0, 0, z }, ti, tf,1));
                }

                else
                {
                    if(tf > 5700)
                    {
                        y += -0.67f;
                        zt += +0.05f;
                         
                        list_actions.Add(new Action(new List<string>() { "Ball" }, new List<byte>() { 1, 0, 0 }, new List<float>() { x, y, zt }, ti, tf, 1));
                         
                    }
                    else
                    {
                        y += 0.67f;
                        list_actions.Add(new Action(new List<string>() { "Ball" }, new List<byte>() { 1, 0, 0 }, new List<float>() { x, y, zt }, ti, tf, 1));
                    }
                }
                ti = tf;
            }
            Scene scene = new Scene("movment", list_actions);

            list_scenes.Add(scene);
            return list_scenes;
        }
        public void objToJson(string path)
        {
            Serializer.SaveObjToJson<Script>(script, path);
        }
    }
}
