namespace Model
{
    public static class Globals
    {
        public const int SecInHour = 3600;
        public const int MSecInHour = 60;
        private static ushort _dT;
        private static double _clientFlowRate;
        private static float _serveFlowRate;
        public static double clientFlowRate
        {
            get { return _clientFlowRate; }
            set { _clientFlowRate = value / SecInHour; }
        }
        public static float serveFlowRate {
            get { return _serveFlowRate; }
            set { _serveFlowRate = value; }
        }
        public static ushort dT {
            get { return _dT; }
            set { _dT = value; }
        }
        private static int _ratio;
        public static int ratio {
            get { return _ratio; }
            set { _ratio = dT / SecInHour; }
        }
        public static float ClientPerHour {
            get { return serveFlowRate * SecInHour; }
        }
    }
}