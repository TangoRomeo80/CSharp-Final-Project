
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.durationComboBox = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
      this.cancelButton = new WalletBuddy.CustomControl.RJButton();
      this.durationLabel = new System.Windows.Forms.Label();
      this.addButton = new WalletBuddy.CustomControl.RJButton();
      this.targetSavingTextBox = new WalletBuddy.CustomControl.RJTextBox();
      this.targetSavingsLabel = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.durationComboBox)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
      this.panel1.Controls.Add(this.durationComboBox);
      this.panel1.Controls.Add(this.cancelButton);
      this.panel1.Controls.Add(this.durationLabel);
      this.panel1.Controls.Add(this.addButton);
      this.panel1.Controls.Add(this.targetSavingTextBox);
      this.panel1.Controls.Add(this.targetSavingsLabel);
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
      this.durationComboBox.Location = new System.Drawing.Point(201, 73);
      this.durationComboBox.Name = "durationComboBox";
      this.durationComboBox.Size = new System.Drawing.Size(181, 21);
      this.durationComboBox.TabIndex = 9;
      this.durationComboBox.Text = "Duration";
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
      this.durationLabel.Location = new System.Drawing.Point(102, 73);
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
      this.addButton.Click += new System.EventHandler(this.addButton_Click);
      // 
      // targetSavingTextBox
      // 
      this.targetSavingTextBox.BackColor = System.Drawing.SystemColors.Window;
      this.targetSavingTextBox.BorderColor = System.Drawing.Color.CornflowerBlue;
      this.targetSavingTextBox.BorderFocusColor = System.Drawing.Color.Blue;
      this.targetSavingTextBox.BorderRadius = 10;
      this.targetSavingTextBox.BorderSize = 2;
      this.targetSavingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.targetSavingTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.targetSavingTextBox.Location = new System.Drawing.Point(201, 31);
      this.targetSavingTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.targetSavingTextBox.Multiline = false;
      this.targetSavingTextBox.Name = "targetSavingTextBox";
      this.targetSavingTextBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
      this.targetSavingTextBox.PasswordChar = false;
      this.targetSavingTextBox.PlaceholderColor = System.Drawing.Color.Silver;
      this.targetSavingTextBox.PlaceholderText = "Target Savings";
      this.targetSavingTextBox.Size = new System.Drawing.Size(448, 29);
      this.targetSavingTextBox.TabIndex = 5;
      this.targetSavingTextBox.Texts = "";
      this.targetSavingTextBox.UnderlinedStyle = false;
      // 
      // targetSavingsLabel
      // 
      this.targetSavingsLabel.AutoSize = true;
      this.targetSavingsLabel.BackColor = System.Drawing.Color.Transparent;
      this.targetSavingsLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.targetSavingsLabel.ForeColor = System.Drawing.Color.Black;
      this.targetSavingsLabel.Location = new System.Drawing.Point(84, 31);
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
    private System.Windows.Forms.Panel panel1;
    private CustomControl.RJTextBox targetSavingTextBox;
    private System.Windows.Forms.Label targetSavingsLabel;
    private CustomControl.RJButton cancelButton;
    private CustomControl.RJButton addButton;
    private ComponentFactory.Krypton.Toolkit.KryptonComboBox durationComboBox;
    private System.Windows.Forms.Label durationLabel;
  }
}