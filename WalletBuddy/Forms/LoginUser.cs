//Login page

using System;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using WalletBuddy.Executor;
using WalletBuddy.Model;

namespace WalletBuddy.Forms
{
  public partial class LoginUser : KryptonForm
  {
    public LoginUser()
    {
      InitializeComponent();
    }

    private void backToWelcomeLabel_Click(object sender, EventArgs e)
    {
      Welcome welcome = new Welcome();
      welcome.Show();
      this.Hide();
    }

    private void signUpLabel_Click(object sender, EventArgs e)
    {
      RegisterUser registerUser = new RegisterUser();
      registerUser.Show();
      this.Hide();
    }

    private void showPassCheckBox_CheckedChanged(object sender, EventArgs e)
    {
      if (showPassCheckBox.Checked) passwordTextBox.PasswordChar = false;
      else passwordTextBox.PasswordChar = true;
    }

    private void clearButton_Click(object sender, EventArgs e)
    {
      userNameTextBox.Texts = "";
      passwordTextBox.Texts = "";
    }

    private void signInButton_Click(object sender, EventArgs e)
    {
      if (userNameTextBox.Texts == "" ||  passwordTextBox.Texts == "")
      {
        MessageBox.Show("Username or Password fields cannot be empty.");
      }
      else
      {
        UserServices userServices = new UserServices();

        if (userServices.UserLoginValidate(userNameTextBox.Texts, passwordTextBox.Texts))
        {
          
          string userType = userServices.CheckUserType(userNameTextBox.Texts);
          if(userType == "User")
          {
            User user = new User()
            {
              UserName = userNameTextBox.Texts
            };

            UserMain userMain = new UserMain(user);
            userMain.Show();
            this.Hide();
          }
          else if(userType == "Admin")
          {
            User user = new User()
            {
              UserName = userNameTextBox.Texts
            };
            AdminMain adminMain = new AdminMain(user);
            adminMain.Show();
            this.Hide();
          }
          else
          {
            MessageBox.Show("Unexpected error occured. Could not login.");
          }
        }
        else
        {
          MessageBox.Show("Validation failed, Username or password did not match.");
        }
      }

    }
  }
}
