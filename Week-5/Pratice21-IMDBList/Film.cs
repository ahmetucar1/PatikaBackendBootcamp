namespace IMBDList
{
    class Film
    {
    public string Ad { get; set; }
    public double ImdbPuani { get; set; }

    // Yapıcı metod
    public Film(string ad, double imdbPuani)
    {
        Ad = ad;
        ImdbPuani = imdbPuani;
    }
    }
}