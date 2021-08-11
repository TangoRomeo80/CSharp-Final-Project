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
  public partial class AddExpense : Form
  {
    private User user;
    private UserExpense parentForm;

    public AddExpense(User user, UserExpense parentForm)
    {
      InitializeComponent();
      this.user = user;
      this.parentForm = parentForm;
      Load += new EventHandler(Init_Load);
    }

    private void Init_Load(object sender, System.EventArgs e)
    {
      ExpenseServices expenseServices = new ExpenseServices();
      List<string> accountNames = expenseServices.GetAccountNames(this.user);
      foreach (string accountName in accountNames)
      {
        accountComboBox.Items.Add(accountName);
      }
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void addButton_Click(object sender, EventArgs e)
    {
      if (paymentToTextBox.Texts == "" || paymentAmountTextBox.Texts == "" || descriptionTextBox.Texts == "")
      {
        MessageBox.Show("Reciever name, amount or description fields cannot be empty.");
      }
      else if (accountComboBox.SelectedIndex < 0)
      {
        MessageBox.Show("An account needs to be selected.");
      }
      else
      {
        ExpenseServices expenseServices = new ExpenseServices();
        Expense expense = new Expense()
        {
          UserName = user.UserName,
          Amount = Convert.ToInt32(paymentAmountTextBox.Texts),
          PaymentTo = paymentToTextBox.Texts,
          Description = descriptionTextBox.Texts,
          AccountName = accountComboBox.SelectedItem.ToString(),
          Date = DateTime.Now
        };
        int success = expenseServices.AddExpense(expense, this.user);
        if (success > 0)
        {
          paymentAmountTextBox.Texts = "";
          paymentToTextBox.Texts = "";
          descriptionTextBox.Texts = "";
          MessageBox.Show("Expense record added successfully");
          parentForm.UpdateDataGrid();
        }
        else
        {
          MessageBox.Show("An Unexpected error Occured. Record could not be added.");
        }
      }
    }
  }
}
