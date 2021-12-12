using System;

namespace Model
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            
        }
    }
    void setModelParams(bool paramsStatement) {
        if (paramsStatement == true) {
            Globals.clientFlowRate = Console.ReadLine();
            Globals.dT = Console.ReadLine();
            Globals.serveFlowRate = Console.ReadLine();
            Globals.ratio = Console.ReadLine();
        }
        else
        {
            Globals.dT = 5;
            Globals.clientFlowRate = 5/Globals.SecInHour;
            Globals.serveFlowRate = 1;
            Globals.ratio = Globals.dT / Globals.SecInHour;
            public int channelsCount = 0;
        }
        }
    }
}