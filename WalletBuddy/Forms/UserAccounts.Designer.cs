
namespace WalletBuddy.Forms
{
  partial class UserAccounts
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccounts));
      this.addAccountButton = new WalletBuddy.CustomControl.RJButton();
      this.AccountDataGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
      this.AccountNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.AccountTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.StartingAmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.BalanceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.rjButton1 = new WalletBuddy.CustomControl.RJButton();
      ((System.ComponentModel.ISupportInitialize)(this.AccountDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // addAccountButton
      // 
      this.addAccountButton.BackColor = System.Drawing.Color.White;
      this.addAccountButton.BackgroundColor = System.Drawing.Color.White;
      this.addAccountButton.BorderColor = System.Drawing.Color.Black;
      this.addAccountButton.BorderRadius = 10;
      this.addAccountButton.BorderSize = 1;
      this.addAccountButton.FlatAppearance.BorderSize = 0;
      this.addAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.addAccountButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.addAccountButton.ForeColor = System.Drawing.Color.SlateGray;
      this.addAccountButton.Image = ((System.Drawing.Image)(resources.GetObject("addAccountButton.Image")));
      this.addAccountButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.addAccountButton.Location = new System.Drawing.Point(13, 5);
      this.addAccountButton.Margin = new System.Windows.Forms.Padding(2);
      this.addAccountButton.Name = "addAccountButton";
      this.addAccountButton.Size = new System.Drawing.Size(112, 37);
      this.addAccountButton.TabIndex = 3;
      this.addAccountButton.Text = "Add Account";
      this.addAccountButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.addAccountButton.TextColor = System.Drawing.Color.SlateGray;
      this.addAccountButton.UseVisualStyleBackColor = false;
      this.addAccountButton.Click += new System.EventHandler(this.addAccountButton_Click);
      // 
      // AccountDataGridView
      // 
      this.AccountDataGridView.AllowUserToOrderColumns = true;
      this.AccountDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.AccountDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.AccountDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountNameColumn,
            this.AccountTypeColumn,
            this.DescriptionColumn,
            this.StartingAmountColumn,
            this.BalanceColumn});
      this.AccountDataGridView.Location = new System.Drawing.Point(13, 47);
      this.AccountDataGridView.Name = "AccountDataGridView";
      this.AccountDataGridView.Size = new System.Drawing.Size(903, 369);
      this.AccountDataGridView.StateCommon.Background.Color1 = System.Drawing.Color.LightGray;
      this.AccountDataGridView.StateCommon.Background.Color2 = System.Drawing.Color.LightGray;
      this.AccountDataGridView.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
      this.AccountDataGridView.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.DarkGray;
      this.AccountDataGridView.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.DarkGray;
      this.AccountDataGridView.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.Gray;
      this.AccountDataGridView.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.Gray;
      this.AccountDataGridView.TabIndex = 2;
      // 
      // AccountNameColumn
      // 
      this.AccountNameColumn.HeaderText = "Account Name";
      this.AccountNameColumn.Name = "AccountNameColumn";
      // 
      // AccountTypeColumn
      // 
      this.AccountTypeColumn.HeaderText = "Account Type";
      this.AccountTypeColumn.Name = "AccountTypeColumn";
      // 
      // DescriptionColumn
      // 
      this.DescriptionColumn.HeaderText = "Description";
      this.DescriptionColumn.Name = "DescriptionColumn";
      // 
      // StartingAmountColumn
      // 
      this.StartingAmountColumn.HeaderText = "Starting Amount";
      this.StartingAmountColumn.Name = "StartingAmountColumn";
      // 
      // BalanceColumn
      // 
      this.BalanceColumn.HeaderText = "Balance";
      this.BalanceColumn.Name = "BalanceColumn";
      // 
      // rjButton1
      // 
      this.rjButton1.BackColor = System.Drawing.Color.White;
      this.rjButton1.BackgroundColor = System.Drawing.Color.White;
      this.rjButton1.BorderColor = System.Drawing.Color.Black;
      this.rjButton1.BorderRadius = 10;
      this.rjButton1.BorderSize = 1;
      this.rjButton1.FlatAppearance.BorderSize = 0;
      this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.rjButton1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rjButton1.ForeColor = System.Drawing.Color.SlateGray;
      this.rjButton1.Image = ((System.Drawing.Image)(resources.GetObject("rjButton1.Image")));
      this.rjButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.rjButton1.Location = new System.Drawing.Point(129, 5);
      this.rjButton1.Margin = new System.Windows.Forms.Padding(2);
      this.rjButton1.Name = "rjButton1";
      this.rjButton1.Size = new System.Drawing.Size(143, 37);
      this.rjButton1.TabIndex = 3;
      this.rjButton1.Text = "Remove Account";
      this.rjButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.rjButton1.TextColor = System.Drawing.Color.SlateGray;
      this.rjButton1.UseVisualStyleBackColor = false;
      // 
      // UserAccounts
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(928, 421);
      this.Controls.Add(this.rjButton1);
      this.Controls.Add(this.addAccountButton);
      this.Controls.Add(this.AccountDataGridView);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "UserAccounts";
      this.Text = "UserAccounts";
      ((System.ComponentModel.ISupportInitialize)(this.AccountDataGridView)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private CustomControl.RJButton addAccountButton;
    private ComponentFactory.Krypton.Toolkit.KryptonDataGridView AccountDataGridView;
    private CustomControl.RJButton rjButton1;
    private System.Windows.Forms.DataGridViewTextBoxColumn AccountNameColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn AccountTypeColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn StartingAmountColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn BalanceColumn;
  }
}