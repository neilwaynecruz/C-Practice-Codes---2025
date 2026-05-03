namespace MenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void window1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            windowSelections();
        }

        public void windowSelections()  // user-defined method
        {
            String windows = String.Empty;

            if (window1ToolStripMenuItem.Checked == true)
                windows += "Window 1" + "\n";

            if (window2ToolStripMenuItem.Checked == true)
                windows += "Window 2" + "\n";

            MessageBox.Show(windows, "Selected Windows");
        }

    
    }
}
