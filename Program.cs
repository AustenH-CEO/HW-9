// This program will focus on creating and returning objects from methods
// Austen Hernandez
// 5/21/26

using CarFile;

namespace ProgramFile
{
    public class Program
    {
        public static void Main()
        {
            var UserModel = CreateCar().model;
            Console.WriteLine("Car Created: " + UserModel);
        }
        static Car CreateCar()
        {
            Console.WriteLine("Enter Car model: ");
            string input = Console.ReadLine();
            Car car1 = new Car(input, 0);
            return car1;
        }
    }
}