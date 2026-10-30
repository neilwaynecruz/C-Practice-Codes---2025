namespace Final_Prac_Exam_Pizza
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpLogin = new GroupBox();
            lblUserName = new Label();
            txtUserName = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            
            picPizzaTopping = new PictureBox();
            
            grpTakeOrder = new GroupBox();
            lblToppings = new Label();
            rdoPepperoni = new RadioButton();
            rdoHawaiian = new RadioButton();
            rdoHamCheese = new RadioButton();
            lblAddOns = new Label();
            chkCheese = new CheckBox();
            chkMushrooms = new CheckBox();
            lblDiscount = new Label();
            cmbDiscount = new ComboBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
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
            
            grpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPizzaTopping).BeginInit();
            grpTakeOrder.SuspendLayout();
            grpBillsPayment.SuspendLayout();
            SuspendLayout();
            
            // 
            // grpLogin (Cashier Log-In GroupBox)
            // 
            grpLogin.Controls.Add(lblUserName);
            grpLogin.Controls.Add(txtUserName);
            grpLogin.Controls.Add(lblPassword);
            grpLogin.Controls.Add(txtPassword);
            grpLogin.Controls.Add(btnLogin);
            grpLogin.FlatStyle = FlatStyle.Flat;
            grpLogin.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            grpLogin.ForeColor = Color.FromArgb(43, 48, 53);
            grpLogin.Location = new Point(20, 20);
            grpLogin.Name = "grpLogin";
            grpLogin.Size = new Size(280, 175);
            grpLogin.TabIndex = 0;
            grpLogin.TabStop = false;
            grpLogin.Text = " Cashier Log-In ";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 9F);
            lblUserName.ForeColor = Color.FromArgb(70, 80, 75);
            lblUserName.Location = new Point(15, 30);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(84, 20);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "User Name:";
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.FromArgb(248, 249, 250);
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Font = new Font("Segoe UI", 10.5F);
            txtUserName.ForeColor = Color.FromArgb(33, 37, 41);
            txtUserName.Location = new Point(15, 52);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(250, 31);
            txtUserName.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F);
            lblPassword.ForeColor = Color.FromArgb(70, 80, 75);
            lblPassword.Location = new Point(15, 84);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(248, 249, 250);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 10.5F);
            txtPassword.ForeColor = Color.FromArgb(33, 37, 41);
            txtPassword.Location = new Point(15, 106);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(250, 31);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(46, 125, 50);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 94, 32);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 142, 60);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(15, 137);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(250, 32);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Log-In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // picPizzaTopping (Pizza Visualizer)
            // 
            picPizzaTopping.BackColor = Color.FromArgb(248, 249, 250);
            picPizzaTopping.BorderStyle = BorderStyle.FixedSingle;
            picPizzaTopping.Location = new Point(20, 205);
            picPizzaTopping.Name = "picPizzaTopping";
            picPizzaTopping.Size = new Size(280, 190);
            picPizzaTopping.SizeMode = PictureBoxSizeMode.Zoom;
            picPizzaTopping.TabIndex = 5;
            picPizzaTopping.TabStop = false;
            // 
            // grpTakeOrder (Take Order GroupBox)
            // 
            grpTakeOrder.Controls.Add(lblToppings);
            grpTakeOrder.Controls.Add(rdoPepperoni);
            grpTakeOrder.Controls.Add(rdoHawaiian);
            grpTakeOrder.Controls.Add(rdoHamCheese);
            grpTakeOrder.Controls.Add(lblAddOns);
            grpTakeOrder.Controls.Add(chkCheese);
            grpTakeOrder.Controls.Add(chkMushrooms);
            grpTakeOrder.Controls.Add(lblDiscount);
            grpTakeOrder.Controls.Add(cmbDiscount);
            grpTakeOrder.Controls.Add(lblQuantity);
            grpTakeOrder.Controls.Add(txtQuantity);
            grpTakeOrder.Controls.Add(btnOk);
            grpTakeOrder.Controls.Add(btnCancel);
            grpTakeOrder.FlatStyle = FlatStyle.Flat;
            grpTakeOrder.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            grpTakeOrder.ForeColor = Color.FromArgb(43, 48, 53);
            grpTakeOrder.Location = new Point(315, 20);
            grpTakeOrder.Name = "grpTakeOrder";
            grpTakeOrder.Size = new Size(400, 375);
            grpTakeOrder.TabIndex = 1;
            grpTakeOrder.TabStop = false;
            grpTakeOrder.Text = " Take Order ";
            // 
            // lblToppings
            // 
            lblToppings.AutoSize = true;
            lblToppings.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblToppings.ForeColor = Color.FromArgb(43, 48, 53);
            lblToppings.Location = new Point(15, 25);
            lblToppings.Name = "lblToppings";
            lblToppings.Size = new Size(84, 21);
            lblToppings.TabIndex = 0;
            lblToppings.Text = "Toppings:";
            // 
            // rdoPepperoni
            // 
            rdoPepperoni.AutoSize = true;
            rdoPepperoni.Cursor = Cursors.Hand;
            rdoPepperoni.Font = new Font("Segoe UI", 9F);
            rdoPepperoni.ForeColor = Color.FromArgb(50, 50, 50);
            rdoPepperoni.Location = new Point(25, 50);
            rdoPepperoni.Name = "rdoPepperoni";
            rdoPepperoni.Size = new Size(139, 24);
            rdoPepperoni.TabIndex = 1;
            rdoPepperoni.TabStop = true;
            rdoPepperoni.Text = "Pepperoni [200]";
            rdoPepperoni.UseVisualStyleBackColor = true;
            rdoPepperoni.CheckedChanged += rdoPepperoni_CheckedChanged;
            // 
            // rdoHawaiian
            // 
            rdoHawaiian.AutoSize = true;
            rdoHawaiian.Cursor = Cursors.Hand;
            rdoHawaiian.Font = new Font("Segoe UI", 9F);
            rdoHawaiian.ForeColor = Color.FromArgb(50, 50, 50);
            rdoHawaiian.Location = new Point(25, 80);
            rdoHawaiian.Name = "rdoHawaiian";
            rdoHawaiian.Size = new Size(132, 24);
            rdoHawaiian.TabIndex = 2;
            rdoHawaiian.TabStop = true;
            rdoHawaiian.Text = "Hawaiian [150]";
            rdoHawaiian.UseVisualStyleBackColor = true;
            rdoHawaiian.CheckedChanged += rdoHawaiian_CheckedChanged;
            // 
            // rdoHamCheese
            // 
            rdoHamCheese.AutoSize = true;
            rdoHamCheese.Cursor = Cursors.Hand;
            rdoHamCheese.Font = new Font("Segoe UI", 9F);
            rdoHamCheese.ForeColor = Color.FromArgb(50, 50, 50);
            rdoHamCheese.Location = new Point(25, 110);
            rdoHamCheese.Name = "rdoHamCheese";
            rdoHamCheese.Size = new Size(183, 24);
            rdoHamCheese.TabIndex = 3;
            rdoHamCheese.TabStop = true;
            rdoHamCheese.Text = "Ham and Cheese [100]";
            rdoHamCheese.UseVisualStyleBackColor = true;
            rdoHamCheese.CheckedChanged += rdoHamCheese_CheckedChanged;
            // 
            // lblAddOns
            // 
            lblAddOns.AutoSize = true;
            lblAddOns.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblAddOns.ForeColor = Color.FromArgb(43, 48, 53);
            lblAddOns.Location = new Point(220, 25);
            lblAddOns.Name = "lblAddOns";
            lblAddOns.Size = new Size(79, 21);
            lblAddOns.TabIndex = 4;
            lblAddOns.Text = "Add-Ons:";
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Cursor = Cursors.Hand;
            chkCheese.Font = new Font("Segoe UI", 9F);
            chkCheese.ForeColor = Color.FromArgb(50, 50, 50);
            chkCheese.Location = new Point(230, 50);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(110, 24);
            chkCheese.TabIndex = 5;
            chkCheese.Text = "Cheese [50]";
            chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkMushrooms
            // 
            chkMushrooms.AutoSize = true;
            chkMushrooms.Cursor = Cursors.Hand;
            chkMushrooms.Font = new Font("Segoe UI", 9F);
            chkMushrooms.ForeColor = Color.FromArgb(50, 50, 50);
            chkMushrooms.Location = new Point(230, 80);
            chkMushrooms.Name = "chkMushrooms";
            chkMushrooms.Size = new Size(137, 24);
            chkMushrooms.TabIndex = 6;
            chkMushrooms.Text = "Mushrooms [75]";
            chkMushrooms.UseVisualStyleBackColor = true;
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Segoe UI", 9F);
            lblDiscount.ForeColor = Color.FromArgb(70, 80, 75);
            lblDiscount.Location = new Point(15, 160);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(123, 20);
            lblDiscount.TabIndex = 7;
            lblDiscount.Text = "Type of Discount:";
            // 
            // cmbDiscount
            // 
            cmbDiscount.BackColor = Color.White;
            cmbDiscount.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDiscount.FlatStyle = FlatStyle.Flat;
            cmbDiscount.Font = new Font("Segoe UI", 9.5F);
            cmbDiscount.ForeColor = Color.Black;
            cmbDiscount.FormattingEnabled = true;
            cmbDiscount.Location = new Point(15, 183);
            cmbDiscount.Name = "cmbDiscount";
            cmbDiscount.Size = new Size(370, 29);
            cmbDiscount.TabIndex = 8;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 9F);
            lblQuantity.ForeColor = Color.FromArgb(70, 80, 75);
            lblQuantity.Location = new Point(15, 228);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(84, 20);
            lblQuantity.TabIndex = 9;
            lblQuantity.Text = "How Many?";
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.FromArgb(248, 249, 250);
            txtQuantity.BorderStyle = BorderStyle.FixedSingle;
            txtQuantity.Font = new Font("Segoe UI", 10.5F);
            txtQuantity.ForeColor = Color.FromArgb(33, 37, 41);
            txtQuantity.Location = new Point(15, 250);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(370, 31);
            txtQuantity.TabIndex = 10;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.FromArgb(46, 125, 50);
            btnOk.Cursor = Cursors.Hand;
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 94, 32);
            btnOk.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 142, 60);
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            btnOk.ForeColor = Color.White;
            btnOk.Location = new Point(60, 310);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(130, 40);
            btnOk.TabIndex = 11;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(142, 142, 147);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(112, 112, 115);
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(174, 174, 178);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(210, 310);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 40);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // grpBillsPayment (Bills Payment GroupBox)
            // 
            grpBillsPayment.Controls.Add(lblTotalAmount);
            grpBillsPayment.Controls.Add(txtTotalAmount);
            grpBillsPayment.Controls.Add(lblAmountGiven);
            grpBillsPayment.Controls.Add(txtAmountGiven);
            grpBillsPayment.Controls.Add(lblChange);
            grpBillsPayment.Controls.Add(txtChange);
            grpBillsPayment.Controls.Add(btnCompute);
            grpBillsPayment.FlatStyle = FlatStyle.Flat;
            grpBillsPayment.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            grpBillsPayment.ForeColor = Color.FromArgb(43, 48, 53);
            grpBillsPayment.Location = new Point(730, 20);
            grpBillsPayment.Name = "grpBillsPayment";
            grpBillsPayment.Size = new Size(330, 305);
            grpBillsPayment.TabIndex = 2;
            grpBillsPayment.TabStop = false;
            grpBillsPayment.Text = " Bills Payment ";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 9F);
            lblTotalAmount.ForeColor = Color.FromArgb(70, 80, 75);
            lblTotalAmount.Location = new Point(15, 25);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(102, 20);
            lblTotalAmount.TabIndex = 0;
            lblTotalAmount.Text = "Total Amount:";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.BackColor = Color.FromArgb(235, 247, 238);
            txtTotalAmount.BorderStyle = BorderStyle.FixedSingle;
            txtTotalAmount.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            txtTotalAmount.ForeColor = Color.FromArgb(46, 125, 50);
            txtTotalAmount.Location = new Point(15, 48);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(300, 32);
            txtTotalAmount.TabIndex = 1;
            txtTotalAmount.TextAlign = HorizontalAlignment.Right;
            // 
            // lblAmountGiven
            // 
            lblAmountGiven.AutoSize = true;
            lblAmountGiven.Font = new Font("Segoe UI", 9F);
            lblAmountGiven.ForeColor = Color.FromArgb(70, 80, 75);
            lblAmountGiven.Location = new Point(15, 88);
            lblAmountGiven.Name = "lblAmountGiven";
            lblAmountGiven.Size = new Size(107, 20);
            lblAmountGiven.TabIndex = 2;
            lblAmountGiven.Text = "Amount Given:";
            // 
            // txtAmountGiven
            // 
            txtAmountGiven.BackColor = Color.White;
            txtAmountGiven.BorderStyle = BorderStyle.FixedSingle;
            txtAmountGiven.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            txtAmountGiven.ForeColor = Color.Black;
            txtAmountGiven.Location = new Point(15, 111);
            txtAmountGiven.Name = "txtAmountGiven";
            txtAmountGiven.Size = new Size(300, 32);
            txtAmountGiven.TabIndex = 3;
            txtAmountGiven.TextAlign = HorizontalAlignment.Right;
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Segoe UI", 9F);
            lblChange.ForeColor = Color.FromArgb(70, 80, 75);
            lblChange.Location = new Point(15, 151);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(62, 20);
            lblChange.TabIndex = 4;
            lblChange.Text = "Change:";
            // 
            // txtChange
            // 
            txtChange.BackColor = Color.FromArgb(254, 244, 226);
            txtChange.BorderStyle = BorderStyle.FixedSingle;
            txtChange.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            txtChange.ForeColor = Color.FromArgb(190, 110, 0);
            txtChange.Location = new Point(15, 174);
            txtChange.Name = "txtChange";
            txtChange.ReadOnly = true;
            txtChange.Size = new Size(300, 32);
            txtChange.TabIndex = 5;
            txtChange.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCompute
            // 
            btnCompute.BackColor = Color.FromArgb(46, 125, 50);
            btnCompute.Cursor = Cursors.Hand;
            btnCompute.FlatAppearance.BorderSize = 0;
            btnCompute.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 94, 32);
            btnCompute.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 142, 60);
            btnCompute.FlatStyle = FlatStyle.Flat;
            btnCompute.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnCompute.ForeColor = Color.White;
            btnCompute.Location = new Point(15, 230);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(300, 45);
            btnCompute.TabIndex = 6;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = false;
            btnCompute.Click += btnCompute_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(209, 73, 73);
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(170, 50, 50);
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(229, 96, 96);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(730, 335);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(155, 60);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(99, 99, 102);
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 72, 74);
            btnReset.FlatAppearance.MouseOverBackColor = Color.FromArgb(142, 142, 147);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(905, 335);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(155, 60);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1080, 420);
            Controls.Add(btnReset);
            Controls.Add(btnExit);
            Controls.Add(grpBillsPayment);
            Controls.Add(grpTakeOrder);
            Controls.Add(picPizzaTopping);
            Controls.Add(grpLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            FormScreenCaptureMode = ScreenCaptureMode.HideWindow;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GreenHutShake Pizza";
            Load += Form1_Load;
            grpLogin.ResumeLayout(false);
            grpLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPizzaTopping).EndInit();
            grpTakeOrder.ResumeLayout(false);
            grpTakeOrder.PerformLayout();
            grpBillsPayment.ResumeLayout(false);
            grpBillsPayment.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        
        private System.Windows.Forms.PictureBox picPizzaTopping;
        
        private System.Windows.Forms.GroupBox grpTakeOrder;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.RadioButton rdoPepperoni;
        private System.Windows.Forms.RadioButton rdoHawaiian;
        private System.Windows.Forms.RadioButton rdoHamCheese;
        private System.Windows.Forms.Label lblAddOns;
        private System.Windows.Forms.CheckBox chkCheese;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.ComboBox cmbDiscount;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        
        private System.Windows.Forms.GroupBox grpBillsPayment;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblAmountGiven;
        private System.Windows.Forms.TextBox txtAmountGiven;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Button btnCompute;
        
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
    }
}
