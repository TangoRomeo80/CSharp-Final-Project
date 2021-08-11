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
  public partial class SettingsInfo : Form
  {
    public SettingsInfo()
    {
      InitializeComponent();
    }

    private void changeInfoButton_Click(object sender, EventArgs e)
    {
      ChangeInfo changeInfo = new ChangeInfo();
      changeInfo.Show();
    }

    private void changePasswordButton_Click(object sender, EventArgs e)
    {
      ChangePassword changePassword = new ChangePassword();
      changePassword.Show();
    }
  }
}
