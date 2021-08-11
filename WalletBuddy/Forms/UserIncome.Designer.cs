
namespace WalletBuddy.Forms
{
  partial class UserIncome
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserIncome));
      this.incomeDataGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
      this.TransactionIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.PaymentFromColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.AccountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.addIncomeButton = new WalletBuddy.CustomControl.RJButton();
      this.iNCOMETBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.incomeDataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.iNCOMETBLBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // incomeDataGridView
      // 
      this.incomeDataGridView.AllowUserToOrderColumns = true;
      this.incomeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.incomeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.incomeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransactionIdColumn,
            this.PaymentFromColumn,
            this.DescriptionColumn,
            this.AccountColumn,
            this.AmountColumn,
            this.DateColumn});
      this.incomeDataGridView.Location = new System.Drawing.Point(17, 60);
      this.incomeDataGridView.Margin = new System.Windows.Forms.Padding(4);
      this.incomeDataGridView.Name = "incomeDataGridView";
      this.incomeDataGridView.RowHeadersWidth = 51;
      this.incomeDataGridView.Size = new System.Drawing.Size(1204, 454);
      this.incomeDataGridView.StateCommon.Background.Color1 = System.Drawing.Color.PaleGreen;
      this.incomeDataGridView.StateCommon.Background.Color2 = System.Drawing.Color.PaleGreen;
      this.incomeDataGridView.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
      this.incomeDataGridView.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
      this.incomeDataGridView.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
      this.incomeDataGridView.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.Green;
      this.incomeDataGridView.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.Green;
      this.incomeDataGridView.TabIndex = 0;
      // 
      // TransactionIdColumn
      // 
      this.TransactionIdColumn.HeaderText = "Transaction ID";
      this.TransactionIdColumn.MinimumWidth = 6;
      this.TransactionIdColumn.Name = "TransactionIdColumn";
      // 
      // PaymentFromColumn
      // 
      this.PaymentFromColumn.HeaderText = "Payment From";
      this.PaymentFromColumn.MinimumWidth = 6;
      this.PaymentFromColumn.Name = "PaymentFromColumn";
      // 
      // DescriptionColumn
      // 
      this.DescriptionColumn.HeaderText = "Description";
      this.DescriptionColumn.MinimumWidth = 6;
      this.DescriptionColumn.Name = "DescriptionColumn";
      // 
      // AccountColumn
      // 
      this.AccountColumn.HeaderText = "Account";
      this.AccountColumn.MinimumWidth = 6;
      this.AccountColumn.Name = "AccountColumn";
      // 
      // AmountColumn
      // 
      this.AmountColumn.HeaderText = "Amount";
      this.AmountColumn.MinimumWidth = 6;
      this.AmountColumn.Name = "AmountColumn";
      // 
      // DateColumn
      // 
      this.DateColumn.HeaderText = "Date";
      this.DateColumn.MinimumWidth = 6;
      this.DateColumn.Name = "DateColumn";
      // 
      // addIncomeButton
      // 
      this.addIncomeButton.BackColor = System.Drawing.Color.White;
      this.addIncomeButton.BackgroundColor = System.Drawing.Color.White;
      this.addIncomeButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
      this.addIncomeButton.BorderRadius = 10;
      this.addIncomeButton.BorderSize = 1;
      this.addIncomeButton.FlatAppearance.BorderSize = 0;
      this.addIncomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.addIncomeButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.addIncomeButton.ForeColor = System.Drawing.Color.SlateGray;
      this.addIncomeButton.Image = ((System.Drawing.Image)(resources.GetObject("addIncomeButton.Image")));
      this.addIncomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.addIncomeButton.Location = new System.Drawing.Point(17, 9);
      this.addIncomeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.addIncomeButton.Name = "addIncomeButton";
      this.addIncomeButton.Size = new System.Drawing.Size(149, 46);
      this.addIncomeButton.TabIndex = 1;
      this.addIncomeButton.Text = "Add Income";
      this.addIncomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.addIncomeButton.TextColor = System.Drawing.Color.SlateGray;
      this.addIncomeButton.UseVisualStyleBackColor = false;
      this.addIncomeButton.Click += new System.EventHandler(this.addIncomeButton_Click);
      // 
      // UserIncome
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1237, 518);
      this.Controls.Add(this.addIncomeButton);
      this.Controls.Add(this.incomeDataGridView);
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "UserIncome";
      this.Text = "UserIncome";
      ((System.ComponentModel.ISupportInitialize)(this.incomeDataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.iNCOMETBLBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private ComponentFactory.Krypton.Toolkit.KryptonDataGridView incomeDataGridView;
    private System.Windows.Forms.DataGridViewTextBoxColumn TransactionIdColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn PaymentFromColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn AccountColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
    private CustomControl.RJButton addIncomeButton;
    private System.Windows.Forms.BindingSource iNCOMETBLBindingSource;
  }
}