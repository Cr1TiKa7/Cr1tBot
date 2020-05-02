using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using Cr1tBot.Models;
using Cr1tBot.Models.EventArgs;
using TwitchLib.Api;
using TwitchLib.Api.Core.Models.Undocumented.Chatters;
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
        private ChannelAuthed _channel;

        #region "Events"

        public EventHandler<UserMessageEventArgs> UserMessageReceived;
        public EventHandler<ChannelAuthed> ChannelInfoReceived;
        public EventHandler<List<ChatterFormatted>> ChattersReceived;
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
                var userAuth = _oauth.Replace("oauth:", "");
                var credentials = new ConnectionCredentials(_username, userAuth);
                var clientOptions = new ClientOptions
                {
                    MessagesAllowedInPeriod = 750,
                    ThrottlingPeriod = TimeSpan.FromSeconds(30)
                };
                var customClient = new WebSocketClient(clientOptions);
                _client = new TwitchClient(customClient);
                _client.Initialize(credentials, _username);

                _api = new TwitchAPI();
                _api.Settings.AccessToken = userAuth;//"oauth:m98wbyj1uzgtyr5mjkgefgrbb3nhhh";
                _api.Settings.ClientId = "5hi8c6qjnq18zhe2mrmddavovygtee";

                if (_client.IsInitialized)
                    _client.Connect();

                _client.OnConnected += OnConnected;

                GetUpdatedChannelInfo();
                ScheduleUpdateChannelInfo();
                return _client.IsInitialized && _client.IsConnected;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void OnConnected(object sender, OnConnectedArgs e)
        {
            _client.JoinChannel(_username);
            _client.OnMessageReceived += OnMessageReceived;
            _client.OnUserJoined += OnUserJoined;
            _client.OnUserLeft += OnUserLeft;
            _client.OnIncorrectLogin += OnIncorrectLogin;
        }

        public void Reconnect()
        {
          
        }

        private void OnIncorrectLogin(object sender, OnIncorrectLoginArgs e)
        {
            throw new NotImplementedException();
        }


        private async Task ScheduleUpdateChannelInfo()
        {
            await Task.Run(async () =>
            {
                while (true)
                {
                    await GetUpdatedChannelInfo();
                    await GetChatters();
                    await Task.Delay(10 * 1000);
                }
            });
        }

        private async Task GetUpdatedChannelInfo()
        {
            var channel = await _api.V5.Channels.GetChannelAsync();
            if (channel != null)
                _channel = channel;
            ChannelInfoReceived?.Invoke(null, channel);
        }
        private async Task GetChatters()
        {
            var chatters = await _api.Undocumented.GetChattersAsync(_username);
            if (chatters != null)
                ChattersReceived?.Invoke(null, chatters);
        }


        public async Task UpdateGame(Game game)
        {
            if (_channel?.Id != null)
            {
                var channel = await _api.V5.Channels.UpdateChannelAsync(_channel.Id, _channel.Status, game.GameName);
            }
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
                UsernameColor = Color.FromArgb(255,e.ChatMessage.Color),
                Username = e.ChatMessage.Username,
                UserType = e.ChatMessage.UserType
            });
        }
        #endregion

        public void SendMessage(string message)
        {
            _client.SendMessage(_username,message);
        }
    }
}
