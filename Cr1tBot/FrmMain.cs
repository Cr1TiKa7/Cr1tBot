using System;
using System.Linq;
using System.Windows.Forms;
using Cr1tBot.Models;
using Cr1tBot.Properties;
using Cr1tBot.Services.Music;
using Cr1tBot.Services.Settings;
using Cr1tBot.Services.Twitch;
using Cr1tBot.Views;
using Cr1tBot.Views.Commands;
using Cr1tBot.Views.Game;
using Cr1TiKa7_Framework.Baseform;
using Cr1TiKa7_Framework.Controls.SideBar;
using Cr1TiKa7_Framework.Dialog;

namespace Cr1tBot
{
    public partial class FrmMain : Baseform
    {
        private readonly FrmLogin _frmLogin;
        private readonly Models.Settings _settings;
        private readonly SettingsService _settingsService = new SettingsService();

        public static EventHandler<NotificationEventArgs> ReceivedNotification;

        private TwitchHandlerService _twitchHandlerService;
        private TwitchGameChangeService _gameChangeService;
        private TwitchCommandService _twitchCommandService;

        public FrmMain()
        {
            InitializeComponent();
        }

        public FrmMain(FrmLogin frmLogin, Models.Settings settings)
        {
            if (frmLogin == null) throw new ArgumentNullException(nameof(frmLogin));
            InitializeComponent();
            _frmLogin = frmLogin;
            _settings = settings;
            InitializeTwitchHandler(settings.OAuth, settings.Username);
            frmLogin.Hide();
            IntializeSideBar();
            MusicHandler.GetCurrentSong();
            ReceivedNotification += OnReceivedNotification;
        }

        private void InitializeTwitchHandler(string accesstoken, string username)
        {
            _twitchHandlerService = new TwitchHandlerService(accesstoken, username);
            if (_twitchHandlerService.Connect())
            {
                _gameChangeService = new TwitchGameChangeService(_twitchHandlerService, _settings);
                _twitchCommandService = new TwitchCommandService(_settings,_twitchHandlerService);
                // Add listeners
            }
        }

        private void IntializeSideBar()
        {
            sideBar.Items.Add(new SideBarItem
            {
                CustomControl = new MainView(_twitchHandlerService) { Dock = DockStyle.Fill },
                Text = "Home",
                Image = Resources.Home
            });
            sideBar.Items.Add(new SideBarItem
            {
                CustomControl = new GameView(_settings, _gameChangeService) {Dock = DockStyle.Fill},
                Text = "Games",
                Image = Resources.Game
            });
            sideBar.Items.Add(new SideBarItem
            {
                CustomControl = new CommandView(_settings) {Dock = DockStyle.Fill},
                Text = "Commands",
                Image = Resources.Commands
            });
            sideBar.Items.Add(new SideBarItem
            {
                CustomControl = new MainView(_twitchHandlerService) { Dock = DockStyle.Fill },
                Text = "Settings",
                Image = Resources.Settings
            });
            sideBar.OnItemClicked += OnSideBarItemClicked;
            OnSideBarItemClicked(null, new OnItemClickedEventArgs(sideBar.Items.FirstOrDefault()));
        }

        #region Events
        private void OnSideBarItemClicked(object sender, OnItemClickedEventArgs e)
        {
            pnlCustomControl.Controls.Clear();
            pnlCustomControl.Controls.Add(e.CustomControl);
        }

        private void OnFrmMainShown(object sender, EventArgs e)
        {
            BringToFront();

            if (_settings.FirstStartup)
            {
                using (var frmDialog = new FrmDialog(
                    "If this is your first time using this bot please enter the following text into your channels chat" +
                    "to get use of every function: !mod cr1tbot.", "Your first time?"))
                {
                    frmDialog.ShowDialog(this);
                    _settings.FirstStartup = false;
                }
            }
        }

        private void OnFrmMainClosing(object sender, FormClosingEventArgs e)
        {
            _settingsService.WriteSettings(_settings);
            _frmLogin.Close();
        }

        private void OnReceivedNotification(object sender, NotificationEventArgs e)
        {
            notifyBar.ShowNotification(e.Type,e.Message,TimeSpan.FromSeconds(3));
        }
        #endregion
    }
}
