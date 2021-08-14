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
  public partial class SettingsInfo : Form
  {
    private User user;
    private User userToModify;

    public SettingsInfo(User user)
    {
      InitializeComponent();
      this.user = user;
      Load += new EventHandler(Init_Load);
    }

    private void changeInfoButton_Click(object sender, EventArgs e)
    {
      ChangeInfo changeInfo = new ChangeInfo(userToModify, this);
      changeInfo.Show();
    }

    private void changePasswordButton_Click(object sender, EventArgs e)
    {
      ChangePassword changePassword = new ChangePassword(userToModify, this);
      changePassword.Show();
    }

    public void UpdateUserInfo(User user)
    {
      UserServices userServices = new UserServices();
      userToModify = userServices.GetUserInfo(user);
      usernameTextLabel.Text = userToModify.UserName;
      emailTextlabel.Text = userToModify.UserEmail;
    }

    private void Init_Load(object sender, System.EventArgs e)
    {
      UpdateUserInfo(this.user);
    }
  }
}
