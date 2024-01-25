using System;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;

namespace TuBotDiscord
{
    class Program
    {
        private DiscordSocketClient _client;

        static void Main(string[] args) => new Program().MainAsync().GetAwaiter().GetResult();

        public async Task MainAsync()
        {
            _client = new DiscordSocketClient();

            _client.Log += Log;

            var token = "MTE5OTg2MzAxNTM5NTI5OTQyOA.G_M1W6.4mWLK3azVjLlzucwGrcoj5UpBAKN-15vUWhD8Y"; // Reemplaza esto con tu token de bot

            await _client.LoginAsync(TokenType.Bot, token);
            await _client.StartAsync();

            // Bloquea este programa hasta que se cierre.
            await Task.Delay(-1);
        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }
    }
}
