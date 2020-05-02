namespace Cr1tBot.Views.Game
{
    partial class GameView
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
            this.btnRemove = new Cr1TiKa7_Framework.Controls.Button.FlatButton();
            this.btnAdd = new Cr1TiKa7_Framework.Controls.Button.FlatButton();
            this.customListBox1 = new Cr1TiKa7_Framework.Controls.ListBox.CustomListBox();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnRemove.Icon = null;
            this.btnRemove.Location = new System.Drawing.Point(92, 324);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 2;
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
            this.btnAdd.Location = new System.Drawing.Point(15, 324);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.OnBtnAddGame);
            // 
            // customListBox1
            // 
            this.customListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.customListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.customListBox1.EnableNotification = false;
            this.customListBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.customListBox1.FormattingEnabled = true;
            this.customListBox1.ItemHeight = 16;
            this.customListBox1.ItemSelectionColor = System.Drawing.Color.DarkSlateGray;
            this.customListBox1.ItemsSelectable = true;
            this.customListBox1.Location = new System.Drawing.Point(15, 14);
            this.customListBox1.Name = "customListBox1";
            this.customListBox1.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.customListBox1.Size = new System.Drawing.Size(152, 304);
            this.customListBox1.Sorted = true;
            this.customListBox1.TabIndex = 0;
            // 
            // GameView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.customListBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "GameView";
            this.Size = new System.Drawing.Size(622, 360);
            this.ResumeLayout(false);

        }

        #endregion

        private Cr1TiKa7_Framework.Controls.ListBox.CustomListBox customListBox1;
        private Cr1TiKa7_Framework.Controls.Button.FlatButton btnAdd;
        private Cr1TiKa7_Framework.Controls.Button.FlatButton btnRemove;
    }
}
