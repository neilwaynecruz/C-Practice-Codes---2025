namespace Assignment_1_Electric_Bill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // On form load all controls are enabled and the result textboxes are not editable
            cmbArea.Enabled = true;
            txtAccountNumber.Enabled = true;
            txtCustomerName.Enabled = true;
            txtPreviousReading.Enabled = true;
            txtCurrentReading.Enabled = true;
            cmbAccountType.Enabled = true;

            // Result fields should not be editable by the user
            txtKwhUsed.ReadOnly = true;
            txtElectricBill.ReadOnly = true;
            txtSystemCharges.ReadOnly = true;
            txtTotalBill.ReadOnly = true;
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            // Validate Previous and Current readings are positive integers
            if (!int.TryParse(txtPreviousReading.Text.Trim(), out int prev) || prev < 0 ||
                !int.TryParse(txtCurrentReading.Text.Trim(), out int curr) || curr < 0)
            {
                MessageBox.Show("Please input a correct positive integer value", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Current must be greater than Previous
            if (curr <= prev)
            {
                MessageBox.Show("Incorrect Reading", "Reading Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCurrentReading.Focus();
                return;
            }

            // Compute kWh used
            int kwh = curr - prev;
            txtKwhUsed.Text = kwh.ToString();

            // Determine price per kWh based on account type
            if (cmbAccountType.SelectedItem == null)
            {
                MessageBox.Show("Please select an Account Type", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string accountType = cmbAccountType.SelectedItem.ToString();
            decimal pricePerKw = 0m;
            switch (accountType)
            {
                case "Residential":
                    pricePerKw = 15m;
                    break;
                case "Commercial":
                    pricePerKw = 30m;
                    break;
                case "Industrial":
                    pricePerKw = 45m;
                    break;
                default:
                    MessageBox.Show("Unknown Account Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            decimal electricBill = kwh * pricePerKw;

            // Determine system charge percent based on area and account type
            if (cmbArea.SelectedItem == null)
            {
                MessageBox.Show("Please select Customer Area (NCR or PROVINCIAL)", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string area = cmbArea.SelectedItem.ToString();
            decimal systemPercent = 0m; // as a decimal fraction (e.g., 0.03)

            if (area == "NCR")
            {
                // Metro Manila percentages
                switch (accountType)
                {
                    case "Residential": systemPercent = 0.03m; break;
                    case "Commercial": systemPercent = 0.06m; break;
                    case "Industrial": systemPercent = 0.09m; break;
                }
            }
            else // Provincial
            {
                switch (accountType)
                {
                    case "Residential": systemPercent = 0.02m; break;
                    case "Commercial": systemPercent = 0.04m; break;
                    case "Industrial": systemPercent = 0.06m; break;
                }
            }

            decimal systemCharges = electricBill * systemPercent;
            decimal totalBill = electricBill + systemCharges;

            // Display results formatted with two decimal places
            txtElectricBill.Text = electricBill.ToString("N2");
            txtSystemCharges.Text = systemCharges.ToString("N2");
            txtTotalBill.Text = totalBill.ToString("N2");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Reset form to default values (same as form load)
            cmbArea.SelectedIndex = -1;
            txtAccountNumber.Text = string.Empty;
            txtCustomerName.Text = string.Empty;
            txtPreviousReading.Text = string.Empty;
            txtCurrentReading.Text = string.Empty;
            cmbAccountType.SelectedIndex = -1;

            txtKwhUsed.Text = string.Empty;
            txtElectricBill.Text = string.Empty;
            txtSystemCharges.Text = string.Empty;
            txtTotalBill.Text = string.Empty;

            txtPreviousReading.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                this.Close(); 
            }
                
        }
    }
}
