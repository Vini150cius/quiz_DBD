public class User
{
    private static User _instance;
    private static readonly object _lock = new object();

    public string NameUser { get; set; }
    public int Score { get; set; }

    private User() { }

    public static User Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new User();
                }
                return _instance;
            }
        }
    }
}