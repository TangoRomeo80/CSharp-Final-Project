using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletBuddy.DB;
using WalletBuddy.Model;

namespace WalletBuddy.Executor
{
  class AccountServices
  {
    AccountDataAccess accountDataAccess = new AccountDataAccess();

    public AccountServices()
    {
      this.accountDataAccess = new AccountDataAccess();
    }

    public List<Account> GetAccountList(User user)
    {
      return accountDataAccess.GetAccountList(user);
    }

    public int AddAccount(Account account)
    {
      return accountDataAccess.AddAccount(account);
    }

    public int RemoveAccount(User user, Account account)
    {
      return accountDataAccess.RemoveAccount(user, account);
    }

    public int AddIncomeToAccount(Account account, User user, int amount)
    {
      return accountDataAccess.AddIncomeToAccount(account, user, amount);
    }

    public int AddExpenseToAccount(Account account, User user, int amount)
    {
      return accountDataAccess.AddExpenseToAccount(account, user, amount);
    }

    public string CheckAccountName(Account account, User user)
    {
      return accountDataAccess.CheckAccountName(account, user);
    }

    public int CheckAccountBalance(Account account, User user)
    {
      return accountDataAccess.CheckAccountBalance(account, user);
    }

    public int TransferBalance(Account senderAccount, Account recieverAccount, User user, int amount)
    {
      int success = 0;
      success = AddIncomeToAccount(recieverAccount, user, amount);
      success = AddExpenseToAccount(senderAccount, user, amount);
      return success;
    }

  }
}
