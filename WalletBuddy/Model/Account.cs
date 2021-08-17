using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalletBuddy.Model
{
  class Account
  {
    //properties
    public int AccountId { set; get; }
    public int UserId { set; get; }
    public string AccountName { set; get; }
    public string AccountDescription { set; get; }
    public int StartingAmount { set; get; }
    public int Balance { set; get; }

    //default constructor
    public Account()
    {
      AccountId = 0;
      UserId = 0;
      AccountName = "";
      AccountDescription = "";
      StartingAmount = 0;
      Balance = 0;
    }

    //parameterized constructor
    public Account(int accountId, int userId, string accountName, string accountDescription, int startingAmount, int balance)
    {
      AccountId = accountId;
      UserId = userId;
      AccountName = accountName;
      AccountDescription = accountDescription;
      StartingAmount = startingAmount;
      Balance = balance;
    }

  }
}
