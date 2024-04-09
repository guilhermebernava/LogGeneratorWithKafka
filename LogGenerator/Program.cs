using LogGenerator;
using LogGenerator.Helpers;
using Microsoft.Extensions.Configuration;

ConsoleHelper.ShowInfo("Start Running", title: "INFO", color: ConsoleColor.DarkGreen);
var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();

var producer = new Producer(configuration);
for (int i = 0; i < 10; i++)
{
   await producer.SendAsync(TextGenerator.GenerateRandomText());
}

ConsoleHelper.ShowInfo("Finished", title: "INFO", color: ConsoleColor.DarkGreen);
Console.ReadLine(); 
