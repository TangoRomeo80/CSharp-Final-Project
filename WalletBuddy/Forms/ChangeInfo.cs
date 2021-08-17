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
  public partial class ChangeInfo : Form
  {
    private User userToModify;
    public SettingsInfo ParentFormP { set; get; }

    public ChangeInfo(User userToModify, SettingsInfo parentForm)
    {
      InitializeComponent();
      this.userToModify = userToModify;
      this.ParentFormP = parentForm;
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void changeButton_Click(object sender, EventArgs e)
    {
      UserServices userServices = new UserServices();
      string userExists = userServices.CheckUserName(newUsernameTextBox.Texts);
      if (newUsernameTextBox.Texts == "" || newEmailTextBox.Texts == "")
      {
        MessageBox.Show("New userName or email fields cannot be empty.");
      }
      else if(userExists == newUsernameTextBox.Texts)
      {
        MessageBox.Show("Username is already taken, please try different Username");
      }
      else
      {
        User user = new User()
        {
          UserName = newUsernameTextBox.Texts,
          UserEmail = newEmailTextBox.Texts,
          UserType = userToModify.UserType,
          Image = userServices.ConvertToByte(profilePictureBox.Image)
        };
        int success = userServices.ChangeInfo(user, userToModify);
        if(success > 0)
        {
          newUsernameTextBox.Texts = "";
          newEmailTextBox.Texts = "";
          MessageBox.Show("Information changed successfully");
          ParentFormP.UpdateUserInfo(user);
        }
        else
        {
          MessageBox.Show("An Unexpected error Occured. Information could not be changed.");
        }
      }
    }

    private void uploadButton_Click(object sender, EventArgs e)
    {
      OpenFileDialog ofd = new OpenFileDialog();
      ofd.Title = "Select Image";
      ofd.Filter = "All Files *.*|*.*";
      if (ofd.ShowDialog() == DialogResult.OK)
      {
        profilePictureBox.Image = new Bitmap(ofd.FileName);
      }
    }
  }
}
