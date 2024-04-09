namespace LogGenerator.Helpers;
public static class ConsoleHelper
{
    public static void ShowInfo(string data, string title = "Sended", ConsoleColor color = ConsoleColor.Yellow)
    {
        Console.ForegroundColor = color;
        Console.Write($"{title} - [{DateTime.Now}]: ");
        Console.ResetColor();
        Console.Write(data);
        Console.WriteLine();
    }
}
