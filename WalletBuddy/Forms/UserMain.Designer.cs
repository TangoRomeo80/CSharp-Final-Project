
namespace WalletBuddy.Forms
{
  partial class UserMain
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMain));
      this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
      this.headerPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
      this.label2 = new System.Windows.Forms.Label();
      this.topUserNameLabel = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.logoutPicBox = new System.Windows.Forms.PictureBox();
      this.userPicBox = new System.Windows.Forms.PictureBox();
      this.mainLabel = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.buttonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
      this.goalsButton = new WalletBuddy.CustomControl.RJButton();
      this.paymentButton = new WalletBuddy.CustomControl.RJButton();
      this.settingsButton = new WalletBuddy.CustomControl.RJButton();
      this.recordsButton = new WalletBuddy.CustomControl.RJButton();
      this.accountsButton = new WalletBuddy.CustomControl.RJButton();
      this.expenseButton = new WalletBuddy.CustomControl.RJButton();
      this.incomeButton = new WalletBuddy.CustomControl.RJButton();
      this.dashButton = new WalletBuddy.CustomControl.RJButton();
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
      this.headerPanel.Controls.Add(this.label2);
      this.headerPanel.Controls.Add(this.topUserNameLabel);
      this.headerPanel.Controls.Add(this.label1);
      this.headerPanel.Controls.Add(this.logoutPicBox);
      this.headerPanel.Controls.Add(this.userPicBox);
      this.headerPanel.Controls.Add(this.mainLabel);
      this.headerPanel.Controls.Add(this.pictureBox1);
      this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
      this.headerPanel.Location = new System.Drawing.Point(0, 0);
      this.headerPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.headerPanel.Name = "headerPanel";
      this.headerPanel.Size = new System.Drawing.Size(1236, 167);
      this.headerPanel.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(5)))), ((int)(((byte)(227)))));
      this.headerPanel.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(5)))), ((int)(((byte)(227)))));
      this.headerPanel.TabIndex = 0;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.Color.Transparent;
      this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.White;
      this.label2.Location = new System.Drawing.Point(948, 31);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(64, 21);
      this.label2.TabIndex = 4;
      this.label2.Text = "Log Out";
      // 
      // topUserNameLabel
      // 
      this.topUserNameLabel.AutoSize = true;
      this.topUserNameLabel.BackColor = System.Drawing.Color.Transparent;
      this.topUserNameLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.topUserNameLabel.ForeColor = System.Drawing.Color.White;
      this.topUserNameLabel.Location = new System.Drawing.Point(1063, 31);
      this.topUserNameLabel.Name = "topUserNameLabel";
      this.topUserNameLabel.Size = new System.Drawing.Size(87, 21);
      this.topUserNameLabel.TabIndex = 4;
      this.topUserNameLabel.Text = "User Name";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(1063, 31);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(87, 21);
      this.label1.TabIndex = 4;
      this.label1.Text = "User Name";
      // 
      // logoutPicBox
      // 
      this.logoutPicBox.BackColor = System.Drawing.Color.Transparent;
      this.logoutPicBox.Image = ((System.Drawing.Image)(resources.GetObject("logoutPicBox.Image")));
      this.logoutPicBox.Location = new System.Drawing.Point(900, 21);
      this.logoutPicBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
      this.userPicBox.Location = new System.Drawing.Point(1027, 21);
      this.userPicBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.userPicBox.Name = "userPicBox";
      this.userPicBox.Size = new System.Drawing.Size(30, 30);
      this.userPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.userPicBox.TabIndex = 3;
      this.userPicBox.TabStop = false;
      // 
      // mainLabel
      // 
      this.mainLabel.AutoSize = true;
      this.mainLabel.BackColor = System.Drawing.Color.Transparent;
      this.mainLabel.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.mainLabel.ForeColor = System.Drawing.Color.White;
      this.mainLabel.Location = new System.Drawing.Point(80, 12);
      this.mainLabel.Name = "mainLabel";
      this.mainLabel.Size = new System.Drawing.Size(230, 46);
      this.mainLabel.TabIndex = 1;
      this.mainLabel.Text = "Wallet Buddy";
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(12, 12);
      this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(61, 50);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 2;
      this.pictureBox1.TabStop = false;
      // 
      // buttonPanel
      // 
      this.buttonPanel.Controls.Add(this.goalsButton);
      this.buttonPanel.Controls.Add(this.paymentButton);
      this.buttonPanel.Controls.Add(this.settingsButton);
      this.buttonPanel.Controls.Add(this.recordsButton);
      this.buttonPanel.Controls.Add(this.accountsButton);
      this.buttonPanel.Controls.Add(this.expenseButton);
      this.buttonPanel.Controls.Add(this.incomeButton);
      this.buttonPanel.Controls.Add(this.dashButton);
      this.buttonPanel.Location = new System.Drawing.Point(0, 81);
      this.buttonPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.buttonPanel.Name = "buttonPanel";
      this.buttonPanel.Size = new System.Drawing.Size(1261, 87);
      this.buttonPanel.StateCommon.Color1 = System.Drawing.Color.AliceBlue;
      this.buttonPanel.StateCommon.Color2 = System.Drawing.Color.AliceBlue;
      this.buttonPanel.TabIndex = 1;
      // 
      // goalsButton
      // 
      this.goalsButton.BackColor = System.Drawing.Color.White;
      this.goalsButton.BackgroundColor = System.Drawing.Color.White;
      this.goalsButton.BorderColor = System.Drawing.Color.Blue;
      this.goalsButton.BorderRadius = 10;
      this.goalsButton.BorderSize = 1;
      this.goalsButton.FlatAppearance.BorderSize = 0;
      this.goalsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.goalsButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.goalsButton.ForeColor = System.Drawing.Color.SlateGray;
      this.goalsButton.Image = ((System.Drawing.Image)(resources.GetObject("goalsButton.Image")));
      this.goalsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.goalsButton.Location = new System.Drawing.Point(819, 16);
      this.goalsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.goalsButton.Name = "goalsButton";
      this.goalsButton.Size = new System.Drawing.Size(149, 46);
      this.goalsButton.TabIndex = 0;
      this.goalsButton.Text = "Goals";
      this.goalsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.goalsButton.TextColor = System.Drawing.Color.SlateGray;
      this.goalsButton.UseVisualStyleBackColor = false;
      this.goalsButton.Click += new System.EventHandler(this.goalsButton_Click);
      // 
      // paymentButton
      // 
      this.paymentButton.BackColor = System.Drawing.Color.White;
      this.paymentButton.BackgroundColor = System.Drawing.Color.White;
      this.paymentButton.BorderColor = System.Drawing.Color.Blue;
      this.paymentButton.BorderRadius = 10;
      this.paymentButton.BorderSize = 1;
      this.paymentButton.FlatAppearance.BorderSize = 0;
      this.paymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.paymentButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.paymentButton.ForeColor = System.Drawing.Color.SlateGray;
      this.paymentButton.Image = ((System.Drawing.Image)(resources.GetObject("paymentButton.Image")));
      this.paymentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.paymentButton.Location = new System.Drawing.Point(664, 16);
      this.paymentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.paymentButton.Name = "paymentButton";
      this.paymentButton.Size = new System.Drawing.Size(149, 46);
      this.paymentButton.TabIndex = 0;
      this.paymentButton.Text = "Payments";
      this.paymentButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.paymentButton.TextColor = System.Drawing.Color.SlateGray;
      this.paymentButton.UseVisualStyleBackColor = false;
      this.paymentButton.Click += new System.EventHandler(this.paymentButton_Click);
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
      this.settingsButton.Location = new System.Drawing.Point(1168, 16);
      this.settingsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.settingsButton.Name = "settingsButton";
      this.settingsButton.Size = new System.Drawing.Size(53, 46);
      this.settingsButton.TabIndex = 0;
      this.settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.settingsButton.TextColor = System.Drawing.Color.SlateGray;
      this.settingsButton.UseVisualStyleBackColor = false;
      this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
      // 
      // recordsButton
      // 
      this.recordsButton.BackColor = System.Drawing.Color.White;
      this.recordsButton.BackgroundColor = System.Drawing.Color.White;
      this.recordsButton.BorderColor = System.Drawing.Color.Blue;
      this.recordsButton.BorderRadius = 10;
      this.recordsButton.BorderSize = 1;
      this.recordsButton.FlatAppearance.BorderSize = 0;
      this.recordsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.recordsButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.recordsButton.ForeColor = System.Drawing.Color.SlateGray;
      this.recordsButton.Image = ((System.Drawing.Image)(resources.GetObject("recordsButton.Image")));
      this.recordsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.recordsButton.Location = new System.Drawing.Point(973, 16);
      this.recordsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.recordsButton.Name = "recordsButton";
      this.recordsButton.Size = new System.Drawing.Size(149, 46);
      this.recordsButton.TabIndex = 0;
      this.recordsButton.Text = "Records";
      this.recordsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.recordsButton.TextColor = System.Drawing.Color.SlateGray;
      this.recordsButton.UseVisualStyleBackColor = false;
      this.recordsButton.Click += new System.EventHandler(this.recordsButton_Click);
      // 
      // accountsButton
      // 
      this.accountsButton.BackColor = System.Drawing.Color.White;
      this.accountsButton.BackgroundColor = System.Drawing.Color.White;
      this.accountsButton.BorderColor = System.Drawing.Color.Blue;
      this.accountsButton.BorderRadius = 10;
      this.accountsButton.BorderSize = 1;
      this.accountsButton.FlatAppearance.BorderSize = 0;
      this.accountsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.accountsButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.accountsButton.ForeColor = System.Drawing.Color.SlateGray;
      this.accountsButton.Image = ((System.Drawing.Image)(resources.GetObject("accountsButton.Image")));
      this.accountsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.accountsButton.Location = new System.Drawing.Point(509, 16);
      this.accountsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.accountsButton.Name = "accountsButton";
      this.accountsButton.Size = new System.Drawing.Size(149, 46);
      this.accountsButton.TabIndex = 0;
      this.accountsButton.Text = "Accounts";
      this.accountsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.accountsButton.TextColor = System.Drawing.Color.SlateGray;
      this.accountsButton.UseVisualStyleBackColor = false;
      this.accountsButton.Click += new System.EventHandler(this.accountsButton_Click);
      // 
      // expenseButton
      // 
      this.expenseButton.BackColor = System.Drawing.Color.White;
      this.expenseButton.BackgroundColor = System.Drawing.Color.White;
      this.expenseButton.BorderColor = System.Drawing.Color.Blue;
      this.expenseButton.BorderRadius = 10;
      this.expenseButton.BorderSize = 1;
      this.expenseButton.FlatAppearance.BorderSize = 0;
      this.expenseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.expenseButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.expenseButton.ForeColor = System.Drawing.Color.SlateGray;
      this.expenseButton.Image = ((System.Drawing.Image)(resources.GetObject("expenseButton.Image")));
      this.expenseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.expenseButton.Location = new System.Drawing.Point(355, 16);
      this.expenseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.expenseButton.Name = "expenseButton";
      this.expenseButton.Size = new System.Drawing.Size(149, 46);
      this.expenseButton.TabIndex = 0;
      this.expenseButton.Text = "Expense";
      this.expenseButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.expenseButton.TextColor = System.Drawing.Color.SlateGray;
      this.expenseButton.UseVisualStyleBackColor = false;
      this.expenseButton.Click += new System.EventHandler(this.expenseButton_Click);
      // 
      // incomeButton
      // 
      this.incomeButton.BackColor = System.Drawing.Color.White;
      this.incomeButton.BackgroundColor = System.Drawing.Color.White;
      this.incomeButton.BorderColor = System.Drawing.Color.Blue;
      this.incomeButton.BorderRadius = 10;
      this.incomeButton.BorderSize = 1;
      this.incomeButton.FlatAppearance.BorderSize = 0;
      this.incomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.incomeButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.incomeButton.ForeColor = System.Drawing.Color.SlateGray;
      this.incomeButton.Image = ((System.Drawing.Image)(resources.GetObject("incomeButton.Image")));
      this.incomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.incomeButton.Location = new System.Drawing.Point(200, 16);
      this.incomeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.incomeButton.Name = "incomeButton";
      this.incomeButton.Size = new System.Drawing.Size(149, 46);
      this.incomeButton.TabIndex = 0;
      this.incomeButton.Text = "Income";
      this.incomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.incomeButton.TextColor = System.Drawing.Color.SlateGray;
      this.incomeButton.UseVisualStyleBackColor = false;
      this.incomeButton.Click += new System.EventHandler(this.incomeButton_Click);
      // 
      // dashButton
      // 
      this.dashButton.BackColor = System.Drawing.Color.White;
      this.dashButton.BackgroundColor = System.Drawing.Color.White;
      this.dashButton.BorderColor = System.Drawing.Color.Blue;
      this.dashButton.BorderRadius = 10;
      this.dashButton.BorderSize = 1;
      this.dashButton.FlatAppearance.BorderSize = 0;
      this.dashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.dashButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dashButton.ForeColor = System.Drawing.Color.SlateGray;
      this.dashButton.Image = ((System.Drawing.Image)(resources.GetObject("dashButton.Image")));
      this.dashButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.dashButton.Location = new System.Drawing.Point(45, 16);
      this.dashButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.dashButton.Name = "dashButton";
      this.dashButton.Size = new System.Drawing.Size(149, 46);
      this.dashButton.TabIndex = 0;
      this.dashButton.Text = "Dashboard";
      this.dashButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.dashButton.TextColor = System.Drawing.Color.SlateGray;
      this.dashButton.UseVisualStyleBackColor = false;
      this.dashButton.Click += new System.EventHandler(this.dashButton_Click);
      // 
      // panelDesktopPane
      // 
      this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelDesktopPane.Location = new System.Drawing.Point(0, 167);
      this.panelDesktopPane.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.panelDesktopPane.Name = "panelDesktopPane";
      this.panelDesktopPane.Size = new System.Drawing.Size(1236, 530);
      this.panelDesktopPane.TabIndex = 2;
      // 
      // UserMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(1236, 697);
      this.Controls.Add(this.panelDesktopPane);
      this.Controls.Add(this.buttonPanel);
      this.Controls.Add(this.headerPanel);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "UserMain";
      this.Palette = this.kryptonPalette1;
      this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Wallet Buddy";
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
    private CustomControl.RJButton accountsButton;
    private CustomControl.RJButton expenseButton;
    private CustomControl.RJButton incomeButton;
    private CustomControl.RJButton dashButton;
    private System.Windows.Forms.PictureBox userPicBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panelDesktopPane;
    private CustomControl.RJButton recordsButton;
    private CustomControl.RJButton paymentButton;
    private CustomControl.RJButton goalsButton;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label topUserNameLabel;
    private System.Windows.Forms.PictureBox logoutPicBox;
    private CustomControl.RJButton settingsButton;
  }
}