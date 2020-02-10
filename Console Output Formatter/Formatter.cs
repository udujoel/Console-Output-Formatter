using System;

namespace Console_Output_Formatter
{
    public class Formatter
    {
        public static void ColoredMessage(string msg, ConsoleColor color = ConsoleColor.DarkMagenta)
        {


            CenterOutput(msg);
            Console.ForegroundColor = color;
            Console.WriteLine(msg);
            Console.ResetColor();
            CenterOutput();
        }

        public static void CenterOutput(string textToDisplay = "")
        {
            Console.SetCursorPosition((Console.WindowWidth - textToDisplay.Length) / 2, Console.CursorTop);
        }
    }
}
