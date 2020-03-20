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
    public class ChairRepository {

        public List<ChairView> Getall() {

            var pathToJsonFile = GetPathToJson();

            List<ChairView> items;

            using (StreamReader r = new StreamReader(pathToJsonFile))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<ChairView>>(json);
            }

            return items;

        }

        public void AddChair(double price) {
            var allChairs = Getall();
            var newId = allChairs.Max(x => x.Id_TheaterRoom);
            var chairToAdd = new ChairView(newId, price);
            allChairs.Append(chairToAdd);


             var json = JsonConvert.SerializeObject(allChairs);

             var pathToJsonFile = GetPathToJson();
             File.WriteAllText(pathToJsonFile, json);
        }

        public void reserveChair(double price, string[] chairs, int id_TheaterRoom,string chairName) {
            var allObjectsInArray = Getall();
            var singleObject= allObjectsInArray.Find(x => x.Id_TheaterRoom == id_TheaterRoom && x.Price == price);


            var chairsInSingleObject = singleObject.Chairs.ToList();
            var singleChair = chairsInSingleObject.Find(x => x == chairName);
            chairsInSingleObject.Remove(singleChair);

            var json = JsonConvert.SerializeObject(allObjectsInArray);

            var pathToJsonFile = GetPathToJson();
            File.WriteAllText(pathToJsonFile, json);

        }

        public List<string> allChairs(int id_TheaterRoom) {
            var allObjectsInArray = Getall();
            var singleObject = allObjectsInArray.Find(x => x.Id_TheaterRoom == id_TheaterRoom);

            var allChairInRoom = singleObject.Chairs.ToList();


            var json = JsonConvert.SerializeObject(allChairInRoom);

            var pathToJsonFile = GetPathToJson();
            File.WriteAllText(pathToJsonFile, json);

            return allChairInRoom;
            


            

           
        }

        public string GetPathToJson()
        {
            string workingDirectory = Environment.CurrentDirectory;
            var pathToJsonFile = Directory.GetParent(workingDirectory).Parent.FullName + @"\Data\AllChairs.json";

            return pathToJsonFile;
        }

    }





}