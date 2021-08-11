using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletBuddy.Model;
using System.Data.SqlClient;

namespace WalletBuddy.DB
{
  class IncomeDataAccess : DataAccess
  {
    public List<Income> GetIncomeList(User user)
    {
      string query = "SELECT * FROM INCOME_TBL WHERE USER_NAME= '" + user.UserName + "'";
      SqlDataReader reader = GetData(query);
      List<Income> incomeList = new List<Income>();
      while (reader.Read())
      {
        Income income = new Income()
        {
          TransactionId = Convert.ToInt32(reader["TRANSACTION_ID"]),
          UserName = reader["USER_NAME"].ToString(),
          Amount = Convert.ToInt32(reader["AMOUNT"]),
          PaymentFrom = reader["PAYMENT_FROM"].ToString(),
          Description = reader["DESCRIPTION"].ToString(),
          AccountName = reader["ACCOUNT_NAME"].ToString(),
          Date = Convert.ToDateTime(reader["DATE"])
        };
        incomeList.Add(income);
      }
      return incomeList;
    }

    public List<string> GetAccountNames(User user)
    {
      string query = "SELECT * FROM ACCOUNT_TBL WHERE USER_NAME= '" + user.UserName + "'";
      SqlDataReader reader = GetData(query);
      List<string> accountNames = new List<string>();
      while (reader.Read())
      {
        string accountName = reader["ACCOUNT_NAME"].ToString();
        accountNames.Add(accountName);
      }
      return accountNames;
    }

    public int AddIncome(Income income)
    {
      string sql = "INSERT INTO INCOME_TBL(USER_NAME,AMOUNT,PAYMENT_FROM,DESCRIPTION,ACCOUNT_NAME,DATE) VALUES('" + income.UserName + "','" + income.Amount + "','" + income.PaymentFrom + "','" + income.Description + "','" + income.AccountName + "','" + income.Date.ToString("yyyy-MM-dd HH:mm:ss.fff") + "')";
      return this.ExecuteQuery(sql);
    }

  }
}
