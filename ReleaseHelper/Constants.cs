namespace ReleaseHelper
{
    public static class Constants
    {
        public static readonly int FirstSprint = 7;
        public static readonly DateTime FirstSprintEndDate = new(2023, 4, 7);
        public static readonly DateTime FirstSprintStartDate = FirstSprintEndDate.AddDays(-12);
        public static readonly string ReleaseFolderTemplate = "Release {0}_{1}{2}"; //Release 34_19.04.2024_fix
        public static readonly string FileNameTemplate = "{0}_{1}.sql"; //09.04.2024_111413.sql
        public static readonly string DateFormat = "dd.MM.yyyy";
    }
}
