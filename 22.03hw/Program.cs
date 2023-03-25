using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._03hw
{
   
    class Car
    {
        public string Body { get; set; }
        public string Power { get; set; }
        public string Wheel { get; set; }
        public string Trans { get; set; }
        public Car() { }
        public Car(string body, string power, string wheel, string trans)
        {
            Body = body;          
            Power = power;           
            Wheel = wheel;
            Trans = trans;
        }
        public override string ToString()
        {
            return $"Body: {Body}\nPower: {Power}\nWheel: {Wheel}\nTransmission: {Trans}";
        }
    }
    interface CarBuilder
    {
        void BodyBuild();
        void PowerBuild();
        void WheelBuild();
        void TransBuild();
        Car GetCar();
    }

    class CarBuilder1 : CarBuilder
    {
        private Car car;
      
        public void BodyBuild()
        {
            if (car == null)
            {
                car = new Car();
            }            
            car.Body = "Седан";
        }
        public void PowerBuild()
        {
            if (car == null)
            {
                car = new Car();
            }              
            car.Power = "98 л.с";
        }
        public void WheelBuild()
        {
            if (car == null)
            {
                car = new Car();
            }             
            car.Wheel = "13 R";
        }
        public void TransBuild()
        {
            if (car == null)
            {
                car = new Car();
            }              
            car.Trans = "5 Manual";
        }
        public Car GetCar()
        {
            if (car == null)
            {
                return null;
            }             
            return car;
        }
    }
    class CarBuilder2 : CarBuilder
    {
        private Car car;
        public void BodyBuild()
        {
            if (car == null)
            {
                car = new Car();
            }            
            car.Body = "Купе";
        }
        public void PowerBuild()
        {
            if (car == null)
            {
                car = new Car();
            }               
            car.Power = "160 л.с";
        }
        public void WheelBuild()
        {
            if (car == null)
            {
                car = new Car();
            }             
            car.Wheel = "14 R";
        }
        public void TransBuild()
        {
            if (car == null)
            {
                car = new Car();
            }              
            car.Trans = "4 Auto";
        }
        public Car GetCar()
        {
            if (car == null)
            {
                return null;
            }              
            return car;
        }
    }
    class CarBuilder3 : CarBuilder
    {
        private Car car;
        public void BodyBuild()
        {
            if (car == null)
            {
                car = new Car();
            }              
            car.Body = "Универсал";
        }
        public void PowerBuild()
        {
            if (car == null)
            {
                car = new Car();
            }
              
            car.Power = "120 л.с";
        }
        public void WheelBuild()
        {
            if (car == null)
            {
                car = new Car();
            }
            car.Wheel = "16 R";
        }
        public void TransBuild()
        {
            if (car == null)
            {
                car = new Car();
            }             
            car.Trans = "4 Manual";
        }
        public Car GetCar()
        {
            if (car == null)
            {
                return null;
            }              
            return car;
        }
    }
    class CarBuilder4 : CarBuilder
    {
        private Car car;
        public void BodyBuild()
        {
            if (car == null)
            {
               car = new Car();
            }              
            car.Body = "Хетчбэк";
        }
        public void PowerBuild()
        {
            if (car == null)
            {
                car = new Car();
            }              
            car.Power = "66 л.с";
        }
        public void WheelBuild()
        {
            if (car == null)
            {
                car = new Car();
            }
            car.Wheel = "13 R";
        }
        public void TransBuild()
        {
            if (car == null)
            {
                car = new Car();
            }               
            car.Trans = "4 auto";
        }
        public Car GetCar()
        {
            if (car == null)
            {
                return null;
            }             
            return car;
        }
    }

    class Shop
    {
        private CarBuilder car;
        public void Car()
        {
            Console.WriteLine("Enter num 1-4: \n");
            int choose = Convert.ToInt32(Console.ReadLine());
            if (choose == 1)
            {
                Console.WriteLine("\nDaewoo Lanos");
                car = new CarBuilder1();
            }             
            if (choose == 2)
            {
                Console.WriteLine("\nFord Probe");
                car = new CarBuilder2();
            }               
            if (choose == 3)
            {
                Console.WriteLine("\nUA* Patriot");
                car = new CarBuilder3();
            }               
            if (choose == 4)
            {
                Console.WriteLine("\nHyundai Getz");
                car = new CarBuilder4();
            }
            else
            {
                car = null;
            }              
        }
        public void BuildCar()
        {
            if (car == null)
            {
                car = new CarBuilder1();
            }              
            car.BodyBuild();
            car.TransBuild();
            car.PowerBuild();
            car.WheelBuild();
        }
        public CarBuilder GetCar()
        {
            return car;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop();
            shop.Car();
            shop.BuildCar();
            var build = shop.GetCar();
            Car car = build.GetCar();
            Console.WriteLine(car);
        }
    }
}
