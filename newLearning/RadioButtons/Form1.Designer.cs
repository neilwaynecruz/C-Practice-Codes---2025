namespace RadioButtons
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
            lblChooseGender = new Label();
            panel1 = new Panel();
            radioButtonFemale = new RadioButton();
            radioButtonMale = new RadioButton();
            pictureBox1 = new PictureBox();
            buttonDisplay = new Button();
            buttonClear = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblChooseGender
            // 
            lblChooseGender.AutoSize = true;
            lblChooseGender.Location = new Point(32, 30);
            lblChooseGender.Name = "lblChooseGender";
            lblChooseGender.Size = new Size(113, 20);
            lblChooseGender.TabIndex = 0;
            lblChooseGender.Text = "Choose Gender:";
            lblChooseGender.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(radioButtonFemale);
            panel1.Controls.Add(radioButtonMale);
            panel1.Location = new Point(58, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(188, 109);
            panel1.TabIndex = 1;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Location = new Point(33, 62);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(78, 24);
            radioButtonFemale.TabIndex = 1;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            radioButtonFemale.CheckedChanged += radioButtonFemale_CheckedChanged;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Location = new Point(33, 32);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(63, 24);
            radioButtonMale.TabIndex = 0;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            radioButtonMale.CheckedChanged += radioButtonMale_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(292, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 165);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // buttonDisplay
            // 
            buttonDisplay.Location = new Point(51, 220);
            buttonDisplay.Name = "buttonDisplay";
            buttonDisplay.Size = new Size(94, 29);
            buttonDisplay.TabIndex = 3;
            buttonDisplay.Text = "Display";
            buttonDisplay.UseVisualStyleBackColor = true;
            buttonDisplay.Click += buttonDisplay_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(152, 220);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(94, 29);
            buttonClear.TabIndex = 4;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 348);
            Controls.Add(buttonClear);
            Controls.Add(buttonDisplay);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(lblChooseGender);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblChooseGender;
        private Panel panel1;
        private RadioButton radioButtonFemale;
        private RadioButton radioButtonMale;
        private PictureBox pictureBox1;
        private Button buttonDisplay;
        private Button buttonClear;
    }
}
