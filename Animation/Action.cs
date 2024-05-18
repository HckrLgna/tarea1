using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_01.Animation
{
    public class Action
    {
        [JsonProperty] public List<string> list_object_name;
        [JsonProperty] public byte object_type;  //escenario = 0, objeto = 1, cara = 2
        [JsonProperty] public long timeI;
        [JsonProperty] public long timeF;
        [JsonProperty] public long nextTime;
        [JsonProperty] public List<byte> list_actions;  //trasladar = 1, rotar = 1, escalar = 1
        [JsonProperty] public List<float> parameters;
        public Action() { }

        public Action(List<string> objetos, List<byte> acciones, List<float> parametros, long tiempoI, long tiempoF, byte tipoObjeto)
        {
            this.list_object_name = objetos;
            this.list_actions = acciones;
            this.object_type = tipoObjeto;
            this.parameters = parametros;
            this.timeI = this.nextTime = timeI;
            this.timeF = tiempoF;
        }
    }
}
