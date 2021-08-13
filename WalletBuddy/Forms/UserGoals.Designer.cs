
namespace WalletBuddy.Forms
{
  partial class UserGoals
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserGoals));
      this.addGoalButton = new WalletBuddy.CustomControl.RJButton();
      this.goalDataGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
      this.GoalDurationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.TargetSavingsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CurrentExpenseColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.RemainingIncomeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.goalDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // addGoalButton
      // 
      this.addGoalButton.BackColor = System.Drawing.Color.White;
      this.addGoalButton.BackgroundColor = System.Drawing.Color.White;
      this.addGoalButton.BorderColor = System.Drawing.Color.DodgerBlue;
      this.addGoalButton.BorderRadius = 10;
      this.addGoalButton.BorderSize = 1;
      this.addGoalButton.FlatAppearance.BorderSize = 0;
      this.addGoalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.addGoalButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.addGoalButton.ForeColor = System.Drawing.Color.SlateGray;
      this.addGoalButton.Image = ((System.Drawing.Image)(resources.GetObject("addGoalButton.Image")));
      this.addGoalButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.addGoalButton.Location = new System.Drawing.Point(13, 5);
      this.addGoalButton.Margin = new System.Windows.Forms.Padding(2);
      this.addGoalButton.Name = "addGoalButton";
      this.addGoalButton.Size = new System.Drawing.Size(126, 37);
      this.addGoalButton.TabIndex = 7;
      this.addGoalButton.Text = "Add New Goal";
      this.addGoalButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.addGoalButton.TextColor = System.Drawing.Color.SlateGray;
      this.addGoalButton.UseVisualStyleBackColor = false;
      this.addGoalButton.Click += new System.EventHandler(this.addGoalButton_Click);
      // 
      // goalDataGridView
      // 
      this.goalDataGridView.AllowUserToAddRows = false;
      this.goalDataGridView.AllowUserToDeleteRows = false;
      this.goalDataGridView.AllowUserToOrderColumns = true;
      this.goalDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.goalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.goalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GoalDurationColumn,
            this.TargetSavingsColumn,
            this.CurrentExpenseColumn,
            this.RemainingIncomeColumn});
      this.goalDataGridView.Location = new System.Drawing.Point(13, 47);
      this.goalDataGridView.Name = "goalDataGridView";
      this.goalDataGridView.ReadOnly = true;
      this.goalDataGridView.Size = new System.Drawing.Size(903, 369);
      this.goalDataGridView.StateCommon.Background.Color1 = System.Drawing.Color.LightSkyBlue;
      this.goalDataGridView.StateCommon.Background.Color2 = System.Drawing.Color.LightSkyBlue;
      this.goalDataGridView.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
      this.goalDataGridView.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.DodgerBlue;
      this.goalDataGridView.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.DodgerBlue;
      this.goalDataGridView.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.Blue;
      this.goalDataGridView.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.Blue;
      this.goalDataGridView.TabIndex = 6;
      // 
      // GoalDurationColumn
      // 
      this.GoalDurationColumn.HeaderText = "Goal Duration";
      this.GoalDurationColumn.Name = "GoalDurationColumn";
      this.GoalDurationColumn.ReadOnly = true;
      // 
      // TargetSavingsColumn
      // 
      this.TargetSavingsColumn.HeaderText = "Target Savings";
      this.TargetSavingsColumn.Name = "TargetSavingsColumn";
      this.TargetSavingsColumn.ReadOnly = true;
      // 
      // CurrentExpenseColumn
      // 
      this.CurrentExpenseColumn.HeaderText = "Current Expense";
      this.CurrentExpenseColumn.Name = "CurrentExpenseColumn";
      this.CurrentExpenseColumn.ReadOnly = true;
      // 
      // RemainingIncomeColumn
      // 
      this.RemainingIncomeColumn.HeaderText = "Remaining income to spend";
      this.RemainingIncomeColumn.Name = "RemainingIncomeColumn";
      this.RemainingIncomeColumn.ReadOnly = true;
      // 
      // UserGoals
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(928, 421);
      this.Controls.Add(this.addGoalButton);
      this.Controls.Add(this.goalDataGridView);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "UserGoals";
      this.Text = "UserGoals";
      ((System.ComponentModel.ISupportInitialize)(this.goalDataGridView)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private CustomControl.RJButton addGoalButton;
    private ComponentFactory.Krypton.Toolkit.KryptonDataGridView goalDataGridView;
    private System.Windows.Forms.DataGridViewTextBoxColumn GoalDurationColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn TargetSavingsColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn CurrentExpenseColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn RemainingIncomeColumn;
  }
}