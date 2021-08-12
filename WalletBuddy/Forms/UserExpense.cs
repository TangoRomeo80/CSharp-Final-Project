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
  public partial class UserExpense : Form
  {
    private User user;

    public UserExpense(User user)
    {
      InitializeComponent();
      this.user = user;
      Load += new EventHandler(Init_Load);
    }

    public void UpdateDataGrid()
    {
      expenseDataGridView.Rows.Clear();

      ExpenseServices expenseServices = new ExpenseServices();
      List<Expense> expenseList = expenseServices.GetExpenseList(this.user);
      foreach (Expense expense in expenseList)
      {
        expenseDataGridView.Rows.Add(expense.PaymentTo, expense.Description, expense.AccountName, expense.Amount, expense.Date.ToString("dd/MM/yyyy"));
      }
    }

    private void Init_Load(object sender, System.EventArgs e)
    {
      UpdateDataGrid();
    }

    private void addExpenseButton_Click(object sender, EventArgs e)
    {
      AddExpense addExpense = new AddExpense(this.user, this);
      addExpense.Show();
    }
  }
}
