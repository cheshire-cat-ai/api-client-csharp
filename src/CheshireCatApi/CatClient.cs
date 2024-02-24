using System;
using WebSocketSharp;
using Newtonsoft.Json;

namespace CheshireCatApi;

public class CatClient
{
    private WebSocket _webSocket;

    public Configuration websocketConfig;
    public Action<string> OnMessage { get; set; }
    public Action OnOpen { get; set; }
    public Action OnClose { get; set; }
    public Action OnError { get; set; }
    
    public CatClient()
        : this(new Configuration())
    {
    }

    public CatClient(Configuration connConfiguration)
    {
        websocketConfig = connConfiguration;
        string protocol = websocketConfig.secureConnection ? "wss" : "ws";
        Console.WriteLine(protocol);
        _webSocket = new WebSocket($"ws://{websocketConfig.baseUrl}:{websocketConfig.port}/ws/{websocketConfig.userId}");
        
        _webSocket.OnMessage += (sender, e) =>
        {
            OnMessage?.Invoke(e.Data);
        };

        _webSocket.OnOpen += (sender, e) =>
        {
            OnOpen?.Invoke();
        };

        _webSocket.OnClose += (sender, e) =>
        {
            OnClose?.Invoke();
        };

        _webSocket.OnError += (sender, e) =>
        {
            OnError?.Invoke();
        };
    }
    
    public void ConnectWebsocket()
    {
        _webSocket.Connect();
    }

    public void DisconnectWebSocket()
    {
        _webSocket.Close();
    }
    
    public void SendMessage(string text)
    {
        Message message = new Message { text = text };
        string jsonMessage = JsonConvert.SerializeObject(message);
        _webSocket.Send(jsonMessage);
    }
}