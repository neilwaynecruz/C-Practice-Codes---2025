namespace Assignment_4_CarRental
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label labelTitle;
        private Label labelCustomerName;
        private TextBox textCustomerName;
        private Label labelCarType;
        private ComboBox comboCarType;
        private PictureBox pictureVehicle;
        private GroupBox groupTravelDate;
        private Label labelFrom;
        private Label labelTo;
        private DateTimePicker dateFrom;
        private DateTimePicker dateTo;
        private Label labelDestination;
        private ComboBox comboDestination;
        private Label labelDriver;
        private ComboBox comboDriver;
        private Button buttonReserve;
        private Button buttonClose;
        private GroupBox groupRates;
        private Label labelRatesTitle;
        private Label labelRateMangPinong;
        private Label labelRateKuyaBoy;

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
            // Form title
            labelTitle = new Label();
            labelCustomerName = new Label();
            textCustomerName = new TextBox();
            labelCarType = new Label();
            comboCarType = new ComboBox();
            pictureVehicle = new PictureBox();
            groupTravelDate = new GroupBox();
            labelFrom = new Label();
            labelTo = new Label();
            dateFrom = new DateTimePicker();
            dateTo = new DateTimePicker();
            labelDestination = new Label();
            comboDestination = new ComboBox();
            labelDriver = new Label();
            comboDriver = new ComboBox();
            buttonReserve = new Button();
            buttonClose = new Button();
            groupRates = new GroupBox();
            labelRatesTitle = new Label();
            labelRateMangPinong = new Label();
            labelRateKuyaBoy = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureVehicle).BeginInit();
            groupTravelDate.SuspendLayout();
            groupRates.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.FromArgb(45, 45, 45);
            labelTitle.Location = new Point(20, 18);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(203, 32);
            labelTitle.TabIndex = 13;
            labelTitle.Text = "MJRC Car Rental";
            // 
            // Customer input section
            // 
            // 
            // labelCustomerName
            // 
            labelCustomerName.AutoSize = true;
            labelCustomerName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCustomerName.Location = new Point(24, 65);
            labelCustomerName.Name = "labelCustomerName";
            labelCustomerName.Size = new Size(144, 23);
            labelCustomerName.TabIndex = 12;
            labelCustomerName.Text = "Customer Name:";
            // 
            // textCustomerName
            // 
            textCustomerName.Location = new Point(170, 61);
            textCustomerName.Name = "textCustomerName";
            textCustomerName.Size = new Size(300, 30);
            textCustomerName.TabIndex = 11;
            // 
            // labelCarType
            // 
            labelCarType.AutoSize = true;
            labelCarType.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCarType.Location = new Point(24, 102);
            labelCarType.Name = "labelCarType";
            labelCarType.Size = new Size(85, 23);
            labelCarType.TabIndex = 10;
            labelCarType.Text = "Car Type:";
            // 
            // comboCarType
            // 
            comboCarType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCarType.FlatStyle = FlatStyle.Flat;
            comboCarType.Location = new Point(170, 98);
            comboCarType.Name = "comboCarType";
            comboCarType.Size = new Size(200, 31);
            comboCarType.TabIndex = 9;
            comboCarType.SelectedIndexChanged += comboCarType_SelectedIndexChanged;
            // 
            // Vehicle preview image
            // 
            // 
            // pictureVehicle
            // 
            pictureVehicle.BackColor = Color.White;
            pictureVehicle.BorderStyle = BorderStyle.FixedSingle;
            pictureVehicle.InitialImage = null;
            pictureVehicle.Location = new Point(150, 140);
            pictureVehicle.Name = "pictureVehicle";
            pictureVehicle.Size = new Size(320, 200);
            pictureVehicle.SizeMode = PictureBoxSizeMode.Zoom;
            pictureVehicle.TabIndex = 8;
            pictureVehicle.TabStop = false;
            pictureVehicle.Click += pictureVehicle_Click;
            // 
            // Travel date range picker
            // 
            // 
            // groupTravelDate
            // 
            groupTravelDate.Controls.Add(labelFrom);
            groupTravelDate.Controls.Add(labelTo);
            groupTravelDate.Controls.Add(dateFrom);
            groupTravelDate.Controls.Add(dateTo);
            groupTravelDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupTravelDate.Location = new Point(24, 320);
            groupTravelDate.Name = "groupTravelDate";
            groupTravelDate.Size = new Size(446, 100);
            groupTravelDate.TabIndex = 7;
            groupTravelDate.TabStop = false;
            groupTravelDate.Text = "Travel Date";
            // 
            // labelFrom
            // 
            labelFrom.AutoSize = true;
            labelFrom.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFrom.Location = new Point(16, 30);
            labelFrom.Name = "labelFrom";
            labelFrom.Size = new Size(50, 21);
            labelFrom.TabIndex = 0;
            labelFrom.Text = "From:";
            // 
            // labelTo
            // 
            labelTo.AutoSize = true;
            labelTo.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTo.Location = new Point(16, 62);
            labelTo.Name = "labelTo";
            labelTo.Size = new Size(28, 21);
            labelTo.TabIndex = 1;
            labelTo.Text = "To:";
            // 
            // dateFrom
            // 
            dateFrom.Location = new Point(70, 26);
            dateFrom.Name = "dateFrom";
            dateFrom.Size = new Size(350, 30);
            dateFrom.TabIndex = 2;
            // 
            // dateTo
            // 
            dateTo.Location = new Point(70, 58);
            dateTo.Name = "dateTo";
            dateTo.Size = new Size(350, 30);
            dateTo.TabIndex = 3;
            // 
            // Destination and driver selection
            // 
            // 
            // labelDestination
            // 
            labelDestination.AutoSize = true;
            labelDestination.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDestination.Location = new Point(24, 435);
            labelDestination.Name = "labelDestination";
            labelDestination.Size = new Size(107, 23);
            labelDestination.TabIndex = 6;
            labelDestination.Text = "Destination:";
            // 
            // comboDestination
            // 
            comboDestination.DropDownStyle = ComboBoxStyle.DropDownList;
            comboDestination.FlatStyle = FlatStyle.Flat;
            comboDestination.Location = new Point(170, 431);
            comboDestination.Name = "comboDestination";
            comboDestination.Size = new Size(200, 31);
            comboDestination.TabIndex = 5;
            // 
            // labelDriver
            // 
            labelDriver.AutoSize = true;
            labelDriver.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDriver.Location = new Point(24, 472);
            labelDriver.Name = "labelDriver";
            labelDriver.Size = new Size(128, 23);
            labelDriver.TabIndex = 4;
            labelDriver.Text = "Driver's Name:";
            // 
            // comboDriver
            // 
            comboDriver.DropDownStyle = ComboBoxStyle.DropDownList;
            comboDriver.FlatStyle = FlatStyle.Flat;
            comboDriver.Location = new Point(170, 468);
            comboDriver.Name = "comboDriver";
            comboDriver.Size = new Size(200, 31);
            comboDriver.TabIndex = 3;
            // 
            // Action buttons and driver rates display
            // 
            // 
            // buttonReserve
            // 
            buttonReserve.BackColor = Color.FromArgb(52, 120, 246);
            buttonReserve.FlatStyle = FlatStyle.Flat;
            buttonReserve.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonReserve.ForeColor = Color.White;
            buttonReserve.Location = new Point(170, 560);
            buttonReserve.Name = "buttonReserve";
            buttonReserve.Size = new Size(120, 35);
            buttonReserve.TabIndex = 2;
            buttonReserve.Text = "Reserve";
            buttonReserve.UseVisualStyleBackColor = false;
            buttonReserve.Click += buttonReserve_Click;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = Color.FromArgb(230, 230, 230);
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClose.ForeColor = Color.FromArgb(45, 45, 45);
            buttonClose.Location = new Point(310, 560);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(120, 35);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // groupRates
            // 
            groupRates.BackColor = Color.White;
            groupRates.Controls.Add(labelRatesTitle);
            groupRates.Controls.Add(labelRateMangPinong);
            groupRates.Controls.Add(labelRateKuyaBoy);
            groupRates.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupRates.Location = new Point(24, 510);
            groupRates.Name = "groupRates";
            groupRates.Size = new Size(446, 40);
            groupRates.TabIndex = 0;
            groupRates.TabStop = false;
            // 
            // labelRatesTitle
            // 
            labelRatesTitle.AutoSize = true;
            labelRatesTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRatesTitle.Location = new Point(12, 15);
            labelRatesTitle.Name = "labelRatesTitle";
            labelRatesTitle.Size = new Size(110, 21);
            labelRatesTitle.TabIndex = 0;
            labelRatesTitle.Text = "Driver's Rate:";
            // 
            // labelRateMangPinong
            // 
            labelRateMangPinong.AutoSize = true;
            labelRateMangPinong.Location = new Point(130, 15);
            labelRateMangPinong.Name = "labelRateMangPinong";
            labelRateMangPinong.Size = new Size(168, 21);
            labelRateMangPinong.TabIndex = 1;
            labelRateMangPinong.Text = "Mang Pinong: 500/day";
            // 
            // labelRateKuyaBoy
            // 
            labelRateKuyaBoy.AutoSize = true;
            labelRateKuyaBoy.Location = new Point(300, 15);
            labelRateKuyaBoy.Name = "labelRateKuyaBoy";
            labelRateKuyaBoy.Size = new Size(139, 21);
            labelRateKuyaBoy.TabIndex = 2;
            labelRateKuyaBoy.Text = "Kuya Boy: 750/day";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(500, 620);
            Controls.Add(groupRates);
            Controls.Add(buttonClose);
            Controls.Add(buttonReserve);
            Controls.Add(comboDriver);
            Controls.Add(labelDriver);
            Controls.Add(comboDestination);
            Controls.Add(labelDestination);
            Controls.Add(groupTravelDate);
            Controls.Add(pictureVehicle);
            Controls.Add(comboCarType);
            Controls.Add(labelCarType);
            Controls.Add(textCustomerName);
            Controls.Add(labelCustomerName);
            Controls.Add(labelTitle);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MJRC Car Rental";
            // Wire up the form load event to initialize control defaults.
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureVehicle).EndInit();
            groupTravelDate.ResumeLayout(false);
            groupTravelDate.PerformLayout();
            groupRates.ResumeLayout(false);
            groupRates.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
