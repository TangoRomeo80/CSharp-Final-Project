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
  public partial class AddAccount : Form
  {
    private User user;
    private UserAccounts parentForm;

    public AddAccount(User user, UserAccounts parentForm)
    {
      InitializeComponent();
      this.user = user;
      this.parentForm = parentForm;
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void addButton_Click(object sender, EventArgs e)
    {
      if (accountNameTextBox.Texts == "" || descriptionTextBox.Texts == "" || startingAmountTextBox.Texts == "")
      {
        MessageBox.Show("Account name, starting amount or description fields cannot be empty.");
      }
      else
      {
        AccountServices accountServices = new AccountServices();
        Account account = new Account()
        {
          UserName = user.UserName,
          StartingAmount = Convert.ToInt32(startingAmountTextBox.Texts),
          AccountName = accountNameTextBox.Texts,
          AccountDescription = descriptionTextBox.Texts
        };
        int success = accountServices.AddAccount(account);
        if (success > 0)
        {
          accountNameTextBox.Texts = "";
          startingAmountTextBox.Texts = "";
          descriptionTextBox.Texts = "";
          MessageBox.Show("Account record added successfully");
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
