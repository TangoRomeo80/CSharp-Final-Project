using System;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using WalletBuddy.Executor;
using WalletBuddy.Model;
using System.Drawing;
using System.IO;

namespace WalletBuddy.Forms
{
  public partial class RegisterUser : KryptonForm
  {
    public RegisterUser()
    {
      InitializeComponent();
    }

    private void backToLoginLabel_Click(object sender, EventArgs e)
    {
      LoginUser loginUser = new LoginUser();
      loginUser.Show();
      this.Hide();
    }

    private void clearButton_Click(object sender, EventArgs e)
    {
      userNameTextBox.Texts = "";
      emailTextBox.Texts = "";
      passwordTextBox.Texts = "";
      confirmPasswordTextBox.Texts = "";
    }

    private void showPassCheckBox_CheckedChanged(object sender, EventArgs e)
    {
      if (showPassCheckBox.Checked)
      {
        passwordTextBox.PasswordChar = false;
        confirmPasswordTextBox.PasswordChar = false;
      }
      else
      {
        passwordTextBox.PasswordChar = true;
        confirmPasswordTextBox.PasswordChar = true;
      }
    }

    private void signUpButton_Click(object sender, EventArgs e)
    {
      if (userNameTextBox.Texts == "" || emailTextBox.Texts == "" || passwordTextBox.Texts == "")
      {
        MessageBox.Show("Username, Email or Password fields cannot be empty.");
      }

      else if (passwordTextBox.Texts != confirmPasswordTextBox.Texts)
      {
        MessageBox.Show("Passwords do not match!");
      }
      else
      {
        UserServices userServices = new UserServices();

        //check if user exists
        string userExists = userServices.CheckUserName(userNameTextBox.Texts);
        if (userExists == userNameTextBox.Texts)
        {
          MessageBox.Show("Username is already taken, please try different Username");
        }
        else
        {
          User user = new User()
          {
            UserName = userNameTextBox.Texts,
            UserEmail = emailTextBox.Texts,
            UserPassword = passwordTextBox.Texts,
            UserType = "User",
            Image = userServices.ConvertToByte(profilePictureBox.Image)
          };
          int success = userServices.AddUser(user);
          if(success > 0)
          {
            userNameTextBox.Texts = "";
            emailTextBox.Texts = "";
            passwordTextBox.Texts = "";
            confirmPasswordTextBox.Texts = "";
            MessageBox.Show("Sign up successfull.");
          }
          else
          {
            MessageBox.Show("An Unexpected error Occured. Sign up failed.");
          }
        }

      }
    }

    private void uploadButton_Click(object sender, EventArgs e)
    {
      OpenFileDialog ofd = new OpenFileDialog();
      ofd.Title = "Select Image";
      ofd.Filter = "All Files *.*|*.*";
      if(ofd.ShowDialog() == DialogResult.OK)
      {
        profilePictureBox.Image = new Bitmap(ofd.FileName);
      }
    }
  }
}
