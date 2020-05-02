using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Devices.AllJoyn;
using Cr1tBot.Services.Settings;
using Cr1TiKa7_Framework.Baseform;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace Cr1tBot
{
    public partial class FrmLogin : Baseform
    {
        private string _username;
        private SettingsService _settingsService = new SettingsService();
        public FrmLogin()
        {
            InitializeComponent();
            wbBrowser.Navigate("https://id.twitch.tv/oauth2/authorize?response_type=token&client_id=5hi8c6qjnq18zhe2mrmddavovygtee&redirect_uri=http://127.0.0.1&scope=user_read+user_blocks_edit+user_blocks_read+user_follows_edit+channel_read+channel_editor+channel_commercial+channel_stream+channel_subscriptions+user_subscriptions+channel_check_subscription+chat_login+channel_feed_read+channel_feed_edit&force_verify=true");

        }


        private  void OnWbBrowserStartingNavigation(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationStartingEventArgs e)
        {

            if (e.Uri.ToString().StartsWith("http://127.0.0.1/"))
            {
                string accessToken = "oauth:" + e.Uri.Fragment.Substring(14, e.Uri.Fragment.IndexOf("&") - 14); //"oauth:" + e.Url.Fragment.Substring(14, e.Url.Fragment.IndexOf("&") - 14);
                var settings = _settingsService.GetSettings();
                if (!string.IsNullOrEmpty(accessToken))
                {
                    if (settings == null)
                        settings = new Models.Settings();
                    settings.OAuth = accessToken;
                    settings.Username = _username;
                    _settingsService.WriteSettings(settings);
                    var frmMain = new FrmMain(this, settings);
                    frmMain.Show();
                }
            }
        }

        private async void OnDomContentLoaded(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlDOMContentLoadedEventArgs e)
        {
            if (e.Uri.ToString().StartsWith("https://id.twitch.tv/oauth2/authorize?response_type=token&client_id=") && string.IsNullOrEmpty(_username))
            {
                _username = "cr1tika7";
                var html = await wbBrowser.InvokeScriptAsync("eval", new string[] { "document.documentElement.outerHTML;" });
                var doc = new HtmlDocument();
                doc.LoadHtml(html);
                _username = doc.DocumentNode.SelectSingleNode("//p[@class='user-info__username']/strong")?.InnerText.Replace("\n", "").Trim(' ');
            }
        }
        private void OnFrmLoginShown(object sender, EventArgs e)
        {
        }
    }
}
