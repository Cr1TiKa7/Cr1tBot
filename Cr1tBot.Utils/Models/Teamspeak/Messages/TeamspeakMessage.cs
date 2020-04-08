namespace Cr1tBot.Utils.Models.Teamspeak.Messages
{
    public class TeamspeakMessage
    {
        [TeamspeakMessageProperty("error id")]
        public int ErrorId { get; set; }
        [TeamspeakMessageProperty("msg")]
        public string Message { get; set; }
    }
}
