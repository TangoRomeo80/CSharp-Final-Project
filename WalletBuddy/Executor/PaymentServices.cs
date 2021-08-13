using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletBuddy.DB;
using WalletBuddy.Model;

namespace WalletBuddy.Executor
{
  class PaymentServices
  {
    PaymentDataAccess paymentDataAccess = new PaymentDataAccess();

    public PaymentServices()
    {
      this.paymentDataAccess = new PaymentDataAccess();
    }

    public List<Payment> GetPaymentList(User user)
    {
      return paymentDataAccess.GetPaymentList(user);
    }

    public int AddPayment(Payment payment)
    {
      return paymentDataAccess.AddPayment(payment);
    }
  }
}
