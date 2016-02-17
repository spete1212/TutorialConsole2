using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            // String Tutorial  Make a change   
            //string myString = "Go to your c:\\ drive";
            //string myString = "My \"so called\" life";
            //string myString = "What if I need \n a new line?";

            //string myString = string.Format("{0}!", "Bonzai");

            //string myString = string.Format("Make:{0} (Model: {1})", "BMW", "760li");

            //string myString = string.Format("{0:C}", 123.45);
            // commas and decimal points - :N, percentage - :P

            //string myString = string.Format("Phone number: {0:(###) ###-####}", 1234567890);

            //string myString = "";
            //for (int i = 0; i < 100; i++)
            //{
            //    //myString = myString + "--" + i.ToString();
            //    myString += "--" + i.ToString();
            //}
            // inefficient, must reallocate memory for string each time

            //StringBuilder myString = new StringBuilder();

            //for (int i = 0; i < 100; i++)
            //{
            //    myString.Append("--");
            //    myString.Append(i);
            //}

            //Console.WriteLine(myString.ToString());

            //DateTime myValue = DateTime.Now;

            //Console.WriteLine(myValue.ToString());
            //Console.WriteLine(myValue.ToShortDateString());
            //Console.WriteLine(myValue.ToShortTimeString());
            //Console.WriteLine(myValue.ToLongDateString());
            //Console.WriteLine(myValue.ToLongTimeString());

            //DateTime myBirthday = DateTime.Parse("3/5/1970");
            //TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            //Console.WriteLine(myAge.TotalDays);

            //Console.ReadLine();


            //Car myNewCar = new Car();

            //myNewCar.Make = "Oldsmobile";
            //myNewCar.Model = "Cutlass Supreme";
            //myNewCar.Year = 1986;
            //myNewCar.Color = "Silver";

            //Console.WriteLine("{0} - {1} - {2}",
            //    myNewCar.Make,
            //    myNewCar.Model,
            //    myNewCar.Color);

            ////double marketValueOfCar = determineMarketValue(myNewCar);

            //Console.WriteLine("Car's value: {0:C}", myNewCar.DetermineMarketValue());


            //Car myCar = new Car();
            //Car myOtherCar = myCar;  // copied reference, didn't create a new object
            //Car myThirdCar = new Car("Ford", "Escape", 2005, "White");

            Car myCar = new Car();
            myCar.Make = "BMW";
            myCar.Model = "745li";
            myCar.Color = "Black";
            myCar.Year = 2005;

            printVehicleDetails(myCar);

            Truck myTruck = new Truck();

            myTruck.Make = "Ford";
            myTruck.Model = "F950";
            myTruck.Year = 2006;
            myTruck.Color = "Black";
            myTruck.TowingCapacity = 1200;

            printVehicleDetails(myTruck);

            Console.ReadLine();
        }

        private static void printVehicleDetails(Vehicle vehicle)
        {
            Console.WriteLine("Here are the vehicle's details: {0}",
                vehicle.FormatMe());
        }

        //private static double determineMarketValue(Car _car)
        //{
        //    double carValue = 100.0;
        //    // do something
        //    return carValue;
        //}
    }

    abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public abstract string FormatMe();

    }

    class Car :Vehicle
    {
        //public Car(string make, string model, int year, string color)
        //{
        //    Make = make;
        //    Model = model;
        //    Year = year;
        //    Color = color;
        //}

        public override string FormatMe()
        {
            return String.Format("{0} -- {1} -- {2} -- {3}",
                this.Make,
                this.Model,
                this.Color,
                this.Year);
        }

        //public double DetermineMarketValue()
        //{
        //    double carValue;

        //    if (this.Year > 1990)
        //        carValue = 10000.0;
        //    else
        //        carValue = 2000.0;

        //    return carValue;

        //}
    }

    class Truck: Vehicle
    {
        public int TowingCapacity { get; set; }

        public override string FormatMe()
        {
            return String.Format("{0} - {1} - {2} Towing units",
                this.Make,
                this.Model,
                this.TowingCapacity);
        }
    }

}
