internal class User
{
    public string NameUser;
    public int Score;

    private static User _instance;

    public static User Instance
    {
        get { return _instance; }
        set { _instance = value; }
    }
    public User()
    {

    }
    public User(string NameUser)
    {
        this.NameUser = NameUser;
        Score = 000;
        Instance = this;
    }

    public int AdicionarPontos()
    {
        this.Score = 001;
        return Score;
    }
}