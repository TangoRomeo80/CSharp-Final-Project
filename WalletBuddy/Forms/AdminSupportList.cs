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
  public partial class AdminSupportList : Form
  {
    private User user;

    public AdminSupportList(User user)
    {
      InitializeComponent();
      this.user = user;
      Load += new EventHandler(Init_Load);
    }

    public void UpdateDataGrid()
    {
      tokenDataGridView.Rows.Clear();

      TokenServices tokenServices = new TokenServices();
      List<SupportToken> tokenList = tokenServices.GetAllTokenList();
      foreach (SupportToken token in tokenList)
      {
        tokenDataGridView.Rows.Add(token.TokenId, token.SenderName, token.SenderEmail, token.Description, token.Status);
      }
    }

    private void Init_Load(object sender, System.EventArgs e)
    {
      UpdateDataGrid();
    }

    private void completeButton_Click(object sender, EventArgs e)
    {
      TokenServices tokenServices = new TokenServices();
      if (tokenDataGridView.SelectedRows.Count <= 0)
      {
        MessageBox.Show("No user is selected.");
      }
      else
      {
        SupportToken token = new SupportToken()
        {
          TokenId = Convert.ToInt32(tokenDataGridView.SelectedRows[0].Cells[0].Value)
        };
        int success = tokenServices.ChangeStatus(token);
        if(success > 0)
        {
          MessageBox.Show("Token status changed successfully");
          UpdateDataGrid();
        }
        else
        {
          MessageBox.Show("An Unexpected error Occured. Status could not be changed.");
        }

      }
    }
  }
}
