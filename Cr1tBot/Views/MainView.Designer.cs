namespace Cr1tBot.Views
{
    partial class MainView
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
            this.btnSend = new Cr1TiKa7_Framework.Controls.Button.FlatButton();
            this.txtCommandText = new Cr1TiKa7_Framework.Controls.TextBox.FlatTextBox();
            this.lbChat = new Cr1TiKa7_Framework.Controls.ListBox.CustomListBox();
            this.txtTitle = new System.Windows.Forms.Label();
            this.txtGame = new System.Windows.Forms.Label();
            this.txtFollower = new System.Windows.Forms.Label();
            this.txtViews = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnSend.Icon = null;
            this.btnSend.Location = new System.Drawing.Point(490, 297);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            // 
            // txtCommandText
            // 
            this.txtCommandText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommandText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.txtCommandText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCommandText.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtCommandText.ForeColor = System.Drawing.Color.White;
            this.txtCommandText.Location = new System.Drawing.Point(12, 299);
            this.txtCommandText.Name = "txtCommandText";
            this.txtCommandText.Size = new System.Drawing.Size(472, 20);
            this.txtCommandText.TabIndex = 5;
            // 
            // lbChat
            // 
            this.lbChat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbChat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lbChat.EnableNotification = false;
            this.lbChat.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lbChat.FormattingEnabled = true;
            this.lbChat.ItemHeight = 16;
            this.lbChat.ItemSelectionColor = System.Drawing.Color.DarkSlateGray;
            this.lbChat.ItemsSelectable = true;
            this.lbChat.Location = new System.Drawing.Point(12, 59);
            this.lbChat.Name = "lbChat";
            this.lbChat.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.lbChat.Size = new System.Drawing.Size(553, 234);
            this.lbChat.TabIndex = 4;
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Location = new System.Drawing.Point(38, 38);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(38, 13);
            this.txtTitle.TabIndex = 7;
            this.txtTitle.Text = "label1";
            // 
            // txtGame
            // 
            this.txtGame.AutoSize = true;
            this.txtGame.Location = new System.Drawing.Point(38, 15);
            this.txtGame.Name = "txtGame";
            this.txtGame.Size = new System.Drawing.Size(38, 13);
            this.txtGame.TabIndex = 8;
            this.txtGame.Text = "label2";
            // 
            // txtFollower
            // 
            this.txtFollower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFollower.AutoSize = true;
            this.txtFollower.Location = new System.Drawing.Point(387, 34);
            this.txtFollower.Name = "txtFollower";
            this.txtFollower.Size = new System.Drawing.Size(38, 13);
            this.txtFollower.TabIndex = 9;
            this.txtFollower.Text = "label2";
            // 
            // txtViews
            // 
            this.txtViews.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtViews.AutoSize = true;
            this.txtViews.Location = new System.Drawing.Point(387, 11);
            this.txtViews.Name = "txtViews";
            this.txtViews.Size = new System.Drawing.Size(38, 13);
            this.txtViews.TabIndex = 10;
            this.txtViews.Text = "label2";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackgroundImage = global::Cr1tBot.Properties.Resources.Follower;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(361, 30);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 22);
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackgroundImage = global::Cr1tBot.Properties.Resources.Viewer;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(361, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 22);
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Cr1tBot.Properties.Resources.Game;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(12, 34);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 22);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Cr1tBot.Properties.Resources.Title;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 22);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtViews);
            this.Controls.Add(this.txtFollower);
            this.Controls.Add(this.txtGame);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtCommandText);
            this.Controls.Add(this.lbChat);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MainView";
            this.Size = new System.Drawing.Size(577, 331);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Cr1TiKa7_Framework.Controls.Button.FlatButton btnSend;
        private Cr1TiKa7_Framework.Controls.TextBox.FlatTextBox txtCommandText;
        private Cr1TiKa7_Framework.Controls.ListBox.CustomListBox lbChat;
        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.Label txtGame;
        private System.Windows.Forms.Label txtFollower;
        private System.Windows.Forms.Label txtViews;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}
