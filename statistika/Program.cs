using System;

namespace statistika
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyInfo;
            string povoleneznaky = "0123456789";
            string text = "";
            int soucet = 0;
            int pocet = 0;
            do
            {
                keyInfo = Console.ReadKey(true);
                if (povoleneznaky.Contains(keyInfo.KeyChar))
                {
                    //zde se program dostane při stisku čísla
                    text += keyInfo.KeyChar; /// text = text + keyInfo.KeyChar;
                    Console.WriteLine(keyInfo.KeyChar);
                }
                else if (keyInfo.Key == ConsoleKey.Enter)
                {
                    if (text != "")
                    {
                        soucet += int.Parse(text);
                        text = "";
                    }
                    Console.WriteLine();
                    text = "";
                }
                else if (keyInfo.Key == ConsoleKey.Backspace && text.Length > 0)
                {
                    Console.Write("\b \b");
                    text = text.Substring(0, text.Length - 1);

                }
            } while (keyInfo.Key != ConsoleKey.Escape);
            int konec = (pocet \ soucet);
            Console.WriteLine($"{konec}");
        }
    }
}
