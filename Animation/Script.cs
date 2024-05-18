using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_01.Animation
{
    public class Script
    {
        public List<Scene> list_scenes { get; set; }
        public Script()
        {
            this.list_scenes = new List<Scene>();
        }
        public Script(List<Scene> list_scenes)
        {
            this.list_scenes = list_scenes;
        }

        public void AddScene(Scene scene)
        {
            this.list_scenes.Add(scene);
        }
        public void SetListScenes(List<Scene> list_scenes)
        {
            this.list_scenes=list_scenes;
        }
        public int GetCantidadScences()
        {
            return this.list_scenes.Count;
        }
    }
   
}
