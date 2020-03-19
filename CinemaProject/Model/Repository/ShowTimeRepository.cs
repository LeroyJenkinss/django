﻿using CinemaProject.View;
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

        public List<ShowTimeView> allShowTimesForMovie(int id_Movie)
        {  
            var allShowTimes = GetAll();

            var allShowTimesForMovie = allShowTimes.Where(x => x.Id_Movie == id_Movie).ToList();

            return allShowTimesForMovie;
        }

      
        public string GetPathToJson()
        {
            string workingDirectory = Environment.CurrentDirectory;
            var pathToJsonFile = Directory.GetParent(workingDirectory).Parent.FullName + @"\Data\AllShowtimes.json";

            return pathToJsonFile;
        }
    }



}
