
namespace WalletBuddy.Forms
{
  partial class UserExpense
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserExpense));
      this.expenseDataGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
      this.TransactionIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.PaymentToColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.AccountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.addExpenseButton = new WalletBuddy.CustomControl.RJButton();
      ((System.ComponentModel.ISupportInitialize)(this.expenseDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // expenseDataGridView
      // 
      this.expenseDataGridView.AllowUserToOrderColumns = true;
      this.expenseDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.expenseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.expenseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransactionIdColumn,
            this.PaymentToColumn,
            this.DescriptionColumn,
            this.AccountColumn,
            this.AmountColumn,
            this.DateColumn});
      this.expenseDataGridView.Location = new System.Drawing.Point(13, 49);
      this.expenseDataGridView.Name = "expenseDataGridView";
      this.expenseDataGridView.Size = new System.Drawing.Size(903, 369);
      this.expenseDataGridView.StateCommon.Background.Color1 = System.Drawing.Color.LightPink;
      this.expenseDataGridView.StateCommon.Background.Color2 = System.Drawing.Color.LightPink;
      this.expenseDataGridView.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
      this.expenseDataGridView.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.OrangeRed;
      this.expenseDataGridView.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.OrangeRed;
      this.expenseDataGridView.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.Crimson;
      this.expenseDataGridView.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.Crimson;
      this.expenseDataGridView.TabIndex = 0;
      // 
      // TransactionIdColumn
      // 
      this.TransactionIdColumn.HeaderText = "Transaction ID";
      this.TransactionIdColumn.Name = "TransactionIdColumn";
      // 
      // PaymentToColumn
      // 
      this.PaymentToColumn.HeaderText = "Payment To";
      this.PaymentToColumn.Name = "PaymentToColumn";
      // 
      // DescriptionColumn
      // 
      this.DescriptionColumn.HeaderText = "Description";
      this.DescriptionColumn.Name = "DescriptionColumn";
      // 
      // AccountColumn
      // 
      this.AccountColumn.HeaderText = "Account";
      this.AccountColumn.Name = "AccountColumn";
      // 
      // AmountColumn
      // 
      this.AmountColumn.HeaderText = "Amount";
      this.AmountColumn.Name = "AmountColumn";
      // 
      // DateColumn
      // 
      this.DateColumn.HeaderText = "Date";
      this.DateColumn.Name = "DateColumn";
      // 
      // addExpenseButton
      // 
      this.addExpenseButton.BackColor = System.Drawing.Color.White;
      this.addExpenseButton.BackgroundColor = System.Drawing.Color.White;
      this.addExpenseButton.BorderColor = System.Drawing.Color.Red;
      this.addExpenseButton.BorderRadius = 10;
      this.addExpenseButton.BorderSize = 1;
      this.addExpenseButton.FlatAppearance.BorderSize = 0;
      this.addExpenseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.addExpenseButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.addExpenseButton.ForeColor = System.Drawing.Color.SlateGray;
      this.addExpenseButton.Image = ((System.Drawing.Image)(resources.GetObject("addExpenseButton.Image")));
      this.addExpenseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.addExpenseButton.Location = new System.Drawing.Point(13, 7);
      this.addExpenseButton.Margin = new System.Windows.Forms.Padding(2);
      this.addExpenseButton.Name = "addExpenseButton";
      this.addExpenseButton.Size = new System.Drawing.Size(112, 37);
      this.addExpenseButton.TabIndex = 1;
      this.addExpenseButton.Text = "Add Expense";
      this.addExpenseButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.addExpenseButton.TextColor = System.Drawing.Color.SlateGray;
      this.addExpenseButton.UseVisualStyleBackColor = false;
      this.addExpenseButton.Click += new System.EventHandler(this.addExpenseButton_Click);
      // 
      // UserExpense
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(928, 421);
      this.Controls.Add(this.addExpenseButton);
      this.Controls.Add(this.expenseDataGridView);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "UserExpense";
      this.Text = "UserExpense";
      ((System.ComponentModel.ISupportInitialize)(this.expenseDataGridView)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private ComponentFactory.Krypton.Toolkit.KryptonDataGridView expenseDataGridView;
    private CustomControl.RJButton addExpenseButton;
    private System.Windows.Forms.DataGridViewTextBoxColumn TransactionIdColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn PaymentToColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn AccountColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
  }
}