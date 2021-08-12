
namespace WalletBuddy.Forms
{
  partial class UserRecords
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
      this.recordsDataGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
      this.recordWeeklyRadio = new System.Windows.Forms.RadioButton();
      this.recordMonthlyRadio = new System.Windows.Forms.RadioButton();
      this.recordYearlyRadio = new System.Windows.Forms.RadioButton();
      this.TransactionTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.recordsDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // recordsDataGridView
      // 
      this.recordsDataGridView.AllowUserToAddRows = false;
      this.recordsDataGridView.AllowUserToDeleteRows = false;
      this.recordsDataGridView.AllowUserToOrderColumns = true;
      this.recordsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.recordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.recordsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransactionTypeColumn,
            this.AmountColumn,
            this.DateColumn});
      this.recordsDataGridView.Location = new System.Drawing.Point(13, 47);
      this.recordsDataGridView.Name = "recordsDataGridView";
      this.recordsDataGridView.ReadOnly = true;
      this.recordsDataGridView.Size = new System.Drawing.Size(903, 369);
      this.recordsDataGridView.StateCommon.Background.Color1 = System.Drawing.Color.LightGray;
      this.recordsDataGridView.StateCommon.Background.Color2 = System.Drawing.Color.LightGray;
      this.recordsDataGridView.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
      this.recordsDataGridView.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.DarkGray;
      this.recordsDataGridView.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.DarkGray;
      this.recordsDataGridView.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.Gray;
      this.recordsDataGridView.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.Gray;
      this.recordsDataGridView.TabIndex = 4;
      // 
      // recordWeeklyRadio
      // 
      this.recordWeeklyRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.recordWeeklyRadio.AutoSize = true;
      this.recordWeeklyRadio.BackColor = System.Drawing.Color.Transparent;
      this.recordWeeklyRadio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.recordWeeklyRadio.ForeColor = System.Drawing.Color.Black;
      this.recordWeeklyRadio.Location = new System.Drawing.Point(13, 12);
      this.recordWeeklyRadio.Name = "recordWeeklyRadio";
      this.recordWeeklyRadio.Size = new System.Drawing.Size(74, 23);
      this.recordWeeklyRadio.TabIndex = 5;
      this.recordWeeklyRadio.TabStop = true;
      this.recordWeeklyRadio.Text = "Weekly";
      this.recordWeeklyRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.recordWeeklyRadio.UseVisualStyleBackColor = false;
      this.recordWeeklyRadio.CheckedChanged += new System.EventHandler(this.recordWeeklyRadio_CheckedChanged);
      // 
      // recordMonthlyRadio
      // 
      this.recordMonthlyRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.recordMonthlyRadio.AutoSize = true;
      this.recordMonthlyRadio.BackColor = System.Drawing.Color.Transparent;
      this.recordMonthlyRadio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.recordMonthlyRadio.ForeColor = System.Drawing.Color.Black;
      this.recordMonthlyRadio.Location = new System.Drawing.Point(110, 12);
      this.recordMonthlyRadio.Name = "recordMonthlyRadio";
      this.recordMonthlyRadio.Size = new System.Drawing.Size(80, 23);
      this.recordMonthlyRadio.TabIndex = 5;
      this.recordMonthlyRadio.TabStop = true;
      this.recordMonthlyRadio.Text = "Monthly";
      this.recordMonthlyRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.recordMonthlyRadio.UseVisualStyleBackColor = false;
      this.recordMonthlyRadio.CheckedChanged += new System.EventHandler(this.recordMonthlyRadio_CheckedChanged);
      // 
      // recordYearlyRadio
      // 
      this.recordYearlyRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.recordYearlyRadio.AutoSize = true;
      this.recordYearlyRadio.BackColor = System.Drawing.Color.Transparent;
      this.recordYearlyRadio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.recordYearlyRadio.ForeColor = System.Drawing.Color.Black;
      this.recordYearlyRadio.Location = new System.Drawing.Point(207, 12);
      this.recordYearlyRadio.Name = "recordYearlyRadio";
      this.recordYearlyRadio.Size = new System.Drawing.Size(66, 23);
      this.recordYearlyRadio.TabIndex = 5;
      this.recordYearlyRadio.TabStop = true;
      this.recordYearlyRadio.Text = "Yearly";
      this.recordYearlyRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.recordYearlyRadio.UseVisualStyleBackColor = false;
      this.recordYearlyRadio.CheckedChanged += new System.EventHandler(this.recordYearlyRadio_CheckedChanged);
      // 
      // TransactionTypeColumn
      // 
      this.TransactionTypeColumn.HeaderText = "Transaction Type";
      this.TransactionTypeColumn.Name = "TransactionTypeColumn";
      this.TransactionTypeColumn.ReadOnly = true;
      // 
      // AmountColumn
      // 
      this.AmountColumn.HeaderText = "Amount";
      this.AmountColumn.Name = "AmountColumn";
      this.AmountColumn.ReadOnly = true;
      // 
      // DateColumn
      // 
      this.DateColumn.HeaderText = "Date";
      this.DateColumn.Name = "DateColumn";
      this.DateColumn.ReadOnly = true;
      // 
      // UserRecords
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(928, 421);
      this.Controls.Add(this.recordYearlyRadio);
      this.Controls.Add(this.recordMonthlyRadio);
      this.Controls.Add(this.recordWeeklyRadio);
      this.Controls.Add(this.recordsDataGridView);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "UserRecords";
      this.Text = "UserRecords";
      ((System.ComponentModel.ISupportInitialize)(this.recordsDataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private ComponentFactory.Krypton.Toolkit.KryptonDataGridView recordsDataGridView;
    private System.Windows.Forms.RadioButton recordWeeklyRadio;
    private System.Windows.Forms.RadioButton recordMonthlyRadio;
    private System.Windows.Forms.RadioButton recordYearlyRadio;
    private System.Windows.Forms.DataGridViewTextBoxColumn TransactionTypeColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
  }
}