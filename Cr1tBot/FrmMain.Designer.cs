namespace Cr1tBot
{
    partial class FrmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sideBar = new Cr1TiKa7_Framework.Controls.SideBar.SideBar();
            this.pnlCustomControl = new Cr1TiKa7_Framework.Controls.Panel.FlatPanel();
            this.SuspendLayout();
            // 
            // sideBar
            // 
            this.sideBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sideBar.BackColor = System.Drawing.Color.Transparent;
            this.sideBar.HoverColor = System.Drawing.Color.Gray;
            this.sideBar.Location = new System.Drawing.Point(4, 56);
            this.sideBar.Name = "sideBar";
            this.sideBar.ShowText = false;
            this.sideBar.Size = new System.Drawing.Size(50, 357);
            this.sideBar.TabIndex = 2;
            // 
            // pnlCustomControl
            // 
            this.pnlCustomControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCustomControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.pnlCustomControl.CausesValidation = false;
            this.pnlCustomControl.Location = new System.Drawing.Point(60, 56);
            this.pnlCustomControl.Name = "pnlCustomControl";
            this.pnlCustomControl.Size = new System.Drawing.Size(688, 352);
            this.pnlCustomControl.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 420);
            this.Controls.Add(this.pnlCustomControl);
            this.Controls.Add(this.sideBar);
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cr1TBot by Cr1TiKa7";
            this.Shown += new System.EventHandler(this.OnFrmMainShown);
            this.Controls.SetChildIndex(this.sideBar, 0);
            this.Controls.SetChildIndex(this.pnlCustomControl, 0);
            this.ResumeLayout(false);

        }

        #endregion
        private Cr1TiKa7_Framework.Controls.SideBar.SideBar sideBar;
        private Cr1TiKa7_Framework.Controls.Panel.FlatPanel pnlCustomControl;
    }
}

