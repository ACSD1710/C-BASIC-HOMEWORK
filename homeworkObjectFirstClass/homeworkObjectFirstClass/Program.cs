using homeworkObjectFirstClass.Models;
using System;

namespace homeworkObjectFirstClass
{
    class Program
    {
        static Car FindCar(string model, Car[] cars)
        {
           foreach (Car car in cars)
            {
                if(car.Model.ToLower() == model.ToLower())
                {
                    return car;
                }
            }

            return null;
        }

        static Driver FindDriver(string model, Driver[] cars)
        {
            foreach (Driver car in cars)
            {
                if (car.Name.ToLower() == model.ToLower())
                {
                    return car;
                }
            }

            return null;
        }

        static double CalculateSpeed( Driver driver, Car car)
        {

            double result = driver.Skill * car.Speed;
            return result;

        }
        static void RaceCars(double car, double car1)
        {
            if(car > car1)
            {
                Console.WriteLine($" Car No.1 is faster !!!");
            }else if (car < car1)
            {
                Console.WriteLine($"Car No.2 is faster !!!");
            }
            else
            {
                Console.WriteLine($"Car No.1  and car No.2 are with same speed !!!");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Home Work");

            Driver[] drivers = new Driver[]
            {
                new Driver("Darko", 2),
                new Driver("Marko", 3),
                new Driver("Zarko", 4),
                new Driver("Trajko", 5)
            };

            Car[] cars = new Car[]
            {
                new Car("Cadillac", 180 ),
                new Car("Lincoln", 170.7),
                new Car("Dodge", 190),
                new Car("Chrysler", 160)

            };
           

            Console.WriteLine("Please chose the first type of car\n 1) Cadillac\n 2) Lincoln\n 3) Dodge\n 4) Chrysler ");
            Car carFirst = FindCar(Console.ReadLine(), cars);

            Console.WriteLine("Please chose the first driver:\n 1) Darko\n 2) Marko\n 3) Zarko\n 4) Trajko ");
            Driver driverFirst = FindDriver(Console.ReadLine(), drivers);

            Console.WriteLine("Please chose the second type of car\n 1) Cadillac\n 2) Lincoln\n 3) Dodge\n 4) Chrysler ");
            Car carSecond = FindCar(Console.ReadLine(), cars);

            Console.WriteLine("Please chose the second driver:\n 1) Darko\n 2) Marko\n 3) Zarko\n 4) Trajko ");
            Driver driverSecond = FindDriver(Console.ReadLine(), drivers);

            double firstCarSpeed = CalculateSpeed(driverFirst, carFirst);

            double secondCarSpeed = CalculateSpeed(driverSecond, carSecond);

            RaceCars(firstCarSpeed, secondCarSpeed);



            Console.ReadLine();
        }

       

        
    }
}
