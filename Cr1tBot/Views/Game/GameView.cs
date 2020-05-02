using System.Collections.Generic;
using System.Windows.Forms;
using Cr1tBot.Models;
using Cr1tBot.Services.Twitch;

namespace Cr1tBot.Views.Game
{
    public partial class GameView : UserControl
    {
        private readonly Settings _settings;
        private readonly TwitchGameChangeService _gameChangeService;

        public GameView(Settings settings, TwitchGameChangeService gameChangeService)
        {
            _settings = settings;
            _gameChangeService = gameChangeService;
            InitializeComponent();
            if (_settings.Games == null)
                _settings.Games = new List<Models.Game>();

            foreach (var game in _settings.Games)
                customListBox1.Items.Add(game);

        }

        private void OnBtnAddGame(object sender, System.EventArgs e)
        {
            using (var frmGame = new FrmAddGame())
            {
                if (frmGame.ShowDialog(this) == DialogResult.OK)
                {
                    if (frmGame.Result != null)
                    {
                        customListBox1.Items.Add(frmGame.Result);
                        _settings.Games.Add(frmGame.Result);
                    }
                }
            }
        }

        private void OnBtnRemoveClick(object sender, System.EventArgs e)
        {
            var selectedItem = (Models.Game)customListBox1.SelectedItem;

            if (selectedItem == null)
                return;

            _settings.Games.Remove(selectedItem);
            customListBox1.Items.Remove(selectedItem);
        }
    }
}
