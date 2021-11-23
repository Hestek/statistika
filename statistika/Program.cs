using System;

namespace statistika
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyInfo;
            string povoleneznaky = "0123456789";

            do
            {
                keyInfo = Console.ReadKey(true);
                if (povoleneznaky.Contains(keyInfo.KeyChar))
                {
                    //zde se program dostane při stisku čísla
                }
                else if (keyInfo.Key == ConsoleKey.Enter)
                {

                }
                else if (keyInfo.Key == ConsoleKey.Backspace)
                {

                }
            } while (keyInfo.Key != ConsoleKey.Escape);
        }
    }
}
