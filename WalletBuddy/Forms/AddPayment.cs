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
  public partial class AddPayment : Form
  {
    private User user;
    private UserPayments parentForm;

    public AddPayment(User user, UserPayments parentForm)
    {
      InitializeComponent();
      this.user = user;
      this.parentForm = parentForm;
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

  }
}
