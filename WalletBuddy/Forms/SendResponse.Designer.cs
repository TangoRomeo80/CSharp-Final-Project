
namespace WalletBuddy.Forms
{
  partial class SendResponse
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
      this.cancelButton = new WalletBuddy.CustomControl.RJButton();
      this.sendButton = new WalletBuddy.CustomControl.RJButton();
      this.descriptionTextBox = new WalletBuddy.CustomControl.RJTextBox();
      this.responseLabel = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.LightGray;
      this.panel1.Controls.Add(this.cancelButton);
      this.panel1.Controls.Add(this.sendButton);
      this.panel1.Controls.Add(this.descriptionTextBox);
      this.panel1.Controls.Add(this.responseLabel);
      this.panel1.Location = new System.Drawing.Point(12, 12);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(735, 397);
      this.panel1.TabIndex = 7;
      // 
      // cancelButton
      // 
      this.cancelButton.BackColor = System.Drawing.Color.DimGray;
      this.cancelButton.BackgroundColor = System.Drawing.Color.DimGray;
      this.cancelButton.BorderColor = System.Drawing.Color.DarkGray;
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
      // sendButton
      // 
      this.sendButton.BackColor = System.Drawing.Color.DimGray;
      this.sendButton.BackgroundColor = System.Drawing.Color.DimGray;
      this.sendButton.BorderColor = System.Drawing.Color.DarkGray;
      this.sendButton.BorderRadius = 20;
      this.sendButton.BorderSize = 1;
      this.sendButton.FlatAppearance.BorderSize = 0;
      this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.sendButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.sendButton.ForeColor = System.Drawing.Color.White;
      this.sendButton.Location = new System.Drawing.Point(154, 297);
      this.sendButton.Margin = new System.Windows.Forms.Padding(2);
      this.sendButton.Name = "sendButton";
      this.sendButton.Size = new System.Drawing.Size(205, 50);
      this.sendButton.TabIndex = 9;
      this.sendButton.Text = "Send";
      this.sendButton.TextColor = System.Drawing.Color.White;
      this.sendButton.UseVisualStyleBackColor = false;
      this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
      // 
      // descriptionTextBox
      // 
      this.descriptionTextBox.BackColor = System.Drawing.SystemColors.Window;
      this.descriptionTextBox.BorderColor = System.Drawing.Color.DimGray;
      this.descriptionTextBox.BorderFocusColor = System.Drawing.Color.Black;
      this.descriptionTextBox.BorderRadius = 10;
      this.descriptionTextBox.BorderSize = 2;
      this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.descriptionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.descriptionTextBox.Location = new System.Drawing.Point(200, 15);
      this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.descriptionTextBox.Multiline = true;
      this.descriptionTextBox.Name = "descriptionTextBox";
      this.descriptionTextBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
      this.descriptionTextBox.PasswordChar = false;
      this.descriptionTextBox.PlaceholderColor = System.Drawing.Color.Silver;
      this.descriptionTextBox.PlaceholderText = "Description";
      this.descriptionTextBox.Size = new System.Drawing.Size(448, 231);
      this.descriptionTextBox.TabIndex = 8;
      this.descriptionTextBox.Texts = "";
      this.descriptionTextBox.UnderlinedStyle = false;
      // 
      // responseLabel
      // 
      this.responseLabel.AutoSize = true;
      this.responseLabel.BackColor = System.Drawing.Color.Transparent;
      this.responseLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.responseLabel.ForeColor = System.Drawing.Color.Black;
      this.responseLabel.Location = new System.Drawing.Point(111, 96);
      this.responseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.responseLabel.Name = "responseLabel";
      this.responseLabel.Size = new System.Drawing.Size(72, 19);
      this.responseLabel.TabIndex = 6;
      this.responseLabel.Text = "Response";
      // 
      // SendResponse
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(759, 421);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "SendResponse";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "AddIncome";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label responseLabel;
    private CustomControl.RJTextBox descriptionTextBox;
    private CustomControl.RJButton cancelButton;
    private CustomControl.RJButton sendButton;
  }
}