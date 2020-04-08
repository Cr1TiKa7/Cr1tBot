namespace Cr1tBot.Utils.Models.Teamspeak.Messages
{
    public class ClientListMessage
    {
        [TeamspeakMessageProperty("clid")]
        public string ClientId { get; set; }
        [TeamspeakMessageProperty("cid")]
        public string ChannelId { get; set; }
        [TeamspeakMessageProperty("client_nickname")]
        public string Username { get; set; }
    }
}
