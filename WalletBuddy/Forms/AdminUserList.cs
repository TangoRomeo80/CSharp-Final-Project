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
  public partial class AdminUserList : Form
  {
    private User user;

    public AdminUserList(User user)
    {
      InitializeComponent();
      this.user = user;
      Load += new EventHandler(Init_Load);
    }

    public void UpdateDataGrid()
    {
      userListDataGridView.Rows.Clear();

      UserServices userServices = new UserServices();
      List<User> userList = userServices.GetAllUserList();
      foreach (User user in userList)
      {
        userListDataGridView.Rows.Add(user.UserName, user.UserEmail, user.UserType);
      }
    }

    private void Init_Load(object sender, System.EventArgs e)
    {
      UpdateDataGrid();
    }


    private void editUserButton_Click(object sender, EventArgs e)
    {
      if (userListDataGridView.SelectedRows.Count <= 0)
      {
        MessageBox.Show("No user is selected.");
      }
      else
      {
        userNameTextBox.Texts = userListDataGridView.SelectedRows[0].Cells[0].Value.ToString();
        emailTextBox.Texts = userListDataGridView.SelectedRows[0].Cells[1].Value.ToString();
        userTypeTextBox.Texts = userListDataGridView.SelectedRows[0].Cells[2].Value.ToString();
      }
    }

    private void updateButton_Click(object sender, EventArgs e)
    {
      UserServices userServices = new UserServices();
      if (userNameTextBox.Texts == "" || emailTextBox.Texts == "" || userTypeTextBox.Texts == "")
      {
        MessageBox.Show("User detail fields cannot be empty.");
      }
      else
      {
        User oldUser = new User()
        {
          UserName = userListDataGridView.SelectedRows[0].Cells[0].Value.ToString()
        };
        User newUser = new User()
        {
          UserName = userNameTextBox.Texts,
          UserEmail = emailTextBox.Texts,
          UserType = userTypeTextBox.Texts
        };
        int success = userServices.ChangeInfo(newUser, oldUser);
        if(success > 0)
        {
          userNameTextBox.Texts = "";
          emailTextBox.Texts = "";
          userTypeTextBox.Texts = "";
          MessageBox.Show("User information updated successfully");
          UpdateDataGrid();
        }
        else
        {
          MessageBox.Show("An Unexpected error Occured. Record could not be Removed.");
        }
      }

    }

    private void removeButton_Click(object sender, EventArgs e)
    {
      UserServices userServices = new UserServices();
      if (userListDataGridView.SelectedRows.Count <= 0)
      {
        MessageBox.Show("No user is selected.");
      }
      else
      {
        User userToRemove = new User()
        {
          UserName = userListDataGridView.SelectedRows[0].Cells[0].Value.ToString(),
        };
        int success = userServices.RemoveUser(userToRemove);
        if (success > 0)
        {
          userNameTextBox.Texts = "";
          emailTextBox.Texts = "";
          userTypeTextBox.Texts = "";
          MessageBox.Show("User Removed successfully");
          UpdateDataGrid();
        }
        else
        {
          MessageBox.Show("An Unexpected error Occured. User could not be Removed.");
        }
      }
    }

    private void userSearchTextBox__TextChanged(object sender, EventArgs e)
    {
      userListDataGridView.Rows.Clear();

      UserServices userServices = new UserServices();
      List<User> userList = userServices.GetAllUserList();
      foreach(User user in userList)
      {
        if (user.UserName.Contains(userSearchTextBox.Texts))
        {
          userListDataGridView.Rows.Add(user.UserName, user.UserEmail, user.UserType);
        }
      }
    }
  }
}
