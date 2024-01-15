using DataLayer;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace RemindBot.Commands
{
    internal class Start : Command
    {
        public override string Name => "/start";

        public override async Task Execute(Message message, TelegramBotClient client)
        {
            using (Connection connection = new Connection())
            {
                DataLayer.Models.User user = await connection.Context.GetUser(message.From.Id);
                await client.SendTextMessageAsync(message.From.Id, "Hello!");
            }
        }


    }
}
