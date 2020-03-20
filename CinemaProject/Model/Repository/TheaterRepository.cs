using CinemaProject.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace CinemaProject.Model.Repository
{
    public class TheatherRepository {

        public List<TheaterView> Getall() {

            var pathToJsonFile = GetPathToJson();

            List<TheaterView> items;

            using (StreamReader r = new StreamReader(pathToJsonFile))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<TheaterView>>(json);
            }

            return items;

        }

        public List<string> allChiarsInTheatherRoom(int id_TheaterRoom) {
            var allObjects = Getall();
            var singleObject = allObjects.Find(x => x.Id_TheaterRoom == id_TheaterRoom);

            var allChairsinTheaterRoom = singleObject.AllChairs.ToList();
            return allChairsinTheaterRoom;

        }

        public string GetPathToJson()
        {
            string workingDirectory = Environment.CurrentDirectory;
            var pathToJsonFile = Directory.GetParent(workingDirectory).Parent.FullName + @"\Data\AllTheaterRooms.json";

            return pathToJsonFile;
        }

    }


}


