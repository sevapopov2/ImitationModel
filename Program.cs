using System;

namespace Model
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDateTime = DateTime.Now;
            Globals.dT = 5;
            Globals.clientFlowRate = 5/3600;
            Globals.serveFlowRate = 1;
            Globals.ratio = currentDateTime / Globals.dT;
            int channelsCount = 4;
             var symbol = Console.ReadKey();
            if (symbol == "q") {
                Environment.Exit(0);
            }
            if (symbol == ConsoleKeyInfo()) {
                channelsCount = channelsCount +1;
                Console.WriteLine("The channels count is set to", channelsCount);
            }
        }

    }
}
