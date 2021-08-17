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
  public partial class AddGoal : Form
  {
    private User user;
    private UserGoals parentForm;

    public AddGoal(User user, UserGoals parentForm)
    {
      InitializeComponent();
      this.user = user;
      this.parentForm = parentForm;
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void addButton_Click(object sender, EventArgs e)
    {
      if (targetSavingTextBox.Texts == "")
      {
        MessageBox.Show("Target savings fields cannot be empty.");
      }
      else if (durationComboBox.SelectedIndex < 0)
      {
        MessageBox.Show("A duration for the goal needs to be selected.");
      }
      else
      {
        GoalsServices goalsServices = new GoalsServices();
        Goals goal = new Goals()
        {
          UserId = user.UserId,
          GoalDuration = durationComboBox.SelectedItem.ToString(),
          TargetSavings = Convert.ToInt32(targetSavingTextBox.Texts),
          
        };
        int success = goalsServices.AddGoals(goal);
        if (success > 0)
        {
          targetSavingTextBox.Texts = "";
          MessageBox.Show("Goals record added successfully");
          parentForm.UpdateDataGrid();
        }
        else
        {
          MessageBox.Show("An Unexpected error Occured. Record could not be added.");
        }
      }
    }
  }
}
