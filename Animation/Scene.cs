using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_01.Animation
{
    public  class Scene
    {
        [JsonProperty] string name { get; set; }
        [JsonProperty] public List<Action> list_actions { get; set; }
        [JsonProperty] long durationTime;
        public Scene() {
            this.name = "";
            this.list_actions = new List<Action>();
            this.durationTime = 0;
        }

        public Scene(string name, List<Action> list_action)
        {
            this.name = name;
            this.list_actions = list_action;
            this.durationTime = calculateDurationTotal(list_action);
        }
        public int GetTotalActions()
        {
            return this.list_actions.Count;
        }
        private long calculateDurationTotal(List<Action> list_action)
        {
            long total = 0;
            foreach (var item in list_action)
            {
                total += (item.timeF - item.timeI);
            }
            return total;
        }
        public Action getAction(int i)
        {
            return list_actions.ElementAt(i);
        }
    }
}
