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
        private readonly TheaterRoomsRepository _theaterRoomsRepository;

        public ShowTimeRepository()
        {
            _theaterRoomsRepository = new TheaterRoomsRepository();
        }

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

        public List<ShowTimeView> GetAllShowTimesForMovie(int id_movie)
        {
            
            List<ShowTimeView> times = new List<ShowTimeView>();
            List<string> takenchair = new List<string>();

            var allShowTime = GetAll();
            var showtimes = allShowTime.Where(x => x.Id_Movie == id_movie).ToList();



            
           

            foreach ( ShowTimeView showTime in showtimes)
            {
                var chairsOfRoom = _theaterRoomsRepository.GetTheaterRoom(showTime.Id_TheaterRoom);
                var takenchairsMovie = showTime.TakenChairs;
                if (takenchairsMovie.Count() != chairsOfRoom.AllChairs.Count())
                {
                    times.Add(showTime);
                }

            }
            return times;
            
        }

        public void AddNewTakenChairs(List<string> chairs, int id_movieShowTime)
        {
            // Get Individual showtime
            var showTime = GetShowTime(id_movieShowTime);

            // Checking if requested reservation is already booked.
            for (int a = 0; a < showTime.TakenChairs.Count; a++)
            {
                for (int b = 0; b < chairs.Count; b++)
                {
                    if (showTime.TakenChairs[a] == chairs[b])
                    {
                        throw new System.InvalidOperationException("The requested booking can not be provided, the following chair is already taken: " + chairs[b]);
                    }
                }
            }

            // Is ook op te lossen met een Linq statement: (C# specifieke oplossing)
            //if (showTime.TakenChairs.Any( takenChair => chairs.Contains(takenChair)))
            //{
            //    throw new System.InvalidOperationException("The requested booking can not be provided, the following chair is already taken: ");
            //};

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
            var currentShowTime = GetShowTime(id_movieShowTime);

            List<string> takenChairs = currentShowTime.TakenChairs.ToList();

            if (takenChairs != null)
            {
                takenChairs = new List<string>();
            }

            takenChairs = takenChairs.Where( x => !chairs.Contains(x)).ToList();

            var allShowTimes = GetAll().Where(x => x.Id_MovieShowTime != id_movieShowTime).ToList();

            // Append the showtime in its whole to all showtimes
            allShowTimes.Add(currentShowTime);

            // Convert to Json and extract
            var json = JsonConvert.SerializeObject(allShowTimes);

            var pathToJsonFile = GetPathToJson();
            File.WriteAllText(pathToJsonFile, json);
        }

        public string GetPathToJson()
        {
            string workingDirectory = Environment.CurrentDirectory;
            var pathToJsonFile = Directory.GetParent(workingDirectory).Parent.FullName + @"\Data\AllShowtimes.json";

            return pathToJsonFile;
        }
    }



}
