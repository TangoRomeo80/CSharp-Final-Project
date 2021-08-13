
namespace WalletBuddy.Forms
{
  partial class UserPayments
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPayments));
      this.addPaymentButton = new WalletBuddy.CustomControl.RJButton();
      this.paymentDataGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
      this.PaymentNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.PaymentRecieverColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DueDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.paymentDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // addPaymentButton
      // 
      this.addPaymentButton.BackColor = System.Drawing.Color.White;
      this.addPaymentButton.BackgroundColor = System.Drawing.Color.White;
      this.addPaymentButton.BorderColor = System.Drawing.Color.Black;
      this.addPaymentButton.BorderRadius = 10;
      this.addPaymentButton.BorderSize = 1;
      this.addPaymentButton.FlatAppearance.BorderSize = 0;
      this.addPaymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.addPaymentButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.addPaymentButton.ForeColor = System.Drawing.Color.SlateGray;
      this.addPaymentButton.Image = ((System.Drawing.Image)(resources.GetObject("addPaymentButton.Image")));
      this.addPaymentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.addPaymentButton.Location = new System.Drawing.Point(13, 5);
      this.addPaymentButton.Margin = new System.Windows.Forms.Padding(2);
      this.addPaymentButton.Name = "addPaymentButton";
      this.addPaymentButton.Size = new System.Drawing.Size(126, 37);
      this.addPaymentButton.TabIndex = 5;
      this.addPaymentButton.Text = "Add Payment";
      this.addPaymentButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.addPaymentButton.TextColor = System.Drawing.Color.SlateGray;
      this.addPaymentButton.UseVisualStyleBackColor = false;
      this.addPaymentButton.Click += new System.EventHandler(this.addPaymentButton_Click);
      // 
      // paymentDataGridView
      // 
      this.paymentDataGridView.AllowUserToAddRows = false;
      this.paymentDataGridView.AllowUserToDeleteRows = false;
      this.paymentDataGridView.AllowUserToOrderColumns = true;
      this.paymentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.paymentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.paymentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PaymentNameColumn,
            this.PaymentRecieverColumn,
            this.DescriptionColumn,
            this.AmountColumn,
            this.DueDateColumn});
      this.paymentDataGridView.Location = new System.Drawing.Point(13, 47);
      this.paymentDataGridView.Name = "paymentDataGridView";
      this.paymentDataGridView.ReadOnly = true;
      this.paymentDataGridView.Size = new System.Drawing.Size(903, 369);
      this.paymentDataGridView.StateCommon.Background.Color1 = System.Drawing.Color.LightGray;
      this.paymentDataGridView.StateCommon.Background.Color2 = System.Drawing.Color.LightGray;
      this.paymentDataGridView.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
      this.paymentDataGridView.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.DarkGray;
      this.paymentDataGridView.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.DarkGray;
      this.paymentDataGridView.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.Gray;
      this.paymentDataGridView.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.Gray;
      this.paymentDataGridView.TabIndex = 4;
      // 
      // PaymentNameColumn
      // 
      this.PaymentNameColumn.HeaderText = "Payment Name";
      this.PaymentNameColumn.Name = "PaymentNameColumn";
      this.PaymentNameColumn.ReadOnly = true;
      // 
      // PaymentRecieverColumn
      // 
      this.PaymentRecieverColumn.HeaderText = "Payment Reciever";
      this.PaymentRecieverColumn.Name = "PaymentRecieverColumn";
      this.PaymentRecieverColumn.ReadOnly = true;
      // 
      // DescriptionColumn
      // 
      this.DescriptionColumn.HeaderText = "Description";
      this.DescriptionColumn.Name = "DescriptionColumn";
      this.DescriptionColumn.ReadOnly = true;
      // 
      // AmountColumn
      // 
      this.AmountColumn.HeaderText = "Amount";
      this.AmountColumn.Name = "AmountColumn";
      this.AmountColumn.ReadOnly = true;
      // 
      // DueDateColumn
      // 
      this.DueDateColumn.HeaderText = "Due Date";
      this.DueDateColumn.Name = "DueDateColumn";
      this.DueDateColumn.ReadOnly = true;
      // 
      // UserPayments
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(928, 421);
      this.Controls.Add(this.addPaymentButton);
      this.Controls.Add(this.paymentDataGridView);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "UserPayments";
      this.Text = "UserPayments";
      ((System.ComponentModel.ISupportInitialize)(this.paymentDataGridView)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    private CustomControl.RJButton addPaymentButton;
    private ComponentFactory.Krypton.Toolkit.KryptonDataGridView paymentDataGridView;
    private System.Windows.Forms.DataGridViewTextBoxColumn PaymentNameColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn PaymentRecieverColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn DueDateColumn;
  }
}