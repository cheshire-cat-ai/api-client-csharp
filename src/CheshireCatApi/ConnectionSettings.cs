namespace CheshireCatApi;

public struct ConnectionSettings
{
    public string baseUrl;
    public int port;
    public string userId;
    public string auth_key;
    public bool secureConnection;

    public ConnectionSettings()
    {
        baseUrl = "localhost";
        port = 1865;
        userId = "user";
        auth_key = "";
        secureConnection = false;
    }
}