using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletBuddy.DB;
using WalletBuddy.Model;

namespace WalletBuddy.Executor
{
  class TransactionServices
  {
    TransactionDataAccess transactionDataAccess = new TransactionDataAccess();

    public TransactionServices()
    {
      this.transactionDataAccess = new TransactionDataAccess();
    }

    public List<Transaction> GetAllTransactionList(User user)
    {
      return transactionDataAccess.GetAllTransactionList(user);
    }

    public int AddTransaction(Transaction transaction)
    {
      return transactionDataAccess.AddTransaction(transaction);
    }

  }
}
