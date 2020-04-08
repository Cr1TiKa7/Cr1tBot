using System;
using System.Linq;
using System.Windows.Forms;
using Cr1tBot.Properties;
using Cr1tBot.Services.Settings;
using Cr1tBot.Services.Twitch;
using Cr1tBot.Views;
using Cr1tBot.Views.Game;
using Cr1TiKa7_Framework.Baseform;
using Cr1TiKa7_Framework.Controls.SideBar;

namespace Cr1tBot
{
    public partial class FrmMain : Baseform
    {
        private readonly FrmLogin _frmLogin;
        private readonly Models.Settings _settings;
        private readonly SettingsService _settingsService;

        private TwitchHandlerService _twitchHandlerService;
        public FrmMain()
        {
            InitializeComponent();
        }

        public FrmMain(FrmLogin frmLogin, Models.Settings settings)
        {
            if (frmLogin == null) throw new ArgumentNullException(nameof(frmLogin));
            InitializeComponent();
            InitializeTwitchHandler(settings.OAuth, settings.Username);
            IntializeSideBar();
            _frmLogin = frmLogin;
            _settings = settings;
            frmLogin.Hide();
        }

        private void InitializeTwitchHandler(string accesstoken, string username)
        {
            _twitchHandlerService = new TwitchHandlerService(accesstoken, username);
            if (_twitchHandlerService.Connect())
            {
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
                CustomControl = new GameView(_settings) {Dock = DockStyle.Fill},
                Text = "Games",
                Image = Resources.Game
            });
            //sideBar.Items.Add(new SideBarItem
            //{
            //    CustomControl = new MainView(),
            //    Text = "Settings",
            //    Image = Resources.Settings
            //});
            sideBar.OnItemClicked += OnSideBarItemClicked;
            OnSideBarItemClicked(null, new OnItemClickedEventArgs(sideBar.Items.FirstOrDefault()));
        }

        private void OnSideBarItemClicked(object sender, OnItemClickedEventArgs e)
        {
            pnlCustomControl.Controls.Clear();
            pnlCustomControl.Controls.Add(e.CustomControl);
        }

        private void OnFrmMainShown(object sender, EventArgs e)
        {
            BringToFront();
        }
    }
}
