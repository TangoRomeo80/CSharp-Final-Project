using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WalletBuddy.Executor;
using WalletBuddy.Model;

namespace WalletBuddy.Forms
{
  public partial class UserGoals : Form
  {
    private User user;

    public UserGoals(User user)
    {
      InitializeComponent();
      this.user = user;
      Load += new EventHandler(Init_Load);
    }

    public void UpdateDataGrid()
    {
      goalDataGridView.Rows.Clear();

      GoalsServices goalsServices = new GoalsServices();
      goalsServices.UpdateGoalsList(this.user);
      List<Goals> goalsList = goalsServices.GetGoalsList(this.user);
      foreach (Goals goal in goalsList)
      {
        goalDataGridView.Rows.Add(goal.GoalDuration, goal.TargetSavings, goal.CurrentExpense, goal.RemainingExpense);
      }
    }

    private void Init_Load(object sender, System.EventArgs e)
    {
      UpdateDataGrid();
    }

    private void addGoalButton_Click(object sender, EventArgs e)
    {
      AddGoal addGoal = new AddGoal(this.user, this);
      addGoal.Show();
    }
  }
}
