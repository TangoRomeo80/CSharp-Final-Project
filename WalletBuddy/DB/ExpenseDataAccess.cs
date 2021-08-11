using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletBuddy.Model;
using System.Data.SqlClient;

namespace WalletBuddy.DB
{
  class ExpenseDataAccess : DataAccess
  {
    public List<Expense> GetExpenseList(User user)
    {
      string query = "SELECT * FROM EXPENSE_TBL WHERE USER_NAME= '" + user.UserName + "'";
      SqlDataReader reader = GetData(query);
      List<Expense> expenseList = new List<Expense>();
      while (reader.Read())
      {
        Expense expense = new Expense()
        {
          TransactionId = Convert.ToInt32(reader["TRANSACTION_ID"]),
          UserName = reader["USER_NAME"].ToString(),
          Amount = Convert.ToInt32(reader["AMOUNT"]),
          PaymentTo = reader["PAYMENT_TO"].ToString(),
          Description = reader["DESCRIPTION"].ToString(),
          AccountName = reader["ACCOUNT_NAME"].ToString(),
          Date = Convert.ToDateTime(reader["DATE"])
        };
        expenseList.Add(expense);
      }
      return expenseList;
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

    public int AddExpense(Expense expense)
    {
      string sql = "INSERT INTO EXPENSE_TBL(USER_NAME,AMOUNT,PAYMENT_TO,DESCRIPTION,ACCOUNT_NAME,DATE) VALUES('" + expense.UserName + "','" + expense.Amount + "','" + expense.PaymentTo + "','" + expense.Description + "','" + expense.AccountName + "','" + expense.Date.ToString("yyyy-MM-dd HH:mm:ss.fff") + "')";
      return this.ExecuteQuery(sql);
    }
  }
}
