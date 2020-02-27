using System;
//given a number of seconds, print how many years old that is for each planet
namespace day4problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            double secInput = GetSeconds();
            CalculateYears(secInput);
        }

        static double GetSeconds()
        {
            Console.WriteLine("How many seconds should be measured?");
            double secInput = Convert.ToDouble(Console.ReadLine());
            return secInput;
        }

        static double CalculateYears(double secs)
        {
            double days = secs / 60 / 24;
            
            double earthYears = days / 365.26;
            double mercuryYears = days / 87.97;
            double venusYears = days / 224.7;
            double marsYears = days / 686.98;
            double jupiterYears = days / 4332.82;
            double saturnYears = days / 10755.7;
            double uranusYears = days / 30687.15;
            double neptuneYears = days / 60190.03;
            double plutoYears = days / 90533;

            double[] arr = {earthYears, mercuryYears, venusYears, marsYears, jupiterYears, saturnYears, uranusYears, neptuneYears, plutoYears};
            string[] planetName = {"Earth", "Mercury", "Venus", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune", "Pluto"};
            for(int i = 0; i < 9; i++)
            {
                Console.WriteLine("That many seconds is equal to " + arr[i] + " " + planetName[i] + " years.");
            }
            return arr[0];
        }
    }
}
