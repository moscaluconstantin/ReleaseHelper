namespace ReleaseHelper.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            _folderPathTextBox.Text = Properties.Settings.Default.ProjectLocation;
            _repoPathTextBox.Text = Properties.Settings.Default.RepositoryReleasesFolderPath;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(_folderPathTextBox.Text) || !Directory.Exists(_folderPathTextBox.Text))
            {
                ShowError("Invalid Releases Folder Path.");
                return;
            }

            if (string.IsNullOrEmpty(_repoPathTextBox.Text))
            {
                ShowError("Invalid Repo Releases Path.");
                return;
            }

            Properties.Settings.Default.ProjectLocation = _folderPathTextBox.Text;
            Properties.Settings.Default.RepositoryReleasesFolderPath = _repoPathTextBox.Text;
            Close();
        }

        private static void ShowError(string message) => 
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
