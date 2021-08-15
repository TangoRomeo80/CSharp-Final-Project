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

  }
}
