
namespace WalletBuddy.Forms
{
  partial class RegisterUser
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterUser));
      this.mainLabel = new System.Windows.Forms.Label();
      this.headerPanel = new System.Windows.Forms.Panel();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.infoLabel = new System.Windows.Forms.Label();
      this.userNameLabel = new System.Windows.Forms.Label();
      this.emailLabel = new System.Windows.Forms.Label();
      this.passwordLabel = new System.Windows.Forms.Label();
      this.showPassCheckBox = new System.Windows.Forms.CheckBox();
      this.haveAccountLabel = new System.Windows.Forms.Label();
      this.backToLoginLabel = new System.Windows.Forms.Label();
      this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
      this.confirmPasswordLabel = new System.Windows.Forms.Label();
      this.clearButton = new WalletBuddy.CustomControl.RJButton();
      this.signUpButton = new WalletBuddy.CustomControl.RJButton();
      this.confirmPasswordTextBox = new WalletBuddy.CustomControl.RJTextBox();
      this.passwordTextBox = new WalletBuddy.CustomControl.RJTextBox();
      this.emailTextBox = new WalletBuddy.CustomControl.RJTextBox();
      this.userNameTextBox = new WalletBuddy.CustomControl.RJTextBox();
      this.profilePictureBox = new System.Windows.Forms.PictureBox();
      this.uploadButton = new WalletBuddy.CustomControl.RJButton();
      this.headerPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
      this.SuspendLayout();
      // 
      // mainLabel
      // 
      this.mainLabel.AutoSize = true;
      this.mainLabel.BackColor = System.Drawing.Color.Transparent;
      this.mainLabel.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.mainLabel.ForeColor = System.Drawing.Color.White;
      this.mainLabel.Location = new System.Drawing.Point(6, 14);
      this.mainLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.mainLabel.Name = "mainLabel";
      this.mainLabel.Size = new System.Drawing.Size(205, 37);
      this.mainLabel.TabIndex = 0;
      this.mainLabel.Text = "Create account";
      // 
      // headerPanel
      // 
      this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(5)))), ((int)(((byte)(227)))));
      this.headerPanel.Controls.Add(this.pictureBox1);
      this.headerPanel.Controls.Add(this.mainLabel);
      this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
      this.headerPanel.Location = new System.Drawing.Point(0, 0);
      this.headerPanel.Margin = new System.Windows.Forms.Padding(2);
      this.headerPanel.Name = "headerPanel";
      this.headerPanel.Size = new System.Drawing.Size(468, 67);
      this.headerPanel.TabIndex = 1;
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(412, 14);
      this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(46, 41);
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
      this.infoLabel.Location = new System.Drawing.Point(8, 70);
      this.infoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.infoLabel.Name = "infoLabel";
      this.infoLabel.Size = new System.Drawing.Size(330, 27);
      this.infoLabel.TabIndex = 2;
      this.infoLabel.Text = "Sign up below to create an account";
      // 
      // userNameLabel
      // 
      this.userNameLabel.AutoSize = true;
      this.userNameLabel.BackColor = System.Drawing.Color.Transparent;
      this.userNameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.userNameLabel.ForeColor = System.Drawing.Color.DimGray;
      this.userNameLabel.Location = new System.Drawing.Point(51, 252);
      this.userNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.userNameLabel.Name = "userNameLabel";
      this.userNameLabel.Size = new System.Drawing.Size(75, 19);
      this.userNameLabel.TabIndex = 3;
      this.userNameLabel.Text = "Username";
      // 
      // emailLabel
      // 
      this.emailLabel.AutoSize = true;
      this.emailLabel.BackColor = System.Drawing.Color.Transparent;
      this.emailLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.emailLabel.ForeColor = System.Drawing.Color.DimGray;
      this.emailLabel.Location = new System.Drawing.Point(76, 289);
      this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.emailLabel.Name = "emailLabel";
      this.emailLabel.Size = new System.Drawing.Size(50, 19);
      this.emailLabel.TabIndex = 3;
      this.emailLabel.Text = "E-mail";
      // 
      // passwordLabel
      // 
      this.passwordLabel.AutoSize = true;
      this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
      this.passwordLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.passwordLabel.ForeColor = System.Drawing.Color.DimGray;
      this.passwordLabel.Location = new System.Drawing.Point(55, 326);
      this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.passwordLabel.Name = "passwordLabel";
      this.passwordLabel.Size = new System.Drawing.Size(71, 19);
      this.passwordLabel.TabIndex = 3;
      this.passwordLabel.Text = "Password";
      // 
      // showPassCheckBox
      // 
      this.showPassCheckBox.AutoSize = true;
      this.showPassCheckBox.BackColor = System.Drawing.Color.Transparent;
      this.showPassCheckBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.showPassCheckBox.ForeColor = System.Drawing.Color.DimGray;
      this.showPassCheckBox.Location = new System.Drawing.Point(133, 398);
      this.showPassCheckBox.Margin = new System.Windows.Forms.Padding(2);
      this.showPassCheckBox.Name = "showPassCheckBox";
      this.showPassCheckBox.Size = new System.Drawing.Size(121, 23);
      this.showPassCheckBox.TabIndex = 5;
      this.showPassCheckBox.Text = "Show Pasword";
      this.showPassCheckBox.UseVisualStyleBackColor = false;
      this.showPassCheckBox.CheckedChanged += new System.EventHandler(this.showPassCheckBox_CheckedChanged);
      // 
      // haveAccountLabel
      // 
      this.haveAccountLabel.AutoSize = true;
      this.haveAccountLabel.BackColor = System.Drawing.Color.Transparent;
      this.haveAccountLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.haveAccountLabel.ForeColor = System.Drawing.Color.DimGray;
      this.haveAccountLabel.Location = new System.Drawing.Point(123, 574);
      this.haveAccountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.haveAccountLabel.Name = "haveAccountLabel";
      this.haveAccountLabel.Size = new System.Drawing.Size(175, 19);
      this.haveAccountLabel.TabIndex = 3;
      this.haveAccountLabel.Text = "Already have an account?";
      // 
      // backToLoginLabel
      // 
      this.backToLoginLabel.AutoSize = true;
      this.backToLoginLabel.BackColor = System.Drawing.Color.Transparent;
      this.backToLoginLabel.Cursor = System.Windows.Forms.Cursors.Hand;
      this.backToLoginLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.backToLoginLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
      this.backToLoginLabel.Location = new System.Drawing.Point(297, 574);
      this.backToLoginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.backToLoginLabel.Name = "backToLoginLabel";
      this.backToLoginLabel.Size = new System.Drawing.Size(52, 19);
      this.backToLoginLabel.TabIndex = 3;
      this.backToLoginLabel.Text = "Sign In";
      this.backToLoginLabel.Click += new System.EventHandler(this.backToLoginLabel_Click);
      // 
      // kryptonPalette1
      // 
      this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.White;
      this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.White;
      this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
      this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 10;
      this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.White;
      this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.White;
      // 
      // confirmPasswordLabel
      // 
      this.confirmPasswordLabel.AutoSize = true;
      this.confirmPasswordLabel.BackColor = System.Drawing.Color.Transparent;
      this.confirmPasswordLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.confirmPasswordLabel.ForeColor = System.Drawing.Color.DimGray;
      this.confirmPasswordLabel.Location = new System.Drawing.Point(6, 363);
      this.confirmPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.confirmPasswordLabel.Name = "confirmPasswordLabel";
      this.confirmPasswordLabel.Size = new System.Drawing.Size(125, 19);
      this.confirmPasswordLabel.TabIndex = 3;
      this.confirmPasswordLabel.Text = "Confirm Password";
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
      this.clearButton.Location = new System.Drawing.Point(133, 510);
      this.clearButton.Margin = new System.Windows.Forms.Padding(2);
      this.clearButton.Name = "clearButton";
      this.clearButton.Size = new System.Drawing.Size(205, 50);
      this.clearButton.TabIndex = 6;
      this.clearButton.Text = "Clear Fields";
      this.clearButton.TextColor = System.Drawing.Color.White;
      this.clearButton.UseVisualStyleBackColor = false;
      this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
      // 
      // signUpButton
      // 
      this.signUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(5)))), ((int)(((byte)(227)))));
      this.signUpButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(5)))), ((int)(((byte)(227)))));
      this.signUpButton.BorderColor = System.Drawing.Color.Blue;
      this.signUpButton.BorderRadius = 20;
      this.signUpButton.BorderSize = 1;
      this.signUpButton.FlatAppearance.BorderSize = 0;
      this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.signUpButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.signUpButton.ForeColor = System.Drawing.Color.White;
      this.signUpButton.Location = new System.Drawing.Point(133, 445);
      this.signUpButton.Margin = new System.Windows.Forms.Padding(2);
      this.signUpButton.Name = "signUpButton";
      this.signUpButton.Size = new System.Drawing.Size(205, 50);
      this.signUpButton.TabIndex = 6;
      this.signUpButton.Text = "Sign Up";
      this.signUpButton.TextColor = System.Drawing.Color.White;
      this.signUpButton.UseVisualStyleBackColor = false;
      this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
      // 
      // confirmPasswordTextBox
      // 
      this.confirmPasswordTextBox.BackColor = System.Drawing.SystemColors.Window;
      this.confirmPasswordTextBox.BorderColor = System.Drawing.Color.CornflowerBlue;
      this.confirmPasswordTextBox.BorderFocusColor = System.Drawing.Color.Blue;
      this.confirmPasswordTextBox.BorderRadius = 10;
      this.confirmPasswordTextBox.BorderSize = 2;
      this.confirmPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.confirmPasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.confirmPasswordTextBox.Location = new System.Drawing.Point(132, 363);
      this.confirmPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.confirmPasswordTextBox.Multiline = false;
      this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
      this.confirmPasswordTextBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
      this.confirmPasswordTextBox.PasswordChar = true;
      this.confirmPasswordTextBox.PlaceholderColor = System.Drawing.Color.Silver;
      this.confirmPasswordTextBox.PlaceholderText = "Confirm Password";
      this.confirmPasswordTextBox.Size = new System.Drawing.Size(326, 29);
      this.confirmPasswordTextBox.TabIndex = 3;
      this.confirmPasswordTextBox.Texts = "";
      this.confirmPasswordTextBox.UnderlinedStyle = false;
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
      this.passwordTextBox.Location = new System.Drawing.Point(132, 326);
      this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.passwordTextBox.Multiline = false;
      this.passwordTextBox.Name = "passwordTextBox";
      this.passwordTextBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
      this.passwordTextBox.PasswordChar = true;
      this.passwordTextBox.PlaceholderColor = System.Drawing.Color.Silver;
      this.passwordTextBox.PlaceholderText = "Password";
      this.passwordTextBox.Size = new System.Drawing.Size(327, 29);
      this.passwordTextBox.TabIndex = 2;
      this.passwordTextBox.Texts = "";
      this.passwordTextBox.UnderlinedStyle = false;
      // 
      // emailTextBox
      // 
      this.emailTextBox.BackColor = System.Drawing.SystemColors.Window;
      this.emailTextBox.BorderColor = System.Drawing.Color.CornflowerBlue;
      this.emailTextBox.BorderFocusColor = System.Drawing.Color.Blue;
      this.emailTextBox.BorderRadius = 10;
      this.emailTextBox.BorderSize = 2;
      this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.emailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.emailTextBox.Location = new System.Drawing.Point(132, 289);
      this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.emailTextBox.Multiline = false;
      this.emailTextBox.Name = "emailTextBox";
      this.emailTextBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
      this.emailTextBox.PasswordChar = false;
      this.emailTextBox.PlaceholderColor = System.Drawing.Color.Silver;
      this.emailTextBox.PlaceholderText = "E-mail";
      this.emailTextBox.Size = new System.Drawing.Size(327, 29);
      this.emailTextBox.TabIndex = 1;
      this.emailTextBox.Texts = "";
      this.emailTextBox.UnderlinedStyle = false;
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
      this.userNameTextBox.Location = new System.Drawing.Point(133, 252);
      this.userNameTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.userNameTextBox.Multiline = false;
      this.userNameTextBox.Name = "userNameTextBox";
      this.userNameTextBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
      this.userNameTextBox.PasswordChar = false;
      this.userNameTextBox.PlaceholderColor = System.Drawing.Color.Silver;
      this.userNameTextBox.PlaceholderText = "Username";
      this.userNameTextBox.Size = new System.Drawing.Size(326, 29);
      this.userNameTextBox.TabIndex = 0;
      this.userNameTextBox.Texts = "";
      this.userNameTextBox.UnderlinedStyle = false;
      // 
      // profilePictureBox
      // 
      this.profilePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("profilePictureBox.Image")));
      this.profilePictureBox.Location = new System.Drawing.Point(166, 100);
      this.profilePictureBox.Name = "profilePictureBox";
      this.profilePictureBox.Size = new System.Drawing.Size(150, 145);
      this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.profilePictureBox.TabIndex = 7;
      this.profilePictureBox.TabStop = false;
      // 
      // uploadButton
      // 
      this.uploadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(5)))), ((int)(((byte)(227)))));
      this.uploadButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(5)))), ((int)(((byte)(227)))));
      this.uploadButton.BorderColor = System.Drawing.Color.Blue;
      this.uploadButton.BorderRadius = 10;
      this.uploadButton.BorderSize = 1;
      this.uploadButton.FlatAppearance.BorderSize = 0;
      this.uploadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.uploadButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.uploadButton.ForeColor = System.Drawing.Color.White;
      this.uploadButton.Location = new System.Drawing.Point(321, 214);
      this.uploadButton.Margin = new System.Windows.Forms.Padding(2);
      this.uploadButton.Name = "uploadButton";
      this.uploadButton.Size = new System.Drawing.Size(91, 31);
      this.uploadButton.TabIndex = 6;
      this.uploadButton.Text = "Upload";
      this.uploadButton.TextColor = System.Drawing.Color.White;
      this.uploadButton.UseVisualStyleBackColor = false;
      this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
      // 
      // RegisterUser
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(468, 612);
      this.Controls.Add(this.profilePictureBox);
      this.Controls.Add(this.clearButton);
      this.Controls.Add(this.uploadButton);
      this.Controls.Add(this.signUpButton);
      this.Controls.Add(this.showPassCheckBox);
      this.Controls.Add(this.confirmPasswordTextBox);
      this.Controls.Add(this.passwordTextBox);
      this.Controls.Add(this.confirmPasswordLabel);
      this.Controls.Add(this.emailTextBox);
      this.Controls.Add(this.passwordLabel);
      this.Controls.Add(this.emailLabel);
      this.Controls.Add(this.userNameTextBox);
      this.Controls.Add(this.backToLoginLabel);
      this.Controls.Add(this.haveAccountLabel);
      this.Controls.Add(this.userNameLabel);
      this.Controls.Add(this.infoLabel);
      this.Controls.Add(this.headerPanel);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "RegisterUser";
      this.Palette = this.kryptonPalette1;
      this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Wallet Buddy";
      this.headerPanel.ResumeLayout(false);
      this.headerPanel.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label mainLabel;
    private System.Windows.Forms.Panel headerPanel;
    private System.Windows.Forms.Label infoLabel;
    private System.Windows.Forms.Label userNameLabel;
    private CustomControl.RJTextBox userNameTextBox;
    private System.Windows.Forms.Label emailLabel;
    private CustomControl.RJTextBox emailTextBox;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label passwordLabel;
    private CustomControl.RJTextBox passwordTextBox;
    private System.Windows.Forms.CheckBox showPassCheckBox;
    private CustomControl.RJButton signUpButton;
    private CustomControl.RJButton clearButton;
    private System.Windows.Forms.Label haveAccountLabel;
    private System.Windows.Forms.Label backToLoginLabel;
    private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
    private System.Windows.Forms.Label confirmPasswordLabel;
    private CustomControl.RJTextBox confirmPasswordTextBox;
    private System.Windows.Forms.PictureBox profilePictureBox;
    private CustomControl.RJButton uploadButton;
  }
}