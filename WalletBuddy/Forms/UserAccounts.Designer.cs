
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
      this.removeAccountButton = new WalletBuddy.CustomControl.RJButton();
      this.transferBudgetButton = new WalletBuddy.CustomControl.RJButton();
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
      // removeAccountButton
      // 
      this.removeAccountButton.BackColor = System.Drawing.Color.White;
      this.removeAccountButton.BackgroundColor = System.Drawing.Color.White;
      this.removeAccountButton.BorderColor = System.Drawing.Color.Black;
      this.removeAccountButton.BorderRadius = 10;
      this.removeAccountButton.BorderSize = 1;
      this.removeAccountButton.FlatAppearance.BorderSize = 0;
      this.removeAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.removeAccountButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.removeAccountButton.ForeColor = System.Drawing.Color.SlateGray;
      this.removeAccountButton.Image = ((System.Drawing.Image)(resources.GetObject("removeAccountButton.Image")));
      this.removeAccountButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.removeAccountButton.Location = new System.Drawing.Point(129, 5);
      this.removeAccountButton.Margin = new System.Windows.Forms.Padding(2);
      this.removeAccountButton.Name = "removeAccountButton";
      this.removeAccountButton.Size = new System.Drawing.Size(143, 37);
      this.removeAccountButton.TabIndex = 3;
      this.removeAccountButton.Text = "Remove Account";
      this.removeAccountButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.removeAccountButton.TextColor = System.Drawing.Color.SlateGray;
      this.removeAccountButton.UseVisualStyleBackColor = false;
      // 
      // transferBudgetButton
      // 
      this.transferBudgetButton.BackColor = System.Drawing.Color.White;
      this.transferBudgetButton.BackgroundColor = System.Drawing.Color.White;
      this.transferBudgetButton.BorderColor = System.Drawing.Color.Black;
      this.transferBudgetButton.BorderRadius = 10;
      this.transferBudgetButton.BorderSize = 1;
      this.transferBudgetButton.FlatAppearance.BorderSize = 0;
      this.transferBudgetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.transferBudgetButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.transferBudgetButton.ForeColor = System.Drawing.Color.SlateGray;
      this.transferBudgetButton.Image = ((System.Drawing.Image)(resources.GetObject("transferBudgetButton.Image")));
      this.transferBudgetButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.transferBudgetButton.Location = new System.Drawing.Point(276, 5);
      this.transferBudgetButton.Margin = new System.Windows.Forms.Padding(2);
      this.transferBudgetButton.Name = "transferBudgetButton";
      this.transferBudgetButton.Size = new System.Drawing.Size(143, 37);
      this.transferBudgetButton.TabIndex = 3;
      this.transferBudgetButton.Text = "Transfer Budget";
      this.transferBudgetButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.transferBudgetButton.TextColor = System.Drawing.Color.SlateGray;
      this.transferBudgetButton.UseVisualStyleBackColor = false;
      // 
      // UserAccounts
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(928, 421);
      this.Controls.Add(this.transferBudgetButton);
      this.Controls.Add(this.removeAccountButton);
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
    private CustomControl.RJButton removeAccountButton;
    private System.Windows.Forms.DataGridViewTextBoxColumn AccountNameColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn AccountTypeColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn StartingAmountColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn BalanceColumn;
    private CustomControl.RJButton transferBudgetButton;
  }
}