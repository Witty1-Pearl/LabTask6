using System;

namespace PolymorphismTest
{
    class Program
    {
        static void Main(string[] args)
        {
            OvernightPackage overnightPackage = new OvernightPackage("Enugu", "Bayelsa", 1000M);
           
            TwoDayPackage twoDayPackage = new TwoDayPackage("Ibadan", "Akwa-Ibom", 500M);

            Package[] packages = new Package[2] { overnightPackage, twoDayPackage };

            Console.WriteLine("\n Packages processed polymorphically...\n");
            

            foreach (Package package in packages)
            {
                Console.WriteLine($"{package}\n");
                Console.WriteLine($"Shipping Cost: {package.CalculateCost():C}");
            }
        }

    }
}
