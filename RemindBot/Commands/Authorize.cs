using DataLayer;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace RemindBot.Commands
{
    internal class Authorize : Command
    {
        public override string Name => "/ping";

        public override async Task Execute(Message message, TelegramBotClient client)
        {
            bool userExist = false;

            using (Connection connection = new Connection())
            {
                DataLayer.Models.User user = await connection.Context.GetUser(message.From.Id);
                if (user != null) { userExist = true; }
            }

            if (userExist)
            {
                await client.SendTextMessageAsync(message.From.Id, "Hello my lord, what can I do for you?");
            }
            else
            {
                await client.SendTextMessageAsync(message.From.Id, "Sorry, can not find you in my address book.");
            }

        }


    }
}
