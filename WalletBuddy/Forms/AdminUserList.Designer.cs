
namespace WalletBuddy.Forms
{
  partial class AdminUserList
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUserList));
      this.userListDataGridView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
      this.UserNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.UserEmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.UserTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.panel1 = new System.Windows.Forms.Panel();
      this.removeButton = new WalletBuddy.CustomControl.RJButton();
      this.updateButton = new WalletBuddy.CustomControl.RJButton();
      this.userTypeTextBox = new WalletBuddy.CustomControl.RJTextBox();
      this.emailTextBox = new WalletBuddy.CustomControl.RJTextBox();
      this.userNameTextBox = new WalletBuddy.CustomControl.RJTextBox();
      this.editUserButton = new WalletBuddy.CustomControl.RJButton();
      this.userSearchTextBox = new WalletBuddy.CustomControl.RJTextBox();
      ((System.ComponentModel.ISupportInitialize)(this.userListDataGridView)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // userListDataGridView
      // 
      this.userListDataGridView.AllowUserToAddRows = false;
      this.userListDataGridView.AllowUserToDeleteRows = false;
      this.userListDataGridView.AllowUserToOrderColumns = true;
      this.userListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.userListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.userListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserNameColumn,
            this.UserEmailColumn,
            this.UserTypeColumn});
      this.userListDataGridView.Location = new System.Drawing.Point(12, 87);
      this.userListDataGridView.Name = "userListDataGridView";
      this.userListDataGridView.ReadOnly = true;
      this.userListDataGridView.Size = new System.Drawing.Size(540, 322);
      this.userListDataGridView.StateCommon.Background.Color1 = System.Drawing.Color.LightSkyBlue;
      this.userListDataGridView.StateCommon.Background.Color2 = System.Drawing.Color.LightSkyBlue;
      this.userListDataGridView.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
      this.userListDataGridView.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.DodgerBlue;
      this.userListDataGridView.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.DodgerBlue;
      this.userListDataGridView.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.Blue;
      this.userListDataGridView.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.Blue;
      this.userListDataGridView.TabIndex = 7;
      // 
      // UserNameColumn
      // 
      this.UserNameColumn.HeaderText = "User Name";
      this.UserNameColumn.Name = "UserNameColumn";
      this.UserNameColumn.ReadOnly = true;
      // 
      // UserEmailColumn
      // 
      this.UserEmailColumn.HeaderText = "User Email";
      this.UserEmailColumn.Name = "UserEmailColumn";
      this.UserEmailColumn.ReadOnly = true;
      // 
      // UserTypeColumn
      // 
      this.UserTypeColumn.HeaderText = "User Type";
      this.UserTypeColumn.Name = "UserTypeColumn";
      this.UserTypeColumn.ReadOnly = true;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.White;
      this.panel1.Controls.Add(this.removeButton);
      this.panel1.Controls.Add(this.updateButton);
      this.panel1.Controls.Add(this.userTypeTextBox);
      this.panel1.Controls.Add(this.emailTextBox);
      this.panel1.Controls.Add(this.userNameTextBox);
      this.panel1.Location = new System.Drawing.Point(568, 87);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(348, 322);
      this.panel1.TabIndex = 11;
      // 
      // removeButton
      // 
      this.removeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(5)))), ((int)(((byte)(227)))));
      this.removeButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(5)))), ((int)(((byte)(227)))));
      this.removeButton.BorderColor = System.Drawing.Color.Blue;
      this.removeButton.BorderRadius = 20;
      this.removeButton.BorderSize = 1;
      this.removeButton.FlatAppearance.BorderSize = 0;
      this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.removeButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.removeButton.ForeColor = System.Drawing.Color.White;
      this.removeButton.Location = new System.Drawing.Point(74, 232);
      this.removeButton.Margin = new System.Windows.Forms.Padding(2);
      this.removeButton.Name = "removeButton";
      this.removeButton.Size = new System.Drawing.Size(205, 50);
      this.removeButton.TabIndex = 9;
      this.removeButton.Text = "Remove";
      this.removeButton.TextColor = System.Drawing.Color.White;
      this.removeButton.UseVisualStyleBackColor = false;
      this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
      // 
      // updateButton
      // 
      this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(5)))), ((int)(((byte)(227)))));
      this.updateButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(5)))), ((int)(((byte)(227)))));
      this.updateButton.BorderColor = System.Drawing.Color.Blue;
      this.updateButton.BorderRadius = 20;
      this.updateButton.BorderSize = 1;
      this.updateButton.FlatAppearance.BorderSize = 0;
      this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.updateButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.updateButton.ForeColor = System.Drawing.Color.White;
      this.updateButton.Location = new System.Drawing.Point(74, 165);
      this.updateButton.Margin = new System.Windows.Forms.Padding(2);
      this.updateButton.Name = "updateButton";
      this.updateButton.Size = new System.Drawing.Size(205, 50);
      this.updateButton.TabIndex = 9;
      this.updateButton.Text = "Update";
      this.updateButton.TextColor = System.Drawing.Color.White;
      this.updateButton.UseVisualStyleBackColor = false;
      this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
      // 
      // userTypeTextBox
      // 
      this.userTypeTextBox.BackColor = System.Drawing.SystemColors.Window;
      this.userTypeTextBox.BorderColor = System.Drawing.Color.CornflowerBlue;
      this.userTypeTextBox.BorderFocusColor = System.Drawing.Color.Blue;
      this.userTypeTextBox.BorderRadius = 10;
      this.userTypeTextBox.BorderSize = 2;
      this.userTypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.userTypeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.userTypeTextBox.Location = new System.Drawing.Point(4, 101);
      this.userTypeTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.userTypeTextBox.Multiline = false;
      this.userTypeTextBox.Name = "userTypeTextBox";
      this.userTypeTextBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
      this.userTypeTextBox.PasswordChar = false;
      this.userTypeTextBox.PlaceholderColor = System.Drawing.Color.Silver;
      this.userTypeTextBox.PlaceholderText = "New User Type";
      this.userTypeTextBox.Size = new System.Drawing.Size(340, 29);
      this.userTypeTextBox.TabIndex = 8;
      this.userTypeTextBox.Texts = "";
      this.userTypeTextBox.UnderlinedStyle = false;
      // 
      // emailTextBox
      // 
      this.emailTextBox.BackColor = System.Drawing.SystemColors.Window;
      this.emailTextBox.BorderColor = System.Drawing.Color.CornflowerBlue;
      this.emailTextBox.BorderFocusColor = System.Drawing.Color.Blue;
      this.emailTextBox.BorderRadius = 10;
      this.emailTextBox.BorderSize = 2;
      this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.emailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.emailTextBox.Location = new System.Drawing.Point(4, 52);
      this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.emailTextBox.Multiline = false;
      this.emailTextBox.Name = "emailTextBox";
      this.emailTextBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
      this.emailTextBox.PasswordChar = false;
      this.emailTextBox.PlaceholderColor = System.Drawing.Color.Silver;
      this.emailTextBox.PlaceholderText = "New E-mail";
      this.emailTextBox.Size = new System.Drawing.Size(340, 29);
      this.emailTextBox.TabIndex = 8;
      this.emailTextBox.Texts = "";
      this.emailTextBox.UnderlinedStyle = false;
      // 
      // userNameTextBox
      // 
      this.userNameTextBox.BackColor = System.Drawing.SystemColors.Window;
      this.userNameTextBox.BorderColor = System.Drawing.Color.CornflowerBlue;
      this.userNameTextBox.BorderFocusColor = System.Drawing.Color.Blue;
      this.userNameTextBox.BorderRadius = 10;
      this.userNameTextBox.BorderSize = 2;
      this.userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.userNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.userNameTextBox.Location = new System.Drawing.Point(4, 4);
      this.userNameTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.userNameTextBox.Multiline = false;
      this.userNameTextBox.Name = "userNameTextBox";
      this.userNameTextBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
      this.userNameTextBox.PasswordChar = false;
      this.userNameTextBox.PlaceholderColor = System.Drawing.Color.Silver;
      this.userNameTextBox.PlaceholderText = "New User Name";
      this.userNameTextBox.Size = new System.Drawing.Size(340, 29);
      this.userNameTextBox.TabIndex = 8;
      this.userNameTextBox.Texts = "";
      this.userNameTextBox.UnderlinedStyle = false;
      // 
      // editUserButton
      // 
      this.editUserButton.BackColor = System.Drawing.Color.White;
      this.editUserButton.BackgroundColor = System.Drawing.Color.White;
      this.editUserButton.BorderColor = System.Drawing.Color.DodgerBlue;
      this.editUserButton.BorderRadius = 10;
      this.editUserButton.BorderSize = 1;
      this.editUserButton.FlatAppearance.BorderSize = 0;
      this.editUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.editUserButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.editUserButton.ForeColor = System.Drawing.Color.SlateGray;
      this.editUserButton.Image = ((System.Drawing.Image)(resources.GetObject("editUserButton.Image")));
      this.editUserButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.editUserButton.Location = new System.Drawing.Point(257, 36);
      this.editUserButton.Margin = new System.Windows.Forms.Padding(2);
      this.editUserButton.Name = "editUserButton";
      this.editUserButton.Size = new System.Drawing.Size(148, 29);
      this.editUserButton.TabIndex = 9;
      this.editUserButton.Text = "Edit/Remove User";
      this.editUserButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.editUserButton.TextColor = System.Drawing.Color.SlateGray;
      this.editUserButton.UseVisualStyleBackColor = false;
      this.editUserButton.Click += new System.EventHandler(this.editUserButton_Click);
      // 
      // userSearchTextBox
      // 
      this.userSearchTextBox.BackColor = System.Drawing.SystemColors.Window;
      this.userSearchTextBox.BorderColor = System.Drawing.Color.CornflowerBlue;
      this.userSearchTextBox.BorderFocusColor = System.Drawing.Color.Blue;
      this.userSearchTextBox.BorderRadius = 10;
      this.userSearchTextBox.BorderSize = 2;
      this.userSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.userSearchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.userSearchTextBox.Location = new System.Drawing.Point(12, 36);
      this.userSearchTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.userSearchTextBox.Multiline = false;
      this.userSearchTextBox.Name = "userSearchTextBox";
      this.userSearchTextBox.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
      this.userSearchTextBox.PasswordChar = false;
      this.userSearchTextBox.PlaceholderColor = System.Drawing.Color.Silver;
      this.userSearchTextBox.PlaceholderText = "Search Username...";
      this.userSearchTextBox.Size = new System.Drawing.Size(239, 29);
      this.userSearchTextBox.TabIndex = 8;
      this.userSearchTextBox.Texts = "";
      this.userSearchTextBox.UnderlinedStyle = false;
      this.userSearchTextBox._TextChanged += new System.EventHandler(this.userSearchTextBox__TextChanged);
      // 
      // AdminUserList
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(928, 421);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.editUserButton);
      this.Controls.Add(this.userSearchTextBox);
      this.Controls.Add(this.userListDataGridView);
      this.Name = "AdminUserList";
      this.Text = "AdminUserList";
      ((System.ComponentModel.ISupportInitialize)(this.userListDataGridView)).EndInit();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private ComponentFactory.Krypton.Toolkit.KryptonDataGridView userListDataGridView;
    private System.Windows.Forms.DataGridViewTextBoxColumn UserNameColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn UserEmailColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn UserTypeColumn;
    private CustomControl.RJTextBox userSearchTextBox;
    private System.Windows.Forms.Panel panel1;
    private CustomControl.RJTextBox userTypeTextBox;
    private CustomControl.RJTextBox emailTextBox;
    private CustomControl.RJTextBox userNameTextBox;
    private CustomControl.RJButton removeButton;
    private CustomControl.RJButton updateButton;
    private CustomControl.RJButton editUserButton;
  }
}