```
class SingletonUsuarios
{
    private static SingletonUsuarios _instance;
    private Common[] users = [];

    public static SingletonUsuarios Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new SingletonUsuarios();
            }
            return _instance;
        }
    }

    public void setUser(Common user_common)
    {
        users = users.Append(user_common).ToArray();
    }

    public Common[] getUsers()
    {
        return users;
    }
}


class Common
{
    public String name = "";
    public String lastname = "";
    public int old = 0;
}
```