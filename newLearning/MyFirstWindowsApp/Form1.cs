using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyFirstWindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Make sure controls start enabled
            SetControlsEnabled(false);
        }

        // Click Add: read numbers, add them, show result
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Try to parse first number
            double firstNumber;
            string a = textBoxA.Text;
            string b = textBoxB.Text;

            bool firstOk = double.TryParse(textBoxA.Text, out firstNumber);
            if (!firstOk)
            {
                
                ShowInputError("First Number");
                textBoxA.Focus();
                return;
            }

            // Try to parse second number
            double secondNumber;
            bool secondOk = double.TryParse(textBoxB.Text, out secondNumber);
            if (!secondOk)
            {
                ShowInputError("Second Number");
                textBoxB.Focus();
                return;
            }

            // Simple calculation
            double sum = firstNumber + secondNumber;
            labelResult.Text = "Result: " + sum.ToString();
        }

        // Click Clear: empty the inputs and result
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxA.Text = "";
            textBoxB.Text = "";
            labelResult.Text = "Result:";
            textBoxA.Focus();
        }

        // Click Close: ask user for confirmation then close
        private void buttonClose_Click(object sender, EventArgs e)
        {
            // Ask a simple Yes/ No question.If the user clicks Yes, close the form.
            var answer = MessageBox.Show(
                "Are you sure you want to close it?", // message
                "Confirm close",                       // title
                MessageBoxButtons.YesNoCancel,               // buttons
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button3);              // icon

            if (answer == DialogResult.Yes)
            {
                this.Close();
            }
            // If the user clicks No, do nothing and return to the form.
        }

        // Turn calculator on
        private void buttonOn_Click(object sender, EventArgs e)
        {
            SetControlsEnabled(true);
        }

        // Turn calculator off
        private void buttonOff_Click(object sender, EventArgs e)
        {
            SetControlsEnabled(false);
        }

        // Helper: show a friendly input error message
        private void ShowInputError(string fieldName)
        {
            MessageBox.Show("Please enter a valid number for " + fieldName + ".", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Enable or disable the input controls and buttons
        private void SetControlsEnabled(bool enabled)
        {
            textBoxA.Enabled = enabled;
            textBoxB.Enabled = enabled;
            buttonAdd.Enabled = enabled;
            buttonClear.Enabled = enabled;

            // Show a clear message when turned off so a beginner understands
            if (enabled)
            {
                labelResult.Text = "Result:";
            }
            else
            {
                labelResult.Text = "Calculator is off";
            }
        }

        //private void SetControlsDisabled(bool disabled) 
        //    {   textBoxA.Enabled = !disabled;
        //        textBoxB.Enabled = !disabled;
        //        buttonAdd.Enabled = !disabled;
        //        buttonClear.Enabled = !disabled;

        //        if (disabled)
        //        {
        //            labelResult.Text = "Calculator is off";
        //        }
        //        else
        //        {
        //            labelResult.Text = "Result:";
        //    }
        //}
    }
}
