namespace OOP.Classes
{
    public static class Helper
    {
        public static int Counter { get; set; } = 0;

        public static void AutoId()
        {
            Counter++;
        }

        public static string DatetimeFormat(this DateTime dateTime)
        {
            return dateTime.ToString("dd/MM/yyyy");
        }
    }
}
