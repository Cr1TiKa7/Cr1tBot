using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Cr1tBot.Utils.Teamspeak;
using PrimS.Telnet;

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
        private static async Task Test()
        {
            try
            {
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
