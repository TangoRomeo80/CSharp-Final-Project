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
using System.Web;
using System.Net.Mail;

namespace WalletBuddy.Forms
{
  public partial class SendResponse : Form
  {
    private string eMail;

    public SendResponse(string eMail)
    {
      InitializeComponent();
      this.eMail = eMail;
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void sendButton_Click(object sender, EventArgs e)
    {
      if(descriptionTextBox.Texts == "")
      {
        MessageBox.Show("Description field cannot stay empty.");
      }
      else
      {
        MailMessage mail = new MailMessage("tanzeemRahatVal@gmail.com", eMail, "Response to your feedback from Wallet Buddy", descriptionTextBox.Texts);
        SmtpClient client = new SmtpClient("smtp.gmail.com");
        client.UseDefaultCredentials = false;
        client.Port = 587;
        client.Credentials = new System.Net.NetworkCredential("tanzeemRahatVal@gmail.com", "rahatOTG2769");
        client.EnableSsl = true;
        client.Send(mail);
        MessageBox.Show("Response sent successfully.");
      }
    }
  }
}
