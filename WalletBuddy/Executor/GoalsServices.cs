using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletBuddy.DB;
using WalletBuddy.Model;

namespace WalletBuddy.Executor
{
  class GoalsServices
  {
    GoalsDataAccess goalsDataAccess = new GoalsDataAccess();

    public GoalsServices()
    {
      this.goalsDataAccess = new GoalsDataAccess();
    }

    public List<Goals> GetGoalsList(User user)
    {
      return goalsDataAccess.GetGoalsList(user);
    }

    public int AddGoals(Goals goals)
    {
      return goalsDataAccess.AddGoals(goals);
    }

    public void UpdateGoalsList(User user)
    {
      goalsDataAccess.UpdateGoalsList(user);
    }

  }
}
