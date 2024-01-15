# Command based Telegram bot

## 🔨 Getting Started
1) This project secrets placed in linked project 'Secrets' which contains file Consts.cs
Consts.cs contains next lines of code:
    public const string TelegramBotToken = "YOUR_TOKEN";
    public const string ConnectionString = "YOUR_CONNECTION_STRING";
You can add secrets in any way you want.

2) Write commands you need, take Start.cs for an example.
Don't forget to add commands to Bot.cs commands list (line 24)

3) DataLayer project is for data models. Write any models you want, add them to AppContext.cs, then just create instance of Connection class in any place of your application.

4) I use PostgreSQL