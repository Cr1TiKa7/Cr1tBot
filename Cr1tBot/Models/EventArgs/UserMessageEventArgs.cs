using System.Collections.Generic;
using System.Drawing;
using TwitchLib.Client.Enums;
using TwitchLib.Client.Models;

namespace Cr1tBot.Models.EventArgs
{
    public class UserMessageEventArgs
    {
        public string Username { get; set; }
        public Color UsernameColor { get; set; }
        public string Message { get; set; }
        public List<Emote> Emotes { get; set; }
        public UserType UserType { get; set; }

        public override string ToString()
        {
            return $"{Username}: {Message}";
        }
    }
}
