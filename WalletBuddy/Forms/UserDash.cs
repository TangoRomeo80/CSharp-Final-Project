using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WalletBuddy.Executor;
using WalletBuddy.Model;

namespace WalletBuddy.Forms
{
  public partial class UserDash : Form
  {
    private User user;

    public UserDash(User user)
    {
      InitializeComponent();
      this.user = user;
      Load += new EventHandler(Init_Load);
    }

    public void UpdateWeeklyIncomeChart()
    {
      incomeChart.Series["Income trend"].Points.Clear();

      IncomeServices incomeServices = new IncomeServices();
      List<Income> weeklyIncomeList = incomeServices.GetWeeklyIncomeList(this.user);
      foreach (Income income in weeklyIncomeList)
      {
        incomeChart.Series["Income trend"].Points.AddXY(income.Date.ToString("dd/MM/yyyy"), income.Amount);
      }
    }

    public void UpdateMonthlyIncomeChart()
    {
      incomeChart.Series["Income trend"].Points.Clear();

      IncomeServices incomeServices = new IncomeServices();
      List<Income> monthlyIncomeList = incomeServices.GetMonthlyIncomeList(this.user);
      foreach (Income income in monthlyIncomeList)
      {
        incomeChart.Series["Income trend"].Points.AddXY(income.Date.ToString("dd/MM/yyyy"), income.Amount);
      }
    }

    public void UpdateYearlyIncomeChart()
    {
      incomeChart.Series["Income trend"].Points.Clear();

      IncomeServices incomeServices = new IncomeServices();
      List<Income> yearlyIncomeList = incomeServices.GetYearlyIncomeList(this.user);
      foreach (Income income in yearlyIncomeList)
      {
        incomeChart.Series["Income trend"].Points.AddXY(income.Date.ToString("dd/MM/yyyy"), income.Amount);
      }
    }

    public void UpdateWeeklyExpenseChart()
    {
      expenseChart.Series["Expense trend"].Points.Clear();

      ExpenseServices expenseServices = new ExpenseServices();
      List<Expense> weeklyExpenseList = expenseServices.GetWeeklyExpenseList(this.user);
      foreach (Expense expense in weeklyExpenseList)
      {
        expenseChart.Series["Expense trend"].Points.AddXY(expense.Date.ToString("dd/MM/yyyy"), expense.Amount);
      }
    }

    public void UpdateMonthlyExpenseChart()
    {
      expenseChart.Series["Expense trend"].Points.Clear();

      ExpenseServices expenseServices = new ExpenseServices();
      List<Expense> monthlyExpenseList = expenseServices.GetMonthlyExpenseList(this.user);
      foreach (Expense expense in monthlyExpenseList)
      {
        expenseChart.Series["Expense trend"].Points.AddXY(expense.Date.ToString("dd/MM/yyyy"), expense.Amount);
      }
    }

    public void UpdateYearlyExpenseChart()
    {
      expenseChart.Series["Expense trend"].Points.Clear();

      ExpenseServices expenseServices = new ExpenseServices();
      List<Expense> yearlyExpenseList = expenseServices.GetMonthlyExpenseList(this.user);
      foreach (Expense expense in yearlyExpenseList)
      {
        expenseChart.Series["Expense trend"].Points.AddXY(expense.Date.ToString("dd/MM/yyyy"), expense.Amount);
      }
    }

    public void updateWeeklyOverview()
    {
      IncomeServices incomeServices = new IncomeServices();
      ExpenseServices expenseServices = new ExpenseServices();
      int weeklyIncome = incomeServices.GetWeeklyIncome(this.user);
      incomeLabel.Text = weeklyIncome.ToString();
      int weeklyExpense = expenseServices.GetWeeklyExpense(this.user);
      expenselabel.Text = weeklyExpense.ToString();
      balanceLabel.Text = (weeklyIncome - weeklyExpense).ToString();
    }

    public void updateMonthlyOverview()
    {
      IncomeServices incomeServices = new IncomeServices();
      ExpenseServices expenseServices = new ExpenseServices();
      int monthlyIncome = incomeServices.GetMonthlyIncome(this.user);
      incomeLabel.Text = monthlyIncome.ToString();
      int monthlyExpense = expenseServices.GetMonthlyExpense(this.user);
      expenselabel.Text = monthlyExpense.ToString();
      balanceLabel.Text = (monthlyIncome - monthlyExpense).ToString();
    }

    public void updateYearlyOverview()
    {
      IncomeServices incomeServices = new IncomeServices();
      ExpenseServices expenseServices = new ExpenseServices();
      int yearlyIncome = incomeServices.GetYearlyIncome(this.user);
      incomeLabel.Text = yearlyIncome.ToString();
      int yearlyExpense = expenseServices.GetYearlyExpense(this.user);
      expenselabel.Text = yearlyExpense.ToString();
      balanceLabel.Text = (yearlyIncome - yearlyExpense).ToString();
    }

    public void UpdateLoad()
    {
      UpdateWeeklyIncomeChart();
      UpdateWeeklyExpenseChart();
      updateWeeklyOverview();
    }

    private void Init_Load(object sender, System.EventArgs e)
    {
      UpdateLoad();
    }

    private void incomeWeeklyRadio_CheckedChanged(object sender, EventArgs e)
    {
      if (incomeWeeklyRadio.Checked) UpdateWeeklyIncomeChart();
      else UpdateLoad();
    }

    private void incomeMonthlyRadio_CheckedChanged(object sender, EventArgs e)
    {
      if (incomeMonthlyRadio.Checked) UpdateMonthlyIncomeChart();
      else UpdateLoad();
    }

    private void incomeYearlyRadio_CheckedChanged(object sender, EventArgs e)
    {
      if (incomeYearlyRadio.Checked) UpdateYearlyIncomeChart();
      else UpdateLoad();
    }

    private void expenseWeeklyRadio_CheckedChanged(object sender, EventArgs e)
    {
      if (expenseWeeklyRadio.Checked) UpdateWeeklyExpenseChart();
      else UpdateLoad();
    }

    private void expenseMonthlyRadio_CheckedChanged(object sender, EventArgs e)
    {
      if (expenseMonthlyRadio.Checked) UpdateMonthlyExpenseChart();
      else UpdateLoad();
    }

    private void expenseYearlyRadio_CheckedChanged(object sender, EventArgs e)
    {
      if (expenseYearlyRadio.Checked) UpdateYearlyExpenseChart();
      else UpdateLoad();
    }

    private void weeklyOverviewRadio_CheckedChanged(object sender, EventArgs e)
    {
      if (weeklyOverviewRadio.Checked) updateWeeklyOverview();
      else UpdateLoad();
    }

    private void monthlyOverviewRadio_CheckedChanged(object sender, EventArgs e)
    {
      if (monthlyOverviewRadio.Checked) updateMonthlyOverview();
      else UpdateLoad();
    }

    private void yearlyOverviewRadio_CheckedChanged(object sender, EventArgs e)
    {
      if (yearlyOverviewRadio.Checked) updateYearlyOverview();
      else UpdateLoad();
    }
  }
}
