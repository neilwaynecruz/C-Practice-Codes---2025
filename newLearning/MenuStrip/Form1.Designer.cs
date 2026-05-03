namespace MenuStrip
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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            edit1ToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            edit2ToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            wIndowToolStripMenuItem = new ToolStripMenuItem();
            window1ToolStripMenuItem = new ToolStripMenuItem();
            window2ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, wIndowToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(497, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, saveToolStripMenuItem, toolStripMenuItem1, exitToolStripMenuItem });
            fileToolStripMenuItem.Image = Properties.Resources.GTR_PICTURE_1;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(66, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(224, 26);
            newToolStripMenuItem.Text = "&New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(224, 26);
            saveToolStripMenuItem.Text = "&Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(221, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { edit1ToolStripMenuItem, edit2ToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // edit1ToolStripMenuItem
            // 
            edit1ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copyToolStripMenuItem });
            edit1ToolStripMenuItem.Name = "edit1ToolStripMenuItem";
            edit1ToolStripMenuItem.Size = new Size(130, 26);
            edit1ToolStripMenuItem.Text = "Edit 1";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(126, 26);
            copyToolStripMenuItem.Text = "Copy";
            // 
            // edit2ToolStripMenuItem
            // 
            edit2ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pasteToolStripMenuItem });
            edit2ToolStripMenuItem.Name = "edit2ToolStripMenuItem";
            edit2ToolStripMenuItem.Size = new Size(130, 26);
            edit2ToolStripMenuItem.Text = "Edit 2";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(126, 26);
            pasteToolStripMenuItem.Text = "Paste";
            // 
            // wIndowToolStripMenuItem
            // 
            wIndowToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { window1ToolStripMenuItem, window2ToolStripMenuItem });
            wIndowToolStripMenuItem.Name = "wIndowToolStripMenuItem";
            wIndowToolStripMenuItem.Size = new Size(78, 24);
            wIndowToolStripMenuItem.Text = "WIndow";
            // 
            // window1ToolStripMenuItem
            // 
            window1ToolStripMenuItem.Checked = true;
            window1ToolStripMenuItem.CheckOnClick = true;
            window1ToolStripMenuItem.CheckState = CheckState.Checked;
            window1ToolStripMenuItem.Name = "window1ToolStripMenuItem";
            window1ToolStripMenuItem.Size = new Size(224, 26);
            window1ToolStripMenuItem.Text = "Window 1";
            window1ToolStripMenuItem.CheckedChanged += window1ToolStripMenuItem_Click;
            window1ToolStripMenuItem.Click += window1ToolStripMenuItem_Click;
            // 
            // window2ToolStripMenuItem
            // 
            window2ToolStripMenuItem.CheckOnClick = true;
            window2ToolStripMenuItem.Name = "window2ToolStripMenuItem";
            window2ToolStripMenuItem.Size = new Size(224, 26);
            window2ToolStripMenuItem.Text = "Window 2";
            //window2ToolStripMenuItem.Click += window2ToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem edit1ToolStripMenuItem;
        private ToolStripMenuItem edit2ToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem wIndowToolStripMenuItem;
        private ToolStripMenuItem window1ToolStripMenuItem;
        private ToolStripMenuItem window2ToolStripMenuItem;
    }
}
