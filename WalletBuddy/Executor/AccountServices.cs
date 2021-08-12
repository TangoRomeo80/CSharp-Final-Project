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

  }
}
