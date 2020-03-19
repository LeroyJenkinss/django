using CinemaProject.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Org.BouncyCastle.Utilities;

namespace CinemaProject.Model.Repository
{
    public class ShowTimeRepository 
    {
        public List<ShowTimeView> GetAll()
        {
            var pathToJsonFile = GetPathToJson();

            List<ShowTimeView> items;

            using (StreamReader r = new StreamReader(pathToJsonFile))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<ShowTimeView>>(json);
            }

            return items;
        }

        public int[] allShowTimes(int Id_Movietime)
        {
            
                var allTimes = GetAll();
            int[] everyTime = new int[30];
            var json = JsonConvert.SerializeObject(allTimes);

            everyTime = allTimes.Select(i => i.Id_Movietime).ToArray();

            

            var pathToJsonFile = GetPathToJson();
            File.WriteAllText(pathToJsonFile, json);
            return everyTime;
        }

      
        public string GetPathToJson()
        {
            string workingDirectory = Environment.CurrentDirectory;
            var pathToJsonFile = Directory.GetParent(workingDirectory).Parent.FullName + @"\Data\AllShowtimes.json";

            return pathToJsonFile;
        }
    }



}
