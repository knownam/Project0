using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Project0.Models
{
    public class Filters
    {
        public string permission { get; set; }
        public List<string> status;
        public int limit { get; set; }
    }
    public class Odds
    {
        public string msg { get; set; }
    }
    
    public class FullTime
    {
        public string homeTeam { get; set; }
        public string awayTeam { get; set; }
    }

    public class HalfTime
    {
        public string homeTeam { get; set; }
        public string awayTeam { get; set; }
    }
    public class ExtraTime 
    {
        public  string homeTeam { get; set; }
        public string awayTeam { get; set; }
    }

    public class Penalties
    {
        public string homeTeam { get; set; }
        public string awayTeam { get; set; }
    }
    public class Score
    {
        public string winner { get; set; }
        public string duration { get; set; }
        public FullTime fulltime { get; set; }
        public HalfTime halfTime { get; set; }
        public ExtraTime extraTime { get; set; }
        public Penalties penalties { get; set; }
    }

    public class HomeTeam
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class AwayTeam
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Match
    {
        public int id { get; set; }
        public Competition competition { get; set; }
        public SeasonModel season { get; set; }
        public DateTime utcDate { get; set; }
        public string status { get; set; }
        public int matchday { get; set; }
        public string stage { get; set; }
        public string group { get; set; }
        public DateTime lastUpdated { get; set; }
        public Odds odds { get; set; }
        public Score score { get; set; }
        public  HomeTeam homeTeam { get; set; }
        public AwayTeam awayTeam { get; set; }
        public List<string> referees { get; set; }
    }
    public class MatchesModel
    {
        public int count { get; set; }
        public Filters filters { get; set; }
        public List <Match> matches { get; set; }
    }
}
