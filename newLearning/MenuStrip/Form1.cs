namespace MenuStrip
{
    // ============================================================================
    // PROFESSIONAL TEXT EDITOR APPLICATION
    // ============================================================================
    // Purpose: Ito ay isang simple yet powerful text editor na pwede mong gamitin
    //          para mag-create, mag-edit, at mag-save ng text files.
    // 
    // Features:
    //   - Create bagong files
    //   - Open existing files
    //   - Save files
    //   - Edit operations (cut, copy, paste)
    //   - Window management
    // ============================================================================

    public partial class Form1 : Form
    {
        // ========= VARIABLES NA GINAGAMIT NATIN =========
        // Ang currentFilePath ay nag-store ng file location na binuksan o nai-save
        // Kung empty, wala pang file na selected
        private string currentFilePath = string.Empty;

        // Ang isModified ay nag-track kung may changes na hindi pa na-save
        // TRUE = may changes, FALSE = wala pa
        private bool isModified = false;

        // Constructor - ito ang unang tatakbo pag nag-start ang program
        public Form1()
        {
            InitializeComponent(); // Setup lahat ng UI controls
            UpdateStatusBar("Ready"); // Ilagay ang "Ready" sa status bar
        }

        // ============================================================================
        // SECTION 1: FILE MENU EVENTS - Lahat ng "File" menu operations
        // ============================================================================

        // NEW FILE - Gumawa ng fresh start, clear lahat
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // CHECK: May unsaved changes ba?
            // If may text at isModified ay true, tanungin ang user kung gusto nila i-save
            if (isModified && mainTextBox.Text.Length > 0)
            {
                // Ipakita ang dialog para tanungin ang user
                DialogResult result = MessageBox.Show(
                    "Do you want to save changes before creating a new document?",
                    "Unsaved Changes",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                // Kung YES - save ang file
                if (result == DialogResult.Yes)
                    saveToolStripMenuItem_Click(sender, e);
                // Kung CANCEL - exit lang, huwag mag-proceed
                else if (result == DialogResult.Cancel)
                    return;
            }

            // Clear ang text box - walang laman na fresh start
            mainTextBox.Clear();
            // Wala pang file, so i-reset ang file path
            currentFilePath = string.Empty;
            // Mark as NOT modified since bagong file lang
            isModified = false;
            // Update ang title bar
            UpdateTitle();
            // Update ang status bar msg
            UpdateStatusBar("New document created");
        }

        // OPEN FILE - Buksan ang existing file
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Gumawa ng dialog para pumili ng file
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Set filter para text files lang
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog.Title = "Open File";

                // If user nag-click ng OK button
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Store ang path ng file
                        currentFilePath = openFileDialog.FileName;
                        // Basa ang lahat ng content from file at i-paste sa text box
                        mainTextBox.Text = File.ReadAllText(currentFilePath);
                        // Mark as NOT modified since fresh open lang
                        isModified = false;
                        // Update ang title bar para ipakita kung aling file ang open
                        UpdateTitle();
                        // Update ang status msg
                        UpdateStatusBar($"File opened: {Path.GetFileName(currentFilePath)}");
                    }
                    catch (Exception ex)
                    {
                        // Kung may error (ex: file corrupted, permission denied), show error msg
                        MessageBox.Show(
                            $"Error opening file: {ex.Message}",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        UpdateStatusBar("Error opening file");
                    }
                }
            }
        }

        // SAVE FILE - I-save ang file sa existing location
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // CHECK: May file path ba na open na?
            if (string.IsNullOrEmpty(currentFilePath))
            {
                // Kung wala, gamitin ang "Save As" para dapat mag-pick ng location
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                // May file path na, so i-save lang sa same location
                try
                {
                    // Write ang text mula sa text box into file
                    File.WriteAllText(currentFilePath, mainTextBox.Text);
                    // Mark as NOT modified since na-save na
                    isModified = false;
                    // Update ang title bar
                    UpdateTitle();
                    // Update ang status msg
                    UpdateStatusBar($"File saved: {Path.GetFileName(currentFilePath)}");
                }
                catch (Exception ex)
                {
                    // Kung may error (ex: disk full, permission denied)
                    MessageBox.Show(
                        $"Error saving file: {ex.Message}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    UpdateStatusBar("Error saving file");
                }
            }
        }

        // SAVE AS - I-save ang file sa bagong location with bagong name
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Gumawa ng dialog para mag-pick ng location at name
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // Set filter para text files lang
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.Title = "Save File As";

                // If user nag-click ng OK button
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Store ang bagong file path
                        currentFilePath = saveFileDialog.FileName;
                        // Write ang text mula sa text box into NEW file
                        File.WriteAllText(currentFilePath, mainTextBox.Text);
                        // Mark as NOT modified
                        isModified = false;
                        // Update ang title bar para ipakita ang bagong file name
                        UpdateTitle();
                        // Update ang status msg
                        UpdateStatusBar($"File saved as: {Path.GetFileName(currentFilePath)}");
                    }
                    catch (Exception ex)
                    {
                        // Kung may error
                        MessageBox.Show(
                            $"Error saving file: {ex.Message}",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        UpdateStatusBar("Error saving file");
                    }
                }
            }
        }

        // EXIT - Lumabas sa application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // CHECK: May unsaved changes ba bago lumabas?
            if (isModified && mainTextBox.Text.Length > 0)
            {
                // Tanungin ang user
                DialogResult result = MessageBox.Show(
                    "You have unsaved changes. Do you want to save before closing?",
                    "Unsaved Changes",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                // Kung YES - save bago lumabas
                if (result == DialogResult.Yes)
                    saveToolStripMenuItem_Click(sender, e);
                // Kung CANCEL - cancel ang exit
                else if (result == DialogResult.Cancel)
                    return;
            }

            // Close ang application
            Application.Exit();
        }

        // ============================================================================
        // SECTION 2: EDIT MENU EVENTS - Lahat ng "Edit" menu operations
        // ============================================================================

        // CUT - Kunin at i-copy sa clipboard, then i-delete sa text box
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // CHECK: May selected text ba?
            if (mainTextBox.SelectionLength > 0)
            {
                // Cut ang selected text
                mainTextBox.Cut();
                // Mark as modified dahil may binago
                isModified = true;
                // Update ang status msg
                UpdateStatusBar("Text cut to clipboard");
            }
        }

        // COPY - I-copy ang selected text sa clipboard (hindi i-delete)
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // CHECK: May selected text ba?
            if (mainTextBox.SelectionLength > 0)
            {
                // Copy ang selected text
                mainTextBox.Copy();
                // Update ang status msg
                UpdateStatusBar("Text copied to clipboard");
            }
            else
            {
                // Wala namang selected text, mag-info lang
                UpdateStatusBar("No text selected");
            }
        }

        // PASTE - I-insert ang text from clipboard sa current cursor position
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Paste ang clipboard content
            mainTextBox.Paste();
            // Mark as modified dahil may bagong text na
            isModified = true;
            // Update ang status msg
            UpdateStatusBar("Text pasted from clipboard");
        }

        // SELECT ALL - I-highlight lahat ng text
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Select lahat ng text sa text box
            mainTextBox.SelectAll();
            // Update ang status msg, ipakita kung gaano kalaki ang text
            UpdateStatusBar($"All text selected ({mainTextBox.TextLength} characters)");
        }

        // ============================================================================
        // SECTION 3: VIEW MENU EVENTS - Para sa window management
        // ============================================================================

        // WINDOW 1 - Check/Uncheck ang Window 1
        private void window1ToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            // Tawag ang method na mag-update ng window selection display
            UpdateWindowSelection();
        }

        // WINDOW 2 - Check/Uncheck ang Window 2
        private void window2ToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            // Tawag ang method na mag-update ng window selection display
            UpdateWindowSelection();
        }

        // Helper method: I-update ang display ng selected windows sa status bar
        private void UpdateWindowSelection()
        {
            // Gumawa ng message para ipakita ang active windows
            string windows = "Active Windows:\n";

            // If Window 1 ay checked, i-add sa message
            if (window1ToolStripMenuItem.Checked)
                windows += "✓ Window 1\n";

            // If Window 2 ay checked, i-add sa message
            if (window2ToolStripMenuItem.Checked)
                windows += "✓ Window 2\n";

            // Update ang status bar para makita ng user kung aling windows ay active
            UpdateStatusBar($"Windows - W1: {window1ToolStripMenuItem.Checked}, W2: {window2ToolStripMenuItem.Checked}");
        }

        // ============================================================================
        // SECTION 4: HELP MENU EVENTS - Information about ang app
        // ============================================================================

        // ABOUT - Ipakita ang info tungkol sa application
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ipakita ang dialog with app information
            MessageBox.Show(
                "Professional Text Editor v1.0\n\n" +
                "A simple yet powerful text editor for your daily tasks.\n\n" +
                "Features:\n" +
                "• Create, open, and save text files\n" +
                "• Edit operations (cut, copy, paste)\n" +
                "• Window management\n" +
                "• Professional interface\n\n" +
                "© 2025 Neil Wayne Cruz",
                "About Professional Text Editor",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // ============================================================================
        // SECTION 5: BUTTON CLICK EVENTS - Para sa buttons sa UI
        // ============================================================================

        // LOAD BUTTON - Same as "Open File" from menu
        private void loadButton_Click(object sender, EventArgs e)
        {
            // Tawag ang same method na ginagamit ng "Open" menu item
            openToolStripMenuItem_Click(sender, e);
        }

        // CLEAR BUTTON - Mag-confirm lang bago i-delete lahat ng text
        private void clearButton_Click(object sender, EventArgs e)
        {
            // CHECK: May text ba na i-clear?
            if (mainTextBox.Text.Length > 0)
            {
                // Tanungin ang user kung sure ba sila mag-delete ng lahat
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to clear all text?",
                    "Clear Text",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                // Kung YES
                if (result == DialogResult.Yes)
                {
                    // Delete lahat ng text
                    mainTextBox.Clear();
                    // Mark as modified
                    isModified = true;
                    // Update ang status msg
                    UpdateStatusBar("Text cleared");
                }
            }
        }

        // ============================================================================
        // SECTION 6: HELPER METHODS - Utility methods na ginagamit sa buong app
        // ============================================================================

        // UPDATE STATUS BAR - Simple method para mag-update ng status message
        private void UpdateStatusBar(string message)
        {
            // Set ang message sa status bar label
            toolStripStatusLabel.Text = message;
        }

        // UPDATE TITLE - Update ang title bar para ipakita ang file name at status
        private void UpdateTitle()
        {
            // Start with default title
            string title = "Professional Text Editor";

            // If may open file
            if (!string.IsNullOrEmpty(currentFilePath))
            {
                // Add ang file name sa title
                title = $"{Path.GetFileName(currentFilePath)} - {title}";
                
                // If may unsaved changes, add asterisk (*) para mag-indicate
                if (isModified)
                    title = "* " + title;
            }

            // Set ang title sa form
            Text = title;
        }

        // TRACK TEXT CHANGES - Ito ay tatakbo pag nag-load ang form
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
            // Subscribe sa TextChanged event ng text box
            // Ito ay mag-trigger pag may changes sa text
            mainTextBox.TextChanged += MainTextBox_TextChanged;
        }

        // EVENT HANDLER - Tatakbo pag may changes sa text box
        private void MainTextBox_TextChanged(object sender, EventArgs e)
        {
            // Mark as modified dahil may bagong change
            isModified = true;
            // Update ang title para ipakita ang asterisk (*)
            UpdateTitle();
        }

        // ============================================================================
        // END OF CODE - May questions? Basahin ang comments para maintindihan! 😊
        // ============================================================================
    }
}
