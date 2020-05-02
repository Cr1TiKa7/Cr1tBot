using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Cr1tBot.Utils.Teamspeak;
using PrimS.Telnet;
using TwitchLib.Api;
using TwitchLib.Client;
using TwitchLib.Client.Models;

namespace TestConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Test();
            Console.ReadLine();
        }


        private static async Task GenerateGifImage()
        {

        }

        private static async Task Spotify()
        {

        }

        private static async Task Test()
        {
            try
            {
                var userToJoin = "cr1tika7";
                var botName = "cr1tbot";

                var client = new TwitchClient();
                client.Initialize(new ConnectionCredentials(botName, "fryrbpz6ouqck2grprgq5sygs7shbn"));
                client.Connect();
                client.JoinChannel(userToJoin);
                
                var api = new TwitchAPI();
                api.Settings.AccessToken = "fryrbpz6ouqck2grprgq5sygs7shbn";
                api.Settings.ClientId = "5hi8c6qjnq18zhe2mrmddavovygtee";

                var tsHandler = new TeamspeakHandler();

                if (await tsHandler.Connect("7UQN-SRU9-LV69-KHPQ-TW8D-MXTI"))
                {
                    var users = await tsHandler.GetUsersInCurrentChannel();

                }

            }
            catch (Exception ex)
            {
                ex = ex;
            }
        }
    }
}
