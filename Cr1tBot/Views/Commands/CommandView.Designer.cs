namespace Cr1tBot.Views.Commands
{
    partial class CommandView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommandView));
            this.txtCommandText = new FastColoredTextBoxNS.FastColoredTextBox();
            this.lbCommands = new Cr1TiKa7_Framework.Controls.ListBox.CustomListBox();
            this.txtCommandName = new Cr1TiKa7_Framework.Controls.TextBox.FlatTextBox();
            this.lblCommandName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemove = new Cr1TiKa7_Framework.Controls.Button.FlatButton();
            this.btnAdd = new Cr1TiKa7_Framework.Controls.Button.FlatButton();
            this.btnSave = new Cr1TiKa7_Framework.Controls.Button.FlatButton();
            this.cmbUserTypes = new Cr1TiKa7_Framework.Controls.ComboBox.FlatCombobox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtShortDescription = new Cr1TiKa7_Framework.Controls.TextBox.FlatTextBox();
            this.btnEdit = new Cr1TiKa7_Framework.Controls.Button.FlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtCommandText)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCommandText
            // 
            this.txtCommandText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommandText.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.txtCommandText.AutoScrollMinSize = new System.Drawing.Size(2, 16);
            this.txtCommandText.BackBrush = null;
            this.txtCommandText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.txtCommandText.CaretColor = System.Drawing.Color.White;
            this.txtCommandText.CharHeight = 16;
            this.txtCommandText.CharWidth = 9;
            this.txtCommandText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCommandText.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtCommandText.Font = new System.Drawing.Font("Courier New", 11.25F);
            this.txtCommandText.ForeColor = System.Drawing.Color.White;
            this.txtCommandText.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtCommandText.IsReplaceMode = false;
            this.txtCommandText.Location = new System.Drawing.Point(182, 123);
            this.txtCommandText.Name = "txtCommandText";
            this.txtCommandText.Paddings = new System.Windows.Forms.Padding(0);
            this.txtCommandText.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtCommandText.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtCommandText.ServiceColors")));
            this.txtCommandText.ShowLineNumbers = false;
            this.txtCommandText.Size = new System.Drawing.Size(421, 194);
            this.txtCommandText.TabIndex = 0;
            this.txtCommandText.Zoom = 100;
            // 
            // lbCommands
            // 
            this.lbCommands.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCommands.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbCommands.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lbCommands.EnableNotification = false;
            this.lbCommands.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lbCommands.FormattingEnabled = true;
            this.lbCommands.ItemHeight = 16;
            this.lbCommands.ItemSelectionColor = System.Drawing.Color.DarkSlateGray;
            this.lbCommands.ItemsSelectable = true;
            this.lbCommands.Location = new System.Drawing.Point(13, 13);
            this.lbCommands.Name = "lbCommands";
            this.lbCommands.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.lbCommands.Size = new System.Drawing.Size(152, 304);
            this.lbCommands.TabIndex = 1;
            // 
            // txtCommandName
            // 
            this.txtCommandName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommandName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.txtCommandName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCommandName.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtCommandName.ForeColor = System.Drawing.Color.White;
            this.txtCommandName.Location = new System.Drawing.Point(182, 29);
            this.txtCommandName.Name = "txtCommandName";
            this.txtCommandName.Size = new System.Drawing.Size(208, 20);
            this.txtCommandName.TabIndex = 2;
            // 
            // lblCommandName
            // 
            this.lblCommandName.AutoSize = true;
            this.lblCommandName.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblCommandName.ForeColor = System.Drawing.Color.White;
            this.lblCommandName.Location = new System.Drawing.Point(179, 13);
            this.lblCommandName.Name = "lblCommandName";
            this.lblCommandName.Size = new System.Drawing.Size(62, 13);
            this.lblCommandName.TabIndex = 3;
            this.lblCommandName.Text = "Command:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(179, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Command text:";
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnRemove.Icon = null;
            this.btnRemove.Location = new System.Drawing.Point(119, 323);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(46, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.OnBtnRemoveClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(13, 323);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(44, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.OnBtnAddClick);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(528, 323);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.OnBtnSaveClick);
            // 
            // cmbUserTypes
            // 
            this.cmbUserTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUserTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.cmbUserTypes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUserTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUserTypes.FormattingEnabled = true;
            this.cmbUserTypes.Location = new System.Drawing.Point(416, 29);
            this.cmbUserTypes.MaxDropDownItems = 5;
            this.cmbUserTypes.Name = "cmbUserTypes";
            this.cmbUserTypes.Size = new System.Drawing.Size(187, 21);
            this.cmbUserTypes.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(413, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Usertype:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(179, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Short description:";
            // 
            // txtShortDescription
            // 
            this.txtShortDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtShortDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.txtShortDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtShortDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtShortDescription.ForeColor = System.Drawing.Color.White;
            this.txtShortDescription.Location = new System.Drawing.Point(182, 74);
            this.txtShortDescription.Name = "txtShortDescription";
            this.txtShortDescription.Size = new System.Drawing.Size(421, 20);
            this.txtShortDescription.TabIndex = 10;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnEdit.Icon = null;
            this.btnEdit.Location = new System.Drawing.Point(63, 323);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(50, 23);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.OnBtnEditClick);
            // 
            // CommandView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtShortDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUserTypes);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCommandName);
            this.Controls.Add(this.txtCommandName);
            this.Controls.Add(this.lbCommands);
            this.Controls.Add(this.txtCommandText);
            this.Name = "CommandView";
            this.Size = new System.Drawing.Size(622, 360);
            ((System.ComponentModel.ISupportInitialize)(this.txtCommandText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox txtCommandText;
        private Cr1TiKa7_Framework.Controls.ListBox.CustomListBox lbCommands;
        private Cr1TiKa7_Framework.Controls.TextBox.FlatTextBox txtCommandName;
        private System.Windows.Forms.Label lblCommandName;
        private System.Windows.Forms.Label label2;
        private Cr1TiKa7_Framework.Controls.Button.FlatButton btnRemove;
        private Cr1TiKa7_Framework.Controls.Button.FlatButton btnAdd;
        private Cr1TiKa7_Framework.Controls.Button.FlatButton btnSave;
        private Cr1TiKa7_Framework.Controls.ComboBox.FlatCombobox cmbUserTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Cr1TiKa7_Framework.Controls.TextBox.FlatTextBox txtShortDescription;
        private Cr1TiKa7_Framework.Controls.Button.FlatButton btnEdit;
    }
}
