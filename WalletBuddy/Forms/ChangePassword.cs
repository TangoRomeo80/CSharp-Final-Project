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
  public partial class ChangePassword : Form
  {
    private User userToModify;
    private SettingsInfo parentForm;

    public ChangePassword(User userToModify, SettingsInfo parentForm)
    {
      InitializeComponent();
      this.userToModify = userToModify;
      this.parentForm = parentForm;
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void changeButton_Click(object sender, EventArgs e)
    {
      UserServices userServices = new UserServices();
      if (previousPasswordTextBox.Texts == "" || newPasswordTextBox.Texts == "" || confNewPasswordTextBox.Texts == "")
      {
        MessageBox.Show("Any of the password fields cannot be empty");
      }
      else if(previousPasswordTextBox.Texts != userToModify.UserPassword)
      {
        MessageBox.Show("Previous password does not match");
      }

      else if (newPasswordTextBox.Texts != confNewPasswordTextBox.Texts)
      {
        MessageBox.Show("Confirmed passwords do not match");
      }
      else
      {
        User user = new User()
        {
          UserId = userToModify.UserId,
          UserName = userToModify.UserName,
          UserPassword = newPasswordTextBox.Texts
        };
        int success = userServices.ChangePassword(user, userToModify);
        if (success > 0)
        {
          previousPasswordTextBox.Texts = "";
          newPasswordTextBox.Texts = "";
          confNewPasswordTextBox.Texts = "";
          MessageBox.Show("Password changed successfully");
          parentForm.UpdateUserInfo(user);
        }
        else
        {
          MessageBox.Show("An Unexpected error Occured. Information could not be changed.");
        }
      } 

    }

    private void showPassCheckBox_CheckedChanged(object sender, EventArgs e)
    {
      if (showPassCheckBox.Checked)
      {
        previousPasswordTextBox.PasswordChar = false;
        newPasswordTextBox.PasswordChar = false;
        confNewPasswordTextBox.PasswordChar = false;
      }
      else
      {
        previousPasswordTextBox.PasswordChar = true;
        newPasswordTextBox.PasswordChar = true;
        confNewPasswordTextBox.PasswordChar = true;
      }
    }
  }
}
