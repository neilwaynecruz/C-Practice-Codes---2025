namespace Assignment_3_BookStore
{
    public partial class Form1 : Form
    {
        // Listahan ng levels para sa combo boxes, simple lang para madaling sundan.
        private readonly string[] Levels = { "", "NURSERY", "KINDER", "PREP" };

        public Form1()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // Load level choices once.
            cboEnglishLevel.Items.AddRange(Levels);
            cboMathLevel.Items.AddRange(Levels);
            cboScienceLevel.Items.AddRange(Levels);

            // Reset natin lahat para clean ang start.
            ResetForm();

            // Kapag chineck/unchecked, i-on/off natin yung katapat na fields.
            chkEnglish.CheckedChanged += (sender, args) => ToggleRow(chkEnglish, cboEnglishLevel, txtEnglishQty, txtEnglishSubTotal, "Everyday English");
            chkMath.CheckedChanged += (sender, args) => ToggleRow(chkMath, cboMathLevel, txtMathQty, txtMathSubTotal, "Integrated Mathematics");
            chkScience.CheckedChanged += (sender, args) => ToggleRow(chkScience, cboScienceLevel, txtScienceQty, txtScienceSubTotal, "Wonders of Science");

            // Kapag pumili ng level, update natin yung list view summary.
            cboEnglishLevel.SelectedIndexChanged += (sender, args) => UpdateSummary("Everyday English", cboEnglishLevel);
            cboMathLevel.SelectedIndexChanged += (sender, args) => UpdateSummary("Integrated Mathematics", cboMathLevel);
            cboScienceLevel.SelectedIndexChanged += (sender, args) => UpdateSummary("Wonders of Science", cboScienceLevel);

            // Button clicks para compute, clear, at close.
            btnCompute.Click += btnCompute_Click;
            btnClear.Click += btnClear_Click;
            btnClose.Click += btnClose_Click;
        }

        private void ToggleRow(CheckBox checkBox, ComboBox comboBox, TextBox qtyBox, TextBox subTotalBox, string title)
        {
            // Pag checked, enable natin ang level at quantity.
            if (checkBox.Checked)
            {
                comboBox.Enabled = true;
                qtyBox.Enabled = true;
                comboBox.SelectedIndex = 0;
                qtyBox.Clear();
                subTotalBox.Clear();
                return;
            }

            // Pag unchecked, balik sa blank at disable.
            comboBox.Enabled = false;
            qtyBox.Enabled = false;
            comboBox.SelectedIndex = 0;
            qtyBox.Clear();
            subTotalBox.Clear();
            RemoveSummaryItem(title);
        }

        private void UpdateSummary(string title, ComboBox comboBox)
        {
            // Kunin natin yung selected level.
            string level = comboBox.SelectedItem?.ToString() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(level))
            {
                // Kapag blank, tanggalin natin sa list.
                RemoveSummaryItem(title);
                return;
            }

            // Kuha ng price base sa level.
            decimal price = GetUnitPrice(level);
            ListViewItem item = FindSummaryItem(title);
            if (item == null)
            {
                // Kapag wala pa sa list, add new row.
                item = new ListViewItem(title);
                item.SubItems.Add(level);
                item.SubItems.Add(price.ToString("0.00"));
                lvSummary.Items.Add(item);
                lvSummary.Enabled = true;
            }
            else
            {
                // Kapag meron na, update lang.
                item.SubItems[1].Text = level;
                item.SubItems[2].Text = price.ToString("0.00");
            }
        }

        private void btnCompute_Click(object? sender, EventArgs e)
        {
            // Validate first so totals are only computed with correct input.
            if (!ValidateRow(chkEnglish, cboEnglishLevel, txtEnglishQty, "Everyday English"))
            {
                return;
            }

            if (!ValidateRow(chkMath, cboMathLevel, txtMathQty, "Integrated Mathematics"))
            {
                return;
            }

            if (!ValidateRow(chkScience, cboScienceLevel, txtScienceQty, "Wonders of Science"))
            {
                return;
            }

            // Compute natin yung total amount.
            decimal totalAmount = 0m;
            totalAmount += ComputeRow(chkEnglish, cboEnglishLevel, txtEnglishQty, txtEnglishSubTotal);
            totalAmount += ComputeRow(chkMath, cboMathLevel, txtMathQty, txtMathSubTotal);
            totalAmount += ComputeRow(chkScience, cboScienceLevel, txtScienceQty, txtScienceSubTotal);
            txtTotalAmount.Text = totalAmount.ToString("0.00");
        }

        private decimal ComputeRow(CheckBox checkBox, ComboBox comboBox, TextBox qtyBox, TextBox subTotalBox)
        {
            // Pag hindi checked, zero lang ang subtotal.
            if (!checkBox.Checked)
            {
                subTotalBox.Clear();
                return 0m;
            }

            // Pag walang level, huwag muna mag compute.
            string level = comboBox.SelectedItem?.ToString() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(level))
            {
                subTotalBox.Clear();
                return 0m;
            }

            // Quantity * presyo ang subtotal.
            int quantity = int.Parse(qtyBox.Text.Trim());
            decimal price = GetUnitPrice(level);
            decimal subTotal = price * quantity;
            subTotalBox.Text = subTotal.ToString("0.00");
            return subTotal;
        }

        private bool ValidateRow(CheckBox checkBox, ComboBox comboBox, TextBox qtyBox, string title)
        {
            // Kapag hindi naka-check, skip validation.
            if (!checkBox.Checked)
            {
                return true;
            }

            // Check muna kung may level.
            string level = comboBox.SelectedItem?.ToString() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(level))
            {
                MessageBox.Show($"Please select a level for {title}.", "Missing Level", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox.Focus();
                return false;
            }

            // Check kung valid number ang quantity.
            if (string.IsNullOrWhiteSpace(qtyBox.Text) || !int.TryParse(qtyBox.Text.Trim(), out int quantity) || quantity <= 0)
            {
                MessageBox.Show($"Please input a correct quantity for {title}.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                qtyBox.Focus();
                return false;
            }

            return true;
        }

        private decimal GetUnitPrice(string level)
        {
            // Simple switch para sa presyo per level.
            return level switch
            {
                "NURSERY" => 150m,
                "KINDER" => 200m,
                "PREP" => 250m,
                _ => 0m
            };
        }

        private void RemoveSummaryItem(string title)
        {
            // Hanapin yung row sa list at tanggalin.
            ListViewItem item = FindSummaryItem(title);
            if (item != null)
            {
                lvSummary.Items.Remove(item);
                if (lvSummary.Items.Count == 0)
                {
                    lvSummary.Enabled = false;
                }
            }
        }

        private ListViewItem? FindSummaryItem(string title)
        {
            // Simple loop para hanapin yung item by title.
            foreach (ListViewItem item in lvSummary.Items)
            {
                if (string.Equals(item.Text, title, StringComparison.OrdinalIgnoreCase))
                {
                    return item;
                }
            }

            return null;
        }

        private void btnClear_Click(object? sender, EventArgs e)
        {
            // Clear button balik sa default.
            ResetForm();
        }

        private void btnClose_Click(object? sender, EventArgs e)
        {
            // Ask muna bago isara.
            DialogResult result = MessageBox.Show("Are you sure?", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void ResetForm()
        {
            // Default state: only checkboxes and buttons are enabled.
            chkEnglish.Checked = false;
            chkMath.Checked = false;
            chkScience.Checked = false;

            cboEnglishLevel.Enabled = false;
            cboMathLevel.Enabled = false;
            cboScienceLevel.Enabled = false;

            txtEnglishQty.Enabled = false;
            txtMathQty.Enabled = false;
            txtScienceQty.Enabled = false;

            txtEnglishSubTotal.Enabled = false;
            txtMathSubTotal.Enabled = false;
            txtScienceSubTotal.Enabled = false;
            txtTotalAmount.Enabled = false;

            // Reset to blank selection.
            cboEnglishLevel.SelectedIndex = 0;
            cboMathLevel.SelectedIndex = 0;
            cboScienceLevel.SelectedIndex = 0;

            // Clear lahat ng input at output.
            txtEnglishQty.Clear();
            txtMathQty.Clear();
            txtScienceQty.Clear();
            txtEnglishSubTotal.Clear();
            txtMathSubTotal.Clear();
            txtScienceSubTotal.Clear();
            txtTotalAmount.Clear();

            // Clear summary list.
            lvSummary.Items.Clear();
            lvSummary.Enabled = false;
        }
    }
}
