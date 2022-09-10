using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCSharp_1
{
    class Car
    {
        private String markOfCar;
        private String modelOfCar;
        private String colorOfCar;

        public Car(String markOfCar,String modelOfCar,String colorOfCar)
        {
            this.markOfCar = markOfCar;
            this.modelOfCar = modelOfCar;
            this.colorOfCar = colorOfCar;
        }

        public override string ToString()
        {
            return "Mark of car: " + this.markOfCar + " | Model of car: " + this.modelOfCar + " | Color of car: " + this.colorOfCar;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            Car car1 = new Car("BMW","M5","Black");
            Car car2 = new Car("Skoda","A7","Yellow");
            Car car3 = new Car("Ford","Mustang","White");
            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);
            for(int i = 0; i < cars.Count; i++)
            {
                Car car;
                if (cars[i] == null)
                {
                    break;
                }
                car = cars[i];
                if (cars.Contains(car))
                {
                    Console.WriteLine(car.ToString());
                }
            }
        }
    }

}
