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
    public class TheaterRoomsRepository {

        public List<TheaterRoomView> GetAll() {

            var pathToJsonFile = GetPathToJson();

            List<TheaterRoomView> items;

            using (StreamReader r = new StreamReader(pathToJsonFile))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<TheaterRoomView>>(json);
            }

            return items;

        }

        public TheaterRoomView GetTheaterRoom(int id_TheaterRoom) {
            var allTheaterRooms = GetAll();
            var theaterRoom = allTheaterRooms.Find(x => x.Id_TheaterRoom == id_TheaterRoom);

            return theaterRoom;  
        } // haal theaterroom met stoelen op

        public string GetPathToJson()
        {
            string workingDirectory = Environment.CurrentDirectory;
            var pathToJsonFile = Directory.GetParent(workingDirectory).Parent.FullName + @"\Data\AllTheaterRooms.json";

            return pathToJsonFile;
        }

    }





}