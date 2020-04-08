using System;
using System.Threading.Tasks;
using Cr1tBot.Models.EventArgs;
using TwitchLib.Api;
using TwitchLib.Api.V5.Models.Channels;
using TwitchLib.Client;
using TwitchLib.Client.Events;
using TwitchLib.Client.Models;
using TwitchLib.Communication.Clients;
using TwitchLib.Communication.Models;

namespace Cr1tBot.Services.Twitch
{
    public class TwitchHandlerService
    {
        private string _oauth;
        private readonly string _username;
        private TwitchClient _client;
        private TwitchAPI _api;

        #region "Events"

        public EventHandler<UserMessageEventArgs> UserMessageReceived;
        public EventHandler<ChannelAuthed> ChannelInfoReceived;
        public EventHandler<OnUserJoinedArgs> UserJoined;
        public EventHandler<OnUserLeftArgs> UserLeft;

        #endregion


        public TwitchHandlerService(string oauth, string username)
        {
            _oauth = oauth;
            _username = username;
        }

        public bool Connect()
        {
            try
            {
                var credentials = new ConnectionCredentials(_username, _oauth.Replace("oauth:",""));
                var clientOptions = new ClientOptions
                {
                    MessagesAllowedInPeriod = 750,
                    ThrottlingPeriod = TimeSpan.FromSeconds(30)
                };
                var customClient = new WebSocketClient(clientOptions);
                _client = new TwitchClient(customClient);
                _client.Initialize(credentials, _username);

                _api = new TwitchAPI();
                _api.Settings.AccessToken = _oauth.Replace("oauth:","");//"8rmxbwdxm06it6qvjwpt1zqyv15kxx";
                _api.Settings.ClientId = "5hi8c6qjnq18zhe2mrmddavovygtee";

                if (_client.IsInitialized)
                    _client.Connect();

                _client.OnMessageReceived += OnMessageReceived;
                _client.OnUserJoined += OnUserJoined;
                _client.OnUserLeft += OnUserLeft;

                UpdateChannelInfo();
                ScheduleUpdateChannelInfo();
                return _client.IsInitialized && _client.IsConnected;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private async Task UpdateChannelInfo()
        {
            var channel = await _api.V5.Channels.GetChannelAsync();
             ChannelInfoReceived?.Invoke(null,channel);
        }

        private async Task ScheduleUpdateChannelInfo()
        {
            await Task.Run(async () =>
            {
                while (true)
                {
                    await UpdateChannelInfo();
                    await Task.Delay(10 * 1000);
                }
            });
        }


        #region Events

        private void OnUserJoined(object sender, OnUserJoinedArgs e)
        {
            UserJoined.Invoke(null, e);

        }
        private void OnUserLeft(object sender, OnUserLeftArgs e)
        {
            UserLeft.Invoke(null,e);
        }

        private void OnMessageReceived(object sender, OnMessageReceivedArgs e)
        {
            UserMessageReceived?.Invoke(null, new UserMessageEventArgs
            {
                Emotes = e.ChatMessage.EmoteSet.Emotes,
                Message = e.ChatMessage.Message,
                UsernameColor = e.ChatMessage.Color,
                Username = e.ChatMessage.Username
            });
        }
        #endregion
    }
}
