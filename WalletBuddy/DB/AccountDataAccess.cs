using System;
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
    public List<Account> GetAccountList(User user)
    {
      string query = "SELECT * FROM ACCOUNT_TBL WHERE USER_ID= '" + user.UserId + "'";
      SqlDataReader reader = GetData(query);
      List<Account> accountList = new List<Account>();
      while (reader.Read())
      {
        Account account = new Account()
        {
          AccountId = Convert.ToInt32(reader["ACCOUNT_ID"]),
          UserId = Convert.ToInt32(reader["USER_ID"]),
          StartingAmount = Convert.ToInt32(reader["STARTING_AMOUNT"]),
          AccountName = reader["ACCOUNT_NAME"].ToString(),
          Balance = Convert.ToInt32(reader["BALANCE"]),
          AccountDescription = reader["ACCOUNT_DESCRIPTION"].ToString()
        };
        accountList.Add(account);
      }
      return accountList;
    }

    public int AddAccount(Account account)
    {
      string sql = "INSERT INTO ACCOUNT_TBL(USER_ID,ACCOUNT_NAME,ACCOUNT_DESCRIPTION,STARTING_AMOUNT,BALANCE) VALUES('" + account.UserId + "','" + account.AccountName + "','" + account.AccountDescription + "','" + account.StartingAmount + "','" + account.Balance + "')";
      return this.ExecuteQuery(sql);
    }

    public int RemoveAccount(User user, Account account)
    {
      string sql = "DELETE FROM ACCOUNT_TBL WHERE ACCOUNT_NAME= '" + account.AccountName + "' AND USER_ID = '" + user.UserId + "'";
      return this.ExecuteQuery(sql);
    }

    public int AddIncomeToAccount(Account account, User user, int amount)
    {
      string query = "SELECT * FROM ACCOUNT_TBL WHERE ACCOUNT_NAME= '" + account.AccountName + "' AND USER_ID = '" + user.UserId + "'";
      SqlDataReader reader = GetData(query);
      int balance = 0;
      while (reader.Read())
      {
        balance = Convert.ToInt32(reader["BALANCE"]);
      }
      balance += amount;
      string query2 = "UPDATE ACCOUNT_TBL SET BALANCE = '" + balance + "' WHERE ACCOUNT_NAME= '" + account.AccountName + "' AND USER_ID = '" + user.UserId + "'";
      return this.ExecuteQuery(query2);
    }

    public int AddExpenseToAccount(Account account, User user, int amount)
    {
      string query = "SELECT * FROM ACCOUNT_TBL WHERE ACCOUNT_NAME= '" + account.AccountName + "' AND USER_ID = '" + user.UserId + "'";
      SqlDataReader reader = GetData(query);
      int balance = 0;
      while (reader.Read())
      {
        balance = Convert.ToInt32(reader["BALANCE"]);
      }
      balance -= amount;
      string query2 = "UPDATE ACCOUNT_TBL SET BALANCE = '" + balance + "' WHERE ACCOUNT_NAME= '" + account.AccountName + "' AND USER_ID = '" + user.UserId + "'";
      return this.ExecuteQuery(query2);
    }

    public string CheckAccountName(Account account, User user)
    {
      string query = "SELECT * FROM ACCOUNT_TBL WHERE ACCOUNT_NAME= '" + account.AccountName + "' AND USER_ID = '" + user.UserId + "'";
      SqlDataReader reader = GetData(query);
      if (reader.Read())
      {
        return reader["ACCOUNT_NAME"].ToString();
      }
      return null;
    }

    public int CheckAccountBalance(Account account, User user)
    {
      string query = "SELECT * FROM ACCOUNT_TBL WHERE ACCOUNT_NAME= '" + account.AccountName + "' AND USER_ID = '" + user.UserId + "'";
      SqlDataReader reader = GetData(query);
      if (reader.Read())
      {
        return Convert.ToInt32(reader["BALANCE"]);
      }
      return 0;
    }

  }
}
