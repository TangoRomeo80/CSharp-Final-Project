
namespace WalletBuddy.Forms
{
  partial class LoginUser
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUser));
      this.mainLabel = new System.Windows.Forms.Label();
      this.headerPanel = new System.Windows.Forms.Panel();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.infoLabel = new System.Windows.Forms.Label();
      this.userNameLabel = new System.Windows.Forms.Label();
      this.passwordLabel = new System.Windows.Forms.Label();
      this.showPassCheckBox = new System.Windows.Forms.CheckBox();
      this.clearButton = new WalletBuddy.CustomControl.RJButton();
      this.signInButton = new WalletBuddy.CustomControl.RJButton();
      this.passwordTextBox = new WalletBuddy.CustomControl.RJTextBox();
      this.userNameTextBox = new WalletBuddy.CustomControl.RJTextBox();
      this.signUpLabel = new System.Windows.Forms.Label();
      this.dontHaveAccountLabel = new System.Windows.Forms.Label();
      this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
      this.backToWelcomeLabel = new System.Windows.Forms.Label();
      this.headerPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // mainLabel
      // 
      this.mainLabel.AutoSize = true;
      this.mainLabel.BackColor = System.Drawing.Color.Transparent;
      this.mainLabel.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.mainLabel.ForeColor = System.Drawing.Color.White;
      this.mainLabel.Location = new System.Drawing.Point(8, 17);
      this.mainLabel.Name = "mainLabel";
      this.mainLabel.Size = new System.Drawing.Size(261, 46);
      this.mainLabel.TabIndex = 0;
      this.mainLabel.Text = "Welcome back!";
      // 
      // headerPanel
      // 
      this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(5)))), ((int)(((byte)(227)))));
      this.headerPanel.Controls.Add(this.pictureBox1);
      this.headerPanel.Controls.Add(this.mainLabel);
      this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
      this.headerPanel.Location = new System.Drawing.Point(0, 0);
      this.headerPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.headerPanel.Name = "headerPanel";
      this.headerPanel.Size = new System.Drawing.Size(624, 82);
      this.headerPanel.TabIndex = 1;
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(549, 17);
      this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(61, 50);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 1;
      this.pictureBox1.TabStop = false;
      // 
      // infoLabel
      // 
      this.infoLabel.AutoSize = true;
      this.infoLabel.BackColor = System.Drawing.Color.Transparent;
      this.infoLabel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.infoLabel.ForeColor = System.Drawing.Color.DimGray;
      this.infoLabel.Location = new System.Drawing.Point(11, 86);
      this.infoLabel.Name = "infoLabel";
      this.infoLabel.Size = new System.Drawing.Size(456, 35);
      this.infoLabel.TabIndex = 2;
      this.infoLabel.Text = "Provide required information to sign in";
      // 
      // userNameLabel
      // 
      this.userNameLabel.AutoSize = true;
      this.userNameLabel.BackColor = System.Drawing.Color.Transparent;
      this.userNameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.userNameLabel.ForeColor = System.Drawing.Color.DimGray;
      this.userNameLabel.Location = new System.Drawing.Point(12, 158);
      this.userNameLabel.Name = "userNameLabel";
      this.userNameLabel.Size = new System.Drawing.Size(95, 24);
      this.userNameLabel.TabIndex = 3;
      this.userNameLabel.Text = "Username";
      // 
      // passwordLabel
      // 
      this.passwordLabel.AutoSize = true;
      this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
      this.passwordLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.passwordLabel.ForeColor = System.Drawing.Color.DimGray;
      this.passwordLabel.Location = new System.Drawing.Point(12, 262);
      this.passwordLabel.Name = "passwordLabel";
      this.passwordLabel.Size = new System.Drawing.Size(89, 24);
      this.passwordLabel.TabIndex = 3;
      this.passwordLabel.Text = "Password";
      // 
      // showPassCheckBox
      // 
      this.showPassCheckBox.AutoSize = true;
      this.showPassCheckBox.BackColor = System.Drawing.Color.Transparent;
      this.showPassCheckBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.showPassCheckBox.ForeColor = System.Drawing.Color.DimGray;
      this.showPassCheckBox.Location = new System.Drawing.Point(16, 358);
      this.showPassCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.showPassCheckBox.Name = "showPassCheckBox";
      this.showPassCheckBox.Size = new System.Drawing.Size(153, 28);
      this.showPassCheckBox.TabIndex = 5;
      this.showPassCheckBox.Text = "Show Pasword";
      this.showPassCheckBox.UseVisualStyleBackColor = false;
      this.showPassCheckBox.CheckedChanged += new System.EventHandler(this.showPassCheckBox_CheckedChanged);
      // 
      // clearButton
      // 
      this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(5)))), ((int)(((byte)(227)))));
      this.clearButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(5)))), ((int)(((byte)(227)))));
      this.clearButton.BorderColor = System.Drawing.Color.Blue;
      this.clearButton.BorderRadius = 20;
      this.clearButton.BorderSize = 1;
      this.clearButton.FlatAppearance.BorderSize = 0;
      this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.clearButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.clearButton.ForeColor = System.Drawing.Color.White;
      this.clearButton.Location = new System.Drawing.Point(176, 519);
      this.clearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.clearButton.Name = "clearButton";
      this.clearButton.Size = new System.Drawing.Size(273, 62);
      this.clearButton.TabIndex = 6;
      this.clearButton.Text = "Clear Fields";
      this.clearButton.TextColor = System.Drawing.Color.White;
      this.clearButton.UseVisualStyleBackColor = false;
      this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
      // 
      // signInButton
      // 
      this.signInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(5)))), ((int)(((byte)(227)))));
      this.signInButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(5)))), ((int)(((byte)(227)))));
      this.signInButton.BorderColor = System.Drawing.Color.Blue;
      this.signInButton.BorderRadius = 20;
      this.signInButton.BorderSize = 1;
      this.signInButton.FlatAppearance.BorderSize = 0;
      this.signInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.signInButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.signInButton.ForeColor = System.Drawing.Color.White;
      this.signInButton.Location = new System.Drawing.Point(176, 436);
      this.signInButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.signInButton.Name = "signInButton";
      this.signInButton.Size = new System.Drawing.Size(273, 62);
      this.signInButton.TabIndex = 6;
      this.signInButton.Text = "Sign In";
      this.signInButton.TextColor = System.Drawing.Color.White;
      this.signInButton.UseVisualStyleBackColor = false;
      this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
      // 
      // passwordTextBox
      // 
      this.passwordTextBox.BackColor = System.Drawing.SystemColors.Window;
      this.passwordTextBox.BorderColor = System.Drawing.Color.CornflowerBlue;
      this.passwordTextBox.BorderFocusColor = System.Drawing.Color.Blue;
      this.passwordTextBox.BorderRadius = 10;
      this.passwordTextBox.BorderSize = 2;
      this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.passwordTextBox.Location = new System.Drawing.Point(13, 300);
      this.passwordTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
      this.passwordTextBox.Multiline = false;
      this.passwordTextBox.Name = "passwordTextBox";
      this.passwordTextBox.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
      this.passwordTextBox.PasswordChar = true;
      this.passwordTextBox.PlaceholderColor = System.Drawing.Color.Silver;
      this.passwordTextBox.PlaceholderText = "Password";
      this.passwordTextBox.Size = new System.Drawing.Size(597, 35);
      this.passwordTextBox.TabIndex = 1;
      this.passwordTextBox.Texts = "";
      this.passwordTextBox.UnderlinedStyle = false;
      // 
      // userNameTextBox
      // 
      this.userNameTextBox.BackColor = System.Drawing.SystemColors.Window;
      this.userNameTextBox.BorderColor = System.Drawing.Color.CornflowerBlue;
      this.userNameTextBox.BorderFocusColor = System.Drawing.Color.Blue;
      this.userNameTextBox.BorderRadius = 10;
      this.userNameTextBox.BorderSize = 2;
      this.userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.userNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.userNameTextBox.Location = new System.Drawing.Point(13, 194);
      this.userNameTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
      this.userNameTextBox.Multiline = false;
      this.userNameTextBox.Name = "userNameTextBox";
      this.userNameTextBox.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
      this.userNameTextBox.PasswordChar = false;
      this.userNameTextBox.PlaceholderColor = System.Drawing.Color.Silver;
      this.userNameTextBox.PlaceholderText = "Username";
      this.userNameTextBox.Size = new System.Drawing.Size(597, 35);
      this.userNameTextBox.TabIndex = 0;
      this.userNameTextBox.Texts = "";
      this.userNameTextBox.UnderlinedStyle = false;
      // 
      // signUpLabel
      // 
      this.signUpLabel.AutoSize = true;
      this.signUpLabel.BackColor = System.Drawing.Color.Transparent;
      this.signUpLabel.Cursor = System.Windows.Forms.Cursors.Hand;
      this.signUpLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.signUpLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
      this.signUpLabel.Location = new System.Drawing.Point(384, 601);
      this.signUpLabel.Name = "signUpLabel";
      this.signUpLabel.Size = new System.Drawing.Size(73, 24);
      this.signUpLabel.TabIndex = 7;
      this.signUpLabel.Text = "Sign Up";
      this.signUpLabel.Click += new System.EventHandler(this.signUpLabel_Click);
      // 
      // dontHaveAccountLabel
      // 
      this.dontHaveAccountLabel.AutoSize = true;
      this.dontHaveAccountLabel.BackColor = System.Drawing.Color.Transparent;
      this.dontHaveAccountLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dontHaveAccountLabel.ForeColor = System.Drawing.Color.DimGray;
      this.dontHaveAccountLabel.Location = new System.Drawing.Point(172, 601);
      this.dontHaveAccountLabel.Name = "dontHaveAccountLabel";
      this.dontHaveAccountLabel.Size = new System.Drawing.Size(206, 24);
      this.dontHaveAccountLabel.TabIndex = 8;
      this.dontHaveAccountLabel.Text = "Don\'t have an account?";
      // 
      // kryptonPalette1
      // 
      this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color1 = System.Drawing.Color.White;
      this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color2 = System.Drawing.Color.White;
      this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.White;
      this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.White;
      // 
      // backToWelcomeLabel
      // 
      this.backToWelcomeLabel.AutoSize = true;
      this.backToWelcomeLabel.BackColor = System.Drawing.Color.Transparent;
      this.backToWelcomeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
      this.backToWelcomeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.backToWelcomeLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
      this.backToWelcomeLabel.Location = new System.Drawing.Point(215, 624);
      this.backToWelcomeLabel.Name = "backToWelcomeLabel";
      this.backToWelcomeLabel.Size = new System.Drawing.Size(197, 24);
      this.backToWelcomeLabel.TabIndex = 9;
      this.backToWelcomeLabel.Text = "Back to Welcome Page";
      this.backToWelcomeLabel.Click += new System.EventHandler(this.backToWelcomeLabel_Click);
      // 
      // LoginUser
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(624, 753);
      this.Controls.Add(this.backToWelcomeLabel);
      this.Controls.Add(this.signUpLabel);
      this.Controls.Add(this.dontHaveAccountLabel);
      this.Controls.Add(this.clearButton);
      this.Controls.Add(this.signInButton);
      this.Controls.Add(this.showPassCheckBox);
      this.Controls.Add(this.passwordTextBox);
      this.Controls.Add(this.passwordLabel);
      this.Controls.Add(this.userNameTextBox);
      this.Controls.Add(this.userNameLabel);
      this.Controls.Add(this.infoLabel);
      this.Controls.Add(this.headerPanel);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "LoginUser";
      this.Palette = this.kryptonPalette1;
      this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Wallet Buddy";
      this.headerPanel.ResumeLayout(false);
      this.headerPanel.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label mainLabel;
    private System.Windows.Forms.Panel headerPanel;
    private System.Windows.Forms.Label infoLabel;
    private System.Windows.Forms.Label userNameLabel;
    private CustomControl.RJTextBox userNameTextBox;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label passwordLabel;
    private CustomControl.RJTextBox passwordTextBox;
    private System.Windows.Forms.CheckBox showPassCheckBox;
    private CustomControl.RJButton signInButton;
    private CustomControl.RJButton clearButton;
    private System.Windows.Forms.Label signUpLabel;
    private System.Windows.Forms.Label dontHaveAccountLabel;
    private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
    private System.Windows.Forms.Label backToWelcomeLabel;
  }
}