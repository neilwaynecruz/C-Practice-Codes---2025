namespace Assignment_2_Employees
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMain = new Panel();
            btnClose = new Button();
            btnClear = new Button();
            btnCompute = new Button();
            txtNetPay = new TextBox();
            rdoWithLoan = new RadioButton();
            rdoWithoutLoan = new RadioButton();
            txtTotalDeductions = new TextBox();
            chkPagibig = new CheckBox();
            chkWithholdingTax = new CheckBox();
            chkPhilhealth = new CheckBox();
            chkGsis = new CheckBox();
            txtGrossSalary = new TextBox();
            cmbEmployeeRank = new ComboBox();
            txtHoursWorked = new TextBox();
            txtEmployeeName = new TextBox();
            lblNetPay = new Label();
            lblLoanDetails = new Label();
            lblTotalDeductions = new Label();
            lblDeductions = new Label();
            lblGrossSalary = new Label();
            lblEmployeeRank = new Label();
            lblHoursWorked = new Label();
            lblEmployeeName = new Label();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BorderStyle = BorderStyle.FixedSingle;
            pnlMain.Controls.Add(btnClose);
            pnlMain.Controls.Add(btnClear);
            pnlMain.Controls.Add(btnCompute);
            pnlMain.Controls.Add(txtNetPay);
            pnlMain.Controls.Add(rdoWithLoan);
            pnlMain.Controls.Add(rdoWithoutLoan);
            pnlMain.Controls.Add(txtTotalDeductions);
            pnlMain.Controls.Add(chkPagibig);
            pnlMain.Controls.Add(chkWithholdingTax);
            pnlMain.Controls.Add(chkPhilhealth);
            pnlMain.Controls.Add(chkGsis);
            pnlMain.Controls.Add(txtGrossSalary);
            pnlMain.Controls.Add(cmbEmployeeRank);
            pnlMain.Controls.Add(txtHoursWorked);
            pnlMain.Controls.Add(txtEmployeeName);
            pnlMain.Controls.Add(lblNetPay);
            pnlMain.Controls.Add(lblLoanDetails);
            pnlMain.Controls.Add(lblTotalDeductions);
            pnlMain.Controls.Add(lblDeductions);
            pnlMain.Controls.Add(lblGrossSalary);
            pnlMain.Controls.Add(lblEmployeeRank);
            pnlMain.Controls.Add(lblHoursWorked);
            pnlMain.Controls.Add(lblEmployeeName);
            pnlMain.Location = new Point(12, 12);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(660, 540);
            pnlMain.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Times New Roman", 14F);
            btnClose.Location = new Point(421, 476);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(175, 48);
            btnClose.TabIndex = 14;
            btnClose.Text = "btn-CLO&SE";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Times New Roman", 14F);
            btnClear.Location = new Point(228, 476);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(175, 48);
            btnClear.TabIndex = 13;
            btnClear.Text = "btn-CLEA&R";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnCompute
            // 
            btnCompute.Font = new Font("Times New Roman", 14F);
            btnCompute.Location = new Point(35, 476);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(175, 48);
            btnCompute.TabIndex = 12;
            btnCompute.Text = "btn-&COMPUTE";
            btnCompute.UseVisualStyleBackColor = true;
            btnCompute.Click += btnCompute_Click;
            // 
            // txtNetPay
            // 
            txtNetPay.Font = new Font("Times New Roman", 14F);
            txtNetPay.Location = new Point(210, 420);
            txtNetPay.Name = "txtNetPay";
            txtNetPay.ReadOnly = true;
            txtNetPay.Size = new Size(305, 34);
            txtNetPay.TabIndex = 11;
            txtNetPay.TabStop = false;
            // 
            // rdoWithLoan
            // 
            rdoWithLoan.AutoSize = true;
            rdoWithLoan.Font = new Font("Times New Roman", 14F);
            rdoWithLoan.Location = new Point(353, 376);
            rdoWithLoan.Name = "rdoWithLoan";
            rdoWithLoan.Size = new Size(136, 31);
            rdoWithLoan.TabIndex = 10;
            rdoWithLoan.Text = "With Loan";
            rdoWithLoan.UseVisualStyleBackColor = true;
            // 
            // rdoWithoutLoan
            // 
            rdoWithoutLoan.AutoSize = true;
            rdoWithoutLoan.Checked = true;
            rdoWithoutLoan.Font = new Font("Times New Roman", 14F);
            rdoWithoutLoan.Location = new Point(172, 376);
            rdoWithoutLoan.Name = "rdoWithoutLoan";
            rdoWithoutLoan.Size = new Size(167, 31);
            rdoWithoutLoan.TabIndex = 9;
            rdoWithoutLoan.TabStop = true;
            rdoWithoutLoan.Text = "Without Loan";
            rdoWithoutLoan.UseVisualStyleBackColor = true;
            // 
            // txtTotalDeductions
            // 
            txtTotalDeductions.Font = new Font("Times New Roman", 14F);
            txtTotalDeductions.Location = new Point(210, 323);
            txtTotalDeductions.Name = "txtTotalDeductions";
            txtTotalDeductions.ReadOnly = true;
            txtTotalDeductions.Size = new Size(305, 34);
            txtTotalDeductions.TabIndex = 8;
            txtTotalDeductions.TabStop = false;
            // 
            // chkPagibig
            // 
            chkPagibig.AutoSize = true;
            chkPagibig.Font = new Font("Times New Roman", 14F);
            chkPagibig.Location = new Point(353, 275);
            chkPagibig.Name = "chkPagibig";
            chkPagibig.Size = new Size(265, 31);
            chkPagibig.TabIndex = 7;
            chkPagibig.Text = "PAG-IBIG             P300";
            chkPagibig.UseVisualStyleBackColor = true;
            // 
            // chkWithholdingTax
            // 
            chkWithholdingTax.AutoSize = true;
            chkWithholdingTax.Font = new Font("Times New Roman", 14F);
            chkWithholdingTax.Location = new Point(35, 275);
            chkWithholdingTax.Name = "chkWithholdingTax";
            chkWithholdingTax.Size = new Size(273, 31);
            chkWithholdingTax.TabIndex = 6;
            chkWithholdingTax.Text = "Withholding Tax      10%";
            chkWithholdingTax.UseVisualStyleBackColor = true;
            // 
            // chkPhilhealth
            // 
            chkPhilhealth.AutoSize = true;
            chkPhilhealth.Font = new Font("Times New Roman", 14F);
            chkPhilhealth.Location = new Point(353, 237);
            chkPhilhealth.Name = "chkPhilhealth";
            chkPhilhealth.Size = new Size(273, 31);
            chkPhilhealth.TabIndex = 5;
            chkPhilhealth.Text = "PHILHEALTH       P200";
            chkPhilhealth.UseVisualStyleBackColor = true;
            // 
            // chkGsis
            // 
            chkGsis.AutoSize = true;
            chkGsis.Font = new Font("Times New Roman", 14F);
            chkGsis.Location = new Point(35, 237);
            chkGsis.Name = "chkGsis";
            chkGsis.Size = new Size(291, 31);
            chkGsis.TabIndex = 4;
            chkGsis.Text = "GSIS Contribution   P1000";
            chkGsis.UseVisualStyleBackColor = true;
            // 
            // txtGrossSalary
            // 
            txtGrossSalary.Font = new Font("Times New Roman", 14F);
            txtGrossSalary.Location = new Point(210, 156);
            txtGrossSalary.Name = "txtGrossSalary";
            txtGrossSalary.ReadOnly = true;
            txtGrossSalary.Size = new Size(305, 34);
            txtGrossSalary.TabIndex = 3;
            txtGrossSalary.TabStop = false;
            // 
            // cmbEmployeeRank
            // 
            cmbEmployeeRank.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmployeeRank.Font = new Font("Times New Roman", 14F);
            cmbEmployeeRank.FormattingEnabled = true;
            cmbEmployeeRank.Items.AddRange(new object[] { " ", "Rank 1", "Rank 2", "Rank 3" });
            cmbEmployeeRank.Location = new Point(265, 109);
            cmbEmployeeRank.Name = "cmbEmployeeRank";
            cmbEmployeeRank.Size = new Size(305, 34);
            cmbEmployeeRank.TabIndex = 2;
            // 
            // txtHoursWorked
            // 
            txtHoursWorked.Font = new Font("Times New Roman", 14F);
            txtHoursWorked.Location = new Point(265, 63);
            txtHoursWorked.Name = "txtHoursWorked";
            txtHoursWorked.Size = new Size(305, 34);
            txtHoursWorked.TabIndex = 1;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Font = new Font("Times New Roman", 14F);
            txtEmployeeName.Location = new Point(265, 17);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(305, 34);
            txtEmployeeName.TabIndex = 0;
            txtEmployeeName.TextChanged += txtEmployeeName_TextChanged;
            // 
            // lblNetPay
            // 
            lblNetPay.AutoSize = true;
            lblNetPay.Font = new Font("Times New Roman", 16F);
            lblNetPay.Location = new Point(12, 423);
            lblNetPay.Name = "lblNetPay";
            lblNetPay.Size = new Size(106, 31);
            lblNetPay.TabIndex = 7;
            lblNetPay.Text = "Net Pay:";
            // 
            // lblLoanDetails
            // 
            lblLoanDetails.AutoSize = true;
            lblLoanDetails.Font = new Font("Times New Roman", 16F);
            lblLoanDetails.Location = new Point(12, 376);
            lblLoanDetails.Name = "lblLoanDetails";
            lblLoanDetails.Size = new Size(159, 31);
            lblLoanDetails.TabIndex = 6;
            lblLoanDetails.Text = "Loan Details:";
            // 
            // lblTotalDeductions
            // 
            lblTotalDeductions.AutoSize = true;
            lblTotalDeductions.Font = new Font("Times New Roman", 16F);
            lblTotalDeductions.Location = new Point(12, 326);
            lblTotalDeductions.Name = "lblTotalDeductions";
            lblTotalDeductions.Size = new Size(207, 31);
            lblTotalDeductions.TabIndex = 5;
            lblTotalDeductions.Text = "Total Deductions:";
            // 
            // lblDeductions
            // 
            lblDeductions.AutoSize = true;
            lblDeductions.Font = new Font("Times New Roman", 16F);
            lblDeductions.Location = new Point(12, 201);
            lblDeductions.Name = "lblDeductions";
            lblDeductions.Size = new Size(144, 31);
            lblDeductions.TabIndex = 4;
            lblDeductions.Text = "Deductions:";
            // 
            // lblGrossSalary
            // 
            lblGrossSalary.AutoSize = true;
            lblGrossSalary.Font = new Font("Times New Roman", 16F);
            lblGrossSalary.Location = new Point(12, 159);
            lblGrossSalary.Name = "lblGrossSalary";
            lblGrossSalary.Size = new Size(158, 31);
            lblGrossSalary.TabIndex = 3;
            lblGrossSalary.Text = "Gross Salary:";
            // 
            // lblEmployeeRank
            // 
            lblEmployeeRank.AutoSize = true;
            lblEmployeeRank.Font = new Font("Times New Roman", 16F);
            lblEmployeeRank.Location = new Point(12, 112);
            lblEmployeeRank.Name = "lblEmployeeRank";
            lblEmployeeRank.Size = new Size(194, 31);
            lblEmployeeRank.TabIndex = 2;
            lblEmployeeRank.Text = "Employee Rank:";
            // 
            // lblHoursWorked
            // 
            lblHoursWorked.AutoSize = true;
            lblHoursWorked.Font = new Font("Times New Roman", 16F);
            lblHoursWorked.Location = new Point(12, 66);
            lblHoursWorked.Name = "lblHoursWorked";
            lblHoursWorked.Size = new Size(247, 31);
            lblHoursWorked.TabIndex = 1;
            lblHoursWorked.Text = "No of Hours Worked:";
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Font = new Font("Times New Roman", 16F);
            lblEmployeeName.Location = new Point(12, 20);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(200, 31);
            lblEmployeeName.TabIndex = 0;
            lblEmployeeName.Text = "Employee Name:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 561);
            Controls.Add(pnlMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Assignment 2 - Employees";
            Load += Form1_Load;
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private Label lblEmployeeName;
        private Label lblHoursWorked;
        private Label lblEmployeeRank;
        private Label lblGrossSalary;
        private Label lblDeductions;
        private Label lblTotalDeductions;
        private Label lblLoanDetails;
        private Label lblNetPay;
        private TextBox txtEmployeeName;
        private TextBox txtHoursWorked;
        private ComboBox cmbEmployeeRank;
        private TextBox txtGrossSalary;
        private CheckBox chkGsis;
        private CheckBox chkPhilhealth;
        private CheckBox chkWithholdingTax;
        private CheckBox chkPagibig;
        private TextBox txtTotalDeductions;
        private RadioButton rdoWithoutLoan;
        private RadioButton rdoWithLoan;
        private TextBox txtNetPay;
        private Button btnCompute;
        private Button btnClear;
        private Button btnClose;
    }
}
