using System;
namespace AP204Classwork.Models
{
    public class Bus:Car
    {

        public byte PassengerCount;

        public Bus(byte passengercount, string brand, string model, string color, int maxspeed):base(brand,model,color,maxspeed)
        {
            PassengerCount = passengercount;
        }

        public override string AllInfo()
        {
            return $"{base.AllInfo()} PassengerCount: {PassengerCount}";
        }
    }
}
