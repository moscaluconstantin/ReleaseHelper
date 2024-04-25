namespace ReleaseHelper
{
    partial class ReleaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReleaseForm));
            this._userStoryTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._userStoryType = new System.Windows.Forms.ComboBox();
            this._createFileButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this._sprintTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._sprintEndDateTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._copyFileNameButton = new System.Windows.Forms.Button();
            this._copyReleasePathButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._copyBranchNameButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _userStoryTextBox
            // 
            this._userStoryTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._userStoryTextBox.Location = new System.Drawing.Point(91, 29);
            this._userStoryTextBox.Name = "_userStoryTextBox";
            this._userStoryTextBox.PlaceholderText = "123465";
            this._userStoryTextBox.Size = new System.Drawing.Size(100, 23);
            this._userStoryTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Story Id";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Story Type";
            // 
            // _userStoryType
            // 
            this._userStoryType.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._userStoryType.FormattingEnabled = true;
            this._userStoryType.Items.AddRange(new object[] {
            "Feature",
            "Bug"});
            this._userStoryType.Location = new System.Drawing.Point(105, 58);
            this._userStoryType.Name = "_userStoryType";
            this._userStoryType.Size = new System.Drawing.Size(86, 23);
            this._userStoryType.TabIndex = 3;
            // 
            // _createFileButton
            // 
            this._createFileButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._createFileButton.Location = new System.Drawing.Point(10, 178);
            this._createFileButton.Name = "_createFileButton";
            this._createFileButton.Size = new System.Drawing.Size(181, 23);
            this._createFileButton.TabIndex = 4;
            this._createFileButton.Text = "Create File";
            this._createFileButton.UseVisualStyleBackColor = true;
            this._createFileButton.Click += new System.EventHandler(this.CreateFileButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // _sprintTextBox
            // 
            this._sprintTextBox.Location = new System.Drawing.Point(71, 21);
            this._sprintTextBox.Name = "_sprintTextBox";
            this._sprintTextBox.PlaceholderText = "21";
            this._sprintTextBox.ReadOnly = true;
            this._sprintTextBox.Size = new System.Drawing.Size(102, 23);
            this._sprintTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "End Date";
            // 
            // _sprintEndDateTextBox
            // 
            this._sprintEndDateTextBox.Location = new System.Drawing.Point(71, 50);
            this._sprintEndDateTextBox.Name = "_sprintEndDateTextBox";
            this._sprintEndDateTextBox.PlaceholderText = "04.06.2023";
            this._sprintEndDateTextBox.ReadOnly = true;
            this._sprintEndDateTextBox.Size = new System.Drawing.Size(102, 23);
            this._sprintEndDateTextBox.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this._sprintEndDateTextBox);
            this.groupBox1.Controls.Add(this._sprintTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 85);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sprint";
            // 
            // _copyFileNameButton
            // 
            this._copyFileNameButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._copyFileNameButton.Location = new System.Drawing.Point(10, 236);
            this._copyFileNameButton.Name = "_copyFileNameButton";
            this._copyFileNameButton.Size = new System.Drawing.Size(181, 23);
            this._copyFileNameButton.TabIndex = 10;
            this._copyFileNameButton.Text = "Copy file name";
            this._copyFileNameButton.UseVisualStyleBackColor = true;
            this._copyFileNameButton.Click += new System.EventHandler(this.CopyFileNameButton_Click);
            // 
            // _copyReleasePathButton
            // 
            this._copyReleasePathButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._copyReleasePathButton.Location = new System.Drawing.Point(10, 265);
            this._copyReleasePathButton.Name = "_copyReleasePathButton";
            this._copyReleasePathButton.Size = new System.Drawing.Size(181, 23);
            this._copyReleasePathButton.TabIndex = 11;
            this._copyReleasePathButton.Text = "Copy release path";
            this._copyReleasePathButton.UseVisualStyleBackColor = true;
            this._copyReleasePathButton.Click += new System.EventHandler(this.CopyReleasePathButton_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "© 2024 Moscalu Constantin.";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "All rights reserved.";
            // 
            // _copyBranchNameButton
            // 
            this._copyBranchNameButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._copyBranchNameButton.Location = new System.Drawing.Point(10, 207);
            this._copyBranchNameButton.Name = "_copyBranchNameButton";
            this._copyBranchNameButton.Size = new System.Drawing.Size(181, 23);
            this._copyBranchNameButton.TabIndex = 14;
            this._copyBranchNameButton.Text = "Copy Branch Name";
            this._copyBranchNameButton.UseVisualStyleBackColor = true;
            this._copyBranchNameButton.Click += new System.EventHandler(this.CopyBranchNameButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(204, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // ReleaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 338);
            this.Controls.Add(this._copyBranchNameButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._copyReleasePathButton);
            this.Controls.Add(this._copyFileNameButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._createFileButton);
            this.Controls.Add(this._userStoryType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._userStoryTextBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ReleaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Release Helper";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox _userStoryTextBox;
        private Label label1;
        private Label label2;
        private ComboBox _userStoryType;
        private Button _createFileButton;
        private Label label3;
        private TextBox _sprintTextBox;
        private Label label4;
        private TextBox _sprintEndDateTextBox;
        private GroupBox groupBox1;
        private Button _copyFileNameButton;
        private Button _copyReleasePathButton;
        private Label label5;
        private Label label6;
        private Button _copyBranchNameButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem settingsToolStripMenuItem;
    }
}
