public class Song
{
    public string Artist { get; set; }
    public string Title { get; set; }
    public double Duration { get; set; } // У хвилинах

    public Song(string artist, string title, double duration)
    {
        Artist = artist;
        Title = title;
        Duration = duration;
    }

    public override string ToString()
    {
        return $"{Artist} — \"{Title}\" ({Duration} хв)";
    }
}
