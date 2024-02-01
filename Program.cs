// Ishak
using System.ComponentModel.Design;

namespace GA_Condition_Ishak
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //Console.WriteLine("Checking conditions!");

            //int number = 6;

            //if (number == 5)
            //{
            //    Console.WriteLine("Number is equal to 5");
            //}
            //else if (number > 5)

            //{
            //    Console.WriteLine("Numbe is greater than 5");
            //}
            //else
            //{
            //    Console.WriteLine("Number is less than 5");
            //}
            int temperature = 75;
            string weatherInfo = "";

            if (temperature > 180) 
            {
                weatherInfo = "It's a hot day!";
            }
            else if (temperature > 60) 
            {
                weatherInfo = "It's a pleasant day.";
            }
            else
            {
                weatherInfo = "It's a bit chilly.";
            }

            Console.WriteLine(weatherInfo);
                
            


        }

    }
}
