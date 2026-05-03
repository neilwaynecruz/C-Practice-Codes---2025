namespace RadioButtons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            pictureBox1.Image = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            if (radioButtonMale.Checked)
            {
                pictureBox1.Image = RadioButtons.Properties.Resources.male;
            }
            else if (radioButtonFemale.Checked)
            {
                pictureBox1.Image = RadioButtons.Properties.Resources.female;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            pictureBox1.Image = null;
        }

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMale.Checked)
            {
                pictureBox1.Image = RadioButtons.Properties.Resources.male;
            }

        }

        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFemale.Checked)
            {
                pictureBox1.Image = RadioButtons.Properties.Resources.female;
            }
        }
    }
}
