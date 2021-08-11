using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletBuddy.DB;
using WalletBuddy.Model;

namespace WalletBuddy.Executor
{
  class IncomeServices
  {
    IncomeDataAccess incomeDataAccess = new IncomeDataAccess();

    public IncomeServices()
    {
      this.incomeDataAccess = new IncomeDataAccess();
    }

    public List<Income> GetIncomeList(User user)
    {
      return incomeDataAccess.GetIncomeList(user);
    }

    public List<string> GetAccountNames(User user)
    {
      return incomeDataAccess.GetAccountNames(user);
    }

    public int AddIncome(Income income, User user)
    {
      int success = 0;
      success = incomeDataAccess.AddIncome(income);
      Account account = new Account()
      {
        AccountName = income.AccountName
      };
      AccountServices accountServices = new AccountServices();
      success = accountServices.AddIncomeToAccount(account, user, income.Amount);
      return success;
    }
  }
}
