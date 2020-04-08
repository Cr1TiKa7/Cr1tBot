using System;
using System.Collections.Generic;
using System.Text;

namespace Cr1tBot.Utils.Models.Teamspeak
{
    public class ChannelConnectInfoMessage
    {
        [TeamspeakMessageProperty("path")]
        public string Path { get; set; }
    }
}
