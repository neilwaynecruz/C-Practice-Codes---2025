namespace Practical_Exam
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            grpCashier = new GroupBox();
            lblUserName = new Label();
            txtUserName = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogIn = new Button();
            picTopping = new PictureBox();
            grpTakeOrder = new GroupBox();
            lblToppings = new Label();
            rbPepperoni = new RadioButton();
            rbHawaiian = new RadioButton();
            rbHamCheese = new RadioButton();
            lblAddOns = new Label();
            chkCheese = new CheckBox();
            chkMushrooms = new CheckBox();
            lblDiscount = new Label();
            cmbDiscount = new ComboBox();
            lblHowMany = new Label();
            txtHowMany = new TextBox();
            btnOk = new Button();
            btnCancel = new Button();
            grpBillsPayment = new GroupBox();
            lblTotalAmount = new Label();
            txtTotalAmount = new TextBox();
            lblAmountGiven = new Label();
            txtAmountGiven = new TextBox();
            lblChange = new Label();
            txtChange = new TextBox();
            btnCompute = new Button();
            btnExit = new Button();
            btnReset = new Button();
            grpCashier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTopping).BeginInit();
            grpTakeOrder.SuspendLayout();
            grpBillsPayment.SuspendLayout();
            SuspendLayout();
            // 
            // grpCashier
            // 
            grpCashier.Controls.Add(lblUserName);
            grpCashier.Controls.Add(txtUserName);
            grpCashier.Controls.Add(lblPassword);
            grpCashier.Controls.Add(txtPassword);
            grpCashier.Controls.Add(btnLogIn);
            grpCashier.Controls.Add(picTopping);
            grpCashier.Location = new Point(12, 12);
            grpCashier.Name = "grpCashier";
            grpCashier.Size = new Size(200, 220);
            grpCashier.TabIndex = 0;
            grpCashier.TabStop = false;
            grpCashier.Text = "Cashier Log-In";
            // 
            // lblUserName
            // 
            lblUserName.Location = new Point(8, 25);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(65, 15);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "User Name:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(75, 22);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(110, 27);
            txtUserName.TabIndex = 0;
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(8, 52);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(65, 15);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(75, 49);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(110, 27);
            txtPassword.TabIndex = 1;
            // 
            // btnLogIn
            // 
            btnLogIn.Location = new Point(55, 78);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(75, 23);
            btnLogIn.TabIndex = 2;
            btnLogIn.Text = "&Log-In";
            btnLogIn.Click += btnLogIn_Click;
            // 
            // picTopping
            // 
            picTopping.BorderStyle = BorderStyle.FixedSingle;
            picTopping.Location = new Point(25, 110);
            picTopping.Name = "picTopping";
            picTopping.Size = new Size(150, 100);
            picTopping.SizeMode = PictureBoxSizeMode.StretchImage;
            picTopping.TabIndex = 3;
            picTopping.TabStop = false;
            // 
            // grpTakeOrder
            // 
            grpTakeOrder.Controls.Add(lblToppings);
            grpTakeOrder.Controls.Add(rbPepperoni);
            grpTakeOrder.Controls.Add(rbHawaiian);
            grpTakeOrder.Controls.Add(rbHamCheese);
            grpTakeOrder.Controls.Add(lblAddOns);
            grpTakeOrder.Controls.Add(chkCheese);
            grpTakeOrder.Controls.Add(chkMushrooms);
            grpTakeOrder.Controls.Add(lblDiscount);
            grpTakeOrder.Controls.Add(cmbDiscount);
            grpTakeOrder.Controls.Add(lblHowMany);
            grpTakeOrder.Controls.Add(txtHowMany);
            grpTakeOrder.Controls.Add(btnOk);
            grpTakeOrder.Controls.Add(btnCancel);
            grpTakeOrder.Location = new Point(220, 12);
            grpTakeOrder.Name = "grpTakeOrder";
            grpTakeOrder.Size = new Size(340, 220);
            grpTakeOrder.TabIndex = 1;
            grpTakeOrder.TabStop = false;
            grpTakeOrder.Text = "Take Order";
            // 
            // lblToppings
            // 
            lblToppings.Location = new Point(8, 22);
            lblToppings.Name = "lblToppings";
            lblToppings.Size = new Size(65, 15);
            lblToppings.TabIndex = 0;
            lblToppings.Text = "Toppings:";
            // 
            // rbPepperoni
            // 
            rbPepperoni.Location = new Point(10, 40);
            rbPepperoni.Name = "rbPepperoni";
            rbPepperoni.Size = new Size(140, 18);
            rbPepperoni.TabIndex = 3;
            rbPepperoni.Text = "Pepperoni  [200]";
            rbPepperoni.CheckedChanged += rbPepperoni_CheckedChanged;
            // 
            // rbHawaiian
            // 
            rbHawaiian.Location = new Point(10, 62);
            rbHawaiian.Name = "rbHawaiian";
            rbHawaiian.Size = new Size(140, 18);
            rbHawaiian.TabIndex = 4;
            rbHawaiian.Text = "Hawaiian  [150]";
            rbHawaiian.CheckedChanged += rbHawaiian_CheckedChanged;
            // 
            // rbHamCheese
            // 
            rbHamCheese.Location = new Point(10, 84);
            rbHamCheese.Name = "rbHamCheese";
            rbHamCheese.Size = new Size(155, 18);
            rbHamCheese.TabIndex = 5;
            rbHamCheese.Text = "Ham and Cheese  [100]";
            rbHamCheese.CheckedChanged += rbHamCheese_CheckedChanged;
            // 
            // lblAddOns
            // 
            lblAddOns.Location = new Point(175, 22);
            lblAddOns.Name = "lblAddOns";
            lblAddOns.Size = new Size(60, 15);
            lblAddOns.TabIndex = 6;
            lblAddOns.Text = "Add-Ons:";
            // 
            // chkCheese
            // 
            chkCheese.Location = new Point(175, 40);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(115, 18);
            chkCheese.TabIndex = 6;
            chkCheese.Text = "Cheese  [50]";
            // 
            // chkMushrooms
            // 
            chkMushrooms.Location = new Point(175, 62);
            chkMushrooms.Name = "chkMushrooms";
            chkMushrooms.Size = new Size(140, 18);
            chkMushrooms.TabIndex = 7;
            chkMushrooms.Text = "Mushrooms  [75]";
            // 
            // lblDiscount
            // 
            lblDiscount.Location = new Point(8, 112);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(105, 15);
            lblDiscount.TabIndex = 8;
            lblDiscount.Text = "Type of Discount:";
            // 
            // cmbDiscount
            // 
            cmbDiscount.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDiscount.Items.AddRange(new object[] { "Senior", "VIPCard" });
            cmbDiscount.Location = new Point(115, 109);
            cmbDiscount.Name = "cmbDiscount";
            cmbDiscount.Size = new Size(110, 28);
            cmbDiscount.TabIndex = 8;
            // 
            // lblHowMany
            // 
            lblHowMany.Location = new Point(8, 138);
            lblHowMany.Name = "lblHowMany";
            lblHowMany.Size = new Size(89, 27);
            lblHowMany.TabIndex = 9;
            lblHowMany.Text = "How Many?";
            // 
            // txtHowMany
            // 
            txtHowMany.Location = new Point(126, 138);
            txtHowMany.Name = "txtHowMany";
            txtHowMany.Size = new Size(80, 27);
            txtHowMany.TabIndex = 9;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(90, 185);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(70, 23);
            btnOk.TabIndex = 10;
            btnOk.Text = "&Ok";
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(168, 185);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(70, 23);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "&Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // grpBillsPayment
            // 
            grpBillsPayment.Controls.Add(lblTotalAmount);
            grpBillsPayment.Controls.Add(txtTotalAmount);
            grpBillsPayment.Controls.Add(lblAmountGiven);
            grpBillsPayment.Controls.Add(txtAmountGiven);
            grpBillsPayment.Controls.Add(lblChange);
            grpBillsPayment.Controls.Add(txtChange);
            grpBillsPayment.Controls.Add(btnCompute);
            grpBillsPayment.Controls.Add(btnExit);
            grpBillsPayment.Controls.Add(btnReset);
            grpBillsPayment.Location = new Point(568, 12);
            grpBillsPayment.Name = "grpBillsPayment";
            grpBillsPayment.Size = new Size(260, 220);
            grpBillsPayment.TabIndex = 2;
            grpBillsPayment.TabStop = false;
            grpBillsPayment.Text = "Bills Payment";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.Location = new Point(8, 25);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(107, 27);
            lblTotalAmount.TabIndex = 0;
            lblTotalAmount.Text = "Total Amount:";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Location = new Point(120, 19);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(110, 27);
            txtTotalAmount.TabIndex = 1;
            txtTotalAmount.TabStop = false;
            // 
            // lblAmountGiven
            // 
            lblAmountGiven.Location = new Point(8, 52);
            lblAmountGiven.Name = "lblAmountGiven";
            lblAmountGiven.Size = new Size(107, 21);
            lblAmountGiven.TabIndex = 2;
            lblAmountGiven.Text = "Amount Given:";
            // 
            // txtAmountGiven
            // 
            txtAmountGiven.Location = new Point(121, 49);
            txtAmountGiven.Name = "txtAmountGiven";
            txtAmountGiven.Size = new Size(110, 27);
            txtAmountGiven.TabIndex = 12;
            // 
            // lblChange
            // 
            lblChange.Location = new Point(8, 79);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(81, 24);
            lblChange.TabIndex = 13;
            lblChange.Text = "Change:";
            // 
            // txtChange
            // 
            txtChange.Location = new Point(120, 78);
            txtChange.Name = "txtChange";
            txtChange.ReadOnly = true;
            txtChange.Size = new Size(110, 27);
            txtChange.TabIndex = 14;
            txtChange.TabStop = false;
            // 
            // btnCompute
            // 
            btnCompute.Location = new Point(130, 112);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(80, 23);
            btnCompute.TabIndex = 13;
            btnCompute.Text = "&Compute";
            btnCompute.Click += btnCompute_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(50, 185);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(65, 23);
            btnExit.TabIndex = 14;
            btnExit.Text = "E&xit";
            btnExit.Click += btnExit_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(130, 185);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(65, 23);
            btnReset.TabIndex = 15;
            btnReset.Text = "&Reset";
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(855, 364);
            Controls.Add(grpCashier);
            Controls.Add(grpTakeOrder);
            Controls.Add(grpBillsPayment);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GreenHutShake Pizza";
            Load += Form1_Load;
            grpCashier.ResumeLayout(false);
            grpCashier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTopping).EndInit();
            grpTakeOrder.ResumeLayout(false);
            grpTakeOrder.PerformLayout();
            grpBillsPayment.ResumeLayout(false);
            grpBillsPayment.PerformLayout();
            ResumeLayout(false);
        }

        // ── Control declarations ─────────────────────────────────────
        private System.Windows.Forms.GroupBox grpCashier;
        private System.Windows.Forms.GroupBox grpTakeOrder;
        private System.Windows.Forms.GroupBox grpBillsPayment;

        private System.Windows.Forms.Label    lblUserName;
        private System.Windows.Forms.Label    lblPassword;
        private System.Windows.Forms.TextBox  txtUserName;
        private System.Windows.Forms.TextBox  txtPassword;
        private System.Windows.Forms.Button   btnLogIn;
        private System.Windows.Forms.PictureBox picTopping;

        private System.Windows.Forms.Label    lblToppings;
        private System.Windows.Forms.Label    lblAddOns;
        private System.Windows.Forms.RadioButton rbPepperoni;
        private System.Windows.Forms.RadioButton rbHawaiian;
        private System.Windows.Forms.RadioButton rbHamCheese;
        private System.Windows.Forms.CheckBox chkCheese;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.Label    lblDiscount;
        private System.Windows.Forms.ComboBox cmbDiscount;
        private System.Windows.Forms.Label    lblHowMany;
        private System.Windows.Forms.TextBox  txtHowMany;
        private System.Windows.Forms.Button   btnOk;
        private System.Windows.Forms.Button   btnCancel;

        private System.Windows.Forms.Label    lblTotalAmount;
        private System.Windows.Forms.Label    lblAmountGiven;
        private System.Windows.Forms.Label    lblChange;
        private System.Windows.Forms.TextBox  txtTotalAmount;
        private System.Windows.Forms.TextBox  txtAmountGiven;
        private System.Windows.Forms.TextBox  txtChange;
        private System.Windows.Forms.Button   btnCompute;
        private System.Windows.Forms.Button   btnExit;
        private System.Windows.Forms.Button   btnReset;
    }
}