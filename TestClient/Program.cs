using System;
using CheshireCatApi;

namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the WebSocket client
            Configuration config = new Configuration();
            CatClient client = new CatClient(config);

            // Set up event handlers
            client.OnMessage += (message) =>
            {
                Console.WriteLine("Received message: " + message);
            };

            client.OnOpen += () =>
            {
                Console.WriteLine("Connected to WebSocket server.");
            };

            client.OnClose += () =>
            {
                Console.WriteLine("Disconnected from WebSocket server.");
            };

            // Connect to the WebSocket server
            client.ConnectWebsocket();

            // Send a message
            client.SendMessage("Hello, WebSocket!");

            // Keep the console application running until a key is pressed
            Console.ReadKey();
        }
    }
}
