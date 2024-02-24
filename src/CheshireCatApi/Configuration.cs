namespace CheshireCatApi;

public struct Configuration
{
    public string baseUrl;
    public int port;
    public string userId;
    public string auth_key;
    public bool secureConnection;

    public Configuration()
    {
        baseUrl = "localhost";
        port = 1865;
        userId = "user";
        auth_key = "";
        secureConnection = false;
    }
}