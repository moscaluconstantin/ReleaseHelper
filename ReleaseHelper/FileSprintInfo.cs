namespace ReleaseHelper
{
    public class FileSprintInfo
    {
        public int Sprint { get; set; }
        public DateTime Date { get; set; }
        public string FilePath { get; set; }

        public FileSprintInfo(string filePath)
        {
            FilePath = filePath;

            var segments = filePath.Split('\\');

            if (segments.Length < 2)
                return;

            Sprint = GetSprint(segments[^2]);
            Date = GetDate(segments[^1]);
        }

        private int GetSprint(string text)
        {
            Sprint = 0;

            int start = text.IndexOf(' ');
            int end = text.IndexOf('_');

            if (start != -1 && end != -1 && int.TryParse(text.AsSpan(start + 1, end - start - 1), out int sprint))
                return sprint;

            return 0;
        }


        private DateTime GetDate(string text)
        {
            int end = text.IndexOf('_');

            if (end > 0 && DateTime.TryParseExact(text.AsSpan(0, end), Constants.DateFormat, null, System.Globalization.DateTimeStyles.None, out var result))
                return result;

            return new DateTime();
        }
    }
}
