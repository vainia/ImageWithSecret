namespace ImageWithSecretForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureHide = new System.Windows.Forms.PictureBox();
            this.hideModeSwitcher = new System.Windows.Forms.Button();
            this.hideModeLabel = new System.Windows.Forms.Label();
            this.textToHide = new System.Windows.Forms.TextBox();
            this.pictureHider = new System.Windows.Forms.PictureBox();
            this.pictureHidden = new System.Windows.Forms.PictureBox();
            this.labelHidden = new System.Windows.Forms.Label();
            this.listOfCompressions = new System.Windows.Forms.CheckedListBox();
            this.labelSettings = new System.Windows.Forms.Label();
            this.panelDivider = new System.Windows.Forms.Panel();
            this.labelCompression = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listOfEncryptions = new System.Windows.Forms.CheckedListBox();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonOpenDialogHider = new System.Windows.Forms.Button();
            this.labelDropHider = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonReload = new System.Windows.Forms.Button();
            this.labelDropHide = new System.Windows.Forms.Label();
            this.buttonOpenDialogHide = new System.Windows.Forms.Button();
            this.labelHider = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.textKey = new System.Windows.Forms.TextBox();
            this.labelKey = new System.Windows.Forms.Label();
            this.checkInteractive = new System.Windows.Forms.CheckBox();
            this.checkBoxTips = new System.Windows.Forms.CheckBox();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHidden)).BeginInit();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureHide
            // 
            this.pictureHide.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureHide.Location = new System.Drawing.Point(6, 29);
            this.pictureHide.Margin = new System.Windows.Forms.Padding(2);
            this.pictureHide.Name = "pictureHide";
            this.pictureHide.Size = new System.Drawing.Size(254, 165);
            this.pictureHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureHide.TabIndex = 0;
            this.pictureHide.TabStop = false;
            this.pictureHide.Visible = false;
            // 
            // hideModeSwitcher
            // 
            this.hideModeSwitcher.BackColor = System.Drawing.Color.Transparent;
            this.hideModeSwitcher.Location = new System.Drawing.Point(69, 3);
            this.hideModeSwitcher.Margin = new System.Windows.Forms.Padding(0);
            this.hideModeSwitcher.Name = "hideModeSwitcher";
            this.hideModeSwitcher.Size = new System.Drawing.Size(190, 22);
            this.hideModeSwitcher.TabIndex = 1;
            this.hideModeSwitcher.Text = "Text";
            this.hideModeSwitcher.UseVisualStyleBackColor = false;
            this.hideModeSwitcher.Click += new System.EventHandler(this.HideModeSwitcher_Click);
            // 
            // hideModeLabel
            // 
            this.hideModeLabel.AutoSize = true;
            this.hideModeLabel.Location = new System.Drawing.Point(6, 11);
            this.hideModeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hideModeLabel.Name = "hideModeLabel";
            this.hideModeLabel.Size = new System.Drawing.Size(61, 13);
            this.hideModeLabel.TabIndex = 2;
            this.hideModeLabel.Text = "Hide mode:";
            // 
            // textToHide
            // 
            this.textToHide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textToHide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textToHide.Location = new System.Drawing.Point(5, 29);
            this.textToHide.Margin = new System.Windows.Forms.Padding(2);
            this.textToHide.Multiline = true;
            this.textToHide.Name = "textToHide";
            this.textToHide.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textToHide.Size = new System.Drawing.Size(254, 163);
            this.textToHide.TabIndex = 3;
            // 
            // pictureHider
            // 
            this.pictureHider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureHider.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureHider.Location = new System.Drawing.Point(6, 211);
            this.pictureHider.Margin = new System.Windows.Forms.Padding(2);
            this.pictureHider.Name = "pictureHider";
            this.pictureHider.Size = new System.Drawing.Size(254, 165);
            this.pictureHider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureHider.TabIndex = 4;
            this.pictureHider.TabStop = false;
            // 
            // pictureHidden
            // 
            this.pictureHidden.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureHidden.BackColor = System.Drawing.Color.Transparent;
            this.pictureHidden.Location = new System.Drawing.Point(263, 41);
            this.pictureHidden.Margin = new System.Windows.Forms.Padding(2);
            this.pictureHidden.Name = "pictureHidden";
            this.pictureHidden.Size = new System.Drawing.Size(325, 246);
            this.pictureHidden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureHidden.TabIndex = 6;
            this.pictureHidden.TabStop = false;
            // 
            // labelHidden
            // 
            this.labelHidden.AutoSize = true;
            this.labelHidden.Location = new System.Drawing.Point(263, 10);
            this.labelHidden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHidden.Name = "labelHidden";
            this.labelHidden.Size = new System.Drawing.Size(75, 13);
            this.labelHidden.TabIndex = 7;
            this.labelHidden.Text = "Hidden image:";
            this.labelHidden.Visible = false;
            // 
            // listOfCompressions
            // 
            this.listOfCompressions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listOfCompressions.FormattingEnabled = true;
            this.listOfCompressions.Location = new System.Drawing.Point(592, 167);
            this.listOfCompressions.Margin = new System.Windows.Forms.Padding(2);
            this.listOfCompressions.Name = "listOfCompressions";
            this.listOfCompressions.Size = new System.Drawing.Size(259, 94);
            this.listOfCompressions.TabIndex = 8;
            // 
            // labelSettings
            // 
            this.labelSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSettings.AutoSize = true;
            this.labelSettings.Location = new System.Drawing.Point(592, 11);
            this.labelSettings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(48, 13);
            this.labelSettings.TabIndex = 9;
            this.labelSettings.Text = "Settings:";
            // 
            // panelDivider
            // 
            this.panelDivider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDivider.BackColor = System.Drawing.Color.SteelBlue;
            this.panelDivider.Location = new System.Drawing.Point(592, 29);
            this.panelDivider.Margin = new System.Windows.Forms.Padding(2);
            this.panelDivider.Name = "panelDivider";
            this.panelDivider.Size = new System.Drawing.Size(258, 6);
            this.panelDivider.TabIndex = 10;
            // 
            // labelCompression
            // 
            this.labelCompression.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCompression.AutoSize = true;
            this.labelCompression.Location = new System.Drawing.Point(592, 150);
            this.labelCompression.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCompression.Name = "labelCompression";
            this.labelCompression.Size = new System.Drawing.Size(79, 13);
            this.labelCompression.TabIndex = 9;
            this.labelCompression.Text = "• Compression:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(592, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "• Encryption:";
            // 
            // listOfEncryptions
            // 
            this.listOfEncryptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listOfEncryptions.FormattingEnabled = true;
            this.listOfEncryptions.Location = new System.Drawing.Point(592, 54);
            this.listOfEncryptions.Margin = new System.Windows.Forms.Padding(2);
            this.listOfEncryptions.Name = "listOfEncryptions";
            this.listOfEncryptions.Size = new System.Drawing.Size(259, 79);
            this.listOfEncryptions.TabIndex = 8;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEncrypt.BackColor = System.Drawing.Color.Transparent;
            this.buttonEncrypt.Enabled = false;
            this.buttonEncrypt.Location = new System.Drawing.Point(592, 270);
            this.buttonEncrypt.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(127, 41);
            this.buttonEncrypt.TabIndex = 11;
            this.buttonEncrypt.Text = "Hide";
            this.buttonEncrypt.UseVisualStyleBackColor = false;
            this.buttonEncrypt.Click += new System.EventHandler(this.ButtonEncrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDecrypt.BackColor = System.Drawing.Color.Transparent;
            this.buttonDecrypt.Enabled = false;
            this.buttonDecrypt.Location = new System.Drawing.Point(723, 270);
            this.buttonDecrypt.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(127, 41);
            this.buttonDecrypt.TabIndex = 12;
            this.buttonDecrypt.Text = "Reveal";
            this.buttonDecrypt.UseVisualStyleBackColor = false;
            this.buttonDecrypt.Click += new System.EventHandler(this.ButtonDecrypt_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.BackColor = System.Drawing.Color.Transparent;
            this.buttonSave.Location = new System.Drawing.Point(592, 314);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(258, 62);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonOpenDialogHider
            // 
            this.buttonOpenDialogHider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOpenDialogHider.BackColor = System.Drawing.Color.Transparent;
            this.buttonOpenDialogHider.Location = new System.Drawing.Point(18, 244);
            this.buttonOpenDialogHider.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenDialogHider.Name = "buttonOpenDialogHider";
            this.buttonOpenDialogHider.Size = new System.Drawing.Size(113, 99);
            this.buttonOpenDialogHider.TabIndex = 14;
            this.buttonOpenDialogHider.Text = "Choose image";
            this.buttonOpenDialogHider.UseVisualStyleBackColor = false;
            this.buttonOpenDialogHider.Click += new System.EventHandler(this.ButtonOpenDialog_Click);
            // 
            // labelDropHider
            // 
            this.labelDropHider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDropHider.AutoSize = true;
            this.labelDropHider.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelDropHider.Location = new System.Drawing.Point(135, 287);
            this.labelDropHider.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDropHider.Name = "labelDropHider";
            this.labelDropHider.Size = new System.Drawing.Size(109, 13);
            this.labelDropHider.TabIndex = 15;
            this.labelDropHider.Text = "or drag and drop here";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // buttonReload
            // 
            this.buttonReload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReload.Location = new System.Drawing.Point(263, 314);
            this.buttonReload.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(325, 62);
            this.buttonReload.TabIndex = 16;
            this.buttonReload.Text = "Reload";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.ButtonReload_Click);
            // 
            // labelDropHide
            // 
            this.labelDropHide.AutoSize = true;
            this.labelDropHide.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelDropHide.Location = new System.Drawing.Point(135, 103);
            this.labelDropHide.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDropHide.Name = "labelDropHide";
            this.labelDropHide.Size = new System.Drawing.Size(109, 13);
            this.labelDropHide.TabIndex = 15;
            this.labelDropHide.Text = "or drag and drop here";
            this.labelDropHide.Visible = false;
            // 
            // buttonOpenDialogHide
            // 
            this.buttonOpenDialogHide.BackColor = System.Drawing.Color.Transparent;
            this.buttonOpenDialogHide.Location = new System.Drawing.Point(18, 61);
            this.buttonOpenDialogHide.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenDialogHide.Name = "buttonOpenDialogHide";
            this.buttonOpenDialogHide.Size = new System.Drawing.Size(113, 99);
            this.buttonOpenDialogHide.TabIndex = 14;
            this.buttonOpenDialogHide.Text = "Choose image";
            this.buttonOpenDialogHide.UseVisualStyleBackColor = false;
            this.buttonOpenDialogHide.Visible = false;
            this.buttonOpenDialogHide.Click += new System.EventHandler(this.ButtonOpenDialog_Click);
            // 
            // labelHider
            // 
            this.labelHider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelHider.AutoSize = true;
            this.labelHider.Location = new System.Drawing.Point(5, 194);
            this.labelHider.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHider.Name = "labelHider";
            this.labelHider.Size = new System.Drawing.Size(69, 13);
            this.labelHider.TabIndex = 17;
            this.labelHider.Text = "Picture hider:";
            // 
            // textKey
            // 
            this.textKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textKey.Location = new System.Drawing.Point(297, 291);
            this.textKey.Margin = new System.Windows.Forms.Padding(2);
            this.textKey.Multiline = true;
            this.textKey.Name = "textKey";
            this.textKey.Size = new System.Drawing.Size(186, 21);
            this.textKey.TabIndex = 18;
            this.textKey.TextChanged += new System.EventHandler(this.TextKey_TextChanged);
            // 
            // labelKey
            // 
            this.labelKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(263, 296);
            this.labelKey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(28, 13);
            this.labelKey.TabIndex = 19;
            this.labelKey.Text = "Key:";
            this.labelKey.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkInteractive
            // 
            this.checkInteractive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkInteractive.AutoSize = true;
            this.checkInteractive.Location = new System.Drawing.Point(483, 292);
            this.checkInteractive.Margin = new System.Windows.Forms.Padding(2);
            this.checkInteractive.Name = "checkInteractive";
            this.checkInteractive.Size = new System.Drawing.Size(106, 17);
            this.checkInteractive.TabIndex = 20;
            this.checkInteractive.Text = "Interactive Mode";
            this.checkInteractive.UseVisualStyleBackColor = true;
            // 
            // checkBoxTips
            // 
            this.checkBoxTips.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxTips.AutoSize = true;
            this.checkBoxTips.Checked = true;
            this.checkBoxTips.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTips.Location = new System.Drawing.Point(803, 7);
            this.checkBoxTips.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxTips.Name = "checkBoxTips";
            this.checkBoxTips.Size = new System.Drawing.Size(46, 17);
            this.checkBoxTips.TabIndex = 21;
            this.checkBoxTips.Text = "Tips";
            this.checkBoxTips.UseVisualStyleBackColor = true;
            this.checkBoxTips.CheckedChanged += new System.EventHandler(this.checkBoxTips_CheckedChanged);
            // 
            // statusBar
            // 
            this.statusBar.BackColor = System.Drawing.Color.Transparent;
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 376);
            this.statusBar.Name = "statusBar";
            this.statusBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusBar.Size = new System.Drawing.Size(859, 22);
            this.statusBar.TabIndex = 22;
            this.statusBar.Text = "statusBar";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(859, 398);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.checkBoxTips);
            this.Controls.Add(this.checkInteractive);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.textKey);
            this.Controls.Add(this.labelHider);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.labelDropHide);
            this.Controls.Add(this.labelDropHider);
            this.Controls.Add(this.buttonOpenDialogHide);
            this.Controls.Add(this.buttonOpenDialogHider);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.panelDivider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCompression);
            this.Controls.Add(this.labelSettings);
            this.Controls.Add(this.listOfEncryptions);
            this.Controls.Add(this.listOfCompressions);
            this.Controls.Add(this.labelHidden);
            this.Controls.Add(this.pictureHidden);
            this.Controls.Add(this.pictureHider);
            this.Controls.Add(this.textToHide);
            this.Controls.Add(this.hideModeLabel);
            this.Controls.Add(this.hideModeSwitcher);
            this.Controls.Add(this.pictureHide);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(875, 436);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Image With Secret";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.MainForm_DragOver);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHidden)).EndInit();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureHide;
        private System.Windows.Forms.Button hideModeSwitcher;
        private System.Windows.Forms.Label hideModeLabel;
        private System.Windows.Forms.TextBox textToHide;
        private System.Windows.Forms.PictureBox pictureHider;
        private System.Windows.Forms.PictureBox pictureHidden;
        private System.Windows.Forms.Label labelHidden;
        private System.Windows.Forms.CheckedListBox listOfCompressions;
        private System.Windows.Forms.Label labelSettings;
        private System.Windows.Forms.Panel panelDivider;
        private System.Windows.Forms.Label labelCompression;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox listOfEncryptions;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonOpenDialogHider;
        private System.Windows.Forms.Label labelDropHider;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.Label labelDropHide;
        private System.Windows.Forms.Button buttonOpenDialogHide;
        private System.Windows.Forms.Label labelHider;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox textKey;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.CheckBox checkInteractive;
        private System.Windows.Forms.CheckBox checkBoxTips;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}

