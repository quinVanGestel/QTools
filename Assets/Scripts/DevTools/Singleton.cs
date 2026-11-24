public sealed class Singleton<T> where T : class, new()
{
    private static T instance = null;
    private static readonly object padlock = new();

    public static T Instance
    {
        get
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new();
                }
                return instance;
            }
        }
    }
}
