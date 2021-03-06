﻿using CinemaProject.View;
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

        public MovieView GetMovie(int id_movie)
        {
            var allShowTimesForMovie = GetAll();
            var movie = allShowTimesForMovie.Single(x => x.Id_Movie == id_movie);

            return movie;
        }

        public void AddMovie(string movieTitle, DateTime releaseDate,string genre, string picture, string description)
        {
            var allMovies = GetAll();
            var newId = allMovies.Max(x => x.Id_Movie);
            var movieToAdd = new MovieView(newId, movieTitle, genre, releaseDate, description, picture);
            allMovies.Append(movieToAdd);

            var json = JsonConvert.SerializeObject(allMovies);

            var pathToJsonFile = GetPathToJson();
            File.WriteAllText(pathToJsonFile, json);
        }

        public string GetPathToJson()
        {
            string workingDirectory = Environment.CurrentDirectory;
            var pathToJsonFile = Directory.GetParent(workingDirectory).Parent.FullName + @"\Data\AllMovies.json";

            return pathToJsonFile;
        }
    }



}
