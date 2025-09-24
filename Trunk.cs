using System;

namespace Vehicle_Inheritance
{
    public class Trunk : Vehicle
    {
        private double _payload;
        public Trunk(int wheels, double weight, double payload) : base(wheels, weight)
        {
            _payload = payload;
        }

        public double Payload
        {
            set { _payload = value; }
            get { return _payload; }
        }

        public double Efficiency()
        {
            return _payload / (_payload + Weight);
        }
    }
}