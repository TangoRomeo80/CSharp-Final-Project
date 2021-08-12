﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletBuddy.Model;
using System.Data.SqlClient;

namespace WalletBuddy.DB
{
  class AccountDataAccess : DataAccess
  {
    public int AddIncomeToAccount(Account account, User user, int amount)
    {
      string query = "SELECT * FROM ACCOUNT_TBL WHERE ACCOUNT_NAME= '" + account.AccountName + "' AND USER_NAME = '" + user.UserName + "'";
      SqlDataReader reader = GetData(query);
      int balance = 0;
      while (reader.Read())
      {
        balance = Convert.ToInt32(reader["BALANCE"]);
      }
      balance += amount;
      string query2 = "UPDATE ACCOUNT_TBL SET BALANCE = '" + balance + "' WHERE ACCOUNT_NAME= '" + account.AccountName + "' AND USER_NAME = '" + user.UserName + "'";
      return this.ExecuteQuery(query2);
    }

    public int AddExpenseToAccount(Account account, User user, int amount)
    {
      string query = "SELECT * FROM ACCOUNT_TBL WHERE ACCOUNT_NAME= '" + account.AccountName + "' AND USER_NAME = '" + user.UserName + "'";
      SqlDataReader reader = GetData(query);
      int balance = 0;
      while (reader.Read())
      {
        balance = Convert.ToInt32(reader["BALANCE"]);
      }
      balance -= amount;
      string query2 = "UPDATE ACCOUNT_TBL SET BALANCE = '" + balance + "' WHERE ACCOUNT_NAME= '" + account.AccountName + "' AND USER_NAME = '" + user.UserName + "'";
      return this.ExecuteQuery(query2);
    }
  }
}