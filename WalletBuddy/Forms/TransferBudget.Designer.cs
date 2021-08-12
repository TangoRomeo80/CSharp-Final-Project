
namespace WalletBuddy.Forms
{
  partial class TransferBudget
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
      this.senderAccountNameLabel = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.cancelButton = new WalletBuddy.CustomControl.RJButton();
      this.transferButton = new WalletBuddy.CustomControl.RJButton();
      this.amountTextBox = new WalletBuddy.CustomControl.RJTextBox();
      this.recieverAccountNameTextBox = new WalletBuddy.CustomControl.RJTextBox();
      this.senderAccountNameTextBox = new WalletBuddy.CustomControl.RJTextBox();
      this.amountLabel = new System.Windows.Forms.Label();
      this.recieverAccountLabel = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // senderAccountNameLabel
      // 
      this.senderAccountNameLabel.AutoSize = true;
      this.senderAccountNameLabel.BackColor = System.Drawing.Color.Transparent;
      this.senderAccountNameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.senderAccountNameLabel.ForeColor = System.Drawing.Color.Black;
      this.senderAccountNameLabel.Location = new System.Drawing.Point(47, 22);
      this.senderAccountNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.senderAccountNameLabel.Name = "senderAccountNameLabel";
      this.senderAccountNameLabel.Size = new System.Drawing.Size(151, 19);
      this.senderAccountNameLabel.TabIndex = 6;
      this.senderAccountNameLabel.Text = "Sender Account Name";
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.LightGray;
      this.panel1.Controls.Add(this.cancelButton);
      this.panel1.Controls.Add(this.transferButton);
      this.panel1.Controls.Add(this.amountTextBox);
      this.panel1.Controls.Add(this.recieverAccountNameTextBox);
      this.panel1.Controls.Add(this.senderAccountNameTextBox);
      this.panel1.Controls.Add(this.amountLabel);
      this.panel1.Controls.Add(this.recieverAccountLabel);
      this.panel1.Controls.Add(this.senderAccountNameLabel);
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
      // transferButton
      // 
      this.transferButton.BackColor = System.Drawing.Color.DimGray;
      this.transferButton.BackgroundColor = System.Drawing.Color.DimGray;
      this.transferButton.BorderColor = System.Drawing.Color.DarkGray;
      this.transferButton.BorderRadius = 20;
      this.transferButton.BorderSize = 1;
      this.transferButton.FlatAppearance.BorderSize = 0;
      this.transferButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.transferButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.transferButton.ForeColor = System.Drawing.Color.White;
      this.transferButton.Location = new System.Drawing.Point(154, 297);
      this.transferButton.Margin = new System.Windows.Forms.Padding(2);
      this.transferButton.Name = "transferButton";
      this.transferButton.Size = new System.Drawing.Size(205, 50);
      this.transferButton.TabIndex = 9;
      this.transferButton.Text = "Transfer Money";
      this.transferButton.TextColor = System.Drawing.Color.White;
      this.transferButton.UseVisualStyleBackColor = false;
      this.transferButton.Click += new System.EventHandler(this.transferButton_Click);
      // 
      // amountTextBox
      // 
      this.amountTextBox.BackColor = System.Drawing.SystemColors.Window;
      this.amountTextBox.BorderColor = System.Drawing.Color.DimGray;
      this.amountTextBox.BorderFocusColor = System.Drawing.Color.Black;
      this.amountTextBox.BorderRadius = 10;
      this.amountTextBox.BorderSize = 2;
      this.amountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.amountTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.amountTextBox.Location = new System.Drawing.Point(204, 96);
      this.amountTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.amountTextBox.Multiline = true;
      this.amountTextBox.Name = "amountTextBox";
      this.amountTextBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
      this.amountTextBox.PasswordChar = false;
      this.amountTextBox.PlaceholderColor = System.Drawing.Color.Silver;
      this.amountTextBox.PlaceholderText = "Amount";
      this.amountTextBox.Size = new System.Drawing.Size(448, 29);
      this.amountTextBox.TabIndex = 8;
      this.amountTextBox.Texts = "";
      this.amountTextBox.UnderlinedStyle = false;
      // 
      // recieverAccountNameTextBox
      // 
      this.recieverAccountNameTextBox.BackColor = System.Drawing.SystemColors.Window;
      this.recieverAccountNameTextBox.BorderColor = System.Drawing.Color.DimGray;
      this.recieverAccountNameTextBox.BorderFocusColor = System.Drawing.Color.Black;
      this.recieverAccountNameTextBox.BorderRadius = 10;
      this.recieverAccountNameTextBox.BorderSize = 2;
      this.recieverAccountNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.recieverAccountNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.recieverAccountNameTextBox.Location = new System.Drawing.Point(204, 59);
      this.recieverAccountNameTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.recieverAccountNameTextBox.Multiline = false;
      this.recieverAccountNameTextBox.Name = "recieverAccountNameTextBox";
      this.recieverAccountNameTextBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
      this.recieverAccountNameTextBox.PasswordChar = false;
      this.recieverAccountNameTextBox.PlaceholderColor = System.Drawing.Color.Silver;
      this.recieverAccountNameTextBox.PlaceholderText = "Account to send money to";
      this.recieverAccountNameTextBox.Size = new System.Drawing.Size(448, 29);
      this.recieverAccountNameTextBox.TabIndex = 5;
      this.recieverAccountNameTextBox.Texts = "";
      this.recieverAccountNameTextBox.UnderlinedStyle = false;
      // 
      // senderAccountNameTextBox
      // 
      this.senderAccountNameTextBox.BackColor = System.Drawing.SystemColors.Window;
      this.senderAccountNameTextBox.BorderColor = System.Drawing.Color.DimGray;
      this.senderAccountNameTextBox.BorderFocusColor = System.Drawing.Color.Black;
      this.senderAccountNameTextBox.BorderRadius = 10;
      this.senderAccountNameTextBox.BorderSize = 2;
      this.senderAccountNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.senderAccountNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.senderAccountNameTextBox.Location = new System.Drawing.Point(204, 22);
      this.senderAccountNameTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.senderAccountNameTextBox.Multiline = false;
      this.senderAccountNameTextBox.Name = "senderAccountNameTextBox";
      this.senderAccountNameTextBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
      this.senderAccountNameTextBox.PasswordChar = false;
      this.senderAccountNameTextBox.PlaceholderColor = System.Drawing.Color.Silver;
      this.senderAccountNameTextBox.PlaceholderText = "Account to send money from";
      this.senderAccountNameTextBox.Size = new System.Drawing.Size(448, 29);
      this.senderAccountNameTextBox.TabIndex = 5;
      this.senderAccountNameTextBox.Texts = "";
      this.senderAccountNameTextBox.UnderlinedStyle = false;
      // 
      // amountLabel
      // 
      this.amountLabel.AutoSize = true;
      this.amountLabel.BackColor = System.Drawing.Color.Transparent;
      this.amountLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.amountLabel.ForeColor = System.Drawing.Color.Black;
      this.amountLabel.Location = new System.Drawing.Point(111, 96);
      this.amountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.amountLabel.Name = "amountLabel";
      this.amountLabel.Size = new System.Drawing.Size(59, 19);
      this.amountLabel.TabIndex = 6;
      this.amountLabel.Text = "Amount";
      // 
      // recieverAccountLabel
      // 
      this.recieverAccountLabel.AutoSize = true;
      this.recieverAccountLabel.BackColor = System.Drawing.Color.Transparent;
      this.recieverAccountLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.recieverAccountLabel.ForeColor = System.Drawing.Color.Black;
      this.recieverAccountLabel.Location = new System.Drawing.Point(35, 59);
      this.recieverAccountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.recieverAccountLabel.Name = "recieverAccountLabel";
      this.recieverAccountLabel.Size = new System.Drawing.Size(163, 19);
      this.recieverAccountLabel.TabIndex = 6;
      this.recieverAccountLabel.Text = "Reciever Account Name";
      // 
      // TransferBudget
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(759, 421);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "TransferBudget";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "AddIncome";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private CustomControl.RJTextBox senderAccountNameTextBox;
    private System.Windows.Forms.Label senderAccountNameLabel;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label recieverAccountLabel;
    private System.Windows.Forms.Label amountLabel;
    private CustomControl.RJTextBox amountTextBox;
    private CustomControl.RJButton cancelButton;
    private CustomControl.RJButton transferButton;
    private CustomControl.RJTextBox recieverAccountNameTextBox;
  }
}