#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace DailyRate
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }

        public void run()
        {
            double dailyRate = readDouble("Enter your daily rate: ");
            int noOfDays = readInt("Enter the number of days: ");
            writeFee(calculateFee(dailyRate, noOfDays));
        }

        private double readDouble(string v)
        {
            Console.Write(v);
            string line = Console.ReadLine();
            return double.Parse(line);
        }

        private void writeFee(double p)
        {
            Console.WriteLine("The consultant's fee is: " + p * 1.1);
        }

        private double calculateFee(double dailyRate, int noOfDays)
        {
            Console.WriteLine("calculatefee using two optional parameters");
            return dailyRate * noOfDays;
        }

        private double calculatefee(double dailyRate = 500.0)
        {
            Console.WriteLine("calculatefee using one optional parameter");
            int defaultNoOfDays = 1;
            return dailyRate * defaultNoOfDays;
        }

        private int readInt(string p)
        {
            Console.Write(p);
            string line = Console.ReadLine();
            return int.Parse(line);
        }

    }
}
