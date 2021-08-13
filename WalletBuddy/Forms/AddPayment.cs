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
  public partial class AddPayment : Form
  {
    private User user;
    private UserPayments parentForm;

    public AddPayment(User user, UserPayments parentForm)
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
      if (paymentNameTextBox.Texts == "" || paymentRecieverTextBox.Texts == "" || descriptionTextBox.Texts == "" || paymentAmountTextBox.Texts == "")
      {
        MessageBox.Show("Payment name, payment reciever, amount or description fields cannot be empty.");
      }
      else
      {
        PaymentServices paymentServices = new PaymentServices();
        Payment payment = new Payment()
        {
          PaymentName = paymentNameTextBox.Texts,
          UserName = user.UserName,
          PaymentReciever = paymentRecieverTextBox.Texts,
          Description = descriptionTextBox.Texts,
          Amount = Convert.ToInt32(paymentAmountTextBox.Texts),
          Date = dueDatePicker.Value
        };
        int success = paymentServices.AddPayment(payment);
        if(success > 0)
        {
          paymentNameTextBox.Texts = "";
          paymentRecieverTextBox.Texts = "";
          descriptionTextBox.Texts = "";
          paymentAmountTextBox.Texts = "";
          MessageBox.Show("Payment record added successfully");
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
