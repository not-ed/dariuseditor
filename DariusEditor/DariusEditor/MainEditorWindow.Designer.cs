namespace DariusEditor
{
    partial class MainEditorWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainEditorWindow));
            this.levelViewPanel = new System.Windows.Forms.Panel();
            this.levelGridBackground = new System.Windows.Forms.PictureBox();
            this.clearLevelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.highlightedDescriptionBody = new System.Windows.Forms.Label();
            this.highlightedDescriptionTitle = new System.Windows.Forms.Label();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.selectedTilePreview = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectedTileNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveLevelButton = new System.Windows.Forms.Button();
            this.loadLevelButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.themeSelectionBox = new System.Windows.Forms.ListBox();
            this.levelExportDialog = new System.Windows.Forms.SaveFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.levelLoadDialog = new System.Windows.Forms.OpenFileDialog();
            this.selectedThemePreview = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.copyLevelSeedButton = new System.Windows.Forms.Button();
            this.levelViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.levelGridBackground)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedTilePreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedThemePreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // levelViewPanel
            // 
            this.levelViewPanel.AutoScroll = true;
            this.levelViewPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.levelViewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.levelViewPanel.Controls.Add(this.levelGridBackground);
            this.levelViewPanel.Location = new System.Drawing.Point(12, 12);
            this.levelViewPanel.Name = "levelViewPanel";
            this.levelViewPanel.Size = new System.Drawing.Size(800, 657);
            this.levelViewPanel.TabIndex = 3;
            // 
            // levelGridBackground
            // 
            this.levelGridBackground.BackgroundImage = global::DariusEditor.Properties.Resources.editor_background_grass;
            this.levelGridBackground.Cursor = System.Windows.Forms.Cursors.Cross;
            this.levelGridBackground.Location = new System.Drawing.Point(0, 0);
            this.levelGridBackground.Name = "levelGridBackground";
            this.levelGridBackground.Size = new System.Drawing.Size(32, 32);
            this.levelGridBackground.TabIndex = 4;
            this.levelGridBackground.TabStop = false;
            this.levelGridBackground.MouseDown += new System.Windows.Forms.MouseEventHandler(this.levelGridBackground_MouseDown);
            // 
            // clearLevelButton
            // 
            this.clearLevelButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clearLevelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearLevelButton.ForeColor = System.Drawing.Color.Firebrick;
            this.clearLevelButton.Location = new System.Drawing.Point(986, 82);
            this.clearLevelButton.Name = "clearLevelButton";
            this.clearLevelButton.Size = new System.Drawing.Size(156, 32);
            this.clearLevelButton.TabIndex = 4;
            this.clearLevelButton.TabStop = false;
            this.clearLevelButton.Text = "Clear Level";
            this.clearLevelButton.UseVisualStyleBackColor = false;
            this.clearLevelButton.Click += new System.EventHandler(this.ResetLevel);
            this.clearLevelButton.MouseEnter += new System.EventHandler(this.clearLevelButton_MouseEnter);
            this.clearLevelButton.MouseLeave += new System.EventHandler(this.ClearHighlightedTitleAndBody);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.label1.Location = new System.Drawing.Point(822, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tiles";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.highlightedDescriptionBody);
            this.panel1.Controls.Add(this.highlightedDescriptionTitle);
            this.panel1.Location = new System.Drawing.Point(822, 474);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 117);
            this.panel1.TabIndex = 6;
            // 
            // highlightedDescriptionBody
            // 
            this.highlightedDescriptionBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlightedDescriptionBody.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.highlightedDescriptionBody.Location = new System.Drawing.Point(3, 23);
            this.highlightedDescriptionBody.Name = "highlightedDescriptionBody";
            this.highlightedDescriptionBody.Size = new System.Drawing.Size(310, 90);
            this.highlightedDescriptionBody.TabIndex = 1;
            this.highlightedDescriptionBody.Text = "label2";
            this.highlightedDescriptionBody.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // highlightedDescriptionTitle
            // 
            this.highlightedDescriptionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlightedDescriptionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.highlightedDescriptionTitle.Location = new System.Drawing.Point(3, 0);
            this.highlightedDescriptionTitle.Name = "highlightedDescriptionTitle";
            this.highlightedDescriptionTitle.Size = new System.Drawing.Size(310, 23);
            this.highlightedDescriptionTitle.TabIndex = 0;
            this.highlightedDescriptionTitle.Text = "label2";
            this.highlightedDescriptionTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.selectedTilePreview);
            this.panel2.Location = new System.Drawing.Point(822, 621);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(48, 48);
            this.panel2.TabIndex = 7;
            // 
            // selectedTilePreview
            // 
            this.selectedTilePreview.BackColor = System.Drawing.Color.Transparent;
            this.selectedTilePreview.Location = new System.Drawing.Point(6, 6);
            this.selectedTilePreview.Name = "selectedTilePreview";
            this.selectedTilePreview.Size = new System.Drawing.Size(32, 32);
            this.selectedTilePreview.TabIndex = 9;
            this.selectedTilePreview.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.label2.Location = new System.Drawing.Point(818, 594);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Currently Selected";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // selectedTileNameLabel
            // 
            this.selectedTileNameLabel.AutoSize = true;
            this.selectedTileNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.selectedTileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedTileNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.selectedTileNameLabel.Location = new System.Drawing.Point(876, 621);
            this.selectedTileNameLabel.Name = "selectedTileNameLabel";
            this.selectedTileNameLabel.Size = new System.Drawing.Size(62, 24);
            this.selectedTileNameLabel.TabIndex = 9;
            this.selectedTileNameLabel.Text = " None";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.label3.Location = new System.Drawing.Point(822, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Darius";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.label4.Location = new System.Drawing.Point(822, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Theme";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // saveLevelButton
            // 
            this.saveLevelButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.saveLevelButton.FlatAppearance.BorderSize = 2;
            this.saveLevelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveLevelButton.Location = new System.Drawing.Point(822, 120);
            this.saveLevelButton.Name = "saveLevelButton";
            this.saveLevelButton.Size = new System.Drawing.Size(156, 32);
            this.saveLevelButton.TabIndex = 17;
            this.saveLevelButton.TabStop = false;
            this.saveLevelButton.Text = "Save Level";
            this.saveLevelButton.UseVisualStyleBackColor = false;
            this.saveLevelButton.Click += new System.EventHandler(this.saveLevelButton_Click);
            this.saveLevelButton.MouseEnter += new System.EventHandler(this.saveLevelButton_MouseEnter);
            this.saveLevelButton.MouseLeave += new System.EventHandler(this.ClearHighlightedTitleAndBody);
            // 
            // loadLevelButton
            // 
            this.loadLevelButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.loadLevelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadLevelButton.Location = new System.Drawing.Point(984, 120);
            this.loadLevelButton.Name = "loadLevelButton";
            this.loadLevelButton.Size = new System.Drawing.Size(158, 32);
            this.loadLevelButton.TabIndex = 18;
            this.loadLevelButton.TabStop = false;
            this.loadLevelButton.Text = "Load Level";
            this.loadLevelButton.UseVisualStyleBackColor = false;
            this.loadLevelButton.Click += new System.EventHandler(this.InitializeLoadLevelDialog);
            this.loadLevelButton.MouseEnter += new System.EventHandler(this.loadLevelButton_MouseEnter);
            this.loadLevelButton.MouseLeave += new System.EventHandler(this.ClearHighlightedTitleAndBody);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.label5.Location = new System.Drawing.Point(876, 653);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "LMB = Place Tile | RMB = Remove Tile";
            // 
            // themeSelectionBox
            // 
            this.themeSelectionBox.FormattingEnabled = true;
            this.themeSelectionBox.Items.AddRange(new object[] {
            "Grasslands",
            "Desert",
            "Arctic"});
            this.themeSelectionBox.Location = new System.Drawing.Point(822, 199);
            this.themeSelectionBox.Name = "themeSelectionBox";
            this.themeSelectionBox.Size = new System.Drawing.Size(213, 43);
            this.themeSelectionBox.TabIndex = 24;
            this.themeSelectionBox.TabStop = false;
            this.themeSelectionBox.SelectedIndexChanged += new System.EventHandler(this.themeSelectionBox_SelectedIndexChanged);
            // 
            // levelExportDialog
            // 
            this.levelExportDialog.DefaultExt = "DARIUS";
            this.levelExportDialog.Filter = "Destruction Darius 3D Level | *.DARIUS";
            this.levelExportDialog.Title = "Save Level";
            this.levelExportDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFinalLevelSeedToFile);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // levelLoadDialog
            // 
            this.levelLoadDialog.DefaultExt = "DARIUS";
            this.levelLoadDialog.Filter = "Destruction Darius 3D Level | *.DARIUS";
            this.levelLoadDialog.Title = "Load Level";
            // 
            // selectedThemePreview
            // 
            this.selectedThemePreview.Image = global::DariusEditor.Properties.Resources.theme_preview_grass;
            this.selectedThemePreview.Location = new System.Drawing.Point(1041, 159);
            this.selectedThemePreview.Name = "selectedThemePreview";
            this.selectedThemePreview.Size = new System.Drawing.Size(96, 96);
            this.selectedThemePreview.TabIndex = 14;
            this.selectedThemePreview.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DariusEditor.Properties.Resources.editor_logo;
            this.pictureBox1.Location = new System.Drawing.Point(822, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 64);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // copyLevelSeedButton
            // 
            this.copyLevelSeedButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.copyLevelSeedButton.FlatAppearance.BorderSize = 2;
            this.copyLevelSeedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyLevelSeedButton.Location = new System.Drawing.Point(822, 82);
            this.copyLevelSeedButton.Name = "copyLevelSeedButton";
            this.copyLevelSeedButton.Size = new System.Drawing.Size(156, 32);
            this.copyLevelSeedButton.TabIndex = 25;
            this.copyLevelSeedButton.TabStop = false;
            this.copyLevelSeedButton.Text = "Get Level Seed";
            this.copyLevelSeedButton.UseVisualStyleBackColor = false;
            this.copyLevelSeedButton.Click += new System.EventHandler(this.copyLevelSeedButton_Click);
            this.copyLevelSeedButton.MouseEnter += new System.EventHandler(this.copyLevelSeedButton_MouseEnter);
            this.copyLevelSeedButton.MouseLeave += new System.EventHandler(this.ClearHighlightedTitleAndBody);
            // 
            // MainEditorWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(175)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(1154, 681);
            this.Controls.Add(this.copyLevelSeedButton);
            this.Controls.Add(this.themeSelectionBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.loadLevelButton);
            this.Controls.Add(this.saveLevelButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.selectedThemePreview);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectedTileNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearLevelButton);
            this.Controls.Add(this.levelViewPanel);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1170, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1170, 720);
            this.Name = "MainEditorWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Darius Editor";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.aboutButton_Click);
            this.Load += new System.EventHandler(this.MainEditorWindow_Load);
            this.levelViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.levelGridBackground)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.selectedTilePreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedThemePreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel levelViewPanel;
        private System.Windows.Forms.PictureBox levelGridBackground;
        private System.Windows.Forms.Button clearLevelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label highlightedDescriptionTitle;
        private System.Windows.Forms.Label highlightedDescriptionBody;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox selectedTilePreview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label selectedTileNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox selectedThemePreview;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveLevelButton;
        private System.Windows.Forms.Button loadLevelButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox themeSelectionBox;
        private System.Windows.Forms.SaveFileDialog levelExportDialog;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.OpenFileDialog levelLoadDialog;
        private System.Windows.Forms.Button copyLevelSeedButton;
    }
}

