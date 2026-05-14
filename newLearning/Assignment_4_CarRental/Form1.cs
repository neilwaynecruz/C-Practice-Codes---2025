using System.IO;

namespace Assignment_4_CarRental
{
    public partial class Form1 : Form
    {
        // Per-day driver rates used in total bill computation.
        private const decimal DriverRateMangPinong = 500m;
        private const decimal DriverRateKuyaBoy = 750m;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Populate combo box options for vehicle type, destination, and driver.
            comboCarType.Items.AddRange(new object[] { "Car", "Van" });
            comboDestination.Items.AddRange(new object[] { "Baguio", "Bicol", "Ilocos" });
            comboDriver.Items.AddRange(new object[] { "Mang Pinong", "Kuya Boy" });

            // Reset all form fields to their default empty state.
            textCustomerName.Clear();
            comboCarType.SelectedIndex = -1;
            comboDestination.SelectedIndex = -1;
            comboDriver.SelectedIndex = -1;
            dateFrom.Value = DateTime.Today;
            dateTo.Value = DateTime.Today;
            pictureVehicle.Image = null;
            pictureVehicle.ImageLocation = null;
        }

        private void comboCarType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Refresh the vehicle preview image when the user picks a different car type.
            UpdateVehicleImage();
        }

        private void buttonReserve_Click(object sender, EventArgs e)
        {
            // Validate that a customer name has been entered.
            if (string.IsNullOrWhiteSpace(textCustomerName.Text))
            {
                MessageBox.Show("Please enter the customer name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textCustomerName.Focus();
                return;
            }

            // Ensure that car type, destination, and driver are all selected.
            if (comboCarType.SelectedIndex < 0 || comboDestination.SelectedIndex < 0 || comboDriver.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose a car type, destination, and driver.", "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Retrieve the selected travel dates to calculate total rental days.
            DateTime fromDate = dateFrom.Value.Date;
            DateTime toDate = dateTo.Value.Date;

            if (toDate < fromDate)
            {
                MessageBox.Show("The 'To' date must be on or after the 'From' date.", "Invalid Travel Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Compute total rental days, get the applicable vehicle and driver rates.
            int totalDays = (toDate - fromDate).Days + 1;
            decimal vehicleRate = GetVehicleRate(comboCarType.Text, comboDestination.Text);
            decimal driverRate = GetDriverRate(comboDriver.Text);
            decimal totalBill = (vehicleRate + driverRate) * totalDays;

            // Show the computed total bill before asking for confirmation.
            MessageBox.Show($"Total Bill: {totalBill:C0}\nDays: {totalDays}", "Total Bill", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Ask the user to confirm the reservation. Yes proceeds, No exits the application.
            DialogResult confirm = MessageBox.Show("Confirm reservation?", "Confirm Reservation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                MessageBox.Show("Enjoy your Vacation!", "Reservation Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Close();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            // Ask for confirmation before closing the form.
            DialogResult result = MessageBox.Show("Are you sure?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private decimal GetVehicleRate(string carType, string destination)
        {
            // Car rates vary by destination.
            if (carType == "Car")
            {
                return destination switch
                {
                    "Baguio" => 3000m,
                    "Bicol" => 3500m,
                    "Ilocos" => 4000m,
                    _ => 0m
                };
            }

            // Van rates vary by destination.
            return destination switch
            {
                "Baguio" => 5000m,
                "Bicol" => 5500m,
                "Ilocos" => 6000m,
                _ => 0m
            };
        }

        private decimal GetDriverRate(string driverName)
        {
            // Return the per-day rate for the selected driver.
            return driverName == "Kuya Boy" ? DriverRateKuyaBoy : DriverRateMangPinong;
        }

        private void UpdateVehicleImage()
        {
            // Select the correct image file based on the chosen car type.
            string fileName = comboCarType.Text == "Van" ? "Van-1.jpg" : "GTR_PICTURE_1.jpg";
            string imagePath = GetVehicleImagePath(fileName);
            if (!File.Exists(imagePath) && fileName != "GTR_PICTURE_1.jpg")
            {
                // Fallback to the car image if the van image is not found.
                imagePath = GetVehicleImagePath("GTR_PICTURE_1.jpg");
            }
            if (File.Exists(imagePath))
            {
                pictureVehicle.ImageLocation = imagePath;
            }
            else
            {
                // No valid image found; clear the picture box.
                pictureVehicle.Image = null;
            }
        }

        private string GetVehicleImagePath(string fileName)
        {
            // Search for the image file in the application's output directory first.
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string outputPath = Path.Combine(basePath, fileName);
            if (File.Exists(outputPath))
            {
                return outputPath;
            }

            // If not found, check a project-named subdirectory under the output folder.
            string outputSubfolderPath = Path.Combine(basePath, "Assignment_4_CarRental", fileName);
            if (File.Exists(outputSubfolderPath))
            {
                return outputSubfolderPath;
            }

            // Fallback: navigate up to the project root directory.
            string projectRootPath = Path.GetFullPath(Path.Combine(basePath, "..", "..", ".."));
            string projectImagePath = Path.Combine(projectRootPath, fileName);
            if (File.Exists(projectImagePath))
            {
                return projectImagePath;
            }

            // Last resort: combine the project root with a project-named subfolder.
            return Path.Combine(projectRootPath, "Assignment_4_CarRental", fileName);
        }

        private void pictureVehicle_Click(object sender, EventArgs e)
        {

        }
    }
}
