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
                    car.IsChosen = true;
                    return car;
                }
            }

            return null;
        }

        static Driver FindDriver(string model, Driver[] drivers)
        {
            foreach (Driver driver in drivers)
            {
                if (driver.Name.ToLower() == model.ToLower())
                {
                    driver.IsChose = true;
                    return driver;
                }
            }

            return null;
        }

        static double CalculateSpeed( Driver driver, Car car)
        {
            
            return (driver.Skill * car.Speed);
             

        }
        static double RaceCars(double firstCar, double secondCar)
        {
            if(firstCar > secondCar)
            {
                return firstCar;
            }else if (firstCar < secondCar)
            {
                return secondCar;
            }
            else
            {
                return 0;
            }
        }
        static void CarChose(Car[] cars)
        {
            Console.WriteLine("Please chose the type of car: ");
            foreach (Car car in cars)
            {

                if (car.IsChosen == false)
                {
                  Console.WriteLine(car.Model);
                }
            }
          
        }
        static void DriverChose(Driver[] drivers)
        {
            Console.WriteLine("Please chose the Driver of car: ");
            foreach (Driver driver in drivers)
            {

                if (driver.IsChose == false)
                {
                    Console.WriteLine(driver.Name);
                }
            }

        }

        static void lastMassage(Car carFirst, Driver driverFirst, Car carSecond, Driver driverSecond, double raceResult)
        {
            if(carFirst.Speed * driverFirst.Skill > carSecond.Speed * driverSecond.Skill)
            {
                Console.WriteLine($"In this race won car model {carFirst.Model}\n with speed reached speed of {carFirst.Speed} km/h the driver was be {driverFirst.Name} , with all point of speed {raceResult}");
            }
            if (carFirst.Speed* driverFirst.Skill < carSecond.Speed * driverSecond.Skill)
            {
                Console.WriteLine($"In this race won car model {carSecond.Model}\n with speed reached speed of {carSecond.Speed} km/h the driver was be {driverSecond.Name}, with all point of speed {raceResult}");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("================================");
            Console.WriteLine("================================");
            Console.WriteLine("Angel te molam iskreno kazimi ima nadez ili ne :D i dali sum najtrup od grupive???\niskreno 3 saati sigurno se vrtev probuvav dure da gi resam bonusive\ni znaam deka ima uste mnogu validacii za iminjata... ama toa ne se barase :D :D :D  ");
            Console.WriteLine("================================");
            Console.WriteLine("================================");
            Driver[] drivers = new Driver[]
            {
                new Driver("Darko", 2, false),
                new Driver("Marko", 3, false),
                new Driver("Zarko", 4, false),
                new Driver("Trajko", 5, false)
            };

            Car[] cars = new Car[]
            {
                new Car("Cadillac", 180, false ),
                new Car("Lincoln", 170.7, false),
                new Car("Dodge", 190, false),
                new Car("Chrysler", 160, false)

            };



            CarChose(cars);
            Car carFirst = FindCar(Console.ReadLine(), cars);
            Console.WriteLine("================================");

            DriverChose(drivers);
            Driver driverFirst = FindDriver(Console.ReadLine(), drivers);
            Console.WriteLine("================================");

            CarChose(cars);

            Car carSecond = FindCar(Console.ReadLine(), cars);
            Console.WriteLine("================================");

            DriverChose(drivers);

            Driver driverSecond = FindDriver(Console.ReadLine(), drivers);
            Console.WriteLine("================================");
            double firstCarSpeed = CalculateSpeed(driverFirst, carFirst);
            Console.WriteLine("================================");

            double secondCarSpeed = CalculateSpeed(driverSecond, carSecond);
            Console.WriteLine("================================");

            double raceResult = RaceCars(firstCarSpeed, secondCarSpeed);
            Console.WriteLine("================================");

            lastMassage(carFirst, driverFirst, carSecond, driverSecond, raceResult);
            Console.WriteLine("================================");

            foreach (Driver driver in drivers)
            {
                driver.IsChose = false;
            }
            foreach (Car car in cars)
            {
                car.IsChosen = false;
            }

            Console.WriteLine("Do you want another race : YES or NO");
            Console.WriteLine("================================");
            string answer1 = Console.ReadLine().ToLower();
            while (answer1.Contains("yes") == true)

            {
                CarChose(cars);
                Car carFirst1 = FindCar(Console.ReadLine(), cars);
                Console.WriteLine("================================");

                DriverChose(drivers);
                Driver driverFirst1 = FindDriver(Console.ReadLine(), drivers);
                Console.WriteLine("================================");

                CarChose(cars);
                Car carSecond1 = FindCar(Console.ReadLine(), cars);
                Console.WriteLine("================================");
                
                DriverChose(drivers);
                Console.WriteLine("================================");

                Driver driverSecond1 = FindDriver(Console.ReadLine(), drivers);
                Console.WriteLine("================================");

                double firstCarSpeed1 = CalculateSpeed(driverFirst1, carFirst1);
                Console.WriteLine("================================");

                double secondCarSpeed1 = CalculateSpeed(driverSecond1, carSecond1);
                Console.WriteLine("================================");

                double raceResult1 = RaceCars(firstCarSpeed1, secondCarSpeed1);
                Console.WriteLine("================================");

                lastMassage(carFirst1, driverFirst1, carSecond1, driverSecond1, raceResult1);
                Console.WriteLine("================================");
                foreach (Driver driver in drivers)
                {
                    driver.IsChose = false;
                }
                foreach (Car car in cars)
                {
                    car.IsChosen = false;
                }
                Console.WriteLine(" Would you do like another race : yes or no");
                answer1 = Console.ReadLine().ToLower();
            }

            Console.WriteLine("Thank you for using this race program");



            Console.ReadLine();






        }

      
    }
}
