
namespace WalletBuddy.Forms
{
  partial class AddAccount
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
      this.accountNameLabel = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.cancelButton = new WalletBuddy.CustomControl.RJButton();
      this.addButton = new WalletBuddy.CustomControl.RJButton();
      this.descriptionTextBox = new WalletBuddy.CustomControl.RJTextBox();
      this.startingAmountTextBox = new WalletBuddy.CustomControl.RJTextBox();
      this.accountTypeTextBox = new WalletBuddy.CustomControl.RJTextBox();
      this.paymentFromTextBox = new WalletBuddy.CustomControl.RJTextBox();
      this.descriptionLabel = new System.Windows.Forms.Label();
      this.startingAmountLabel = new System.Windows.Forms.Label();
      this.accountTypeLabel = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // accountNameLabel
      // 
      this.accountNameLabel.AutoSize = true;
      this.accountNameLabel.BackColor = System.Drawing.Color.Transparent;
      this.accountNameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.accountNameLabel.ForeColor = System.Drawing.Color.Black;
      this.accountNameLabel.Location = new System.Drawing.Point(91, 22);
      this.accountNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.accountNameLabel.Name = "accountNameLabel";
      this.accountNameLabel.Size = new System.Drawing.Size(103, 19);
      this.accountNameLabel.TabIndex = 6;
      this.accountNameLabel.Text = "Account Name";
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.LightGray;
      this.panel1.Controls.Add(this.cancelButton);
      this.panel1.Controls.Add(this.addButton);
      this.panel1.Controls.Add(this.descriptionTextBox);
      this.panel1.Controls.Add(this.startingAmountTextBox);
      this.panel1.Controls.Add(this.accountTypeTextBox);
      this.panel1.Controls.Add(this.paymentFromTextBox);
      this.panel1.Controls.Add(this.descriptionLabel);
      this.panel1.Controls.Add(this.startingAmountLabel);
      this.panel1.Controls.Add(this.accountTypeLabel);
      this.panel1.Controls.Add(this.accountNameLabel);
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
      // addButton
      // 
      this.addButton.BackColor = System.Drawing.Color.DimGray;
      this.addButton.BackgroundColor = System.Drawing.Color.DimGray;
      this.addButton.BorderColor = System.Drawing.Color.DarkGray;
      this.addButton.BorderRadius = 20;
      this.addButton.BorderSize = 1;
      this.addButton.FlatAppearance.BorderSize = 0;
      this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.addButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.addButton.ForeColor = System.Drawing.Color.White;
      this.addButton.Location = new System.Drawing.Point(154, 297);
      this.addButton.Margin = new System.Windows.Forms.Padding(2);
      this.addButton.Name = "addButton";
      this.addButton.Size = new System.Drawing.Size(205, 50);
      this.addButton.TabIndex = 9;
      this.addButton.Text = "Add";
      this.addButton.TextColor = System.Drawing.Color.White;
      this.addButton.UseVisualStyleBackColor = false;
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
      this.descriptionTextBox.Location = new System.Drawing.Point(204, 131);
      this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.descriptionTextBox.Multiline = true;
      this.descriptionTextBox.Name = "descriptionTextBox";
      this.descriptionTextBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
      this.descriptionTextBox.PasswordChar = false;
      this.descriptionTextBox.PlaceholderColor = System.Drawing.Color.Silver;
      this.descriptionTextBox.PlaceholderText = "Description";
      this.descriptionTextBox.Size = new System.Drawing.Size(448, 150);
      this.descriptionTextBox.TabIndex = 8;
      this.descriptionTextBox.Texts = "";
      this.descriptionTextBox.UnderlinedStyle = false;
      // 
      // startingAmountTextBox
      // 
      this.startingAmountTextBox.BackColor = System.Drawing.SystemColors.Window;
      this.startingAmountTextBox.BorderColor = System.Drawing.Color.DimGray;
      this.startingAmountTextBox.BorderFocusColor = System.Drawing.Color.Black;
      this.startingAmountTextBox.BorderRadius = 10;
      this.startingAmountTextBox.BorderSize = 2;
      this.startingAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.startingAmountTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.startingAmountTextBox.Location = new System.Drawing.Point(204, 94);
      this.startingAmountTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.startingAmountTextBox.Multiline = false;
      this.startingAmountTextBox.Name = "startingAmountTextBox";
      this.startingAmountTextBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
      this.startingAmountTextBox.PasswordChar = false;
      this.startingAmountTextBox.PlaceholderColor = System.Drawing.Color.Silver;
      this.startingAmountTextBox.PlaceholderText = "Starting amount";
      this.startingAmountTextBox.Size = new System.Drawing.Size(448, 29);
      this.startingAmountTextBox.TabIndex = 5;
      this.startingAmountTextBox.Texts = "";
      this.startingAmountTextBox.UnderlinedStyle = false;
      // 
      // accountTypeTextBox
      // 
      this.accountTypeTextBox.BackColor = System.Drawing.SystemColors.Window;
      this.accountTypeTextBox.BorderColor = System.Drawing.Color.DimGray;
      this.accountTypeTextBox.BorderFocusColor = System.Drawing.Color.Black;
      this.accountTypeTextBox.BorderRadius = 10;
      this.accountTypeTextBox.BorderSize = 2;
      this.accountTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.accountTypeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.accountTypeTextBox.Location = new System.Drawing.Point(204, 57);
      this.accountTypeTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.accountTypeTextBox.Multiline = false;
      this.accountTypeTextBox.Name = "accountTypeTextBox";
      this.accountTypeTextBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
      this.accountTypeTextBox.PasswordChar = false;
      this.accountTypeTextBox.PlaceholderColor = System.Drawing.Color.Silver;
      this.accountTypeTextBox.PlaceholderText = "Account Type";
      this.accountTypeTextBox.Size = new System.Drawing.Size(448, 29);
      this.accountTypeTextBox.TabIndex = 5;
      this.accountTypeTextBox.Texts = "";
      this.accountTypeTextBox.UnderlinedStyle = false;
      // 
      // paymentFromTextBox
      // 
      this.paymentFromTextBox.BackColor = System.Drawing.SystemColors.Window;
      this.paymentFromTextBox.BorderColor = System.Drawing.Color.DimGray;
      this.paymentFromTextBox.BorderFocusColor = System.Drawing.Color.Black;
      this.paymentFromTextBox.BorderRadius = 10;
      this.paymentFromTextBox.BorderSize = 2;
      this.paymentFromTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.paymentFromTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.paymentFromTextBox.Location = new System.Drawing.Point(204, 22);
      this.paymentFromTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.paymentFromTextBox.Multiline = false;
      this.paymentFromTextBox.Name = "paymentFromTextBox";
      this.paymentFromTextBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
      this.paymentFromTextBox.PasswordChar = false;
      this.paymentFromTextBox.PlaceholderColor = System.Drawing.Color.Silver;
      this.paymentFromTextBox.PlaceholderText = "Account Name";
      this.paymentFromTextBox.Size = new System.Drawing.Size(448, 29);
      this.paymentFromTextBox.TabIndex = 5;
      this.paymentFromTextBox.Texts = "";
      this.paymentFromTextBox.UnderlinedStyle = false;
      // 
      // descriptionLabel
      // 
      this.descriptionLabel.AutoSize = true;
      this.descriptionLabel.BackColor = System.Drawing.Color.Transparent;
      this.descriptionLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.descriptionLabel.ForeColor = System.Drawing.Color.Black;
      this.descriptionLabel.Location = new System.Drawing.Point(111, 131);
      this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.descriptionLabel.Name = "descriptionLabel";
      this.descriptionLabel.Size = new System.Drawing.Size(83, 19);
      this.descriptionLabel.TabIndex = 6;
      this.descriptionLabel.Text = "Description";
      // 
      // startingAmountLabel
      // 
      this.startingAmountLabel.AutoSize = true;
      this.startingAmountLabel.BackColor = System.Drawing.Color.Transparent;
      this.startingAmountLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.startingAmountLabel.ForeColor = System.Drawing.Color.Black;
      this.startingAmountLabel.Location = new System.Drawing.Point(81, 94);
      this.startingAmountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.startingAmountLabel.Name = "startingAmountLabel";
      this.startingAmountLabel.Size = new System.Drawing.Size(113, 19);
      this.startingAmountLabel.TabIndex = 6;
      this.startingAmountLabel.Text = "Starting Amount";
      // 
      // accountTypeLabel
      // 
      this.accountTypeLabel.AutoSize = true;
      this.accountTypeLabel.BackColor = System.Drawing.Color.Transparent;
      this.accountTypeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.accountTypeLabel.ForeColor = System.Drawing.Color.Black;
      this.accountTypeLabel.Location = new System.Drawing.Point(99, 57);
      this.accountTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.accountTypeLabel.Name = "accountTypeLabel";
      this.accountTypeLabel.Size = new System.Drawing.Size(95, 19);
      this.accountTypeLabel.TabIndex = 6;
      this.accountTypeLabel.Text = "Account Type";
      // 
      // AddAccount
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(759, 421);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "AddAccount";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "AddIncome";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private CustomControl.RJTextBox paymentFromTextBox;
    private System.Windows.Forms.Label accountNameLabel;
    private System.Windows.Forms.Panel panel1;
    private CustomControl.RJTextBox accountTypeTextBox;
    private System.Windows.Forms.Label accountTypeLabel;
    private System.Windows.Forms.Label startingAmountLabel;
    private System.Windows.Forms.Label descriptionLabel;
    private CustomControl.RJTextBox descriptionTextBox;
    private CustomControl.RJButton cancelButton;
    private CustomControl.RJButton addButton;
    private CustomControl.RJTextBox startingAmountTextBox;
  }
}