namespace RGB_API.Models
{
    public class Color : Common
    {
        public int Red { get; set; }

        public int Green { get; set; }

        public int Blue { get; set; }
        
        public User Creator { get; set; }
    }
}
