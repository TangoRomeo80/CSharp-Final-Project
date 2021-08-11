
namespace WalletBuddy.Forms
{
  partial class AddPayment
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
      this.paymentNameLabel = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.cancelButton = new WalletBuddy.CustomControl.RJButton();
      this.addButton = new WalletBuddy.CustomControl.RJButton();
      this.descriptionTextBox = new WalletBuddy.CustomControl.RJTextBox();
      this.paymentAmountTextBox = new WalletBuddy.CustomControl.RJTextBox();
      this.paymentRecieverTextBox = new WalletBuddy.CustomControl.RJTextBox();
      this.paymentNameTextBox = new WalletBuddy.CustomControl.RJTextBox();
      this.descriptionLabel = new System.Windows.Forms.Label();
      this.paymentAmountLabel = new System.Windows.Forms.Label();
      this.paymentRecieverLabel = new System.Windows.Forms.Label();
      this.dueDate = new System.Windows.Forms.Label();
      this.dueDatePicker = new System.Windows.Forms.DateTimePicker();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // paymentNameLabel
      // 
      this.paymentNameLabel.AutoSize = true;
      this.paymentNameLabel.BackColor = System.Drawing.Color.Transparent;
      this.paymentNameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.paymentNameLabel.ForeColor = System.Drawing.Color.Black;
      this.paymentNameLabel.Location = new System.Drawing.Point(91, 22);
      this.paymentNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.paymentNameLabel.Name = "paymentNameLabel";
      this.paymentNameLabel.Size = new System.Drawing.Size(107, 19);
      this.paymentNameLabel.TabIndex = 6;
      this.paymentNameLabel.Text = "Payment Name";
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.LightGray;
      this.panel1.Controls.Add(this.dueDatePicker);
      this.panel1.Controls.Add(this.dueDate);
      this.panel1.Controls.Add(this.cancelButton);
      this.panel1.Controls.Add(this.addButton);
      this.panel1.Controls.Add(this.descriptionTextBox);
      this.panel1.Controls.Add(this.paymentAmountTextBox);
      this.panel1.Controls.Add(this.paymentRecieverTextBox);
      this.panel1.Controls.Add(this.paymentNameTextBox);
      this.panel1.Controls.Add(this.descriptionLabel);
      this.panel1.Controls.Add(this.paymentAmountLabel);
      this.panel1.Controls.Add(this.paymentRecieverLabel);
      this.panel1.Controls.Add(this.paymentNameLabel);
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
      this.cancelButton.Location = new System.Drawing.Point(390, 309);
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
      this.addButton.Location = new System.Drawing.Point(154, 309);
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
      this.descriptionTextBox.Size = new System.Drawing.Size(448, 107);
      this.descriptionTextBox.TabIndex = 8;
      this.descriptionTextBox.Texts = "";
      this.descriptionTextBox.UnderlinedStyle = false;
      // 
      // paymentAmountTextBox
      // 
      this.paymentAmountTextBox.BackColor = System.Drawing.SystemColors.Window;
      this.paymentAmountTextBox.BorderColor = System.Drawing.Color.DimGray;
      this.paymentAmountTextBox.BorderFocusColor = System.Drawing.Color.Black;
      this.paymentAmountTextBox.BorderRadius = 10;
      this.paymentAmountTextBox.BorderSize = 2;
      this.paymentAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.paymentAmountTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.paymentAmountTextBox.Location = new System.Drawing.Point(204, 94);
      this.paymentAmountTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.paymentAmountTextBox.Multiline = false;
      this.paymentAmountTextBox.Name = "paymentAmountTextBox";
      this.paymentAmountTextBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
      this.paymentAmountTextBox.PasswordChar = false;
      this.paymentAmountTextBox.PlaceholderColor = System.Drawing.Color.Silver;
      this.paymentAmountTextBox.PlaceholderText = "AccountType";
      this.paymentAmountTextBox.Size = new System.Drawing.Size(448, 29);
      this.paymentAmountTextBox.TabIndex = 5;
      this.paymentAmountTextBox.Texts = "";
      this.paymentAmountTextBox.UnderlinedStyle = false;
      // 
      // paymentRecieverTextBox
      // 
      this.paymentRecieverTextBox.BackColor = System.Drawing.SystemColors.Window;
      this.paymentRecieverTextBox.BorderColor = System.Drawing.Color.DimGray;
      this.paymentRecieverTextBox.BorderFocusColor = System.Drawing.Color.Black;
      this.paymentRecieverTextBox.BorderRadius = 10;
      this.paymentRecieverTextBox.BorderSize = 2;
      this.paymentRecieverTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.paymentRecieverTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.paymentRecieverTextBox.Location = new System.Drawing.Point(204, 57);
      this.paymentRecieverTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.paymentRecieverTextBox.Multiline = false;
      this.paymentRecieverTextBox.Name = "paymentRecieverTextBox";
      this.paymentRecieverTextBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
      this.paymentRecieverTextBox.PasswordChar = false;
      this.paymentRecieverTextBox.PlaceholderColor = System.Drawing.Color.Silver;
      this.paymentRecieverTextBox.PlaceholderText = "Payment Reciever";
      this.paymentRecieverTextBox.Size = new System.Drawing.Size(448, 29);
      this.paymentRecieverTextBox.TabIndex = 5;
      this.paymentRecieverTextBox.Texts = "";
      this.paymentRecieverTextBox.UnderlinedStyle = false;
      // 
      // paymentNameTextBox
      // 
      this.paymentNameTextBox.BackColor = System.Drawing.SystemColors.Window;
      this.paymentNameTextBox.BorderColor = System.Drawing.Color.DimGray;
      this.paymentNameTextBox.BorderFocusColor = System.Drawing.Color.Black;
      this.paymentNameTextBox.BorderRadius = 10;
      this.paymentNameTextBox.BorderSize = 2;
      this.paymentNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.paymentNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.paymentNameTextBox.Location = new System.Drawing.Point(204, 22);
      this.paymentNameTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.paymentNameTextBox.Multiline = false;
      this.paymentNameTextBox.Name = "paymentNameTextBox";
      this.paymentNameTextBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
      this.paymentNameTextBox.PasswordChar = false;
      this.paymentNameTextBox.PlaceholderColor = System.Drawing.Color.Silver;
      this.paymentNameTextBox.PlaceholderText = "Payment Name";
      this.paymentNameTextBox.Size = new System.Drawing.Size(448, 29);
      this.paymentNameTextBox.TabIndex = 5;
      this.paymentNameTextBox.Texts = "";
      this.paymentNameTextBox.UnderlinedStyle = false;
      // 
      // descriptionLabel
      // 
      this.descriptionLabel.AutoSize = true;
      this.descriptionLabel.BackColor = System.Drawing.Color.Transparent;
      this.descriptionLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.descriptionLabel.ForeColor = System.Drawing.Color.Black;
      this.descriptionLabel.Location = new System.Drawing.Point(115, 131);
      this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.descriptionLabel.Name = "descriptionLabel";
      this.descriptionLabel.Size = new System.Drawing.Size(83, 19);
      this.descriptionLabel.TabIndex = 6;
      this.descriptionLabel.Text = "Description";
      // 
      // paymentAmountLabel
      // 
      this.paymentAmountLabel.AutoSize = true;
      this.paymentAmountLabel.BackColor = System.Drawing.Color.Transparent;
      this.paymentAmountLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.paymentAmountLabel.ForeColor = System.Drawing.Color.Black;
      this.paymentAmountLabel.Location = new System.Drawing.Point(79, 94);
      this.paymentAmountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.paymentAmountLabel.Name = "paymentAmountLabel";
      this.paymentAmountLabel.Size = new System.Drawing.Size(119, 19);
      this.paymentAmountLabel.TabIndex = 6;
      this.paymentAmountLabel.Text = "Payment Amount";
      // 
      // paymentRecieverLabel
      // 
      this.paymentRecieverLabel.AutoSize = true;
      this.paymentRecieverLabel.BackColor = System.Drawing.Color.Transparent;
      this.paymentRecieverLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.paymentRecieverLabel.ForeColor = System.Drawing.Color.Black;
      this.paymentRecieverLabel.Location = new System.Drawing.Point(73, 57);
      this.paymentRecieverLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.paymentRecieverLabel.Name = "paymentRecieverLabel";
      this.paymentRecieverLabel.Size = new System.Drawing.Size(125, 19);
      this.paymentRecieverLabel.TabIndex = 6;
      this.paymentRecieverLabel.Text = "Payment Reciever";
      // 
      // dueDate
      // 
      this.dueDate.AutoSize = true;
      this.dueDate.BackColor = System.Drawing.Color.Transparent;
      this.dueDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dueDate.ForeColor = System.Drawing.Color.Black;
      this.dueDate.Location = new System.Drawing.Point(128, 254);
      this.dueDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.dueDate.Name = "dueDate";
      this.dueDate.Size = new System.Drawing.Size(70, 19);
      this.dueDate.TabIndex = 10;
      this.dueDate.Text = "Due Date";
      // 
      // dueDatePicker
      // 
      this.dueDatePicker.Location = new System.Drawing.Point(204, 252);
      this.dueDatePicker.Name = "dueDatePicker";
      this.dueDatePicker.Size = new System.Drawing.Size(200, 20);
      this.dueDatePicker.TabIndex = 11;
      // 
      // AddPayment
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(759, 421);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "AddPayment";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "AddIncome";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private CustomControl.RJTextBox paymentNameTextBox;
    private System.Windows.Forms.Label paymentNameLabel;
    private System.Windows.Forms.Panel panel1;
    private CustomControl.RJTextBox paymentRecieverTextBox;
    private System.Windows.Forms.Label paymentRecieverLabel;
    private System.Windows.Forms.Label paymentAmountLabel;
    private System.Windows.Forms.Label descriptionLabel;
    private CustomControl.RJTextBox descriptionTextBox;
    private CustomControl.RJButton cancelButton;
    private CustomControl.RJButton addButton;
    private CustomControl.RJTextBox paymentAmountTextBox;
    private System.Windows.Forms.DateTimePicker dueDatePicker;
    private System.Windows.Forms.Label dueDate;
  }
}