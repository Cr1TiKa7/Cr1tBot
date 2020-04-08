using System.Windows.Forms;
using Cr1tBot.Models;

namespace Cr1tBot.Views.Game
{
    public partial class GameView : UserControl
    {
        public GameView(Settings settings)
        {
            InitializeComponent();
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
                    }
                }
            }
        }
    }
}
