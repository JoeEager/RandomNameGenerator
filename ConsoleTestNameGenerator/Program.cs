using System;
using RandomNameGenerator;

namespace ConsoleTestNameGenerator
{
    class Program
    {
        static void Main()
        {
            RandomNameGenerator.RandomNameGenerator NameGenerator = new RandomNameGenerator.RandomNameGenerator();
            
            Console.WriteLine("Test Application for RandomNameGenerator Library \n");

            Console.WriteLine("Generating a random male name: {0} {1}", NameGenerator.GetRandomMaleFirstName(), NameGenerator.GetRandomLastName());

            Console.WriteLine("Generating a male first name in the 30th percentile: {0}", NameGenerator.GetRandomMaleFirstName(30));

            Console.WriteLine("Generating a male first name in the 90th percentile: {0} \n", NameGenerator.GetRandomMaleFirstName(90));

            Console.WriteLine("Generating a random female name: {0} {1}", NameGenerator.GetRandomFemaleFirstName(), NameGenerator.GetRandomLastName());

            Console.WriteLine("Generating a female first name in the 30th percentile: {0}", NameGenerator.GetRandomFemaleFirstName(30));

            Console.WriteLine("Generating a female first name in the 90th percentile: {0}", NameGenerator.GetRandomFemaleFirstName(90));

            Console.WriteLine("\nPress any key to exit ....");

            Console.Read();


        }
    }
}
