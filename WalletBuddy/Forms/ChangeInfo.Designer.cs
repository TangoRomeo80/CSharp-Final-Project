
namespace WalletBuddy.Forms
{
  partial class ChangeInfo
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeInfo));
      this.newUsernameLabel = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.cancelButton = new WalletBuddy.CustomControl.RJButton();
      this.changeButton = new WalletBuddy.CustomControl.RJButton();
      this.newEmailTextBox = new WalletBuddy.CustomControl.RJTextBox();
      this.newUsernameTextBox = new WalletBuddy.CustomControl.RJTextBox();
      this.newEmailLabel = new System.Windows.Forms.Label();
      this.newImageLabel = new System.Windows.Forms.Label();
      this.profilePictureBox = new System.Windows.Forms.PictureBox();
      this.uploadButton = new WalletBuddy.CustomControl.RJButton();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
      this.SuspendLayout();
      // 
      // newUsernameLabel
      // 
      this.newUsernameLabel.AutoSize = true;
      this.newUsernameLabel.BackColor = System.Drawing.Color.Transparent;
      this.newUsernameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.newUsernameLabel.ForeColor = System.Drawing.Color.Black;
      this.newUsernameLabel.Location = new System.Drawing.Point(90, 22);
      this.newUsernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.newUsernameLabel.Name = "newUsernameLabel";
      this.newUsernameLabel.Size = new System.Drawing.Size(108, 19);
      this.newUsernameLabel.TabIndex = 6;
      this.newUsernameLabel.Text = "New Username";
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
      this.panel1.Controls.Add(this.uploadButton);
      this.panel1.Controls.Add(this.profilePictureBox);
      this.panel1.Controls.Add(this.cancelButton);
      this.panel1.Controls.Add(this.changeButton);
      this.panel1.Controls.Add(this.newEmailTextBox);
      this.panel1.Controls.Add(this.newUsernameTextBox);
      this.panel1.Controls.Add(this.newImageLabel);
      this.panel1.Controls.Add(this.newEmailLabel);
      this.panel1.Controls.Add(this.newUsernameLabel);
      this.panel1.Location = new System.Drawing.Point(12, 12);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(735, 397);
      this.panel1.TabIndex = 7;
      // 
      // cancelButton
      // 
      this.cancelButton.BackColor = System.Drawing.Color.Blue;
      this.cancelButton.BackgroundColor = System.Drawing.Color.Blue;
      this.cancelButton.BorderColor = System.Drawing.Color.CornflowerBlue;
      this.cancelButton.BorderRadius = 20;
      this.cancelButton.BorderSize = 1;
      this.cancelButton.FlatAppearance.BorderSize = 0;
      this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cancelButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cancelButton.ForeColor = System.Drawing.Color.White;
      this.cancelButton.Location = new System.Drawing.Point(388, 297);
      this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(205, 50);
      this.cancelButton.TabIndex = 9;
      this.cancelButton.Text = "Cancel";
      this.cancelButton.TextColor = System.Drawing.Color.White;
      this.cancelButton.UseVisualStyleBackColor = false;
      this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
      // 
      // changeButton
      // 
      this.changeButton.BackColor = System.Drawing.Color.Blue;
      this.changeButton.BackgroundColor = System.Drawing.Color.Blue;
      this.changeButton.BorderColor = System.Drawing.Color.CornflowerBlue;
      this.changeButton.BorderRadius = 20;
      this.changeButton.BorderSize = 1;
      this.changeButton.FlatAppearance.BorderSize = 0;
      this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.changeButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.changeButton.ForeColor = System.Drawing.Color.White;
      this.changeButton.Location = new System.Drawing.Point(154, 297);
      this.changeButton.Margin = new System.Windows.Forms.Padding(2);
      this.changeButton.Name = "changeButton";
      this.changeButton.Size = new System.Drawing.Size(205, 50);
      this.changeButton.TabIndex = 9;
      this.changeButton.Text = "Change";
      this.changeButton.TextColor = System.Drawing.Color.White;
      this.changeButton.UseVisualStyleBackColor = false;
      this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
      // 
      // newEmailTextBox
      // 
      this.newEmailTextBox.BackColor = System.Drawing.SystemColors.Window;
      this.newEmailTextBox.BorderColor = System.Drawing.Color.CornflowerBlue;
      this.newEmailTextBox.BorderFocusColor = System.Drawing.Color.Blue;
      this.newEmailTextBox.BorderRadius = 10;
      this.newEmailTextBox.BorderSize = 2;
      this.newEmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.newEmailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.newEmailTextBox.Location = new System.Drawing.Point(204, 57);
      this.newEmailTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.newEmailTextBox.Multiline = false;
      this.newEmailTextBox.Name = "newEmailTextBox";
      this.newEmailTextBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
      this.newEmailTextBox.PasswordChar = false;
      this.newEmailTextBox.PlaceholderColor = System.Drawing.Color.Silver;
      this.newEmailTextBox.PlaceholderText = "New Email";
      this.newEmailTextBox.Size = new System.Drawing.Size(448, 29);
      this.newEmailTextBox.TabIndex = 5;
      this.newEmailTextBox.Texts = "";
      this.newEmailTextBox.UnderlinedStyle = false;
      // 
      // newUsernameTextBox
      // 
      this.newUsernameTextBox.BackColor = System.Drawing.SystemColors.Window;
      this.newUsernameTextBox.BorderColor = System.Drawing.Color.CornflowerBlue;
      this.newUsernameTextBox.BorderFocusColor = System.Drawing.Color.Blue;
      this.newUsernameTextBox.BorderRadius = 10;
      this.newUsernameTextBox.BorderSize = 2;
      this.newUsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.newUsernameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.newUsernameTextBox.Location = new System.Drawing.Point(204, 22);
      this.newUsernameTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.newUsernameTextBox.Multiline = false;
      this.newUsernameTextBox.Name = "newUsernameTextBox";
      this.newUsernameTextBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
      this.newUsernameTextBox.PasswordChar = false;
      this.newUsernameTextBox.PlaceholderColor = System.Drawing.Color.Silver;
      this.newUsernameTextBox.PlaceholderText = "New Username";
      this.newUsernameTextBox.Size = new System.Drawing.Size(448, 29);
      this.newUsernameTextBox.TabIndex = 5;
      this.newUsernameTextBox.Texts = "";
      this.newUsernameTextBox.UnderlinedStyle = false;
      // 
      // newEmailLabel
      // 
      this.newEmailLabel.AutoSize = true;
      this.newEmailLabel.BackColor = System.Drawing.Color.Transparent;
      this.newEmailLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.newEmailLabel.ForeColor = System.Drawing.Color.Black;
      this.newEmailLabel.Location = new System.Drawing.Point(120, 57);
      this.newEmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.newEmailLabel.Name = "newEmailLabel";
      this.newEmailLabel.Size = new System.Drawing.Size(78, 19);
      this.newEmailLabel.TabIndex = 6;
      this.newEmailLabel.Text = "New Email";
      // 
      // newImageLabel
      // 
      this.newImageLabel.AutoSize = true;
      this.newImageLabel.BackColor = System.Drawing.Color.Transparent;
      this.newImageLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.newImageLabel.ForeColor = System.Drawing.Color.Black;
      this.newImageLabel.Location = new System.Drawing.Point(66, 111);
      this.newImageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.newImageLabel.Name = "newImageLabel";
      this.newImageLabel.Size = new System.Drawing.Size(132, 19);
      this.newImageLabel.TabIndex = 6;
      this.newImageLabel.Text = "New Profile picture";
      // 
      // profilePictureBox
      // 
      this.profilePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("profilePictureBox.Image")));
      this.profilePictureBox.Location = new System.Drawing.Point(204, 111);
      this.profilePictureBox.Name = "profilePictureBox";
      this.profilePictureBox.Size = new System.Drawing.Size(150, 145);
      this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.profilePictureBox.TabIndex = 10;
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
      this.uploadButton.Location = new System.Drawing.Point(359, 218);
      this.uploadButton.Margin = new System.Windows.Forms.Padding(2);
      this.uploadButton.Name = "uploadButton";
      this.uploadButton.Size = new System.Drawing.Size(140, 38);
      this.uploadButton.TabIndex = 11;
      this.uploadButton.Text = "Upload";
      this.uploadButton.TextColor = System.Drawing.Color.White;
      this.uploadButton.UseVisualStyleBackColor = false;
      this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
      // 
      // ChangeInfo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(759, 421);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "ChangeInfo";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "AddIncome";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private CustomControl.RJTextBox newUsernameTextBox;
    private System.Windows.Forms.Label newUsernameLabel;
    private System.Windows.Forms.Panel panel1;
    private CustomControl.RJTextBox newEmailTextBox;
    private System.Windows.Forms.Label newEmailLabel;
    private CustomControl.RJButton cancelButton;
    private CustomControl.RJButton changeButton;
    private System.Windows.Forms.Label newImageLabel;
    private System.Windows.Forms.PictureBox profilePictureBox;
    private CustomControl.RJButton uploadButton;
  }
}