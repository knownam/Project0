using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Project0.Models
{
    public class SeasonModel
    {
        public int id { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int currentMatchDay { get; set; }
        public string winner { get; set; }
    }
}
