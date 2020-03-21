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

        public ShowTimeView GetShowTime(int id_movieShowTime)
        {
            var allShowTimesForMovie = GetAll();
            var showtime = allShowTimesForMovie.Single(x => x.Id_MovieShowTime == id_movieShowTime);

            return showtime;
        }


        public List<ShowTimeView> GetAllShowTimesForMovie(int id_Movie)
        {
            var allShowTimes = GetAll();
            return allShowTimes.Where(x => x.Id_Movie == id_Movie).ToList();
        }


        public void AddNewTakenChairs(List<string> chairs, int id_movieShowTime)
        {
            // Note for Tarik en Kay: De methode mist nog een check of de stoelen die gereserveerd worden al in de lijst van stoelen zit van de showtime
            // Ik stel voor om een check te bouwen die kijkt of de nieuwe stoelen die gereserveerd worden (chairs) al in de lijst van showTime.TakenChairs
            // Als er een stoel al in zit moet er een exception gethrowd worden, succes ehhh


            // Get Individual showtime
            var showTime = GetShowTime(id_movieShowTime);

            // Append to the list of chairs that are taken of the showtime
            showTime.TakenChairs.AddRange(chairs);

            // Get all showtimes without the individual showtime
            var allShowTimes = GetAll().Where( x => x.Id_MovieShowTime != id_movieShowTime).ToList();

            // Append the showtime in its whole to all showtimes
            allShowTimes.Add(showTime);

            // Convert to Json and extract
            var json = JsonConvert.SerializeObject(allShowTimes);

            var pathToJsonFile = GetPathToJson();
            File.WriteAllText(pathToJsonFile, json);
        }

        public void RemoveTakenChairs(List<string> chairs, int id_movieShowTime)
        {
            // Note for Tarik en Kay: Okee nu mogen jullie uitvogelen hoe je chairs van de lijst uit taken chairs eruit gooit.
            // De methode ontvangt een lijst van stoelen, deze stoelen moeten uit de lijst van TakenChairs van de bijbehorend showtime eruit gegooid moet worden
            // Ik zou ook nog dubbel checken of de lijst van stoelen wel uberhaupt in de lijst van TakenChairs van het json zich bestandje bevind
            // In dat geval zal ik geen exception throwen maar eerder de chair overslaan. 
            // Verwijder onderstaande lijn en plaats je nieuwe code, Succes drollen
            throw new NotImplementedException();
        }

        public string GetPathToJson()
        {
            string workingDirectory = Environment.CurrentDirectory;
            var pathToJsonFile = Directory.GetParent(workingDirectory).Parent.FullName + @"\Data\AllShowtimes.json";

            return pathToJsonFile;
        }
    }



}
