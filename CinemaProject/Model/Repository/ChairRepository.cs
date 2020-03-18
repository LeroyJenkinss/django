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
            var newId = allChairs.Max(x => x.Id_Chair);
            var chairToAdd = new ChairView(newId, price);
            allChairs.Append(chairToAdd);


             var json = JsonConvert.SerializeObject(allChairs);

             var pathToJsonFile = GetPathToJson();
             File.WriteAllText(pathToJsonFile, json);
        }

        public void deleteChair(int Id_Chair,int price) {
            var allChairs = Getall();
            var chairDel = new ChairView(Id_Chair,price);
            allChairs.Remove(chairDel);

            var json = JsonConvert.SerializeObject(allChairs);

            var pathToJsonFile = GetPathToJson();
            File.WriteAllText(pathToJsonFile, json);

        }
        public string GetPathToJson()
        {
            string workingDirectory = Environment.CurrentDirectory;
            var pathToJsonFile = Directory.GetParent(workingDirectory).Parent.FullName + @"\Data\AllChairs.json";

            return pathToJsonFile;
        }

    }





}