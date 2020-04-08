using System;
using System.Collections.Generic;
using TwitchLib.Api;
using TwitchLib.Client;
using TwitchLib.Client.Models;

namespace IdleTwitchBot
{
    class Program
    {

        //oauth:o572x71rni5lt1pq4sakkge2zwttut

            private List<string> _channels = new List<string>()
            {
                "PietSmiet",
                "Papaplatte",
                "Trilluxe",
                "DoktorFroid",
                "Dhalucard",
                "Maxim",
                "Kalle",
                "gobbTV",
                "summit1g",
                "timthetatman",
                "xqcow",
                "anomaly"

            };

        private TwitchClient _twitchClient = new TwitchClient();
        private TwitchAPI _twitchApi = new TwitchAPI();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var program = new Program();
            program.Start();
            while (true)
            {

            }
        }


        private void Start()
        {
            _twitchClient.Initialize(new ConnectionCredentials("cr1tika7", "o572x71rni5lt1pq4sakkge2zwttut"));
            _twitchClient.Connect();
            _twitchApi = new TwitchAPI();
            _twitchApi.Settings.AccessToken = "o572x71rni5lt1pq4sakkge2zwttut";//"8rmxbwdxm06it6qvjwpt1zqyv15kxx";
            _twitchApi.Settings.ClientId = "5hi8c6qjnq18zhe2mrmddavovygtee";

            if (_twitchClient.IsInitialized && _twitchClient.IsConnected)
            {
                _twitchClient.AutoReListenOnException = true;
                foreach (var channel in _channels)
                {
                    _twitchClient.JoinChannel(channel);
                    Console.WriteLine($"Channel '{channel}' joined..");
                }

                while (true)
                {
                    var input = Console.ReadLine();
                    if (!_channels.Contains(input))
                    {
                        _channels.Add(input);
                        _twitchClient.JoinChannel(input);
                        Console.WriteLine($"Channel '{input}' joined..");
                    }
                }

            }
        }
    }
}
