namespace Cr1tBot.Utils.Models.Teamspeak.Messages
{
    public class ChannelListMessage
    {
        [TeamspeakMessageProperty("cid")]
        public string ChannelId { get; set; }
        [TeamspeakMessageProperty("channel_name")]
        public string ChannelName { get; set; }
    }
}
