
namespace WalletBuddy.Forms
{
  partial class AddGoal
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
      this.goalDurationLabel = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.durationComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
      this.cancelButton = new WalletBuddy.CustomControl.RJButton();
      this.durationLabel = new System.Windows.Forms.Label();
      this.addButton = new WalletBuddy.CustomControl.RJButton();
      this.accountTypeTextBox = new WalletBuddy.CustomControl.RJTextBox();
      this.goalDurationTextBox = new WalletBuddy.CustomControl.RJTextBox();
      this.targetSavingsLabel = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.durationComboBox)).BeginInit();
      this.SuspendLayout();
      // 
      // goalDurationLabel
      // 
      this.goalDurationLabel.AutoSize = true;
      this.goalDurationLabel.BackColor = System.Drawing.Color.Transparent;
      this.goalDurationLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.goalDurationLabel.ForeColor = System.Drawing.Color.Black;
      this.goalDurationLabel.Location = new System.Drawing.Point(91, 22);
      this.goalDurationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.goalDurationLabel.Name = "goalDurationLabel";
      this.goalDurationLabel.Size = new System.Drawing.Size(99, 19);
      this.goalDurationLabel.TabIndex = 6;
      this.goalDurationLabel.Text = "Goal Duration";
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
      this.panel1.Controls.Add(this.durationComboBox);
      this.panel1.Controls.Add(this.cancelButton);
      this.panel1.Controls.Add(this.durationLabel);
      this.panel1.Controls.Add(this.addButton);
      this.panel1.Controls.Add(this.accountTypeTextBox);
      this.panel1.Controls.Add(this.goalDurationTextBox);
      this.panel1.Controls.Add(this.targetSavingsLabel);
      this.panel1.Controls.Add(this.goalDurationLabel);
      this.panel1.Location = new System.Drawing.Point(12, 12);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(735, 397);
      this.panel1.TabIndex = 7;
      // 
      // durationComboBox
      // 
      this.durationComboBox.DropDownWidth = 181;
      this.durationComboBox.Items.AddRange(new object[] {
            "Week",
            "Month",
            "Year"});
      this.durationComboBox.Location = new System.Drawing.Point(204, 99);
      this.durationComboBox.Name = "durationComboBox";
      this.durationComboBox.Size = new System.Drawing.Size(181, 21);
      this.durationComboBox.TabIndex = 9;
      this.durationComboBox.Text = "Accounts";
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
      // durationLabel
      // 
      this.durationLabel.AutoSize = true;
      this.durationLabel.BackColor = System.Drawing.Color.Transparent;
      this.durationLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.durationLabel.ForeColor = System.Drawing.Color.Black;
      this.durationLabel.Location = new System.Drawing.Point(105, 99);
      this.durationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.durationLabel.Name = "durationLabel";
      this.durationLabel.Size = new System.Drawing.Size(85, 19);
      this.durationLabel.TabIndex = 8;
      this.durationLabel.Text = "Goal set for";
      // 
      // addButton
      // 
      this.addButton.BackColor = System.Drawing.Color.Blue;
      this.addButton.BackgroundColor = System.Drawing.Color.Blue;
      this.addButton.BorderColor = System.Drawing.Color.CornflowerBlue;
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
      // accountTypeTextBox
      // 
      this.accountTypeTextBox.BackColor = System.Drawing.SystemColors.Window;
      this.accountTypeTextBox.BorderColor = System.Drawing.Color.CornflowerBlue;
      this.accountTypeTextBox.BorderFocusColor = System.Drawing.Color.Blue;
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
      this.accountTypeTextBox.PlaceholderText = "Target Savings";
      this.accountTypeTextBox.Size = new System.Drawing.Size(448, 29);
      this.accountTypeTextBox.TabIndex = 5;
      this.accountTypeTextBox.Texts = "";
      this.accountTypeTextBox.UnderlinedStyle = false;
      // 
      // goalDurationTextBox
      // 
      this.goalDurationTextBox.BackColor = System.Drawing.SystemColors.Window;
      this.goalDurationTextBox.BorderColor = System.Drawing.Color.CornflowerBlue;
      this.goalDurationTextBox.BorderFocusColor = System.Drawing.Color.Blue;
      this.goalDurationTextBox.BorderRadius = 10;
      this.goalDurationTextBox.BorderSize = 2;
      this.goalDurationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.goalDurationTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.goalDurationTextBox.Location = new System.Drawing.Point(204, 22);
      this.goalDurationTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.goalDurationTextBox.Multiline = false;
      this.goalDurationTextBox.Name = "goalDurationTextBox";
      this.goalDurationTextBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
      this.goalDurationTextBox.PasswordChar = false;
      this.goalDurationTextBox.PlaceholderColor = System.Drawing.Color.Silver;
      this.goalDurationTextBox.PlaceholderText = "Goal Duration";
      this.goalDurationTextBox.Size = new System.Drawing.Size(448, 29);
      this.goalDurationTextBox.TabIndex = 5;
      this.goalDurationTextBox.Texts = "";
      this.goalDurationTextBox.UnderlinedStyle = false;
      // 
      // targetSavingsLabel
      // 
      this.targetSavingsLabel.AutoSize = true;
      this.targetSavingsLabel.BackColor = System.Drawing.Color.Transparent;
      this.targetSavingsLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.targetSavingsLabel.ForeColor = System.Drawing.Color.Black;
      this.targetSavingsLabel.Location = new System.Drawing.Point(87, 57);
      this.targetSavingsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.targetSavingsLabel.Name = "targetSavingsLabel";
      this.targetSavingsLabel.Size = new System.Drawing.Size(103, 19);
      this.targetSavingsLabel.TabIndex = 6;
      this.targetSavingsLabel.Text = "Target Savings";
      // 
      // AddGoal
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(759, 421);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "AddGoal";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "AddIncome";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.durationComboBox)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private CustomControl.RJTextBox goalDurationTextBox;
    private System.Windows.Forms.Label goalDurationLabel;
    private System.Windows.Forms.Panel panel1;
    private CustomControl.RJTextBox accountTypeTextBox;
    private System.Windows.Forms.Label targetSavingsLabel;
    private CustomControl.RJButton cancelButton;
    private CustomControl.RJButton addButton;
    private ComponentFactory.Krypton.Toolkit.KryptonComboBox durationComboBox;
    private System.Windows.Forms.Label durationLabel;
  }
}