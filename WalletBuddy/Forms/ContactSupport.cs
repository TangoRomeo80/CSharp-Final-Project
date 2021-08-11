using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace WalletBuddy.Forms
{
  public partial class ContactSupport : KryptonForm
  {
    public ContactSupport()
    {
      InitializeComponent();
    }

    private void backToWelcomeLabel_Click(object sender, EventArgs e)
    {
      Welcome welcome = new Welcome();
      welcome.Show();
      this.Hide();
    }

    private void clearButton_Click(object sender, EventArgs e)
    {
      userNameTextBox.Texts = "";
      emailTextBox.Texts = "";
      messageTextBox.Texts = "";
    }
  }
}
