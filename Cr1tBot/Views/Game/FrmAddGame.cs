using System.Diagnostics;
using System.Windows.Forms;
using Cr1tBot.Models;
using Cr1TiKa7_Framework.Baseform;

namespace Cr1tBot.Views.Game
{
    public partial class FrmAddGame : Baseform
    {
        public FrmAddGame()
        {
            InitializeComponent();
        }

        public Models.Game Result { get; set; }

        private void OnFrmAddGameLoad(object sender, System.EventArgs e)
        {
            foreach (var proc in Process.GetProcesses())
            {
                cmbProcesses.Items.Add(new Models.Game
                {
                    WindowTitle = proc.MainWindowTitle,
                    ProcessName = proc.ProcessName
                });
            }
        }

        private void OnBtnAddClick(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGameName.Text) || cmbProcesses.SelectedItem == null)
            {
                lblError.Visible = true;
                return;
            }
            Result = (Models.Game)cmbProcesses.SelectedItem;
            Result.GameName = txtGameName.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
