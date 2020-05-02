using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Cr1tBot.Models;
using Cr1tBot.Models.AutoCompleteItems;
using Cr1TiKa7_Framework.Controls.NotificationStatus;
using FastColoredTextBoxNS;
using TwitchLib.Client.Enums;
using Command = Cr1tBot.Models.Command;

namespace Cr1tBot.Views.Commands
{
    public partial class CommandView : UserControl
    {
        private readonly Settings _settings;
        private AutocompleteMenu _autocompleteMenu;
        public CommandView(Settings settings)
        {
            _settings = settings;
            InitializeComponent();

            if (_settings.Commands != null)
                _settings.Commands.ForEach(x=> lbCommands.Items.Add(x));
            cmbUserTypes.DataSource = Enum.GetValues(typeof(UserType));

            _autocompleteMenu = new AutocompleteMenu(txtCommandText)
            {
                AllowTabKey = true,
                SearchPattern = @"[\w\.:=!<>]"
            };
            FillAutoCompleteMenu();
        }

        private void FillAutoCompleteMenu()
        {
            var items = new List<AutocompleteItem>();

            items.Add(new MusicPlayerAutoCompleteItem("Song"));
            items.Add(new MusicPlayerAutoCompleteItem("Artist"));
            items.Add(new MusicPlayerAutoCompleteItem("Title"));

            _autocompleteMenu.Items.SetAutocompleteItems(items);
        }

        private void OnBtnAddClick(object sender, EventArgs e)
        {
            txtCommandName.Text = "!myCommand";
            txtShortDescription.Text = "The short description here";
            txtCommandText.Text = "The text that should be send to the chat";
        }

        private void OnBtnSaveClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCommandName.Text) || string.IsNullOrEmpty(txtCommandText.Text))
            {
                MessageBox.Show("Please fill all fields!", "Fill all fields", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            if (!txtCommandName.Text.StartsWith("!"))
                txtCommandName.Text = "!" + txtCommandText.Text;

            var command = _settings.Commands.FirstOrDefault(x =>
                x.CommandName.Equals(txtCommandName.Text, StringComparison.OrdinalIgnoreCase));
            if (command == null)
            {
                command = new Command();
                command.CommandName = txtCommandName.Text;
                lbCommands.Items.Add(command);
            }
            command.CommandText = txtCommandText.Text;
            command.ShortDescription = txtShortDescription.Text;
            command.UserType = (UserType) cmbUserTypes.SelectedItem;
            if (_settings.Commands == null)
                _settings.Commands = new List<Command>();
            _settings.Commands.Add(command);


            txtCommandText.Text = "";
            txtCommandName.Text = "";
            txtShortDescription.Text = "";
            cmbUserTypes.SelectedItem = UserType.Viewer;
            FrmMain.ReceivedNotification?.Invoke(null, new NotificationEventArgs
            {
                Message = "The command has been saved successfully",
                Type = CustomNotificationType.Success
            });
        }

        private void OnBtnRemoveClick(object sender, EventArgs e)
        {
            if (lbCommands.SelectedItem == null)
                return;
            var selectedItem = (Command) lbCommands.SelectedItem;
            
            if (_settings.Commands != null)
                _settings.Commands.Remove(selectedItem);
            lbCommands.Items.Remove(selectedItem);
        }

        private void OnBtnEditClick(object sender, EventArgs e)
        {
            if (lbCommands.SelectedItem == null)
                return;
            var selectedItem = (Command)lbCommands.SelectedItem;

            txtCommandName.Text = selectedItem.CommandName;
            txtShortDescription.Text = selectedItem.ShortDescription;
            txtCommandText.Text = selectedItem.CommandText;
            cmbUserTypes.SelectedItem = selectedItem.UserType;

        }
    }
}
