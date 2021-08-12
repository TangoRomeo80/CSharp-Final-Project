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
