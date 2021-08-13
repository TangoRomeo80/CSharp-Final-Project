using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletBuddy.Model;
using WalletBuddy.Executor;
using System.Data.SqlClient;

namespace WalletBuddy.DB
{
  class GoalsDataAccess : DataAccess
  {
    public List<Goals> GetGoalsList(User user)
    {
      string query = "SELECT * FROM GOALS_TBL WHERE USER_NAME= '" + user.UserName + "'";
      SqlDataReader reader = GetData(query);
      List<Goals> goalsList = new List<Goals>();
      while (reader.Read())
      {
        Goals goals = new Goals()
        {
          GoalId = Convert.ToInt32(reader["GOAL_ID"]),
          UserName = reader["USER_NAME"].ToString(),
          GoalDuration = reader["GOAL_DURATION"].ToString(),
          TargetSavings = Convert.ToInt32(reader["TARGET_SAVINGS"]),
          CurrentExpense = Convert.ToInt32(reader["CURRENT_EXPENSE"]),
          RemainingExpense = Convert.ToInt32(reader["REMAINING_EXPENSE"])
        };
        goalsList.Add(goals);
      }
      return goalsList;
    }

    public int AddGoals(Goals goals)
    {
      string sql = "INSERT INTO GOALS_TBL(USER_NAME,GOAL_DURATION,TARGET_SAVINGS,CURRENT_EXPENSE,REMAINING_EXPENSE) VALUES('" + goals.UserName + "','" + goals.GoalDuration + "','" + goals.TargetSavings + "','" + goals.CurrentExpense + "','" + goals.RemainingExpense + "')";
      return this.ExecuteQuery(sql);
    }

    public void UpdateGoalsList(User user)
    {
      IncomeServices incomeServices = new IncomeServices();
      ExpenseServices expenseServices = new ExpenseServices();
      List<Goals> prevGoalsList = GetGoalsList(user);
      foreach(Goals goal in prevGoalsList)
      {
        if(goal.GoalDuration == "Week")
        {
          goal.CurrentExpense = expenseServices.GetWeeklyExpense(user);
          string query = "UPDATE GOALS_TBL SET CURRENT_EXPENSE = '" + goal.CurrentExpense + "' WHERE GOAL_ID= '" + goal.GoalId + "' AND USER_NAME = '" + user.UserName + "'";
          this.ExecuteQuery(query);
          goal.RemainingExpense = incomeServices.GetWeeklyIncome(user) - goal.TargetSavings - goal.CurrentExpense;
          string query2 = "UPDATE GOALS_TBL SET REMAINING_EXPENSE = '" + goal.RemainingExpense + "' WHERE GOAL_ID= '" + goal.GoalId + "' AND USER_NAME = '" + user.UserName + "'";
          this.ExecuteQuery(query2);
        }

        else if (goal.GoalDuration == "Month")
        {
          goal.CurrentExpense = expenseServices.GetMonthlyExpense(user);
          string query = "UPDATE GOALS_TBL SET CURRENT_EXPENSE = '" + goal.CurrentExpense + "' WHERE GOAL_ID= '" + goal.GoalId + "' AND USER_NAME = '" + user.UserName + "'";
          this.ExecuteQuery(query);
          goal.RemainingExpense = incomeServices.GetMonthlyIncome(user) - goal.TargetSavings - goal.CurrentExpense;
          string query2 = "UPDATE GOALS_TBL SET REMAINING_EXPENSE = '" + goal.RemainingExpense + "' WHERE GOAL_ID= '" + goal.GoalId + "' AND USER_NAME = '" + user.UserName + "'";
          this.ExecuteQuery(query2);
        }

        else if (goal.GoalDuration == "Year")
        {
          goal.CurrentExpense = expenseServices.GetYearlyExpense(user);
          string query = "UPDATE GOALS_TBL SET CURRENT_EXPENSE = '" + goal.CurrentExpense + "' WHERE GOAL_ID= '" + goal.GoalId + "' AND USER_NAME = '" + user.UserName + "'";
          this.ExecuteQuery(query);
          goal.RemainingExpense = incomeServices.GetYearlyIncome(user) - goal.TargetSavings - goal.CurrentExpense;
          string query2 = "UPDATE GOALS_TBL SET REMAINING_EXPENSE = '" + goal.RemainingExpense + "' WHERE GOAL_ID= '" + goal.GoalId + "' AND USER_NAME = '" + user.UserName + "'";
          this.ExecuteQuery(query2);
        }

      }
    }

  }
}
