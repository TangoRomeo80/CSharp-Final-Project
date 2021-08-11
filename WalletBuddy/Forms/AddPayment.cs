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
  public partial class AddPayment : Form
  {
    public AddPayment()
    {
      InitializeComponent();
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

  }
}
