using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Lab
{
    internal class Car
    {
        //Fields or attributes in car class
        private int year;
        private string model;
        private bool isDrivable;
        private double price;
        //constructor with arguments
        public Car(int year,string model,double price, bool isDrivable = true)
        {
            this.year = year;
            this.model = model;
            this.price = price;
            this.isDrivable = isDrivable;
        }
        //using ToString method for display
        public override string ToString()
        {
            return $"The car is of year :{year}, model :{model}, price :{price} and is Drivable";
        }
        //To get input from user about cars
        public void getDetails()
        {
            Console.WriteLine("Enter the year of car Launch:");
            this.year = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Model of car:");
            this.model = Console.ReadLine();
            Console.WriteLine("Enter the price of car:");
            this.price = double.Parse(Console.ReadLine());
        }
    }
}
