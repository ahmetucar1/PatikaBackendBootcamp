namespace Patikafy
{
    public class Artists
    {
        public string Name {get; set;}
        public string MusicGenre {get; set;}
        public int Year {get; set;}
        public int AlbumSales{get; set;}

        public Artists(string name, string musicGenre, int year, int albumSales)
        {
            Name = name;
            MusicGenre = musicGenre;
            Year = year;
            AlbumSales = albumSales;
        }
    }
}