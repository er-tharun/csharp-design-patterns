using SIngleton.Pattern.Models;

namespace SIngleton.Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton firstObj = Singleton.GetInstance();
            Singleton secondObj = Singleton.GetInstance();
            Singleton thirdObj = Singleton.GetInstance();
            Singleton fourthObj = Singleton.GetInstance();
            Singleton fifthObj = Singleton.GetInstance();

            var obj1 = Task.Run(Singleton.GetInstance).Result;
            var obj2 = Task.Run(Singleton.GetInstance).Result;
            var obj3 = Task.Run(Singleton.GetInstance).Result;

            if(obj1 == obj2 && obj2 == obj3 && obj3 == obj1)
                Console.WriteLine("Multithreaded Singleton objects created successfully");
            else
                Console.WriteLine("Failed to create Multithreaded singleton objects");
            if (firstObj == secondObj && secondObj == thirdObj && thirdObj == fourthObj && fourthObj ==fifthObj && fifthObj == firstObj)
                Console.WriteLine("Singleton objects created successfully");
            else
                Console.WriteLine("Failed to create singleton objects");
        }
    }
}
