using System;

namespace statistika
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyInfo;

            while (true)
            {
                keyInfo = Console.ReadKey(true);
                Console.WriteLine(keyInfo.Key.ToString());

            }
        }
    }
}
