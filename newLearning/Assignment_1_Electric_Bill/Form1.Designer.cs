namespace Assignment_1_Electric_Bill
{
    partial class Form1
    {
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblPreviousReading;
        private System.Windows.Forms.TextBox txtPreviousReading;
        private System.Windows.Forms.Label lblCurrentReading;
        private System.Windows.Forms.TextBox txtCurrentReading;
        private System.Windows.Forms.Label lblKwhUsed;
        private System.Windows.Forms.TextBox txtKwhUsed;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.ComboBox cmbAccountType;
        private System.Windows.Forms.Label lblElectricBill;
        private System.Windows.Forms.TextBox txtElectricBill;
        private System.Windows.Forms.Label lblSystemCharges;
        private System.Windows.Forms.TextBox txtSystemCharges;
        private System.Windows.Forms.Label lblTotalBill;
        private System.Windows.Forms.TextBox txtTotalBill;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.GroupBox grpInputs;
        private System.Windows.Forms.GroupBox grpResults;
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
            lblArea = new Label();
            cmbArea = new ComboBox();
            lblAccountNumber = new Label();
            txtAccountNumber = new TextBox();
            lblCustomerName = new Label(); 
            txtCustomerName = new TextBox();
            lblPreviousReading = new Label();
            txtPreviousReading = new TextBox();
            lblCurrentReading = new Label();
            txtCurrentReading = new TextBox(); 
            lblKwhUsed = new Label();
            txtKwhUsed = new TextBox();
            lblAccountType = new Label();
            cmbAccountType = new ComboBox();
            lblElectricBill = new Label(); 
            txtElectricBill = new TextBox();
            lblSystemCharges = new Label();
            txtSystemCharges = new TextBox();
            lblTotalBill = new Label();
            txtTotalBill = new TextBox(); 
            btnCompute = new Button();
            btnClear = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(20, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(235, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "MJRC Electric Company";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(20, 50);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(110, 20);
            lblArea.TabIndex = 1;
            lblArea.Text = "Customer Area:";
            // 
            // cmbArea
            // 
            cmbArea.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbArea.Items.AddRange(new object[] { "NCR", "PROVINCIAL" });
            cmbArea.Location = new Point(150, 47);
            cmbArea.Name = "cmbArea";
            cmbArea.Size = new Size(354, 28);
            cmbArea.TabIndex = 2;
            // 
            // lblAccountNumber
            // 
            lblAccountNumber.AutoSize = true;
            lblAccountNumber.Location = new Point(20, 85);
            lblAccountNumber.Name = "lblAccountNumber";
            lblAccountNumber.Size = new Size(124, 20);
            lblAccountNumber.TabIndex = 3;
            lblAccountNumber.Text = "Account Number:";
            // 
            // txtAccountNumber
            // 
            txtAccountNumber.Location = new Point(150, 82);
            txtAccountNumber.Name = "txtAccountNumber";
            txtAccountNumber.Size = new Size(354, 27);
            txtAccountNumber.TabIndex = 4;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(20, 120);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(119, 20);
            lblCustomerName.TabIndex = 5;
            lblCustomerName.Text = "Customer Name:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(150, 117);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(354, 27);
            txtCustomerName.TabIndex = 6;
            // 
            // lblPreviousReading
            // 
            lblPreviousReading.AutoSize = true;
            lblPreviousReading.Location = new Point(20, 155);
            lblPreviousReading.Name = "lblPreviousReading";
            lblPreviousReading.Size = new Size(126, 20);
            lblPreviousReading.TabIndex = 7;
            lblPreviousReading.Text = "Previous Reading:";
            // 
            // txtPreviousReading
            // 
            txtPreviousReading.Location = new Point(150, 152);
            txtPreviousReading.Name = "txtPreviousReading";
            txtPreviousReading.Size = new Size(354, 27);
            txtPreviousReading.TabIndex = 8;
            // 
            // lblCurrentReading
            // 
            lblCurrentReading.AutoSize = true;
            lblCurrentReading.Location = new Point(20, 190);
            lblCurrentReading.Name = "lblCurrentReading";
            lblCurrentReading.Size = new Size(119, 20);
            lblCurrentReading.TabIndex = 9;
            lblCurrentReading.Text = "Current Reading:";
            // 
            // txtCurrentReading
            // 
            txtCurrentReading.Location = new Point(150, 187);
            txtCurrentReading.Name = "txtCurrentReading";
            txtCurrentReading.Size = new Size(354, 27);
            txtCurrentReading.TabIndex = 10;
            // 
            // lblKwhUsed
            // 
            lblKwhUsed.AutoSize = true;
            lblKwhUsed.Location = new Point(20, 225);
            lblKwhUsed.Name = "lblKwhUsed";
            lblKwhUsed.Size = new Size(79, 20);
            lblKwhUsed.TabIndex = 11;
            lblKwhUsed.Text = "KwH Used:";
            // 
            // txtKwhUsed
            // 
            txtKwhUsed.Location = new Point(150, 222);
            txtKwhUsed.Name = "txtKwhUsed";
            txtKwhUsed.Size = new Size(354, 27);
            txtKwhUsed.TabIndex = 12;
            // 
            // lblAccountType
            // 
            lblAccountType.AutoSize = true;
            lblAccountType.Location = new Point(20, 260);
            lblAccountType.Name = "lblAccountType";
            lblAccountType.Size = new Size(101, 20);
            lblAccountType.TabIndex = 13;
            lblAccountType.Text = "Account Type:";
            // 
            // cmbAccountType
            // 
            cmbAccountType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAccountType.Items.AddRange(new object[] { "Residential", "Commercial", "Industrial" });
            cmbAccountType.Location = new Point(150, 257);
            cmbAccountType.Name = "cmbAccountType";
            cmbAccountType.Size = new Size(354, 28);
            cmbAccountType.TabIndex = 14;
            // 
            // lblElectricBill
            // 
            lblElectricBill.AutoSize = true;
            lblElectricBill.Location = new Point(20, 295);
            lblElectricBill.Name = "lblElectricBill";
            lblElectricBill.Size = new Size(85, 20);
            lblElectricBill.TabIndex = 15;
            lblElectricBill.Text = "Electric Bill:";
            // 
            // txtElectricBill
            // 
            txtElectricBill.Location = new Point(150, 292);
            txtElectricBill.Name = "txtElectricBill";
            txtElectricBill.Size = new Size(354, 27);
            txtElectricBill.TabIndex = 16;
            // 
            // lblSystemCharges
            // 
            lblSystemCharges.AutoSize = true;
            lblSystemCharges.Location = new Point(20, 330);
            lblSystemCharges.Name = "lblSystemCharges";
            lblSystemCharges.Size = new Size(116, 20);
            lblSystemCharges.TabIndex = 17;
            lblSystemCharges.Text = "System Charges:";
            // 
            // txtSystemCharges
            // 
            txtSystemCharges.Location = new Point(150, 327);
            txtSystemCharges.Name = "txtSystemCharges";
            txtSystemCharges.Size = new Size(354, 27);
            txtSystemCharges.TabIndex = 18;
            // 
            // lblTotalBill
            // 
            lblTotalBill.AutoSize = true;
            lblTotalBill.Location = new Point(20, 365);
            lblTotalBill.Name = "lblTotalBill";
            lblTotalBill.Size = new Size(70, 20);
            lblTotalBill.TabIndex = 19;
            lblTotalBill.Text = "Total Bill:";
            // 
            // txtTotalBill
            // 
            txtTotalBill.Location = new Point(150, 362);
            txtTotalBill.Name = "txtTotalBill";
            txtTotalBill.Size = new Size(354, 27);
            txtTotalBill.TabIndex = 20;
            // 
            // btnCompute
            // 
            btnCompute.Location = new Point(53, 416);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(135, 51);
            btnCompute.TabIndex = 21;
            btnCompute.Text = "&COMPUTE";
            btnCompute.UseVisualStyleBackColor = true;
            btnCompute.Click += btnCompute_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(209, 416);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(135, 51);
            btnClear.TabIndex = 22;
            btnClear.Text = "C&LEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(357, 416);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(135, 51);
            btnClose.TabIndex = 23;
            btnClose.Text = "C&LOSE";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 498);
            Controls.Add(lblTitle);
            Controls.Add(lblArea);
            Controls.Add(cmbArea);
            Controls.Add(lblAccountNumber);
            Controls.Add(txtAccountNumber);
            Controls.Add(lblCustomerName);
            Controls.Add(txtCustomerName);
            Controls.Add(lblPreviousReading);
            Controls.Add(txtPreviousReading);
            Controls.Add(lblCurrentReading);
            Controls.Add(txtCurrentReading);
            Controls.Add(lblKwhUsed);
            Controls.Add(txtKwhUsed);
            Controls.Add(lblAccountType);
            Controls.Add(cmbAccountType);
            Controls.Add(lblElectricBill);
            Controls.Add(txtElectricBill);
            Controls.Add(lblSystemCharges);
            Controls.Add(txtSystemCharges);
            Controls.Add(lblTotalBill);
            Controls.Add(txtTotalBill);
            Controls.Add(btnCompute);
            Controls.Add(btnClear);
            Controls.Add(btnClose);
            Name = "Form1";
            Text = "Electric Bill Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
