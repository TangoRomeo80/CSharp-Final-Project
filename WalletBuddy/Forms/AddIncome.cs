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
  public partial class AddIncome : Form
  {
    private User user;
    private UserIncome parentForm;

    public AddIncome(User user, UserIncome parentForm)
    {
      InitializeComponent();
      this.user = user;
      this.parentForm = parentForm;
      Load += new EventHandler(Init_Load);
    }

    private void Init_Load(object sender, System.EventArgs e)
    {
      IncomeServices incomeServices = new IncomeServices();
      List<string> accountNames = incomeServices.GetAccountNames(this.user);
      foreach(string accountName in accountNames)
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
      if (paymentFromTextBox.Texts == "" || paymentAmountTextBox.Texts == "" || descriptionTextBox.Texts == "")
      {
        MessageBox.Show("Payer name, amount or description fields cannot be empty.");
      }
      else if (accountComboBox.SelectedIndex < 0)
      {
        MessageBox.Show("An account needs to be selected.");
      }
      else
      {
        IncomeServices incomeServices = new IncomeServices();
        Income income = new Income()
        {
          UserName = user.UserName,
          Amount = Convert.ToInt32(paymentAmountTextBox.Texts),
          PaymentFrom = paymentFromTextBox.Texts,
          Description = descriptionTextBox.Texts,
          AccountName = accountComboBox.SelectedItem.ToString(),
          Date = DateTime.Now
        };
        int success = incomeServices.AddIncome(income, this.user);
        if (success > 0)
        {
          paymentAmountTextBox.Texts = "";
          paymentFromTextBox.Texts = "";
          descriptionTextBox.Texts = "";
          MessageBox.Show("Income record added successfully");
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
