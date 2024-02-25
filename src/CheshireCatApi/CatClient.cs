using System;
using CheshireCatApi.Api;
using CheshireCatApi.Client;
using WebSocketSharp;
using Newtonsoft.Json;

namespace CheshireCatApi;

public class CatClient
{
    private WebSocket _webSocket;
    private MemoryApi _memoryApi;
    private PluginsApi _pluginsApi;
    private RabbitHoleApi _rabbitHoleApi;
    private StatusApi _statusApi;
    private EmbedderApi _embedderApi;
    private SettingsApi _settingsApi;
    private LargeLanguageModelApi _languageModel;

    private Configuration _configuration;

    public MemoryApi Memory
    {
        get
        {
            if (_memoryApi == null)
            {
                _memoryApi = new MemoryApi(_configuration);
            }
            
            return _memoryApi;
        }
    }

    public PluginsApi Plugins
    {
        get
        {
            if (_pluginsApi == null)
            {
                _pluginsApi = new PluginsApi(_configuration);
            }
            
            return _pluginsApi;
        }
    }

    public RabbitHoleApi RabbitHole
    {
        get
        {
            if (_rabbitHoleApi == null)
            {
                _rabbitHoleApi = new RabbitHoleApi(_configuration);
            }

            return _rabbitHoleApi;
        }
    }

    public StatusApi Status
    {
        get
        {
            if (_statusApi == null)
            {
                _statusApi = new StatusApi(_configuration);
            }

            return _statusApi;
        }
    }

    public EmbedderApi Embedder
    {
        get
        {
            if (_embedderApi == null)
            {
                _embedderApi = new EmbedderApi(_configuration);
            }

            return _embedderApi;
        }
    }

    public SettingsApi Settings
    {
        get
        {
            if (_settingsApi == null)
            {
                _settingsApi = new SettingsApi(_configuration);
            }

            return _settingsApi;
        }
    }

    public LargeLanguageModelApi LanguageModel
    {
        get
        {
            if (_languageModel == null)
            {
                _languageModel = new LargeLanguageModelApi(_configuration);
            }

            return _languageModel;
        }
    }
    
    public ConnectionSettings settings;
    public Action<string> OnMessage { get; set; }
    public Action OnOpen { get; set; }
    public Action OnClose { get; set; }
    public Action OnError { get; set; }

    public CatClient(ConnectionSettings connSettings)
    {
        settings = connSettings;
        string wsProtocol = settings.secureConnection ? "wss" : "ws";
        string httpProtocol = settings.secureConnection ? "https" : "http";
        string baseUrl = $"{settings.baseUrl}:{settings.port}";
        _webSocket = new WebSocket($"{wsProtocol}://{baseUrl}/ws/{settings.userId}");
        _configuration = new Configuration
        {
            BasePath = $"{httpProtocol}://{baseUrl}"
        };

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