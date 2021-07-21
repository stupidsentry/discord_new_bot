using System;
using Discord;
using Discord.Net;
using Discord.Commands;
using Discord.WebSocket;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;


namespace testboy
{
    public static class MessageHandler
    {
        public static async void HandleMessage(SocketMessage message)
        {

            if (message.Content == ".hello")
            {
                await message.Channel.SendMessageAsync("World!");
            }
            else if (message.Content == ".NewCmd")
            {
                await message.Channel.SendMessageAsync("This is the new command");

            }
        }


    }
}
