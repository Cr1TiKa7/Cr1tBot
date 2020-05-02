using TwitchLib.Client.Enums;

namespace Cr1tBot.Models
{
    public class Command
    {
        public string CommandName { get; set; }
        public string CommandText { get; set; }
        public string ShortDescription { get; set; }
        public UserType UserType { get; set; }

        public override string ToString()
        {
            return CommandName;
        }
    }
}
