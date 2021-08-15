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

    public List<Income> GetWeeklyIncomeList(User user)
    {
      List<Income> allIncomeList = incomeDataAccess.GetIncomeList(user);
      List<Income> weeklyIncomeList = new List<Income>();
      foreach(Income income in allIncomeList)
      {
        if ((DateTime.Now - income.Date).TotalDays < 7) weeklyIncomeList.Add(income);
      }
      return weeklyIncomeList;
    }

    public List<Income> GetMonthlyIncomeList(User user)
    {
      List<Income> allIncomeList = incomeDataAccess.GetIncomeList(user);
      List<Income> monthlyIncomeList = new List<Income>();
      foreach (Income income in allIncomeList)
      {
        if ((DateTime.Now - income.Date).TotalDays < 30) monthlyIncomeList.Add(income);
      }
      return monthlyIncomeList;
    }

    public List<Income> GetYearlyIncomeList(User user)
    {
      List<Income> allIncomeList = incomeDataAccess.GetIncomeList(user);
      List<Income> yearlyIncomeList = new List<Income>();
      foreach (Income income in allIncomeList)
      {
        if ((DateTime.Now - income.Date).TotalDays < 30) yearlyIncomeList.Add(income);
      }
      return yearlyIncomeList;
    }

    public int GetWeeklyIncome(User user)
    {
      int totalIncome = 0;
      List<Income> incomeList = GetIncomeList(user);
      List<Income> weeklyIncomeList = new List<Income>();
      foreach (Income income in incomeList)
      {
        if ((DateTime.Now - income.Date).TotalDays < 7) weeklyIncomeList.Add(income);
      }
      foreach (Income income in weeklyIncomeList)
      {
        totalIncome += income.Amount;
      }
      return totalIncome;
    }

    public int GetMonthlyIncome(User user)
    {
      int totalIncome = 0;
      List<Income> incomeList = GetIncomeList(user);
      List<Income> monthlyIncomeList = new List<Income>();
      foreach (Income income in incomeList)
      {
        if ((DateTime.Now - income.Date).TotalDays < 30) monthlyIncomeList.Add(income);
      }
      foreach (Income income in monthlyIncomeList)
      {
        totalIncome += income.Amount;
      }
      return totalIncome;
    }

    public int GetYearlyIncome(User user)
    {
      int totalIncome = 0;
      List<Income> incomeList = GetIncomeList(user);
      List<Income> yearlyIncomeList = new List<Income>();
      foreach (Income income in incomeList)
      {
        if ((DateTime.Now - income.Date).TotalDays < 365) yearlyIncomeList.Add(income);
      }
      foreach (Income income in yearlyIncomeList)
      {
        totalIncome += income.Amount;
      }
      return totalIncome;
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

      Transaction transaction = new Transaction()
      {
        UserName = income.UserName,
        Amount = income.Amount,
        TransactionType = "Income",
        Date = income.Date
      };
      TransactionServices transactionServices = new TransactionServices();
      success = transactionServices.AddTransaction(transaction);

      return success;
    }
  }
}
