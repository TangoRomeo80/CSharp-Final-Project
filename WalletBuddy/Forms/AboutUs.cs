//Login page

using System;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using WalletBuddy.Executor;
using WalletBuddy.Model;

namespace WalletBuddy.Forms
{
  public partial class AboutUs : KryptonForm
  {
    public AboutUs()
    {
      InitializeComponent();
    }

    private void backToWelcomeLabel_Click(object sender, EventArgs e)
    {
      Welcome welcome = new Welcome();
      welcome.Show();
      this.Hide();
    }
  }
}
