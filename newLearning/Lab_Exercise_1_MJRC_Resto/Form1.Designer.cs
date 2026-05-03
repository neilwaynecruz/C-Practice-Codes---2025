namespace Lab_Exercise_1_MJRC_Resto
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Controls
        private Label lblTitle;
        private Label lblUserName;
        private TextBox txtUserName;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;

        private Label lblAmountGiven;
        private TextBox txtAmountGiven;
        private Button btnComputeChange;
        private Label lblChangeText;
        private TextBox txtChange;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name = "disposing" > true if managed resources should be disposed; otherwise, false.</param>
        /// 
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblUserName = new Label();
            txtUserName = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblAmountGiven = new Label();
            txtAmountGiven = new TextBox();
            lblChangeText = new Label();
            txtChange = new TextBox();
            btnComputeChange = new Button();
            txtTotalBill = new TextBox();
            lblTotalBillText = new Label();
            btnClearAll = new Button();
            btnComputeBill = new Button();
            txtSiopao = new TextBox();
            lblSiopao = new Label();
            txtCoffee = new TextBox();
            lblCoffee = new Label();
            txtSoup = new TextBox();
            lblSoup = new Label();
            lblChoose = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(12, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(124, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "MJRC Resto";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(12, 50);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(85, 20);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "User Name:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(100, 47);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(180, 27);
            txtUserName.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(12, 80);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(100, 77);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(180, 27);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(295, 75);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(63, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Ok";
            btnLogin.Click += btnLogin_Click;
            // 
            // lblAmountGiven
            // 
            lblAmountGiven.AutoSize = true;
            lblAmountGiven.Location = new Point(134, 331);
            lblAmountGiven.Name = "lblAmountGiven";
            lblAmountGiven.Size = new Size(106, 20);
            lblAmountGiven.TabIndex = 7;
            lblAmountGiven.Text = "Amount Given:";
            lblAmountGiven.Click += lblAmountGiven_Click;
            // 
            // txtAmountGiven
            // 
            txtAmountGiven.Location = new Point(35, 361);
            txtAmountGiven.Name = "txtAmountGiven";
            txtAmountGiven.Size = new Size(309, 27);
            txtAmountGiven.TabIndex = 8;
            // 
            // lblChangeText
            // 
            lblChangeText.AutoSize = true;
            lblChangeText.Location = new Point(154, 398);
            lblChangeText.Name = "lblChangeText";
            lblChangeText.Size = new Size(62, 20);
            lblChangeText.TabIndex = 9;
            lblChangeText.Text = "Change:";
            // 
            // txtChange
            // 
            txtChange.BackColor = SystemColors.Info;
            txtChange.Location = new Point(32, 426);
            txtChange.Name = "txtChange";
            txtChange.ReadOnly = true;
            txtChange.Size = new Size(312, 27);
            txtChange.TabIndex = 10;
            // 
            // btnComputeChange
            // 
            btnComputeChange.Location = new Point(109, 463);
            btnComputeChange.Name = "btnComputeChange";
            btnComputeChange.Size = new Size(156, 29);
            btnComputeChange.TabIndex = 11;
            btnComputeChange.Text = "Compute Change";
            btnComputeChange.Click += btnComputeChange_Click;
            // 
            // txtTotalBill
            // 
            txtTotalBill.BackColor = SystemColors.Info;
            txtTotalBill.Location = new Point(35, 289);
            txtTotalBill.Name = "txtTotalBill";
            txtTotalBill.ReadOnly = true;
            txtTotalBill.Size = new Size(309, 27);
            txtTotalBill.TabIndex = 19;
            // 
            // lblTotalBillText
            // 
            lblTotalBillText.AutoSize = true;
            lblTotalBillText.Location = new Point(238, 255);
            lblTotalBillText.Name = "lblTotalBillText";
            lblTotalBillText.Size = new Size(84, 20);
            lblTotalBillText.TabIndex = 18;
            lblTotalBillText.Text = "Total Bill is:";
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(150, 250);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(75, 30);
            btnClearAll.TabIndex = 17;
            btnClearAll.Text = "Clear All";
            btnClearAll.Click += btnClearAll_Click;
            // 
            // btnComputeBill
            // 
            btnComputeBill.Location = new Point(32, 250);
            btnComputeBill.Name = "btnComputeBill";
            btnComputeBill.Size = new Size(106, 30);
            btnComputeBill.TabIndex = 16;
            btnComputeBill.Text = "Compute Bill";
            btnComputeBill.Click += btnComputeBill_Click;
            // 
            // txtSiopao
            // 
            txtSiopao.Location = new Point(155, 210);
            txtSiopao.Name = "txtSiopao";
            txtSiopao.Size = new Size(180, 27);
            txtSiopao.TabIndex = 15;
            // 
            // lblSiopao
            // 
            lblSiopao.AutoSize = true;
            lblSiopao.Location = new Point(45, 213);
            lblSiopao.Name = "lblSiopao";
            lblSiopao.Size = new Size(106, 20);
            lblSiopao.TabIndex = 14;
            lblSiopao.Text = "Siopao: P15.00";
            // 
            // txtCoffee
            // 
            txtCoffee.Location = new Point(155, 180);
            txtCoffee.Name = "txtCoffee";
            txtCoffee.Size = new Size(180, 27);
            txtCoffee.TabIndex = 13;
            // 
            // lblCoffee
            // 
            lblCoffee.AutoSize = true;
            lblCoffee.Location = new Point(45, 183);
            lblCoffee.Name = "lblCoffee";
            lblCoffee.Size = new Size(103, 20);
            lblCoffee.TabIndex = 12;
            lblCoffee.Text = "Coffee: P20.00";
            // 
            // txtSoup
            // 
            txtSoup.Location = new Point(155, 150);
            txtSoup.Name = "txtSoup";
            txtSoup.Size = new Size(180, 27);
            txtSoup.TabIndex = 11;
            // 
            // lblSoup
            // 
            lblSoup.AutoSize = true;
            lblSoup.Location = new Point(45, 153);
            lblSoup.Name = "lblSoup";
            lblSoup.Size = new Size(93, 20);
            lblSoup.TabIndex = 10;
            lblSoup.Text = "Soup: P25.00";
            // 
            // lblChoose
            // 
            lblChoose.AutoSize = true;
            lblChoose.Location = new Point(35, 120);
            lblChoose.Name = "lblChoose";
            lblChoose.Size = new Size(309, 20);
            lblChoose.TabIndex = 20;
            lblChoose.Text = "Choose Your Order and the number of orders:";
            lblChoose.Click += labels_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(377, 522);
            Controls.Add(lblChoose);
            Controls.Add(lblSoup);
            Controls.Add(lblTitle);
            Controls.Add(txtSoup);
            Controls.Add(lblUserName);
            Controls.Add(lblCoffee);
            Controls.Add(txtUserName);
            Controls.Add(txtCoffee);
            Controls.Add(lblSiopao);
            Controls.Add(lblPassword);
            Controls.Add(txtSiopao);
            Controls.Add(txtPassword);
            Controls.Add(btnComputeBill);
            Controls.Add(btnLogin);
            Controls.Add(btnClearAll);
            Controls.Add(lblTotalBillText);
            Controls.Add(lblAmountGiven);
            Controls.Add(txtTotalBill);
            Controls.Add(txtAmountGiven);
            Controls.Add(lblChangeText);
            Controls.Add(txtChange);
            Controls.Add(btnComputeChange);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MJRC Resto";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTotalBill;
        private Label lblTotalBillText;
        private Button btnClearAll;
        private Button btnComputeBill;
        private TextBox txtSiopao;
        private Label lblSiopao;
        private TextBox txtCoffee;
        private Label lblCoffee;
        private TextBox txtSoup;
        private Label lblSoup;
        private Label lblChoose;
    }
}
