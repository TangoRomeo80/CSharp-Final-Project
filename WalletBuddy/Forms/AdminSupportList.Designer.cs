
namespace WalletBuddy.Forms
{
  partial class AdminSupportList
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSupportList));
      this.completeButton = new WalletBuddy.CustomControl.RJButton();
      this.tokenDataGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
      this.TokenId = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.SenderNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.SenderEmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.tokenDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // completeButton
      // 
      this.completeButton.BackColor = System.Drawing.Color.White;
      this.completeButton.BackgroundColor = System.Drawing.Color.White;
      this.completeButton.BorderColor = System.Drawing.Color.Black;
      this.completeButton.BorderRadius = 10;
      this.completeButton.BorderSize = 1;
      this.completeButton.FlatAppearance.BorderSize = 0;
      this.completeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.completeButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.completeButton.ForeColor = System.Drawing.Color.SlateGray;
      this.completeButton.Image = ((System.Drawing.Image)(resources.GetObject("completeButton.Image")));
      this.completeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.completeButton.Location = new System.Drawing.Point(13, 5);
      this.completeButton.Margin = new System.Windows.Forms.Padding(2);
      this.completeButton.Name = "completeButton";
      this.completeButton.Size = new System.Drawing.Size(180, 37);
      this.completeButton.TabIndex = 5;
      this.completeButton.Text = "Set status to complete";
      this.completeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.completeButton.TextColor = System.Drawing.Color.SlateGray;
      this.completeButton.UseVisualStyleBackColor = false;
      this.completeButton.Click += new System.EventHandler(this.completeButton_Click);
      // 
      // tokenDataGridView
      // 
      this.tokenDataGridView.AllowUserToAddRows = false;
      this.tokenDataGridView.AllowUserToDeleteRows = false;
      this.tokenDataGridView.AllowUserToOrderColumns = true;
      this.tokenDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.tokenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.tokenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TokenId,
            this.SenderNameColumn,
            this.SenderEmailColumn,
            this.DescriptionColumn,
            this.StatusColumn});
      this.tokenDataGridView.Location = new System.Drawing.Point(13, 47);
      this.tokenDataGridView.Name = "tokenDataGridView";
      this.tokenDataGridView.ReadOnly = true;
      this.tokenDataGridView.Size = new System.Drawing.Size(903, 369);
      this.tokenDataGridView.StateCommon.Background.Color1 = System.Drawing.Color.LightGray;
      this.tokenDataGridView.StateCommon.Background.Color2 = System.Drawing.Color.LightGray;
      this.tokenDataGridView.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
      this.tokenDataGridView.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.DarkGray;
      this.tokenDataGridView.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.DarkGray;
      this.tokenDataGridView.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.Gray;
      this.tokenDataGridView.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.Gray;
      this.tokenDataGridView.TabIndex = 4;
      // 
      // TokenId
      // 
      this.TokenId.HeaderText = "Token Id";
      this.TokenId.Name = "TokenId";
      this.TokenId.ReadOnly = true;
      // 
      // SenderNameColumn
      // 
      this.SenderNameColumn.HeaderText = "Sender Name";
      this.SenderNameColumn.Name = "SenderNameColumn";
      this.SenderNameColumn.ReadOnly = true;
      // 
      // SenderEmailColumn
      // 
      this.SenderEmailColumn.HeaderText = "Sender E-mail";
      this.SenderEmailColumn.Name = "SenderEmailColumn";
      this.SenderEmailColumn.ReadOnly = true;
      // 
      // DescriptionColumn
      // 
      this.DescriptionColumn.HeaderText = "Description";
      this.DescriptionColumn.Name = "DescriptionColumn";
      this.DescriptionColumn.ReadOnly = true;
      // 
      // StatusColumn
      // 
      this.StatusColumn.HeaderText = "Status";
      this.StatusColumn.Name = "StatusColumn";
      this.StatusColumn.ReadOnly = true;
      // 
      // AdminSupportList
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(928, 421);
      this.Controls.Add(this.completeButton);
      this.Controls.Add(this.tokenDataGridView);
      this.Name = "AdminSupportList";
      this.Text = "AdminSupportList";
      ((System.ComponentModel.ISupportInitialize)(this.tokenDataGridView)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private CustomControl.RJButton completeButton;
    private ComponentFactory.Krypton.Toolkit.KryptonDataGridView tokenDataGridView;
    private System.Windows.Forms.DataGridViewTextBoxColumn TokenId;
    private System.Windows.Forms.DataGridViewTextBoxColumn SenderNameColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn SenderEmailColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
  }
}