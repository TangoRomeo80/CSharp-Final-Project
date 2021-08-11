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
    public int AddUser(User user)
    {
      string sql = "INSERT INTO USER_TBL(USER_NAME,USER_EMAIL,USER_PASSWORD,USER_TYPE) VALUES('" + user.UserName + "','" + user.UserEmail + "','" + user.UserPassword + "','" + user.UserType + "')";
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

  }
}
