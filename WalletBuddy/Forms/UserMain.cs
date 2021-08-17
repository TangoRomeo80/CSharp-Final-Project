using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using WalletBuddy.Model;
using WalletBuddy.Executor;

namespace WalletBuddy.Forms
{
  public partial class UserMain : KryptonForm
  {
    private Button currentButton;
    private Button previousButton;
    private Form activeForm;
    private User user;

    public UserMain(User user)
    {
      InitializeComponent();
      this.user = user;
      Load += new EventHandler(Init_Load);
    }


    //button select effects on click
    private void ActivateButton(object btnSender)
    {
      if (btnSender != null)
      {
        if (currentButton != (Button)btnSender)
        {
          DisableButton();
          Color color = Color.Blue;
          currentButton = (Button)btnSender;
          currentButton.Width = 115;
          currentButton.Height = 45;
          currentButton.BackColor = color;
          currentButton.ForeColor = Color.White;
          currentButton.Font = new System.Drawing.Font("Calibri", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          previousButton = (Button)btnSender;
        }
      }
    }

    //button disselect effects reversion
    private void DisableButton()
    {
      if (previousButton != null)
      {
        previousButton.Width = 112;
        previousButton.Height = 37;
        previousButton.BackColor = Color.White;
        previousButton.ForeColor = Color.DimGray;
        previousButton.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      }
    }

    //open form in windowPane
    private void OpenChildForm(Form childForm, object btnSender)
    {
      if (activeForm != null)
        activeForm.Close();
      ActivateButton(btnSender);
      activeForm = childForm;
      childForm.TopLevel = false;
      childForm.FormBorderStyle = FormBorderStyle.None;
      childForm.Dock = DockStyle.Fill;
      this.panelDesktopPane.Controls.Add(childForm);
      this.panelDesktopPane.Tag = childForm;
      childForm.BringToFront();
      childForm.Show();
    }

    //open user info in windowpane
    private void OpenUserInfo(Form childForm, object btnSender)
    {
      if (activeForm != null)
        activeForm.Close();
      DisableButton();
      activeForm = childForm;
      childForm.TopLevel = false;
      childForm.FormBorderStyle = FormBorderStyle.None;
      childForm.Dock = DockStyle.Fill;
      this.panelDesktopPane.Controls.Add(childForm);
      this.panelDesktopPane.Tag = childForm;
      childForm.BringToFront();
      childForm.Show();
    }

    private void Init_Load(object sender, System.EventArgs e)
    {
      UserServices userServices = new UserServices();
      this.topUserNameLabel.Text = this.user.UserName;
      this.userPicBox.Image = userServices.GetProfilePicture(this.user);
      UserDash childForm = new UserDash(this.user);
      if (activeForm != null)
        activeForm.Close();
      ActivateButton(dashButton);
      activeForm = childForm;
      childForm.TopLevel = false;
      childForm.FormBorderStyle = FormBorderStyle.None;
      childForm.Dock = DockStyle.Fill;
      this.panelDesktopPane.Controls.Add(childForm);
      this.panelDesktopPane.Tag = childForm;
      childForm.BringToFront();
      childForm.Show();
    }

    private void dashButton_Click(object sender, EventArgs e)
    {
      OpenChildForm(new UserDash(this.user), sender);
    }

    private void incomeButton_Click(object sender, EventArgs e)
    {
      OpenChildForm(new UserIncome(this.user), sender);
    }

    private void expenseButton_Click(object sender, EventArgs e)
    {
      OpenChildForm(new UserExpense(this.user), sender);
    }

    private void accountsButton_Click(object sender, EventArgs e)
    {
      OpenChildForm(new UserAccounts(this.user), sender);
    }

    private void paymentButton_Click(object sender, EventArgs e)
    {
      OpenChildForm(new UserPayments(this.user), sender);
    }

    private void recordsButton_Click(object sender, EventArgs e)
    {
      OpenChildForm(new UserRecords(this.user), sender);
    }

    private void goalsButton_Click(object sender, EventArgs e)
    {
      OpenChildForm(new UserGoals(this.user), sender);
    }

    private void settingsButton_Click(object sender, EventArgs e)
    {
      OpenUserInfo(new SettingsInfo(this.user), sender);
    }

    private void logOutLabel_Click(object sender, EventArgs e)
    {
      DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log out", MessageBoxButtons.YesNo);
      if (result == DialogResult.Yes)
      {
        LoginUser login = new LoginUser();
        login.Show();
        this.Hide();
      }
    }
  }
}
