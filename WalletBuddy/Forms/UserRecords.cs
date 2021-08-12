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
        recordsDataGridView.Rows.Add(transaction.TransactionType, transaction.Amount, transaction.Date.ToString("dd/MM/yyyy"));
      }
    }

    public void UpdateWeeklyDataGrid()
    {
      recordsDataGridView.Rows.Clear();

      TransactionServices transactionServices = new TransactionServices();
      List<Transaction> transactionList = transactionServices.GetAllTransactionList(this.user);
      List<Transaction> weeklyTransactionList = new List<Transaction>();
      foreach (Transaction transaction in transactionList)
      {
        if ((DateTime.Now - transaction.Date).TotalDays < 7) weeklyTransactionList.Add(transaction);
      }
      foreach (Transaction transaction in weeklyTransactionList)
      {
        recordsDataGridView.Rows.Add(transaction.TransactionType, transaction.Amount, transaction.Date.ToString("dd/MM/yyyy"));
      }
    }

    public void UpdateMonthlyDataGrid()
    {
      recordsDataGridView.Rows.Clear();

      TransactionServices transactionServices = new TransactionServices();
      List<Transaction> transactionList = transactionServices.GetAllTransactionList(this.user);
      List<Transaction> monthlyTransactionList = new List<Transaction>();
      foreach (Transaction transaction in transactionList)
      {
        if ((DateTime.Now - transaction.Date).TotalDays < 30) monthlyTransactionList.Add(transaction);
      }
      foreach (Transaction transaction in monthlyTransactionList)
      {
        recordsDataGridView.Rows.Add(transaction.TransactionType, transaction.Amount, transaction.Date.ToString("dd/MM/yyyy"));
      }
    }

    public void UpdateYearlyDataGrid()
    {
      recordsDataGridView.Rows.Clear();

      TransactionServices transactionServices = new TransactionServices();
      List<Transaction> transactionList = transactionServices.GetAllTransactionList(this.user);
      List<Transaction> yearlyTransactionList = new List<Transaction>();
      foreach (Transaction transaction in transactionList)
      {
        if ((DateTime.Now - transaction.Date).TotalDays < 365) yearlyTransactionList.Add(transaction);
      }
      foreach (Transaction transaction in yearlyTransactionList)
      {
        recordsDataGridView.Rows.Add(transaction.TransactionType, transaction.Amount, transaction.Date.ToString("dd/MM/yyyy"));
      }
    }


    private void Init_Load(object sender, System.EventArgs e)
    {
      UpdateDataGrid();
    }

    private void recordWeeklyRadio_CheckedChanged(object sender, EventArgs e)
    {
      if (recordWeeklyRadio.Checked) UpdateWeeklyDataGrid();
      else UpdateDataGrid();
    }

    private void recordMonthlyRadio_CheckedChanged(object sender, EventArgs e)
    {
      if (recordMonthlyRadio.Checked) UpdateMonthlyDataGrid();
      else UpdateDataGrid();
    }

    private void recordYearlyRadio_CheckedChanged(object sender, EventArgs e)
    {
      if (recordYearlyRadio.Checked) UpdateYearlyDataGrid();
      else UpdateDataGrid();
    }
  }
}
