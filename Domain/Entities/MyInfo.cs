namespace AboutMe.Domain.Entities
{
    public class MyInfo
    {
        public string Info { get; set; }

        public MyInfo(string info)
        {
            if (string.IsNullOrEmpty(info))
            {
                throw new ArgumentException("Info must not be null or empty.");
            }

            Info = info;
        }
    }
}