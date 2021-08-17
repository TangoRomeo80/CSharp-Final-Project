using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalletBuddy.Model
{
  class Transaction
  { 
    //Properties
    public int TransactionId { set; get; }
    public int UserId { set; get; }
    public int Amount { set; get; }
    public string TransactionType { set; get; }
    public DateTime Date { set; get; }

    //default constructor
    public Transaction()
    {
      TransactionId = 0;
      UserId = 0;
      Amount = 0;
      TransactionType = "";
      Date = DateTime.Now;
    }

    //Parameterized constructor
    public Transaction(int transactionId, int userId, int amount, string transactionType, DateTime date)
    {
      TransactionId = transactionId;
      UserId = userId;
      Amount = amount;
      TransactionType = transactionType;
      Date = date;
    }

  }
}
