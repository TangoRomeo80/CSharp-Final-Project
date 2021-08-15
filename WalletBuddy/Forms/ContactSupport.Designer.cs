
namespace WalletBuddy.Forms
{
  partial class ContactSupport
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactSupport));
      this.mainLabel = new System.Windows.Forms.Label();
      this.headerPanel = new System.Windows.Forms.Panel();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.infoLabel = new System.Windows.Forms.Label();
      this.nameLabel = new System.Windows.Forms.Label();
      this.emailLabel = new System.Windows.Forms.Label();
      this.messageLabel = new System.Windows.Forms.Label();
      this.infoLabel2 = new System.Windows.Forms.Label();
      this.clearButton = new WalletBuddy.CustomControl.RJButton();
      this.messageTextBox = new WalletBuddy.CustomControl.RJTextBox();
      this.emailTextBox = new WalletBuddy.CustomControl.RJTextBox();
      this.userNameTextBox = new WalletBuddy.CustomControl.RJTextBox();
      this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
      this.submitButton = new WalletBuddy.CustomControl.RJButton();
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
      this.mainLabel.Location = new System.Drawing.Point(6, 14);
      this.mainLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.mainLabel.Name = "mainLabel";
      this.mainLabel.Size = new System.Drawing.Size(343, 37);
      this.mainLabel.TabIndex = 0;
      this.mainLabel.Text = "Feedback and Help Centre";
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
      this.infoLabel.Size = new System.Drawing.Size(261, 27);
      this.infoLabel.TabIndex = 2;
      this.infoLabel.Text = "Let us know what you think";
      // 
      // nameLabel
      // 
      this.nameLabel.AutoSize = true;
      this.nameLabel.BackColor = System.Drawing.Color.Transparent;
      this.nameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.nameLabel.ForeColor = System.Drawing.Color.DimGray;
      this.nameLabel.Location = new System.Drawing.Point(9, 134);
      this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.nameLabel.Name = "nameLabel";
      this.nameLabel.Size = new System.Drawing.Size(47, 19);
      this.nameLabel.TabIndex = 3;
      this.nameLabel.Text = "Name";
      // 
      // emailLabel
      // 
      this.emailLabel.AutoSize = true;
      this.emailLabel.BackColor = System.Drawing.Color.Transparent;
      this.emailLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.emailLabel.ForeColor = System.Drawing.Color.DimGray;
      this.emailLabel.Location = new System.Drawing.Point(9, 204);
      this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.emailLabel.Name = "emailLabel";
      this.emailLabel.Size = new System.Drawing.Size(50, 19);
      this.emailLabel.TabIndex = 3;
      this.emailLabel.Text = "E-mail";
      // 
      // messageLabel
      // 
      this.messageLabel.AutoSize = true;
      this.messageLabel.BackColor = System.Drawing.Color.Transparent;
      this.messageLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.messageLabel.ForeColor = System.Drawing.Color.DimGray;
      this.messageLabel.Location = new System.Drawing.Point(9, 274);
      this.messageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.messageLabel.Name = "messageLabel";
      this.messageLabel.Size = new System.Drawing.Size(68, 19);
      this.messageLabel.TabIndex = 3;
      this.messageLabel.Text = "Message";
      // 
      // infoLabel2
      // 
      this.infoLabel2.AutoSize = true;
      this.infoLabel2.BackColor = System.Drawing.Color.Transparent;
      this.infoLabel2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.infoLabel2.ForeColor = System.Drawing.Color.DimGray;
      this.infoLabel2.Location = new System.Drawing.Point(8, 98);
      this.infoLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.infoLabel2.Name = "infoLabel2";
      this.infoLabel2.Size = new System.Drawing.Size(466, 23);
      this.infoLabel2.TabIndex = 2;
      this.infoLabel2.Text = "Got an issue? Leave a note and we will get back to you soon";
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
      this.clearButton.Location = new System.Drawing.Point(124, 538);
      this.clearButton.Margin = new System.Windows.Forms.Padding(2);
      this.clearButton.Name = "clearButton";
      this.clearButton.Size = new System.Drawing.Size(205, 50);
      this.clearButton.TabIndex = 6;
      this.clearButton.Text = "Clear Fields";
      this.clearButton.TextColor = System.Drawing.Color.White;
      this.clearButton.UseVisualStyleBackColor = false;
      this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
      // 
      // messageTextBox
      // 
      this.messageTextBox.BackColor = System.Drawing.SystemColors.Window;
      this.messageTextBox.BorderColor = System.Drawing.Color.CornflowerBlue;
      this.messageTextBox.BorderFocusColor = System.Drawing.Color.Blue;
      this.messageTextBox.BorderRadius = 10;
      this.messageTextBox.BorderSize = 2;
      this.messageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.messageTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.messageTextBox.Location = new System.Drawing.Point(10, 296);
      this.messageTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.messageTextBox.Multiline = true;
      this.messageTextBox.Name = "messageTextBox";
      this.messageTextBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
      this.messageTextBox.PasswordChar = false;
      this.messageTextBox.PlaceholderColor = System.Drawing.Color.Silver;
      this.messageTextBox.PlaceholderText = "Write your message here";
      this.messageTextBox.Size = new System.Drawing.Size(448, 172);
      this.messageTextBox.TabIndex = 2;
      this.messageTextBox.Texts = "";
      this.messageTextBox.UnderlinedStyle = false;
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
      this.emailTextBox.Location = new System.Drawing.Point(8, 234);
      this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.emailTextBox.Multiline = false;
      this.emailTextBox.Name = "emailTextBox";
      this.emailTextBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
      this.emailTextBox.PasswordChar = false;
      this.emailTextBox.PlaceholderColor = System.Drawing.Color.Silver;
      this.emailTextBox.PlaceholderText = "E-mail";
      this.emailTextBox.Size = new System.Drawing.Size(448, 29);
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
      this.userNameTextBox.Location = new System.Drawing.Point(10, 165);
      this.userNameTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.userNameTextBox.Multiline = false;
      this.userNameTextBox.Name = "userNameTextBox";
      this.userNameTextBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
      this.userNameTextBox.PasswordChar = false;
      this.userNameTextBox.PlaceholderColor = System.Drawing.Color.Silver;
      this.userNameTextBox.PlaceholderText = "Name";
      this.userNameTextBox.Size = new System.Drawing.Size(448, 29);
      this.userNameTextBox.TabIndex = 0;
      this.userNameTextBox.Texts = "";
      this.userNameTextBox.UnderlinedStyle = false;
      // 
      // kryptonPalette1
      // 
      this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color1 = System.Drawing.Color.White;
      this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color2 = System.Drawing.Color.White;
      this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.White;
      this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.White;
      // 
      // submitButton
      // 
      this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(5)))), ((int)(((byte)(227)))));
      this.submitButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(5)))), ((int)(((byte)(227)))));
      this.submitButton.BorderColor = System.Drawing.Color.Blue;
      this.submitButton.BorderRadius = 20;
      this.submitButton.BorderSize = 1;
      this.submitButton.FlatAppearance.BorderSize = 0;
      this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.submitButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.submitButton.ForeColor = System.Drawing.Color.White;
      this.submitButton.Location = new System.Drawing.Point(124, 484);
      this.submitButton.Margin = new System.Windows.Forms.Padding(2);
      this.submitButton.Name = "submitButton";
      this.submitButton.Size = new System.Drawing.Size(205, 50);
      this.submitButton.TabIndex = 6;
      this.submitButton.Text = "Submit";
      this.submitButton.TextColor = System.Drawing.Color.White;
      this.submitButton.UseVisualStyleBackColor = false;
      this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
      // 
      // backToWelcomeLabel
      // 
      this.backToWelcomeLabel.AutoSize = true;
      this.backToWelcomeLabel.BackColor = System.Drawing.Color.Transparent;
      this.backToWelcomeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
      this.backToWelcomeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.backToWelcomeLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
      this.backToWelcomeLabel.Location = new System.Drawing.Point(150, 590);
      this.backToWelcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.backToWelcomeLabel.Name = "backToWelcomeLabel";
      this.backToWelcomeLabel.Size = new System.Drawing.Size(157, 19);
      this.backToWelcomeLabel.TabIndex = 7;
      this.backToWelcomeLabel.Text = "Back to Welcome Page";
      this.backToWelcomeLabel.Click += new System.EventHandler(this.backToWelcomeLabel_Click);
      // 
      // ContactSupport
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(468, 612);
      this.Controls.Add(this.backToWelcomeLabel);
      this.Controls.Add(this.submitButton);
      this.Controls.Add(this.clearButton);
      this.Controls.Add(this.messageTextBox);
      this.Controls.Add(this.emailTextBox);
      this.Controls.Add(this.messageLabel);
      this.Controls.Add(this.emailLabel);
      this.Controls.Add(this.userNameTextBox);
      this.Controls.Add(this.nameLabel);
      this.Controls.Add(this.infoLabel2);
      this.Controls.Add(this.infoLabel);
      this.Controls.Add(this.headerPanel);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "ContactSupport";
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
    private System.Windows.Forms.Label nameLabel;
    private CustomControl.RJTextBox userNameTextBox;
    private System.Windows.Forms.Label emailLabel;
    private CustomControl.RJTextBox emailTextBox;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label messageLabel;
    private CustomControl.RJTextBox messageTextBox;
    private CustomControl.RJButton clearButton;
    private System.Windows.Forms.Label infoLabel2;
    private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
    private CustomControl.RJButton submitButton;
    private System.Windows.Forms.Label backToWelcomeLabel;
  }
}