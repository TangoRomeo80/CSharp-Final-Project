using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletBuddy.DB;
using WalletBuddy.Model;

namespace WalletBuddy.Executor
{
  class ExpenseServices
  {
    ExpenseDataAccess expenseDataAccess = new ExpenseDataAccess();

    public ExpenseServices()
    {
      this.expenseDataAccess = new ExpenseDataAccess();
    }

    public List<Expense> GetExpenseList(User user)
    {
      return expenseDataAccess.GetExpenseList(user);
    }

    public List<Expense> GetWeeklyExpenseList(User user)
    {
      List<Expense> allExpenseList = expenseDataAccess.GetExpenseList(user);
      List<Expense> weeklyExpenseList = new List<Expense>();
      foreach (Expense expense in allExpenseList)
      {
        if ((DateTime.Now - expense.Date).TotalDays < 7) weeklyExpenseList.Add(expense);
      }
      return weeklyExpenseList;
    }

    public List<Expense> GetMonthlyExpenseList(User user)
    {
      List<Expense> allExpenseList = expenseDataAccess.GetExpenseList(user);
      List<Expense> monthlyExpenseList = new List<Expense>();
      foreach (Expense expense in allExpenseList)
      {
        if ((DateTime.Now - expense.Date).TotalDays < 30) monthlyExpenseList.Add(expense);
      }
      return monthlyExpenseList;
    }

    public List<Expense> GetYearlyExpenseList(User user)
    {
      List<Expense> allExpenseList = expenseDataAccess.GetExpenseList(user);
      List<Expense> yearlyExpenseList = new List<Expense>();
      foreach (Expense expense in allExpenseList)
      {
        if ((DateTime.Now - expense.Date).TotalDays < 30) yearlyExpenseList.Add(expense);
      }
      return yearlyExpenseList;
    }

    public int GetWeeklyExpense(User user)
    {
      int totalExpense = 0;
      List<Expense> expenseList = GetExpenseList(user);
      List<Expense> weeklyExpenseList = new List<Expense>();
      foreach (Expense expense in expenseList)
      {
        if ((DateTime.Now - expense.Date).TotalDays < 7) weeklyExpenseList.Add(expense);
      }
      foreach (Expense expense in weeklyExpenseList)
      {
        totalExpense += expense.Amount;
      }
      return totalExpense;
    }

    public int GetMonthlyExpense(User user)
    {
      int totalExpense = 0;
      List<Expense> expenseList = GetExpenseList(user);
      List<Expense> monthlyExpenseList = new List<Expense>();
      foreach (Expense expense in expenseList)
      {
        if ((DateTime.Now - expense.Date).TotalDays < 30) monthlyExpenseList.Add(expense);
      }
      foreach (Expense expense in monthlyExpenseList)
      {
        totalExpense += expense.Amount;
      }
      return totalExpense;
    }

    public int GetYearlyExpense(User user)
    {
      int totalExpense = 0;
      List<Expense> expenseList = GetExpenseList(user);
      List<Expense> yearlyExpenseList = new List<Expense>();
      foreach (Expense expense in expenseList)
      {
        if ((DateTime.Now - expense.Date).TotalDays < 365) yearlyExpenseList.Add(expense);
      }
      foreach (Expense expense in yearlyExpenseList)
      {
        totalExpense += expense.Amount;
      }
      return totalExpense;
    }

    public List<string> GetAccountNames(User user)
    {
      return expenseDataAccess.GetAccountNames(user);
    }

    public int AddExpense(Expense expense, User user)
    {
      int success = 0;
      success = expenseDataAccess.AddExpense(expense);
      Account account = new Account()
      {
        AccountName = expense.AccountName
      };
      AccountServices accountServices = new AccountServices();
      success = accountServices.AddExpenseToAccount(account, user, expense.Amount);

      Transaction transaction = new Transaction()
      {
        UserName = expense.UserName,
        Amount = expense.Amount,
        TransactionType = "Expense",
        Date = expense.Date
      };
      TransactionServices transactionServices = new TransactionServices();
      success = transactionServices.AddTransaction(transaction);

      return success;
    }

  }
}
