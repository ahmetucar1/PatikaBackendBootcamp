using System.Reflection.Metadata.Ecma335;

namespace Patikaflix
{
    public class Series
    {
        public string Name {get; set;}
        public int ProductionYear {get; set;}
        public string Genre {get; set;}
        public int StartYear {get; set;}
        public string Director {get; set;}
        public string Platform {get; set;}


        public Series(string name, int productionYear, string genre, int startYear, string director, string platform)
        {
        Name = name;
        ProductionYear = productionYear;
        Genre = genre;
        StartYear = startYear;
        Director= director; 
        Platform = platform;
        }
    }

    public class ComedySeries
    {
        public string Name {get; set;}
        public string Genre {get; set;}
        public string Director {get; set;}

        public ComedySeries(string name, string genre, string director)
        {
        Name = name;
        Genre = genre;
        Director= director; 
        }
    }
}