using System;

namespace Primeiro.Helpers
{
    class FunctionsHelper
    {
        public static string getFromConsole(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
    }
}
