
namespace WalletBuddy.Forms
{
  partial class AdminMain
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMain));
      this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
      this.headerPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
      this.logOutLabel = new System.Windows.Forms.Label();
      this.topAdminLabel = new System.Windows.Forms.Label();
      this.logoutPicBox = new System.Windows.Forms.PictureBox();
      this.userPicBox = new System.Windows.Forms.PictureBox();
      this.mainLabel = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.buttonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
      this.settingsButton = new WalletBuddy.CustomControl.RJButton();
      this.supportButton = new WalletBuddy.CustomControl.RJButton();
      this.userListButton = new WalletBuddy.CustomControl.RJButton();
      this.panelDesktopPane = new System.Windows.Forms.Panel();
      ((System.ComponentModel.ISupportInitialize)(this.headerPanel)).BeginInit();
      this.headerPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.logoutPicBox)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.userPicBox)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.buttonPanel)).BeginInit();
      this.buttonPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // kryptonPalette1
      // 
      this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color1 = System.Drawing.Color.White;
      this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color2 = System.Drawing.Color.White;
      this.kryptonPalette1.HeaderStyles.HeaderCommon.StateCommon.Back.Color1 = System.Drawing.Color.White;
      this.kryptonPalette1.HeaderStyles.HeaderCommon.StateCommon.Back.Color2 = System.Drawing.Color.White;
      // 
      // headerPanel
      // 
      this.headerPanel.Controls.Add(this.logOutLabel);
      this.headerPanel.Controls.Add(this.topAdminLabel);
      this.headerPanel.Controls.Add(this.logoutPicBox);
      this.headerPanel.Controls.Add(this.userPicBox);
      this.headerPanel.Controls.Add(this.mainLabel);
      this.headerPanel.Controls.Add(this.pictureBox1);
      this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
      this.headerPanel.Location = new System.Drawing.Point(0, 0);
      this.headerPanel.Margin = new System.Windows.Forms.Padding(2);
      this.headerPanel.Name = "headerPanel";
      this.headerPanel.Size = new System.Drawing.Size(927, 136);
      this.headerPanel.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(5)))), ((int)(((byte)(227)))));
      this.headerPanel.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(5)))), ((int)(((byte)(227)))));
      this.headerPanel.TabIndex = 0;
      // 
      // logOutLabel
      // 
      this.logOutLabel.AutoSize = true;
      this.logOutLabel.BackColor = System.Drawing.Color.Transparent;
      this.logOutLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.logOutLabel.ForeColor = System.Drawing.Color.White;
      this.logOutLabel.Location = new System.Drawing.Point(705, 25);
      this.logOutLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.logOutLabel.Name = "logOutLabel";
      this.logOutLabel.Size = new System.Drawing.Size(52, 17);
      this.logOutLabel.TabIndex = 4;
      this.logOutLabel.Text = "Log Out";
      this.logOutLabel.Click += new System.EventHandler(this.logOutLabel_Click);
      // 
      // topAdminLabel
      // 
      this.topAdminLabel.AutoSize = true;
      this.topAdminLabel.BackColor = System.Drawing.Color.Transparent;
      this.topAdminLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.topAdminLabel.ForeColor = System.Drawing.Color.White;
      this.topAdminLabel.Location = new System.Drawing.Point(804, 25);
      this.topAdminLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.topAdminLabel.Name = "topAdminLabel";
      this.topAdminLabel.Size = new System.Drawing.Size(71, 17);
      this.topAdminLabel.TabIndex = 4;
      this.topAdminLabel.Text = "User Name";
      // 
      // logoutPicBox
      // 
      this.logoutPicBox.BackColor = System.Drawing.Color.Transparent;
      this.logoutPicBox.Image = ((System.Drawing.Image)(resources.GetObject("logoutPicBox.Image")));
      this.logoutPicBox.Location = new System.Drawing.Point(675, 17);
      this.logoutPicBox.Margin = new System.Windows.Forms.Padding(2);
      this.logoutPicBox.Name = "logoutPicBox";
      this.logoutPicBox.Size = new System.Drawing.Size(32, 32);
      this.logoutPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.logoutPicBox.TabIndex = 3;
      this.logoutPicBox.TabStop = false;
      // 
      // userPicBox
      // 
      this.userPicBox.BackColor = System.Drawing.Color.Transparent;
      this.userPicBox.Image = ((System.Drawing.Image)(resources.GetObject("userPicBox.Image")));
      this.userPicBox.Location = new System.Drawing.Point(770, 17);
      this.userPicBox.Margin = new System.Windows.Forms.Padding(2);
      this.userPicBox.Name = "userPicBox";
      this.userPicBox.Size = new System.Drawing.Size(30, 30);
      this.userPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.userPicBox.TabIndex = 3;
      this.userPicBox.TabStop = false;
      // 
      // mainLabel
      // 
      this.mainLabel.AutoSize = true;
      this.mainLabel.BackColor = System.Drawing.Color.Transparent;
      this.mainLabel.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.mainLabel.ForeColor = System.Drawing.Color.White;
      this.mainLabel.Location = new System.Drawing.Point(60, 10);
      this.mainLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.mainLabel.Name = "mainLabel";
      this.mainLabel.Size = new System.Drawing.Size(183, 37);
      this.mainLabel.TabIndex = 1;
      this.mainLabel.Text = "Wallet Buddy";
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(9, 10);
      this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(46, 41);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 2;
      this.pictureBox1.TabStop = false;
      // 
      // buttonPanel
      // 
      this.buttonPanel.Controls.Add(this.settingsButton);
      this.buttonPanel.Controls.Add(this.supportButton);
      this.buttonPanel.Controls.Add(this.userListButton);
      this.buttonPanel.Location = new System.Drawing.Point(0, 66);
      this.buttonPanel.Margin = new System.Windows.Forms.Padding(2);
      this.buttonPanel.Name = "buttonPanel";
      this.buttonPanel.Size = new System.Drawing.Size(927, 71);
      this.buttonPanel.StateCommon.Color1 = System.Drawing.Color.AliceBlue;
      this.buttonPanel.StateCommon.Color2 = System.Drawing.Color.AliceBlue;
      this.buttonPanel.TabIndex = 1;
      // 
      // settingsButton
      // 
      this.settingsButton.BackColor = System.Drawing.Color.White;
      this.settingsButton.BackgroundColor = System.Drawing.Color.White;
      this.settingsButton.BorderColor = System.Drawing.Color.Blue;
      this.settingsButton.BorderRadius = 10;
      this.settingsButton.BorderSize = 1;
      this.settingsButton.FlatAppearance.BorderSize = 0;
      this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.settingsButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.settingsButton.ForeColor = System.Drawing.Color.SlateGray;
      this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
      this.settingsButton.Location = new System.Drawing.Point(876, 13);
      this.settingsButton.Margin = new System.Windows.Forms.Padding(2);
      this.settingsButton.Name = "settingsButton";
      this.settingsButton.Size = new System.Drawing.Size(40, 37);
      this.settingsButton.TabIndex = 3;
      this.settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.settingsButton.TextColor = System.Drawing.Color.SlateGray;
      this.settingsButton.UseVisualStyleBackColor = false;
      this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
      // 
      // supportButton
      // 
      this.supportButton.BackColor = System.Drawing.Color.White;
      this.supportButton.BackgroundColor = System.Drawing.Color.White;
      this.supportButton.BorderColor = System.Drawing.Color.Blue;
      this.supportButton.BorderRadius = 10;
      this.supportButton.BorderSize = 1;
      this.supportButton.FlatAppearance.BorderSize = 0;
      this.supportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.supportButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.supportButton.ForeColor = System.Drawing.Color.SlateGray;
      this.supportButton.Image = ((System.Drawing.Image)(resources.GetObject("supportButton.Image")));
      this.supportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.supportButton.Location = new System.Drawing.Point(140, 13);
      this.supportButton.Margin = new System.Windows.Forms.Padding(2);
      this.supportButton.Name = "supportButton";
      this.supportButton.Size = new System.Drawing.Size(112, 37);
      this.supportButton.TabIndex = 0;
      this.supportButton.Text = "Support";
      this.supportButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.supportButton.TextColor = System.Drawing.Color.SlateGray;
      this.supportButton.UseVisualStyleBackColor = false;
      this.supportButton.Click += new System.EventHandler(this.supportButton_Click);
      // 
      // userListButton
      // 
      this.userListButton.BackColor = System.Drawing.Color.White;
      this.userListButton.BackgroundColor = System.Drawing.Color.White;
      this.userListButton.BorderColor = System.Drawing.Color.Blue;
      this.userListButton.BorderRadius = 10;
      this.userListButton.BorderSize = 1;
      this.userListButton.FlatAppearance.BorderSize = 0;
      this.userListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.userListButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.userListButton.ForeColor = System.Drawing.Color.SlateGray;
      this.userListButton.Image = ((System.Drawing.Image)(resources.GetObject("userListButton.Image")));
      this.userListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.userListButton.Location = new System.Drawing.Point(24, 13);
      this.userListButton.Margin = new System.Windows.Forms.Padding(2);
      this.userListButton.Name = "userListButton";
      this.userListButton.Size = new System.Drawing.Size(112, 37);
      this.userListButton.TabIndex = 0;
      this.userListButton.Text = "User List";
      this.userListButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.userListButton.TextColor = System.Drawing.Color.SlateGray;
      this.userListButton.UseVisualStyleBackColor = false;
      this.userListButton.Click += new System.EventHandler(this.userListButton_Click);
      // 
      // panelDesktopPane
      // 
      this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelDesktopPane.Location = new System.Drawing.Point(0, 136);
      this.panelDesktopPane.Margin = new System.Windows.Forms.Padding(2);
      this.panelDesktopPane.Name = "panelDesktopPane";
      this.panelDesktopPane.Size = new System.Drawing.Size(927, 430);
      this.panelDesktopPane.TabIndex = 2;
      // 
      // AdminMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(927, 566);
      this.Controls.Add(this.panelDesktopPane);
      this.Controls.Add(this.buttonPanel);
      this.Controls.Add(this.headerPanel);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "AdminMain";
      this.Palette = this.kryptonPalette1;
      this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Wallet Buddy";
      this.Activated += new System.EventHandler(this.AdminMain_Activated);
      ((System.ComponentModel.ISupportInitialize)(this.headerPanel)).EndInit();
      this.headerPanel.ResumeLayout(false);
      this.headerPanel.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.logoutPicBox)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.userPicBox)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.buttonPanel)).EndInit();
      this.buttonPanel.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
    private ComponentFactory.Krypton.Toolkit.KryptonPanel headerPanel;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label mainLabel;
    private ComponentFactory.Krypton.Toolkit.KryptonPanel buttonPanel;
    private CustomControl.RJButton userListButton;
    private System.Windows.Forms.PictureBox userPicBox;
    private System.Windows.Forms.Panel panelDesktopPane;
    private System.Windows.Forms.Label logOutLabel;
    private System.Windows.Forms.Label topAdminLabel;
    private System.Windows.Forms.PictureBox logoutPicBox;
    private CustomControl.RJButton supportButton;
    private CustomControl.RJButton settingsButton;
  }
}