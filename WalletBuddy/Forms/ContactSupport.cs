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
using WalletBuddy.Executor;
using WalletBuddy.Model;

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

    private void submitButton_Click(object sender, EventArgs e)
    {
      TokenServices tokenservices = new TokenServices();
      if (userNameTextBox.Texts == "" || emailTextBox.Texts == "" || messageTextBox.Texts == "")
      {
        MessageBox.Show("Username, Email or Message fields cannot be empty.");
      }
      else
      {
        SupportToken token = new SupportToken()
        {
          SenderName = userNameTextBox.Texts,
          SenderEmail = emailTextBox.Texts,
          Description = messageTextBox.Texts,
          Status = "Incomplete"
        };
        int success = tokenservices.AddToken(token);
        if (success > 0)
        {
          userNameTextBox.Texts = "";
          emailTextBox.Texts = "";
          messageTextBox.Texts = "";
          MessageBox.Show("Your feedback was logged successfully.");
        }
        else
        {
          MessageBox.Show("An Unexpected error Occured. Feedback could not be saved.");
        }
      }
    }
  }
}
