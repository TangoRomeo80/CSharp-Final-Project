using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletBuddy.Model;
using System.Data.SqlClient;

namespace WalletBuddy.DB
{
  class UserDataAccess : DataAccess
  {

    public List<User> GetAllUserList()
    {
      string query = "SELECT * FROM USER_TBL";
      SqlDataReader reader = GetData(query);
      List<User> userList = new List<User>();
      while (reader.Read())
      {
        User user = new User()
        {
          UserId = Convert.ToInt32(reader["USER_ID"]),
          UserName = reader["USER_NAME"].ToString(),
          UserEmail = reader["USER_EMAIL"].ToString(),
          UserPassword = reader["USER_PASSWORD"].ToString(),
          UserType = reader["USER_TYPE"].ToString()
        };
        userList.Add(user);
      }
      return userList;
    }

    public int AddUser(User user)
    {
      string sql = "INSERT INTO USER_TBL(USER_NAME,USER_EMAIL,USER_PASSWORD,USER_TYPE) VALUES('" + user.UserName + "','" + user.UserEmail + "','" + user.UserPassword + "','" + user.UserType + "')";
      return this.ExecuteQuery(sql);
    }

    public int RemoveUser(User user)
    {
      string sql = "DELETE FROM USER_TBL WHERE USER_NAME= '" + user.UserName + "'";
      return this.ExecuteQuery(sql);
    }

    public string CheckUserName(User user)
    {
      string query = "SELECT * FROM USER_TBL WHERE USER_NAME= '" + user.UserName + "'";
      SqlDataReader reader = GetData(query);
      if (reader.Read())
      {
        return reader["USER_NAME"].ToString();
      }
      return null;
    }

    public string CheckUserType(User user)
    {
      string query = "SELECT * FROM USER_TBL WHERE USER_NAME='" + user.UserName + "'";
      SqlDataReader reader = GetData(query);
      if (reader.Read())
      {
        return reader["USER_TYPE"].ToString();
      }
      else
      {
        return null;
      }
    }

    public bool UserLoginValidate(User user)
    {
      string query = "SELECT * FROM USER_TBL WHERE USER_NAME='" + user.UserName + "'";
      SqlDataReader reader = GetData(query);
      if (reader.Read())
      {
        return (reader["USER_PASSWORD"].ToString() == user.UserPassword);
      }
      else
      {
        return false;
      }
    }

    public User GetUserInfo(User user)
    {
      string query = "SELECT * FROM USER_TBL WHERE USER_NAME='" + user.UserName + "'";
      SqlDataReader reader = GetData(query);
      if (reader.Read())
      {
        User userToReturn = new User()
        {
          UserId = Convert.ToInt32(reader["USER_ID"]),
          UserName = reader["USER_NAME"].ToString(),
          UserEmail = reader["USER_EMAIL"].ToString(),
          UserType = reader["USER_TYPE"].ToString(),
          UserPassword = reader["USER_PASSWORD"].ToString()
        };
        return userToReturn;
      }
      else
      {
        return null;
      }
    }

    public int ChangeInfo(User user, User userToModify)
    {
      int success = 0;
      string query = "UPDATE USER_TBL SET USER_TYPE = '" + user.UserType + "' WHERE USER_NAME = '" + userToModify.UserName + "'";
      success = this.ExecuteQuery(query);
      query = "UPDATE USER_TBL SET USER_EMAIL = '" + user.UserEmail + "' WHERE USER_NAME = '" + userToModify.UserName + "'";
      success = this.ExecuteQuery(query);
      query = "UPDATE USER_TBL SET USER_NAME = '" + user.UserName + "' WHERE USER_NAME = '" + userToModify.UserName + "'";
      success = this.ExecuteQuery(query);

      return success;
    }

    public int ChangePassword(User user, User userToModify)
    {
      string query = "UPDATE USER_TBL SET USER_PASSWORD = '" + user.UserPassword + "' WHERE USER_NAME = '" + userToModify.UserName + "'";
      return this.ExecuteQuery(query);
    }

  }
}
