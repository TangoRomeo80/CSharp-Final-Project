using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WalletBuddy.Model;

namespace WalletBuddy.Forms
{
  public partial class UserDash : Form
  {
    private User user;

    public UserDash(User user)
    {
      InitializeComponent();
      this.user = user;
    }

  }
}
