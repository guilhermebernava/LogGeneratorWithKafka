using System.Text;

namespace LogGenerator.Helpers;
public static class TextGenerator
{
    public static string GenerateRandomText(int lenght = 150)
    {
        Random random = new Random();
        const string permitedChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        StringBuilder text = new StringBuilder(lenght);

        for (int i = 0; i < lenght; i++)
        {
            char caractere = permitedChars[random.Next(permitedChars.Length)];
            text.Append(caractere);
        }

        return text.ToString();
    }
}
