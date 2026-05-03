using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MyFirstWindowsApp
{
    partial class Form1
    {
        private IContainer components = null;
        private Panel headerPanel;
        private Label titleLabel;
        private Label labelA;
        private Label labelB;
        private TextBox textBoxA;
        private TextBox textBoxB;
        private Button buttonAdd;
        private Button buttonClear;
        private Button buttonClose;
        private Button buttonOn;
        private Button buttonOff;
        private Label labelResult;

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headerPanel = new Panel();
            titleLabel = new Label();
            labelA = new Label();
            labelB = new Label();
            textBoxA = new TextBox();
            textBoxB = new TextBox();
            buttonAdd = new Button();
            buttonClear = new Button();
            buttonClose = new Button();
            buttonOn = new Button();
            buttonOff = new Button();
            labelResult = new Label();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.RoyalBlue;
            headerPanel.Controls.Add(titleLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Padding = new Padding(8);
            headerPanel.Size = new Size(410, 48);
            headerPanel.TabIndex = 9;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(12, 10);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(204, 32);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Simple Calculator";
            // 
            // labelA
            // 
            labelA.AutoSize = true;
            labelA.Font = new Font("Segoe UI", 10F);
            labelA.Location = new Point(24, 72);
            labelA.Name = "labelA";
            labelA.Size = new Size(109, 23);
            labelA.TabIndex = 8;
            labelA.Text = "First Number";
            // 
            // labelB
            // 
            labelB.AutoSize = true;
            labelB.Font = new Font("Segoe UI", 10F);
            labelB.Location = new Point(24, 110);
            labelB.Name = "labelB";
            labelB.Size = new Size(134, 23);
            labelB.TabIndex = 6;
            labelB.Text = "Second Number";
            // 
            // textBoxA
            // 
            textBoxA.Font = new Font("Segoe UI", 10F);
            textBoxA.Location = new Point(160, 70);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(200, 30);
            textBoxA.TabIndex = 7;
            // 
            // textBoxB
            // 
            textBoxB.Font = new Font("Segoe UI", 10F);
            textBoxB.Location = new Point(160, 108);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(200, 30);
            textBoxB.TabIndex = 5;
            // 
            // buttonAdd
            // 
            buttonAdd.FlatStyle = FlatStyle.System;
            buttonAdd.Font = new Font("Segoe UI", 10F);
            buttonAdd.Location = new Point(28, 160);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(110, 40);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "&Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonClear
            // 
            buttonClear.FlatStyle = FlatStyle.System;
            buttonClear.Font = new Font("Segoe UI", 10F);
            buttonClear.Location = new Point(150, 160);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(110, 40);
            buttonClear.TabIndex = 4;
            buttonClear.Text = "&Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonClose
            // 
            buttonClose.FlatStyle = FlatStyle.System;
            buttonClose.Font = new Font("Segoe UI", 10F);
            buttonClose.Location = new Point(272, 160);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(110, 40);
            buttonClose.TabIndex = 3;
            buttonClose.Text = "C&lose";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonOn
            // 
            buttonOn.Font = new Font("Segoe UI", 10F);
            buttonOn.Location = new Point(80, 220);
            buttonOn.Name = "buttonOn";
            buttonOn.Size = new Size(110, 40);
            buttonOn.TabIndex = 2;
            buttonOn.Text = "&ON";
            buttonOn.UseVisualStyleBackColor = true;
            buttonOn.Click += buttonOn_Click;
            // 
            // buttonOff
            // 
            buttonOff.Font = new Font("Segoe UI", 10F);
            buttonOff.Location = new Point(220, 220);
            buttonOff.Name = "buttonOff";
            buttonOff.Size = new Size(110, 40);
            buttonOff.TabIndex = 1;
            buttonOff.Text = "O&FF";
            buttonOff.UseVisualStyleBackColor = true;
            buttonOff.Click += buttonOff_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelResult.Location = new Point(24, 276);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(71, 25);
            labelResult.TabIndex = 0;
            labelResult.Text = "Result:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(410, 330);
            Controls.Add(labelResult);
            Controls.Add(buttonOff);
            Controls.Add(buttonOn);
            Controls.Add(buttonClose);
            Controls.Add(buttonClear);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxB);
            Controls.Add(labelB);
            Controls.Add(textBoxA);
            Controls.Add(labelA);
            Controls.Add(headerPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple Calculator";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

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
    }
}
