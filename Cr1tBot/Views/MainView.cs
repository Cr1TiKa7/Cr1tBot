using System;
using System.Windows.Forms;
using Cr1tBot.Models.EventArgs;
using Cr1tBot.Services.Twitch;
using Cr1TiKa7_Framework.Controls.ListBox;
using TwitchLib.Api.V5.Models.Channels;
using TwitchLib.Client.Events;

namespace Cr1tBot.Views
{
    public partial class MainView : UserControl
    {
        private readonly TwitchHandlerService _twitchHandlerService;

        public MainView(TwitchHandlerService twitchHandlerService)
        {
            _twitchHandlerService = twitchHandlerService ?? throw new ArgumentNullException(nameof(twitchHandlerService));
            _twitchHandlerService.UserMessageReceived += OnUserMessageReceived;
            _twitchHandlerService.ChannelInfoReceived += OnChannelInfoReceived;
            _twitchHandlerService.UserJoined += OnUserJoined;
            _twitchHandlerService.UserLeft += OnUserLeft;
            InitializeComponent();
        }

        private void OnChannelInfoReceived(object sender, ChannelAuthed e)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { OnChannelInfoReceived(sender, e); });
                return;
            }

            txtGame.Text = "Game: " + e.Game;
            txtTitle.Text = "Title: " + e.Status;
            txtFollower.Text = "Follower: " + e.Followers;
            txtViews.Text = "Views: " + e.Views;
        }


        #region Events   
        private void OnUserJoined(object sender, OnUserJoinedArgs e)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { OnUserJoined(sender, e); });
                return;
            }

            lbChat.Items.Add(new CustomListBoxItem
            {
                Username = e.Username,
                Text = $"The user '{e.Username}' joined.",
                Type = CustomListBoxItemType.UserJoined
            });
        }

        private void OnUserLeft(object sender, OnUserLeftArgs e)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { OnUserLeft(sender, e); });
                return;
            }

            lbChat.Items.Add(new CustomListBoxItem
            {
                Username = e.Username,
                Text = $"The user '{e.Username}' left.",
                Type = CustomListBoxItemType.UserLeft
            });
        }


        private void OnUserMessageReceived(object sender, UserMessageEventArgs e)
        {

            if (InvokeRequired)
            {
                Invoke((MethodInvoker) delegate { OnUserMessageReceived(sender, e); });
            }
            else
            {
                lbChat.Items.Add(new CustomListBoxItem
                {
                    Username = e.Username,
                    UsernameColor = e.UsernameColor,
                    Text = e.Message,
                    Emotes = e.Emotes,
                    Type = CustomListBoxItemType.Chat
                });
            }
        }
        #endregion
    }
}
