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
  public partial class UserPayments : Form
  {
    private User user;

    public UserPayments(User user)
    {
      InitializeComponent();
      this.user = user;
      Load += new EventHandler(Init_Load);
    }

    public void UpdateDataGrid()
    {
      paymentDataGridView.Rows.Clear();

      PaymentServices paymentServices = new PaymentServices();
      List<Payment> paymentList = paymentServices.GetPaymentList(this.user);
      foreach (Payment payment in paymentList)
      {
        paymentDataGridView.Rows.Add(payment.PaymentName, payment.PaymentReciever, payment.Description, payment.Amount, payment.Date.ToString("dd/MM/yyyy"));
      }
    }

    private void Init_Load(object sender, System.EventArgs e)
    {
      UpdateDataGrid();
    }

    private void addPaymentButton_Click(object sender, EventArgs e)
    {
      AddPayment addPayment = new AddPayment(this.user, this);
      addPayment.Show();
    }
  }
}
