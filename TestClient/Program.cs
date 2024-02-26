using System;
using CheshireCatApi;
using CheshireCatApi.Model;

namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the WebSocket client
            ConnectionSettings config = new ConnectionSettings();
            CatClient client = new CatClient(config);
            
            client.OnOpen += () =>
            {
                Console.WriteLine("Connected to WebSocket server.");
            };

            client.OnClose += () =>
            {
                Console.WriteLine("Disconnected from WebSocket server.");
            };

            client.OnMessage += (string message) =>
            {
                Console.WriteLine(message);
            };

            // Connect to the WebSocket server
            client.ConnectWebsocket();
            client.SendMessage("ueeeilaaa");
            string userName = Console.ReadLine();
            client.SendMessage(userName);
            Console.ReadKey();
        }
    }
}
