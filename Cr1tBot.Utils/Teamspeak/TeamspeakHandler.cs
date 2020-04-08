using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Cr1tBot.Utils.Models.Teamspeak;
using Cr1tBot.Utils.Models.Teamspeak.Messages;
using PrimS.Telnet;

namespace Cr1tBot.Utils.Teamspeak
{
    public class TeamspeakHandler
    {
        private Client _client;
        private TeamspeakMessageParser _teamspeakMessageParser = new TeamspeakMessageParser();
        public async Task<bool> Connect(string apiKey)
        {
            try
            {
                _client = new Client("localhost",25639, new CancellationToken());
                if (_client.IsConnected)
                {
                    await _client.ReadAsync();
                    await _client.WriteLine($"auth apikey={apiKey}");
                    var result = await _client.ReadAsync();
                }
                return _client.IsConnected;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public async Task<List<string>> GetUsersInCurrentChannel()
        {
            var ret = new List<string>();

            if (_client.IsConnected)
            {
                var currentChannel = await GetCurrentChannelName();

                if (!string.IsNullOrEmpty(currentChannel))
                {
                    await _client.WriteLine("channellist");
                    var result = await _client.ReadAsync();
                    if (!string.IsNullOrEmpty(result))
                    {
                        var channels = _teamspeakMessageParser.ParseList<ChannelListMessage>(result);
                        foreach (var channel in channels)
                        {
                            if (channel.ChannelName.Equals(currentChannel))
                            {
                                var cid = channel.ChannelId;
                                await _client.WriteLine("clientlist");
                                result = await _client.ReadAsync();
                                var clients = _teamspeakMessageParser.ParseList<ClientListMessage>(result);
                                foreach (var client in clients)
                                {
                                    if (client.ChannelId == cid)
                                        ret.Add(client.Username);
                                }

                                break;
                            }
                        }
                    }
                }
            }
            return ret;
        }

        public async Task<string> GetCurrentChannelName()
        {
            var ret = "";

            if (_client.IsConnected)
            {
                await _client.WriteLine("channelconnectinfo");
                var result = await _client.ReadAsync();
                if (!string.IsNullOrEmpty(result))
                {
                    var channelInfo = _teamspeakMessageParser.Parse<ChannelConnectInfoMessage>(result);
                    if (channelInfo != null)
                        ret = channelInfo.Path;
                }
            }

            return ret;
        }



        private Dictionary<string,string> ParseMessage(string message)
        {
            var ret = new Dictionary<string,string>();
            var returnedParams = message.Split('\n');

            foreach (var returnedParam in returnedParams)
            {
                var paramKeyValue = returnedParam.Split('=');
                if (paramKeyValue.Length == 2)
                {
                    if (!ret.ContainsKey(paramKeyValue[0]))
                    {
                        ret.Add(paramKeyValue[0],paramKeyValue[1]);
                    }
                }
            }

            return ret;
        }
    }
}
