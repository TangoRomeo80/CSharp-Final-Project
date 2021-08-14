
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
      this.newUsernameLabel = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.cancelButton = new WalletBuddy.CustomControl.RJButton();
      this.changeButton = new WalletBuddy.CustomControl.RJButton();
      this.newEmailTextBox = new WalletBuddy.CustomControl.RJTextBox();
      this.newUsernameTextBox = new WalletBuddy.CustomControl.RJTextBox();
      this.newEmailLabel = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
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
      this.panel1.Controls.Add(this.cancelButton);
      this.panel1.Controls.Add(this.changeButton);
      this.panel1.Controls.Add(this.newEmailTextBox);
      this.panel1.Controls.Add(this.newUsernameTextBox);
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
  }
}