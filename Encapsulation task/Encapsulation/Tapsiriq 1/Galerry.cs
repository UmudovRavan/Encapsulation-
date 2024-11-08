using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Tapsiriq_1
{
    public class Galerry
    {
       public int Id { get; set; }
        public string Name { get; set; }

        public List<Car> Cars { get; set; } = new List<Car>();

        public  void AddCar(Car car)
        {
            Cars.Add(car);
        }

        public void ShowAllCars()
        {
            foreach (var car in Cars)
            {
                Console.WriteLine($"ID: {car.Id},Name: {car.Name}, Speed: {car.Speed}, CarCode: {car.CarCode}");
            }
        }
            
        public List<Car> GetAllCars()
        {
            return Cars;
        }

        public Car FindCarById (int id)
        {
            foreach(var car in Cars)
            {
                if(car.Id == id) 
                    return car;
            }
            return null;
        }

        public Car FindCarByCarCode (string carCode)
        {
            foreach (var car in Cars)
            {
                if(car.CarCode == carCode)
                    return car;
            }
            return null ;
        }

        public List<Car> FindCarsBySpeedInterval(int minSpeed, int maxSpeed)
        {
            List<Car> carIsInInterval = new List<Car>();

            foreach (var car in Cars)
            {
                if(car.Speed >= minSpeed && car.Speed <= maxSpeed)
                {
                    carIsInInterval.Add(car);
                }
            }
            return carIsInInterval;

        }



    }
}
