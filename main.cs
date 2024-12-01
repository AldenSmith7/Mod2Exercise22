using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of hours for the move: ");
        double hours = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter number of miles for the move: ");
        double miles = Convert.ToDouble(Console.ReadLine());
        double baseRate = 200.0;
        double hourlyRate = 150.0;
        double perMileRate = 2.0;
        double totalFee = baseRate + (hours * hourlyRate) + (miles * perMileRate);
        string formattedTotalFee = totalFee.ToString("C", CultureInfo.GetCultureInfo("en-US"));
        Console.WriteLine("For a move taking {0} hours and going {1} miles the estimate is {2}", hours, miles, formattedTotalFee);
    }
}