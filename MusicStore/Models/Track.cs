namespace MusicStore.Models
{
    public class Track
    {
        
        public string Title { get; set; }
        
        public string Composer { get; set; }
        
        public string Lenght { get; set; }
        

        public Track(string title, string composer, string lenght)
        {
            Title = title;
            Composer = composer;
            Lenght = lenght;
        }
    }
}