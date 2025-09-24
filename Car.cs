using System;

namespace Vehicle_Inheritance
{
    public class Car : Vehicle
    {
        private int _passengerLoad;

        public Car(int wheels, double weight) : base(wheels, weight)
        {
            _passengerLoad = 4;
        }

        public int PassengerLoad
        {
            get{ return _passengerLoad; }
        }
    }
}