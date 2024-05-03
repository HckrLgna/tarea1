using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Proyecto1_01.Utils
{
     class Serializer
    {
        public static void SaveObjToJson<T>(T obj, string path)
        {
            try
            {
                string jsonOutput = JsonConvert.SerializeObject(obj);
                File.WriteAllText(path, jsonOutput);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
           
        }
        public static T SaveJsonToObj<T>(string path)
        {
            string filePath = File.ReadAllText(path);
             
            return JsonConvert.DeserializeObject<T>(filePath);
        }
    }
}
