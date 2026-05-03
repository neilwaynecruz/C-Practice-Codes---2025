using System.IO;

namespace Assignment_4_CarRental
{
    public partial class Form1 : Form
    {
        // Driver rates per day para madaling i-compute later.
        private const decimal DriverRateMangPinong = 500m;
        private const decimal DriverRateKuyaBoy = 750m;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Setup ng choices para ready na agad ang dropdowns.
            comboCarType.Items.AddRange(new object[] { "Car", "Van" });
            comboDestination.Items.AddRange(new object[] { "Baguio", "Bicol", "Ilocos" });
            comboDriver.Items.AddRange(new object[] { "Mang Pinong", "Kuya Boy" });

            // Start fresh: clear lahat ng fields at walang selected car.
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
            // Palit image depende sa napiling car type.
            UpdateVehicleImage();
        }

        private void buttonReserve_Click(object sender, EventArgs e)
        {
            // Basic check para sure na may customer name.
            if (string.IsNullOrWhiteSpace(textCustomerName.Text))
            {
                MessageBox.Show("Please enter the customer name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textCustomerName.Focus();
                return;
            }

            // Check kung may napili na car, destination, at driver.
            if (comboCarType.SelectedIndex < 0 || comboDestination.SelectedIndex < 0 || comboDriver.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose a car type, destination, and driver.", "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kuha natin yung dates para ma-compute ang days.
            DateTime fromDate = dateFrom.Value.Date;
            DateTime toDate = dateTo.Value.Date;

            if (toDate < fromDate)
            {
                MessageBox.Show("The 'To' date must be on or after the 'From' date.", "Invalid Travel Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Compute ng total days, rate ng car/van, at driver.
            int totalDays = (toDate - fromDate).Days + 1;
            decimal vehicleRate = GetVehicleRate(comboCarType.Text, comboDestination.Text);
            decimal driverRate = GetDriverRate(comboDriver.Text);
            decimal totalBill = (vehicleRate + driverRate) * totalDays;

            // Ipakita muna ang total bill.
            MessageBox.Show($"Total Bill: {totalBill:C0}\nDays: {totalDays}", "Total Bill", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Confirm reservation. Yes = enjoy, No = close.
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
            // Simple confirmation bago isara ang form.
            DialogResult result = MessageBox.Show("Are you sure?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private decimal GetVehicleRate(string carType, string destination)
        {
            // Rate ng Car depende sa destination.
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

            // Rate ng Van depende sa destination.
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
            // Simple check kung sino ang driver.
            return driverName == "Kuya Boy" ? DriverRateKuyaBoy : DriverRateMangPinong;
        }

        private void UpdateVehicleImage()
        {
            // Pili ng tamang image file based sa car type.
            string fileName = comboCarType.Text == "Van" ? "Van-1.jpg" : "GTR_PICTURE_1.jpg";
            string imagePath = GetVehicleImagePath(fileName);
            if (!File.Exists(imagePath) && fileName != "GTR_PICTURE_1.jpg")
            {
                // Fallback: gamitin ang car image kung wala yung van image.
                imagePath = GetVehicleImagePath("GTR_PICTURE_1.jpg");
            }
            if (File.Exists(imagePath))
            {
                pictureVehicle.ImageLocation = imagePath;
            }
            else
            {
                // Walang image na nakita.
                pictureVehicle.Image = null;
            }
        }

        private string GetVehicleImagePath(string fileName)
        {
            // Hanapin muna sa output folder.
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string outputPath = Path.Combine(basePath, fileName);
            if (File.Exists(outputPath))
            {
                return outputPath;
            }

            // Check kung may subfolder na same name ng project.
            string outputSubfolderPath = Path.Combine(basePath, "Assignment_4_CarRental", fileName);
            if (File.Exists(outputSubfolderPath))
            {
                return outputSubfolderPath;
            }

            // Check naman sa project root.
            string projectRootPath = Path.GetFullPath(Path.Combine(basePath, "..", "..", ".."));
            string projectImagePath = Path.Combine(projectRootPath, fileName);
            if (File.Exists(projectImagePath))
            {
                return projectImagePath;
            }

            // Last try: project subfolder.
            return Path.Combine(projectRootPath, "Assignment_4_CarRental", fileName);
        }

        private void pictureVehicle_Click(object sender, EventArgs e)
        {

        }
    }
}
