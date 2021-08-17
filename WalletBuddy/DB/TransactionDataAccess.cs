using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletBuddy.Model;
using System.Data.SqlClient;

namespace WalletBuddy.DB
{
  class TransactionDataAccess : DataAccess
  {
    public List<Transaction> GetAllTransactionList(User user)
    {
      string query = "SELECT * FROM TRANSACTION_TBL WHERE USER_ID= '" + user.UserId + "'";
      SqlDataReader reader = GetData(query);
      List<Transaction> transactionList = new List<Transaction>();
      while (reader.Read())
      {
        Transaction transaction = new Transaction()
        {
          TransactionId = Convert.ToInt32(reader["TRANSACTION_ID"]),
          UserId = Convert.ToInt32(reader["USER_ID"]),
          Amount = Convert.ToInt32(reader["AMOUNT"]),
          TransactionType = reader["TRANSACTION_TYPE"].ToString(),
          Date = Convert.ToDateTime(reader["DATE"])
        };
        transactionList.Add(transaction);
      }
      return transactionList;
    }

    public int AddTransaction(Transaction transaction)
    {
      string sql = "INSERT INTO TRANSACTION_TBL(USER_ID,AMOUNT,TRANSACTION_TYPE,DATE) VALUES('" + transaction.UserId + "','" + transaction.Amount + "','" + transaction.TransactionType + "','" + transaction.Date.ToString("yyyy-MM-dd HH:mm:ss.fff") + "')";
      return this.ExecuteQuery(sql);
    }

  }
}
