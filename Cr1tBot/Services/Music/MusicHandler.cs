using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Cr1tBot.Services.Music
{
    public static class MusicHandler
    {
        public static MusicPlayer MusicPlayer = MusicPlayer.Spotify;
                 
        public static EventHandler<Song> SongChanged;
               
        public static Song CurrentSong;
        private static Process _currentProcess;
               
        private  const string SPOTIFY_TITLE = "Spotify Premium";


        public static async Task GetCurrentSong()
        {
            await Task.Run(async () =>
            {
                while (true)
                {
                    GetProcess();
                    switch (MusicPlayer)
                    {
                        case MusicPlayer.Spotify:
                            if (_currentProcess != null)
                            {
                                var songString = _currentProcess.MainWindowTitle.Split('-');
                                if (songString.Length > 1 && CurrentSong?.Artist != songString[0] && CurrentSong?.Title != songString[1])
                                {
                                   var song = new Song();
                                   song.Artist = songString[0];
                                   song.Title = songString[1];
                                   CurrentSong = song;
                                   SongChanged?.Invoke(null, song);
                                }
                            }
                            break;
                    }
                    Thread.Sleep(1000 * 1);
                }
            });
        }

        private static void GetProcess()
        {
            switch (MusicPlayer)
            {
                case MusicPlayer.Spotify:
                    var processes = Process.GetProcessesByName("Spotify");
                    foreach (var process in processes)
                    {
                        if (process.MainWindowTitle == SPOTIFY_TITLE || process.MainWindowTitle.Split('-').Length > 1)
                        {
                            _currentProcess = process;
                            break;
                        }
                    }
                    break;
            }
        }
    }

    public class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }

        public override string ToString()
        {
            return $"{Artist}-{Title}";
        }
    }

    public enum MusicPlayer
    {
        Spotify
    }
}
