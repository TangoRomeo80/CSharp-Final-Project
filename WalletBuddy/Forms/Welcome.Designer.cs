
namespace WalletBuddy.Forms
{
  partial class Welcome
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.titleLabel = new System.Windows.Forms.Label();
      this.tagLabel1 = new System.Windows.Forms.Label();
      this.tagLabel2 = new System.Windows.Forms.Label();
      this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.aboutButton = new WalletBuddy.CustomControl.RJButton();
      this.startButton = new WalletBuddy.CustomControl.RJButton();
      this.aboutUsButton = new WalletBuddy.CustomControl.RJButton();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      this.SuspendLayout();
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(44, -3);
      this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(104, 131);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 2;
      this.pictureBox1.TabStop = false;
      // 
      // titleLabel
      // 
      this.titleLabel.AutoSize = true;
      this.titleLabel.BackColor = System.Drawing.Color.Transparent;
      this.titleLabel.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.titleLabel.ForeColor = System.Drawing.Color.Blue;
      this.titleLabel.Location = new System.Drawing.Point(152, 33);
      this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.titleLabel.Name = "titleLabel";
      this.titleLabel.Size = new System.Drawing.Size(295, 59);
      this.titleLabel.TabIndex = 3;
      this.titleLabel.Text = "Wallet Buddy";
      // 
      // tagLabel1
      // 
      this.tagLabel1.AutoSize = true;
      this.tagLabel1.BackColor = System.Drawing.Color.Transparent;
      this.tagLabel1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tagLabel1.ForeColor = System.Drawing.Color.Blue;
      this.tagLabel1.Location = new System.Drawing.Point(169, 101);
      this.tagLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.tagLabel1.Name = "tagLabel1";
      this.tagLabel1.Size = new System.Drawing.Size(132, 39);
      this.tagLabel1.TabIndex = 4;
      this.tagLabel1.Text = "You Earn";
      // 
      // tagLabel2
      // 
      this.tagLabel2.AutoSize = true;
      this.tagLabel2.BackColor = System.Drawing.Color.Transparent;
      this.tagLabel2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tagLabel2.ForeColor = System.Drawing.Color.Blue;
      this.tagLabel2.Location = new System.Drawing.Point(118, 149);
      this.tagLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.tagLabel2.Name = "tagLabel2";
      this.tagLabel2.Size = new System.Drawing.Size(232, 39);
      this.tagLabel2.TabIndex = 4;
      this.tagLabel2.Text = "We do the Math";
      // 
      // kryptonPalette1
      // 
      this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color1 = System.Drawing.Color.White;
      this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color2 = System.Drawing.Color.White;
      this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
      this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 10;
      this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.White;
      this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.White;
      // 
      // pictureBox2
      // 
      this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
      this.pictureBox2.Location = new System.Drawing.Point(134, 191);
      this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(187, 236);
      this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox2.TabIndex = 5;
      this.pictureBox2.TabStop = false;
      // 
      // aboutButton
      // 
      this.aboutButton.BackColor = System.Drawing.Color.Blue;
      this.aboutButton.BackgroundColor = System.Drawing.Color.Blue;
      this.aboutButton.BorderColor = System.Drawing.Color.Blue;
      this.aboutButton.BorderRadius = 20;
      this.aboutButton.BorderSize = 1;
      this.aboutButton.FlatAppearance.BorderSize = 0;
      this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.aboutButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.aboutButton.ForeColor = System.Drawing.Color.White;
      this.aboutButton.Location = new System.Drawing.Point(237, 448);
      this.aboutButton.Margin = new System.Windows.Forms.Padding(2);
      this.aboutButton.Name = "aboutButton";
      this.aboutButton.Size = new System.Drawing.Size(113, 50);
      this.aboutButton.TabIndex = 1;
      this.aboutButton.Text = "CONTACT US";
      this.aboutButton.TextColor = System.Drawing.Color.White;
      this.aboutButton.UseVisualStyleBackColor = false;
      this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
      // 
      // startButton
      // 
      this.startButton.BackColor = System.Drawing.Color.Blue;
      this.startButton.BackgroundColor = System.Drawing.Color.Blue;
      this.startButton.BorderColor = System.Drawing.Color.Blue;
      this.startButton.BorderRadius = 20;
      this.startButton.BorderSize = 1;
      this.startButton.FlatAppearance.BorderSize = 0;
      this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.startButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.startButton.ForeColor = System.Drawing.Color.White;
      this.startButton.Location = new System.Drawing.Point(104, 448);
      this.startButton.Margin = new System.Windows.Forms.Padding(2);
      this.startButton.Name = "startButton";
      this.startButton.Size = new System.Drawing.Size(113, 50);
      this.startButton.TabIndex = 1;
      this.startButton.Text = "GET STARTED";
      this.startButton.TextColor = System.Drawing.Color.White;
      this.startButton.UseVisualStyleBackColor = false;
      this.startButton.Click += new System.EventHandler(this.startButton_Click);
      // 
      // aboutUsButton
      // 
      this.aboutUsButton.BackColor = System.Drawing.Color.Blue;
      this.aboutUsButton.BackgroundColor = System.Drawing.Color.Blue;
      this.aboutUsButton.BorderColor = System.Drawing.Color.Blue;
      this.aboutUsButton.BorderRadius = 20;
      this.aboutUsButton.BorderSize = 1;
      this.aboutUsButton.FlatAppearance.BorderSize = 0;
      this.aboutUsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.aboutUsButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.aboutUsButton.ForeColor = System.Drawing.Color.White;
      this.aboutUsButton.Location = new System.Drawing.Point(176, 514);
      this.aboutUsButton.Margin = new System.Windows.Forms.Padding(2);
      this.aboutUsButton.Name = "aboutUsButton";
      this.aboutUsButton.Size = new System.Drawing.Size(113, 50);
      this.aboutUsButton.TabIndex = 1;
      this.aboutUsButton.Text = "ABOUT US";
      this.aboutUsButton.TextColor = System.Drawing.Color.White;
      this.aboutUsButton.UseVisualStyleBackColor = false;
      this.aboutUsButton.Click += new System.EventHandler(this.aboutUsButton_Click);
      // 
      // Welcome
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(464, 612);
      this.Controls.Add(this.pictureBox2);
      this.Controls.Add(this.tagLabel2);
      this.Controls.Add(this.tagLabel1);
      this.Controls.Add(this.titleLabel);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.aboutUsButton);
      this.Controls.Add(this.aboutButton);
      this.Controls.Add(this.startButton);
      this.DoubleBuffered = true;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "Welcome";
      this.Palette = this.kryptonPalette1;
      this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Wallet Buddy";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private CustomControl.RJButton startButton;
    private CustomControl.RJButton aboutButton;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label titleLabel;
    private System.Windows.Forms.Label tagLabel1;
    private System.Windows.Forms.Label tagLabel2;
    private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
    private System.Windows.Forms.PictureBox pictureBox2;
    private CustomControl.RJButton aboutUsButton;
  }
}