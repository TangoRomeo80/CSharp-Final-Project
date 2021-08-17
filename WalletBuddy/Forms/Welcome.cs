//Welcome page

using System;
using ComponentFactory.Krypton.Toolkit;

namespace WalletBuddy.Forms
{
  public partial class Welcome : KryptonForm
  {
    public Welcome()
    {
      InitializeComponent();
    }

    private void startButton_Click(object sender, EventArgs e)
    {
      LoginUser login = new LoginUser();
      login.Show();
      this.Hide();
    }

    private void aboutButton_Click(object sender, EventArgs e)
    {
      ContactSupport contactSupport = new ContactSupport();
      contactSupport.Show();
      this.Hide();
    }

    private void aboutUsButton_Click(object sender, EventArgs e)
    {
      AboutUs aboutUs = new AboutUs();
      aboutUs.Show();
      this.Hide();
    }
  }
}
