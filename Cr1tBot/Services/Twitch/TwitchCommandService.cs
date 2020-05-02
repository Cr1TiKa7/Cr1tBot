using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cr1tBot.Models.EventArgs;
using Cr1tBot.Services.Music;

namespace Cr1tBot.Services.Twitch
{
    public class TwitchCommandService
    {
        private readonly Models.Settings _settings;
        private readonly TwitchHandlerService _twitchHandlerService;

        public TwitchCommandService(Models.Settings settings, TwitchHandlerService twitchHandlerService)
        {
            _settings = settings;
            _twitchHandlerService = twitchHandlerService;

            _twitchHandlerService.UserMessageReceived += OnUserMessageReceived;
        }

        private void OnUserMessageReceived(object sender, UserMessageEventArgs e)
        {
            if (!e.Message.StartsWith("!"))
                return;

            if (_settings.Commands == null)
                return;
            var commands = _settings.Commands.Where(x => x.UserType <= e.UserType);

            if (e.Message.Equals("!help", StringComparison.OrdinalIgnoreCase))
            {
                var msg = "The following commands are available {user}:";
                foreach (var cmd in _settings.Commands)
                {
                    msg += $"{cmd.CommandName} | {cmd.ShortDescription}\r\n";
                }
                if (!string.IsNullOrEmpty(msg))
                    SendCommandResult(e.Username, msg);
                return;
            }

            foreach (var cmd in commands)
            {
                if (cmd.CommandName.Equals(e.Message, StringComparison.OrdinalIgnoreCase))
                {
                    SendCommandResult(e.Username, cmd.CommandText);
                    break;
                }

            }
        }

        private void SendCommandResult(string username, string message)
        {
            var msg = ReplaceMessageVariables(message, username);
            _twitchHandlerService.SendMessage(msg);
        }

        private string ReplaceMessageVariables(string msg, string username)
        {
             msg = msg.Replace("{user}", username)
                 .Replace("{musicPlayer.Song}",MusicHandler.CurrentSong?.ToString())
                 .Replace("{musicPlayer.Title}",MusicHandler.CurrentSong?.Title)
                 .Replace("{musicPlayer.Artist}",MusicHandler.CurrentSong?.Artist)
                 ;

             return msg;
        }
    }
}
