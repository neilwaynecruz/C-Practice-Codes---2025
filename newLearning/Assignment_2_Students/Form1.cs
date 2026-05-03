namespace Assignment_2_Students
{
    public partial class Form1 : Form
    {
        private const decimal UnitFee = 12m;
        private const decimal LaboratoryFee = 200m;
        private const decimal StudentCouncilFee = 50m;
        private const decimal RegistrationCardFee = 50m;
        private const decimal StudentIdFee = 50m;
        private const decimal CatalystFee = 50m;
        private const decimal OtherMiscellaneousFee = 100m;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            bool hasError = false;

            if (!int.TryParse(txtUnitsEnrolled.Text.Trim(), out int unitsEnrolled) || unitsEnrolled <= 0)
            {
                MessageBox.Show(
                    "Please input a correct positive integer value for Units Enrolled.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                hasError = true;
            }

            if (cboYearLevel.SelectedIndex <= 0)
            {
                MessageBox.Show(
                    "Please choose a correct Year Level.",
                    "Invalid Year Level",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                hasError = true;
            }

            if (hasError)
            {
                return;
            }

            decimal otherFeesTotal = GetOtherFeesTotal();
            decimal yearLevelFee = GetYearLevelFee(cboYearLevel.SelectedItem?.ToString() ?? string.Empty);
            decimal baseTotal = (unitsEnrolled * UnitFee) + otherFeesTotal + yearLevelFee;

            decimal totalAmount;

            if (rdoFullScholar.Checked)
            {
                totalAmount = 0m;
            }
            else if (rdoPartialScholar.Checked)
            {
                totalAmount = baseTotal / 2m;
            }
            else
            {
                totalAmount = baseTotal;
            }

            txtTotalAmount.Text = totalAmount.ToString("0.00");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure?",
                "Close Form",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private decimal GetOtherFeesTotal()
        {
            decimal total = 0m;

            if (chkLaboratoryFee.Checked)
            {
                total += LaboratoryFee;
            }

            if (chkStudentCouncil.Checked)
            {
                total += StudentCouncilFee;
            }

            if (chkRegistrationCard.Checked)
            {
                total += RegistrationCardFee;
            }

            if (chkStudentId.Checked)
            {
                total += StudentIdFee;
            }

            if (chkCatalyst.Checked)
            {
                total += CatalystFee;
            }

            if (chkOtherMiscellaneous.Checked)
            {
                total += OtherMiscellaneousFee;
            }

            return total;
        }

        private static decimal GetYearLevelFee(string yearLevel)
        {
            return yearLevel switch
            {
                "1st Year" => 100m,
                "2nd Year" => 200m,
                "3rd Year" => 300m,
                "4th Year" => 400m,
                "5th Year" => 500m,
                _ => 0m
            };
        }

        private void ResetForm()
        {
            txtStudentName.Clear();
            txtUnitsEnrolled.Clear();
            cboYearLevel.SelectedIndex = 0;

            chkLaboratoryFee.Checked = false;
            chkStudentCouncil.Checked = false;
            chkRegistrationCard.Checked = false;
            chkStudentId.Checked = false;
            chkCatalyst.Checked = false;
            chkOtherMiscellaneous.Checked = false;

            rdoNonScholar.Checked = true;
            txtTotalAmount.Clear();

            txtStudentName.Focus();
        }
    }
}
