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
    public static class MessageHandler // Static means we don't have to create an instance of the class - we can just use it :)
    {
        public static async void HandleMessage(SocketMessage message) // We can use MessageHandler.HandleMessage(message) to deal with any incoming messages and handle them here.
        {

            if (message.Content == ".hello")  //If statements are a poor choice for this kind of work - We'll work on making this better in our next session.
            {
                await message.Channel.SendMessageAsync("World!"); //Our original command
            }
            else if (message.Content == ".NewCmd")
            {
                await message.Channel.SendMessageAsync("This is the new command"); // Our new command

            }

            // your mission - Using what you can see - add some more commands and responses.
        }


    }
}
