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
    public class MoviesRepository 
    {
        public List<MovieView> GetAll()
        {
            var pathToJsonFile = GetPathToJson();

            List<MovieView> items;

            using (StreamReader r = new StreamReader(pathToJsonFile))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<MovieView>>(json);
            }

            return items;
        }

        public void AddMovie(string movieTitle, DateTime releaseDate,string genre)
        {
            var allMovies = GetAll();
            var newId = allMovies.Max(x => x.Id + 1); /// it didn't add a new id so I added 1 which means max+1
            var movieToAdd = new MovieView(newId, movieTitle, genre, releaseDate);
            ///allMovies.Append(movieToAdd); Append wwasn't a good choice, because it didn't add the movie with its id so i used methid Add.
            allMovies.Add(movieToAdd);

            var json = JsonConvert.SerializeObject(allMovies);

            var pathToJsonFile = GetPathToJson();
            File.WriteAllText(pathToJsonFile, json);
        }
        public void DeleteMovie(int Id)
        {
            var allMovies = GetAll();
            var movie = allMovies.Where(m => m.Id != Id).ToList();
            if (movie != null)
            {
                var json = JsonConvert.SerializeObject(movie);
                var pathToJsonFile = GetPathToJson();
                File.WriteAllText(pathToJsonFile, json);
            }

        }

        public string GetPathToJson()
        {
            string workingDirectory = Environment.CurrentDirectory;
            var pathToJsonFile = Directory.GetParent(workingDirectory).Parent.FullName + @"\Data\AllMovies.json";

            return pathToJsonFile;
        }
    }



}
