namespace TabControl
{
    public partial class Form1 : Form
    {
        Boolean visible1 = true; 
        Boolean visible2 = true;
        public Form1()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(tabPage2); // Remove tabPage2 from the tabControl1 when the form loads
            tabControl1.TabPages.Remove(tabPage3); // Remove tabPage3 from the tabControl1 when the form loads
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(visible2 == true)
            {
                tabControl1.TabPages.Add(tabPage3);
                visible2 = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The selected tab is " + tabControl1.SelectedTab.Text);

            if (visible1 == true) { 
                
                tabControl1.TabPages.Add(tabPage2);
                visible1 = false;
            }
        }
    }
}
