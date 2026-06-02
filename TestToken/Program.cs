using System;
using NetCord;

class Program
{
    static void Main()
    {
        try
        {
            var token = new BotToken("");
            Console.WriteLine("Token is valid!");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
