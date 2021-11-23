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
                if (povoleneznaky.Contains(keyInfo.KeyChar));
                {

                }
            } while (keyInfo.Key != ConsoleKey.Escape);
        }
    }
}
