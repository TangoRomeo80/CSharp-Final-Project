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
  public partial class UserPayments : Form
  {
    public UserPayments()
    {
      InitializeComponent();
    }

    private void addPaymentButton_Click(object sender, EventArgs e)
    {
      AddPayment addPayment = new AddPayment();
      addPayment.Show();
    }
  }
}
