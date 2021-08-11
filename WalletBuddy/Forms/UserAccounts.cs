using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WalletBuddy.Forms
{
  public partial class UserAccounts : Form
  {
    public UserAccounts()
    {
      InitializeComponent();
    }

    private void addAccountButton_Click(object sender, EventArgs e)
    {
      AddAccount addAccount = new AddAccount();
      addAccount.Show();
    }
  }
}
