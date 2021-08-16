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
  public partial class TransferBudget : Form
  {
    private User user;
    private UserAccounts parentForm;

    public TransferBudget(User user, UserAccounts parentForm)
    {
      InitializeComponent();
      this.user = user;
      this.parentForm = parentForm;
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void transferButton_Click(object sender, EventArgs e)
    {
      if (senderAccountNameTextBox.Texts == "" || recieverAccountNameTextBox.Texts == "" || amountTextBox.Texts == "")
      {
        MessageBox.Show("Sender account, Reciever account or amount fields cannot be empty.");
      }
      else
      {
        AccountServices accountServices = new AccountServices();
        int amount = Convert.ToInt32(amountTextBox.Texts);
        Account senderAccount = new Account()
        {
          AccountName = senderAccountNameTextBox.Texts
        };

        int accountBalance = accountServices.CheckAccountBalance(senderAccount, this.user);

        if (accountBalance < amount)
        {
          MessageBox.Show("Account Balance is not sufficient.");
        }

        else
        {
          Account recieverAccount = new Account()
          {
            AccountName = recieverAccountNameTextBox.Texts
          };
          string senderExist = accountServices.CheckAccountName(senderAccount, user);
          string recieverExist = accountServices.CheckAccountName(recieverAccount, user);

          if (senderExist != senderAccountNameTextBox.Texts)
          {
            MessageBox.Show("Sending account name does not exist.");
          }
          else if (recieverExist != recieverAccountNameTextBox.Texts)
          {
            MessageBox.Show("Recieving account name does not exist.");
          }
          else
          {
            int success = accountServices.TransferBalance(senderAccount, recieverAccount, user, amount);
            if (success > 0)
            {
              senderAccountNameTextBox.Texts = "";
              recieverAccountNameTextBox.Texts = "";
              amountTextBox.Texts = "";
              MessageBox.Show("Transfer Successfull.");
              parentForm.UpdateDataGrid();
            }
            else
            {
              MessageBox.Show("An Unexpected error Occured. Sign up failed.");
            }
          }
        }
      }
    }
  }
}
