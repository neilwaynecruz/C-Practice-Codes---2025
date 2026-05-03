namespace ListForm
{
    public partial class Form1 : Form
    {
        private DateTime DateFrom;
        private DateTime DateTo;
        private Dictionary<string, string> products;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            products = new Dictionary<string, string>();
            products.Add("Shampoo", "Makes your hair beautiful and shiny.");
            products.Add("Soap", "Removes the dirt and germs on your body.");
            products.Add("Deodorant", "Prevents body odor.");
            products.Add("Toothpaste", "Used to clean your teeth.");
            products.Add("Mouthwash", "Fights bad breath.");

            listBoxInventory.Items.Clear();

            foreach (KeyValuePair<string, string> product in products)
            {
                listBoxInventory.Items.Add(product.Key);
            }

            if (listBoxInventory.Items.Count > 0)
            {
                listBoxInventory.SelectedIndex = 0;
            }

            listView1.Columns.Add("Quantity", 70);

            string[] arr = new string[4];

            arr[0] = "product_1";
            arr[1] = "100";
            arr[2] = "10";
            ListViewItem itm1 = new ListViewItem(arr);
            listView1.Items.Add(itm1);

            arr[0] = "product_2";
            arr[1] = "200";
            arr[2] = "20";
            ListViewItem itm2 = new ListViewItem(arr);
            listView1.Items.Add(itm2);
        }

        private void listBoxInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProduct = listBoxInventory.Text;

            if (!string.IsNullOrWhiteSpace(selectedProduct) && products.ContainsKey(selectedProduct))
            {
                textBoxDescription.Text = products[selectedProduct];
            }
            else
            {
                textBoxDescription.Clear();
            }
        }

        private void checkedListBoxProducts_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                listBoxShoppingCart.Items.Add(checkedListBoxProducts.Items[e.Index]);
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                listBoxShoppingCart.Items.Remove(checkedListBoxProducts.Items[e.Index]);
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateFrom = dateTimePicker1.Value;
            DateTo = dateTimePicker2.Value;

            if (DateTo < DateFrom)
            {
                MessageBox.Show("Date To must not be later than Date From!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateFrom = dateTimePicker1.Value;
            DateTo = dateTimePicker2.Value;

            if (DateTo <= DateFrom)
            {
                MessageBox.Show("Date To must be greater than Date From!", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear();
                return;
            }

            TimeSpan span = DateTo.Subtract(DateFrom);
            int days = Convert.ToInt32(span.TotalDays);
            textBoxDays.Text = days.ToString();
        }

        private void buttonAddListView_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please enter Product Name, Unit Price, and Quantity.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] arr = new string[3];

            arr[0] = textBox1.Text;
            arr[1] = textBox2.Text;
            arr[2] = textBox3.Text;
            ListViewItem itm = new ListViewItem(arr);
            listView1.Items.Add(itm);
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
                textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
                textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
