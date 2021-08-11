
namespace WalletBuddy.Forms
{
  partial class UserDash
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
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDash));
      this.incomeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.expenseCategoryChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.expenseChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.incomeWeeklyRadio = new System.Windows.Forms.RadioButton();
      this.expenseWeeklyRadio = new System.Windows.Forms.RadioButton();
      this.expenseTypeWeeklyRadio = new System.Windows.Forms.RadioButton();
      this.incomeMonthlyRadio = new System.Windows.Forms.RadioButton();
      this.incomeYearlyRadio = new System.Windows.Forms.RadioButton();
      this.expenseMonthlyRadio = new System.Windows.Forms.RadioButton();
      this.expenseYearlyRadio = new System.Windows.Forms.RadioButton();
      this.expenseTypeMonthlyRadio = new System.Windows.Forms.RadioButton();
      this.expenseTypeYearlyRadio = new System.Windows.Forms.RadioButton();
      this.overviewPanel = new System.Windows.Forms.Panel();
      this.balanceOverviewLabel = new System.Windows.Forms.Label();
      this.expenseOverviewLabel = new System.Windows.Forms.Label();
      this.balanceLabel = new System.Windows.Forms.Label();
      this.expenselabel = new System.Windows.Forms.Label();
      this.incomeLabel = new System.Windows.Forms.Label();
      this.incomeOverviewLabel = new System.Windows.Forms.Label();
      this.balanceOverviewIcon = new System.Windows.Forms.PictureBox();
      this.ExpenseOverviewIcon = new System.Windows.Forms.PictureBox();
      this.incomeOverviewIcon = new System.Windows.Forms.PictureBox();
      this.overviewLabel = new System.Windows.Forms.Label();
      this.weeklyOverviewRadio = new System.Windows.Forms.RadioButton();
      this.monthlyOverviewRadio = new System.Windows.Forms.RadioButton();
      this.yearlyOverviewRadio = new System.Windows.Forms.RadioButton();
      this.panel1 = new System.Windows.Forms.Panel();
      this.expenseTrendPanel = new System.Windows.Forms.Panel();
      this.expenseByCategoryPanel = new System.Windows.Forms.Panel();
      ((System.ComponentModel.ISupportInitialize)(this.incomeChart)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.expenseCategoryChart)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.expenseChart)).BeginInit();
      this.overviewPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.balanceOverviewIcon)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ExpenseOverviewIcon)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.incomeOverviewIcon)).BeginInit();
      this.panel1.SuspendLayout();
      this.expenseTrendPanel.SuspendLayout();
      this.expenseByCategoryPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // incomeChart
      // 
      chartArea1.Name = "ChartArea1";
      this.incomeChart.ChartAreas.Add(chartArea1);
      legend1.Name = "Legend1";
      this.incomeChart.Legends.Add(legend1);
      this.incomeChart.Location = new System.Drawing.Point(0, 0);
      this.incomeChart.Name = "incomeChart";
      this.incomeChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
      series1.ChartArea = "ChartArea1";
      series1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      series1.Legend = "Legend1";
      series1.Name = "Income trend";
      this.incomeChart.Series.Add(series1);
      this.incomeChart.Size = new System.Drawing.Size(441, 191);
      this.incomeChart.TabIndex = 0;
      this.incomeChart.Text = "Income";
      // 
      // expenseCategoryChart
      // 
      this.expenseCategoryChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      chartArea2.Name = "ChartArea1";
      this.expenseCategoryChart.ChartAreas.Add(chartArea2);
      legend2.Name = "Legend1";
      this.expenseCategoryChart.Legends.Add(legend2);
      this.expenseCategoryChart.Location = new System.Drawing.Point(0, 0);
      this.expenseCategoryChart.Name = "expenseCategoryChart";
      this.expenseCategoryChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
      series2.ChartArea = "ChartArea1";
      series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
      series2.Legend = "Legend1";
      series2.Name = "Expense by category";
      this.expenseCategoryChart.Series.Add(series2);
      this.expenseCategoryChart.Size = new System.Drawing.Size(441, 191);
      this.expenseCategoryChart.TabIndex = 1;
      this.expenseCategoryChart.Text = "Expense Category";
      // 
      // expenseChart
      // 
      this.expenseChart.Anchor = System.Windows.Forms.AnchorStyles.Right;
      chartArea3.Name = "ChartArea1";
      this.expenseChart.ChartAreas.Add(chartArea3);
      legend3.Name = "Legend1";
      this.expenseChart.Legends.Add(legend3);
      this.expenseChart.Location = new System.Drawing.Point(0, 0);
      this.expenseChart.Name = "expenseChart";
      this.expenseChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
      series3.ChartArea = "ChartArea1";
      series3.Legend = "Legend1";
      series3.Name = "Expense trend";
      this.expenseChart.Series.Add(series3);
      this.expenseChart.Size = new System.Drawing.Size(441, 191);
      this.expenseChart.TabIndex = 0;
      this.expenseChart.Text = "Expense";
      // 
      // incomeWeeklyRadio
      // 
      this.incomeWeeklyRadio.AutoSize = true;
      this.incomeWeeklyRadio.BackColor = System.Drawing.Color.Transparent;
      this.incomeWeeklyRadio.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.incomeWeeklyRadio.ForeColor = System.Drawing.Color.Black;
      this.incomeWeeklyRadio.Location = new System.Drawing.Point(321, 56);
      this.incomeWeeklyRadio.Name = "incomeWeeklyRadio";
      this.incomeWeeklyRadio.Size = new System.Drawing.Size(81, 25);
      this.incomeWeeklyRadio.TabIndex = 2;
      this.incomeWeeklyRadio.TabStop = true;
      this.incomeWeeklyRadio.Text = "Weekly";
      this.incomeWeeklyRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.incomeWeeklyRadio.UseVisualStyleBackColor = false;
      // 
      // expenseWeeklyRadio
      // 
      this.expenseWeeklyRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.expenseWeeklyRadio.AutoSize = true;
      this.expenseWeeklyRadio.BackColor = System.Drawing.Color.Transparent;
      this.expenseWeeklyRadio.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.expenseWeeklyRadio.ForeColor = System.Drawing.Color.Black;
      this.expenseWeeklyRadio.Location = new System.Drawing.Point(296, 56);
      this.expenseWeeklyRadio.Name = "expenseWeeklyRadio";
      this.expenseWeeklyRadio.Size = new System.Drawing.Size(81, 25);
      this.expenseWeeklyRadio.TabIndex = 2;
      this.expenseWeeklyRadio.TabStop = true;
      this.expenseWeeklyRadio.Text = "Weekly";
      this.expenseWeeklyRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.expenseWeeklyRadio.UseVisualStyleBackColor = false;
      // 
      // expenseTypeWeeklyRadio
      // 
      this.expenseTypeWeeklyRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.expenseTypeWeeklyRadio.AutoSize = true;
      this.expenseTypeWeeklyRadio.BackColor = System.Drawing.Color.Transparent;
      this.expenseTypeWeeklyRadio.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.expenseTypeWeeklyRadio.ForeColor = System.Drawing.Color.Black;
      this.expenseTypeWeeklyRadio.Location = new System.Drawing.Point(321, 99);
      this.expenseTypeWeeklyRadio.Name = "expenseTypeWeeklyRadio";
      this.expenseTypeWeeklyRadio.Size = new System.Drawing.Size(81, 25);
      this.expenseTypeWeeklyRadio.TabIndex = 2;
      this.expenseTypeWeeklyRadio.TabStop = true;
      this.expenseTypeWeeklyRadio.Text = "Weekly";
      this.expenseTypeWeeklyRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.expenseTypeWeeklyRadio.UseVisualStyleBackColor = false;
      // 
      // incomeMonthlyRadio
      // 
      this.incomeMonthlyRadio.AutoSize = true;
      this.incomeMonthlyRadio.BackColor = System.Drawing.Color.Transparent;
      this.incomeMonthlyRadio.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.incomeMonthlyRadio.ForeColor = System.Drawing.Color.Black;
      this.incomeMonthlyRadio.Location = new System.Drawing.Point(321, 79);
      this.incomeMonthlyRadio.Name = "incomeMonthlyRadio";
      this.incomeMonthlyRadio.Size = new System.Drawing.Size(91, 25);
      this.incomeMonthlyRadio.TabIndex = 2;
      this.incomeMonthlyRadio.TabStop = true;
      this.incomeMonthlyRadio.Text = "Monthly";
      this.incomeMonthlyRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.incomeMonthlyRadio.UseVisualStyleBackColor = false;
      // 
      // incomeYearlyRadio
      // 
      this.incomeYearlyRadio.AutoSize = true;
      this.incomeYearlyRadio.BackColor = System.Drawing.Color.Transparent;
      this.incomeYearlyRadio.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.incomeYearlyRadio.ForeColor = System.Drawing.Color.Black;
      this.incomeYearlyRadio.Location = new System.Drawing.Point(321, 102);
      this.incomeYearlyRadio.Name = "incomeYearlyRadio";
      this.incomeYearlyRadio.Size = new System.Drawing.Size(72, 25);
      this.incomeYearlyRadio.TabIndex = 2;
      this.incomeYearlyRadio.TabStop = true;
      this.incomeYearlyRadio.Text = "Yearly";
      this.incomeYearlyRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.incomeYearlyRadio.UseVisualStyleBackColor = false;
      // 
      // expenseMonthlyRadio
      // 
      this.expenseMonthlyRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.expenseMonthlyRadio.AutoSize = true;
      this.expenseMonthlyRadio.BackColor = System.Drawing.Color.Transparent;
      this.expenseMonthlyRadio.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.expenseMonthlyRadio.ForeColor = System.Drawing.Color.Black;
      this.expenseMonthlyRadio.Location = new System.Drawing.Point(292, 79);
      this.expenseMonthlyRadio.Name = "expenseMonthlyRadio";
      this.expenseMonthlyRadio.Size = new System.Drawing.Size(91, 25);
      this.expenseMonthlyRadio.TabIndex = 2;
      this.expenseMonthlyRadio.TabStop = true;
      this.expenseMonthlyRadio.Text = "Monthly";
      this.expenseMonthlyRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.expenseMonthlyRadio.UseVisualStyleBackColor = false;
      // 
      // expenseYearlyRadio
      // 
      this.expenseYearlyRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.expenseYearlyRadio.AutoSize = true;
      this.expenseYearlyRadio.BackColor = System.Drawing.Color.Transparent;
      this.expenseYearlyRadio.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.expenseYearlyRadio.ForeColor = System.Drawing.Color.Black;
      this.expenseYearlyRadio.Location = new System.Drawing.Point(297, 102);
      this.expenseYearlyRadio.Name = "expenseYearlyRadio";
      this.expenseYearlyRadio.Size = new System.Drawing.Size(72, 25);
      this.expenseYearlyRadio.TabIndex = 2;
      this.expenseYearlyRadio.TabStop = true;
      this.expenseYearlyRadio.Text = "Yearly";
      this.expenseYearlyRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.expenseYearlyRadio.UseVisualStyleBackColor = false;
      // 
      // expenseTypeMonthlyRadio
      // 
      this.expenseTypeMonthlyRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.expenseTypeMonthlyRadio.AutoSize = true;
      this.expenseTypeMonthlyRadio.BackColor = System.Drawing.Color.Transparent;
      this.expenseTypeMonthlyRadio.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.expenseTypeMonthlyRadio.ForeColor = System.Drawing.Color.Black;
      this.expenseTypeMonthlyRadio.Location = new System.Drawing.Point(320, 122);
      this.expenseTypeMonthlyRadio.Name = "expenseTypeMonthlyRadio";
      this.expenseTypeMonthlyRadio.Size = new System.Drawing.Size(91, 25);
      this.expenseTypeMonthlyRadio.TabIndex = 2;
      this.expenseTypeMonthlyRadio.TabStop = true;
      this.expenseTypeMonthlyRadio.Text = "Monthly";
      this.expenseTypeMonthlyRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.expenseTypeMonthlyRadio.UseVisualStyleBackColor = false;
      // 
      // expenseTypeYearlyRadio
      // 
      this.expenseTypeYearlyRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.expenseTypeYearlyRadio.AutoSize = true;
      this.expenseTypeYearlyRadio.BackColor = System.Drawing.Color.Transparent;
      this.expenseTypeYearlyRadio.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.expenseTypeYearlyRadio.ForeColor = System.Drawing.Color.Black;
      this.expenseTypeYearlyRadio.Location = new System.Drawing.Point(321, 145);
      this.expenseTypeYearlyRadio.Name = "expenseTypeYearlyRadio";
      this.expenseTypeYearlyRadio.Size = new System.Drawing.Size(72, 25);
      this.expenseTypeYearlyRadio.TabIndex = 2;
      this.expenseTypeYearlyRadio.TabStop = true;
      this.expenseTypeYearlyRadio.Text = "Yearly";
      this.expenseTypeYearlyRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.expenseTypeYearlyRadio.UseVisualStyleBackColor = false;
      // 
      // overviewPanel
      // 
      this.overviewPanel.BackColor = System.Drawing.Color.White;
      this.overviewPanel.Controls.Add(this.balanceOverviewLabel);
      this.overviewPanel.Controls.Add(this.expenseOverviewLabel);
      this.overviewPanel.Controls.Add(this.balanceLabel);
      this.overviewPanel.Controls.Add(this.expenselabel);
      this.overviewPanel.Controls.Add(this.incomeLabel);
      this.overviewPanel.Controls.Add(this.incomeOverviewLabel);
      this.overviewPanel.Controls.Add(this.balanceOverviewIcon);
      this.overviewPanel.Controls.Add(this.ExpenseOverviewIcon);
      this.overviewPanel.Controls.Add(this.incomeOverviewIcon);
      this.overviewPanel.Controls.Add(this.overviewLabel);
      this.overviewPanel.Controls.Add(this.weeklyOverviewRadio);
      this.overviewPanel.Controls.Add(this.monthlyOverviewRadio);
      this.overviewPanel.Controls.Add(this.yearlyOverviewRadio);
      this.overviewPanel.Location = new System.Drawing.Point(475, 218);
      this.overviewPanel.Name = "overviewPanel";
      this.overviewPanel.Size = new System.Drawing.Size(441, 191);
      this.overviewPanel.TabIndex = 3;
      // 
      // balanceOverviewLabel
      // 
      this.balanceOverviewLabel.AutoSize = true;
      this.balanceOverviewLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.balanceOverviewLabel.Location = new System.Drawing.Point(60, 147);
      this.balanceOverviewLabel.Name = "balanceOverviewLabel";
      this.balanceOverviewLabel.Size = new System.Drawing.Size(201, 29);
      this.balanceOverviewLabel.TabIndex = 6;
      this.balanceOverviewLabel.Text = "Remaining Balance";
      // 
      // expenseOverviewLabel
      // 
      this.expenseOverviewLabel.AutoSize = true;
      this.expenseOverviewLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.expenseOverviewLabel.Location = new System.Drawing.Point(60, 101);
      this.expenseOverviewLabel.Name = "expenseOverviewLabel";
      this.expenseOverviewLabel.Size = new System.Drawing.Size(148, 29);
      this.expenseOverviewLabel.TabIndex = 5;
      this.expenseOverviewLabel.Text = "Total expense";
      // 
      // balanceLabel
      // 
      this.balanceLabel.AutoSize = true;
      this.balanceLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.balanceLabel.Location = new System.Drawing.Point(252, 147);
      this.balanceLabel.Name = "balanceLabel";
      this.balanceLabel.Size = new System.Drawing.Size(49, 29);
      this.balanceLabel.TabIndex = 4;
      this.balanceLabel.Text = "000";
      // 
      // expenselabel
      // 
      this.expenselabel.AutoSize = true;
      this.expenselabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.expenselabel.Location = new System.Drawing.Point(252, 101);
      this.expenselabel.Name = "expenselabel";
      this.expenselabel.Size = new System.Drawing.Size(49, 29);
      this.expenselabel.TabIndex = 4;
      this.expenselabel.Text = "000";
      // 
      // incomeLabel
      // 
      this.incomeLabel.AutoSize = true;
      this.incomeLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.incomeLabel.Location = new System.Drawing.Point(252, 59);
      this.incomeLabel.Name = "incomeLabel";
      this.incomeLabel.Size = new System.Drawing.Size(49, 29);
      this.incomeLabel.TabIndex = 4;
      this.incomeLabel.Text = "000";
      // 
      // incomeOverviewLabel
      // 
      this.incomeOverviewLabel.AutoSize = true;
      this.incomeOverviewLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.incomeOverviewLabel.Location = new System.Drawing.Point(59, 59);
      this.incomeOverviewLabel.Name = "incomeOverviewLabel";
      this.incomeOverviewLabel.Size = new System.Drawing.Size(140, 29);
      this.incomeOverviewLabel.TabIndex = 4;
      this.incomeOverviewLabel.Text = "Total income";
      // 
      // balanceOverviewIcon
      // 
      this.balanceOverviewIcon.Image = ((System.Drawing.Image)(resources.GetObject("balanceOverviewIcon.Image")));
      this.balanceOverviewIcon.Location = new System.Drawing.Point(18, 147);
      this.balanceOverviewIcon.Name = "balanceOverviewIcon";
      this.balanceOverviewIcon.Size = new System.Drawing.Size(32, 32);
      this.balanceOverviewIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.balanceOverviewIcon.TabIndex = 3;
      this.balanceOverviewIcon.TabStop = false;
      // 
      // ExpenseOverviewIcon
      // 
      this.ExpenseOverviewIcon.Image = ((System.Drawing.Image)(resources.GetObject("ExpenseOverviewIcon.Image")));
      this.ExpenseOverviewIcon.Location = new System.Drawing.Point(18, 101);
      this.ExpenseOverviewIcon.Name = "ExpenseOverviewIcon";
      this.ExpenseOverviewIcon.Size = new System.Drawing.Size(32, 32);
      this.ExpenseOverviewIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.ExpenseOverviewIcon.TabIndex = 3;
      this.ExpenseOverviewIcon.TabStop = false;
      // 
      // incomeOverviewIcon
      // 
      this.incomeOverviewIcon.Image = ((System.Drawing.Image)(resources.GetObject("incomeOverviewIcon.Image")));
      this.incomeOverviewIcon.Location = new System.Drawing.Point(18, 59);
      this.incomeOverviewIcon.Name = "incomeOverviewIcon";
      this.incomeOverviewIcon.Size = new System.Drawing.Size(32, 32);
      this.incomeOverviewIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.incomeOverviewIcon.TabIndex = 3;
      this.incomeOverviewIcon.TabStop = false;
      // 
      // overviewLabel
      // 
      this.overviewLabel.AutoSize = true;
      this.overviewLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.overviewLabel.Location = new System.Drawing.Point(186, 0);
      this.overviewLabel.Name = "overviewLabel";
      this.overviewLabel.Size = new System.Drawing.Size(117, 33);
      this.overviewLabel.TabIndex = 0;
      this.overviewLabel.Text = "Overview";
      // 
      // weeklyOverviewRadio
      // 
      this.weeklyOverviewRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.weeklyOverviewRadio.AutoSize = true;
      this.weeklyOverviewRadio.BackColor = System.Drawing.Color.Transparent;
      this.weeklyOverviewRadio.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.weeklyOverviewRadio.ForeColor = System.Drawing.Color.Black;
      this.weeklyOverviewRadio.Location = new System.Drawing.Point(18, 28);
      this.weeklyOverviewRadio.Name = "weeklyOverviewRadio";
      this.weeklyOverviewRadio.Size = new System.Drawing.Size(81, 25);
      this.weeklyOverviewRadio.TabIndex = 2;
      this.weeklyOverviewRadio.TabStop = true;
      this.weeklyOverviewRadio.Text = "Weekly";
      this.weeklyOverviewRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.weeklyOverviewRadio.UseVisualStyleBackColor = false;
      // 
      // monthlyOverviewRadio
      // 
      this.monthlyOverviewRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.monthlyOverviewRadio.AutoSize = true;
      this.monthlyOverviewRadio.BackColor = System.Drawing.Color.Transparent;
      this.monthlyOverviewRadio.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.monthlyOverviewRadio.ForeColor = System.Drawing.Color.Black;
      this.monthlyOverviewRadio.Location = new System.Drawing.Point(109, 28);
      this.monthlyOverviewRadio.Name = "monthlyOverviewRadio";
      this.monthlyOverviewRadio.Size = new System.Drawing.Size(91, 25);
      this.monthlyOverviewRadio.TabIndex = 2;
      this.monthlyOverviewRadio.TabStop = true;
      this.monthlyOverviewRadio.Text = "Monthly";
      this.monthlyOverviewRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.monthlyOverviewRadio.UseVisualStyleBackColor = false;
      // 
      // yearlyOverviewRadio
      // 
      this.yearlyOverviewRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.yearlyOverviewRadio.AutoSize = true;
      this.yearlyOverviewRadio.BackColor = System.Drawing.Color.Transparent;
      this.yearlyOverviewRadio.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.yearlyOverviewRadio.ForeColor = System.Drawing.Color.Black;
      this.yearlyOverviewRadio.Location = new System.Drawing.Point(208, 28);
      this.yearlyOverviewRadio.Name = "yearlyOverviewRadio";
      this.yearlyOverviewRadio.Size = new System.Drawing.Size(72, 25);
      this.yearlyOverviewRadio.TabIndex = 2;
      this.yearlyOverviewRadio.TabStop = true;
      this.yearlyOverviewRadio.Text = "Yearly";
      this.yearlyOverviewRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.yearlyOverviewRadio.UseVisualStyleBackColor = false;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.White;
      this.panel1.Controls.Add(this.incomeWeeklyRadio);
      this.panel1.Controls.Add(this.incomeMonthlyRadio);
      this.panel1.Controls.Add(this.incomeYearlyRadio);
      this.panel1.Controls.Add(this.incomeChart);
      this.panel1.Location = new System.Drawing.Point(12, 12);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(441, 191);
      this.panel1.TabIndex = 4;
      // 
      // expenseTrendPanel
      // 
      this.expenseTrendPanel.BackColor = System.Drawing.Color.White;
      this.expenseTrendPanel.Controls.Add(this.expenseWeeklyRadio);
      this.expenseTrendPanel.Controls.Add(this.expenseMonthlyRadio);
      this.expenseTrendPanel.Controls.Add(this.expenseYearlyRadio);
      this.expenseTrendPanel.Controls.Add(this.expenseChart);
      this.expenseTrendPanel.Location = new System.Drawing.Point(475, 12);
      this.expenseTrendPanel.Name = "expenseTrendPanel";
      this.expenseTrendPanel.Size = new System.Drawing.Size(441, 191);
      this.expenseTrendPanel.TabIndex = 5;
      // 
      // expenseByCategoryPanel
      // 
      this.expenseByCategoryPanel.BackColor = System.Drawing.Color.White;
      this.expenseByCategoryPanel.Controls.Add(this.expenseTypeWeeklyRadio);
      this.expenseByCategoryPanel.Controls.Add(this.expenseTypeMonthlyRadio);
      this.expenseByCategoryPanel.Controls.Add(this.expenseTypeYearlyRadio);
      this.expenseByCategoryPanel.Controls.Add(this.expenseCategoryChart);
      this.expenseByCategoryPanel.Location = new System.Drawing.Point(12, 218);
      this.expenseByCategoryPanel.Name = "expenseByCategoryPanel";
      this.expenseByCategoryPanel.Size = new System.Drawing.Size(441, 191);
      this.expenseByCategoryPanel.TabIndex = 6;
      // 
      // UserDash
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.ClientSize = new System.Drawing.Size(928, 421);
      this.Controls.Add(this.expenseByCategoryPanel);
      this.Controls.Add(this.expenseTrendPanel);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.overviewPanel);
      this.Name = "UserDash";
      this.Text = "UserDash";
      ((System.ComponentModel.ISupportInitialize)(this.incomeChart)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.expenseCategoryChart)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.expenseChart)).EndInit();
      this.overviewPanel.ResumeLayout(false);
      this.overviewPanel.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.balanceOverviewIcon)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ExpenseOverviewIcon)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.incomeOverviewIcon)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.expenseTrendPanel.ResumeLayout(false);
      this.expenseTrendPanel.PerformLayout();
      this.expenseByCategoryPanel.ResumeLayout(false);
      this.expenseByCategoryPanel.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataVisualization.Charting.Chart incomeChart;
    private System.Windows.Forms.DataVisualization.Charting.Chart expenseCategoryChart;
    private System.Windows.Forms.DataVisualization.Charting.Chart expenseChart;
    private System.Windows.Forms.RadioButton incomeWeeklyRadio;
    private System.Windows.Forms.RadioButton expenseWeeklyRadio;
    private System.Windows.Forms.RadioButton expenseTypeWeeklyRadio;
    private System.Windows.Forms.RadioButton incomeMonthlyRadio;
    private System.Windows.Forms.RadioButton incomeYearlyRadio;
    private System.Windows.Forms.RadioButton expenseMonthlyRadio;
    private System.Windows.Forms.RadioButton expenseYearlyRadio;
    private System.Windows.Forms.RadioButton expenseTypeMonthlyRadio;
    private System.Windows.Forms.RadioButton expenseTypeYearlyRadio;
    private System.Windows.Forms.Panel overviewPanel;
    private System.Windows.Forms.Label overviewLabel;
    private System.Windows.Forms.RadioButton weeklyOverviewRadio;
    private System.Windows.Forms.RadioButton monthlyOverviewRadio;
    private System.Windows.Forms.RadioButton yearlyOverviewRadio;
    private System.Windows.Forms.Label balanceOverviewLabel;
    private System.Windows.Forms.Label expenseOverviewLabel;
    private System.Windows.Forms.Label incomeOverviewLabel;
    private System.Windows.Forms.PictureBox balanceOverviewIcon;
    private System.Windows.Forms.PictureBox ExpenseOverviewIcon;
    private System.Windows.Forms.PictureBox incomeOverviewIcon;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel expenseTrendPanel;
    private System.Windows.Forms.Panel expenseByCategoryPanel;
    private System.Windows.Forms.Label balanceLabel;
    private System.Windows.Forms.Label expenselabel;
    private System.Windows.Forms.Label incomeLabel;
  }
}