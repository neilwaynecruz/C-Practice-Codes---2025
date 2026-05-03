namespace Assignment_2_Employees
{
    public partial class Form1 : Form
    {
        private const decimal Rank1Rate = 100m;
        private const decimal Rank2Rate = 200m;
        private const decimal Rank3Rate = 300m;

        private const decimal GsisAmount = 1000m;
        private const decimal PhilhealthAmount = 200m;
        private const decimal PagibigAmount = 300m;
        private const decimal WithholdingTaxRate = 0.10m;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetFormToDefault();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtHoursWorked.Text.Trim(), out int hoursWorked) || hoursWorked <= 0)
            {
                MessageBox.Show(
                    "Please input a correct positive integer value for No. of Hours Worked.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtHoursWorked.Focus();
                return;
            }

            if (cmbEmployeeRank.SelectedIndex <= 0)
            {
                MessageBox.Show(
                    "Please choose a correct Employee Rank.",
                    "Invalid Rank",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                cmbEmployeeRank.Focus();
                return;
            }

            decimal ratePerHour = GetRatePerHour(cmbEmployeeRank.SelectedItem!.ToString()!);
            decimal grossSalary = hoursWorked * ratePerHour;
            decimal totalDeductions = ComputeTotalDeductions(grossSalary);

            decimal netPay = grossSalary - totalDeductions;
            if (rdoWithLoan.Checked)
            {
                netPay /= 2m;
            }

            txtGrossSalary.Text = grossSalary.ToString("0.00");
            txtTotalDeductions.Text = totalDeductions.ToString("0.00");
            txtNetPay.Text = netPay.ToString("0.00");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetFormToDefault();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show(
                "Are you sure?",
                "Close",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (response == DialogResult.Yes)
            {
                Close();
            }
        }

        private decimal ComputeTotalDeductions(decimal grossSalary)
        {
            decimal totalDeductions = 0m;

            if (chkGsis.Checked)
            {
                totalDeductions += GsisAmount;
            }

            if (chkPhilhealth.Checked)
            {
                totalDeductions += PhilhealthAmount;
            }

            if (chkPagibig.Checked)
            {
                totalDeductions += PagibigAmount;
            }

            if (chkWithholdingTax.Checked)
            {
                totalDeductions += grossSalary * WithholdingTaxRate;
            }

            return totalDeductions;
        }

        private decimal GetRatePerHour(string rank)
        {
            return rank switch
            {
                "Rank 1" => Rank1Rate,
                "Rank 2" => Rank2Rate,
                "Rank 3" => Rank3Rate,
                _ => 0m
            };
        }

        private void ResetFormToDefault()
        {
            txtEmployeeName.Clear();
            txtHoursWorked.Clear();

            cmbEmployeeRank.SelectedIndex = 0;

            chkGsis.Checked = false;
            chkPhilhealth.Checked = false;
            chkWithholdingTax.Checked = false;
            chkPagibig.Checked = false;

            rdoWithoutLoan.Checked = true;
            rdoWithLoan.Checked = false;

            txtGrossSalary.Clear();
            txtTotalDeductions.Clear();
            txtNetPay.Clear();

            txtEmployeeName.Focus();
        }

        private void txtEmployeeName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
