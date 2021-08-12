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
  public partial class UserAccounts : Form
  {
    private User user;

    public UserAccounts(User user)
    {
      InitializeComponent();
      this.user = user;
      Load += new EventHandler(Init_Load);
    }

    public void UpdateDataGrid()
    {
      accountDataGridView.Rows.Clear();

      AccountServices accountServices = new AccountServices();
      List<Account> accountList = accountServices.GetAccountList(this.user);
      foreach (Account account in accountList)
      {
        accountDataGridView.Rows.Add(account.AccountName, account.AccountDescription, account.StartingAmount, account.Balance);
      }
    }

    private void Init_Load(object sender, System.EventArgs e)
    {
      UpdateDataGrid();
    }

    private void addAccountButton_Click(object sender, EventArgs e)
    {
      AddAccount addAccount = new AddAccount(this.user, this);
      addAccount.Show();
    }

    private void removeAccountButton_Click(object sender, EventArgs e)
    {
      string accountName = accountDataGridView.SelectedRows[0].Cells[0].Value.ToString();
      AccountServices accountServices = new AccountServices();
      Account account = new Account()
      {
        AccountName = accountName
      };
      int success = accountServices.RemoveAccount(this.user, account);
      if(success > 0)
      {
        MessageBox.Show("Account record Removed successfully");
        UpdateDataGrid();
      }
      else
      {
        MessageBox.Show("An Unexpected error Occured. Record could not be Removed.");
      }
    }
  }
}
