namespace ListForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelProducts = new Label();
            listBoxInventory = new ListBox();
            labelDescription = new Label();
            textBoxDescription = new TextBox();
            labelProductsChecked = new Label();
            checkedListBoxProducts = new CheckedListBox();
            labelShoppingCart = new Label();
            listBoxShoppingCart = new ListBox();
            labelFrom = new Label();
            dateTimePicker1 = new DateTimePicker();
            labelTo = new Label();
            dateTimePicker2 = new DateTimePicker();
            button1 = new Button();
            labelDays = new Label();
            textBox1 = new TextBox();
            textBoxDays = new TextBox();
            labelListView = new Label();
            listView1 = new ListView();
            columnHeaderProductName = new ColumnHeader();
            columnHeaderUnitPrice = new ColumnHeader();
            labelProductName = new Label();
            textBox2 = new TextBox();
            labelUnitPrice = new Label();
            textBox3 = new TextBox();
            labelQuantity = new Label();
            buttonAddListView = new Button();
            SuspendLayout();
            // 
            // labelProducts
            // 
            labelProducts.AutoSize = true;
            labelProducts.Location = new Point(24, 24);
            labelProducts.Name = "labelProducts";
            labelProducts.Size = new Size(86, 20);
            labelProducts.TabIndex = 0;
            labelProducts.Text = "Product list:";
            // 
            // listBoxInventory
            // 
            listBoxInventory.FormattingEnabled = true;
            listBoxInventory.Location = new Point(24, 56);
            listBoxInventory.Name = "listBoxInventory";
            listBoxInventory.Size = new Size(260, 304);
            listBoxInventory.TabIndex = 1;
            listBoxInventory.SelectedIndexChanged += listBoxInventory_SelectedIndexChanged;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(320, 24);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(141, 20);
            labelDescription.TabIndex = 2;
            labelDescription.Text = "Product description:";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(320, 56);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.ReadOnly = true;
            textBoxDescription.Size = new Size(320, 304);
            textBoxDescription.TabIndex = 3;
            // 
            // labelProductsChecked
            // 
            labelProductsChecked.AutoSize = true;
            labelProductsChecked.Location = new Point(24, 376);
            labelProductsChecked.Name = "labelProductsChecked";
            labelProductsChecked.Size = new Size(86, 20);
            labelProductsChecked.TabIndex = 4;
            labelProductsChecked.Text = "Product list:";
            // 
            // checkedListBoxProducts
            // 
            checkedListBoxProducts.FormattingEnabled = true;
            checkedListBoxProducts.Items.AddRange(new object[] { "Shampoo", "Soap", "Deodorant", "Toothpaste", "Mouthwash" });
            checkedListBoxProducts.Location = new Point(24, 408);
            checkedListBoxProducts.Name = "checkedListBoxProducts";
            checkedListBoxProducts.Size = new Size(260, 202);
            checkedListBoxProducts.TabIndex = 5;
            checkedListBoxProducts.ItemCheck += checkedListBoxProducts_ItemCheck;
            // 
            // labelShoppingCart
            // 
            labelShoppingCart.AutoSize = true;
            labelShoppingCart.Location = new Point(320, 376);
            labelShoppingCart.Name = "labelShoppingCart";
            labelShoppingCart.Size = new Size(105, 20);
            labelShoppingCart.TabIndex = 6;
            labelShoppingCart.Text = "Shopping cart:";
            // 
            // listBoxShoppingCart
            // 
            listBoxShoppingCart.FormattingEnabled = true;
            listBoxShoppingCart.Location = new Point(320, 408);
            listBoxShoppingCart.Name = "listBoxShoppingCart";
            listBoxShoppingCart.Size = new Size(320, 204);
            listBoxShoppingCart.TabIndex = 7;
            // 
            // labelFrom
            // 
            labelFrom.AutoSize = true;
            labelFrom.Location = new Point(24, 632);
            labelFrom.Name = "labelFrom";
            labelFrom.Size = new Size(46, 20);
            labelFrom.TabIndex = 8;
            labelFrom.Text = "From:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.Blue;
            dateTimePicker1.CalendarMonthBackground = Color.SkyBlue;
            dateTimePicker1.CalendarTitleBackColor = Color.Navy;
            dateTimePicker1.CalendarTitleForeColor = Color.Gold;
            dateTimePicker1.CalendarTrailingForeColor = Color.DodgerBlue;
            dateTimePicker1.Location = new Point(80, 628);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(260, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // labelTo
            // 
            labelTo.AutoSize = true;
            labelTo.Location = new Point(360, 632);
            labelTo.Name = "labelTo";
            labelTo.Size = new Size(28, 20);
            labelTo.TabIndex = 10;
            labelTo.Text = "To:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(400, 628);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(240, 27);
            dateTimePicker2.TabIndex = 11;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(24, 672);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "Display";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelDays
            // 
            labelDays.AutoSize = true;
            labelDays.Location = new Point(136, 676);
            labelDays.Name = "labelDays";
            labelDays.Size = new Size(87, 20);
            labelDays.TabIndex = 13;
            labelDays.Text = "No. of days:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 744);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 27);
            textBox1.TabIndex = 14;
            // 
            // textBoxDays
            // 
            textBoxDays.Location = new Point(224, 672);
            textBoxDays.Name = "textBoxDays";
            textBoxDays.ReadOnly = true;
            textBoxDays.Size = new Size(116, 27);
            textBoxDays.TabIndex = 15;
            // 
            // labelListView
            // 
            labelListView.AutoSize = true;
            labelListView.Location = new Point(20, 720);
            labelListView.Name = "labelListView";
            labelListView.Size = new Size(109, 20);
            labelListView.TabIndex = 16;
            labelListView.Text = "ListView demo:";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeaderProductName, columnHeaderUnitPrice });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(20, 853);
            listView1.Name = "listView1";
            listView1.Size = new Size(616, 120);
            listView1.TabIndex = 17;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.ItemActivate += listView1_ItemActivate;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeaderProductName
            // 
            columnHeaderProductName.Text = "Product Name";
            columnHeaderProductName.TextAlign = HorizontalAlignment.Center;
            columnHeaderProductName.Width = 240;
            // 
            // columnHeaderUnitPrice
            // 
            columnHeaderUnitPrice.Text = "Unit Price";
            columnHeaderUnitPrice.TextAlign = HorizontalAlignment.Center;
            columnHeaderUnitPrice.Width = 160;
            // 
            // labelProductName
            // 
            labelProductName.AutoSize = true;
            labelProductName.Location = new Point(20, 748);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(104, 20);
            labelProductName.TabIndex = 18;
            labelProductName.Text = "Product name:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(136, 776);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(120, 27);
            textBox2.TabIndex = 19;
            // 
            // labelUnitPrice
            // 
            labelUnitPrice.AutoSize = true;
            labelUnitPrice.Location = new Point(20, 780);
            labelUnitPrice.Name = "labelUnitPrice";
            labelUnitPrice.Size = new Size(76, 20);
            labelUnitPrice.TabIndex = 20;
            labelUnitPrice.Text = "Unit price:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(136, 808);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(120, 27);
            textBox3.TabIndex = 21;
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Location = new Point(20, 812);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(68, 20);
            labelQuantity.TabIndex = 22;
            labelQuantity.Text = "Quantity:";
            // 
            // buttonAddListView
            // 
            buttonAddListView.Location = new Point(286, 986);
            buttonAddListView.Name = "buttonAddListView";
            buttonAddListView.Size = new Size(120, 29);
            buttonAddListView.TabIndex = 23;
            buttonAddListView.Text = "Add";
            buttonAddListView.UseVisualStyleBackColor = true;
            buttonAddListView.Click += buttonAddListView_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 1055);
            Controls.Add(buttonAddListView);
            Controls.Add(labelQuantity);
            Controls.Add(textBox3);
            Controls.Add(labelUnitPrice);
            Controls.Add(textBox2);
            Controls.Add(labelProductName);
            Controls.Add(listView1);
            Controls.Add(labelListView);
            Controls.Add(textBoxDays);
            Controls.Add(textBox1);
            Controls.Add(labelDays);
            Controls.Add(button1);
            Controls.Add(dateTimePicker2);
            Controls.Add(labelTo);
            Controls.Add(dateTimePicker1);
            Controls.Add(labelFrom);
            Controls.Add(listBoxShoppingCart);
            Controls.Add(labelShoppingCart);
            Controls.Add(checkedListBoxProducts);
            Controls.Add(labelProductsChecked);
            Controls.Add(textBoxDescription);
            Controls.Add(labelDescription);
            Controls.Add(listBoxInventory);
            Controls.Add(labelProducts);
            Name = "Form1";
            Text = "ListBox Demo";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label labelProducts;
        private ListBox listBoxInventory;
        private Label labelDescription;
        private TextBox textBoxDescription;
        private Label labelProductsChecked;
        private CheckedListBox checkedListBoxProducts;
        private Label labelShoppingCart;
        private ListBox listBoxShoppingCart;
        private Label labelFrom;
        private DateTimePicker dateTimePicker1;
        private Label labelTo;
        private DateTimePicker dateTimePicker2;
        private Button button1;
        private Label labelDays;
        private TextBox textBox1;
        private TextBox textBoxDays;
        private Label labelListView;
        private ListView listView1;
        private ColumnHeader columnHeaderProductName;
        private ColumnHeader columnHeaderUnitPrice;
        private Label labelProductName;
        private TextBox textBox2;
        private Label labelUnitPrice;
        private TextBox textBox3;
        private Label labelQuantity;
        private Button buttonAddListView;

        #endregion
    }
}
