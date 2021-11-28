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
        }
    }
}
