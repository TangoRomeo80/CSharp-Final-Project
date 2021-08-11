using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletBuddy.DB;
using WalletBuddy.Model;

namespace WalletBuddy.Executor
{
  class UserServices
  {
    UserDataAccess userDataAccess;

    public UserServices()
    {
      this.userDataAccess = new UserDataAccess();
    }

    public int AddUser(string userName, string userEmail, string userPassword, string userType)
    {
      User user = new User(0, userName, userEmail, userPassword, userType);
      this.userDataAccess = new UserDataAccess();
      return this.userDataAccess.AddUser(user);
    }

    public string CheckUserName(string userName)
    {
      User user = new User()
      {
        UserName = userName
      };
      return this.userDataAccess.CheckUserName(user);
    }

    public string CheckUserType(string userName)
    {
      User user = new User()
      {
        UserName = userName
      };

      return userDataAccess.CheckUserType(user);
    }

    public bool UserLoginValidate(string userName, string userPassword)
    {
      User user = new User()
      {
        UserName = userName,
        UserPassword = userPassword
      };

      return userDataAccess.UserLoginValidate(user);
    }
  }
}
