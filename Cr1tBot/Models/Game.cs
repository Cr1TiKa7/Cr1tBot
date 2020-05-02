namespace Cr1tBot.Models
{
    public class Game
    {
        public string WindowTitle { get; set; }
        public string GameName { get; set; }
        public string ProcessName { get; set; }


        public override string ToString()
        {
            return GameName ?? $"{ProcessName}.exe";
        }
    }
}
