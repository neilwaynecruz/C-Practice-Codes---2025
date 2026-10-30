using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Final_Prac_Exam_Pizza
{
    public partial class Form1 : Form
    {
        // Taglish comments: Para ma-track natin kung ilang beses nag-fail sa pag-login ang cashier.
        private int failedAttempts = 0;

        // Ito naman ang gagamitin natin para i-store ang computed total amount para sa computation ng sukli.
        private double totalAmount = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        // Kapag nag-load ang form natin sa simula ng program.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Pag-load ng options para sa Discount combobox.
            cmbDiscount.Items.Clear();
            cmbDiscount.Items.Add("None");
            cmbDiscount.Items.Add("Senior");
            cmbDiscount.Items.Add("VIPCard");
            cmbDiscount.SelectedIndex = 0; // "None" muna ang default na nakapili.

            // Set natin sa default state ang lahat ng controls.
            ResetToDefaultProperties();
        }

        // Helper function para i-reset ang POS form natin sa orihinal nitong itsura at lagay.
        private void ResetToDefaultProperties()
        {
            // Reset ang variables natin.
            failedAttempts = 0;
            totalAmount = 0.0;

            // Enable muna natin ang Log-in panel at i-clear ang username/password.
            grpLogin.Enabled = true;
            txtUserName.Clear();
            txtPassword.Clear();

            // Disable muna natin ang Order at Bills groupbox.
            grpTakeOrder.Enabled = false;
            grpBillsPayment.Enabled = false;

            // I-clear natin ang mga selection at inputs sa Order panel.
            rdoPepperoni.Checked = false;
            rdoHawaiian.Checked = false;
            rdoHamCheese.Checked = false;
            chkCheese.Checked = false;
            chkMushrooms.Checked = false;
            cmbDiscount.SelectedIndex = 0;
            txtQuantity.Clear();

            // Tanggalin ang image sa PictureBox natin.
            if (picPizzaTopping.Image != null)
            {
                picPizzaTopping.Image.Dispose();
                picPizzaTopping.Image = null;
            }

            // I-clear din natin ang total, bayad, at sukli.
            txtTotalAmount.Clear();
            txtAmountGiven.Clear();
            txtChange.Clear();

            // Disable natin ang Reset button sa simula, dahil nakareset na nga ito.
            btnReset.Enabled = false;

            // Bago ang lahat, kailangang enabled ang Exit button.
            btnExit.Enabled = true;

            // Mas siguradong ma-focus ang User Name gamit ang ActiveControl
            this.ActiveControl = txtUserName;
            txtUserName.Focus();
        }

        // Kapag pinindot ang Log-In button ng cashier.
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Kuhanin natin ang pinasok na username at password (i-trim na rin natin para walang space sa dulo).
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text;

            // Check natin kung tama ang username (mjrc) at password (rcmj).
            if ((username == "mjrc" && password == "rcmj" ) || (username == "neil" && password == "password"))
            {
                MessageBox.Show("Welcome to GreenHutShake Pizza POS system!", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Pag tama ang login:
                // 1. I-enable natin ang Take Order section para makapili ng pizza.
                grpTakeOrder.Enabled = true;

                // 2. I-enable natin ang Reset button kung gusto nating bumalik sa simula mamaya.
                btnReset.Enabled = true;

                // 3. I-disable muna natin ang Log-in inputs para hindi na galawin habang may transaksyon.
                grpLogin.Enabled = false;
            }
            else
            {
                // Dagdagan natin ng isa ang maling log-in attempts.
                failedAttempts++;

                MessageBox.Show("Access Denied", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // I-clear ang textboxes para makapag-type ulit.
                txtUserName.Clear();
                txtPassword.Clear();

                // I-focus ulit ang cursor sa User Name.
                this.ActiveControl = txtUserName;
                txtUserName.Focus();

                // Pag umabot na sa 3 beses na mali ang login, kusa nating isasara ang POS program.
                if (failedAttempts >= 3)
                {
                    MessageBox.Show("Maximum login attempts reached. The application will now close.", "System Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
            }
        }

        // Helper para sa matatag na pagpapalit ng image ng toppings sa PictureBox natin.
        private void LoadToppingImage(string baseNameWithoutExtension)
        {
            try
            {
                // Gagawa tayo ng listahan ng mga posibleng file names (may underscore, may space, .png, .PNG, atbp.)
                string[] possibleFiles = {
                    baseNameWithoutExtension + ".png",
                    baseNameWithoutExtension + ".PNG",
                    baseNameWithoutExtension.Replace("_", " ") + ".png",
                    baseNameWithoutExtension.Replace("_", " ") + ".PNG",
                    baseNameWithoutExtension.Replace(" ", "_") + ".png",
                    baseNameWithoutExtension.Replace(" ", "_") + ".PNG"
                };

                string? foundFilePath = null;
                foreach (string fileName in possibleFiles)
                {
                    string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
                    if (File.Exists(fullPath))
                    {
                        foundFilePath = fullPath;
                        break;
                    }
                }

                if (foundFilePath != null)
                {
                    // Kung may picture, i-dispose muna natin ang dati para iwas memory leak.
                    if (picPizzaTopping.Image != null)
                    {
                        picPizzaTopping.Image.Dispose();
                    }
                    picPizzaTopping.Image = Image.FromFile(foundFilePath);
                }
                else
                {
                    // Kung walang file sa disk, i-clear na lang ang PictureBox kaysa mag-crash.
                    if (picPizzaTopping.Image != null)
                    {
                        picPizzaTopping.Image.Dispose();
                        picPizzaTopping.Image = null;
                    }
                }
            }
            catch (Exception ex)
            {
                // Pag may iba pang error sa pag-load ng file, i-catch natin ito.
                Console.WriteLine("Error loading image: " + ex.Message);
            }
        }

        // Event handler kapag pinili ang Pepperoni.
        private void rdoPepperoni_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPepperoni.Checked)
            {
                LoadToppingImage("Pepperoni");
            }
        }

        // Event handler kapag pinili ang Hawaiian.
        private void rdoHawaiian_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHawaiian.Checked)
            {
                LoadToppingImage("Hawaiian");
            }
        }

        // Event handler kapag pinili ang Ham and Cheese.
        private void rdoHamCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHamCheese.Checked)
            {
                LoadToppingImage("Ham_Cheese");
            }
        }

        // Kapag clinick ang Ok button ng cashier para icomput ang order.
        private void btnOk_Click(object sender, EventArgs e)
        {
            // Una, siguraduhin natin na may napiling topping ang cashier.
            double toppingPrice = 0.0;
            if (rdoPepperoni.Checked) toppingPrice = 200.0;
            else if (rdoHawaiian.Checked) toppingPrice = 150.0;
            else if (rdoHamCheese.Checked) toppingPrice = 100.0;
            else
            {
                MessageBox.Show("Please select a Pizza Topping first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Pangalawa, siguraduhin natin na tama ang quantity na nilagay (dapat valid integer at higit sa zero).
            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid number of orders (must be greater than 0).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return;
            }

            // Pangatlo, i-add natin ang presyo ng add-ons kung naka-check sila.
            double addOnsPrice = 0.0;
            if (chkCheese.Checked) addOnsPrice += 50.0;
            if (chkMushrooms.Checked) addOnsPrice += 75.0;

            // Kunin ang base cost kada pizza at i-multiply sa quantity ng order.
            double subtotal = (toppingPrice + addOnsPrice) * quantity;

            // Alamin natin kung may piniling discount sa combobox.
            double discountRate = 0.0;
            string selectedDiscount = cmbDiscount.SelectedItem?.ToString() ?? "None";

            if (selectedDiscount == "Senior")
            {
                discountRate = 0.20; // 20% discount
            }
            else if (selectedDiscount == "VIPCard")
            {
                discountRate = 0.12; // 12% discount
            }

            // I-compute ang huling halaga pagkatapos ibawas ang discount.
            totalAmount = subtotal * (1.0 - discountRate);

            // Ipakita natin ang kinalabasan sa Total Amount textbox.
            txtTotalAmount.Text = totalAmount.ToString("N2");

            // I-enable natin ang Bills Payment section para makapagbayad na ang customer.
            grpBillsPayment.Enabled = true;
            
            // I-focus ang cursor sa Amount Given para mabilis mag-type ng bayad ang cashier.
            txtAmountGiven.Focus();
        }

        // Kapag pinindot ang Cancel button sa Take Order.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // I-clear lang natin ang lahat ng selections sa Take Order panel pero stay logged in pa rin ang cashier.
            ClearTakeOrderSelections();
        }

        // Helper para sa pag-clear ng mga selections sa order section nang hindi nilolog-out ang cashier.
        private void ClearTakeOrderSelections()
        {
            rdoPepperoni.Checked = false;
            rdoHawaiian.Checked = false;
            rdoHamCheese.Checked = false;
            chkCheese.Checked = false;
            chkMushrooms.Checked = false;
            cmbDiscount.SelectedIndex = 0;
            txtQuantity.Clear();

            if (picPizzaTopping.Image != null)
            {
                picPizzaTopping.Image.Dispose();
                picPizzaTopping.Image = null;
            }

            // Kapag kinansela ang order, kailangang i-clear din at i-disable ang Bills Payment section.
            txtTotalAmount.Clear();
            txtAmountGiven.Clear();
            txtChange.Clear();
            grpBillsPayment.Enabled = false;
            totalAmount = 0.0;
        }

        // Kapag pinindot ang Compute button para sa sukli.
        private void btnCompute_Click(object sender, EventArgs e)
        {
            // Siguraduhin muna natin na may tamang amount given na nilagay.
            if (!double.TryParse(txtAmountGiven.Text, out double amountGiven) || amountGiven < 0)
            {
                MessageBox.Show("Please enter a valid amount given.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmountGiven.Clear();
                txtAmountGiven.Focus();
                return;
            }

            // Suriin natin kung sapat ang ibinayad ng customer kumpara sa kabuuang halaga ng pizza.
            if (amountGiven < totalAmount)
            {
                MessageBox.Show("Amount given is insufficient. Please enter an amount equal to or greater than the Total Amount.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmountGiven.Clear();
                txtAmountGiven.Focus();
            }
            else
            {
                // Pag sapat ang bayad, i-compute natin ang sukli.
                double change = amountGiven - totalAmount;
                txtChange.Text = change.ToString("N2");

                // Magpakita ng success message sa cashier at sa customer.
                MessageBox.Show($"Transaction Successful!\n\nTotal: Php {totalAmount:N2}\nAmount Paid: Php {amountGiven:N2}\nChange: Php {change:N2}", "Order Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Pagkatapos ng matagumpay na transaksyon, kusa nating i-reset ang checkout fields para sa susunod na customer (Automatic checkout reset).
                ClearTakeOrderSelections();
            }
        }

        // Helper para sa orihinal na form load reset (ginagamit din sa reset button).
        private void ResetFormToDefaults()
        {
            ResetToDefaultProperties();
        }

        // Kapag pinindot ang Reset button para ibalik sa panimulang properties ang buong app.
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetFormToDefaults();
        }

        // Kapag pinindot ang Exit button para isara ang POS application.
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Magpakita ng confirmation prompt kung talagang gustong umalis ng cashier.
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
