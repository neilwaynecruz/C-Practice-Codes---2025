namespace Assignment_3_BookStore
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
        private Label lblHeader;
        private GroupBox grpOrder;
        private Label lblBookTitle;
        private Label lblLevel;
        private Label lblQuantity;
        private Label lblSubTotal;
        private CheckBox chkEnglish;
        private CheckBox chkMath;
        private CheckBox chkScience;
        private ComboBox cboEnglishLevel;
        private ComboBox cboMathLevel;
        private ComboBox cboScienceLevel;
        private TextBox txtEnglishQty;
        private TextBox txtMathQty;
        private TextBox txtScienceQty;
        private TextBox txtEnglishSubTotal;
        private TextBox txtMathSubTotal;
        private TextBox txtScienceSubTotal;
        private Label lblTotalAmount;
        private TextBox txtTotalAmount;
        private Button btnCompute;
        private Button btnClear;
        private Button btnClose;
        private Label lblSummary;
        private ListView lvSummary;
        private ColumnHeader colBookTitle;
        private ColumnHeader colLevel;
        private ColumnHeader colUnitPrice;

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblHeader = new Label();
            grpOrder = new GroupBox();
            lblBookTitle = new Label();
            lblLevel = new Label();
            lblQuantity = new Label();
            lblSubTotal = new Label();
            chkEnglish = new CheckBox();
            chkMath = new CheckBox();
            chkScience = new CheckBox();
            cboEnglishLevel = new ComboBox();
            cboMathLevel = new ComboBox();
            cboScienceLevel = new ComboBox();
            txtEnglishQty = new TextBox();
            txtMathQty = new TextBox();
            txtScienceQty = new TextBox();
            txtEnglishSubTotal = new TextBox();
            txtMathSubTotal = new TextBox();
            txtScienceSubTotal = new TextBox();
            lblTotalAmount = new Label();
            txtTotalAmount = new TextBox();
            btnCompute = new Button();
            btnClear = new Button();
            btnClose = new Button();
            lblSummary = new Label();
            lvSummary = new ListView();
            colBookTitle = new ColumnHeader();
            colLevel = new ColumnHeader();
            colUnitPrice = new ColumnHeader();
            grpOrder.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.BackColor = Color.FromArgb(35, 40, 55);
            lblHeader.Dock = DockStyle.Top;
            lblHeader.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(900, 60);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "MJRC Book Store";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpOrder
            // 
            grpOrder.Controls.Add(lblBookTitle);
            grpOrder.Controls.Add(lblLevel);
            grpOrder.Controls.Add(lblQuantity);
            grpOrder.Controls.Add(lblSubTotal);
            grpOrder.Controls.Add(chkEnglish);
            grpOrder.Controls.Add(chkMath);
            grpOrder.Controls.Add(chkScience);
            grpOrder.Controls.Add(cboEnglishLevel);
            grpOrder.Controls.Add(cboMathLevel);
            grpOrder.Controls.Add(cboScienceLevel);
            grpOrder.Controls.Add(txtEnglishQty);
            grpOrder.Controls.Add(txtMathQty);
            grpOrder.Controls.Add(txtScienceQty);
            grpOrder.Controls.Add(txtEnglishSubTotal);
            grpOrder.Controls.Add(txtMathSubTotal);
            grpOrder.Controls.Add(txtScienceSubTotal);
            grpOrder.Controls.Add(lblTotalAmount);
            grpOrder.Controls.Add(txtTotalAmount);
            grpOrder.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            grpOrder.Location = new Point(30, 80);
            grpOrder.Name = "grpOrder";
            grpOrder.Size = new Size(840, 250);
            grpOrder.TabIndex = 1;
            grpOrder.TabStop = false;
            grpOrder.Text = "";
            // 
            // lblBookTitle
            // 
            lblBookTitle.AutoSize = true;
            lblBookTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            lblBookTitle.Location = new Point(20, 35);
            lblBookTitle.Name = "lblBookTitle";
            lblBookTitle.Size = new Size(74, 17);
            lblBookTitle.TabIndex = 0;
            lblBookTitle.Text = "Book Title";
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            lblLevel.Location = new Point(340, 35);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(42, 17);
            lblLevel.TabIndex = 1;
            lblLevel.Text = "Level";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuantity.Location = new Point(500, 35);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(61, 17);
            lblQuantity.TabIndex = 2;
            lblQuantity.Text = "Quantity";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubTotal.Location = new Point(650, 35);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(67, 17);
            lblSubTotal.TabIndex = 3;
            lblSubTotal.Text = "Sub-Total";
            // 
            // chkEnglish
            // 
            chkEnglish.AutoSize = true;
            chkEnglish.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            chkEnglish.Location = new Point(20, 70);
            chkEnglish.Name = "chkEnglish";
            chkEnglish.Size = new Size(128, 21);
            chkEnglish.TabIndex = 4;
            chkEnglish.Text = "Everyday English";
            chkEnglish.UseVisualStyleBackColor = true;
            // 
            // chkMath
            // 
            chkMath.AutoSize = true;
            chkMath.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            chkMath.Location = new Point(20, 110);
            chkMath.Name = "chkMath";
            chkMath.Size = new Size(161, 21);
            chkMath.TabIndex = 5;
            chkMath.Text = "Integrated Mathematics";
            chkMath.UseVisualStyleBackColor = true;
            // 
            // chkScience
            // 
            chkScience.AutoSize = true;
            chkScience.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            chkScience.Location = new Point(20, 150);
            chkScience.Name = "chkScience";
            chkScience.Size = new Size(144, 21);
            chkScience.TabIndex = 6;
            chkScience.Text = "Wonders of Science";
            chkScience.UseVisualStyleBackColor = true;
            // 
            // cboEnglishLevel
            // 
            cboEnglishLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEnglishLevel.FormattingEnabled = true;
            cboEnglishLevel.Location = new Point(300, 68);
            cboEnglishLevel.Name = "cboEnglishLevel";
            cboEnglishLevel.Size = new Size(140, 25);
            cboEnglishLevel.TabIndex = 7;
            // 
            // cboMathLevel
            // 
            cboMathLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMathLevel.FormattingEnabled = true;
            cboMathLevel.Location = new Point(300, 108);
            cboMathLevel.Name = "cboMathLevel";
            cboMathLevel.Size = new Size(140, 25);
            cboMathLevel.TabIndex = 8;
            // 
            // cboScienceLevel
            // 
            cboScienceLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboScienceLevel.FormattingEnabled = true;
            cboScienceLevel.Location = new Point(300, 148);
            cboScienceLevel.Name = "cboScienceLevel";
            cboScienceLevel.Size = new Size(140, 25);
            cboScienceLevel.TabIndex = 9;
            // 
            // txtEnglishQty
            // 
            txtEnglishQty.Location = new Point(470, 68);
            txtEnglishQty.Name = "txtEnglishQty";
            txtEnglishQty.Size = new Size(120, 25);
            txtEnglishQty.TabIndex = 10;
            // 
            // txtMathQty
            // 
            txtMathQty.Location = new Point(470, 108);
            txtMathQty.Name = "txtMathQty";
            txtMathQty.Size = new Size(120, 25);
            txtMathQty.TabIndex = 11;
            // 
            // txtScienceQty
            // 
            txtScienceQty.Location = new Point(470, 148);
            txtScienceQty.Name = "txtScienceQty";
            txtScienceQty.Size = new Size(120, 25);
            txtScienceQty.TabIndex = 12;
            // 
            // txtEnglishSubTotal
            // 
            txtEnglishSubTotal.Location = new Point(620, 68);
            txtEnglishSubTotal.Name = "txtEnglishSubTotal";
            txtEnglishSubTotal.ReadOnly = true;
            txtEnglishSubTotal.Size = new Size(170, 25);
            txtEnglishSubTotal.TabIndex = 13;
            // 
            // txtMathSubTotal
            // 
            txtMathSubTotal.Location = new Point(620, 108);
            txtMathSubTotal.Name = "txtMathSubTotal";
            txtMathSubTotal.ReadOnly = true;
            txtMathSubTotal.Size = new Size(170, 25);
            txtMathSubTotal.TabIndex = 14;
            // 
            // txtScienceSubTotal
            // 
            txtScienceSubTotal.Location = new Point(620, 148);
            txtScienceSubTotal.Name = "txtScienceSubTotal";
            txtScienceSubTotal.ReadOnly = true;
            txtScienceSubTotal.Size = new Size(170, 25);
            txtScienceSubTotal.TabIndex = 15;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalAmount.Location = new Point(500, 195);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(95, 19);
            lblTotalAmount.TabIndex = 16;
            lblTotalAmount.Text = "Total Amount";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Location = new Point(620, 192);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(170, 25);
            txtTotalAmount.TabIndex = 17;
            // 
            // btnCompute
            // 
            btnCompute.BackColor = Color.FromArgb(35, 40, 55);
            btnCompute.FlatStyle = FlatStyle.Flat;
            btnCompute.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCompute.ForeColor = Color.White;
            btnCompute.Location = new Point(120, 350);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(170, 40);
            btnCompute.TabIndex = 2;
            btnCompute.Text = "btn-COMPUTE";
            btnCompute.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(90, 95, 110);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(360, 350);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(170, 40);
            btnClear.TabIndex = 3;
            btnClear.Text = "btn-CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(120, 40, 40);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(600, 350);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(170, 40);
            btnClose.TabIndex = 4;
            btnClose.Text = "btn-CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblSummary.Location = new Point(30, 410);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(153, 19);
            lblSummary.TabIndex = 5;
            lblSummary.Text = "SUMMARY OF ORDERS:";
            // 
            // lvSummary
            // 
            lvSummary.Columns.AddRange(new ColumnHeader[] { colBookTitle, colLevel, colUnitPrice });
            lvSummary.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lvSummary.FullRowSelect = true;
            lvSummary.GridLines = true;
            lvSummary.Location = new Point(30, 440);
            lvSummary.Name = "lvSummary";
            lvSummary.Size = new Size(840, 150);
            lvSummary.TabIndex = 6;
            lvSummary.UseCompatibleStateImageBehavior = false;
            lvSummary.View = View.Details;
            // 
            // colBookTitle
            // 
            colBookTitle.Text = "Book Title";
            colBookTitle.Width = 420;
            // 
            // colLevel
            // 
            colLevel.Text = "Level";
            colLevel.Width = 200;
            // 
            // colUnitPrice
            // 
            colUnitPrice.Text = "Unit Price";
            colUnitPrice.Width = 200;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 620);
            Controls.Add(lvSummary);
            Controls.Add(lblSummary);
            Controls.Add(btnClose);
            Controls.Add(btnClear);
            Controls.Add(btnCompute);
            Controls.Add(grpOrder);
            Controls.Add(lblHeader);
            Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Store";
            grpOrder.ResumeLayout(false);
            grpOrder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
