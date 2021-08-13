using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletBuddy.Model;
using System.Data.SqlClient;

namespace WalletBuddy.DB
{
  class PaymentDataAccess : DataAccess
  {
    public List<Payment> GetPaymentList(User user)
    {
      string query = "SELECT * FROM PAYMENT_TBL WHERE USER_NAME= '" + user.UserName + "'";
      SqlDataReader reader = GetData(query);
      List<Payment> paymentList = new List<Payment>();
      while (reader.Read())
      {
        Payment income = new Payment()
        {
          PaymentId = Convert.ToInt32(reader["PAYMENT_ID"]),
          UserName = reader["USER_NAME"].ToString(),
          Amount = Convert.ToInt32(reader["AMOUNT"]),
          PaymentReciever = reader["PAYMENT_RECIEVER"].ToString(),
          Description = reader["DESCRIPTION"].ToString(),
          PaymentName = reader["PAYMENT_NAME"].ToString(),
          Date = Convert.ToDateTime(reader["DATE"])
        };
        paymentList.Add(income);
      }
      return paymentList;
    }

    public int AddPayment(Payment payment)
    {
      string sql = "INSERT INTO PAYMENT_TBL(USER_NAME,PAYMENT_NAME,PAYMENT_RECIEVER,DESCRIPTION,AMOUNT,DATE) VALUES('" + payment.UserName + "','" + payment.PaymentName + "','" + payment.PaymentReciever + "','" + payment.Description + "','" + payment.Amount + "','" + payment.Date.ToString("yyyy-MM-dd HH:mm:ss.fff") + "')";
      return this.ExecuteQuery(sql);
    }

  }
}
