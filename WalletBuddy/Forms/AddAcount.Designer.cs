
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
      this.accountNameTextBox = new WalletBuddy.CustomControl.RJTextBox();
      this.descriptionLabel = new System.Windows.Forms.Label();
      this.startingAmountLabel = new System.Windows.Forms.Label();
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
      this.panel1.Controls.Add(this.accountNameTextBox);
      this.panel1.Controls.Add(this.descriptionLabel);
      this.panel1.Controls.Add(this.startingAmountLabel);
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
      this.addButton.Click += new System.EventHandler(this.addButton_Click);
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
      this.descriptionTextBox.Location = new System.Drawing.Point(200, 96);
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
      this.startingAmountTextBox.Location = new System.Drawing.Point(200, 59);
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
      // accountNameTextBox
      // 
      this.accountNameTextBox.BackColor = System.Drawing.SystemColors.Window;
      this.accountNameTextBox.BorderColor = System.Drawing.Color.DimGray;
      this.accountNameTextBox.BorderFocusColor = System.Drawing.Color.Black;
      this.accountNameTextBox.BorderRadius = 10;
      this.accountNameTextBox.BorderSize = 2;
      this.accountNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.accountNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.accountNameTextBox.Location = new System.Drawing.Point(204, 22);
      this.accountNameTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.accountNameTextBox.Multiline = false;
      this.accountNameTextBox.Name = "accountNameTextBox";
      this.accountNameTextBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
      this.accountNameTextBox.PasswordChar = false;
      this.accountNameTextBox.PlaceholderColor = System.Drawing.Color.Silver;
      this.accountNameTextBox.PlaceholderText = "Account Name";
      this.accountNameTextBox.Size = new System.Drawing.Size(448, 29);
      this.accountNameTextBox.TabIndex = 5;
      this.accountNameTextBox.Texts = "";
      this.accountNameTextBox.UnderlinedStyle = false;
      // 
      // descriptionLabel
      // 
      this.descriptionLabel.AutoSize = true;
      this.descriptionLabel.BackColor = System.Drawing.Color.Transparent;
      this.descriptionLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.descriptionLabel.ForeColor = System.Drawing.Color.Black;
      this.descriptionLabel.Location = new System.Drawing.Point(111, 96);
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
      this.startingAmountLabel.Location = new System.Drawing.Point(81, 59);
      this.startingAmountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.startingAmountLabel.Name = "startingAmountLabel";
      this.startingAmountLabel.Size = new System.Drawing.Size(113, 19);
      this.startingAmountLabel.TabIndex = 6;
      this.startingAmountLabel.Text = "Starting Amount";
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

    private CustomControl.RJTextBox accountNameTextBox;
    private System.Windows.Forms.Label accountNameLabel;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label startingAmountLabel;
    private System.Windows.Forms.Label descriptionLabel;
    private CustomControl.RJTextBox descriptionTextBox;
    private CustomControl.RJButton cancelButton;
    private CustomControl.RJButton addButton;
    private CustomControl.RJTextBox startingAmountTextBox;
  }
}