
namespace WalletBuddy.Forms
{
  partial class SettingsInfo
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.emailTextlabel = new System.Windows.Forms.Label();
      this.emailLabel = new System.Windows.Forms.Label();
      this.usernameTextLabel = new System.Windows.Forms.Label();
      this.userNameLabel = new System.Windows.Forms.Label();
      this.HeaderLabel = new System.Windows.Forms.Label();
      this.changePasswordButton = new WalletBuddy.CustomControl.RJButton();
      this.changeInfoButton = new WalletBuddy.CustomControl.RJButton();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.White;
      this.panel1.Controls.Add(this.changePasswordButton);
      this.panel1.Controls.Add(this.changeInfoButton);
      this.panel1.Controls.Add(this.emailTextlabel);
      this.panel1.Controls.Add(this.emailLabel);
      this.panel1.Controls.Add(this.usernameTextLabel);
      this.panel1.Controls.Add(this.userNameLabel);
      this.panel1.Controls.Add(this.HeaderLabel);
      this.panel1.Location = new System.Drawing.Point(12, 12);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(904, 397);
      this.panel1.TabIndex = 0;
      // 
      // emailTextlabel
      // 
      this.emailTextlabel.AutoSize = true;
      this.emailTextlabel.BackColor = System.Drawing.Color.White;
      this.emailTextlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.emailTextlabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.emailTextlabel.ForeColor = System.Drawing.Color.Black;
      this.emailTextlabel.Location = new System.Drawing.Point(346, 128);
      this.emailTextlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.emailTextlabel.Name = "emailTextlabel";
      this.emailTextlabel.Size = new System.Drawing.Size(59, 25);
      this.emailTextlabel.TabIndex = 6;
      this.emailTextlabel.Text = "E-mail";
      // 
      // emailLabel
      // 
      this.emailLabel.AutoSize = true;
      this.emailLabel.BackColor = System.Drawing.Color.Transparent;
      this.emailLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.emailLabel.ForeColor = System.Drawing.Color.DimGray;
      this.emailLabel.Location = new System.Drawing.Point(227, 128);
      this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.emailLabel.Name = "emailLabel";
      this.emailLabel.Size = new System.Drawing.Size(57, 23);
      this.emailLabel.TabIndex = 6;
      this.emailLabel.Text = "E-mail";
      // 
      // usernameTextLabel
      // 
      this.usernameTextLabel.AutoSize = true;
      this.usernameTextLabel.BackColor = System.Drawing.Color.White;
      this.usernameTextLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.usernameTextLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.usernameTextLabel.ForeColor = System.Drawing.Color.Black;
      this.usernameTextLabel.Location = new System.Drawing.Point(346, 78);
      this.usernameTextLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.usernameTextLabel.Name = "usernameTextLabel";
      this.usernameTextLabel.Size = new System.Drawing.Size(91, 25);
      this.usernameTextLabel.TabIndex = 5;
      this.usernameTextLabel.Text = "Username";
      // 
      // userNameLabel
      // 
      this.userNameLabel.AutoSize = true;
      this.userNameLabel.BackColor = System.Drawing.Color.Transparent;
      this.userNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.userNameLabel.ForeColor = System.Drawing.Color.DimGray;
      this.userNameLabel.Location = new System.Drawing.Point(227, 78);
      this.userNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.userNameLabel.Name = "userNameLabel";
      this.userNameLabel.Size = new System.Drawing.Size(89, 23);
      this.userNameLabel.TabIndex = 5;
      this.userNameLabel.Text = "Username";
      // 
      // HeaderLabel
      // 
      this.HeaderLabel.AutoSize = true;
      this.HeaderLabel.BackColor = System.Drawing.Color.Transparent;
      this.HeaderLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.HeaderLabel.ForeColor = System.Drawing.Color.DimGray;
      this.HeaderLabel.Location = new System.Drawing.Point(340, 13);
      this.HeaderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.HeaderLabel.Name = "HeaderLabel";
      this.HeaderLabel.Size = new System.Drawing.Size(209, 33);
      this.HeaderLabel.TabIndex = 4;
      this.HeaderLabel.Text = "User Information";
      // 
      // changePasswordButton
      // 
      this.changePasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(5)))), ((int)(((byte)(227)))));
      this.changePasswordButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(5)))), ((int)(((byte)(227)))));
      this.changePasswordButton.BorderColor = System.Drawing.Color.Blue;
      this.changePasswordButton.BorderRadius = 20;
      this.changePasswordButton.BorderSize = 1;
      this.changePasswordButton.FlatAppearance.BorderSize = 0;
      this.changePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.changePasswordButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.changePasswordButton.ForeColor = System.Drawing.Color.White;
      this.changePasswordButton.Location = new System.Drawing.Point(471, 273);
      this.changePasswordButton.Margin = new System.Windows.Forms.Padding(2);
      this.changePasswordButton.Name = "changePasswordButton";
      this.changePasswordButton.Size = new System.Drawing.Size(205, 50);
      this.changePasswordButton.TabIndex = 7;
      this.changePasswordButton.Text = "Change Password";
      this.changePasswordButton.TextColor = System.Drawing.Color.White;
      this.changePasswordButton.UseVisualStyleBackColor = false;
      this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
      // 
      // changeInfoButton
      // 
      this.changeInfoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(5)))), ((int)(((byte)(227)))));
      this.changeInfoButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(5)))), ((int)(((byte)(227)))));
      this.changeInfoButton.BorderColor = System.Drawing.Color.Blue;
      this.changeInfoButton.BorderRadius = 20;
      this.changeInfoButton.BorderSize = 1;
      this.changeInfoButton.FlatAppearance.BorderSize = 0;
      this.changeInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.changeInfoButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.changeInfoButton.ForeColor = System.Drawing.Color.White;
      this.changeInfoButton.Location = new System.Drawing.Point(222, 273);
      this.changeInfoButton.Margin = new System.Windows.Forms.Padding(2);
      this.changeInfoButton.Name = "changeInfoButton";
      this.changeInfoButton.Size = new System.Drawing.Size(205, 50);
      this.changeInfoButton.TabIndex = 7;
      this.changeInfoButton.Text = "Change Information";
      this.changeInfoButton.TextColor = System.Drawing.Color.White;
      this.changeInfoButton.UseVisualStyleBackColor = false;
      this.changeInfoButton.Click += new System.EventHandler(this.changeInfoButton_Click);
      // 
      // SettingsInfo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(928, 421);
      this.Controls.Add(this.panel1);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "SettingsInfo";
      this.Text = "Settings And Informations";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label userNameLabel;
    private System.Windows.Forms.Label HeaderLabel;
    private System.Windows.Forms.Label emailLabel;
    private System.Windows.Forms.Label emailTextlabel;
    private System.Windows.Forms.Label usernameTextLabel;
    private CustomControl.RJButton changePasswordButton;
    private CustomControl.RJButton changeInfoButton;
  }
}