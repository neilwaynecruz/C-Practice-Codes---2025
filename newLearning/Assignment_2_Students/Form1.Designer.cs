namespace Assignment_2_Students
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
            lblTitle = new Label();
            lblStudentName = new Label();
            txtStudentName = new TextBox();
            lblUnitsEnrolled = new Label();
            txtUnitsEnrolled = new TextBox();
            lblYearLevel = new Label();
            cboYearLevel = new ComboBox();
            lblOtherFees = new Label();
            chkLaboratoryFee = new CheckBox();
            lblLaboratoryFee = new Label();
            chkStudentCouncil = new CheckBox();
            lblStudentCouncilFee = new Label();
            chkRegistrationCard = new CheckBox();
            lblRegistrationCardFee = new Label();
            chkStudentId = new CheckBox();
            lblStudentIdFee = new Label();
            chkCatalyst = new CheckBox();
            lblCatalystFee = new Label();
            chkOtherMiscellaneous = new CheckBox();
            lblOtherMiscellaneousFee = new Label();
            grpScholarship = new GroupBox();
            rdoPartialScholar = new RadioButton();
            rdoFullScholar = new RadioButton();
            rdoNonScholar = new RadioButton();
            lblTotalAmount = new Label();
            txtTotalAmount = new TextBox();
            btnCompute = new Button();
            btnClear = new Button();
            btnClose = new Button();
            grpScholarship.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(31, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(192, 26);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Enrollment Form";
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Font = new Font("Times New Roman", 14.25F);
            lblStudentName.Location = new Point(31, 89);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(154, 27);
            lblStudentName.TabIndex = 1;
            lblStudentName.Text = "Student Name:";
            // 
            // txtStudentName
            // 
            txtStudentName.Font = new Font("Times New Roman", 14.25F);
            txtStudentName.Location = new Point(209, 84);
            txtStudentName.Margin = new Padding(3, 4, 3, 4);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(325, 35);
            txtStudentName.TabIndex = 2;
            // 
            // lblUnitsEnrolled
            // 
            lblUnitsEnrolled.AutoSize = true;
            lblUnitsEnrolled.Font = new Font("Times New Roman", 14.25F);
            lblUnitsEnrolled.Location = new Point(31, 148);
            lblUnitsEnrolled.Name = "lblUnitsEnrolled";
            lblUnitsEnrolled.Size = new Size(156, 27);
            lblUnitsEnrolled.TabIndex = 3;
            lblUnitsEnrolled.Text = "Units Enrolled:";
            // 
            // txtUnitsEnrolled
            // 
            txtUnitsEnrolled.Font = new Font("Times New Roman", 14.25F);
            txtUnitsEnrolled.Location = new Point(209, 143);
            txtUnitsEnrolled.Margin = new Padding(3, 4, 3, 4);
            txtUnitsEnrolled.Name = "txtUnitsEnrolled";
            txtUnitsEnrolled.Size = new Size(325, 35);
            txtUnitsEnrolled.TabIndex = 4;
            // 
            // lblYearLevel
            // 
            lblYearLevel.AutoSize = true;
            lblYearLevel.Font = new Font("Times New Roman", 14.25F);
            lblYearLevel.Location = new Point(31, 208);
            lblYearLevel.Name = "lblYearLevel";
            lblYearLevel.Size = new Size(124, 27);
            lblYearLevel.TabIndex = 5;
            lblYearLevel.Text = "Year Level:";
            // 
            // cboYearLevel
            // 
            cboYearLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboYearLevel.Font = new Font("Times New Roman", 14.25F);
            cboYearLevel.FormattingEnabled = true;
            cboYearLevel.Items.AddRange(new object[] { " ", "1st Year", "2nd Year", "3rd Year", "4th Year", "5th Year" });
            cboYearLevel.Location = new Point(209, 203);
            cboYearLevel.Margin = new Padding(3, 4, 3, 4);
            cboYearLevel.Name = "cboYearLevel";
            cboYearLevel.Size = new Size(325, 35);
            cboYearLevel.TabIndex = 6;
            // 
            // lblOtherFees
            // 
            lblOtherFees.AutoSize = true;
            lblOtherFees.Font = new Font("Times New Roman", 14.25F);
            lblOtherFees.Location = new Point(31, 268);
            lblOtherFees.Name = "lblOtherFees";
            lblOtherFees.Size = new Size(123, 27);
            lblOtherFees.TabIndex = 7;
            lblOtherFees.Text = "Other Fees:";
            // 
            // chkLaboratoryFee
            // 
            chkLaboratoryFee.AutoSize = true;
            chkLaboratoryFee.Font = new Font("Times New Roman", 14.25F);
            chkLaboratoryFee.Location = new Point(74, 308);
            chkLaboratoryFee.Margin = new Padding(3, 4, 3, 4);
            chkLaboratoryFee.Name = "chkLaboratoryFee";
            chkLaboratoryFee.Size = new Size(183, 31);
            chkLaboratoryFee.TabIndex = 8;
            chkLaboratoryFee.Text = "Laboratory Fee";
            chkLaboratoryFee.UseVisualStyleBackColor = true;
            // 
            // lblLaboratoryFee
            // 
            lblLaboratoryFee.AutoSize = true;
            lblLaboratoryFee.Font = new Font("Times New Roman", 14.25F);
            lblLaboratoryFee.Location = new Point(315, 311);
            lblLaboratoryFee.Name = "lblLaboratoryFee";
            lblLaboratoryFee.Size = new Size(62, 27);
            lblLaboratoryFee.TabIndex = 9;
            lblLaboratoryFee.Text = "P200";
            // 
            // chkStudentCouncil
            // 
            chkStudentCouncil.AutoSize = true;
            chkStudentCouncil.Font = new Font("Times New Roman", 14.25F);
            chkStudentCouncil.Location = new Point(414, 308);
            chkStudentCouncil.Margin = new Padding(3, 4, 3, 4);
            chkStudentCouncil.Name = "chkStudentCouncil";
            chkStudentCouncil.Size = new Size(188, 31);
            chkStudentCouncil.TabIndex = 10;
            chkStudentCouncil.Text = "Student Council";
            chkStudentCouncil.UseVisualStyleBackColor = true;
            // 
            // lblStudentCouncilFee
            // 
            lblStudentCouncilFee.AutoSize = true;
            lblStudentCouncilFee.Font = new Font("Times New Roman", 14.25F);
            lblStudentCouncilFee.Location = new Point(661, 311);
            lblStudentCouncilFee.Name = "lblStudentCouncilFee";
            lblStudentCouncilFee.Size = new Size(50, 27);
            lblStudentCouncilFee.TabIndex = 11;
            lblStudentCouncilFee.Text = "P50";
            // 
            // chkRegistrationCard
            // 
            chkRegistrationCard.AutoSize = true;
            chkRegistrationCard.Font = new Font("Times New Roman", 14.25F);
            chkRegistrationCard.Location = new Point(74, 367);
            chkRegistrationCard.Margin = new Padding(3, 4, 3, 4);
            chkRegistrationCard.Name = "chkRegistrationCard";
            chkRegistrationCard.Size = new Size(203, 31);
            chkRegistrationCard.TabIndex = 12;
            chkRegistrationCard.Text = "Registration Card";
            chkRegistrationCard.UseVisualStyleBackColor = true;
            // 
            // lblRegistrationCardFee
            // 
            lblRegistrationCardFee.AutoSize = true;
            lblRegistrationCardFee.Font = new Font("Times New Roman", 14.25F);
            lblRegistrationCardFee.Location = new Point(315, 369);
            lblRegistrationCardFee.Name = "lblRegistrationCardFee";
            lblRegistrationCardFee.Size = new Size(50, 27);
            lblRegistrationCardFee.TabIndex = 13;
            lblRegistrationCardFee.Text = "P50";
            // 
            // chkStudentId
            // 
            chkStudentId.AutoSize = true;
            chkStudentId.Font = new Font("Times New Roman", 14.25F);
            chkStudentId.Location = new Point(414, 367);
            chkStudentId.Margin = new Padding(3, 4, 3, 4);
            chkStudentId.Name = "chkStudentId";
            chkStudentId.Size = new Size(138, 31);
            chkStudentId.TabIndex = 14;
            chkStudentId.Text = "Student ID";
            chkStudentId.UseVisualStyleBackColor = true;
            // 
            // lblStudentIdFee
            // 
            lblStudentIdFee.AutoSize = true;
            lblStudentIdFee.Font = new Font("Times New Roman", 14.25F);
            lblStudentIdFee.Location = new Point(661, 369);
            lblStudentIdFee.Name = "lblStudentIdFee";
            lblStudentIdFee.Size = new Size(50, 27);
            lblStudentIdFee.TabIndex = 15;
            lblStudentIdFee.Text = "P50";
            // 
            // chkCatalyst
            // 
            chkCatalyst.AutoSize = true;
            chkCatalyst.Font = new Font("Times New Roman", 14.25F);
            chkCatalyst.Location = new Point(74, 425);
            chkCatalyst.Margin = new Padding(3, 4, 3, 4);
            chkCatalyst.Name = "chkCatalyst";
            chkCatalyst.Size = new Size(113, 31);
            chkCatalyst.TabIndex = 16;
            chkCatalyst.Text = "Catalyst";
            chkCatalyst.UseVisualStyleBackColor = true;
            // 
            // lblCatalystFee
            // 
            lblCatalystFee.AutoSize = true;
            lblCatalystFee.Font = new Font("Times New Roman", 14.25F);
            lblCatalystFee.Location = new Point(315, 428);
            lblCatalystFee.Name = "lblCatalystFee";
            lblCatalystFee.Size = new Size(50, 27);
            lblCatalystFee.TabIndex = 17;
            lblCatalystFee.Text = "P50";
            // 
            // chkOtherMiscellaneous
            // 
            chkOtherMiscellaneous.AutoSize = true;
            chkOtherMiscellaneous.Font = new Font("Times New Roman", 14.25F);
            chkOtherMiscellaneous.Location = new Point(414, 425);
            chkOtherMiscellaneous.Margin = new Padding(3, 4, 3, 4);
            chkOtherMiscellaneous.Name = "chkOtherMiscellaneous";
            chkOtherMiscellaneous.Size = new Size(232, 31);
            chkOtherMiscellaneous.TabIndex = 18;
            chkOtherMiscellaneous.Text = "Other Miscellaneous";
            chkOtherMiscellaneous.UseVisualStyleBackColor = true;
            // 
            // lblOtherMiscellaneousFee
            // 
            lblOtherMiscellaneousFee.AutoSize = true;
            lblOtherMiscellaneousFee.Font = new Font("Times New Roman", 14.25F);
            lblOtherMiscellaneousFee.Location = new Point(661, 428);
            lblOtherMiscellaneousFee.Name = "lblOtherMiscellaneousFee";
            lblOtherMiscellaneousFee.Size = new Size(62, 27);
            lblOtherMiscellaneousFee.TabIndex = 19;
            lblOtherMiscellaneousFee.Text = "P100";
            // 
            // grpScholarship
            // 
            grpScholarship.Controls.Add(rdoPartialScholar);
            grpScholarship.Controls.Add(rdoFullScholar);
            grpScholarship.Controls.Add(rdoNonScholar);
            grpScholarship.Font = new Font("Times New Roman", 14.25F);
            grpScholarship.Location = new Point(35, 467);
            grpScholarship.Margin = new Padding(3, 4, 3, 4);
            grpScholarship.Name = "grpScholarship";
            grpScholarship.Padding = new Padding(3, 4, 3, 4);
            grpScholarship.Size = new Size(683, 165);
            grpScholarship.TabIndex = 20;
            grpScholarship.TabStop = false;
            grpScholarship.Text = "Scholarship Grants:";
            // 
            // rdoPartialScholar
            // 
            rdoPartialScholar.AutoSize = true;
            rdoPartialScholar.Location = new Point(243, 91);
            rdoPartialScholar.Margin = new Padding(3, 4, 3, 4);
            rdoPartialScholar.Name = "rdoPartialScholar";
            rdoPartialScholar.Size = new Size(174, 31);
            rdoPartialScholar.TabIndex = 2;
            rdoPartialScholar.TabStop = true;
            rdoPartialScholar.Text = "Partial Scholar";
            rdoPartialScholar.UseVisualStyleBackColor = true;
            // 
            // rdoFullScholar
            // 
            rdoFullScholar.AutoSize = true;
            rdoFullScholar.Location = new Point(243, 48);
            rdoFullScholar.Margin = new Padding(3, 4, 3, 4);
            rdoFullScholar.Name = "rdoFullScholar";
            rdoFullScholar.Size = new Size(148, 31);
            rdoFullScholar.TabIndex = 1;
            rdoFullScholar.TabStop = true;
            rdoFullScholar.Text = "Full Scholar";
            rdoFullScholar.UseVisualStyleBackColor = true;
            // 
            // rdoNonScholar
            // 
            rdoNonScholar.AutoSize = true;
            rdoNonScholar.Location = new Point(243, 3);
            rdoNonScholar.Margin = new Padding(3, 4, 3, 4);
            rdoNonScholar.Name = "rdoNonScholar";
            rdoNonScholar.Size = new Size(154, 31);
            rdoNonScholar.TabIndex = 0;
            rdoNonScholar.TabStop = true;
            rdoNonScholar.Text = "Non-Scholar";
            rdoNonScholar.UseVisualStyleBackColor = true;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Times New Roman", 14.25F);
            lblTotalAmount.Location = new Point(31, 661);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(149, 27);
            lblTotalAmount.TabIndex = 21;
            lblTotalAmount.Text = "Total Amount:";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Font = new Font("Times New Roman", 14.25F);
            txtTotalAmount.Location = new Point(201, 656);
            txtTotalAmount.Margin = new Padding(3, 4, 3, 4);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(325, 35);
            txtTotalAmount.TabIndex = 22;
            txtTotalAmount.TabStop = false;
            // 
            // btnCompute
            // 
            btnCompute.Font = new Font("Times New Roman", 14.25F);
            btnCompute.Location = new Point(58, 732);
            btnCompute.Margin = new Padding(3, 4, 3, 4);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(190, 60);
            btnCompute.TabIndex = 23;
            btnCompute.Text = "btn-COMPUTE";
            btnCompute.UseVisualStyleBackColor = true;
            btnCompute.Click += btnCompute_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Times New Roman", 14.25F);
            btnClear.Location = new Point(264, 732);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(190, 60);
            btnClear.TabIndex = 24;
            btnClear.Text = "btn-CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Times New Roman", 14.25F);
            btnClose.Location = new Point(470, 732);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(190, 60);
            btnClose.TabIndex = 25;
            btnClose.Text = "btn-CLOSE";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(793, 841);
            Controls.Add(btnClose);
            Controls.Add(btnClear);
            Controls.Add(btnCompute);
            Controls.Add(txtTotalAmount);
            Controls.Add(lblTotalAmount);
            Controls.Add(grpScholarship);
            Controls.Add(lblOtherMiscellaneousFee);
            Controls.Add(chkOtherMiscellaneous);
            Controls.Add(lblCatalystFee);
            Controls.Add(chkCatalyst);
            Controls.Add(lblStudentIdFee);
            Controls.Add(chkStudentId);
            Controls.Add(lblRegistrationCardFee);
            Controls.Add(chkRegistrationCard);
            Controls.Add(lblStudentCouncilFee);
            Controls.Add(chkStudentCouncil);
            Controls.Add(lblLaboratoryFee);
            Controls.Add(chkLaboratoryFee);
            Controls.Add(lblOtherFees);
            Controls.Add(cboYearLevel);
            Controls.Add(lblYearLevel);
            Controls.Add(txtUnitsEnrolled);
            Controls.Add(lblUnitsEnrolled);
            Controls.Add(txtStudentName);
            Controls.Add(lblStudentName);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Enrollment Form";
            Load += Form1_Load;
            grpScholarship.ResumeLayout(false);
            grpScholarship.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblStudentName;
        private TextBox txtStudentName;
        private Label lblUnitsEnrolled;
        private TextBox txtUnitsEnrolled;
        private Label lblYearLevel;
        private ComboBox cboYearLevel;
        private Label lblOtherFees;
        private CheckBox chkLaboratoryFee;
        private Label lblLaboratoryFee;
        private CheckBox chkStudentCouncil;
        private Label lblStudentCouncilFee;
        private CheckBox chkRegistrationCard;
        private Label lblRegistrationCardFee;
        private CheckBox chkStudentId;
        private Label lblStudentIdFee;
        private CheckBox chkCatalyst;
        private Label lblCatalystFee;
        private CheckBox chkOtherMiscellaneous;
        private Label lblOtherMiscellaneousFee;
        private GroupBox grpScholarship;
        private RadioButton rdoNonScholar;
        private RadioButton rdoFullScholar;
        private RadioButton rdoPartialScholar;
        private Label lblTotalAmount;
        private TextBox txtTotalAmount;
        private Button btnCompute;
        private Button btnClear;
        private Button btnClose;
    }
}
