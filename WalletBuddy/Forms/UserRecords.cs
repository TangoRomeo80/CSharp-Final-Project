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
  public partial class UserRecords : Form
  {
    private User user;

    public UserRecords(User user)
    {
      InitializeComponent();
      this.user = user;
      Load += new EventHandler(Init_Load);
    }

    public void UpdateDataGrid()
    {
      recordsDataGridView.Rows.Clear();

      TransactionServices transactionServices = new TransactionServices();
      List<Transaction> transactionList = transactionServices.GetAllTransactionList(this.user);
      foreach (Transaction transaction in transactionList)
      {
        recordsDataGridView.Rows.Add(transaction.TransactionId, transaction.TransactionType, transaction.Amount, transaction.Date.ToString("dd/MM/yyyy"));
      }
    }

    private void Init_Load(object sender, System.EventArgs e)
    {
      UpdateDataGrid();
    }



  }
}
