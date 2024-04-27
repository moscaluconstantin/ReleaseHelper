using ReleaseHelper.Forms;
using TextCopy;

namespace ReleaseHelper
{
    public partial class ReleaseForm : Form
    {
        private readonly Dictionary<string, string> _folderSufix;
        private readonly Dictionary<string, string> _branchSufix;

        private string UsertStoryId => _userStoryTextBox.Text;
        private string Sprint => _sprintTextBox.Text;
        private string SprintEndDate => _sprintEndDateTextBox.Text;
        private string FileName => string.Format(Constants.FileNameTemplate, DateTime.Now.ToString(Constants.DateFormat), UsertStoryId);
        private string ReleaseFolder => string.Format(Constants.ReleaseFolderTemplate, Sprint, SprintEndDate, GetFolderSuffix());

        public static string ProjectFolder => Properties.Settings.Default.ProjectLocation;
        public static string RepoReleasesPath => Properties.Settings.Default.RepositoryReleasesFolderPath;

        public ReleaseForm()
        {
            InitializeComponent();

            _userStoryTextBox.Text = !string.IsNullOrEmpty(Properties.Settings.Default.LastUserStoryId) ? Properties.Settings.Default.LastUserStoryId : "";
            _sprintTextBox.Text = GetCurrentSprint().ToString();
            _sprintEndDateTextBox.Text = GetCurrentSprintEndDate().ToString(Constants.DateFormat);

            _folderSufix = new Dictionary<string, string>
            {
                ["Feature"] = "",
                ["Bug"] = "_fix"
            };

            _branchSufix = new Dictionary<string, string>
            {
                ["Feature"] = "feature_",
                ["Bug"] = "fix_"
            };

            _userStoryType.Items.Clear();
            _userStoryType.Items.AddRange(_folderSufix.Keys.ToArray());
            _userStoryType.SelectedIndex = 0;
        }

        private static int GetCurrentSprint()
        {
            var daysPassed = (DateTime.Now - Constants.FirstSprintStartDate).TotalDays;
            var sprintsPassed = (int)Math.Floor(daysPassed / 14);
            return Constants.FirstSprint + sprintsPassed;
        }

        private static DateTime GetCurrentSprintEndDate()
        {
            int sprintsPassed = GetCurrentSprint() - Constants.FirstSprint;
            return Constants.FirstSprintEndDate.AddDays(sprintsPassed * 14);
        }

        private string GetFolderSuffix() =>
            _folderSufix[_userStoryType.SelectedItem.ToString()];

        private string GetBranchName() =>
            _branchSufix[_userStoryType.SelectedItem.ToString()] + UsertStoryId;

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            using var settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void CreateFileButton_Click(object sender, EventArgs e)
        {
            var releaseFolderPath = Path.Combine(ProjectFolder, ReleaseFolder);

            if (!Directory.Exists(ProjectFolder))
            {
                MessageBox.Show($"Invalid project path: {ProjectFolder}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Directory.Exists(releaseFolderPath))
                Directory.CreateDirectory(releaseFolderPath);

            string filePath = Path.Combine(releaseFolderPath, FileName);

            if (!File.Exists(filePath))
            {
                var stream = File.Create(filePath);
                stream.Close();
            }

            if (string.IsNullOrEmpty(UsertStoryId))
                return;

            Properties.Settings.Default.LastUserStoryId = UsertStoryId;
            Properties.Settings.Default.Save();
        }

        private void CopyBranchNameButton_Click(object sender, EventArgs e)
        {
            var branchName = GetBranchName();
            ClipboardService.SetText(branchName);
        }

        private void CopyFileNameButton_Click(object sender, EventArgs e)
        {
            var fileName = Path.GetFileNameWithoutExtension(GetMostRecentPath());
            ClipboardService.SetText(fileName);
        }

        private void CopyReleasePathButton_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(RepoReleasesPath, GetMostRecentPath());
            ClipboardService.SetText(path);
        }

        private string GetMostRecentPath()
        {
            var sprintsInfo = Directory.GetFiles(ProjectFolder, $"*{UsertStoryId}.sql", SearchOption.AllDirectories)
                .Select(x => new FileSprintInfo(x))
                .OrderByDescending(x => x.Sprint)
                .ThenByDescending(x => x.Date)
                .FirstOrDefault();

            if (sprintsInfo == null)
                return "";

            var segments = sprintsInfo.FilePath.Split('\\');
            return Path.Combine(segments[^2], segments[^1]);
        }
    }
}
