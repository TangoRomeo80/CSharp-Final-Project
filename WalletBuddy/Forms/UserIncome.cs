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
  public partial class UserIncome : Form
  {
    private User user;

    public UserIncome(User user)
    {
      InitializeComponent();
      this.user = user;
      Load += new EventHandler(Init_Load);
    }

    public void UpdateDataGrid()
    {
      incomeDataGridView.Rows.Clear();

      IncomeServices incomeServices = new IncomeServices();
      List<Income> incomeList = incomeServices.GetIncomeList(this.user);
      foreach(Income income in incomeList)
      {
        incomeDataGridView.Rows.Add(income.TransactionId, income.PaymentFrom, income.Description, income.AccountName, income.Amount, income.Date.ToString("dd/MM/yyyy"));
      }
    }

    private void Init_Load(object sender, System.EventArgs e)
    {
      UpdateDataGrid();
    }

    private void addIncomeButton_Click(object sender, EventArgs e)
    {
      AddIncome addIncome = new AddIncome(this.user, this);
      addIncome.Show();
    }

  }
}
