namespace ReleaseHelper
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
            _userStoryTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            _userStoryType = new ComboBox();
            _createFileButton = new Button();
            label3 = new Label();
            _sprintTextBox = new TextBox();
            label4 = new Label();
            _sprintEndDateTextBox = new TextBox();
            groupBox1 = new GroupBox();
            _copyFileNameButton = new Button();
            _copyReleasePathButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // _userStoryTextBox
            // 
            _userStoryTextBox.Location = new Point(91, 12);
            _userStoryTextBox.Name = "_userStoryTextBox";
            _userStoryTextBox.PlaceholderText = "123465";
            _userStoryTextBox.Size = new Size(100, 23);
            _userStoryTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 1;
            label1.Text = "User Story Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 2;
            label2.Text = "User Story Type";
            // 
            // _userStoryType
            // 
            _userStoryType.FormattingEnabled = true;
            _userStoryType.Items.AddRange(new object[] { "Feature", "Bug" });
            _userStoryType.Location = new Point(105, 41);
            _userStoryType.Name = "_userStoryType";
            _userStoryType.Size = new Size(86, 23);
            _userStoryType.TabIndex = 3;
            // 
            // _createFileButton
            // 
            _createFileButton.Location = new Point(10, 161);
            _createFileButton.Name = "_createFileButton";
            _createFileButton.Size = new Size(181, 23);
            _createFileButton.TabIndex = 4;
            _createFileButton.Text = "Create File";
            _createFileButton.UseVisualStyleBackColor = true;
            _createFileButton.Click += CreateFileButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 24);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 6;
            label3.Text = "Name";
            // 
            // _sprintTextBox
            // 
            _sprintTextBox.Location = new Point(71, 21);
            _sprintTextBox.Name = "_sprintTextBox";
            _sprintTextBox.PlaceholderText = "21";
            _sprintTextBox.ReadOnly = true;
            _sprintTextBox.Size = new Size(102, 23);
            _sprintTextBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 53);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 8;
            label4.Text = "End Date";
            // 
            // _sprintEndDateTextBox
            // 
            _sprintEndDateTextBox.Location = new Point(71, 50);
            _sprintEndDateTextBox.Name = "_sprintEndDateTextBox";
            _sprintEndDateTextBox.PlaceholderText = "04.06.2023";
            _sprintEndDateTextBox.ReadOnly = true;
            _sprintEndDateTextBox.Size = new Size(102, 23);
            _sprintEndDateTextBox.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(_sprintEndDateTextBox);
            groupBox1.Controls.Add(_sprintTextBox);
            groupBox1.Location = new Point(12, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(179, 85);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sprint";
            // 
            // _copyFileNameButton
            // 
            _copyFileNameButton.Location = new Point(10, 190);
            _copyFileNameButton.Name = "_copyFileNameButton";
            _copyFileNameButton.Size = new Size(181, 23);
            _copyFileNameButton.TabIndex = 10;
            _copyFileNameButton.Text = "Copy file name";
            _copyFileNameButton.UseVisualStyleBackColor = true;
            _copyFileNameButton.Click += CopyFileNameButton_Click;
            // 
            // _copyReleasePathButton
            // 
            _copyReleasePathButton.Location = new Point(10, 219);
            _copyReleasePathButton.Name = "_copyReleasePathButton";
            _copyReleasePathButton.Size = new Size(181, 23);
            _copyReleasePathButton.TabIndex = 11;
            _copyReleasePathButton.Text = "Copy release path";
            _copyReleasePathButton.UseVisualStyleBackColor = true;
            _copyReleasePathButton.Click += CopyReleasePathButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(204, 256);
            Controls.Add(_copyReleasePathButton);
            Controls.Add(_copyFileNameButton);
            Controls.Add(groupBox1);
            Controls.Add(_createFileButton);
            Controls.Add(_userStoryType);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(_userStoryTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Release Helper";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
    }
}
