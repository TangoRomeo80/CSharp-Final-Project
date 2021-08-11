
namespace WalletBuddy.Forms
{
  partial class AddIncome
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
      this.paymentFromLabel = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.accountComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
      this.descriptionLabel = new System.Windows.Forms.Label();
      this.accountLabel = new System.Windows.Forms.Label();
      this.paymentAmountLabel = new System.Windows.Forms.Label();
      this.cancelButton = new WalletBuddy.CustomControl.RJButton();
      this.addButton = new WalletBuddy.CustomControl.RJButton();
      this.descriptionTextBox = new WalletBuddy.CustomControl.RJTextBox();
      this.paymentAmountTextBox = new WalletBuddy.CustomControl.RJTextBox();
      this.paymentFromTextBox = new WalletBuddy.CustomControl.RJTextBox();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.accountComboBox)).BeginInit();
      this.SuspendLayout();
      // 
      // paymentFromLabel
      // 
      this.paymentFromLabel.AutoSize = true;
      this.paymentFromLabel.BackColor = System.Drawing.Color.Transparent;
      this.paymentFromLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.paymentFromLabel.ForeColor = System.Drawing.Color.Black;
      this.paymentFromLabel.Location = new System.Drawing.Point(69, 18);
      this.paymentFromLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.paymentFromLabel.Name = "paymentFromLabel";
      this.paymentFromLabel.Size = new System.Drawing.Size(164, 19);
      this.paymentFromLabel.TabIndex = 6;
      this.paymentFromLabel.Text = "Payment Recieved From";
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.PaleGreen;
      this.panel1.Controls.Add(this.cancelButton);
      this.panel1.Controls.Add(this.addButton);
      this.panel1.Controls.Add(this.descriptionTextBox);
      this.panel1.Controls.Add(this.accountComboBox);
      this.panel1.Controls.Add(this.paymentAmountTextBox);
      this.panel1.Controls.Add(this.paymentFromTextBox);
      this.panel1.Controls.Add(this.descriptionLabel);
      this.panel1.Controls.Add(this.accountLabel);
      this.panel1.Controls.Add(this.paymentAmountLabel);
      this.panel1.Controls.Add(this.paymentFromLabel);
      this.panel1.Location = new System.Drawing.Point(12, 12);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(735, 397);
      this.panel1.TabIndex = 7;
      // 
      // accountComboBox
      // 
      this.accountComboBox.DropDownWidth = 181;
      this.accountComboBox.Location = new System.Drawing.Point(243, 89);
      this.accountComboBox.Name = "accountComboBox";
      this.accountComboBox.Size = new System.Drawing.Size(181, 21);
      this.accountComboBox.TabIndex = 7;
      this.accountComboBox.Text = "Accounts";
      // 
      // descriptionLabel
      // 
      this.descriptionLabel.AutoSize = true;
      this.descriptionLabel.BackColor = System.Drawing.Color.Transparent;
      this.descriptionLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.descriptionLabel.ForeColor = System.Drawing.Color.Black;
      this.descriptionLabel.Location = new System.Drawing.Point(150, 127);
      this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.descriptionLabel.Name = "descriptionLabel";
      this.descriptionLabel.Size = new System.Drawing.Size(83, 19);
      this.descriptionLabel.TabIndex = 6;
      this.descriptionLabel.Text = "Description";
      // 
      // accountLabel
      // 
      this.accountLabel.AutoSize = true;
      this.accountLabel.BackColor = System.Drawing.Color.Transparent;
      this.accountLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.accountLabel.ForeColor = System.Drawing.Color.Black;
      this.accountLabel.Location = new System.Drawing.Point(33, 89);
      this.accountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.accountLabel.Name = "accountLabel";
      this.accountLabel.Size = new System.Drawing.Size(200, 19);
      this.accountLabel.TabIndex = 6;
      this.accountLabel.Text = "Payment Recieved in Account";
      // 
      // paymentAmountLabel
      // 
      this.paymentAmountLabel.AutoSize = true;
      this.paymentAmountLabel.BackColor = System.Drawing.Color.Transparent;
      this.paymentAmountLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.paymentAmountLabel.ForeColor = System.Drawing.Color.Black;
      this.paymentAmountLabel.Location = new System.Drawing.Point(47, 53);
      this.paymentAmountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.paymentAmountLabel.Name = "paymentAmountLabel";
      this.paymentAmountLabel.Size = new System.Drawing.Size(186, 19);
      this.paymentAmountLabel.TabIndex = 6;
      this.paymentAmountLabel.Text = "Payment Recieving Amount";
      // 
      // cancelButton
      // 
      this.cancelButton.BackColor = System.Drawing.Color.SeaGreen;
      this.cancelButton.BackgroundColor = System.Drawing.Color.SeaGreen;
      this.cancelButton.BorderColor = System.Drawing.Color.LimeGreen;
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
      this.addButton.BackColor = System.Drawing.Color.SeaGreen;
      this.addButton.BackgroundColor = System.Drawing.Color.SeaGreen;
      this.addButton.BorderColor = System.Drawing.Color.LimeGreen;
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
      this.descriptionTextBox.BorderColor = System.Drawing.Color.LimeGreen;
      this.descriptionTextBox.BorderFocusColor = System.Drawing.Color.SeaGreen;
      this.descriptionTextBox.BorderRadius = 10;
      this.descriptionTextBox.BorderSize = 2;
      this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.descriptionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.descriptionTextBox.Location = new System.Drawing.Point(239, 117);
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
      // paymentAmountTextBox
      // 
      this.paymentAmountTextBox.BackColor = System.Drawing.SystemColors.Window;
      this.paymentAmountTextBox.BorderColor = System.Drawing.Color.LimeGreen;
      this.paymentAmountTextBox.BorderFocusColor = System.Drawing.Color.SeaGreen;
      this.paymentAmountTextBox.BorderRadius = 10;
      this.paymentAmountTextBox.BorderSize = 2;
      this.paymentAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.paymentAmountTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.paymentAmountTextBox.Location = new System.Drawing.Point(243, 53);
      this.paymentAmountTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.paymentAmountTextBox.Multiline = false;
      this.paymentAmountTextBox.Name = "paymentAmountTextBox";
      this.paymentAmountTextBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
      this.paymentAmountTextBox.PasswordChar = false;
      this.paymentAmountTextBox.PlaceholderColor = System.Drawing.Color.Silver;
      this.paymentAmountTextBox.PlaceholderText = "Payment Amount";
      this.paymentAmountTextBox.Size = new System.Drawing.Size(448, 29);
      this.paymentAmountTextBox.TabIndex = 5;
      this.paymentAmountTextBox.Texts = "";
      this.paymentAmountTextBox.UnderlinedStyle = false;
      // 
      // paymentFromTextBox
      // 
      this.paymentFromTextBox.BackColor = System.Drawing.SystemColors.Window;
      this.paymentFromTextBox.BorderColor = System.Drawing.Color.LimeGreen;
      this.paymentFromTextBox.BorderFocusColor = System.Drawing.Color.SeaGreen;
      this.paymentFromTextBox.BorderRadius = 10;
      this.paymentFromTextBox.BorderSize = 2;
      this.paymentFromTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.paymentFromTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.paymentFromTextBox.Location = new System.Drawing.Point(243, 18);
      this.paymentFromTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.paymentFromTextBox.Multiline = false;
      this.paymentFromTextBox.Name = "paymentFromTextBox";
      this.paymentFromTextBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
      this.paymentFromTextBox.PasswordChar = false;
      this.paymentFromTextBox.PlaceholderColor = System.Drawing.Color.Silver;
      this.paymentFromTextBox.PlaceholderText = "Payment From";
      this.paymentFromTextBox.Size = new System.Drawing.Size(448, 29);
      this.paymentFromTextBox.TabIndex = 5;
      this.paymentFromTextBox.Texts = "";
      this.paymentFromTextBox.UnderlinedStyle = false;
      // 
      // AddIncome
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(759, 421);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "AddIncome";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "AddIncome";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.accountComboBox)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private CustomControl.RJTextBox paymentFromTextBox;
    private System.Windows.Forms.Label paymentFromLabel;
    private System.Windows.Forms.Panel panel1;
    private CustomControl.RJTextBox paymentAmountTextBox;
    private System.Windows.Forms.Label paymentAmountLabel;
    private ComponentFactory.Krypton.Toolkit.KryptonComboBox accountComboBox;
    private System.Windows.Forms.Label accountLabel;
    private System.Windows.Forms.Label descriptionLabel;
    private CustomControl.RJTextBox descriptionTextBox;
    private CustomControl.RJButton cancelButton;
    private CustomControl.RJButton addButton;
  }
}