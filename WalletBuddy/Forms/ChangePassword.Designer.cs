
namespace WalletBuddy.Forms
{
  partial class ChangePassword
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
      this.previousPasswordLabel = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.cancelButton = new WalletBuddy.CustomControl.RJButton();
      this.changeButton = new WalletBuddy.CustomControl.RJButton();
      this.newPasswordTextBox = new WalletBuddy.CustomControl.RJTextBox();
      this.previousPasswordTextBox = new WalletBuddy.CustomControl.RJTextBox();
      this.newPasswordLabel = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // previousPasswordLabel
      // 
      this.previousPasswordLabel.AutoSize = true;
      this.previousPasswordLabel.BackColor = System.Drawing.Color.Transparent;
      this.previousPasswordLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.previousPasswordLabel.ForeColor = System.Drawing.Color.Black;
      this.previousPasswordLabel.Location = new System.Drawing.Point(68, 22);
      this.previousPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.previousPasswordLabel.Name = "previousPasswordLabel";
      this.previousPasswordLabel.Size = new System.Drawing.Size(130, 19);
      this.previousPasswordLabel.TabIndex = 6;
      this.previousPasswordLabel.Text = "Previous Password";
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
      this.panel1.Controls.Add(this.cancelButton);
      this.panel1.Controls.Add(this.changeButton);
      this.panel1.Controls.Add(this.newPasswordTextBox);
      this.panel1.Controls.Add(this.previousPasswordTextBox);
      this.panel1.Controls.Add(this.newPasswordLabel);
      this.panel1.Controls.Add(this.previousPasswordLabel);
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
      // 
      // newPasswordTextBox
      // 
      this.newPasswordTextBox.BackColor = System.Drawing.SystemColors.Window;
      this.newPasswordTextBox.BorderColor = System.Drawing.Color.CornflowerBlue;
      this.newPasswordTextBox.BorderFocusColor = System.Drawing.Color.Blue;
      this.newPasswordTextBox.BorderRadius = 10;
      this.newPasswordTextBox.BorderSize = 2;
      this.newPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.newPasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.newPasswordTextBox.Location = new System.Drawing.Point(204, 57);
      this.newPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.newPasswordTextBox.Multiline = false;
      this.newPasswordTextBox.Name = "newPasswordTextBox";
      this.newPasswordTextBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
      this.newPasswordTextBox.PasswordChar = false;
      this.newPasswordTextBox.PlaceholderColor = System.Drawing.Color.Silver;
      this.newPasswordTextBox.PlaceholderText = "New Password";
      this.newPasswordTextBox.Size = new System.Drawing.Size(448, 29);
      this.newPasswordTextBox.TabIndex = 5;
      this.newPasswordTextBox.Texts = "";
      this.newPasswordTextBox.UnderlinedStyle = false;
      // 
      // previousPasswordTextBox
      // 
      this.previousPasswordTextBox.BackColor = System.Drawing.SystemColors.Window;
      this.previousPasswordTextBox.BorderColor = System.Drawing.Color.CornflowerBlue;
      this.previousPasswordTextBox.BorderFocusColor = System.Drawing.Color.Blue;
      this.previousPasswordTextBox.BorderRadius = 10;
      this.previousPasswordTextBox.BorderSize = 2;
      this.previousPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.previousPasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.previousPasswordTextBox.Location = new System.Drawing.Point(204, 22);
      this.previousPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.previousPasswordTextBox.Multiline = false;
      this.previousPasswordTextBox.Name = "previousPasswordTextBox";
      this.previousPasswordTextBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
      this.previousPasswordTextBox.PasswordChar = false;
      this.previousPasswordTextBox.PlaceholderColor = System.Drawing.Color.Silver;
      this.previousPasswordTextBox.PlaceholderText = "Previous Password";
      this.previousPasswordTextBox.Size = new System.Drawing.Size(448, 29);
      this.previousPasswordTextBox.TabIndex = 5;
      this.previousPasswordTextBox.Texts = "";
      this.previousPasswordTextBox.UnderlinedStyle = false;
      // 
      // newPasswordLabel
      // 
      this.newPasswordLabel.AutoSize = true;
      this.newPasswordLabel.BackColor = System.Drawing.Color.Transparent;
      this.newPasswordLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.newPasswordLabel.ForeColor = System.Drawing.Color.Black;
      this.newPasswordLabel.Location = new System.Drawing.Point(94, 57);
      this.newPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.newPasswordLabel.Name = "newPasswordLabel";
      this.newPasswordLabel.Size = new System.Drawing.Size(104, 19);
      this.newPasswordLabel.TabIndex = 6;
      this.newPasswordLabel.Text = "New Password";
      // 
      // ChangePassword
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(759, 421);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "ChangePassword";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "AddIncome";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private CustomControl.RJTextBox previousPasswordTextBox;
    private System.Windows.Forms.Label previousPasswordLabel;
    private System.Windows.Forms.Panel panel1;
    private CustomControl.RJTextBox newPasswordTextBox;
    private System.Windows.Forms.Label newPasswordLabel;
    private CustomControl.RJButton cancelButton;
    private CustomControl.RJButton changeButton;
  }
}