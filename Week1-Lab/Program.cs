using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //constructor calling
            Car car1 = new Car(2022, "Civic", 50000, true);
            Car car2 = new Car(2023, "Camrey", 60000, true);
            Car car3 = new Car(2024, "3Series", 70000, true);
            Car car4 = new Car(2025, "Truck", 80000, true);
            Car car5 = new Car(2025, "Sedan", 70000, true);
            //displaying cars
            Console.WriteLine(car1.ToString());
            Console.WriteLine(car2.ToString());
            Console.WriteLine(car3.ToString());
            Console.WriteLine(car4.ToString());
            Console.WriteLine(car5.ToString());
            //To get input of car details from user
            car1.getDetails();
            Console.WriteLine(car1.ToString());
            car2.getDetails();
            Console.WriteLine(car2.ToString());
            car3.getDetails();
            Console.WriteLine(car3.ToString());
            car4.getDetails();
            Console.WriteLine(car4.ToString());
            car5.getDetails();
            Console.WriteLine(car5.ToString());


        }
    }
}
