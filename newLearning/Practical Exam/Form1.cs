using System;
using System.Drawing;
using System.Windows.Forms;

namespace Practical_Exam
{
    public partial class Form1 : Form
    {
        private int deniedCount = 0;

        private const int PEPPERONI = 200;
        private const int HAWAIIAN = 150;
        private const int HAM_CHEESE = 100;
        private const int CHEESE_ADDON = 50;
        private const int MUSHROOMS_ADDON = 75;
        private const double SENIOR_DISCOUNT = 0.20;
        private const double VIPCARD_DISCOUNT = 0.12;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetFormDefaults();
        }

        private void SetFormDefaults()
        {
            grpTakeOrder.Enabled = false;
            grpBillsPayment.Enabled = false;
            btnExit.Enabled = true;
            btnReset.Enabled = false;

            txtTotalAmount.ReadOnly = true;
            txtChange.ReadOnly = true;
            txtAmountGiven.Enabled = false;
            btnCompute.Enabled = false;

            txtUserName.Clear();
            txtPassword.Clear();
            txtHowMany.Clear();
            txtAmountGiven.Clear();
            txtTotalAmount.Clear();
            txtChange.Clear();

            rbPepperoni.Checked = false;
            rbHawaiian.Checked = false;
            rbHamCheese.Checked = false;
            chkCheese.Checked = false;
            chkMushrooms.Checked = false;
            cmbDiscount.SelectedIndex = -1;

            picTopping.Image = null;
            deniedCount = 0;
            txtUserName.Focus();
        }

        // ── Exit ─────────────────────────────────────────────────────
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Exit",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        // ── Log-In ───────────────────────────────────────────────────
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string user = txtUserName.Text.Trim();
            string pass = txtPassword.Text;

            string reversed = ReverseString(user);

            if (!string.IsNullOrEmpty(user) && pass == reversed)
            {
                grpTakeOrder.Enabled = true;
                btnReset.Enabled = true;
                deniedCount = 0;
            }
            else
            {
                deniedCount++;
                MessageBox.Show("Access Denied", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();

                if (deniedCount >= 3)
                {
                    MessageBox.Show("Too many failed attempts. The form will now close.",
                        "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        private string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        // ── Reset ────────────────────────────────────────────────────
        private void btnReset_Click(object sender, EventArgs e) => SetFormDefaults();

        // ── Toppings ─────────────────────────────────────────────────
        private void rbPepperoni_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPepperoni.Checked) LoadToppingImage("Pepperoni");
        }
        private void rbHawaiian_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHawaiian.Checked) LoadToppingImage("Hawaiian");
        }
        private void rbHamCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHamCheese.Checked) LoadToppingImage("Ham_Cheese");
        }

        private void LoadToppingImage(string name)
        {
            string path = Application.StartupPath + "\\" + name + ".PNG";
            try
            {
                picTopping.Image = System.IO.File.Exists(path)
                    ? Image.FromFile(path)
                    : null;
            }
            catch { picTopping.Image = null; }
        }

        // ── Ok ───────────────────────────────────────────────────────
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!rbPepperoni.Checked && !rbHawaiian.Checked && !rbHamCheese.Checked)
            {
                MessageBox.Show("Please select a pizza topping.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtHowMany.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Please enter a valid number of pizzas.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHowMany.Focus();
                return;
            }

            int basePrice = rbPepperoni.Checked ? PEPPERONI
                          : rbHawaiian.Checked ? HAWAIIAN
                          : HAM_CHEESE;

            int addOns = (chkCheese.Checked ? CHEESE_ADDON : 0)
                       + (chkMushrooms.Checked ? MUSHROOMS_ADDON : 0);

            double subtotal = (basePrice + addOns) * qty;

            double discount = 0;
            if (cmbDiscount.SelectedIndex >= 0)
            {
                string sel = cmbDiscount.SelectedItem.ToString();
                if (sel == "Senior") discount = subtotal * SENIOR_DISCOUNT;
                if (sel == "VIPCard") discount = subtotal * VIPCARD_DISCOUNT;
            }

            double total = subtotal - discount;
            txtTotalAmount.Text = total.ToString("F2");
            grpBillsPayment.Enabled = true;
            txtAmountGiven.Enabled = true;
            btnCompute.Enabled = true;
            txtAmountGiven.Focus();
        }

        // ── Cancel ───────────────────────────────────────────────────
        private void btnCancel_Click(object sender, EventArgs e)
        {
            rbPepperoni.Checked = false;
            rbHawaiian.Checked = false;
            rbHamCheese.Checked = false;
            chkCheese.Checked = false;
            chkMushrooms.Checked = false;
            cmbDiscount.SelectedIndex = -1;
            txtHowMany.Clear();
            picTopping.Image = null;

            txtTotalAmount.Clear();
            txtAmountGiven.Clear();
            txtChange.Clear();
            txtAmountGiven.Enabled = false;
            btnCompute.Enabled = false;
        }

        // ── Compute ──────────────────────────────────────────────────
        private void btnCompute_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtTotalAmount.Text, out double total)) return;

            if (!double.TryParse(txtAmountGiven.Text, out double given))
            {
                MessageBox.Show("Please enter a valid amount.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmountGiven.Focus();
                return;
            }

            if (given < total)
            {
                MessageBox.Show("Amount Given must be greater than or equal to the Total Amount.",
                    "Insufficient Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmountGiven.Clear();
                txtAmountGiven.Focus();
                return;
            }

            txtChange.Text = (given - total).ToString("F2");
        }
    }
}