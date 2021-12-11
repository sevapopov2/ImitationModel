namespace Model
{
    public static class Globals
    {
        public const int SecInHour = 3600;
        private static int clientPerHour;
        private static double _clientFlowRate;
        public static double clientFlowRate
        {
            get { return _clientFlowRate; }
            set { _clientFlowRate = value / SecInHour; }
        }
        private static float _serveFlowRate;
        public static float serveFlowRate {
            get { return _serveFlowRate; }
            set { _serveFlowRate = value; }
        }
        private static int _dT;
        public static int dT {
            get { return _dT; }
            set { _dT = value; }
        }
        private static int _ratio;
        public static int ratio {
            get { return _ratio; }
            set { _ratio = dT / SecInHour; }
        }
    }
}