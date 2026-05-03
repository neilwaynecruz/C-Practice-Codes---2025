namespace MenuStrip
{
    // ============================================================================
    // FORM1.DESIGNER.CS - UI LAYOUT AT SETUP
    // ============================================================================
    // Ang file na ito ay nag-define ng lahat ng UI components (buttons, text boxes, menus)
    // at nag-set up kung paano sila mag-arrange sa screen.
    // 
    // NOTE: Ito ay auto-generated ng Visual Studio Designer, pero may comments na
    //       nag-explain kung ano ang bawat parte para sa beginners.
    // ============================================================================

    partial class Form1
    {
        /// <summary>
        ///  Required designer variable - nag-store ng lahat ng UI components
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up resources pag mag-close ang application
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
        ///  Setup ng lahat ng controls at appearance ng Form
        ///  INSTRUCTION: DO NOT MODIFY MANUALLY - Gamitin ang Designer lang
        /// </summary>
        private void InitializeComponent()
        {
            // ========== STEP 1: Declare lahat ng UI controls ==========
            // Dito nag-create kami ng variables para sa bawat UI element
            // (menus, buttons, text boxes, etc.)
            
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            window1ToolStripMenuItem = new ToolStripMenuItem();
            window2ToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            mainContentPanel = new Panel();
            textAreaLabel = new Label();
            mainTextBox = new TextBox();
            buttonPanel = new Panel();
            clearButton = new Button();
            loadButton = new Button();
            toolStrip1 = new ToolStrip();
            newToolStripButton = new ToolStripButton();
            openToolStripButton = new ToolStripButton();
            saveToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            copyToolStripButton = new ToolStripButton();
            pasteToolStripButton = new ToolStripButton();

            // ========== STEP 2: Suspend layout para mag-batch ng updates ==========
            // Ito ay nag-pause ng drawing para mas mabilis ang setup
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            mainContentPanel.SuspendLayout();
            buttonPanel.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();

            // ========== STEP 3: Configure ang MENU STRIP (top menu bar) ==========
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            // Add ang main menu items: File, Edit, View, Help
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            
            // ========== FILE MENU - Lahat ng file-related options ==========
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripMenuItem1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            
            // New option
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N; // Ctrl+N
            newToolStripMenuItem.Size = new Size(195, 26);
            newToolStripMenuItem.Text = "&New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            
            // Open option
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O; // Ctrl+O
            openToolStripMenuItem.Size = new Size(195, 26);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            
            // Save option
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S; // Ctrl+S
            saveToolStripMenuItem.Size = new Size(195, 26);
            saveToolStripMenuItem.Text = "&Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            
            // Save As option
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(195, 26);
            saveAsToolStripMenuItem.Text = "Save &As...";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            
            // Separator line
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(192, 6);
            
            // Exit option
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X; // Ctrl+X
            exitToolStripMenuItem.Size = new Size(195, 26);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            
            // ========== EDIT MENU - Lahat ng edit-related options ==========
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripMenuItem2, selectAllToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "&Edit";
            
            // Cut option
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X; // Ctrl+X
            cutToolStripMenuItem.Size = new Size(195, 26);
            cutToolStripMenuItem.Text = "Cu&t";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            
            // Copy option
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C; // Ctrl+C
            copyToolStripMenuItem.Size = new Size(195, 26);
            copyToolStripMenuItem.Text = "&Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            
            // Paste option
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V; // Ctrl+V
            pasteToolStripMenuItem.Size = new Size(195, 26);
            pasteToolStripMenuItem.Text = "&Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            
            // Separator line
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(192, 6);
            
            // Select All option
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A; // Ctrl+A
            selectAllToolStripMenuItem.Size = new Size(195, 26);
            selectAllToolStripMenuItem.Text = "Select &All";
            selectAllToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
            
            // ========== VIEW MENU - Para sa window management ==========
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { window1ToolStripMenuItem, window2ToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "&View";
            
            // Window 1 option
            window1ToolStripMenuItem.Checked = true;
            window1ToolStripMenuItem.CheckOnClick = true;
            window1ToolStripMenuItem.CheckState = CheckState.Checked;
            window1ToolStripMenuItem.Name = "window1ToolStripMenuItem";
            window1ToolStripMenuItem.Size = new Size(163, 26);
            window1ToolStripMenuItem.Text = "Window &1";
            window1ToolStripMenuItem.CheckedChanged += window1ToolStripMenuItem_CheckedChanged;
            
            // Window 2 option
            window2ToolStripMenuItem.CheckOnClick = true;
            window2ToolStripMenuItem.Name = "window2ToolStripMenuItem";
            window2ToolStripMenuItem.Size = new Size(163, 26);
            window2ToolStripMenuItem.Text = "Window &2";
            window2ToolStripMenuItem.CheckedChanged += window2ToolStripMenuItem_CheckedChanged;
            
            // ========== HELP MENU - Help at info options ==========
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            
            // About option
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(133, 26);
            aboutToolStripMenuItem.Text = "&About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            
            // ========== STATUS STRIP - Bottom status bar ==========
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip1.Location = new Point(0, 429);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            
            // Status label - ipapakita ang messages (ex: "Ready", "File saved")
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(39, 17);
            toolStripStatusLabel.Text = "Ready";
            
            // ========== MAIN CONTENT PANEL - Center area where text goes ==========
            mainContentPanel.BackColor = Color.White;
            mainContentPanel.Controls.Add(textAreaLabel);
            mainContentPanel.Controls.Add(mainTextBox);
            mainContentPanel.Controls.Add(buttonPanel);
            mainContentPanel.Dock = DockStyle.Fill; // Fill ang available space
            mainContentPanel.Location = new Point(0, 49);
            mainContentPanel.Name = "mainContentPanel";
            mainContentPanel.Padding = new Padding(10); // Space around edges
            mainContentPanel.Size = new Size(800, 380);
            mainContentPanel.TabIndex = 2;
            
            // Text Area Label - "Text Area:" na tumutulong identify ang text box
            textAreaLabel.AutoSize = true;
            textAreaLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            textAreaLabel.ForeColor = Color.FromArgb(50, 50, 50);
            textAreaLabel.Location = new Point(10, 10);
            textAreaLabel.Name = "textAreaLabel";
            textAreaLabel.Size = new Size(74, 17);
            textAreaLabel.TabIndex = 0;
            textAreaLabel.Text = "Text Area:";
            
            // Main Text Box - kung saan nag-type ang user
            mainTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainTextBox.BackColor = Color.FromArgb(250, 250, 250);
            mainTextBox.Font = new Font("Segoe UI", 10F);
            mainTextBox.Location = new Point(13, 35);
            mainTextBox.Multiline = true; // Allow multiple lines
            mainTextBox.Name = "mainTextBox";
            mainTextBox.ScrollBars = ScrollBars.Both; // Show scroll bars kung needed
            mainTextBox.Size = new Size(774, 280);
            mainTextBox.TabIndex = 1;
            
            // ========== BUTTON PANEL - May Load at Clear buttons ==========
            buttonPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonPanel.Controls.Add(clearButton);
            buttonPanel.Controls.Add(loadButton);
            buttonPanel.Location = new Point(560, 330);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(230, 50);
            buttonPanel.TabIndex = 2;
            
            // Clear Button - mag-clear ng text
            clearButton.BackColor = Color.FromArgb(230, 230, 230);
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.Font = new Font("Segoe UI", 9F);
            clearButton.ForeColor = Color.FromArgb(50, 50, 50);
            clearButton.Location = new Point(120, 10);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(100, 32);
            clearButton.TabIndex = 1;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            
            // Load Button - mag-open ng file
            loadButton.BackColor = Color.FromArgb(45, 118, 202); // Blue color
            loadButton.FlatStyle = FlatStyle.Flat;
            loadButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            loadButton.ForeColor = Color.White;
            loadButton.Location = new Point(10, 10);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(100, 32);
            loadButton.TabIndex = 0;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = false;
            loadButton.Click += loadButton_Click;
            
            // ========== TOOL STRIP - Top toolbar with quick buttons ==========
            toolStrip1.BackColor = SystemColors.Control;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { newToolStripButton, openToolStripButton, saveToolStripButton, toolStripSeparator1, copyToolStripButton, pasteToolStripButton });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            
            // Toolbar buttons - quick access sa common functions
            newToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            newToolStripButton.Image = SystemIcons.Application.ToBitmap();
            newToolStripButton.ImageTransparentColor = Color.Magenta;
            newToolStripButton.Name = "newToolStripButton";
            newToolStripButton.Size = new Size(24, 22);
            newToolStripButton.Text = "&New";
            newToolStripButton.Click += newToolStripMenuItem_Click;
            
            openToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            openToolStripButton.Image = SystemIcons.Shield.ToBitmap();
            openToolStripButton.ImageTransparentColor = Color.Magenta;
            openToolStripButton.Name = "openToolStripButton";
            openToolStripButton.Size = new Size(24, 22);
            openToolStripButton.Text = "&Open";
            openToolStripButton.Click += openToolStripMenuItem_Click;
            
            saveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveToolStripButton.Image = SystemIcons.Information.ToBitmap();
            saveToolStripButton.ImageTransparentColor = Color.Magenta;
            saveToolStripButton.Name = "saveToolStripButton";
            saveToolStripButton.Size = new Size(24, 22);
            saveToolStripButton.Text = "&Save";
            saveToolStripButton.Click += saveToolStripMenuItem_Click;
            
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            
            copyToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            copyToolStripButton.Image = SystemIcons.Asterisk.ToBitmap();
            copyToolStripButton.ImageTransparentColor = Color.Magenta;
            copyToolStripButton.Name = "copyToolStripButton";
            copyToolStripButton.Size = new Size(24, 22);
            copyToolStripButton.Text = "&Copy";
            copyToolStripButton.Click += copyToolStripMenuItem_Click;
            
            pasteToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            pasteToolStripButton.Image = SystemIcons.Warning.ToBitmap();
            pasteToolStripButton.ImageTransparentColor = Color.Magenta;
            pasteToolStripButton.Name = "pasteToolStripButton";
            pasteToolStripButton.Size = new Size(24, 22);
            pasteToolStripButton.Text = "&Paste";
            pasteToolStripButton.Click += pasteToolStripMenuItem_Click;
            
            // ========== FORM1 - Main window configuration ==========
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            // Add lahat ng controls sa form
            Controls.Add(mainContentPanel);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen; // Center ang window pag mag-start
            Text = "Professional Text Editor";
            
            // ========== STEP 4: Resume layout at enable drawing ==========
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            mainContentPanel.ResumeLayout(false);
            mainContentPanel.PerformLayout();
            buttonPanel.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // ============================================================================
        // DECLARE LAHAT NG UI CONTROLS - Dito nagsisimula ang field declarations
        // Bawat control dito ay may corresponding code sa InitializeComponent()
        // ============================================================================

        private System.Windows.Forms.MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem window1ToolStripMenuItem;
        private ToolStripMenuItem window2ToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel;
        private Panel mainContentPanel;
        private Label textAreaLabel;
        private TextBox mainTextBox;
        private Panel buttonPanel;
        private Button loadButton;
        private Button clearButton;
        private ToolStrip toolStrip1;
        private ToolStripButton newToolStripButton;
        private ToolStripButton openToolStripButton;
        private ToolStripButton saveToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton copyToolStripButton;
        private ToolStripButton pasteToolStripButton;
    }
}
