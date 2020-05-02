using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cr1tBot.Models;
using Cr1tBot.Models.EventArgs;

namespace Cr1tBot.Services.Twitch
{
    public class TwitchGameChangeService
    {
        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();


        private readonly TwitchHandlerService _twitchHandlerService;
        private readonly Models.Settings _settings;
        private Game _currentActiveGame;
        public TwitchGameChangeService(TwitchHandlerService twitchHandlerService, Models.Settings settings)
        {
            _twitchHandlerService = twitchHandlerService;
            _settings = settings;
            _twitchHandlerService.UserMessageReceived += OnUserMessageReceived;
            ScheduleGameChangeTask();
        }

        private void OnUserMessageReceived(object sender, UserMessageEventArgs e)
        {

        }

        private async Task ScheduleGameChangeTask()
        {
            await Task.Run(async () =>
            {
                while (true)
                {
                    var activeGame = GetActiveProcessFileName();
                    if (activeGame != null && _currentActiveGame != activeGame)
                    {
                        _currentActiveGame = activeGame;
                        await _twitchHandlerService.UpdateGame(_currentActiveGame);
                    }
                    Thread.Sleep(1000 * 10);
                }
            });
        }

        private Game GetActiveProcessFileName()
        {
            try
            {
                IntPtr hwnd = GetForegroundWindow();
                uint pid;
                GetWindowThreadProcessId(hwnd, out pid);
                var p = Process.GetProcessById((int) pid);
                return _settings.Games.FirstOrDefault(x => x.ProcessName.Equals(p.ProcessName));

            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
