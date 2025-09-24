using System;

namespace Vehicle_Inheritance
{
    public abstract class Vehicle
    {
        private int _wheels;
        private double _weight;

        public Vehicle(int wheels, double weight)
        {
            _wheels = wheels;
            _weight = weight;
        }

        public int Wheels
        {
            get { return _wheels; }
        }

        public double Weight
        {
            get { return _weight; }
        }

        public double WheelLoad()
        {
            return _weight / _wheels;
        }
    }
}