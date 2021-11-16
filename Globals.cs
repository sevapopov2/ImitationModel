namespace Model
{
    public static class Globals
    {
        private int SecInHour;
        private int clientPerHour;
        private double _clientFlowRate;
        public double clientFlowRate
        {
            get { return _clientFlowRate; }
            set { _clientFlowRate = value / SecInHour; }
        }
        private float _serveFlowRate;
        public float serveFlowRate {
            get { return _serveFlowRate; }
            set { _serveFlowRate = value }
        }
        private int _dT;
        public int dT {
            get { return _dT; }
            set { _dT = value; }
        }
        private int _ratio;
        public int ratio {
            get { return _ratio; }
            set { _ratio = dT / SecInHour }
        }
    }
}