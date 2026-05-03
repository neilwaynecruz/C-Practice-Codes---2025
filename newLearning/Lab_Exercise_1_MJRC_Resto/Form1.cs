namespace Lab_Exercise_1_MJRC_Resto
{
    public partial class Form1 : Form
    {
        // Credentials used by the sample (beginner friendly)
        private const string CorrectUser = "Wayne"; // sample username
        private const string CorrectPass = "123";   // sample password
        private int failedAttempts = 0; // track consecutive failed login attempts

        // Prices
        private const decimal PRICE_SOUP = 25m;
        private const decimal PRICE_COFFEE = 20m;
        private const decimal PRICE_SIOPAO = 15m;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            // Disable ordering controls until successful login
            SetOrderControlsEnabled(false);
            ClearAllFields();
        }

        private void SetOrderControlsEnabled(bool enabled)
        {
            // Order inputs
            txtSoup.Enabled = enabled;
            txtCoffee.Enabled = enabled;
            txtSiopao.Enabled = enabled;

            // Buttons
            btnComputeBill.Enabled = enabled;
            btnClearAll.Enabled = enabled;

            // Payment
            txtAmountGiven.Enabled = enabled;
            btnComputeChange.Enabled = enabled;
        }

        private void btnLogin_Click(object? sender, EventArgs e)
        {
            string user = txtUserName.Text.Trim();
            string pass = txtPassword.Text;

            if (user == CorrectUser && pass == CorrectPass)
            {
                // Successful login: enable order area
                MessageBox.Show("Login successful.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetOrderControlsEnabled(true);
                failedAttempts = 0;
                // Optionally disable login controls after success
                txtUserName.Enabled = false;
                txtPassword.Enabled = false;
                btnLogin.Enabled = false;
            }
            else
            {
                failedAttempts++;
                MessageBox.Show("Incorrect username or password.", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (failedAttempts >= 3)
                {
                    // Exit application after 3 consecutive incorrect passwords
                    MessageBox.Show("Too many failed attempts. The application will now exit.", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }

        private void btnComputeBill_Click(object? sender, EventArgs e)
        {
            // Read quantities (if blank or invalid treat as 0)
            int soup = ParseNonNegativeInt(txtSoup.Text);
            int coffee = ParseNonNegativeInt(txtCoffee.Text);
            int siopao = ParseNonNegativeInt(txtSiopao.Text);

            decimal total = soup * PRICE_SOUP + coffee * PRICE_COFFEE + siopao * PRICE_SIOPAO;

            // Display total bill (read-only textbox)
            txtTotalBill.Text = total.ToString("0.00");
        }

        private void btnComputeChange_Click(object? sender, EventArgs e)
        {
            // Ensure total bill is computed
            if (string.IsNullOrWhiteSpace(txtTotalBill.Text))
            {
                MessageBox.Show("Please compute the bill first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!decimal.TryParse(txtTotalBill.Text, out decimal total))
            {
                MessageBox.Show("Invalid total bill value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtAmountGiven.Text, out decimal given))
            {
                MessageBox.Show("Please enter a valid amount given.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Requirement: amount given must be greater than total bill
            if (given <= total)
            {
                MessageBox.Show("Kulang Bayad Nyo!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal change = given - total;
            txtChange.Text = change.ToString("0.00");
        }

        private void btnClearAll_Click(object? sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void ClearAllFields()
        {
            // Clear all input/output fields but keep login state as is
            txtSoup.Text = "0";
            txtCoffee.Text = "0";
            txtSiopao.Text = "0";
            txtTotalBill.Text = string.Empty;
            txtAmountGiven.Text = string.Empty;
            txtChange.Text = string.Empty;
        }

        private int ParseNonNegativeInt(string? s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return 0;
            if (int.TryParse(s.Trim(), out int v) && v >= 0)
                return v;
            // If invalid, show a friendly message and treat as 0
            MessageBox.Show($"Invalid number '{s}'. It will be treated as 0.", "Input warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return 0;
        }

        private void lblTotalBillText_Click(object sender, EventArgs e)
        {

        }


        private void lblAmountGiven_Click(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void labels_Click(object sender, EventArgs e)
        {

        }
    }
}
