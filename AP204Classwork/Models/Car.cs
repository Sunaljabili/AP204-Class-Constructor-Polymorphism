using System;
namespace AP204Classwork.Models
{
    public class Car
    {

        public string Brand;
        public string Model;
        public string Color;
        public int MaxSpeed;

        public Car()
        {
            Console.WriteLine("Car Created");
        }

        public Car(string brand, string model)
        {
            Brand = brand;
            Model = model;

        }
        public Car(string brand, string model,string color,int maxspeed):this(brand,model)
        {
            Color = color;
            MaxSpeed = maxspeed;
        }

        public  virtual string AllInfo()
        {
            return $"Brand : {Brand} |  Model: {Model} | Color: {Color} | MaxSpeed:{MaxSpeed}";
        }
    }
}
