﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Project0.Models
{
    public class Area
    {
        public string name { get; set; }
        public string countryCode { get; set; }
        public string ensignUrl { get; set; }
    }

    public class Competition
    {
        public int id { get; set; }
        public string name { get; set; }
        public Area area { get; set; }
        public string code { get; set; }
        public string emblemUrl { get; set; }
        public string plan { get; set; }

        public SeasonModel currentSeason { get; set; }
        public int numberofAvailableSeasons { get; set; }
        public DateTime lastUpdated { get; set; }
    }
    public class CompetitionsModel
    {
        public int count { get; set; }
        public Filters filters;
        public List<Competition> competitions { get; set; }
    }
}
